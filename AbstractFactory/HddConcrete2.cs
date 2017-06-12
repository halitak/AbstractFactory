using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HddConcrete2:HddAbstract
    {
        public override string HddTur
        {
            get { return "bu hdd nin türü 'HddConcrete2' dir"; }
        }
        public override void HddIslem()
        {
            Console.WriteLine("HddConcrete2 birleştirildi");
        }
    }
}
