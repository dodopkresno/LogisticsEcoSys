using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Domain.Models
{
    public class UomCategory : BaseEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is a required field.")]
        [MaxLength(25, ErrorMessage = "Maximum length is 25 characters")]
        public string name { get; set; }

        [Required(ErrorMessage = "Measure type is a required field.")]
        public MeasureType MeasureType { get; set; }
        //measeuretype
    }
}
