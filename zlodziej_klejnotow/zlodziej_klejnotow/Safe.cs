using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlodziej_klejnotow
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombinations = "12345";
        public Jewels Open(string combination)
        {
            if(combination == safeCombinations)
            {
                return contents;
            }
            else
            {
                return null;
            }
        }
        public void PickLock(LockSmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombinations);
        }
    }
}
