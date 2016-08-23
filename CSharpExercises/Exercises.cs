using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return "Hello " + name + "!";
        }

        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string name)
        {
            return name.Split(' ')[0];
        }

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string str)
        {
            StringBuilder builder = new StringBuilder("", str.Length);
            for (int i = str.Length -1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }

            return builder.ToString();
        }

        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string s = new string(arr);
            return s;
        }

        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
         public static string PrintTimesTable(int num)
        {
            StringBuilder builder = new StringBuilder();
            int product;

            for (int i = 1; i <= 10; i++)
            {
                product = i * num;
                builder.Append(num.ToString() + " * " + i.ToString() + " = " + product.ToString() + "\r\n");
            }
            builder.Remove(builder.Length - 2, 2);
            return builder.ToString();
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            return Math.Round(kelvin * 9 / 5 - 459.67, 2);
        }

        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] arr)
        {
            int total = 0;
            foreach (int num in arr)
            {
                total += num;
            }

            return (double)total / arr.Length;
        }

        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(params int[] arr)
        {
            return arr.Average();
        }

        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
         public static string DrawTriangle(int num, int width)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = width; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                    builder.Append(num.ToString());
                builder.Append("\r\n");
            }
            builder.Remove(builder.Length - 2, 2);
            return builder.ToString();
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double dist, int h, int m, int s)
        {
            // variable to hold total time
            double hours = 0;

            hours += h;
            hours += m / 60.0;
            hours += s / 3600.0;

            double speed = dist / hours;
            return Math.Round(speed, 0).ToString() + "MPH";
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char letter)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            return Array.IndexOf(vowels, letter) != -1;
        }

        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char letter)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            return Array.IndexOf(vowels, letter) == -1;
        }

        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937.
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int n)
        {
            int steps = 0;

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
                steps++;
            }

            // returns 0 if invalid value (n < 1) is passed in
            return steps;
        }

        //16.5 Create a method called GetOccurences that accepts two strings.the first string should represent a string of text, and the other should represent a single word.getoccurrences should return the number of times that the given word appears in the string of text.
        public static int GetOccurences(string text, string word)
        {
            //int i = 0;
            //int count = 0;
            //while ((i = text.IndexOf(word, i)) != -1)
            //{
            //    count++;
            //    i++;
            //}
            //return count;

            string[] arr = new string[] { word };
            return text.Split(arr, StringSplitOptions.None).Length - 1;
        }

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime date)
        {
            DateTime[] nextWeek = new DateTime[7];

            for (int i = 0; i < 7; i++)
            {
                nextWeek[i] = date.AddDays(i);
            }
            
            return nextWeek;
        }

        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(DateTime date)
        {
            return DateTime.DaysInMonth(date.Year, 2) == 29;
        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static decimal MortgageCalculator(decimal balance, decimal rate, int term, int period)
        {
            double p = (double) balance;
            double r = (double) rate / 100 / 12;
            double n = term * 12/ period;

            decimal result = (decimal)(p * r * Math.Pow((1 + r), n) / (Math.Pow((1 + r), n) - 1));
            
            return Math.Round(result, 2);
        }

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */
         public static string DuckGoose(int num)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                if (i % 15 == 0)
                {
                    builder.Append("DuckGoose");
                }
                else if (i % 3 == 0)
                {
                    builder.Append("Duck");
                }
                else if (i % 5 == 0)
                {
                    builder.Append("Goose");
                }
                else
                {
                    builder.Append(i.ToString());
                }
                builder.Append(Environment.NewLine);
            }
            builder.Remove(builder.Length - 2, 2);
            return builder.ToString();
        }
        

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}
