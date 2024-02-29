using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ChoreAssigner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            
            //Routine Chore List
            EventListStorage.Storage.AddLast("Meal prep helper", " ", " ");
            EventListStorage.Storage.AddLast("Clear the Table, wipe and sweep after meals.", " ", " ");
            EventListStorage.Storage.AddLast("Trash/Recycling/Compost taker outer", " ", " ");
            EventListStorage.Storage.AddLast("Table setter", " ", " ");
            EventListStorage.Storage.AddLast("Dishwasher empty-er", " ", " ");
            EventListStorage.Storage.AddLast("Water bottle filler", " ", " ");
            EventListStorage.Storage.AddLast("Baby bag preparer", " ", " ");
            EventListStorage.Storage.AddLast("Downstairs bathroom cleaner", " ", " ");
            EventListStorage.Storage.AddLast("Kids bathroom cleaner", " ", " ");
            EventListStorage.Storage.AddLast("Sink dish washer", " ", " ");
            EventListStorage.Storage.AddLast("Dish Dryer", " ", " ");

            //Other Chore List
            EventListStorage.OtherChores.AddLast("Wash Daddy's Car", "", "");
            EventListStorage.OtherChores.AddLast("Wash Mama's Car", "", "");
            EventListStorage.OtherChores.AddLast("Clean the inside of Daddy's Car", "", "");
            EventListStorage.OtherChores.AddLast("Clean the inside of Mama's Car", "", "");
            EventListStorage.OtherChores.AddLast("Clean the back patio off", "", "");
            EventListStorage.OtherChores.AddLast("Clear off driveway/walkway of leaves", "", "");
            EventListStorage.OtherChores.AddLast("Do the laundry", "", "");
            EventListStorage.OtherChores.AddLast("Deep clean the shower", "", "");
            EventListStorage.OtherChores.AddLast("Deep clean the bath tub", "", "");
            EventListStorage.OtherChores.AddLast("Toilet bowls", "", "");
            EventListStorage.OtherChores.AddLast("Feed the tigers", "", "");
            EventListStorage.OtherChores.AddLast("Wash the giraffes", "", "");
            EventListStorage.OtherChores.AddLast("Tidy the garage", "", "");

            //Submitted Rewards
            EventListStorage.SubmittedRewards.AddLast("Play with a Samurai sword", "", "Mulan");
            EventListStorage.SubmittedRewards.AddLast("Play with my Red Ryder BB gun", "", "Ralphie");
            EventListStorage.SubmittedRewards.AddLast("Go to the ball and be back before midnight", "", "Cinderella");
            EventListStorage.SubmittedRewards.AddLast("Play with Woody and Buzz Lightyear", "", "Andy");







            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
