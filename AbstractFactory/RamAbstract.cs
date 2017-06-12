using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class RamAbstract
    {
        public abstract string RamTur { get; }
        public abstract void RamIslem();
    }
}
