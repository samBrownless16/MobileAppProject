using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppProject
{
    class Quiz
    {
        private readonly string[][] questionsSport =
        {
            // {0, 1, 2, 3, 4, 5 } - Correct Answer stored at index 5
            new string[] {"By How Many Points was the 2018/2019 Premier League Season Won?", "One", "Two", "Three", "Zero - Goal Difference", "One"},
            new string[] {"In what Year was Connacht Rugby Founded?", "1880", "1900", "1925", "1885", "1885"},
            new string[] {"How Many Appearances did Toby Flood Make for England?", "37", "29", "60", "52", "60"},
            new string[] {"Which Club has Won the Most FA Cups?", "Manchester United", "Arsenal", "Chelsea", "Totenham Hotspur", "Arsenal"},
            new string[] {"How Many Formula 1 Race Wins has Michael Schumacher Achieved?", "89", "91", "85", "93", "91"},
            new string[] {"In 1993 Michael Jordan Retired from Basketball to Play Which Other Sport?", "Cricket", "American Football", "Baseball", "Ice Hockey", "Baseball"},
            new string[] {"Robbie Keane is Republic of Ireland's All Time Leading Goal Scorer Who is Second on the List?", "Shane Long", "Frank Stapleton", "Tony Cascarino", "Niall Quinn", "Niall Quinn"},
            new string[] {"Kerry have Won How Many All-Ireland Senior Football Championships?", "37", "33", "39", "35", "37"},
            new string[] {"Which Sport has Earned Ireland the Most Gold Medals at the Olympics?", "Athletics", "Swimming", "Boxing", "Rowing", "Athletics"},
            new string[] {"In what Year did Munster Last Win the European Cup?", "2007", "2009", "2006", "2008", "2008"},
            new string[] {"Placeholder 1", "ANS 1-1", "ANS 1-2", "ANS 1-3", "ANS 1-4", "ANS 1-1"},
            new string[] {"Placeholder 2", "ANS 2-1", "ANS 2-2", "ANS 2-3", "ANS 2-4", "ANS 2-2"},
            new string[] {"Placeholder 3", "ANS 3-1", "ANS 3-2", "ANS 3-3", "ANS 3-4", "ANS 3-3"},
            new string[] {"Placeholder 4", "ANS 4-1", "ANS 4-2", "ANS 4-3", "ANS 4-4", "ANS 4-4"},
            new string[] {"Placeholder 5", "ANS 5-1", "ANS 5-2", "ANS 5-3", "ANS 5-4", "ANS 5-2"}
        };

        public string[][] GetSportQuestions()
        {
            return questionsSport;
        }

        public void ShuffleQuestionOrAnswerNumbers(int[] arr)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int index, temp;

            for (int i = arr.Length - 1; i > 0; i--)
            {
                index = rand.Next(i);
                temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;
            }
        }

        public string GetQuestionImages(int currQues)
        {
            if (currQues % 2 == 0)
                return "MobileAppProject.Images.question_one.png";
            else
                return "MobileAppProject.Images.question_two.png";
        }
    }
}
