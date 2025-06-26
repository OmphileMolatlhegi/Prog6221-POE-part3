namespace CyberChatBotGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.chatOutput = new System.Windows.Forms.RichTextBox();
            this.chatInput = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.reminderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reminderCheckBox = new System.Windows.Forms.CheckBox();
            this.taskDescInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taskTitleInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taskList = new System.Windows.Forms.ListBox();
            this.tabQuiz = new System.Windows.Forms.TabPage();
            this.quizResultLabel = new System.Windows.Forms.Label();
            this.quizOption4 = new System.Windows.Forms.Button();
            this.quizOption3 = new System.Windows.Forms.Button();
            this.quizOption2 = new System.Windows.Forms.Button();
            this.quizOption1 = new System.Windows.Forms.Button();
            this.quizQuestionLabel = new System.Windows.Forms.Label();
            this.tabActivityLog = new System.Windows.Forms.TabPage();
            this.activityLogBox = new System.Windows.Forms.ListBox();
            this.chatTabButton = new System.Windows.Forms.Button();
            this.tasksTabButton = new System.Windows.Forms.Button();
            this.quizTabButton = new System.Windows.Forms.Button();
            this.logTabButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.tabTasks.SuspendLayout();
            this.tabQuiz.SuspendLayout();
            this.tabActivityLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChat);
            this.tabControl1.Controls.Add(this.tabTasks);
            this.tabControl1.Controls.Add(this.tabQuiz);
            this.tabControl1.Controls.Add(this.tabActivityLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabChat
            // 
            this.tabChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tabChat.Controls.Add(this.chatOutput);
            this.tabChat.Controls.Add(this.chatInput);
            this.tabChat.Controls.Add(this.sendButton);
            this.tabChat.Location = new System.Drawing.Point(4, 22);
            this.tabChat.Name = "tabChat";
            this.tabChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabChat.Size = new System.Drawing.Size(652, 382);
            this.tabChat.TabIndex = 0;
            this.tabChat.Text = "Chat";
            // 
            // chatOutput
            // 
            this.chatOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.chatOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatOutput.ForeColor = System.Drawing.Color.LightGreen;
            this.chatOutput.Location = new System.Drawing.Point(6, 6);
            this.chatOutput.Name = "chatOutput";
            this.chatOutput.ReadOnly = true;
            this.chatOutput.Size = new System.Drawing.Size(640, 330);
            this.chatOutput.TabIndex = 2;
            this.chatOutput.Text = "";
            // 
            // chatInput
            // 
            this.chatInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.chatInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatInput.ForeColor = System.Drawing.Color.White;
            this.chatInput.Location = new System.Drawing.Point(16, 335);
            this.chatInput.Multiline = true;
            this.chatInput.Name = "chatInput";
            this.chatInput.Size = new System.Drawing.Size(540, 51);
            this.chatInput.TabIndex = 1;
            this.chatInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chatInput_KeyPress);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(555, 335);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(94, 51);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // tabTasks
            // 
            this.tabTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tabTasks.Controls.Add(this.completeTaskButton);
            this.tabTasks.Controls.Add(this.deleteTaskButton);
            this.tabTasks.Controls.Add(this.addTaskButton);
            this.tabTasks.Controls.Add(this.reminderDatePicker);
            this.tabTasks.Controls.Add(this.reminderCheckBox);
            this.tabTasks.Controls.Add(this.taskDescInput);
            this.tabTasks.Controls.Add(this.label2);
            this.tabTasks.Controls.Add(this.taskTitleInput);
            this.tabTasks.Controls.Add(this.label1);
            this.tabTasks.Controls.Add(this.taskList);
            this.tabTasks.Location = new System.Drawing.Point(4, 22);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasks.Size = new System.Drawing.Size(652, 382);
            this.tabTasks.TabIndex = 1;
            this.tabTasks.Text = "Tasks";
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.completeTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeTaskButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeTaskButton.ForeColor = System.Drawing.Color.White;
            this.completeTaskButton.Location = new System.Drawing.Point(452, 342);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(194, 51);
            this.completeTaskButton.TabIndex = 9;
            this.completeTaskButton.Text = "Mark as Completed";
            this.completeTaskButton.UseVisualStyleBackColor = false;
            this.completeTaskButton.Click += new System.EventHandler(this.completeTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.deleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTaskButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTaskButton.ForeColor = System.Drawing.Color.White;
            this.deleteTaskButton.Location = new System.Drawing.Point(226, 342);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(220, 51);
            this.deleteTaskButton.TabIndex = 8;
            this.deleteTaskButton.Text = "Delete Task";
            this.deleteTaskButton.UseVisualStyleBackColor = false;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.Location = new System.Drawing.Point(6, 342);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(214, 51);
            this.addTaskButton.TabIndex = 7;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // reminderDatePicker
            // 
            this.reminderDatePicker.CalendarFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderDatePicker.CalendarForeColor = System.Drawing.Color.White;
            this.reminderDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.reminderDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.reminderDatePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.reminderDatePicker.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.reminderDatePicker.Enabled = false;
            this.reminderDatePicker.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderDatePicker.Location = new System.Drawing.Point(226, 302);
            this.reminderDatePicker.Name = "reminderDatePicker";
            this.reminderDatePicker.Size = new System.Drawing.Size(420, 23);
            this.reminderDatePicker.TabIndex = 6;
            // 
            // reminderCheckBox
            // 
            this.reminderCheckBox.AutoSize = true;
            this.reminderCheckBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderCheckBox.ForeColor = System.Drawing.Color.White;
            this.reminderCheckBox.Location = new System.Drawing.Point(6, 304);
            this.reminderCheckBox.Name = "reminderCheckBox";
            this.reminderCheckBox.Size = new System.Drawing.Size(208, 19);
            this.reminderCheckBox.TabIndex = 5;
            this.reminderCheckBox.Text = "Set Reminder for this Task";
            this.reminderCheckBox.UseVisualStyleBackColor = true;
            this.reminderCheckBox.CheckedChanged += new System.EventHandler(this.reminderCheckBox_CheckedChanged);
            // 
            // taskDescInput
            // 
            this.taskDescInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.taskDescInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescInput.ForeColor = System.Drawing.Color.White;
            this.taskDescInput.Location = new System.Drawing.Point(6, 254);
            this.taskDescInput.Multiline = true;
            this.taskDescInput.Name = "taskDescInput";
            this.taskDescInput.Size = new System.Drawing.Size(640, 44);
            this.taskDescInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Description:";
            // 
            // taskTitleInput
            // 
            this.taskTitleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.taskTitleInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleInput.ForeColor = System.Drawing.Color.White;
            this.taskTitleInput.Location = new System.Drawing.Point(6, 210);
            this.taskTitleInput.Name = "taskTitleInput";
            this.taskTitleInput.Size = new System.Drawing.Size(640, 23);
            this.taskTitleInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Title:";
            // 
            // taskList
            // 
            this.taskList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.taskList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskList.ForeColor = System.Drawing.Color.White;
            this.taskList.FormattingEnabled = true;
            this.taskList.ItemHeight = 15;
            this.taskList.Location = new System.Drawing.Point(6, 6);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(640, 169);
            this.taskList.TabIndex = 0;
            // 
            // tabQuiz
            // 
            this.tabQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tabQuiz.Controls.Add(this.quizResultLabel);
            this.tabQuiz.Controls.Add(this.quizOption4);
            this.tabQuiz.Controls.Add(this.quizOption3);
            this.tabQuiz.Controls.Add(this.quizOption2);
            this.tabQuiz.Controls.Add(this.quizOption1);
            this.tabQuiz.Controls.Add(this.quizQuestionLabel);
            this.tabQuiz.Location = new System.Drawing.Point(4, 22);
            this.tabQuiz.Name = "tabQuiz";
            this.tabQuiz.Size = new System.Drawing.Size(652, 382);
            this.tabQuiz.TabIndex = 2;
            this.tabQuiz.Text = "Quiz";
            // 
            // quizResultLabel
            // 
            this.quizResultLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizResultLabel.Location = new System.Drawing.Point(3, 200);
            this.quizResultLabel.Name = "quizResultLabel";
            this.quizResultLabel.Size = new System.Drawing.Size(646, 196);
            this.quizResultLabel.TabIndex = 5;
            this.quizResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quizOption4
            // 
            this.quizOption4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.quizOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizOption4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizOption4.ForeColor = System.Drawing.Color.White;
            this.quizOption4.Location = new System.Drawing.Point(334, 150);
            this.quizOption4.Name = "quizOption4";
            this.quizOption4.Size = new System.Drawing.Size(315, 40);
            this.quizOption4.TabIndex = 4;
            this.quizOption4.UseVisualStyleBackColor = false;
            this.quizOption4.Click += new System.EventHandler(this.quizOption4_Click);
            // 
            // quizOption3
            // 
            this.quizOption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.quizOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizOption3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizOption3.ForeColor = System.Drawing.Color.White;
            this.quizOption3.Location = new System.Drawing.Point(3, 150);
            this.quizOption3.Name = "quizOption3";
            this.quizOption3.Size = new System.Drawing.Size(325, 40);
            this.quizOption3.TabIndex = 3;
            this.quizOption3.UseVisualStyleBackColor = false;
            this.quizOption3.Click += new System.EventHandler(this.quizOption3_Click);
            // 
            // quizOption2
            // 
            this.quizOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.quizOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizOption2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizOption2.ForeColor = System.Drawing.Color.White;
            this.quizOption2.Location = new System.Drawing.Point(334, 104);
            this.quizOption2.Name = "quizOption2";
            this.quizOption2.Size = new System.Drawing.Size(315, 40);
            this.quizOption2.TabIndex = 2;
            this.quizOption2.UseVisualStyleBackColor = false;
            this.quizOption2.Click += new System.EventHandler(this.quizOption2_Click);
            // 
            // quizOption1
            // 
            this.quizOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.quizOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizOption1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizOption1.ForeColor = System.Drawing.Color.White;
            this.quizOption1.Location = new System.Drawing.Point(3, 104);
            this.quizOption1.Name = "quizOption1";
            this.quizOption1.Size = new System.Drawing.Size(325, 40);
            this.quizOption1.TabIndex = 1;
            this.quizOption1.UseVisualStyleBackColor = false;
            this.quizOption1.Click += new System.EventHandler(this.quizOption1_Click);
            // 
            // quizQuestionLabel
            // 
            this.quizQuestionLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizQuestionLabel.Location = new System.Drawing.Point(3, 10);
            this.quizQuestionLabel.Name = "quizQuestionLabel";
            this.quizQuestionLabel.Size = new System.Drawing.Size(646, 80);
            this.quizQuestionLabel.TabIndex = 0;
            this.quizQuestionLabel.Text = "Question text will appear here";
            this.quizQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabActivityLog
            // 
            this.tabActivityLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tabActivityLog.Controls.Add(this.activityLogBox);
            this.tabActivityLog.Location = new System.Drawing.Point(4, 22);
            this.tabActivityLog.Name = "tabActivityLog";
            this.tabActivityLog.Size = new System.Drawing.Size(652, 382);
            this.tabActivityLog.TabIndex = 3;
            this.tabActivityLog.Text = "Activity Log";
            // 
            // activityLogBox
            // 
            this.activityLogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.activityLogBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLogBox.ForeColor = System.Drawing.Color.White;
            this.activityLogBox.FormattingEnabled = true;
            this.activityLogBox.ItemHeight = 15;
            this.activityLogBox.Location = new System.Drawing.Point(3, 3);
            this.activityLogBox.Name = "activityLogBox";
            this.activityLogBox.Size = new System.Drawing.Size(646, 394);
            this.activityLogBox.TabIndex = 0;
            // 
            // chatTabButton
            // 
            this.chatTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.chatTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatTabButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatTabButton.ForeColor = System.Drawing.Color.White;
            this.chatTabButton.Location = new System.Drawing.Point(12, 6);
            this.chatTabButton.Name = "chatTabButton";
            this.chatTabButton.Size = new System.Drawing.Size(100, 30);
            this.chatTabButton.TabIndex = 1;
            this.chatTabButton.Text = "Chat";
            this.chatTabButton.UseVisualStyleBackColor = false;
            this.chatTabButton.Click += new System.EventHandler(this.chatTabButton_Click);
            // 
            // tasksTabButton
            // 
            this.tasksTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.tasksTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasksTabButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksTabButton.ForeColor = System.Drawing.Color.White;
            this.tasksTabButton.Location = new System.Drawing.Point(118, 6);
            this.tasksTabButton.Name = "tasksTabButton";
            this.tasksTabButton.Size = new System.Drawing.Size(100, 30);
            this.tasksTabButton.TabIndex = 2;
            this.tasksTabButton.Text = "Tasks";
            this.tasksTabButton.UseVisualStyleBackColor = false;
            this.tasksTabButton.Click += new System.EventHandler(this.tasksTabButton_Click);
            // 
            // quizTabButton
            // 
            this.quizTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.quizTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizTabButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizTabButton.ForeColor = System.Drawing.Color.White;
            this.quizTabButton.Location = new System.Drawing.Point(224, 6);
            this.quizTabButton.Name = "quizTabButton";
            this.quizTabButton.Size = new System.Drawing.Size(100, 30);
            this.quizTabButton.TabIndex = 3;
            this.quizTabButton.Text = "Quiz";
            this.quizTabButton.UseVisualStyleBackColor = false;
            this.quizTabButton.Click += new System.EventHandler(this.quizTabButton_Click);
            // 
            // logTabButton
            // 
            this.logTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.logTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logTabButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTabButton.ForeColor = System.Drawing.Color.White;
            this.logTabButton.Location = new System.Drawing.Point(330, 6);
            this.logTabButton.Name = "logTabButton";
            this.logTabButton.Size = new System.Drawing.Size(100, 30);
            this.logTabButton.TabIndex = 4;
            this.logTabButton.Text = "Activity Log";
            this.logTabButton.UseVisualStyleBackColor = false;
            this.logTabButton.Click += new System.EventHandler(this.logTabButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.logTabButton);
            this.Controls.Add(this.quizTabButton);
            this.Controls.Add(this.tasksTabButton);
            this.Controls.Add(this.chatTabButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CyberSecBot";
            this.tabControl1.ResumeLayout(false);
            this.tabChat.ResumeLayout(false);
            this.tabChat.PerformLayout();
            this.tabTasks.ResumeLayout(false);
            this.tabTasks.PerformLayout();
            this.tabQuiz.ResumeLayout(false);
            this.tabActivityLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.TabPage tabQuiz;
        private System.Windows.Forms.TabPage tabActivityLog;
        private System.Windows.Forms.RichTextBox chatOutput;
        private System.Windows.Forms.TextBox chatInput;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.TextBox taskTitleInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskDescInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox reminderCheckBox;
        private System.Windows.Forms.DateTimePicker reminderDatePicker;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button completeTaskButton;
        private System.Windows.Forms.Label quizQuestionLabel;
        private System.Windows.Forms.Button quizOption1;
        private System.Windows.Forms.Button quizOption4;
        private System.Windows.Forms.Button quizOption3;
        private System.Windows.Forms.Button quizOption2;
        private System.Windows.Forms.Label quizResultLabel;
        private System.Windows.Forms.ListBox activityLogBox;
        private System.Windows.Forms.Button chatTabButton;
        private System.Windows.Forms.Button tasksTabButton;
        private System.Windows.Forms.Button quizTabButton;
        private System.Windows.Forms.Button logTabButton;
    }
}