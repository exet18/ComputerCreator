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
        public Computer GetComputerByName(string name)
        {
            foreach(Computer pc in _computers)
            {
                if(pc.GetName() == name)
                {
                    return pc;
                }
            }
            return null;
        }
    }
}
