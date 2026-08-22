using System;
using System.Collections.Generic;
using System.Text;

namespace TASK9ROUTE
{
    internal abstract partial class Shipment
    {
        #region Tracking

        public string TrackingStatus { get; set; } = "Ready";

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
        }

        #endregion
    }
}