namespace ActWinForm1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTask = new TextBox();
            btnAddTask = new Button();
            btnRemoveSelected = new Button();
            btnClearAll = new Button();
            lstTasks = new ListBox();
            lblStatus = new Label();
            chkConfirmDelete = new CheckBox();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(274, 87);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(300, 23);
            txtTask.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = SystemColors.MenuHighlight;
            btnAddTask.ForeColor = Color.FloralWhite;
            btnAddTask.Location = new Point(499, 127);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(75, 23);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += BtnAddTask_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.BackColor = SystemColors.MenuHighlight;
            btnRemoveSelected.ForeColor = Color.WhiteSmoke;
            btnRemoveSelected.Location = new Point(274, 127);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(75, 23);
            btnRemoveSelected.TabIndex = 2;
            btnRemoveSelected.Text = "Remove";
            btnRemoveSelected.UseVisualStyleBackColor = false;
            btnRemoveSelected.Click += BtnRemoveSelected_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = SystemColors.MenuHighlight;
            btnClearAll.ForeColor = Color.WhiteSmoke;
            btnClearAll.Location = new Point(389, 127);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 23);
            btnClearAll.TabIndex = 3;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += BtnClearAll_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(371, 203);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(120, 94);
            lstTasks.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(412, 300);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Location = new Point(371, 178);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(106, 19);
            chkConfirmDelete.TabIndex = 6;
            chkConfirmDelete.Text = "Confirm Delete";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkConfirmDelete);
            Controls.Add(lblStatus);
            Controls.Add(lstTasks);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnAddTask);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private Button btnAddTask;
        private Button btnRemoveSelected;
        private Button btnClearAll;
        private ListBox lstTasks;
        private Label lblStatus;
        private CheckBox chkConfirmDelete;
    }
}
