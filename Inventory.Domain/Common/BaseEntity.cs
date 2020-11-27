using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Common
{
    public class BaseEntity
    {
        public string name { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }

        protected BaseEntity()
        {
            LastModified = DateTime.Now;
        }

        public void setObjStatus(string userBy, bool oStatus = true)
        {
            IsActive = !oStatus ? false : true;
            LastModifiedBy = userBy;
        }
    }
}
