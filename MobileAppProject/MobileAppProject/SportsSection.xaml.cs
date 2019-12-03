using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SportsSection : ContentPage
	{
        private Questions questionGenerator;
        private String[][] questions =
        {
            // {0, 1, 2, 3, 4, 5 } - Correct Answer at index 5
            new string[] {"Question 1 PlaceHolder", "ANS 1-1", "ANS 2-1", "ANS 3-1", "ANS 4-1", "ANS 3-1"},
            new string[] {"Question 2 PlaceHolder", "ANS 1-2", "ANS 2-2", "ANS 3-2", "ANS 4-2", "ANS 3-2"},
            new string[] {"Question 3 PlaceHolder", "ANS 1-3", "ANS 2-3", "ANS 3-3", "ANS 4-3", "ANS 1-3"},
            new string[] {"Question 4 PlaceHolder", "ANS 1-4", "ANS 2-4", "ANS 3-4", "ANS 4-4", "ANS 4-4"},
            new string[] {"Question 5 PlaceHolder", "ANS 1-5", "ANS 2-5", "ANS 3-5", "ANS 4-5", "ANS 2-5"},
            new string[] {"Question 6 PlaceHolder", "ANS 1-6", "ANS 2-6", "ANS 3-6", "ANS 4-6", "ANS 2-6"},
            new string[] {"Question 7 PlaceHolder", "ANS 1-7", "ANS 2-7", "ANS 3-7", "ANS 4-7", "ANS 3-7"},
            new string[] {"Question 8 PlaceHolder", "ANS 1-8", "ANS 2-8", "ANS 3-8", "ANS 4-8", "ANS 2-8"},
            new string[] {"Question 9 PlaceHolder", "ANS 1-9", "ANS 2-9", "ANS 3-9", "ANS 4-9", "ANS 1-9"},
            new string[] {"Question 10 PlaceHolder", "ANS 1-10", "ANS 2-10", "ANS 3-10", "ANS 4-10", "ANS 3-10"}
        };

        private int[] numberQuestion = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int[] answerOrder = new int[] { 1, 2, 3, 4 };

        private int currentQuestion = 0;
        private int sameQuestion = -1;
        private int correctAnswerCounter = 0;
        private int answerButtonReset;
        private bool incorrectAnswer;
        private Button answerSelected;

        public SportsSection()
		{
			InitializeComponent();         

            if (questionGenerator == null)
                questionGenerator = new Questions();

            questionGenerator.ShuffleArrays(numberQuestion);
            DisplayQuestion(currentQuestion);
        }

        private void DisplayQuestion(int currQues)
        {
            NextSportsBtn.IsEnabled = false;
            questionGenerator.ShuffleArrays(answerOrder);
            Question.Text = questions[numberQuestion[currQues]][0];
            AnswerOneBtn.Text = questions[numberQuestion[currQues]][answerOrder[0]];
            AnswerTwoBtn.Text = questions[numberQuestion[currQues]][answerOrder[1]];
            AnswerThreeBtn.Text = questions[numberQuestion[currQues]][answerOrder[2]];
            AnswerFourBtn.Text = questions[numberQuestion[currQues]][answerOrder[3]];
        }

        private void NextSportsBtn_Clicked(object sender, EventArgs e)
        {          
            currentQuestion++;
            answerSelected.BackgroundColor = Color.Lavender; // reset button color
            if (incorrectAnswer)
            {
                switch (answerButtonReset)
                {
                    case 1:
                        AnswerOneBtn.BackgroundColor = Color.Lavender;
                        break;
                    case 2:
                        AnswerTwoBtn.BackgroundColor = Color.Lavender;
                        break;
                    case 3:
                        AnswerThreeBtn.BackgroundColor = Color.Lavender;
                        break;
                    case 4:
                        AnswerFourBtn.BackgroundColor = Color.Lavender;
                        break;
                }
            }

            if (currentQuestion == (questions.Length - 1))
            {
                NextSportsBtn.IsVisible = false;
                EndSportsBtn.IsVisible = true;
            }
            DisplayQuestion(currentQuestion);
        }

        private void Answer_Clicked(object sender, EventArgs e)
        {
            if (sameQuestion != currentQuestion)
            {
                sameQuestion++;
                answerSelected = (Button)sender;

                if (answerSelected.Text.Equals(questions[numberQuestion[currentQuestion]][5]))
                {
                    correctAnswerCounter++;
                    incorrectAnswer = false;
                    answerSelected.BackgroundColor = Color.Green;
                }
                else
                {
                    incorrectAnswer = true;
                    answerSelected.BackgroundColor = Color.Red;
                    if (AnswerOneBtn.Text.Equals(questions[numberQuestion[currentQuestion]][5]))
                    {
                        AnswerOneBtn.BackgroundColor = Color.Green;
                        answerButtonReset = 1;
                    }
                    else if (AnswerTwoBtn.Text.Equals(questions[numberQuestion[currentQuestion]][5]))
                    {
                        AnswerTwoBtn.BackgroundColor = Color.Green;
                        answerButtonReset = 2;
                    }
                    else if (AnswerThreeBtn.Text.Equals(questions[numberQuestion[currentQuestion]][5]))
                    {
                        AnswerThreeBtn.BackgroundColor = Color.Green;
                        answerButtonReset = 3;
                    }
                    else
                    {
                        AnswerFourBtn.BackgroundColor = Color.Green;
                        answerButtonReset = 4;
                    }
                }

                if (currentQuestion == (questions.Length - 1))
                    EndSportsBtn.IsEnabled = true;
                else
                    NextSportsBtn.IsEnabled = true;
            }
        }
    }
}