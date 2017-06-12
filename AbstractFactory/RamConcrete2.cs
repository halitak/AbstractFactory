using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RamConcrete2:RamAbstract
    {
        public override string RamTur
        {
            get { return "Bu ram turu 'RamConcrete2' dir"; }
        }
        public override void RamIslem()
        {
            Console.WriteLine("RamConcrete2 birleştirildi");
        }
    }
}
