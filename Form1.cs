using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreAssigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStatusParent_Click(object sender, EventArgs e)
        {
            PasswordEntryAdult passwordEntryAdult = new PasswordEntryAdult();
            passwordEntryAdult.Show();
        }

        private void btnStatusChild_Click(object sender, EventArgs e)
        {
            PasswordEntryChild passwordEntryChild = new PasswordEntryChild();
            passwordEntryChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }
    }
}
