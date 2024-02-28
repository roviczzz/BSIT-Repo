using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataHelperArrayList
{
    public class DataAccess
    {
        static ArrayList customerID = new ArrayList();
        static ArrayList customerName = new ArrayList();
        static ArrayList customerEmail = new ArrayList();
        static ArrayList customerType = new ArrayList();
        static ArrayList customerPassword = new ArrayList();
        static bool signedIn = false;

        public static ArrayList CustomerID
        {
            get { return DataAccess.customerID; }
            set { DataAccess.customerID = value; }
        }
        public static ArrayList CustomerName
        {
            get { return DataAccess.customerName; }
            set { DataAccess.customerName = value; }
        }

        public static ArrayList CustomerEmail
        {
            get { return DataAccess.customerEmail; }
            set { DataAccess.customerEmail = value; }
        }

        public static ArrayList CustomerType
        {
            get { return DataAccess.customerType; }
            set { DataAccess.customerType = value; }
        }

        public static ArrayList CustomerPassword
        {
            get { return DataAccess.customerPassword; }
            set { DataAccess.customerPassword = value; }
        }

        public static bool SignedIn
        { 
          get => signedIn;
          set => signedIn = value;
        }



        public void SaveRecord(string userName, string clientName, string clientType, string clientPassword)
        {
            customerID.Add(userName);
            customerName.Add(clientName);
            customerType.Add(clientType);
            customerPassword.Add(clientPassword);
        }

        public bool userSignedIn()
        {
            return signedIn = true;
        }

    }
}
