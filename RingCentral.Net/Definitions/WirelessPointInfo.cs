namespace RingCentral
{
    public class WirelessPointInfo
    {
        /// <summary>
        ///     Link to the wireless point resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a wireless point
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Unique 48-bit identifier of the wireless access point that follows MAC address conventions
        ///     Required
        /// </summary>
        public string bssid { get; set; }

        /// <summary>
        ///     Wireless access point name
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyAddressAutoUpdateSiteInfo site { get; set; }

        /// <summary>
        ///     Emergency address information (or information assigned to the
        ///     switch or wireless point - in case of using them). Only one of a pair
        ///     `emergencyAddress` or `emergencyLocationId` should be specified,
        ///     otherwise an error is returned
        ///     Required
        /// </summary>
        public WirelessPointInfoEmergencyAddress emergencyAddress { get; set; }

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation { get; set; }

        /// <summary>
        ///     Deprecated. Emergency response location (address) internal identifier. Only one of a pair `emergencyAddress` or
        ///     `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId { get; set; }
    }
}