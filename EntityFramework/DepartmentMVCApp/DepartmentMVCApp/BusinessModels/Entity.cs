using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentMVCApp.BusinessModels
{
    public class Entity
    {
        public Guid ID { get; set; }

        public Entity()
        {
            this.ID = Guid.NewGuid();
        }
    }
}