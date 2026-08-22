using System;
using System.Collections.Generic;
using System.Text;

namespace TASK9ROUTE
{
    internal class ExpressShipment : Shipment
    {
        #region Properties

        public decimal ExtraFee { get; set; }

        #endregion

        #region Constructor

        public ExpressShipment(string trackingCode, string description,
                               decimal weight, decimal deliveryFee,
                               DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        #endregion

        #region Estimated Cost

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ExtraFee;
            }
        }

        #endregion

        #region Print Shipment

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }

        #endregion
    }
}