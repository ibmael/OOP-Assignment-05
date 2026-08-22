using System;
using System.Collections.Generic;
using System.Text;

namespace TASK9ROUTE
{
    internal class StandardShipment : Shipment
    {
        #region Constructor

        public StandardShipment(string trackingCode, string description,
                                decimal weight, decimal deliveryFee,
                                DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        #endregion

        #region Estimated Cost

        public override decimal EstimatedCost
        {
            get
            {
                return Weight * 15 + DeliveryFee;
            }
        }

        #endregion

        #region Print Shipment

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }

        #endregion
    }
}
