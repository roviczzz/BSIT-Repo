using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace MyClassLibrary
{
    public class Computation
    {
        // Silver - 12% discount
        // Gold - 15% discount
        // Platinum - 20% discount

        // Laptop - 35,500.00
        // Desktop - 27,500.00
        // DotMatrix - 5,500.00
        // InkJet - 4,500.00

        static double totalComp, totalDiscount, grandTotal, totalP1, totalP2, totalP3, totalP4;
        

        public static double CompP1(int q1)
        {
            totalP1 = q1 * 35500.00;
            totalComp = totalComp + totalP1;
            return totalP1;
            
        }

        public static double CompP2(int q2)
        {
            totalP2 = q2 * 27500.00;
            totalComp = totalComp + totalP2;
            return totalP2;

        }

        public static double CompP3(int q3)
        {
            totalP3 = q3 * 5500.00;
            totalComp = totalComp + totalP3;
            return totalP3;

        }

        public static double CompP4(int q4)
        {
            totalP4 = q4 * 4500.00;
            totalComp = totalComp + totalP4;
            return totalP4;
        }

        public static double CompTotal()
        {
            return totalComp = totalP1 + totalP2 + totalP3 + totalP4;
        }



        public static double CompDiscount(bool discountBool, string type)
        {

            if (discountBool == true)
            {
                switch (type)
                {
                    case "Silver":
                        totalDiscount = totalComp * .12;
                        return totalDiscount;

                    case "Gold":
                        totalDiscount = totalComp * .15;
                        return totalDiscount;

                    case "Platinum":
                        totalDiscount = totalComp * .20;
                        return totalDiscount;

                    default:
                        return totalDiscount;
                }
            }

            else
            {
                return totalComp;
            }
        }

        public static double compGrandTotal()
        {
            grandTotal = totalComp - totalDiscount;
            return grandTotal;
        }

    }
}
