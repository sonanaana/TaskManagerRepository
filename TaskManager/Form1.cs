using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {

        public class TaskItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }

            public TaskItem()
            {
                Status = "In work";
            }
        }

        private List<TaskItem> _tasks = new List<TaskItem>();

        //для отображения задач
        private ListBox _tasksBox;
        public Form1()
        {
            InitializeComponent();
            DisplayTaskInPanel();
        }

        private void DisplayTaskInPanel()
        {
            //очистим панель сначала
            taskListBox.Items.Clear();

            foreach (var task in _tasks)
            {
                string displayText = $"{task.Name} - {task.Status}";
                taskListBox.Items.Add(displayText);
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
           string taskName = newTaskName.Text.Trim();
           string taskDescription = newTaskDescription.Text.Trim();


            //Проверка на пустоту
            if (string.IsNullOrEmpty(taskName) || taskName == "Name")
            {
                MessageBox.Show("Input task name!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(taskDescription) || taskDescription == "Name")
            {
                taskDescription = "No description";
            }

            //Создаем новую задачу
            TaskItem taskItem = new TaskItem();
            taskItem.Name = taskName;
            taskItem.Description = taskDescription;
            taskItem.Status = "In work";

            _tasks.Add(taskItem);

            DisplayTaskInPanel();

            newTaskName.Text = "Name";
            newTaskDescription.Text = "Description";


            MessageBox.Show("Task was added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void taskListBox_DoubleClick(object sender, EventArgs e)
        {
            if(taskListBox.SelectedIndex >= 0)
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
                MessageBox.Show("Please, choose the task for edit!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                TaskItem taskItem = _tasks[taskListBox.SelectedIndex];
                EditTaskForm newEdit = new EditTaskForm(taskItem, _tasks);

                if(newEdit.ShowDialog() == DialogResult.OK)
                {
                    DisplayTaskInPanel();
                }
            }
            else
            {
                MessageBox.Show("Please, choose the task for edit!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
