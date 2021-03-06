using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerService
{
    class VideocardList
    {
        private List<Videocard> _videocards = new List<Videocard>();
        public void AddVideocard(string name, int price, string ghz, string company)
        {
            Videocard gpu = new Videocard();
            gpu.VideocardName = name;
            gpu.VideocardPrice = price;
            gpu.VideocardGhz = ghz;
            gpu.VideocardCompany = company;
            _videocards.Add(gpu);
        }
        public List<string> GetVideocards()
        {
            List<string> list = new List<string>();
            foreach (Videocard gpu in _videocards)
            {
                list.Add(gpu.VideocardName);
            }
            return list;
        }
        public string GetInfoByVideocard(string name)
        {
            string result = "";
            foreach(Videocard gpu in _videocards)
            {
                if(gpu.VideocardName == name)
                {
                    result = $" [VIDEOCARD] \n Company: {gpu.VideocardCompany} \n Name: {gpu.VideocardName} \n Price: {gpu.VideocardPrice} \n Ghz: {gpu.VideocardGhz}";
                }
            }
            return result;
        }
        public Videocard GetVideocard(string name)
        {
            foreach (Videocard gpu in _videocards)
            {
                if (gpu.VideocardName == name)
                {
                    return gpu;
                }
            }
            return null;
        }
    }
}

