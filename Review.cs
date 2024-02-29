using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreAssigner
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void btnSetFileLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileFormatting.FilePath = dialog.SelectedPath;
                MessageBox.Show($"Location set to {FileFormatting.FilePath}");
            }
        }

        private void Review_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> randomChoresDict = EventList.RandomizeChores(EventListStorage.ToDo, EventListStorage.WorkerNames);
           //need to add rewards prior to displaying
           StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(EventList.DiplayRandomChores(randomChoresDict));
            sb.AppendLine(EventList.DisplayApproveRewards(EventListStorage.EligibleRewards));
            
            richTextBox1.Text =sb.ToString();
            
        }

        private void btn_Save_Draft_Click(object sender, EventArgs e)
        {

            string text=FileFormatting.FileFormat(txtEventTitle.Text, richTextBox1.Text,"DRAFT",monthCalendar1.SelectionStart.ToString("dd MMM yyyy")) ;

            string path = "";
            try
            {
                path = System.IO.Path.Combine(FileFormatting.FilePath, FileFormatting.FileNameConverter(txtEventTitle.Text + "_DRAFT"));
            }
            catch(Exception)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileFormatting.FilePath = dialog.SelectedPath;
                    MessageBox.Show($"Location set to {FileFormatting.FilePath}");
                    path = System.IO.Path.Combine(FileFormatting.FilePath, FileFormatting.FileNameConverter(txtEventTitle.Text + "_DRAFT"));
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                

            }
            System.IO.File.WriteAllText($@"{path}.txt", text);
            MessageBox.Show($"DRAFT File Created: {path}.txt");
        }

        private void btn_Approve_Save_Click(object sender, EventArgs e)
        {
            string text = FileFormatting.FileFormat(txtEventTitle.Text, richTextBox1.Text, "APPROVED", monthCalendar1.SelectionStart.ToString("dd MMM yyyy"));
            string path = "";

            try
            {
                path = System.IO.Path.Combine(FileFormatting.FilePath, FileFormatting.FileNameConverter(txtEventTitle.Text + "_APPROVED"));
            }
            catch (Exception)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileFormatting.FilePath = dialog.SelectedPath;
                    MessageBox.Show($"Location set to {FileFormatting.FilePath}");
                    path = System.IO.Path.Combine(FileFormatting.FilePath, FileFormatting.FileNameConverter(txtEventTitle.Text + "_APPROVED"));
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }


            }

            System.IO.File.WriteAllText($@"{path}.txt", text);
            MessageBox.Show($"APPROVED File Created: {path}.txt");
        }
    }
}
