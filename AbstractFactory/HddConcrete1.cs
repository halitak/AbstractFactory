using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HddConcrete1:HddAbstract
    {
        public override string HddTur
        {
            get { return "bu hdd nin türü 'HddConcrete1' dir"; }
        }
        public override void HddIslem()
        {
            Console.WriteLine("HddConcrete1 birleştirildi");
        }
    }
}
