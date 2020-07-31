namespace RingCentral
{
    public class GetRingOutStatusResponse
    {
        /// <summary>
        /// Internal identifier of a RingOut call
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// RingOut status information
        /// </summary>
        public RingOutStatusInfo status;
    }
}