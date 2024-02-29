using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ChoreAssigner
{

    public class Event
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Event Next;
        private string person;
        public string Person
        {
            get { return person; }
            set { person = value; }
        }
        public Event(string name, string status, string person, Event next)
        {
            this.Name = name;
            this.Status = status;
            this.Person = person;
            this.Next = next;

        }

    }
    
   
    public class EventList
    {
        private Event head;
        private Event tail;
        
        
        private int size;
        public EventList()
        {
            head = null;
            tail = null;
            size = 0;

        }
        public int Length { get { return size; } }

        public bool IsEmpty()
        {
            return size == 0;
        }
        public void AddFirst(string name, string status, string person)
        {
            Event newEvent = new Event(name, status, person, null);
            if (IsEmpty())
            {
                head = newEvent;
                tail = newEvent;
                size++;
            }
            else
            {
                newEvent.Next = head;//assigns value that was in head
                head = newEvent;//head is just a place holder to keep track of where the beginning is
                size++;
            }

        }
        public void AddLast(string name, string status, string person)
        {
            Event newEvent = new Event(name, status, person, null);
            if (IsEmpty())
            {
                head = newEvent;
                tail = newEvent;
                size++;

            }
            else
            {
                tail.Next = newEvent;
                tail = newEvent;
                size++;
            }
        }
        public void RemoveFirst()
        {
            if (IsEmpty()) return;//{ MessageBox.Show("List is Empty"); }
            else if (size == 1)
            {
                head = null;
                tail = null;
                size--;
            }

            else
            {
                head = head.Next;
                size--;
            }
        }
        public void RemoveLast()
        {
            Event p = head;
            int count = 1;
            if (IsEmpty()) return;//MessageBox.Show("List is Empty"); }
            else if (size == 1)
            {
                head = null;
                tail = null;
                size--;
            }
            else
            {
                if (p != null)
                {
                    p = p.Next;
                    count++;
                }
                p.Next = null;
                tail = p;
                size--;
            }
        }
        public void RemoveAnyWhere(int location)
        {
            int count = 1;
            Event p = head;

            if (IsEmpty()) return;
            else if (location > size || location <= 0) MessageBox.Show("Cannot Delete a position that is outside the list boundary");
            else if (location == 1) RemoveFirst();
            else if (location == size) RemoveLast();
            else
            {

                while (count < location - 1) //stops right before the location to delete
                {
                    p = p.Next;
                    count++;
                }
                p.Next = p.Next.Next;//sets the address to the element after the one to delete
                size--;

            }
        }
        public void DeleteAll()
        {
            while (!IsEmpty())
            {
                RemoveFirst();
            }
        }
        public string ChorePrint()
        {
            StringBuilder sb = new StringBuilder();
            int i = 1;
            Event p = head;

            while (p != null)
            {
                sb.AppendLine($"{i}) {p.Person} - {p.Name}");
                i++;
                p = p.Next;
            }
            return sb.ToString();
        }
        public static void MakeCopy(EventList toCopy, EventList newList)
        {
            Event p = toCopy.head;


            while (p != null)
            {
                newList.AddLast(p.Name, p.Status, p.Person);
                p = p.Next;
            }
        }
        public static void CopySingleElement(int index, EventList toCopy, EventList addToList)
        {
            if (toCopy.IsEmpty()) MessageBox.Show("Cannot move any item from an empty list");
            else
            {
                Event p = toCopy.head;
                int count = 0;
                while (count != index)
                {
                    p = p.Next;
                    count++;
                }
                addToList.AddLast(p.Name, p.Status, p.Person);
            }
        }
        //Needed for Randomizing List
        public static string DisplayChoreElement(int index, EventList LList)
        {
            if (!LList.IsEmpty())
            {
                Event p = LList.head;
                int count = 0;
                while (count < index-1)
                {
                    p = p.Next;
                    count++;
                    
                }
                if (p==null)
                {
                    return "";
                }
                else
                {
                    //MessageBox.Show($"Count: {count} index: {index}, {p.Name}");
                    return p.Name;
                }
                
            }
            return "";
        }
        //Returns Dictionary that Has roles assigned 
        public static Dictionary<string,string> RandomizeChores(EventList approvedChores, EventList workerNames)
        {
            Random random = new Random();
            EventList copied = new EventList();//new list to store copied values
            MakeCopy(approvedChores, copied);

            List<Event> direction = workerNames.MakeList();
            Dictionary<string,string> dictionayChores = new Dictionary<string,string>();
            HashSet<string> hashSet = new HashSet<string>();
            
            //Randomizes direction of name list
            if(random.Next(0, 2) == 0)
            {
                direction.Reverse();
            }
            


            while (!copied.IsEmpty())
            {
                for (int i = 0; i < direction.Count(); i++)
                {
                    if (approvedChores.IsEmpty()) { return dictionayChores; }

                    int selection;
                    try
                    {
                        selection = random.Next(1, copied.Length);
                    }
                    catch (Exception)
                    {
                        selection = 0;
                    }
                    
                    if (hashSet.Contains(direction[i].Person))
                    {
                        if (direction[i].Person != "" )
                        {
                            dictionayChores[direction[i].Person] += $"[  ] {DisplayChoreElement(selection, copied)}\n";
                        }
                    }
                    else
                    {
                        hashSet.Add(direction[i].Person);
                        dictionayChores[direction[i].Person]= $"[  ] {DisplayChoreElement(selection, copied)}\n";
                    }
                    copied.RemoveAnyWhere(selection);

                }

            }
            return dictionayChores;


        }

        ///Need to Turn Dictionary into text for display 
        public static string DiplayRandomChores(Dictionary<string,string> dictChores)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keyList = new List<string>(dictChores.Keys);
            sb.AppendLine($"\n\n");
            for(int i = 0;i<keyList.Count();i++)
            {
                sb.Append(keyList[i]);
                sb.Append("********************\n");
                sb.AppendLine(dictChores[keyList[i]]);
                sb.AppendLine();
                sb.AppendLine();
            }

            return sb.ToString();
        }
        public static string DisplayApproveRewards(EventList approvedRewards)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<Event> RewardList = approvedRewards.MakeList();

            stringBuilder.AppendLine("******Rewards for when you are complete and AFTER you are checked********");
            stringBuilder.AppendLine("--The quicker you are done, the sooner you can enjoy.");
            stringBuilder.AppendLine("--If you have time to do a bad job, then you have time to do it over.");
            stringBuilder.AppendLine();

            for (int i = 0; i < RewardList.Count; i++)
            {
                stringBuilder.AppendLine($"{RewardList[i].Person}--{RewardList[i].Name}");
            }

            return stringBuilder.ToString();
        }

        public List<Event> MakeList()
        {
            List<Event> newList= new List<Event>();
            Event p = head;
            while (p != null)
            {
                newList.Add(p);
                p=p.Next;
            }
            return newList;
        }

       
        
    }
    
    //created to make a static class that can alter the linked list on any windows forms
   public static class EventListStorage
    {
        public static EventList Storage = new EventList();
        public static EventList ToDo = new EventList();
        public static EventList OtherChores = new EventList();
        public static EventList SubmittedRewards = new EventList();
        public static EventList EligibleRewards = new EventList();
        public static EventList WorkerNames = new EventList();
    }


}

