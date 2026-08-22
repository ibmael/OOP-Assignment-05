using System;
using System.Collections.Generic;
using System.Text;

namespace TASK9ROUTE
{
    internal abstract partial class Shipment
    {
        #region Properties

        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }

        #endregion

        #region Constructor

        public Shipment(string trackingCode, string description,
                        decimal weight, decimal deliveryFee,
                        DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        #endregion

        #region Abstract Members

        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();

        #endregion

        #region Object Copying

        public Shipment CopyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }

        #endregion

        #region Shallow Copy

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        #endregion

        #region Deep Copy

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                this.Destination.City,
                this.Destination.Street,
                this.Destination.BuildingNumber
            );

            return copy;
        }

        #endregion
    }
}