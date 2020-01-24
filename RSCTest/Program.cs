using static System.Console;
using NLog;
using Microsoft.Extensions.DependencyInjection;


namespace RSCTest
{
    class Program
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<ICheckString, CheckString>()
                .BuildServiceProvider();

            var checkString = serviceProvider.GetService<ICheckString>();
            //log information
            Logger.Info("Application started...");
            //read data from console
           

            
            // once we get a valid string we pass it to get the palindrome 
            do
            {
                WriteLine("Enter the number");
                string inputString = ReadLine();
                //check the input string is int
                while (!checkString.IsInt(inputString))
                {
                    WriteLine("Please enter a valid number");
                    inputString = ReadLine();
                }

                checkString.CheckPalindrome(inputString);
                WriteLine("Would you like to check other number Type Yes or No");
            } while ("Yes"==ReadLine());
            

            
        }

        ///// <summary>
        ///// This code checks if the given string is Palindrome 
        ///// </summary>
        ///// <param name="input"></param>
        ///// <returns></returns>
        //private static bool IsPalindrome (string input)
        //{
        //    //reverse the give string
        //    string reverse = new string(input.Reverse().ToArray());
        //    //check if the string in palindrome 
        //    return reverse == input;
        //}
        //private static bool IsInt(string input)
        //{
        //    int inputInt;
        //    //create a regular expression
        //    Regex regex = new Regex(@"^[0-9-]*$");
        //   //double check if its int so i also tried int.try
        //    return !regex.IsMatch(input) || !int.TryParse(input, out inputInt);
        //}

    }
}
