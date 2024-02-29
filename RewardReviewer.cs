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
    public partial class RewardReviewer : Form
    {
        public RewardReviewer()
        {
            InitializeComponent();
        }

        private void RewardReviewer_Load(object sender, EventArgs e)
        {
            dGVSuggestedRewards.DataSource=EventListStorage.SubmittedRewards.MakeList();
            dGVSuggestedRewards.Columns["Status"].Visible = false;
            dGVApprovedReward.DataSource=EventListStorage.EligibleRewards.MakeList();
            dGVApprovedReward.Columns["Status"].Visible = false;
        }

        private void btnSuggestRewardApproveSelected_Click(object sender, EventArgs e)
        {
            int index=dGVSuggestedRewards.CurrentRow.Index;
            EventList.CopySingleElement(index,EventListStorage.SubmittedRewards,EventListStorage.EligibleRewards);
            dGVApprovedReward.DataSource = EventListStorage.EligibleRewards.MakeList();
        
        }

        private void btnApproveAll_Click(object sender, EventArgs e)
        {
            EventList.MakeCopy(EventListStorage.SubmittedRewards, EventListStorage.EligibleRewards);
            dGVApprovedReward.DataSource = EventListStorage.EligibleRewards.MakeList();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveAllRewards_Click(object sender, EventArgs e)
        {
            EventListStorage.EligibleRewards.DeleteAll();
            dGVApprovedReward.DataSource = EventListStorage.EligibleRewards.MakeList();
        }

        private void btnApprovedRewardsRemoveSelected_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                index = dGVApprovedReward.CurrentRow.Index;
            }
            catch (Exception ex) { }
            EventListStorage.EligibleRewards.RemoveAnyWhere(index+1);//Plus 1 is necessary because displayed as a list but removing a linked list node
            dGVApprovedReward.DataSource = EventListStorage.EligibleRewards.MakeList();
        }
    }
}
