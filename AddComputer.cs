using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerService
{
    public partial class AddComputerForm : Form
    {
        private ProcessorList _processors;
        private VideocardList _videocards;
        private ComputerList _computerlist;
        public AddComputerForm()
        {         
            InitializeComponent();
            _videocards = new VideocardList();
            _processors = new ProcessorList();
            _computerlist = new ComputerList();
            _videocards.AddVideocard("GTX 1650", 1200, "2400", "Nvidia");_videocards.AddVideocard("RTX 3090", 2000, "8000", "Nvidia");
            _videocards.AddVideocard("RTX 1870", 1000, "5000", "Nvidia");_videocards.AddVideocard("GTX 2090", 800, "4000", "Nvidia");
            foreach (Videocard gpu in _videocards.GetVideocards())
            {
                list_gpu.Items.Add(gpu.VideocardName);
            }
            _processors.AddProcessor("I5 7500K", 700, "G5", "Intel"); _processors.AddProcessor("Ryzen 5700", 1000, "G4", "Amd"); 
            _processors.AddProcessor("I9 9600I", 2200, "G7", "Intel"); _processors.AddProcessor("I7 9500H", 1500, "G2", "Intel");
            foreach (Processor cpu in _processors.GetProcessors())
            {
                listcpu.Items.Add(cpu.ProcessorName);
            }
        }

        private void btn_getInfo_Click(object sender, EventArgs e)
        {
            if (listcpu.Text != "")
            {
                MessageBox.Show(_processors.GetInfoByProcessor(listcpu.Text));
            }
            else
            {
                MessageBox.Show("Select processor!");
            }
        }

        private void get_info_videocard_Click(object sender, EventArgs e)
        {
            if (list_gpu.Text != "")
            {
                MessageBox.Show(_videocards.GetInfoByVideocard(list_gpu.Text));
            }
            else
            {
                MessageBox.Show("Select videocard!");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pc_create_Click(object sender, EventArgs e)
        {
            if(inp_name.Text != "" && list_gpu.Text != "" && listcpu.Text != "")
            {
                Computer pc = new Computer();
                pc.SetName(inp_name.Text);
                pc.SetProcessor(_processors.GetProcessor(listcpu.Text));
                pc.SetVideocard(_videocards.GetVideocard(list_gpu.Text));
                _computerlist.AddComputer(pc);
                MessageBox.Show("Computer add!");
                Reset();
            }
            else
            {
                MessageBox.Show("Enter data!");
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if(inp_name.Text != "")
            {
                MessageBox.Show(_computerlist.GetComputerByName(inp_name.Text));
            }
            else
            {
                MessageBox.Show("Enter computer name");
            }
        }
        private void Reset()
        {
            listcpu.ResetText();
            list_gpu.ResetText();
            inp_name.ResetText();
        }
    }
}
