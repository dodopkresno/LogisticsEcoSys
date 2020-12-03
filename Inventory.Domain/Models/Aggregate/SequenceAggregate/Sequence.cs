using Inventory.Domain.Common;
using Inventory.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Domain.Models.Aggregate.SequenceAggregate
{
    public class Sequence : BaseEntity, IAggregateRoot
    {
        public Guid sequenceId { get; set; }
        public string code { get; set; }
        public string prefix { get; set; } //2019 %year(4digit), %Y(2digit), %month(number)
        public string prefixStr { get; set; } //>/< PR Text Output prefix : PR-2020 --> >%[string]
        public string suffix { get; set; }
        public string suffixStr { get; set; }
        public bool usePadding { get; set; }
        public string padding { get; set; } //add some '0' or '00' on the left of next number
        public int increment { get; set; }
        public int nextNumber { get; set; }

        private readonly List<SequenceDetail> dateRanges = new List<SequenceDetail>();
        public IReadOnlyCollection<SequenceDetail> DateRange => dateRanges.AsReadOnly();

        public string sequenceName()
        {
            char[] delimiter = new char[] { '%' };
            string[] oStringPref = prefix.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] oStringPS = prefixStr.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] oStringSuf = suffix.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] oStringSS = suffixStr.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            string objPrefix = "";
            string resultCode, setPadding;

            foreach (var ostr in oStringPref)
            {
                if (ostr == "year")
                    objPrefix += DateTime.Now.Year.ToString();
                if (ostr == "y")
                    objPrefix += DateTime.Now.Year.ToString("yy");
                if (ostr == "month")
                    objPrefix += DateTime.Now.Month.ToString();
            }

            if (oStringPS[0] == ">")
                objPrefix = oStringPS[1] + objPrefix;

            if (oStringPS[0] == "<")
                objPrefix = objPrefix + oStringPS[1];

            string objSuffix = "";
            foreach (var ostr in oStringSuf)
            {
                if (ostr == "year")
                    objSuffix += DateTime.Now.Year.ToString();
                if (ostr == "y")
                    objSuffix += DateTime.Now.Year.ToString("yy");
                if (ostr == "month")
                    objSuffix += DateTime.Now.Month.ToString();
            }

            if (oStringSS[0] == ">")
                objSuffix = oStringSS[1] + objSuffix;
            if (oStringSS[0] == "<")
                objSuffix = objSuffix + oStringSS[1];

            setPadding = !usePadding ? "" : padding;

            if (!DateRange.Any(i => i.sequenceId == sequenceId && (DateTime.Now >= i.from && DateTime.Now < i.to)))
            {
                var nextNum = DateRange.FirstOrDefault(i => i.sequenceId == sequenceId && (DateTime.Now >= i.from && DateTime.Now < i.to));
                resultCode = objPrefix + setPadding + nextNum.ToString() + objSuffix;
                nextNum.nextSequence(nextNumber);
            }

            resultCode = objPrefix + setPadding + nextNumber.ToString() + objSuffix;

            return resultCode;
        }

        public void _next()
        {
            nextNumber += increment;
        }
    }
}
