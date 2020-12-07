namespace RingCentral
{
    // Call session information
    public class CallSessionObject
    {
        /// <summary>
        /// Internal identifier of a call session
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public OriginInfo origin;

        /// <summary>
        /// For calls of 'Conference' type only
        /// </summary>
        public string voiceCallToken;

        /// <summary>
        /// </summary>
        public CallParty[] parties;

        /// <summary>
        /// Date and time of the latest session update represented in Unix time format
        /// </summary>
        public string creationTime;
    }
}