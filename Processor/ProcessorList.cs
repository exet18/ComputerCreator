using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService
{
    public class ProcessorList
    {
        private List<Processor> _processors = new List<Processor>();    
        public void AddProcessor(string name,int price,string socket,string company)
        {
            Processor cpu = new Processor();
            cpu.ProcessorName = name;
            cpu.ProcessorPrice = price;
            cpu.ProcessorSocket = socket;
            cpu.ProcessorCompany = company;
            _processors.Add(cpu);
        }
        public List<string> GetProcessors()
        {
            List<string> list = new List<string>();
            foreach (Processor cpu in _processors)
            {
                list.Add(cpu.ProcessorName);
            }
            return list;
        }
        public string GetInfoByProcessor(string name)
        {
            string result = "";
            foreach(Processor cpu in _processors)
            {
                if(cpu.ProcessorName == name)
                {
                    result = $" [PROCESSOR] \n \n Company: {cpu.ProcessorCompany} \n Name: {cpu.ProcessorName} \n Price: {cpu.ProcessorPrice} \n Socket: {cpu.ProcessorSocket}";
                }
            }
            return result;
        }
        public Processor GetProcessor(string name)
        {
            foreach (Processor cpu in _processors)
            {
                if (cpu.ProcessorName == name)
                {
                    return cpu;
                }
            }
            return null;
        }
    }
}
