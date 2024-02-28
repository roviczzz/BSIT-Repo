using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Generation
    {
        public static string memberIDGen(string fName, string lName)
        {
            string Initial = fName.Substring(0, 1) + lName.Substring(0, 1);

            Random generator = new Random();
            int gen = generator.Next(1, 99999);
            return Initial + gen.ToString();
        }
    }
}
