using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    internal class GlobalCus
    {
        public static string generate_number(int count)
        {

            Random random = new Random();
            int[] randomIntegers = new int[count];

            // Generate 16 random integers
            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = random.Next(0, 10); // Generating random integers between 0 and 9
            }

            // Convert the array of integers to a string
            string result = string.Join("", randomIntegers);

            return result;

        }

        public static string generateId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            string shortId = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return shortId;
        }



    }
}
