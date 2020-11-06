using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Permission : BaseEntity
    {
        [Column("PermitId")]
        public Guid Id { get; set; }
        public string RoleId { get; set; }
        public string MenuId { get; set; }
        public bool canCreate { get; set; }
        public bool canUpdate { get; set; }
        public bool canDelete { get; set; }
    }
}
