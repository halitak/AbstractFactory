using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Concrete1Factory:PcFactory
    {
        public override HddAbstract CreateHdd()
        {
            return new HddConcrete1();
        }
        public override RamAbstract CreateRam()
        {
            return new RamConcrete1();
        }
    }
}
