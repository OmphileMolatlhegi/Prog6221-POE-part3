# Prog6221 POE part3

Overview
CyberSecBot is a Windows desktop application designed to educate users about cybersecurity best practices through interactive chat, task management, quizzes, and activity logging. The application features a chatbot that can answer questions about various cybersecurity topics, help manage security-related tasks, and test users' knowledge with a quiz.
Features
Interactive Chatbot:
Answers questions about cybersecurity topics (passwords, phishing, malware, VPNs, etc.)
Understands natural language commands
Remembers user preferences and name
Detects user sentiment (worried, frustrated, curious)

Task Management:
Create, complete, and delete cybersecurity tasks
Set reminders for important security actions
Categorize tasks (password updates, security scans, etc.)

Cybersecurity Quiz:
10-question quiz to test cybersecurity knowledge
Immediate feedback and explanations
Score tracking

Activity Log:
Tracks all user interactions
Records tasks, quiz attempts, and chat history
Limited to last 10 entries for quick reference
Technical Details

Project Structure
ChatBotCore.cs: Core chatbot logic with keyword recognition, sentiment analysis, and memory management
CyberSecBot.cs: Main bot class that coordinates components
QuizQuestion.cs: Data structure for quiz questions
QuizGame.cs: Manages quiz state and questions
CyberTask.cs: Represents security-related tasks
ActivityLogEntry.cs: Log entry structure
Form1.cs: Main application form with UI logic
Program.cs: Application entry point

Dependencies
.NET Framework 4.7.2 or later
System.Windows.Forms
System.Drawing
System.Media (for sound effects)

How to Use
Initial Setup:
Run the application
Enter your name when prompted

Chat Interface:
Type questions about cybersecurity topics
Use natural language commands like:
"Add task to update my passwords tomorrow"
"Start quiz"
"Show activity log"

Task Management:
Add tasks via chat or the Tasks tab
Set reminders for important actions
Mark tasks as completed when done

Quiz:
Start the quiz via chat command or the Quiz tab
Answer multiple-choice questions
View your score and feedback at the end

Activity Log:
View recent activities in the Activity Log tab
See timestamps and categories for all actions
Code Organization
The project follows a modular design:
Core Components:
CyberSecBot coordinates all functionality
KeywordRecognizer handles natural language processing
SentimentAnalyzer detects user emotions
MemoryManager stores user preferences
Data Structures:
QuizQuestion and QuizGame manage quiz content
CyberTask represents security tasks
ActivityLogEntry tracks user activities

UI Layer:
MainForm contains all Windows Forms components
Tab-based interface for different features
Rich text formatting for chat messages
Future Enhancements
Add more cybersecurity topics and responses
Implement cloud sync for tasks and preferences
Add more quiz questions with varying difficulty
Implement a learning progress system
Add multimedia content (videos, images) for education

License
This project is open-source and available under the MIT License.
