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
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(391, 145);
            txtTask.Margin = new Padding(4, 5, 4, 5);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(427, 31);
            txtTask.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = SystemColors.MenuHighlight;
            btnAddTask.ForeColor = Color.FloralWhite;
            btnAddTask.Location = new Point(713, 212);
            btnAddTask.Margin = new Padding(4, 5, 4, 5);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(107, 38);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += BtnAddTask_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.BackColor = SystemColors.MenuHighlight;
            btnRemoveSelected.ForeColor = Color.WhiteSmoke;
            btnRemoveSelected.Location = new Point(391, 212);
            btnRemoveSelected.Margin = new Padding(4, 5, 4, 5);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(107, 38);
            btnRemoveSelected.TabIndex = 2;
            btnRemoveSelected.Text = "Remove";
            btnRemoveSelected.UseVisualStyleBackColor = false;
            btnRemoveSelected.Click += BtnRemoveSelected_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = SystemColors.MenuHighlight;
            btnClearAll.ForeColor = Color.WhiteSmoke;
            btnClearAll.Location = new Point(556, 212);
            btnClearAll.Margin = new Padding(4, 5, 4, 5);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(107, 38);
            btnClearAll.TabIndex = 3;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += BtnClearAll_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 25;
            lstTasks.Location = new Point(530, 338);
            lstTasks.Margin = new Padding(4, 5, 4, 5);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(170, 154);
            lstTasks.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(580, 516);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Location = new Point(530, 297);
            chkConfirmDelete.Margin = new Padding(4, 5, 4, 5);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(157, 29);
            chkConfirmDelete.TabIndex = 6;
            chkConfirmDelete.Text = "Confirm Delete";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 62);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 7;
            label1.Text = "Task Management Menu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(chkConfirmDelete);
            Controls.Add(lblStatus);
            Controls.Add(lstTasks);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnAddTask);
            Controls.Add(txtTask);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Task Manager";
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
        private Label label1;
    }
}
