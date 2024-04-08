using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_domu
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string description) : base(name)
        {
            this.decoration = description;
        }

        public override string Description
        {
            get
            {
                return base.Description + " Widzisz tutaj " + decoration + ".";
            }
        }
    }
}
