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
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetProcessor(Processor cpu)
        {
            _processor = cpu;
        }
        public void SetVideocard(Videocard gpu)
        {
            _videocard = gpu;
        }
        public string GetName()
        {
            return _name;
        }

    }
}
