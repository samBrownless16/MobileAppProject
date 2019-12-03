using System;
using System.Collections;
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
        Random rand = new Random();

        String[][] questions =
        {
            new string[] {"Question 1 PlaceHolder", "ANS 1-1", "ANS 2-1", "ANS 3-1", "ANS 4-1"},
            new string[] {"Question 2 PlaceHolder", "ANS 1-2", "ANS 2-2", "ANS 3-2", "ANS 4-2"},
            new string[] {"Question 3 PlaceHolder", "ANS 1-3", "ANS 2-3", "ANS 3-3", "ANS 4-3"},
            new string[] {"Question 4 PlaceHolder", "ANS 1-4", "ANS 2-4", "ANS 3-4", "ANS 4-4"},
            new string[] {"Question 5 PlaceHolder", "ANS 1-5", "ANS 2-5", "ANS 3-5", "ANS 4-5"},
            new string[] {"Question 6 PlaceHolder", "ANS 1-6", "ANS 2-6", "ANS 3-6", "ANS 4-6"},
            new string[] {"Question 7 PlaceHolder", "ANS 1-7", "ANS 2-7", "ANS 3-7", "ANS 4-7"},
            new string[] {"Question 8 PlaceHolder", "ANS 1-8", "ANS 2-8", "ANS 3-8", "ANS 4-8"},
            new string[] {"Question 9 PlaceHolder", "ANS 1-9", "ANS 2-9", "ANS 3-9", "ANS 4-9"},
            new string[] {"Question 10 PlaceHolder", "ANS 1-10", "ANS 2-10", "ANS 3-10", "ANS 4-10"}
        };
       
        int[] numberQuestion = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int currentQuestion = 0;

        public SportsSection ()
		{
			InitializeComponent();         
            ShuffleQuestionNumbers();
            DisplayQuestion(currentQuestion);
        }

        private void DisplayQuestion(int currQues)
        {
            Question.Text = questions[numberQuestion[currQues]][0];
            AnswerOne.Text = questions[numberQuestion[currQues]][1];
            AnswerTwo.Text = questions[numberQuestion[currQues]][2];
            AnswerThree.Text = questions[numberQuestion[currQues]][3];
            AnswerFour.Text = questions[numberQuestion[currQues]][4];

            /*for (int i = 0; i < questions.Length; i++)
            {
                Question.Text = questions[numberQuestion[i]][0];
                AnswerOne.Text = questions[numberQuestion[i]][1];
                AnswerTwo.Text = questions[numberQuestion[i]][2];
                AnswerThree.Text = questions[numberQuestion[i]][3];
                AnswerFour.Text = questions[numberQuestion[i]][4];
            }*/
        }

        private void ShuffleQuestionNumbers()
        {
            int index, temp;
            for (int i = numberQuestion.Length - 1; i > 0; i--)
            {
                index = rand.Next(i);
                temp = numberQuestion[index];
                numberQuestion[index] = numberQuestion[i];
                numberQuestion[i] = temp;
            }
        }

        private void NextSportsBtn_Clicked(object sender, EventArgs e)
        {
            currentQuestion++;
            if (currentQuestion == (questions.Length - 1))
            {
                NextSportsBtn.IsEnabled = false;
            }
            DisplayQuestion(currentQuestion);
        }
    }
}