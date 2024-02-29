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
    public partial class PasswordEntryChild : Form
    {
        public PasswordEntryChild()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPasswordChildSubmit_Click(object sender, EventArgs e)
        {
            string userName = "Kid";
            string passWord = "MyDadIsAwesome";
            RewardEntry rewardEntry = new RewardEntry();

            if (txtChildName.Text == userName && txtChildPassword.Text == passWord)
            {
                rewardEntry.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Incorrect entry. Your user name is '{userName}' and your password is '{passWord}'.\nYour loving dad.  :)");
                txtChildPassword.Clear();
                txtChildName.Clear();
            }
        }
    }
}
