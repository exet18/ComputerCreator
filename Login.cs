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
    public partial class Login : Form
    {
        private string _name;
        private string _lastname;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (inp_name.Text == "" || inp_last.Text == "")
            {
                MessageBox.Show("Enter your data!");
            }
            else
            {
                AddComputerForm form = new AddComputerForm();
                _name = inp_name.Text;
                _lastname = inp_last.Text;
                this.Hide();
                form.Show();
            }         
        }
        private void btn_quit_Click(object sender, EventArgs e)
        {   
            MessageBox.Show(_name);
            this.Close();
        }
    }
}
