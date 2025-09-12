using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Textbox1.Text;
            string email = label2.Text;
            string password = label3.Text;
            int characters = password.Length;
            if (characters >= 16)
            {
                MessageBox.Show("Signing up...");
            }
            else
            {
               DialogResult result =  MessageBox.Show("Password not strong enough", "Would you like to retry?",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Retrying....");

                }
                else
                {
                    MessageBox.Show("Exit");
                }
         
            }
        }
    }
}
