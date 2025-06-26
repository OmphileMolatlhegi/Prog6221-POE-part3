using System;
using System.Collections.Generic;

namespace CyberChatBotGUI
{
    public class QuizGame
    {
        public List<QuizQuestion> Questions { get; } = new List<QuizQuestion>();
        public int CurrentQuestionIndex { get; private set; } = 0;
        public int Score { get; private set; } = 0;
        public bool QuizCompleted => CurrentQuestionIndex >= Questions.Count;

        public QuizGame()
        {
            InitializeQuestions();
        }

        private void InitializeQuestions()
        {
            Questions.Add(new QuizQuestion(
                "What should you do if you receive an email asking for your password?",
                new List<string> { "Reply with your password", "Delete the email", "Report the email as phishing", "Ignore it" },
                2)); // Correct answer: Report the email as phishing

            Questions.Add(new QuizQuestion(
                "Which of these is the most secure password?",
                new List<string> { "password123", "John1985", "P@ssw0rd!", "Tr0ub4dor&3" },
                3)); // Correct answer: Tr0ub4dor&3

            Questions.Add(new QuizQuestion(
                "What does HTTPS in a website URL indicate?",
                new List<string> { "The site has videos", "The connection is encrypted", "The site is government-run", "The site is popular" },
                1)); // Correct answer: The connection is encrypted

            Questions.Add(new QuizQuestion(
                "What is two-factor authentication?",
                new List<string> { "Using two passwords", "Verifying identity with two methods", "Logging in from two devices", "Having two email accounts" },
                1)); // Correct answer: Verifying identity with two methods

            Questions.Add(new QuizQuestion(
                "What should you do before connecting to public WiFi?",
                new List<string> { "Disable your firewall", "Enable a VPN", "Share your location", "Update your social media" },
                1)); // Correct answer: Enable a VPN

            Questions.Add(new QuizQuestion(
                "How often should you update your software?",
                new List<string> { "Only when it stops working", "Every 6 months", "Whenever updates are available", "Never" },
                2)); // Correct answer: Whenever updates are available

            Questions.Add(new QuizQuestion(
                "What is a common sign of a phishing email?",
                new List<string> { "Professional logo", "Urgent action required", "Personalized greeting", "Company contact information" },
                1)); // Correct answer: Urgent action required

            Questions.Add(new QuizQuestion(
                "What should you do with old devices before disposing of them?",
                new List<string> { "Throw them away", "Sell them as-is", "Factory reset and wipe data", "Give them to a friend" },
                2)); // Correct answer: Factory reset and wipe data

            Questions.Add(new QuizQuestion(
                "What is the purpose of a password manager?",
                new List<string> { "To remember all your passwords", "To generate weak passwords", "To share passwords with friends", "To store passwords in a browser" },
                0)); // Correct answer: To remember all your passwords

            Questions.Add(new QuizQuestion(
                "What information should you never share online?",
                new List<string> { "Your favorite movie", "Your pet's name", "Your social security number", "Your vacation plans" },
                2)); // Correct answer: Your social security number
        }

        public bool IsCorrect(int selectedOption)
        {
            if (CurrentQuestionIndex < 0 || CurrentQuestionIndex >= Questions.Count)
                return false;

            return selectedOption == Questions[CurrentQuestionIndex].CorrectAnswerIndex;
        }

        public void ProcessAnswer(int selectedOption)
        {
            if (IsCorrect(selectedOption))
            {
                Score++;
            }
            CurrentQuestionIndex++;
        }

        public void Reset()
        {
            CurrentQuestionIndex = 0;
            Score = 0;
        }

        public QuizQuestion GetCurrentQuestion()
        {
            if (CurrentQuestionIndex < Questions.Count)
            {
                return Questions[CurrentQuestionIndex];
            }
            return null;
        }

        public string GetQuestionText()
        {
            var question = GetCurrentQuestion();
            return question?.QuestionText ?? "Quiz completed!";
        }

        public List<string> GetCurrentOptions()
        {
            var question = GetCurrentQuestion();
            return question?.Options ?? new List<string>();
        }
    }
}