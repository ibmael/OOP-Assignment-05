using System;
using System.Collections.Generic;
using System.Text;

namespace TASK9ROUTE
{
    internal class InternationalShipment : Shipment
    {
        #region Properties

        public string DestinationCountry { get; set; }

        #endregion

        #region Constructor

        public InternationalShipment(string trackingCode, string description,
                                     decimal weight, decimal deliveryFee,
                                     DeliveryAddress destination,
                                     string destinationCountry)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
        }

        #endregion

        #region Estimated Cost

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee;
            }
        }

        #endregion

        #region Print Shipment

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }

        #endregion
    }
}
