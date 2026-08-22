using System;
using System.Collections.Generic;
using System.Text;

namespace TASK9ROUTE
{
    internal class DeliveryAddress
    {
        #region Properties

        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int BuildingNumber { get; set; }

        #endregion

        #region Constructors

        public DeliveryAddress()
        {
        }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        #endregion

        #region Methods

        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }

        #endregion
    }
}