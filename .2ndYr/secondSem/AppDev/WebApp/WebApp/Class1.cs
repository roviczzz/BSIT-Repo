using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.App_Code
{
    public class Class1
    {
        static int binToNum(string userInput)
        {
            int result = 0;
            int currentPower = 0;

            for (int i = input.Length-1; i > -1; i--)
            {
                if (input[i].Equals('1'))
                {
                    result += (int)Math.Pow(2, currentPower);
                }
                currentPower;
            }
            return result;

        }

        static string numToBin (int userInput)
        {
            string result = "";

            while (userInput != 0)
            {
                if ((userInput % 2 == 0))
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
                userInput /= 2;
            }
            return result;
        }

    }
}