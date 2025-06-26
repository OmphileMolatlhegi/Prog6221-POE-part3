using System;
using System.Collections.Generic;

namespace CyberChatBotGUI
{

    public class QuizQuestion
    {
        public string QuestionText { get; }
        public List<string> Options { get; }
        public int CorrectAnswerIndex { get; }

        public QuizQuestion(string questionText, List<string> options, int correctAnswerIndex)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(questionText))
                throw new ArgumentException("Question text cannot be null or empty", nameof(questionText));

            if (options == null || options.Count < 2)
                throw new ArgumentException("At least two options are required", nameof(options));

            if (correctAnswerIndex < 0 || correctAnswerIndex >= options.Count)
                throw new ArgumentOutOfRangeException(nameof(correctAnswerIndex), "Correct answer index is out of range");

            QuestionText = questionText;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool IsCorrect(int selectedIndex)
        {
            return selectedIndex == CorrectAnswerIndex;
        }

        public override string ToString()
        {
            return $"{QuestionText} [Correct: {Options[CorrectAnswerIndex]}]";
        }
    }

}