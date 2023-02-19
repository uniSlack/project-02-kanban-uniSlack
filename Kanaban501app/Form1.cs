using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Runtime.CompilerServices;

namespace Kanaban501app
{
    public delegate void ViewUpdateFromController(string action);

    public partial class Form1 : Form
    {

        private GoalsDataBase db;

        public InputUpdateFromView UpdateControllersData;

        public Form1(GoalsDataBase gdb)
        {
            InitializeComponent();
            db = gdb;
            ToDoListView.SelectedIndexChanged += AnySelectionChanged;
            WorkingOnListView.SelectedIndexChanged += AnySelectionChanged;
            DoneListView.SelectedIndexChanged += AnySelectionChanged;
            LoadASave();
            this.FormClosed += Save;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        public void HandelUpdateFromController(string action)
        {
            switch (action)
            {
                case "newOn":
                    NewButton.Enabled = true;
                    break;
                case "newOff":
                    NewButton.Enabled = false;
                    break;
                case "editOn":
                    EditButton.Enabled = true;
                    break;
                case "editOff":
                    EditButton.Enabled = false;
                    break;
                case "delOn":
                    DeleteButton.Enabled = true;
                    break;
                case "delOff":
                    DeleteButton.Enabled = false;
                    break;
                case "norm": 
                    break;
                default:
                    MessageBox.Show("Unrecognized action");
                    break;
            }
            UpdateListViews();
        }

        public void UpdateListViews()
        {
            ToDoListView.Items.Clear();
            foreach (Activity a in db.ToDoArray)
            {
                ToDoListView.Items.Add(a.ToString());
                if(a.CompleteBy <= DateTime.Now)
                {
                    ToDoListView.Items[ToDoListView.Items.Count - 1].ForeColor = Color.Red;
                }
            }
            WorkingOnListView.Items.Clear();
            foreach (Activity a in db.WorkingOnArray)
            {
                WorkingOnListView.Items.Add(a.ToString());
                if (a.CompleteBy <= DateTime.Now)
                {
                    WorkingOnListView.Items[WorkingOnListView.Items.Count - 1].ForeColor = Color.Red;
                }
            }
            DoneListView.Items.Clear();
            foreach (Activity a in db.DoneArray)
            {
                DoneListView.Items.Add(a.ToString());
                if (a.CompleteBy <= DateTime.Now)
                {
                    DoneListView.Items[DoneListView.Items.Count - 1].ForeColor = Color.Red;
                }
            }
            if (ToDoListView.Items.Count < 15) NewButton.Enabled = true;
            else NewButton.Enabled = false;
        }
        
        public void AnySelectionChanged(object sender, EventArgs args) 
        {
            UpdateControllersData("AnySelectionChanged", sender);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            UpdateControllersData("NewButton_Click", sender);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            UpdateControllersData("EditButtonClicked", sender);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UpdateControllersData("DeleteButton_Click", this);
        }

        private void MoveItemFromList(object sender, Status orig, Status nSts)
        {
            UpdateControllersData("UpdateListViews", sender);
        }        
    }
}
