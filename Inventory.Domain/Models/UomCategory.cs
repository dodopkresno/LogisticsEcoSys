using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class UomCategory : BaseEntity
    {
        private string _name;
        private int _measureTypeId;
        public UomCategory(string name, int MeasureTypeId)
        {
            this._name = name;
            this._measureTypeId = MeasureTypeId;
        }

        public Guid Id { get; set; }
        public int intest { get; set; }

        public string name { get; private set; }

        public MeasureType MeasureType { get; private set; }

    }
}
