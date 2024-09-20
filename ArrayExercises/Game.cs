using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Array Exercises
 * 
 * 
 * 
 * 
 * 
 */


namespace ArrayExercises
{
    internal class Game
    {
        public void Run()
        {
            bool calculating = true;
            while (calculating = true)
            {
                int[] ints = GetValues();

                //test comment for repo 
                PrintArray(ints);
                PrintReverse(ints);
                PrintSum(ints);
                PrintHighest(ints);
                PrintLowest(ints);
                PrintHighestToLowest(ints);
                PrintLowestToHighest(ints);

                Console.WriteLine("");
                string userInput = "";
                while (userInput != "1" && userInput != "2")
                {
                    Console.WriteLine("Would you like to calculate again?");
                    Console.WriteLine("1. yes | 2. no");
                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.Clear();
                    }
                    else if (userInput == "2")
                    {
                        Console.Clear();
                        calculating = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please choose option 1 or option 2 by typing either 1 or 2");
                    }
                }
            }
        }

        int[] GetValues()
        {
            int number1Typed = 0;
            int number2Typed = 0;
            int number3Typed = 0;
            int number4Typed = 0;
            int number5Typed = 0;

            while (number1Typed == 0)
            {
                Console.WriteLine("Type the first number");
                string userInput = Console.ReadLine();
                Console.Clear();
                try
                {
                    int userNumberInput = Int32.Parse(userInput);
                    number1Typed = userNumberInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Whoa wayyy to high of a number. Try something lower");
                }
            }
            while (number2Typed == 0)
            {
                Console.WriteLine("Type the second number");
                string userInput = Console.ReadLine();
                Console.Clear();
                try
                {
                    int userNumberInput = Int32.Parse(userInput);
                    number2Typed = userNumberInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Whoa wayyy to high of a number. Try something lower");
                }
            }
            while (number3Typed == 0)
            {
                Console.WriteLine("Type the third number");
                string userInput = Console.ReadLine();
                Console.Clear();
                Int32.TryParse(userInput, out int userNumberInput);
                number3Typed = userNumberInput;
            }
            while (number4Typed == 0)
            {
                Console.WriteLine("Type the fourth number");
                string userInput = Console.ReadLine();
                Console.Clear();
                try
                {
                    int userNumberInput = Convert.ToInt32(userInput);
                    number4Typed = userNumberInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Whoa wayyy to high of a number. Try something lower");
                }
            }
            while (number5Typed == 0)
            {
                Console.WriteLine("Type the fifth number");
                string userInput = Console.ReadLine();
                Console.Clear();
                try
                {
                    int userNumberInput = Convert.ToInt32(userInput);
                    number5Typed = userNumberInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Whoa wayyy to high of a number. Try something lower");
                }
            }

            int[] ints = new int[5] { number1Typed, number2Typed, number3Typed, number4Typed, number5Typed };
            return ints;
        }

        int[] PrintArray(int[] array)
        {
            Console.WriteLine("PrintArray");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Index " + i);
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
            return null;
        }

        int[] PrintReverse(int[] array)
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("PrintReverse");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Index " + i);
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
            return null;
        }

        int[] PrintSum(int[] array)
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            int sum = 0;
            int currentNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                currentNumber = array[i];
                sum += currentNumber;
            }
            Console.WriteLine("PrintSum");
            Console.WriteLine(sum);
            Console.ReadKey();
            return null;
        }

        int[] PrintHighest(int[] array)
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            int currentNumber = 0;
            int highest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                currentNumber = array[i];
                if (currentNumber > highest)
                {
                    highest = currentNumber;
                }
            }
            Console.WriteLine("PrintHighest");
            Console.WriteLine(highest);
            Console.ReadKey();
            return null;
        }

        int[] PrintLowest(int[] array)
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            int currentNumber = 0;
            int lowest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                currentNumber = array[i];
                if (currentNumber < lowest)
                {
                    lowest = currentNumber;
                }
            }
            Console.WriteLine("PrintLowest");
            Console.WriteLine(lowest);
            Console.ReadKey();
            return null;
        }

        int[] PrintHighestToLowest(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("HighestToLowest");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.ReadKey();
            return null;
        }

        int[] PrintLowestToHighest(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("LowestToHighest");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.ReadKey();
            return null;
        }

    }
}
