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
    public partial class AddNames : Form
    {
        public AddNames()
        {
            InitializeComponent();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (EventListStorage.WorkerNames.IsEmpty())
            {
                MessageBox.Show("Need to enter names to conitnue");
            }
            else
            {
                Dictionary<string, string> randomChoresDict = EventList.RandomizeChores(EventListStorage.ToDo, EventListStorage.WorkerNames);
                EventList.DiplayRandomChores(randomChoresDict);

                Review review = new Review();
                review.Show();
                this.Close();
            }
        }

        private void AddNames_Load(object sender, EventArgs e)
        {
            dGVWorkerNames.DataSource=EventListStorage.WorkerNames.MakeList();
            dGVWorkerNames.Columns["Status"].Visible = false;
            dGVWorkerNames.Columns["Name"].Visible = false;
        }

        private void btnSubmitName_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text.Trim() != "")
            {
                EventListStorage.WorkerNames.AddFirst("", "", txtAddName.Text);
                dGVWorkerNames.DataSource = EventListStorage.WorkerNames.MakeList();
                txtAddName.Clear();
            }
            else MessageBox.Show("Invalid entry");

        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            int index=0;
            try
            {
                index = dGVWorkerNames.CurrentRow.Index;
            }
            catch (Exception ex) { }
            EventListStorage.WorkerNames.RemoveAnyWhere(index + 1);
            dGVWorkerNames.DataSource=EventListStorage.WorkerNames.MakeList();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            EventListStorage.WorkerNames.DeleteAll();
            dGVWorkerNames.DataSource=EventListStorage.WorkerNames.MakeList();
        }
    }
}
