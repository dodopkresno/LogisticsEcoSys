using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class MovementRule : BaseEntity
    {
        public Guid mruleId { get; set; }
        public bool cmaxWeightProduct { get; set; }
        public bool cmaxHeightProduct { get; set; }
        public bool cmaxWeightLocation { get; set; }
        public bool cProductCategory { get; set; } //diambil yang sama
        public bool putRangeDateIn { get; set; } //nilai range yang digunakan untuk mengatur batasan dalam 1 lokasi dengan tanggal berbeda dalam 1 range value ini (Putaway)
        public int valueDateIn { get; set; }
        public bool putRageExpired { get; set; } //nilai range yang digunakan untuk mengatur batasan dalam 1 lokasi dengan tanggal berbeda dalam 1 range value ini (Putaway)
        public int valueDateExpired { get; set; }
        public bool pickFIFO { get; set; } //Picking
        public bool pickFEFO { get; set; } //Picking
    }
}
