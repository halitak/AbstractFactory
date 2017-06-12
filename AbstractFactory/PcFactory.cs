using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class PcFactory
    {
        public abstract HddAbstract CreateHdd();
        public abstract RamAbstract CreateRam();
    }
}
