using System;

namespace TestMovieTheatre
{

    class MainClass
    {

        public static int[] RetrieveCustomerAges(int customersCount)
        {
            int[] ages = new int[customersCount];
            int index = 0;
            while(index < customersCount)
            {
                try
                {
                    Console.Write("Add age for person number {0}: ", index + 1);
                    string userInput = Console.ReadLine();
                    int age = int.Parse(userInput);
                    ages[index] = age;
                    index++;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Age must be an integer!!!");
                }
            }
            return ages;
        }

        public static void Main(string[] args)
        {
            bool wrongInput = true;
            int[] ages;

            while(wrongInput)
            {
                try
                {
                    Console.Write("Number of customers: ");
                    string userInput = Console.ReadLine();
                    int customersCount = int.Parse(userInput);
                    ages = RetrieveCustomerAges(customersCount);

                    //TODO: send array to MovieTheatre

                    wrongInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number of customers must be an integer!!!");
                }
            }
        }
    }
}
