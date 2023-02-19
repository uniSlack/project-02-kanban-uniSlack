namespace Kanaban501app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ToDoListView = new System.Windows.Forms.ListView();
            this.WorkingOnListView = new System.Windows.Forms.ListView();
            this.DoneListView = new System.Windows.Forms.ListView();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(9, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(67, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "My Kanaban";
            // 
            // ToDoListView
            // 
            this.ToDoListView.HideSelection = false;
            this.ToDoListView.Location = new System.Drawing.Point(12, 37);
            this.ToDoListView.Margin = new System.Windows.Forms.Padding(15);
            this.ToDoListView.MultiSelect = false;
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToDoListView.ShowGroups = false;
            this.ToDoListView.Size = new System.Drawing.Size(121, 250);
            this.ToDoListView.TabIndex = 1;
            this.ToDoListView.UseCompatibleStateImageBehavior = false;
            this.ToDoListView.View = System.Windows.Forms.View.List;
            // 
            // WorkingOnListView
            // 
            this.WorkingOnListView.HideSelection = false;
            this.WorkingOnListView.Location = new System.Drawing.Point(172, 37);
            this.WorkingOnListView.Margin = new System.Windows.Forms.Padding(15);
            this.WorkingOnListView.MultiSelect = false;
            this.WorkingOnListView.Name = "WorkingOnListView";
            this.WorkingOnListView.Size = new System.Drawing.Size(121, 250);
            this.WorkingOnListView.TabIndex = 2;
            this.WorkingOnListView.UseCompatibleStateImageBehavior = false;
            this.WorkingOnListView.View = System.Windows.Forms.View.List;
            // 
            // DoneListView
            // 
            this.DoneListView.HideSelection = false;
            this.DoneListView.Location = new System.Drawing.Point(332, 37);
            this.DoneListView.Margin = new System.Windows.Forms.Padding(15);
            this.DoneListView.MultiSelect = false;
            this.DoneListView.Name = "DoneListView";
            this.DoneListView.Size = new System.Drawing.Size(121, 250);
            this.DoneListView.TabIndex = 3;
            this.DoneListView.UseCompatibleStateImageBehavior = false;
            this.DoneListView.View = System.Windows.Forms.View.List;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(11, 305);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(92, 305);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(377, 305);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 339);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DoneListView);
            this.Controls.Add(this.WorkingOnListView);
            this.Controls.Add(this.ToDoListView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.EditButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListView ToDoListView;
        private System.Windows.Forms.ListView WorkingOnListView;
        private System.Windows.Forms.ListView DoneListView;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

