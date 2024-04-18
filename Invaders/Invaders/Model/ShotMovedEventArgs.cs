using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders.Model
{
    class ShotMovedEventArgs
    {
        public Shot Shot { get;private set; }
        public bool isDisappeared { get; private set; }
        public ShotMovedEventArgs(Shot shot, bool disappeared) 
        {
            Shot = shot;
            isDisappeared = disappeared;
        }
    }
}
