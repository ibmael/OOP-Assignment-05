using System;
using System.Collections.Generic;
using System.Text;

namespace TASK9ROUTE
{
    internal static class DeliveryUtilities
    {
        #region Methods

        public static void PrintSeparator()
        {
            Console.WriteLine("==========================================");
        }

        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.WriteLine("Delivery Center");
            PrintSeparator();
        }

        #endregion
    }
}