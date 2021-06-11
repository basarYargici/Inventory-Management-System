using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    class UserType : IEntity
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
