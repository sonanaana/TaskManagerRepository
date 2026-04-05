using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TaskManagerAppFinal
{
    public partial class Form1 : Form
    {
        static string connString = @"Server=(localdb)\MSSQLLocalDB; Database=TaskManager; Trusted_Connection=True";

        public class TaskItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public DateTime? ReminderDateTime { get; set; }
            public bool IsRemindEnabled { get; set; }

            public TaskItem()
            {
                Id = 0;
                Name = "New task";
                Description = "Without a description";
                Status = "In work";
                ReminderDateTime = null;
                IsRemindEnabled = false;
            }
        }

        private List<TaskItem> _tasks = new List<TaskItem>();

        //для отображения задач
        public Form1()
        {
            InitializeComponent();
            taskListBox.Items.Clear();
            LoadTasksFromDatabase();
            DisplayTaskInPanel();
        }

        private void LoadTasksFromDatabase()
        {
            _tasks.Clear();

            string command = "SELECT Id, Name, Description, Status, ReminderDateTime, IsRemindEnabled FROM Tasks;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(command, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TaskItem task = new TaskItem();
                                task.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                                task.Name = reader.GetString(reader.GetOrdinal("Name"));
                                task.Description = reader.GetString(reader.GetOrdinal("Description"));
                                task.Status = reader.GetString(reader.GetOrdinal("Status"));
                                task.IsRemindEnabled = reader.GetBoolean(reader.GetOrdinal("IsRemindEnabled"));

                                if (!reader.IsDBNull(reader.GetOrdinal("ReminderDateTime")))
                                {
                                    task.ReminderDateTime = reader.GetDateTime(reader.GetOrdinal("ReminderDateTime"));
                                }
                                else
                                {
                                    task.ReminderDateTime = null;
                                }

                                _tasks.Add(task);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting tasks from db: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayTaskInPanel()
        {
            //очистим панель сначала
            taskListBox.Items.Clear();

            foreach (var task in _tasks)
            {
                string displayText = $"{task.Name} --> {task.Status}";
                taskListBox.Items.Add(displayText);
            }
        }

        private void newTaskName_Click(object sender, EventArgs e)
        {
            newTaskName.Text = "";
        }

        private void newTaskDescription_Click(object sender, EventArgs e)
        {
            newTaskDescription.Text = "";
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            string taskName = newTaskName.Text.Trim();
            string taskDescription = newTaskDescription.Text.Trim();

            // Проверка на пустоту
            if (string.IsNullOrEmpty(taskName) || taskName == "Name")
            {
                MessageBox.Show("Input a name for new task!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(taskDescription) || taskDescription == "Description")
            {
                taskDescription = "Without a description";
            }

            // Создаем новую задачу
            TaskItem taskItem = new TaskItem();
            taskItem.Name = taskName;
            taskItem.Description = taskDescription;
            taskItem.Status = "In work";
            taskItem.ReminderDateTime = null;
            taskItem.IsRemindEnabled = false;

            string command = @"INSERT INTO Tasks (Name, Description, Status, ReminderDateTime, IsRemindEnabled) 
                       OUTPUT INSERTED.Id 
                       VALUES (@Name, @Description, @Status, @ReminderDateTime, @IsRemindEnabled);";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", taskItem.Name);
                    cmd.Parameters.AddWithValue("@Description", taskItem.Description);
                    cmd.Parameters.AddWithValue("@Status", taskItem.Status);
                    cmd.Parameters.AddWithValue("@ReminderDateTime", DBNull.Value); // ← ИСПРАВЛЕНО: передаем NULL
                    cmd.Parameters.AddWithValue("@IsRemindEnabled", taskItem.IsRemindEnabled);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int newId))
                    {
                        taskItem.Id = newId;
                        _tasks.Add(taskItem);
                        DisplayTaskInPanel();

                        newTaskName.Text = "Name";
                        newTaskDescription.Text = "Description";

                        MessageBox.Show("New task was created successfully! To plan a reminder, edit the task.", "Task",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve the new task ID.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void taskListBox_DoubleClick(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                TaskItem taskItem = _tasks[taskListBox.SelectedIndex];
                EditTaskForm newEdit = new EditTaskForm(taskItem, _tasks);

                if (newEdit.ShowDialog() == DialogResult.OK)
                {
                    DisplayTaskInPanel();
                }

            }
            else
            {
                MessageBox.Show("Firstly choose a task from the list, please!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                TaskItem taskItem = _tasks[taskListBox.SelectedIndex];
                EditTaskForm newEdit = new EditTaskForm(taskItem, _tasks);

                if (newEdit.ShowDialog() == DialogResult.OK)
                {
                    DisplayTaskInPanel();
                }
            }
            else
            {
                MessageBox.Show("Firstly choose a task from the list, please!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
