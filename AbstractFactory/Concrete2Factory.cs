using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Concrete2Factory:PcFactory
    {
        public override HddAbstract CreateHdd()
        {
            return new HddConcrete2();
        }
        public override RamAbstract CreateRam()
        {
            return new RamConcrete2();
        }
    }
}
