namespace RingCentral
{
    // Information on the extension, to which the phone number is assigned. Returned only for the request of Account phone number list
    public class UserPhoneNumberExtensionInfo
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public long? id;

        /// <summary>
        /// Canonical URI of an extension
        /// </summary>
        public string uri;

        /// <summary>
        /// Number of department extension
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
        /// </summary>
        public string partnerId;

        /// <summary>
        /// Extension type
        /// Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ApplicationExtension, ParkLocation, Site
        /// </summary>
        public string type;

        /// <summary>
        /// </summary>
        public ContactCenterProvider contactCenterProvider;

        /// <summary>
        /// Extension name. For user extension types the value is a combination of the specified first name and last name
        /// </summary>
        public string name;
    }
}