using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CharacterApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        IList<Characters> characters;
        IList<Questions> questions;
        Questions currentQuestion;
        int currentScore;

        public MainPage()
        {
            InitializeComponent();
            questions = Questions.All;
            characters = Characters.All;
            if(questions.Count > 0 && characters.Count > 0)
            {
                currentQuestion = questions.First();
                mainLabel.Text = currentQuestion.Text;
            }
            else
            {
                mainLabel.Text = "No Questions";
                disableButtons();
            }
            currentQuestion = questions.First();
            currentScore = 0;

        }

        private void disableButtons()
        {
            falseBtn.IsVisible = false;
            trueBtn.IsVisible = false;
        }

        private void questionChange()
        {

            int currentElement = questions.IndexOf(currentQuestion);
            if (currentElement < questions.Count - 1)
            {
                currentQuestion = questions.ElementAt(questions.IndexOf(currentQuestion) + 1);
                mainLabel.Text = currentQuestion.Text;
            }
            else
            {
                disableButtons();
                determineCharacter();
            }
        }

        private void determineCharacter()
        {
            foreach(Characters c in characters)
            {
                if(currentScore >= c.MinScore && currentScore <= c.MaxScore)
                {
                    mainLabel.Text = "You are "+ c.Name;
                }
            }
        }



        public void OnTrueClick(object sender, EventArgs args)
        {
            currentScore += currentQuestion.TrueValue;
            questionChange();
        }

        public void OnFalseClick(object sender, EventArgs args)
        {
            currentScore += currentQuestion.FalseValue;
            questionChange();
        }

    }
}
