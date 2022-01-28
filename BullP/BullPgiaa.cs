using System;
using System.Linq;
using System.Threading;

namespace BullP
{
    public class BullPgiaa
    {


        public string[] combinations = new string[3024];
        Random rnd = new Random();

        public string currGuess = "";



        public BullPgiaa()
        {
            GenerateCombination();
        }

        public string GetGuess()
        {
            int num = rnd.Next(0, combinations.Length);
            currGuess = combinations[num];
            while (currGuess == "")
            {
                num = rnd.Next(0, combinations.Length); ;
                currGuess = combinations[num];
            }
            return currGuess;
        }

        public void RemoveComb(int Bulls, int Cows)
        {
            bool isSimilar = false;
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < combinations.Length; i++)
            {
                if (combinations[i] != "")
                {
                    isSimilar = false;
                    bulls = 0;
                    cows = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        if (combinations[i][j] == currGuess[j])
                        {
                            bulls++;
                        }

                        for (int k = 0; k < 4; k++)
                        {
                            if (combinations[i][k] == currGuess[j] && k != j)
                            {
                                cows++;
                            }
                        }

                    }
                    if (bulls == Bulls && cows == Cows)
                    {

                    }
                    else
                        combinations[i] = "";
                    //Console.WriteLine(combinations[i]);

                }

            }
        }

        public void GenerateCombination()
        {
            int x = 0;
            for (int i = 1111; i < 10000; i++)
            {
                // Generate combination
                int combCurr = i;
                bool isValid = true;

                // Store possible combinations

                int digit = i % 10;
                int digit2 = (i % 100 / 10);
                int digit3 = (i % 1000 / 100);
                int digit4 = i / 1000;


                if (digit == digit2 || digit == digit3 || digit == digit4)
                {
                    isValid = false;
                }
                else if (digit2 == digit || digit2 == digit3 || digit2 == digit4)
                {
                    isValid = false;
                }
                else if (digit3 == digit || digit3 == digit2 || digit3 == digit4)
                {
                    isValid = false;
                }
                else if (digit4 == digit || digit4 == digit2 || digit4 == digit3)
                {
                    isValid = false;
                }
                if (digit == 0 || digit2 == 0 || digit3 == 0 || digit4 == 0)
                {
                    isValid = false;
                }


                if (isValid)
                {
                    combinations[x] = i.ToString();
                    //Console.WriteLine(combinations[x]);
                    x++;
                }
            }
        }
    }
}
