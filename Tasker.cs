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
    public partial class Tasker : Form
    {
        public Tasker()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnSpecialCircumstance_Click(object sender, EventArgs e)
        {
            if (richTextBoxSpecialCircumstance.Text.Trim() != "")
            {
                EventListStorage.ToDo.AddFirst(richTextBoxSpecialCircumstance.Text, "", "");
                richTextBoxSpecialCircumstance.Clear();
                dGV_ToDo.DataSource = EventListStorage.ToDo.MakeList();
            }
            else
            {
                MessageBox.Show("Please enter an actual Special Circumstance");
            }
        }

        private void btnSelectChildren_Click(object sender, EventArgs e)
        {
            //SelectChildren selectChildren = new SelectChildren();
            //selectChildren.Show();

            AddNames addNames = new AddNames();
            addNames.Show();
        }

        private void Tasker_Load(object sender, EventArgs e)
        {
            var bindingList = new BindingList<Event>(EventListStorage.Storage.MakeList());

            dGVDaily.DataSource = bindingList;
            dGVDaily.Columns["Person"].Visible = false;
            dGVDaily.Columns["Status"].Visible = false;

            dGVOtherChores.DataSource = EventListStorage.OtherChores.MakeList();
            dGVOtherChores.Columns["Person"].Visible = false;
            dGVOtherChores.Columns["Status"].Visible = false;

            dGV_ToDo.DataSource=EventListStorage.ToDo.MakeList();
            dGV_ToDo.Columns["Status"].Visible=false;
            dGV_ToDo.Columns["Person"].Visible = false;
        }

        private void dGVApprovedReward_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDailyMoveAll_Click(object sender, EventArgs e)
        {
            EventList.MakeCopy(EventListStorage.Storage, EventListStorage.ToDo);
            dGV_ToDo.DataSource = EventListStorage.ToDo.MakeList();
        }

        private void btnDailyMoveSelected_Click(object sender, EventArgs e)
        {
            int rowIndex = dGVDaily.CurrentCell.RowIndex;
            EventList.CopySingleElement(rowIndex, EventListStorage.Storage, EventListStorage.ToDo);

            ///Need To Write a Delegate that will find the position of the element in a DGV. Go to that element in the linked List to be copied, and then add that element to 
            /////the end of the desired linked list.
            ///Should look like this CopyElement(index, copy link list, destination link list)
            //DataStorage.ChoreListToDo.ChoreToDo.AddLast( DataStorage.ChoreListRoutine.RoutineChoreList.ElementAt(dGVDaily.CurrentCell.RowIndex));
            dGV_ToDo.DataSource = EventListStorage.ToDo.MakeList();
        }

        private void btnToDoDeleteAll_Click(object sender, EventArgs e)
        {
            EventListStorage.ToDo.DeleteAll();
            dGV_ToDo.DataSource = EventListStorage.ToDo.MakeList();
        }

        private void btnToDoDeleteSelected_Click(object sender, EventArgs e)
        {
            int rowIndex=0;
            try
            {
                rowIndex = dGV_ToDo.CurrentCell.RowIndex + 1;//LinkedList is index 1 while List is 0
            }
            catch (Exception ex) { MessageBox.Show($"Error Message: {ex.Message} \nGo find an MSSA person to tell you about Try and Catch Blocks."); }
                EventListStorage.ToDo.RemoveAnyWhere(rowIndex);
            dGV_ToDo.DataSource = EventListStorage.ToDo.MakeList();
        }

        private void BtnMoveSelectedOther_Click(object sender, EventArgs e)
        {
            int rowindex=dGVOtherChores.CurrentCell.RowIndex;
            EventList.CopySingleElement(rowindex,EventListStorage.OtherChores, EventListStorage.ToDo);
            dGV_ToDo.DataSource = EventListStorage.ToDo.MakeList();
        }

        private void BtnMoveAllOther_Click(object sender, EventArgs e)
        {
            EventList.MakeCopy(EventListStorage.OtherChores, EventListStorage.ToDo);
            dGV_ToDo.DataSource = EventListStorage.ToDo.MakeList();

        }

        private void btnReviewRewards_Click(object sender, EventArgs e)
        {
            RewardReviewer rewardReviewer = new RewardReviewer();
            rewardReviewer.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
