namespace ActWinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initial state
            btnAddTask.Enabled = false;
            btnRemoveSelected.Enabled = false;
            chkConfirmDelete.Checked = false;

            // Event subscriptions
            txtTask.TextChanged += TxtTask_TextChanged;
            lstTasks.SelectedIndexChanged += LstTasks_SelectedIndexChanged;
            btnAddTask.Click += BtnAddTask_Click;
            btnRemoveSelected.Click += BtnRemoveSelected_Click;
            btnClearAll.Click += BtnClearAll_Click;
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            string taskText = txtTask.Text.Trim();

            if (string.IsNullOrEmpty(taskText))
            {
                MessageBox.Show("You must enter a task first.", "No Task Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblStatus.Text = "No task entered";
                return;
            }

            lstTasks.Items.Add(taskText);

            txtTask.Clear();
            btnAddTask.Enabled = false;

            lblStatus.Text = $"Task added at {DateTime.Now.ToShortTimeString()}";
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                lblStatus.Text = "No task selected.";
                return;
            }

            string selectedTask = lstTasks.SelectedItem.ToString();
            bool removeConfirmed = true;

            if (chkConfirmDelete.Checked)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Delete '{selectedTask}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                removeConfirmed = (confirm == DialogResult.Yes);
                if (!removeConfirmed)
                {
                    lblStatus.Text = "Deletion canceled.";
                    return;
                }
            }

            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);

            lblStatus.Text = $"Removed: {selectedTask}";
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if (lstTasks.Items.Count == 0)
            {
                lblStatus.Text = "Task list is already empty";
                return;
            }

            lstTasks.Items.Clear();
            lblStatus.Text = "All tasks cleared";
        }

        private void TxtTask_TextChanged(object sender, EventArgs e)
        {
            btnAddTask.Enabled = !string.IsNullOrWhiteSpace(txtTask.Text);
        }

        private void LstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveSelected.Enabled = lstTasks.SelectedIndex != -1;

            if (lstTasks.SelectedIndex != -1)
                lblStatus.Text = $"Selected: {lstTasks.SelectedItem}";
        }
    }
}