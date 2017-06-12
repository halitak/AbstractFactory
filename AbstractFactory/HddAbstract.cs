using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class HddAbstract
    {
        public abstract string HddTur { get; }
        public abstract void HddIslem();
    }
}
