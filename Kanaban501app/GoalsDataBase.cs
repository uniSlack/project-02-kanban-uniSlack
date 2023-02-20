using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanaban501app
{
    public class GoalsDataBase
    {
        public List<Activity> ToDoArray { get; set; } = new List<Activity>(15);

        public List<Activity> WorkingOnArray { get; set; } = new List<Activity>(3);

        public List<Activity> DoneArray { get; set; } = new List<Activity>();

        public List<List<Activity>> AllActivitesLists { get; set; } = new List<List<Activity>>(3);
        
        public GoalsDataBase()
        {
            AllActivitesLists.Add(ToDoArray);
            AllActivitesLists.Add(WorkingOnArray);
            AllActivitesLists.Add(DoneArray);
        }

        private string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GoalActivity.txt");
        public void Save(object sender, EventArgs args)
        {
            List<string> lines = new List<string>();
            foreach (List<Activity> l in AllActivitesLists)
            {
                foreach (Activity a in l)
                {
                    string s = a.Name + "\t" + (int)a.Status + "\t" + a.Resources + "\t" + a.CompleteBy + "\t" + a.Priority;
                    lines.Add(s);
                }
            }
            File.WriteAllLines(filename, lines);
        }

        public void LoadASave()
        {
            if (!File.Exists(filename))
            {
                File.WriteAllLines("GoalActivity.txt", new string[0]);
            }
            using (StreamReader sr = File.OpenText(filename))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] line = s.Split('\t');
                    Activity act = new Activity(line[0], (Status)Int32.Parse(line[1]), line[2], DateTime.Parse(line[3]), line[4]);
                    AllActivitesLists[(int)act.Status].Add(act);
                }
            }
        }

        public void Sort()
        {
            ToDoArray.Sort((a1, a2) => a1.Priority.CompareTo(a2.Priority));
            WorkingOnArray.Sort((a1, a2) => a1.Priority.CompareTo(a2.Priority));
            DoneArray.Sort((a1, a2) => a1.Priority.CompareTo(a2.Priority));
        }
    }
}
