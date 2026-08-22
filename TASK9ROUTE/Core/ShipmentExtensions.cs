using System;
using System.Collections.Generic;
using System.Text;

namespace TASK9ROUTE
{
    internal static class ShipmentExtensions
    {
        #region Extension Methods

        public static string GetSummary(this Shipment shipment)
        {
            string shipmentType = shipment.GetType().Name.Replace("Shipment", "");

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus() == "Delivered";
        }

        #endregion
    }
}