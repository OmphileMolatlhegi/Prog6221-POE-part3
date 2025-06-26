using System;
using System.Collections.Generic;

namespace CyberChatBotGUI
{
    internal class ChatBotCore
    {
        public abstract class CyberSecBot
        {
            protected Random random = new Random();
            public abstract string Process(string input, Dictionary<string, string> memory);
        }

        public class KeywordRecognizer : CyberSecBot
        {
            private Dictionary<string, List<string>> keywordResponses = new Dictionary<string, List<string>>()
            {
                { "password", new List<string> {
                    "{name}, always create complex passwords using letters, numbers, and symbols.",
                    "Make sure to use strong, unique passwords for each account, {name}.",
                    "{name}, consider using a password manager for better security.",
                    "A good password should be at least 12 characters long, {name}."
                }},
                { "phishing", new List<string> {
                    "{name}, phishing attacks usually come via email or messages—never click unknown links or give out personal info!",
                    "Be wary of unsolicited communications asking for personal information, {name}.",
                    "If an offer seems too good to be true, it probably is a scam, {name}."
                }},
                { "browsing", new List<string> {
                    "{name}, stick to secure (https) websites and steer clear of suspicious downloads or popups.",
                    "Always check for the padlock icon in your browser's address bar, {name}."
                }},
                { "malware", new List<string> {
                    "{name}, malware is malicious software designed to harm your device or steal your data.",
                    "Keep your antivirus software updated to protect against malware threats, {name}.",
                    "{name}, never download attachments from unknown senders to avoid malware infections.",
                    "Regular system scans can help detect and remove malware early, {name}."
                }},
                {"privacy", new List<String>(){
                    "{name}, privacy is about controlling who has access to your personal information and how it's used.",
                    "Review privacy settings on social media and apps regularly to limit data sharing, {name}.",
                    "{name}, use encryption tools for sensitive communications to protect your privacy.",
                    "Be cautious about what personal information you share online - once it's out there, it's hard to take back, {name}.",
                    "{name}, consider using privacy-focused browsers and search engines that don't track your activity.",
                    "Two-factor authentication adds an extra layer of privacy protection to your accounts, {name}."
                }},
                { "vpn", new List<string> {
                    "{name}, a VPN encrypts your internet connection to protect your privacy online.",
                    "Always use a VPN when connecting to public WiFi networks, {name}.",
                    "VPNs help mask your IP address and location from trackers, {name}.",
                    "{name}, choose a reputable VPN provider that doesn't keep activity logs."
                }},
                { "wifi", new List<string> {
                    "{name}, public WiFi networks are often unsecured - avoid sensitive transactions on them.",
                    "Use a VPN when connecting to public WiFi to encrypt your data, {name}.",
                    "Disable file sharing when using public WiFi networks, {name}.",
                    "{name}, your device might automatically connect to fake hotspots - disable auto-connect."
                }},
                { "mission", new List<string> {
                    "{name}, my mission is to share tips and guidance on staying safe in the digital world.",
                    "I'm here to help you navigate cybersecurity challenges, {name}."
                }},
                { "hello", new List<string> {
                    "Good day {name}, I'm here to help you stay safe online.",
                    "Hello {name}! Ready to learn about cybersecurity?"
                }},
                { "help", new List<string> {
                    "{name}, feel free to ask about password safety, phishing awareness, or how to browse safely on the internet.",
                    "I can chat with you about: strong passwords, phishing scams, and secure browsing habits, {name}."
                }},
                { "task", new List<string> {
                    "{name}, you can add tasks in the Tasks tab or by saying 'Add task [description]'.",
                    "I can help you manage cybersecurity tasks like password updates and security checks, {name}."
                }},
                { "quiz", new List<string> {
                    "{name}, you can test your cybersecurity knowledge in the Quiz tab or by saying 'Start quiz'.",
                    "The cybersecurity quiz has 10 questions to test your knowledge, {name}."
                }},
                { "log", new List<string> {
                    "{name}, you can view your activity log in the Activity Log tab or by saying 'Show activity log'.",
                    "The activity log keeps track of your interactions with me, {name}."
                }}
            };

            private Dictionary<string, List<string>> followUpResponses = new Dictionary<string, List<string>>()
            {
                { "password", new List<string> {
                    "{name}, would you like more tips about creating strong passwords?",
                    "I can also explain how password managers work if you're interested, {name}.",
                    "{name}, remember to change your passwords regularly. Need more advice?"
                }},
                { "phishing", new List<string> {
                    "{name}, would you like to know how to identify phishing emails?",
                    "I can tell you more about common phishing techniques if you want, {name}.",
                    "{name}, it's also important to know what to do if you fall for a phishing scam. Interested?"
                }},
                { "browsing", new List<string> {
                    "{name}, would you like tips for safer online shopping?",
                    "I can explain more about browser security settings if you'd like, {name}.",
                    "{name}, knowing about VPNs can also help with secure browsing. Want to learn more?"
                }},
                { "malware", new List<string> {
                    "{name}, would you like to learn how to spot malware infections on your device?",
                    "I can explain different types of malware and how they work, {name}.",
                    "{name}, interested in learning about the best anti-malware tools?",
                    "{name}, want to know how to prevent malware infections in the first place?"
                }},
                { "vpn", new List<string> {
                    "{name}, would you like recommendations for reliable VPN services?",
                    "I can explain how VPN encryption works to protect your data, {name}.",
                    "{name}, interested in learning when you should always use a VPN?",
                    "{name}, want to know how to set up a VPN on your devices?"
                }},
                { "wifi", new List<string> {
                    "{name}, would you like to know the specific risks of using public WiFi?",
                    "I can share techniques to stay safe on public networks, {name}.",
                    "{name}, interested in learning about WiFi security tools?",
                    "{name}, want to know what activities you should never do on public WiFi?"
                }}
            };

            public override string Process(string input, Dictionary<string, string> memory)
            {
                string lowerInput = input.ToLower();
                string response = null;

                // Enhanced NLP for task commands
                if (lowerInput.Contains("add task") || lowerInput.Contains("set reminder") ||
                    lowerInput.Contains("remind me") || lowerInput.Contains("create task"))
                {
                    memory["last_command"] = "task_command";
                    return "TASK_COMMAND:" + ExtractTaskDetails(lowerInput);
                }

                // Enhanced NLP for quiz commands
                if (lowerInput.Contains("start quiz") || lowerInput.Contains("take test") ||
                    lowerInput.Contains("cybersecurity quiz") || lowerInput.Contains("begin quiz"))
                {
                    memory["last_command"] = "quiz_command";
                    return "QUIZ_COMMAND:Let's test your cybersecurity knowledge!";
                }

                // Enhanced NLP for activity log
                if (lowerInput.Contains("show activity log") || lowerInput.Contains("what have you done") ||
                    lowerInput.Contains("view history") || lowerInput.Contains("my activity"))
                {
                    memory["last_command"] = "log_command";
                    return "LOG_COMMAND:Here's your activity log.";
                }

                // Check if this is a follow-up question
                if (memory.ContainsKey("last_topic") &&
                    (lowerInput.Contains("more") || lowerInput.Contains("explain") ||
                     lowerInput.Contains("yes") || lowerInput.Contains("tell me")))
                {
                    string lastTopic = memory["last_topic"];
                    if (followUpResponses.ContainsKey(lastTopic))
                    {
                        var responses = followUpResponses[lastTopic];
                        response = responses[random.Next(responses.Count)];
                        memory["awaiting_followup"] = "true";
                        return response;
                    }
                }

                // Handle new topic
                foreach (var keyword in keywordResponses.Keys)
                {
                    if (lowerInput.Contains(keyword))
                    {
                        var responses = keywordResponses[keyword];
                        response = responses[random.Next(responses.Count)];
                        memory["last_topic"] = keyword;
                        memory["awaiting_followup"] = "true";
                        return response;
                    }
                }

                // Handle confusion or requests for clarification
                if (lowerInput.Contains("confused") || lowerInput.Contains("don't understand") ||
                    lowerInput.Contains("not sure"))
                {
                    if (memory.ContainsKey("last_topic"))
                    {
                        response = $"{memory["name"]}, let me explain that differently about {memory["last_topic"]}. " +
                                 keywordResponses[memory["last_topic"]][random.Next(keywordResponses[memory["last_topic"]].Count)];
                        return response;
                    }
                    else
                    {
                        return "I'm sorry you're confused. Could you tell me what cybersecurity topic you're interested in?";
                    }
                }

                return response ?? "I'm not sure I understand. Could you ask about passwords, phishing, or safe browsing?";
            }

            private string ExtractTaskDetails(string input)
            {
                // Extract task details from natural language input
                string title = "Cybersecurity Task";
                string desc = "Important security action";

                if (input.Contains("password"))
                    title = "Update Password";
                else if (input.Contains("2fa") || input.Contains("two-factor"))
                    title = "Enable Two-Factor Authentication";
                else if (input.Contains("privacy"))
                    title = "Review Privacy Settings";
                else if (input.Contains("update") || input.Contains("upgrade"))
                    title = "Update Security Software";
                else if (input.Contains("scan") || input.Contains("malware"))
                    title = "Run Security Scan";

                return $"{title}|{desc}";
            }
        }

        public class SentimentAnalyzer : CyberSecBot
        {
            public override string Process(string input, Dictionary<string, string> memory)
            {
                string lowerInput = input.ToLower();

                if (lowerInput.Contains("worried") || lowerInput.Contains("concerned") ||
                    lowerInput.Contains("scared") || lowerInput.Contains("nervous") ||
                    lowerInput.Contains("anxious") || lowerInput.Contains("fear"))
                    return "worried";

                if (lowerInput.Contains("frustrated") || lowerInput.Contains("angry") ||
                    lowerInput.Contains("annoyed") || lowerInput.Contains("upset") ||
                    lowerInput.Contains("mad") || lowerInput.Contains("irritated"))
                    return "frustrated";

                if (lowerInput.Contains("curious") || lowerInput.Contains("wonder") ||
                    lowerInput.Contains("interested") || lowerInput.Contains("tell me more") ||
                    lowerInput.Contains("explain") || lowerInput.Contains("how does"))
                    return "curious";

                return "neutral";
            }
        }

        public class MemoryManager : CyberSecBot
        {
            public override string Process(string input, Dictionary<string, string> memory)
            {
                string lowerInput = input.ToLower();
                string response = null;

                // Store user's interests
                if (lowerInput.Contains("i'm interested in") || lowerInput.Contains("i like") ||
                    lowerInput.Contains("i care about") || lowerInput.Contains("my interest is"))
                {
                    foreach (var topic in new[] { "wifi", "vpn", "passwords", "phishing", "browsing", "privacy", "malware" })
                    {
                        if (lowerInput.Contains(topic))
                        {
                            memory["interest"] = topic;
                            response = $"Great {memory["name"]}! I'll remember that you're interested in {topic}. " +
                                      GetInterestBasedResponse(topic);
                            return response;
                        }
                    }
                }

                // Store user's name when mentioned
                if (lowerInput.Contains("my name is") || lowerInput.Contains("i am") ||
                    lowerInput.Contains("call me"))
                {
                    // Extract name from input
                    string name = "friend";
                    if (lowerInput.Contains("my name is"))
                        name = ExtractName(lowerInput, "my name is");
                    else if (lowerInput.Contains("i am"))
                        name = ExtractName(lowerInput, "i am");
                    else if (lowerInput.Contains("call me"))
                        name = ExtractName(lowerInput, "call me");

                    memory["name"] = name;
                    return $"Nice to meet you, {name}! How can I help with cybersecurity today?";
                }

                // Recall stored information
                if (lowerInput.Contains("remember") || lowerInput.Contains("my name") ||
                    lowerInput.Contains("what do you know") || lowerInput.Contains("do you remember"))
                {
                    if (memory.ContainsKey("name") && memory.ContainsKey("interest"))
                    {
                        return $"{memory["name"]}, I remember you're interested in {memory["interest"]}. " +
                               GetPersonalizedTip(memory["interest"]);
                    }
                    else if (memory.ContainsKey("name"))
                    {
                        return $"I remember you, {memory["name"]}! But I don't know your interests yet.";
                    }
                    else if (memory.ContainsKey("interest"))
                    {
                        return $"I remember you're interested in {memory["interest"]}. " +
                               GetPersonalizedTip(memory["interest"]);
                    }
                    return "I don't know much about you yet. Tell me your name or interests!";
                }

                // Personalize responses when possible
                if (memory.ContainsKey("interest") &&
                    (lowerInput.Contains("tip") || lowerInput.Contains("advice") ||
                     lowerInput.Contains("suggestion") || lowerInput.Contains("recommendation")))
                {
                    return GetPersonalizedTip(memory["interest"]);
                }

                return null;
            }

            private string ExtractName(string input, string prefix)
            {
                int startIndex = input.IndexOf(prefix) + prefix.Length;
                if (startIndex >= input.Length) return "friend";

                string namePart = input.Substring(startIndex).Trim();
                if (namePart.Contains(" ")) namePart = namePart.Substring(0, namePart.IndexOf(" "));
                if (namePart.Length > 20) namePart = namePart.Substring(0, 20);

                return char.ToUpper(namePart[0]) + namePart.Substring(1);
            }

            private string GetInterestBasedResponse(string topic)
            {
                var responses = new Dictionary<string, List<string>>()
                {
                    { "passwords", new List<string> {
                        "Passwords are your first line of defense!",
                        "Excellent! Strong passwords protect all your accounts.",
                        "Password security is fundamental to online safety."
                    }},
                    { "phishing", new List<string> {
                        "Phishing awareness can save you from many scams!",
                        "Smart choice! Recognizing phishing attempts is a vital skill.",
                        "Phishing is one of the most common cyber threats today."
                    }},
                    { "browsing", new List<string> {
                        "Safe browsing habits protect you from many online dangers!",
                        "Great! Secure browsing is essential for everyone.",
                        "Being careful online can prevent many security issues."
                    }},
                    { "malware", new List<string> {
                        "Malware protection is crucial for device security!",
                        "Good choice! Understanding malware helps keep your devices safe.",
                        "Malware can cause significant damage if not prevented."
                    }},
                    { "vpn", new List<string> {
                        "VPNs are essential for online privacy!",
                        "Excellent choice! VPNs protect your internet connection.",
                        "Using a VPN is a smart way to enhance your security."
                    }},
                    { "wifi", new List<string> {
                        "Understanding WiFi security is important!",
                        "Good choice! Public WiFi can be risky without precautions.",
                        "Securing your WiFi connections protects your data."
                    }},
                    { "privacy", new List<string> {
                        "Privacy protection is fundamental in the digital age!",
                        "Great choice! Maintaining privacy helps protect your identity.",
                        "Controlling your personal information is crucial for security."
                    }}
                };

                if (responses.ContainsKey(topic))
                {
                    return responses[topic][random.Next(responses[topic].Count)];
                }
                return "It's an important topic in cybersecurity!";
            }

            private string GetPersonalizedTip(string topic)
            {
                var tips = new Dictionary<string, List<string>>()
                {
                    { "passwords", new List<string> {
                        "Since you care about passwords, have you tried a password manager?",
                        "For password security, enable two-factor authentication where possible.",
                        "Remember to never reuse passwords across different sites!"
                    }},
                    { "phishing", new List<string> {
                        "For phishing protection, always verify sender email addresses.",
                        "As a phishing-aware user, remember: banks never ask for credentials via email.",
                        "Hover over links before clicking to see the real destination."
                    }},
                    { "browsing", new List<string> {
                        "For safer browsing, consider using a VPN on public networks.",
                        "Always look for HTTPS in the address bar when entering sensitive info.",
                        "Clear your browser cache regularly to protect your browsing history."
                    }},
                    { "malware", new List<string> {
                        "For malware protection, avoid downloading files from untrusted sources.",
                        "Keep your operating system and applications updated to patch vulnerabilities.",
                        "Use a reputable antivirus program and scan your devices regularly."
                    }},
                    { "vpn", new List<string> {
                        "For VPN users, always connect to the VPN before accessing sensitive sites.",
                        "Choose a VPN provider that doesn't keep logs of your online activity.",
                        "Test your VPN connection for leaks to ensure your privacy."
                    }},
                    { "wifi", new List<string> {
                        "When using public WiFi, avoid accessing financial accounts.",
                        "Disable automatic connection to WiFi networks on your devices.",
                        "Use a VPN whenever connecting to public WiFi networks."
                    }},
                    { "privacy", new List<string> {
                        "For better privacy, review app permissions regularly.",
                        "Use private browsing mode when you don't want to save history.",
                        "Consider using encrypted messaging apps for sensitive communications."
                    }}
                };

                if (tips.ContainsKey(topic))
                {
                    return tips[topic][random.Next(tips[topic].Count)];
                }
                return "Here's a security tip: always keep your software updated!";
            }
        }
    }
}