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
            new string[] { "By how many points was the 2018/2019 Premier League season won?", "One", "Two", "Three", "Zero - Goal Difference", "One" },
            new string[] { "In what year was Connacht Rugby founded?", "1880", "1900", "1925", "1885", "1885" },
            new string[] { "How many appearances did Toby Flood make for the England Rugby Union National Team?", "37", "29", "60", "52", "60" },
            new string[] { "Which club has won the most FA Cups?", "Manchester United", "Arsenal", "Chelsea", "Totenham Hotspur", "Arsenal" },
            new string[] { "How many Formula 1 race wins has Michael Schumacher achieved?", "89", "91", "85", "93", "91" },
            new string[] { "In 1993 Michael Jordan retired from basketball to play which other sport?", "Cricket", "American Football", "Baseball", "Ice Hockey", "Baseball" },
            new string[] { "Robbie Keane is the Republic of Ireland's all time leading goal scorer who is second on the list?", "Shane Long", "Frank Stapleton", "Tony Cascarino", "Niall Quinn", "Niall Quinn" },
            new string[] { "Kerry have won how many All-Ireland Senior Football Championships?", "37", "33", "39", "35", "37" },
            new string[] { "Which sport has earned Ireland the most gold medals at the Olympics?", "Athletics", "Swimming", "Boxing", "Rowing", "Athletics" },
            new string[] { "In what year did Munster last win the European Cup?", "2007", "2009", "2006", "2008", "2008" },
            new string[] { "What’s the second event on day one of a men’s Decathlon?", "Long Jump", "400 Metres", "Discus Throw", "1500 Metres", "Long Jump" },
            new string[] { "What number lies between 5 and 9 on a dart board?", "14", "12", "18", "13", "12" },
            new string[] { "Which country won the first FIFA World Cup held in 1930?", "Argentina", "Brazil", "Uruguay", "France", "Uruguay" },
            new string[] { "Sixways Stadium is the home ground of which English Rugby Union team?", "Bath Rugby", "London Irish", "Bristol Rugby", "Worcester Warriors", "Worcester Warriors" },
            new string[] { "In which year was the first Wimbledon tournament held?", "1877", "1878", "1876", "1879", "1877" },
            new string[] { "Which country will host the 2022 FIFA World Cup?", "United Arab Emirates", "Qatar", "Saudi Arabia", "Bahrain", "Qatar" },
            new string[] { "How many players per team on an ice hockey team?", "7", "5", "6", "8", "6" },
            new string[] { "How many points is the brown ball worth in Snooker?", "2", "5", "3", "4", "4" },
            new string[] { "Who did Muhammad Ali fight against in the fight dubbed the 'Thrilla in Manila'?", "Joe Frazier", "Jimmy Ellis", "George Foreman", "Sonny Liston", "Joe Frazier" },
            new string[] { "In which country is the Interlagos Formula 1 circuit?", "Italy", "Brazil", "Mexico", "Spain", "Brazil" }
        };

        private readonly string[][] questionsGeography =
        {
            // {0, 1, 2, 3, 4, 5 } - Correct Answer stored at index 5
            new string[] { "Which river flows through Paris?", "River Seine", "River Loire", "River Meuse", "River Rhine", "River Seine" },
            new string[] { "What is Europe’s largest port?", "Port of Hamburg", "Port of Rotterdam", "Port of Antwerp", "Port of Algeciras", "Port of Rotterdam" },
            new string[] { "Which Asian country is bigger than France, Spain and Germany combined but has a population of a little under four million?", "Armenia", "Afghanistan", "Mongolia", "Kazakhstan", "Mongolia" },
            new string[] { "What is the capital of Libya?", "Benghazi", "Misrata", "Zliten", "Tripoli", "Tripoli" },
            new string[] { "In which US State is the Harvard University?", "Massachusetts", "Connecticut", "Michigan", "Virginia", "Massachusetts" },
            new string[] { "Brisbane is the capital of which Australian State?", "Western Australia", "Queensland", "Victoria", "New South Wales", "Queensland" },
            new string[] { "Riga is the capital city of which European country?", "Estonia", "Lithuania", "Latvia", "Belarus", "Latvia" },
            new string[] { "Apart from Dutch and French, what is the other official language of Belgium?", "Spanish", "Hungarian", "English", "German", "German" },
            new string[] { "Which country has Montevideo as its capital city?", "Uruguay", "Paraguay", "Bolivia", "Chile", "Uruguay" },
            new string[] { "Which river flows through Glasgow?", "River Lochy", "River Clyde", "River Nevis", "River Cree", "River Clyde" },
            new string[] { "In which mountain range would you find Mount Everest?", "The Alps", "The Andes", "Himalayas", "Aleutian Range", "Himalayas" },
            new string[] { "What is the capital city of Slovenia?", "Maribor", "Celje", "Kranj", "Ljubljana", "Ljubljana" },
            new string[] { "Mount Vesuvius overlooks which modern Italian city?", "Naples", "Milan", "Rome", "Turin", "Naples" },
            new string[] { "In which European country is the cathedral town of Teruel?", "France", "Spain", "Portugal", "Andorra", "Spain" },
            new string[] { "What is the largest county in Ireland by area?", "Galway", "Mayo", "Cork", "Donegal", "Cork" },
            new string[] { "What is Japan's largest island by area?", "Hokkaido", "Kyushu", "Okinawa", "Honshu", "Honshu" },
            new string[] { "Which Ocean does the Amazon River empty into?", "Atlantic Ocean", "Pacific Ocean", "Southern Ocean", "Indian Ocean", "Atlantic Ocean" },
            new string[] { "Santiago is the capital city of which country?", "Peru", "Chile", "Bolivia", "Colombia", "Chile" },
            new string[] { "How many countries are there in North America?", "3", "20", "23", "15", "23" },
            new string[] { "Santiago is the capital city of which country?", "Mount Elbert", "Mount Saint Elias", "University Peak", "Denali", "Denali" }
        };

        private readonly string[][] questionsGenKnowledge =
        {
            // {0, 1, 2, 3, 4, 5 } - Correct Answer stored at index 5
            new string[] { "What type of creature is a Sea Wasp?", "Jellyfish", "Eel", "Sea Urchin", "Sea Cucumber", "Jellyfish" },
            new string[] { "Which was the first European country to give women the vote?", "Denmark", "Finland", "Netherlands", "Germany", "Finland" },
            new string[] { "The NASA spacecraft 'Messenger' was sent to explore which planet?", "Neptune", "Mars", "Mercury", "Saturn", "Mercury" },
            new string[] { "Attached to the stomach, what is the first section of the small intestine called?", "Colon", "Ileum", "Jejunum", "Duodenum", "Duodenum" },
            new string[] { "Which superhero featured in the first issue of 'Action Comics' in 1938?", "Superman", "Batman", "Spider-man", "Sandman", "Superman"},
            new string[] { "Something described as 'cordate' is what shape?", "Crown", "Heart", "String", "Pear", "Heart" },
            new string[] { "On an Italian menu, a dish described as 'piccante' is what?", "Sour", "Bitter", "Spicy", "Sweet", "Spicy" },
            new string[] { "The actress Charlize Theron was born in which country?", "Canada", "Australia", "Zimbabwe", "South Africa", "South Africa" },
            new string[] { "In the Bible, what was the native city of King David?", "Bethlehem", "Jericho", "Nazareth", "Jerusalem", "Bethlehem" },
            new string[] { "What name is given to a thin slice of steak which is cooked very quickly?", "Flash", "Minute", "Second", "Tartare", "Minute" },
            new string[] { "The gall bladder lies under which organ?", "Stomach", "Spleen", "Liver", "Kidneys", "Liver" },
            new string[] { "In 1945, Japan formally surrendered to the Allies on board which US battleship?", "U.S.S. Texas", "U.S.S. Indiana", "U.S.S. Kansas", "U.S.S. Missouri", "U.S.S. Missouri" },
            new string[] { "What is a female grizzly bear called?", "Sow", "Cow", "Bitch", "Ewe", "Sow" },
            new string[] { "In which Indian city is the Oscar-winning film 'Slumdog Millionaire' set?", "Calcutta", "Mumbai", "Delhi", "Panaji", "Mumbai" },
            new string[] { "In the US, 'Benedict Arnold' is a byword for what?", "Signature", "Bravery", "Treason", "Indecision", "Treason" },
            new string[] { "In Greek mythology, who was Penelope married to?", "Heracles", "Achilles", "Paris", "Odysseus", "Odysseus" },
            new string[] { "Which of these alloys contains carbon?", "Stainless Steel", "Brass", "Pewter", "Sterling Silver", "Stainless Steel" },
            new string[] { "Nelson's ship, the HMS Victory, is on display in which city?", "Southampton", "Portsmouth", "Plymouth", "Brighton", "Portsmouth" },
            new string[] { "In World War One, what was 'Big Bertha'?", "Airship", "Fort", "Gun", "Tank", "Gun" },
            new string[] { "Which of these 'Star Trek' films was released first?", "First Contact", "The Search for Spock", "Generations", "The Wrath of Khan", "The Wrath of Khan" }
        };

        // return questions to relevant category
        public string[][] GetSportQuestions()
        {
            return questionsSport;
        }

        public string[][] GetGeographyQuestions()
        {
            return questionsGeography;
        }

        public string[][] GetGenKnowledgeQuestions()
        {
            return questionsGenKnowledge;
        }

        // Shuffle the Question and Answer Number arrays so the order they appear is not always the same
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

        // Alternate between 2 images every other question
        public string GetQuestionImages(int currQues)
        {
            if (currQues % 2 == 0)
                return "MobileAppProject.Images.question_one.png";
            else
                return "MobileAppProject.Images.question_two.png";
        }
    }
}
