using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingEFApp
{
   public class Entity
    {
        public Guid ID
        {
            get; set;
        }
        public Entity()
        {
            this.ID = Guid.NewGuid();
        }
    }
}
