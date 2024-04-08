using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_domu
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }
        public string HidingPlaceName { get; private set;}
        public override string Description
        {
            get
            {
                return base.Description + " Ktoś może ukrywać sie " + HidingPlaceName + ".";
            }
        }
    }
}
