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
            new string[] { "By How Many Points was the 2018/2019 Premier League Season Won?", "One", "Two", "Three", "Zero - Goal Difference", "One" },
            new string[] { "In what Year was Connacht Rugby Founded?", "1880", "1900", "1925", "1885", "1885" },
            new string[] { "How Many Appearances did Toby Flood Make for England?", "37", "29", "60", "52", "60" },
            new string[] { "Which Club has Won the Most FA Cups?", "Manchester United", "Arsenal", "Chelsea", "Totenham Hotspur", "Arsenal" },
            new string[] { "How Many Formula 1 Race Wins has Michael Schumacher Achieved?", "89", "91", "85", "93", "91" },
            new string[] { "In 1993 Michael Jordan Retired from Basketball to Play Which Other Sport?", "Cricket", "American Football", "Baseball", "Ice Hockey", "Baseball" },
            new string[] { "Robbie Keane is Republic of Ireland's All Time Leading Goal Scorer Who is Second on the List?", "Shane Long", "Frank Stapleton", "Tony Cascarino", "Niall Quinn", "Niall Quinn" },
            new string[] { "Kerry have Won How Many All-Ireland Senior Football Championships?", "37", "33", "39", "35", "37" },
            new string[] { "Which Sport has Earned Ireland the Most Gold Medals at the Olympics?", "Athletics", "Swimming", "Boxing", "Rowing", "Athletics" },
            new string[] { "In what Year did Munster Last Win the European Cup?", "2007", "2009", "2006", "2008", "2008" },
            new string[] { "What’s the Second Event on Day One of a Men’s Decathlon?", "Long Jump", "400 Metres", "Discus Throw", "1500 Metres", "Long Jump" },
            new string[] { "What Number Lies Between 5 and 9 on a Dart Board?", "14", "12", "18", "13", "12" },
            new string[] { "Which country won the first World Cup held in 1930?", "Argentina", "Brazil", "Uruguay", "France", "Uruguay" },
            new string[] { "Sixways Stadium is the Home ground of which English Rugby Union Team?", "Bath Rugby", "London Irish", "Bristol Rugby", "Worcester Warriors", "Worcester Warriors" },
            new string[] { "In which year was the first Wimbledon tournament held?", "1877", "1878", "1876", "1879", "1877" }
        };

        private readonly string[][] questionsGeography =
        {
            // {0, 1, 2, 3, 4, 5 } - Correct Answer stored at index 5
            new string[] { "Which River Flows Through Paris?", "River Seine", "River Loire", "River Meuse", "River Rhine", "River Seine" },
            new string[] { "What is Europe’s Largest Port?", "Port of Hamburg", "Port of Rotterdam", "Port of Antwerp", "Port of Algeciras", "Port of Rotterdam" },
            new string[] { "Which Asian country is bigger than France, Spain and Germany combined but has a Population of a Little Under Four million?", "Armenia", "Afghanistan", "Mongolia", "Kazakhstan", "Mongolia" },
            new string[] { "What is the Capital of Libya?", "Benghazi", "Misrata", "Zliten", "Tripoli", "Tripoli" },
            new string[] { "In which US State is the Harvard University?", "Massachusetts", "Connecticut", "Michigan", "Virginia", "Massachusetts" },
            new string[] { "Brisbane is the Capital of which Australian State?", "Western Australia", "Queensland", "Victoria", "New South Wales", "Queensland" },
            new string[] { "Riga is the Capital City of which European Country?", "Estonia", "Lithuania", "Latvia", "Belarus", "Latvia" },
            new string[] { "Apart from Dutch and French, What is the Other Official Language of Belgium?", "Spanish", "Flemish", "English", "German", "German" },
            new string[] { "Which Country has Montevideo as its Capital City?", "Uruguay", "Paraguay", "Bolivia", "Chile", "Uruguay" },
            new string[] { "Which River Flows through Glasgow?", "River Lochy", "River Clyde", "River Nevis", "River Cree", "River Clyde" },
            new string[] { "In which Mountain Range would you Find Mount Everest?", "The Alps", "The Andes", "Himalayas", "Aleutian Range", "Himalayas" },
            new string[] { "What is the Capital City of Slovenia?", "Maribor", "Celje", "Kranj", "Ljubljana", "Ljubljana" },
            new string[] { "Mount Vesuvius Overlooks which Modern Italian City?", "Naples", "Milan", "Rome", "Turin", "Naples" },
            new string[] { "In which European country is the cathedral town of Teruel?", "France", "Spain", "Portugal", "Andorra", "Spain" },
            new string[] { "Where did Beans go on Holiday for a Month this Summer?", "Italy", "Spain", "Greece", "Meath", "Greece" }
        };

        public string[][] GetSportQuestions()
        {
            return questionsSport;
        }

        public string[][] GetGeographyQuestions()
        {
            return questionsGeography;
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
