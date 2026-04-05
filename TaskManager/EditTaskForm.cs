using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class EditTaskForm : Form
    {
        private Form1.TaskItem currentTask;
        private List<Form1.TaskItem> taskList;

        public EditTaskForm(Form1.TaskItem task, List<Form1.TaskItem> taskList)
        {
            InitializeComponent();
            currentTask = task;
            this.taskList = taskList;
            LoadTaskData();
        }

        private void LoadTaskData()
        {
           StatusComboBox.Items.Clear();
           StatusComboBox.Items.Add("In work");
           StatusComboBox.Items.Add("Done");

           NameTextBox.Text = currentTask.Name;
           DescrRichBox.Text = currentTask.Description;

           if(StatusComboBox.Items.Contains(currentTask.Status))
           {
                StatusComboBox.SelectedItem = currentTask.Status;
           }
           else
           {
                StatusComboBox.SelectedIndex = 0;
           }
        }

        //Кнопка сохранить
        private void button1_Click(object sender, EventArgs e)
        {
            currentTask.Name = NameTextBox.Text.Trim();
            currentTask.Description = DescrRichBox.Text.Trim();
            currentTask.Status = StatusComboBox.SelectedItem.ToString();
        
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this task?","Delete task",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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
    }
}
