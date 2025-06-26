using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberChatBotGUI
{
    public partial class MainForm : Form
    {
        private CyberSecBot chatbot;
        private BindingList<ActivityLogEntry> activityLog = new BindingList<ActivityLogEntry>();
        private List<CyberTask> tasks = new List<CyberTask>();
        private List<QuizQuestion> quizQuestions = new List<QuizQuestion>();
        private QuizGame quizGame = new QuizGame();
        private bool waitingForName = true;

        public MainForm()
        {
            InitializeComponent();
            InitializeChatbot();
            InitializeQuizQuestions();
            SetupUI();
            PlayWelcomeSound();
            LogActivity("System", "Application started");

            // Initialize activity log binding
            activityLogBox.DataSource = activityLog;

            // Welcome messages
            ShowTypingEffect("Welcome to CyberSecBot - Your Digital Safety Assistant!");
            ShowTypingEffect("Please enter your name to begin...");
        }

        private void ShowTypingEffect(string text, int delay = 30)
        {
            if (chatOutput.InvokeRequired)
            {
                chatOutput.Invoke(new Action(() => ShowTypingEffect(text, delay)));
                return;
            }

            chatOutput.SelectionColor = Color.Cyan;
            foreach (char c in text)
            {
                chatOutput.AppendText(c.ToString());
                Application.DoEvents();
                Thread.Sleep(delay);
            }
            chatOutput.AppendText("\n");
        }

        private void InitializeChatbot()
        {
            chatbot = new CyberSecBot();
        }

        private void SetupUI()
        {
            this.Text = "CyberSecBot - Your Digital Safety Guide";
            this.BackColor = Color.FromArgb(30, 30, 40);
            this.ForeColor = Color.White;
            this.Font = new Font("Consolas", 10);

            // Set up tab control
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.SelectedIndex = 0;

            // Chat tab
            chatInput.BackColor = Color.FromArgb(50, 50, 60);
            chatInput.ForeColor = Color.White;
            chatOutput.BackColor = Color.FromArgb(40, 40, 50);
            chatOutput.ForeColor = Color.LightGreen;

            // Tasks tab
            taskList.BackColor = Color.FromArgb(50, 50, 60);
            taskList.ForeColor = Color.White;
            taskTitleInput.BackColor = Color.FromArgb(50, 50, 60);
            taskTitleInput.ForeColor = Color.White;
            taskDescInput.BackColor = Color.FromArgb(50, 50, 60);
            taskDescInput.ForeColor = Color.White;
            reminderDatePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            reminderDatePicker.Format = DateTimePickerFormat.Custom;

            // Quiz tab
            quizQuestionLabel.ForeColor = Color.Cyan;
            quizOption1.BackColor = Color.FromArgb(50, 50, 60);
            quizOption2.BackColor = Color.FromArgb(50, 50, 60);
            quizOption3.BackColor = Color.FromArgb(50, 50, 60);
            quizOption4.BackColor = Color.FromArgb(50, 50, 60);
            quizResultLabel.ForeColor = Color.Yellow;
        }

        private void InitializeQuizQuestions()
        {
            quizQuestions.Add(new QuizQuestion(
                "What should you do if you receive an email asking for your password?",
                new List<string> { "Reply with your password", "Delete the email", "Report the email as phishing", "Ignore it" },
                2));

            quizQuestions.Add(new QuizQuestion(
                "Which of these is the most secure password?",
                new List<string> { "password123", "John1985", "P@ssw0rd!", "Tr0ub4dor&3" },
                3));

            quizQuestions.Add(new QuizQuestion(
                "What does HTTPS in a website URL indicate?",
                new List<string> { "The site has videos", "The connection is encrypted", "The site is government-run", "The site is popular" },
                1));

            quizQuestions.Add(new QuizQuestion(
                "What is two-factor authentication?",
                new List<string> { "Using two passwords", "Verifying identity with two methods", "Logging in from two devices", "Having two email accounts" },
                1));

            quizQuestions.Add(new QuizQuestion(
                "What should you do before connecting to public WiFi?",
                new List<string> { "Disable your firewall", "Enable a VPN", "Share your location", "Update your social media" },
                1));

            quizQuestions.Add(new QuizQuestion(
                "How often should you update your software?",
                new List<string> { "Only when it stops working", "Every 6 months", "Whenever updates are available", "Never" },
                2));

            quizQuestions.Add(new QuizQuestion(
                "What is a common sign of a phishing email?",
                new List<string> { "Professional logo", "Urgent action required", "Personalized greeting", "Company contact information" },
                1));

            quizQuestions.Add(new QuizQuestion(
                "What should you do with old devices before disposing of them?",
                new List<string> { "Throw them away", "Sell them as-is", "Factory reset and wipe data", "Give them to a friend" },
                2));

            quizQuestions.Add(new QuizQuestion(
                "What is the purpose of a password manager?",
                new List<string> { "To remember all your passwords", "To generate weak passwords", "To share passwords with friends", "To store passwords in a browser" },
                0));

            quizQuestions.Add(new QuizQuestion(
                "What information should you never share online?",
                new List<string> { "Your favorite movie", "Your pet's name", "Your social security number", "Your vacation plans" },
                2));

            // Initialize quiz game with questions
            quizGame.Questions.Clear();
            foreach (var question in quizQuestions)
            {
                quizGame.Questions.Add(question);
            }
        }

        private void PlayWelcomeSound()
        {
            try
            {
                // Get path relative to executable
                string soundPath = Path.Combine(Application.StartupPath, "Sounds", "welcome.wav");

                // Verify file exists
                if (File.Exists(soundPath))
                {
                    using (SoundPlayer player = new SoundPlayer(soundPath))
                    {
                        player.Play();
                    }
                }
                else
                {
                    LogActivity("System", $"Welcome sound not found at: {soundPath}");
                }
            }
            catch (Exception ex)
            {
                LogActivity("System", $"Error playing welcome sound: {ex.Message}");
            }
        }

        private void LogActivity(string category, string description)
        {
            var entry = new ActivityLogEntry(category, description);
            activityLog.Add(entry);

            // Keep only the last 10 entries
            while (activityLog.Count > 10)
            {
                activityLog.RemoveAt(0);
            }

            // Auto-scroll to the newest entry
            activityLogBox.TopIndex = activityLogBox.Items.Count - 1;
        }

        private void chatInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendMessage();
            }
        }

        private void SendMessage()
        {
            string input = chatInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
                return;

            // Add user message to chat
            chatOutput.AppendText($"You: {input}\n", Color.Yellow);
            chatInput.Clear();

            // Handle name capture
            if (waitingForName)
            {
                chatbot.SetUserName(input);
                waitingForName = false;
                string welcomeMsg = $"Hello, {input}! How can I help you with cybersecurity today?";
                chatOutput.AppendText($"CyberSecBot: {welcomeMsg}\n", Color.Green);
                LogActivity("System", $"User provided name: {input}");
                return;
            }

            // Check for special commands first
            if (input.ToLower() == "exit")
            {
                chatOutput.AppendText("CyberSecBot: Goodbye! Stay safe online!\n", Color.Green);
                LogActivity("System", "User exited the chat");
                Application.Exit();
                return;
            }
            else if (input.ToLower().Contains("show activity log") || input.ToLower().Contains("what have you done"))
            {
                ShowActivityLog();
                return;
            }
            else if (input.ToLower().Contains("add task") || input.ToLower().Contains("set reminder"))
            {
                HandleTaskCommand(input);
                return;
            }
            else if (input.ToLower().Contains("start quiz") || input.ToLower().Contains("take test"))
            {
                StartQuiz();
                return;
            }

            // Process normal chat input
            string response = GetBotResponse(input);
            chatOutput.AppendText($"CyberSecBot: {response}\n", Color.Green);
            LogActivity("Chat", $"User: '{input}' → Bot: '{response}'");
        }

        private string GetBotResponse(string input)
        {
            string response = chatbot.ProcessInput(input);
            string userName = chatbot.GetUserName();

            // Personalize responses
            response = response.Replace("{name}", userName);
            return AdjustForSentiment(response, chatbot.GetSentiment());
        }

        private string AdjustForSentiment(string response, string sentiment)
        {
            string userName = chatbot.GetUserName();

            switch (sentiment)
            {
                case "worried":
                    return $"{userName}, I understand this can be concerning. {response}";
                case "frustrated":
                    return $"{userName}, I'm here to help. {response}";
                case "curious":
                    return $"{userName}, great question! {response}";
                default:
                    return response;
            }
        }

        private void ShowActivityLog()
        {
            tabControl1.SelectedTab = tabActivityLog;
            chatOutput.AppendText("CyberSecBot: Here's your activity log. What else can I help with?\n", Color.Green);
            LogActivity("System", "User viewed activity log");
        }

        private void HandleTaskCommand(string input)
        {
            // Extract task details from input
            string taskTitle = "Cybersecurity Task";
            string taskDesc = "Important cybersecurity action";
            DateTime? reminderDate = null;

            if (input.ToLower().Contains("remind me"))
            {
                // Try to parse date/time from input
                if (input.ToLower().Contains("tomorrow"))
                {
                    reminderDate = DateTime.Now.AddDays(1);
                }
                else if (input.ToLower().Contains("next week"))
                {
                    reminderDate = DateTime.Now.AddDays(7);
                }
                else
                {
                    // Default reminder in 1 day
                    reminderDate = DateTime.Now.AddDays(1);
                }
            }

            // Add to tasks
            tasks.Add(new CyberTask(taskTitle, taskDesc, reminderDate));
            UpdateTaskList();

            // Respond
            string response = reminderDate.HasValue
                ? $"Task added! I'll remind you on {reminderDate.Value.ToString("MM/dd/yyyy")}."
                : "Task added! Would you like to set a reminder?";

            chatOutput.AppendText($"CyberSecBot: {response}\n", Color.Green);
            LogActivity("Task", $"Added task: '{taskTitle}' with reminder: {(reminderDate.HasValue ? reminderDate.Value.ToString() : "none")}");

            // Switch to tasks tab
            tabControl1.SelectedTab = tabTasks;
        }

        private void StartQuiz()
        {
            quizGame.Reset();
            ShowNextQuizQuestion();
            tabControl1.SelectedTab = tabQuiz;
            LogActivity("Quiz", "Started cybersecurity quiz");
        }

        private void ShowNextQuizQuestion()
        {
            if (quizGame.QuizCompleted)
            {
                ShowQuizResults();
                return;
            }

            var question = quizGame.Questions[quizGame.CurrentQuestionIndex];
            quizQuestionLabel.Text = question.QuestionText;
            quizOption1.Text = question.Options[0];
            quizOption2.Text = question.Options[1];
            quizOption3.Text = question.Options[2];
            quizOption4.Text = question.Options[3];
            quizResultLabel.Text = "";

            // Enable buttons for next question
            quizOption1.Enabled = true;
            quizOption2.Enabled = true;
            quizOption3.Enabled = true;
            quizOption4.Enabled = true;
        }

        private void ShowQuizResults()
        {
            double percentage = (double)quizGame.Score / quizGame.Questions.Count * 100;
            string resultMessage = $"Quiz completed! Your score: {quizGame.Score}/{quizGame.Questions.Count} ({percentage:0}%)";

            if (percentage >= 80)
                resultMessage += "\nExcellent! You're a cybersecurity expert!";
            else if (percentage >= 60)
                resultMessage += "\nGood job! You have solid cybersecurity knowledge.";
            else if (percentage >= 40)
                resultMessage += "\nNot bad! Keep learning to improve your security awareness.";
            else
                resultMessage += "\nKeep practicing! Cybersecurity is important for everyone.";

            quizResultLabel.Text = resultMessage;
            quizOption1.Enabled = false;
            quizOption2.Enabled = false;
            quizOption3.Enabled = false;
            quizOption4.Enabled = false;

            LogActivity("Quiz", $"Completed with score: {quizGame.Score}/{quizGame.Questions.Count}");
        }

        private void CheckQuizAnswer(int selectedOption)
        {
            if (quizGame.QuizCompleted) return;

            var question = quizGame.Questions[quizGame.CurrentQuestionIndex];
            bool isCorrect = quizGame.IsCorrect(selectedOption);

            if (isCorrect)
            {
                quizResultLabel.Text = "Correct! " + GetQuizFeedback(quizGame.CurrentQuestionIndex);
                quizResultLabel.ForeColor = Color.LightGreen;
            }
            else
            {
                quizResultLabel.Text = $"Incorrect. The correct answer was: {question.Options[question.CorrectAnswerIndex]}\n" +
                                    GetQuizFeedback(quizGame.CurrentQuestionIndex);
                quizResultLabel.ForeColor = Color.OrangeRed;
            }

            quizGame.ProcessAnswer(selectedOption);

            if (quizGame.QuizCompleted)
            {
                Task.Delay(1500).ContinueWith(_ =>
                {
                    this.Invoke((MethodInvoker)delegate {
                        ShowQuizResults();
                    });
                });
            }
            else
            {
                Task.Delay(1500).ContinueWith(_ =>
                {
                    this.Invoke((MethodInvoker)delegate {
                        ShowNextQuizQuestion();
                    });
                });
            }
        }

        private bool IsCorrect(int questionIndex, int selectedOption)
        {
            if (questionIndex < 0 || questionIndex >= quizQuestions.Count)
                return false;
            if (selectedOption < 0 || selectedOption >= 4)
                return false;

            return selectedOption == quizQuestions[questionIndex].CorrectAnswerIndex;
        }

        private string GetQuizFeedback(int questionIndex)
        {
            if (questionIndex < 0 || questionIndex >= quizGame.Questions.Count)
                return "Thanks for testing your cybersecurity knowledge!";

            switch (questionIndex)
            {
                case 0: // Password email question
                    return "Never share your password via email. Legitimate organizations will never ask for it this way.";
                case 1: // Secure password question
                    return "The most secure passwords are long, complex, and unique for each account.";
                case 2: // HTTPS question
                    return "HTTPS ensures your connection to the website is encrypted and secure.";
                case 3: // 2FA question
                    return "Two-factor authentication adds an extra layer of security beyond just a password.";
                case 4: // Public WiFi question
                    return "A VPN encrypts your connection on public networks, protecting your data.";
                case 5: // Software updates question
                    return "Regular updates patch security vulnerabilities that hackers could exploit.";
                case 6: // Phishing email question
                    return "Phishing emails often create a sense of urgency to trick you into acting quickly.";
                case 7: // Old devices question
                    return "Always wipe personal data from devices before disposing of them to prevent data theft.";
                case 8: // Password manager question
                    return "Password managers securely store and generate strong, unique passwords for all your accounts.";
                case 9: // Information sharing question
                    return "Sensitive personal information like SSN should never be shared online.";
                default:
                    return "Good job on the quiz! Remember to stay safe online.";
            }
        }

        private void UpdateTaskList()
        {
            taskList.Items.Clear();
            foreach (var task in tasks)
            {
                string taskText = task.Title;
                if (task.ReminderDate.HasValue)
                {
                    taskText += $" (Reminder: {task.ReminderDate.Value.ToString("MM/dd/yyyy")})";
                }
                taskList.Items.Add(taskText);
            }
        }

        // Button click handlers
        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            string title = taskTitleInput.Text.Trim();
            string desc = taskDescInput.Text.Trim();
            DateTime? reminder = reminderCheckBox.Checked ? reminderDatePicker.Value : (DateTime?)null;

            if (!string.IsNullOrEmpty(title))
            {
                tasks.Add(new CyberTask(title, desc, reminder));
                UpdateTaskList();
                taskTitleInput.Clear();
                taskDescInput.Clear();
                reminderCheckBox.Checked = false;

                string response = reminder.HasValue
                    ? $"Task '{title}' added with reminder set for {reminder.Value.ToString("MM/dd/yyyy")}."
                    : $"Task '{title}' added.";

                chatOutput.AppendText($"CyberSecBot: {response}\n", Color.Green);
                LogActivity("Task", $"Added task via GUI: '{title}'");
            }
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedIndex >= 0 && taskList.SelectedIndex < tasks.Count)
            {
                string taskTitle = tasks[taskList.SelectedIndex].Title;
                tasks.RemoveAt(taskList.SelectedIndex);
                UpdateTaskList();
                chatOutput.AppendText($"CyberSecBot: Task '{taskTitle}' deleted.\n", Color.Green);
                LogActivity("Task", $"Deleted task: '{taskTitle}'");
            }
        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedIndex >= 0 && taskList.SelectedIndex < tasks.Count)
            {
                string taskTitle = tasks[taskList.SelectedIndex].Title;
                tasks.RemoveAt(taskList.SelectedIndex);
                UpdateTaskList();
                chatOutput.AppendText($"CyberSecBot: Congratulations on completing '{taskTitle}'!\n", Color.Green);
                LogActivity("Task", $"Completed task: '{taskTitle}'");
            }
        }

        private void reminderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Enable or disable the date picker based on the checkbox state
            reminderDatePicker.Enabled = reminderCheckBox.Checked;

            // If the checkbox is checked, set a default reminder time (now + 1 day)
            if (reminderCheckBox.Checked)
            {
                reminderDatePicker.Value = DateTime.Now.AddDays(1);
            }

            LogActivity("Task", $"Reminder checkbox {(reminderCheckBox.Checked ? "checked" : "unchecked")}");
        }

        private void chatTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabChat;
        }

        private void tasksTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabTasks;
        }

        private void quizTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabQuiz;
        }

        private void logTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabActivityLog;
        }

        private void quizOption1_Click(object sender, EventArgs e)
        {
            CheckQuizAnswer(0);
        }

        private void quizOption2_Click(object sender, EventArgs e)
        {
            CheckQuizAnswer(1);
        }

        private void quizOption3_Click(object sender, EventArgs e)
        {
            CheckQuizAnswer(2);
        }

        private void quizOption4_Click(object sender, EventArgs e)
        {
            CheckQuizAnswer(3);
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}