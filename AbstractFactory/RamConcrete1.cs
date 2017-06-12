using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RamConcrete1:RamAbstract
    {
        public override string RamTur
        {
            get { return "bu ram türü 'RamConcrete1' dir"; }
        }
        public override void RamIslem()
        {
            Console.WriteLine("RamConcrete1 birleştirildi");
        }
    }
}
