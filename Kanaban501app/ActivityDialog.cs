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
    public delegate void ActivityModification(object sender, Status originalStatus, Status newStatus);

    public partial class ActivityDialog : Form
    {
        private Activity activity;

        public ActivityDialog(Activity a)
        {
            InitializeComponent();
            activity = a;
            ActivityNameTextBox.Text = a.Name;
            ResourcesTextBox.Text = a.Resources;
            StatusComboBox.SelectedIndex = (int)a.Status;
            dateTimePicker1.Value = a.CompleteBy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activity.Name = ActivityNameTextBox.Text;
            activity.Resources = ResourcesTextBox.Text;
            if (activity.Status != (Status)StatusComboBox.SelectedIndex)
            {
                StatusChanged?.Invoke(activity, activity.Status, (Status)StatusComboBox.SelectedIndex);
                activity.Status = (Status)StatusComboBox.SelectedIndex;
            }
            //activity.Status = (Status)StatusComboBox.SelectedIndex;
            activity.CompleteBy = dateTimePicker1.Value;
            this.Close();
        }

        public event ActivityModification StatusChanged;
    }
}
