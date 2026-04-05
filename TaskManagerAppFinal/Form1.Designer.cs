namespace TaskManagerAppFinal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentTasksLabel = new System.Windows.Forms.Label();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.quitButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.PictureBox();
            this.newTaskName = new System.Windows.Forms.TextBox();
            this.newTaskDescription = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTaskButton)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel3.Controls.Add(this.currentTasksLabel);
            this.flowLayoutPanel3.Controls.Add(this.taskListBox);
            this.flowLayoutPanel3.Controls.Add(this.EditButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(23, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(456, 626);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // currentTasksLabel
            // 
            this.currentTasksLabel.AutoSize = true;
            this.currentTasksLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTasksLabel.Location = new System.Drawing.Point(3, 0);
            this.currentTasksLabel.Name = "currentTasksLabel";
            this.currentTasksLabel.Size = new System.Drawing.Size(197, 29);
            this.currentTasksLabel.TabIndex = 1;
            this.currentTasksLabel.Text = "Список задач";
            // 
            // taskListBox
            // 
            this.taskListBox.BackColor = System.Drawing.Color.MediumBlue;
            this.taskListBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskListBox.ForeColor = System.Drawing.SystemColors.Control;
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.HorizontalScrollbar = true;
            this.taskListBox.ItemHeight = 29;
            this.taskListBox.Location = new System.Drawing.Point(3, 32);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(452, 497);
            this.taskListBox.TabIndex = 3;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.Color.Transparent;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(3, 535);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(76, 88);
            this.EditButton.TabIndex = 2;
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel1.Controls.Add(this.quitButton);
            this.flowLayoutPanel1.Controls.Add(this.addTaskButton);
            this.flowLayoutPanel1.Controls.Add(this.newTaskName);
            this.flowLayoutPanel1.Controls.Add(this.newTaskDescription);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.listBox1);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(502, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(483, 626);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // quitButton
            // 
            this.quitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.quitButton.Location = new System.Drawing.Point(385, 10);
            this.quitButton.Margin = new System.Windows.Forms.Padding(385, 10, 3, 3);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(90, 45);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit ➜]";
            this.quitButton.UseVisualStyleBackColor = false;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.Navy;
            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskButton.ErrorImage = null;
            this.addTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("addTaskButton.Image")));
            this.addTaskButton.Location = new System.Drawing.Point(139, 88);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(139, 30, 3, 3);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(238, 238);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.TabStop = false;
            this.addTaskButton.WaitOnLoad = true;
            // 
            // newTaskName
            // 
            this.newTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.newTaskName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTaskName.ForeColor = System.Drawing.Color.SkyBlue;
            this.newTaskName.Location = new System.Drawing.Point(8, 359);
            this.newTaskName.Margin = new System.Windows.Forms.Padding(8, 30, 8, 3);
            this.newTaskName.Name = "newTaskName";
            this.newTaskName.Size = new System.Drawing.Size(466, 46);
            this.newTaskName.TabIndex = 3;
            this.newTaskName.Text = "Название";
            // 
            // newTaskDescription
            // 
            this.newTaskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.newTaskDescription.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTaskDescription.ForeColor = System.Drawing.Color.SkyBlue;
            this.newTaskDescription.Location = new System.Drawing.Point(8, 420);
            this.newTaskDescription.Margin = new System.Windows.Forms.Padding(8, 12, 8, 3);
            this.newTaskDescription.Name = "newTaskDescription";
            this.newTaskDescription.Size = new System.Drawing.Size(466, 216);
            this.newTaskDescription.TabIndex = 4;
            this.newTaskDescription.Text = "Описание";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.richTextBox2);
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 642);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(517, 626);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(410, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(410, 10, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quit ➜]";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(139, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(139, 30, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 238);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.SkyBlue;
            this.textBox1.Location = new System.Drawing.Point(8, 359);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 30, 8, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 46);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Name";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBox2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.ForeColor = System.Drawing.Color.SkyBlue;
            this.richTextBox2.Location = new System.Drawing.Point(8, 420);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(500, 207);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "Description";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 1274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.TransparencyKey = System.Drawing.Color.DarkBlue;
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTaskButton)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);



            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this.taskListBox.DoubleClick += new System.EventHandler(this.taskListBox_DoubleClick);
            this.newTaskName.Click += new System.EventHandler(this.newTaskName_Click);
            this.newTaskDescription.Click += new System.EventHandler(this.newTaskDescription_Click);



        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.PictureBox addTaskButton;
        private System.Windows.Forms.TextBox newTaskName;
        private System.Windows.Forms.RichTextBox newTaskDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label currentTasksLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
    }
}

