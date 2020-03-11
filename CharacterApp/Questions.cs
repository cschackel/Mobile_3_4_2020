using System;
using System.Collections.Generic;

namespace CharacterApp
{
    public class Questions
    {
        public Questions(string text, int posScore, int negScore)
        {

            //Type = type;
            Text = text;
            TrueValue = posScore;
            FalseValue = negScore;
        }

        //public Type Type { private set; get; }

        public string Text { private set; get; }

        public int  TrueValue { private set; get; }

        public int  FalseValue { private set; get; }

        static Questions()
        {
            All = new List<Questions>
            {
                // Part 1. Getting Started with XAML
                new Questions("Do you prefer diet soda?",
                                      2,-2),
                new Questions("Have you now,or at any time, been dead?",
                                      -2,2),
                new Questions("Do you like Minnesota?",
                                      3,-3),
                new Questions("Are you an orphan?",
                                      -3,3)
            };
        }

        public static IList<Questions> All { private set; get; }
    }
    
}

