using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberChatBotGUI
{
    public class ActivityLogEntry
    {
        public DateTime Timestamp { get; }
        public string Category { get; }
        public string Description { get; }

        public ActivityLogEntry(string category, string description)
        {
            Timestamp = DateTime.Now;
            Category = category;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} - [{Category}] {Description}";
        }
    }
}
