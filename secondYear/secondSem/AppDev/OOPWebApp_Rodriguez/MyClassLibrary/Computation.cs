using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace MyClassLibrary
{
    public class Computation
    {
        static double totalComp;
        // Silver - 12% discount
        // Gold - 15% discount
        // Platinum - 20% discount

        // Laptop - 35,500.00
        // Desktop - 27,500.00
        // DotMatrix - 5,500.00
        // InkJet - 4,500.00

        public static double ComputationP1(int q1)
        {
            double totalP1 = q1 * 35500.00;
            totalComp = totalComp + totalP1;
            return totalP1;
            
        }

        public static double ComputationP2(int q2)
        {
            double totalP2 = q2 * 27500.00;
            totalComp = totalComp + totalP2;
            return totalP2;

        }

        public static double ComputationP3(int q3)
        {
            double totalP3 = q3 * 5500.00;
            totalComp = totalComp + totalP3;
            return totalP3;

        }

        public static double ComputationP4(int q4)
        {
            double totalP4 = q4 * 4500.00;
            totalComp = totalComp + totalP4;
            return totalP4;

        }

        public static double ComputationDisc(bool discount, string type)
        {
            if (discount == true)
            {
                switch (type)
                {
                    case "Silver":
                        return totalComp = totalComp * .12;

                    case "Gold":
                        return totalComp = totalComp * .15;

                    case "Platinum":
                        return totalComp = totalComp * .20;
                }
            }

            else
            {
                return totalComp;
            }
        }

    }
}
