using System;

namespace CyberChatBotGUI
{
    public class CyberTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ReminderDate { get; set; }
        public DateTime CreationDate { get; }
        public bool IsCompleted { get; set; }

        public CyberTask(string title, string description, DateTime? reminderDate)
        {
            Title = title;
            Description = description;
            ReminderDate = reminderDate;
            CreationDate = DateTime.Now;
            IsCompleted = false;
        }

        public string ToDisplayString()
        {
            string status = IsCompleted ? "[COMPLETED] " : "";
            string reminderInfo = ReminderDate.HasValue
                ? $" (Reminder: {ReminderDate.Value.ToString("MM/dd/yyyy hh:mm tt")})"
                : "";

            return $"{status}{Title}{reminderInfo}";
        }

        public bool IsReminderDue()
        {
            return ReminderDate.HasValue && DateTime.Now >= ReminderDate.Value && !IsCompleted;
        }
    }
}