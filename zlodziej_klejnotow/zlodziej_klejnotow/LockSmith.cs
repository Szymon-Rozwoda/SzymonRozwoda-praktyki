using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlodziej_klejnotow
{
     class LockSmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents , owner);
        }
        private string writtenDownCombination = null;
        public void WriteDownCombination(string combinaton)
        {
            writtenDownCombination = combinaton;
        }
        virtual public void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
