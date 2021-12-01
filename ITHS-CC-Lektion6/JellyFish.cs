using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Lektion6
{
    public class JellyFish : Animal
    {
        public JellyFish(string name) : base(name) { }

        public override void Speak()
        {
           throw new NotSupportedException();
        }
    }
}
