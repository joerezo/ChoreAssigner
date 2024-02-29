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
    public partial class PasswordEntryAdult : Form
    {
        public PasswordEntryAdult()
        {
            InitializeComponent();
        }

        private void btnPasswordAdultSubmit_Click(object sender, EventArgs e)
        {
            string userName = "Parent";
            string password = "Parent";
            Tasker tasker = new Tasker();
            if(txtParentName.Text==userName && txtParentPassword.Text == password)
            {
                tasker.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect entry");
                txtParentName.Clear();
                txtParentPassword.Clear();
            }
            
        }
    }
}
