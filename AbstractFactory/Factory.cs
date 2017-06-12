using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Factory
    {
        private PcFactory pc_Factory;
        private RamAbstract ram;
        private HddAbstract hdd;
        public Factory(PcFactory pc_Factory) {
            this.pc_Factory = pc_Factory;
            ram = pc_Factory.CreateRam();
            hdd = pc_Factory.CreateHdd();
        }
        public void Birlestir() {
            Console.WriteLine(ram.RamTur);
            ram.RamIslem();
            Console.WriteLine(hdd.HddTur);
            hdd.HddIslem();
        }
    }
}
