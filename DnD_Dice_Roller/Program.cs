using System;

namespace DnD_Dice_Roller // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random;
            int sum = 0;
            Console.WriteLine("Bonjour, qu'est-ce qu'on tir ?");
            Console.WriteLine("");
            while (true)
            {
                string response = Console.ReadLine();

                if (response.Length >= 3 && (response.ElementAt(1) == 'd' || response.ElementAt(1) == 'D'))
                {
                    int numberOfDice = int.Parse(response.ElementAt(0).ToString());
                    int rangeOfDice = int.Parse(response.ElementAt(2).ToString());
                    if (response.Length == 4)
                    {
                        rangeOfDice = int.Parse(response.ElementAt(2).ToString() + response.ElementAt(3).ToString());
                    }

                    for (int i = 0; i < numberOfDice; i++)
                    {
                        random = new Random();
                        int generatedNumber = random.Next(rangeOfDice);
                        generatedNumber = generatedNumber + 1;
                        sum = sum + generatedNumber;
                        if (generatedNumber == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (generatedNumber == 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine(generatedNumber);
                    }
                    if (numberOfDice > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Somme totale : " + sum);
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------");
            }

        }
    }
}