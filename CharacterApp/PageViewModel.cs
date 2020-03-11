using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CharacterApp
{
    public class PageViewModel : INotifyPropertyChanged
    {
        public string test { get; } = "testingh";
        private int tempScore = 0;
        public event PropertyChangedEventHandler PropertyChanged;
        public int currentScore
        {
            set
            {
                if (tempScore != value)
                {
                    tempScore = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("currentScore"));
                }
            }
            get
            {
                return tempScore;
            }
        }

        
    }
}
