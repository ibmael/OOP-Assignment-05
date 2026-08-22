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

            OnTrackingStatusChanged(newStatus);
        }

        #endregion

        #region Partial Method Declaration

        partial void OnTrackingStatusChanged(string newStatus);

        #endregion
    }
}