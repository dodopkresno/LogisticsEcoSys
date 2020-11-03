using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Inventory.Domain.Common
{
    public abstract class Enumeration : IComparable
    {
        private string _name { get; set; }
        private int _id { get; set; }

        protected Enumeration(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name;  }
        }
        // public override string ToString() => Name;
        public override string ToString()
        {
            return Name;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }
        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = _id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }
        // public override int GetHashCode() => Id.GetHashCode();
        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
        public static int AbsoluteDifference(Enumeration firstValue, Enumeration secondValue)
        {
            var absoluteDifference = Math.Abs(firstValue.Id - secondValue.Id);
            return absoluteDifference;
        }
        public static T FromValue<T>(int value) where T : Enumeration
        {
            var matchingItem = Parse<T, int>(value, "value", item => item.Id == value);
            return matchingItem;
        }
        public static T FromDisplayName<T>(string displayName) where T : Enumeration
        {
            var matchingItem = Parse<T, string>(displayName, "display name", item => item.Name == displayName);
            return matchingItem;
        }
        private static T Parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);

            if (matchingItem == null)
                throw new InvalidOperationException($"'{value}' is not a valid {description} in {typeof(T)}");

            return matchingItem;
        }
        //public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);
        public int CompareTo(object obj)
        {
            return Id.CompareTo(((Enumeration)obj).Id);
        }
    }
}
