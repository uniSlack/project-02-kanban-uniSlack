using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanaban501app
{
    public delegate void InputUpdateFromView(string action, object sender);
    public class Controller
    {
        private GoalsDataBase db;

        public ViewUpdateFromController UpdateTheView;

        public Activity SelectedActivity { get; set; }

        public Controller(GoalsDataBase gdb)
        {
            db = gdb;
        }

        public void InputHandler(string action, object sender)
        {
            switch (action)
            {
                case "NewButton_Click":
                    if (db.ToDoArray.Count < 15)
                    {
                        Activity act = new Activity("New Activity", Status.Todo, "", DateTime.Now, "A");
                        db.ToDoArray.Add(act);
                        CreateDialogFromActivity(act);
                    }
                    else
                    {
                        MessageBox.Show("To Do List Full");
                        UpdateTheView("newOff");
                    }
                    UpdateTheView("norm");
                    break;
                case "DeleteButton_Click":
                    if (!db.ToDoArray.Remove(SelectedActivity))
                    {
                        if (!db.WorkingOnArray.Remove(SelectedActivity))
                        {
                            if (!db.DoneArray.Remove(SelectedActivity))
                            {
                                throw new ArgumentException();
                            }
                        }
                    }
                    UpdateTheView("editOff");
                    UpdateTheView("delOff");
                    break;
                case "EditButton_Clicked":
                    CreateDialogFromActivity(SelectedActivity);
                    UpdateTheView("norm");
                    break;
                case "AnySelectionChanged":
                    if (sender is ListView lv && lv.SelectedIndices.Count > 0)
                    {
                        if (lv.Name == "ToDoListView")
                        {
                            SelectedActivity = db.ToDoArray[lv.SelectedIndices[0]];
                        }
                        else if (lv.Name == "WorkingOnListView")
                        {
                            SelectedActivity = db.WorkingOnArray[lv.SelectedIndices[0]];
                        }
                        else if (lv.Name == "DoneListView")
                        {
                            SelectedActivity = db.DoneArray[lv.SelectedIndices[0]];
                        }
                        UpdateTheView("editOn");
                        UpdateTheView("delOn");
                    }
                    break;
                //case "MoveItemFromList":
                //    if (sender is Activity a)
                //    {
                        
                //    }
                //    UpdateTheView("norm");
                //    break;
                case "ActivityDialogSaving":
                    if (sender is ActivityDialog ad)
                    {
                        ad.activity.Name = ad.ActivityNameTextBox.Text;
                        ad.activity.Resources = ad.ResourcesTextBox.Text;
                        if (ad.activity.Status != (Status)ad.StatusComboBox.SelectedIndex)
                        {
                            //StatusChanged?.Invoke(activity, activity.Status, (Status)StatusComboBox.SelectedIndex);
                            
                            db.AllActivitesLists[(int)ad.activity.Status].Remove(ad.activity);
                            db.AllActivitesLists[(int)ad.StatusComboBox.SelectedIndex].Add(ad.activity);
                            ad.activity.Status = (Status)ad.StatusComboBox.SelectedIndex;
                        }
                        //activity.Status = (Status)StatusComboBox.SelectedIndex;
                        ad.activity.CompleteBy = ad.dateTimePicker1.Value;
                        ad.activity.Priority = ad.PriorityComboBox.Text;
                        ad.Close();
                    }
                    break;
                default:
                    MessageBox.Show("Unrecognized action");
                    return;
            }
            
        }

        private void CreateDialogFromActivity(Activity act)
        {
            ActivityDialog ad = new ActivityDialog(act);
            ad.OnSave = InputHandler;
            //ad.StatusChanged += MoveItemFromList;
            //ad.FormClosed += UpdateListViewsOnEventHandler;
            ad.ShowDialog();
        }
    }
}
