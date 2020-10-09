using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is a required field.")]
        [MaxLength(15, ErrorMessage = "Maximum length is 15 characters")]
        public string name { get; set; }

        [Required(ErrorMessage = "Ratio is a required field.")]
        public float ratio { get; set; }

        public UomCategory UomCategory { get; set; } //Many2One Comodel --> UoMCategory

        public Category()
        {
            ratio = 1;
        }
    }
}
