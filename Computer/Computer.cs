using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService
{
    public class Computer
    {
        private string _name;
        private Processor _processor;
        private Videocard _videocard;
        private int _price;
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetProcessor(Processor cpu)
        {
            _processor = cpu;
            _price += cpu.ProcessorPrice;
        }
        public void SetVideocard(Videocard gpu)
        {
            _videocard = gpu;
            _price += gpu.VideocardPrice;
        }
        public string GetName()
        {
            return _name;
        }
        public Processor GetProcessor()
        {
            return _processor;
        }
        public Videocard GetVideocard()
        {
            return _videocard;
        }
        public int GetPrice()
        {
            return _price;
        }

    }
}
