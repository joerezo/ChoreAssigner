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
    public partial class RewardEntry : Form
    {
        public RewardEntry()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EventListStorage.SubmittedRewards.AddFirst(txtRewardSubmission.Text,"",txtChildName.Text);
            dGVSubmittedRewardsSubmission.DataSource = EventListStorage.SubmittedRewards.MakeList();
            MessageBox.Show($"'{txtRewardSubmission.Text}' was succesfully submitted at {DateTime.Now} by {txtChildName.Text}");
            txtChildName.Clear();
            txtRewardSubmission.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void RewardEntry_Load(object sender, EventArgs e)
        {
            dGVSubmittedRewardsSubmission.DataSource=EventListStorage.SubmittedRewards.MakeList();
            dGVSubmittedRewardsSubmission.Columns["Status"].Visible=false;
        }
    }
}
