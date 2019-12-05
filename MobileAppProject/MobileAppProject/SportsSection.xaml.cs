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
        private const int CORRECT_ANSWER_INDEX = 5;
        private const int MAX_QUESTIONS = 10;

        private Quiz questionGenerator;
        private string[][] questions;
        private int[] questionNumber = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        private int[] answerNumber = new int[] { 1, 2, 3, 4 };

        private int currentQuestion = 0; // start at Question 1 (index 0)
        private int sameQuestion = -1;
        private int correctAnswerCounter = 0;
        private int answerButtonReset;
        private bool incorrectAnswer;
        private Button answerSelected;
        private Color unAnsweredColour = Color.LightGray;
        private Color correctAnswerColor = Color.Green;
        private Color inCorrectAnswerColor = Color.Red;

        public SportsSection()
		{
			InitializeComponent();         

            if (questionGenerator == null)
                questionGenerator = new Quiz();

            questions = questionGenerator.GetSportQuestions();
            questionGenerator.ShuffleQuestionOrAnswerNumbers(questionNumber);
            LoadQuestionImage();
            DisplayQuestion(currentQuestion);
        }

        private void LoadQuestionImage()
        {
            var assembly = typeof(SportsSection);
            string imageLocation = questionGenerator.GetQuestionImages(currentQuestion);
            QuestionImage.Source = ImageSource.FromResource(imageLocation, assembly);
        }

        private void DisplayQuestion(int currQues)
        {
            NextQuestionBtn.IsEnabled = false;
            questionGenerator.ShuffleQuestionOrAnswerNumbers(answerNumber); // shuffle the order in which Answers appear
            QuestionLbl.Text = questions[questionNumber[currQues]][0];
            AnswerOneBtn.Text = questions[questionNumber[currQues]][answerNumber[0]];
            AnswerTwoBtn.Text = questions[questionNumber[currQues]][answerNumber[1]];
            AnswerThreeBtn.Text = questions[questionNumber[currQues]][answerNumber[2]];
            AnswerFourBtn.Text = questions[questionNumber[currQues]][answerNumber[3]];
        }

        private void NextQuestionBtn_Clicked(object sender, EventArgs e)
        {          
            currentQuestion++;
            answerSelected.BackgroundColor = unAnsweredColour; // reset button color
            if (incorrectAnswer)
            {
                switch (answerButtonReset)
                {
                    case 1:
                        AnswerOneBtn.BackgroundColor = unAnsweredColour;
                        break;
                    case 2:
                        AnswerTwoBtn.BackgroundColor = unAnsweredColour;
                        break;
                    case 3:
                        AnswerThreeBtn.BackgroundColor = unAnsweredColour;
                        break;
                    case 4:
                        AnswerFourBtn.BackgroundColor = unAnsweredColour;
                        break;
                }
            }

            if (currentQuestion == (MAX_QUESTIONS - 1))
            {
                NextQuestionBtn.IsVisible = false;
                EndQuizBtn.IsVisible = true;
            }
            LoadQuestionImage();
            DisplayQuestion(currentQuestion);
        }

        private void Answer_Clicked(object sender, EventArgs e)
        {
            if (sameQuestion != currentQuestion)
            {
                sameQuestion++;
                answerSelected = (Button)sender;

                if (answerSelected.Text.Equals(questions[questionNumber[currentQuestion]][CORRECT_ANSWER_INDEX]))
                {
                    correctAnswerCounter++;
                    incorrectAnswer = false;
                    answerSelected.BackgroundColor = correctAnswerColor;
                }
                else
                {
                    incorrectAnswer = true;
                    answerSelected.BackgroundColor = inCorrectAnswerColor;
                    if (AnswerOneBtn.Text.Equals(questions[questionNumber[currentQuestion]][CORRECT_ANSWER_INDEX]))
                    {
                        AnswerOneBtn.BackgroundColor = correctAnswerColor;
                        answerButtonReset = 1;
                    }
                    else if (AnswerTwoBtn.Text.Equals(questions[questionNumber[currentQuestion]][CORRECT_ANSWER_INDEX]))
                    {
                        AnswerTwoBtn.BackgroundColor = correctAnswerColor;
                        answerButtonReset = 2;
                    }
                    else if (AnswerThreeBtn.Text.Equals(questions[questionNumber[currentQuestion]][CORRECT_ANSWER_INDEX]))
                    {
                        AnswerThreeBtn.BackgroundColor = correctAnswerColor;
                        answerButtonReset = 3;
                    }
                    else
                    {
                        AnswerFourBtn.BackgroundColor = correctAnswerColor;
                        answerButtonReset = 4;
                    }
                }

                if (currentQuestion == (MAX_QUESTIONS - 1))
                {
                    EndQuizBtn.IsEnabled = true;
                }
                else
                    NextQuestionBtn.IsEnabled = true;
            }
        }

        private void EndQuizBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Quiz Score", "You Scored - " + correctAnswerCounter + "/" + MAX_QUESTIONS, "Ok");
            Navigation.PopAsync();
        }
    }
}