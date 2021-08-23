using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService
{
    public class ComputerList
    {
        private List<Computer> _computers = new List<Computer>();
        public void AddComputer(Computer pc)
        {
            _computers.Add(pc);
        }
        public List<Computer> GetComputers()
        {
            return _computers;
        }
        public string GetComputerByName(string name)
        {
            string result = string.Empty;
            bool ch = true;
            foreach(Computer pc in _computers)
            {
                if(pc.GetName() == name)
                {
                    result = $" Name: {pc.GetName()} \n Processor: {pc.GetProcessor().ProcessorName} \n Videocard: {pc.GetVideocard().VideocardName} \n Price: {pc.GetPrice()}";
                    ch = false;
                }
            }
            if(ch == true)
            {
                return "I dont find this computer";
            }
            else
            {
                return result;
            }        
        }
    }
}
