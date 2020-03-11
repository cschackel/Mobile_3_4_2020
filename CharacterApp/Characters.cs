using System;
using System.Collections.Generic;

namespace CharacterApp
{
    public class Characters
    {
        public string Name { private set; get; }

        public int MinScore { private set; get; }

        public int MaxScore { private set; get; }

        public Characters(string name, int minScore, int maxScore)
        {
            Name = name;

            MinScore = minScore;
            MaxScore = maxScore;


        }

        static Characters()
        {
            All = new List<Characters>
            {
                // Part 1. Getting Started with XAML
                new Characters("Teal'c",-100,-6),
                new Characters("Daniel",-5,-1),
                new Characters("Sam",0,5),
                new Characters("Jack",6,100),
            };
        }

        public static IList<Characters> All { private set; get; }
    }
}
