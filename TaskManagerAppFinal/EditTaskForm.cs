using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TaskManagerAppFinal;
using static TaskManagerAppFinal.Form1;

namespace TaskManagerAppFinal
{
    public partial class EditTaskForm : Form
    {
        private Form1.TaskItem currentTask;
        private List<Form1.TaskItem> taskList;
        private Timer reminderTimer;

        public EditTaskForm(Form1.TaskItem task, List<Form1.TaskItem> taskList)
        {
            InitializeComponent();
            currentTask = task;
            this.taskList = taskList;

            reminderTimer = new Timer();
            reminderTimer.Tick += RemindTimer_Tick;

            if (ReminderDateTimePicker != null)
            {
                ReminderDateTimePicker.Format = DateTimePickerFormat.Custom;
                ReminderDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
                ReminderDateTimePicker.ShowUpDown = true;
            }

            LoadTaskData();
        }

        private void LoadTaskData()
        {
            StatusComboBox.Items.Clear();
            StatusComboBox.Items.Add("In work");
            StatusComboBox.Items.Add("Done");


            NameTextBox.Text = currentTask.Name;
            DescrRichBox.Text = currentTask.Description;

            if (StatusComboBox.Items.Contains(currentTask.Status))
            {
                StatusComboBox.SelectedItem = currentTask.Status;
            }
            else
            {
                StatusComboBox.SelectedIndex = 0;
            }

            if (ReminderCheckBox != null)
            {
                ReminderCheckBox.Checked = currentTask.IsRemindEnabled;
            }

            // Устанавливаем дату/время напоминания
            if (ReminderDateTimePicker != null)
            {
                if (currentTask.ReminderDateTime.HasValue)
                {
                    ReminderDateTimePicker.Value = currentTask.ReminderDateTime.Value;
                }
                else
                {
                    ReminderDateTimePicker.Value = DateTime.Now.AddHours(1);
                }
                ReminderDateTimePicker.Enabled = currentTask.IsRemindEnabled;
            }
        }

        //Кнопка сохранить
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update the task info?", "Update task",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentTask.Name = NameTextBox.Text.Trim();
                currentTask.Description = DescrRichBox.Text.Trim();
                currentTask.Status = StatusComboBox.SelectedItem.ToString();
                currentTask.IsRemindEnabled = ReminderCheckBox.Checked;



                if (ReminderCheckBox.Checked && ReminderDateTimePicker != null)
                {
                    currentTask.ReminderDateTime = ReminderDateTimePicker.Value;

                    // Запускаем таймер до указанной даты
                    TimeSpan timeUntilReminder = currentTask.ReminderDateTime.Value - DateTime.Now;
                    if (timeUntilReminder.TotalMilliseconds > 0)
                    {
                        reminderTimer.Interval = (int)timeUntilReminder.TotalMilliseconds;
                        reminderTimer.Start();
                    }
                }
                else
                {
                    currentTask.ReminderDateTime = null;
                    reminderTimer.Stop();
                }


                string connString = @"Server=(localdb)\MSSQLLocalDB; Database=TaskManager; Trusted_Connection=True";
                string command = @"UPDATE Tasks SET Name = @Name, Description = @Description, Status = @Status, ReminderDateTime = @ReminderDateTime, IsRemindEnabled = @IsRemindEnabled  WHERE Id = @Id;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(command, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", currentTask.Id);
                        cmd.Parameters.AddWithValue("@Name", currentTask.Name);
                        cmd.Parameters.AddWithValue("@Description", currentTask.Description);
                        cmd.Parameters.AddWithValue("@Status", currentTask.Status);
                        cmd.Parameters.AddWithValue("@ReminderDateTime", currentTask.ReminderDateTime.HasValue ? (object)currentTask.ReminderDateTime.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsRemindEnabled", currentTask.IsRemindEnabled);
                        cmd.ExecuteNonQuery();
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure you want to remove this task?", "Remove task",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connString = @"Server=(localdb)\MSSQLLocalDB; Database=TaskManager; Trusted_Connection=True";
                string command = @"DELETE FROM Tasks WHERE Id = @Id;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(command, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", currentTask.Id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Task was successfully deleted from the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                taskList.Remove(currentTask);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RemindTimer_Tick(object sender, EventArgs e)
        {
            string reminderDate = currentTask.ReminderDateTime.HasValue ? currentTask.ReminderDateTime.Value.ToString("dd.MM.yyyy HH:mm") : "date not set";

            MessageBox.Show($"Напоминание: {currentTask.Name}\n\n" +
                            $"Запланировано на: {reminderDate}\n\n" +
                            $"Описание: {currentTask.Description}",
                            "Task Manager - Reminder",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            reminderTimer.Stop();
        }

        private void ReminderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReminderDateTimePicker != null)
            {
                ReminderDateTimePicker.Enabled = ReminderCheckBox.Checked;
            }
        }
    }
}
