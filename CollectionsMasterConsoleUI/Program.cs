using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] myArray01 = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(myArray01, 0, 50);
            //TODO: Print the first number of the array
            Console.WriteLine($"The first number in the array is: {myArray01[0]}.");

            //TODO: Print the last number of the array
            Console.WriteLine($"The last number of the array is {myArray01[myArray01.Length - 1]}.");
            Console.WriteLine("All Numbers Original");
            NumberPrinter(myArray01);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways

            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */


            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(myArray01);
            NumberPrinter(myArray01);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(myArray01);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray01);
            Console.WriteLine(myArray01);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray01);
            NumberPrinter(myArray01);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> numberList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("This is the capacity of the list: ");
            Console.WriteLine(numberList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Console.WriteLine("Here is the populated list: ");
            Populater(numberList, 0, 50);
            NumberPrinter(numberList);

            //TODO: Print the new capacity
            Console.WriteLine("This is the new capacity of the list: ");
            Console.WriteLine(numberList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool canParse;
            int searchNumber;
            do
            {
            Console.WriteLine("What number will you search for in the number list?");
            canParse = int.TryParse(Console.ReadLine(), out searchNumber);
            } while (canParse == false);

            NumberChecker(numberList, searchNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] numberArray = numberList.ToArray();
            NumberPrinter(numberArray);

            //TODO: Clear the list
            Console.WriteLine("-----Cleared list-----");
            numberList.Clear();
            NumberPrinter(numberList);


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--) //Starting at the end allows the indexing not to change so that numbers aren't replaced in the list when removed
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }
            }
            foreach(int i in numberList)
            {
                Console.WriteLine(i);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is contained within the list!");
            }

            else if (!numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is not in this list.");
            }

            else
            {
                Console.WriteLine("Please enter a valid number.");
            }      
            
        }

        private static void Populater(List<int> numberList, int min, int max)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                int randomNumber = rng.Next(min, max);
                numberList.Add(randomNumber);
            }
        }

        private static void Populater(int[] numbers, int min, int max)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rng.Next(min, max + 1);
        }


            Console.WriteLine("Random numbers in the array:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
