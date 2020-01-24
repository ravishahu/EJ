using System;
using static System.Console;
using NLog;
using System.Linq;
using System.Text.RegularExpressions;

namespace RSCTest
{
    public class CheckString:ICheckString
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        private string ReverseString(string inputString)
        {
            return new string(inputString.Reverse().ToArray());
        }

        public CheckString()
        {
                
        }

        public string CheckPalindrome(string inputString)
        {
            try
            {
                do
                {
                    //Reverse string
                    string reverse = ReverseString(inputString);
                    string exprestion = reverse + " + " + inputString;

                    inputString = (long.Parse(inputString) + long.Parse(reverse)).ToString();

                    WriteLine(inputString + "=" + exprestion);
                    ////if I could not find a int get out of the loop.
                    if (!IsInt(inputString))
                    {
                        WriteLine("I counld not find Palindrome ");
                        inputString = "1221";
                    }

                } while (!IsPalindrome(inputString));
                //Display result
                WriteLine("Found number :" + inputString);
            }
            catch (Exception e)
            {
                Logger.Fatal(e, "An unexpected exception has occured");
            }
            finally
            {
                Logger.Info("Application terminated. Press <enter> to exit...");
               
            }
            return inputString;

        }
        /// <summary>
        /// This code checks if the given string is Palindrome 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public  bool IsPalindrome(string input)
        {
            //reverse the give string
            string reverse = ReverseString(input);
            //check if the string in palindrome 
            return reverse == input;
        }
        public bool IsInt(string input)
        {
            long inputInt;
            //create a regular expression
            return (long.TryParse(input, out inputInt));
        }

    }
}
