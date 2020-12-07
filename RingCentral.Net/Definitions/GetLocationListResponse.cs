namespace RingCentral
{
    public class GetLocationListResponse
    {
        /// <summary>
        /// Link to the location list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of locations
        /// </summary>
        public LocationInfo[] records;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}