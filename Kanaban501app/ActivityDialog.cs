using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanaban501app
{
    //public delegate void ActivityModification(object sender, Status originalStatus, Status newStatus);

    public partial class ActivityDialog : Form
    {
        public Activity activity;

        public InputUpdateFromView OnSave;

        public ActivityDialog(Activity a)
        {
            InitializeComponent();
            activity = a;
            ActivityNameTextBox.Text = a.Name;
            ResourcesTextBox.Text = a.Resources;
            StatusComboBox.SelectedIndex = (int)a.Status;
            dateTimePicker1.Value = a.CompleteBy;
            PriorityComboBox.SelectedIndex = a.Priority[0] - 65;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSave("ActivityDialogSaving", this);
        }
    }
}
