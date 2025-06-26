using System;
using System.Collections.Generic;

namespace CyberChatBotGUI
{
    internal class CyberSecBot : ChatBotCore
    {
        private List<CyberSecBot> components = new List<CyberSecBot>();
        private Dictionary<string, string> memory = new Dictionary<string, string>();
        private string currentSentiment = "neutral";

        public CyberSecBot()
        {
            components.Add(new KeywordRecognizer());
            components.Add(new SentimentAnalyzer());
            components.Add(new MemoryManager());
        }

        public void SetUserName(string name)
        {
            if (memory.ContainsKey("name"))
                memory["name"] = name;
            else
                memory.Add("name", name);
        }

        public string GetUserName()
        {
            return memory.ContainsKey("name") ? memory["name"] : "friend";
        }

        public string GetSentiment()
        {
            return currentSentiment;
        }

        public string ProcessInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "I didn't receive any input. Please try again.";

            string response = "";
            string sentiment = "neutral";

            foreach (var component in components)
            {
                string result = component.Process(input, memory);

                if (component is SentimentAnalyzer)
                {
                    currentSentiment = result ?? "neutral";
                    sentiment = currentSentiment;
                }
                else if (result != null)
                {
                    if (result.StartsWith("TASK_COMMAND:"))
                    {
                        return HandleTaskCommand(result.Replace("TASK_COMMAND:", ""));
                    }
                    else if (result.StartsWith("QUIZ_COMMAND:"))
                    {
                        return HandleQuizCommand(result.Replace("QUIZ_COMMAND:", ""));
                    }
                    else if (result.StartsWith("LOG_COMMAND:"))
                    {
                        return HandleLogCommand(result.Replace("LOG_COMMAND:", ""));
                    }
                    else
                    {
                        response += result + " ";
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(response))
            {
                return "I'm not sure I understand. Could you ask about cybersecurity topics?";
            }

            return response.Trim();
        }

        private string HandleTaskCommand(string taskDetails)
        {
            string userName = GetUserName();
            string[] parts = taskDetails.Split('|');
            string title = parts.Length > 0 ? parts[0] : "Cybersecurity Task";
            string desc = parts.Length > 1 ? parts[1] : "Important security action";

            return $"{userName}, I'll help you with the task '{title}' in the Tasks section.";
        }

        private string HandleQuizCommand(string quizDetails)
        {
            string userName = GetUserName();
            return $"{userName}, let's test your cybersecurity knowledge! Check the Quiz tab.";
        }

        private string HandleLogCommand(string logDetails)
        {
            string userName = GetUserName();
            return $"{userName}, you can view your activity log in the Activity Log tab.";
        }
    }
}