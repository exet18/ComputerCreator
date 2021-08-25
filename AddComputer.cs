
using System;
using System.Collections.Generic;
using System.Data;
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
            DataBaseQuery data = new DataBaseQuery();

            foreach (DataRow row in data.GetProcessors().Rows)
            {
                _processors.AddProcessor(row.Field<string>("name"), row.Field<int>("price"), row.Field<string>("socket"), row.Field<string>("company"));
            }
            listcpu.Items.AddRange(_processors.GetProcessors().ToArray());
            foreach (DataRow row in data.GetVideocards().Rows)
            {
                _videocards.AddVideocard(row.Field<string>("name"), row.Field<int>("price"), row.Field<string>("ghz"), row.Field<string>("company"));
            }
            list_gpu.Items.AddRange(_videocards.GetVideocards().ToArray());
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
