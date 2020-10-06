namespace RingCentral
{
    public class GetExtensionInfoResponse
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
        /// Account information
        /// </summary>
        public GetExtensionAccountInfo account;

        /// <summary>
        /// Contact detailed information
        /// </summary>
        public ContactInfo contact;

        /// <summary>
        /// </summary>
        public CustomFieldInfo[] customFields;

        /// <summary>
        /// Information on department extension(s), to which the requested extension belongs. Returned only for user extensions, members of department, requested by single extensionId
        /// </summary>
        public DepartmentInfo[] departments;

        /// <summary>
        /// Number of department extension
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// </summary>
        public string[] extensionNumbers;

        /// <summary>
        /// Extension name. For user extension types the value is a combination of the specified first name and last name
        /// </summary>
        public string name;

        /// <summary>
        /// For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
        /// </summary>
        public string partnerId;

        /// <summary>
        /// </summary>
        public ExtensionPermissions permissions;

        /// <summary>
        /// Information on profile image
        /// </summary>
        public ProfileImageInfo profileImage;

        /// <summary>
        /// List of non-RC internal identifiers assigned to an extension
        /// </summary>
        public ReferenceInfo[] references;

        /// <summary>
        /// </summary>
        public Roles[] roles;

        /// <summary>
        /// Extension region data (timezone, home country, language)
        /// </summary>
        public RegionalSettings regionalSettings;

        /// <summary>
        /// Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features
        /// </summary>
        public ExtensionServiceFeatureInfo[] serviceFeatures;

        /// <summary>
        /// Specifies extension configuration wizard state (web service setup).
        /// Default: NotStarted
        /// Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState;

        /// <summary>
        /// Extension current state. If 'Unassigned' is specified, then extensions without ‘extensionNumber’ are returned. If not specified, then all extensions are returned
        /// Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string status;

        /// <summary>
        /// Status information (reason, comment). Returned for 'Disabled' status only
        /// </summary>
        public ExtensionStatusInfo statusInfo;

        /// <summary>
        /// Extension type
        /// Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ApplicationExtension, ParkLocation, Bot, Room, Limited, Site, ProxyAdmin
        /// </summary>
        public string type;

        /// <summary>
        /// For Department extension type only. Call queue settings
        /// </summary>
        public CallQueueExtensionInfo callQueueInfo;

        /// <summary>
        /// Hides extension from showing in company directory. Supported for extensions of User type only
        /// </summary>
        public bool? hidden;

        /// <summary>
        /// Site data. If multi-site feature is turned on for the account, then internal identifier of a site must be specified. To assign the wireless point to the main site (company) set site ID to `main-site`
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site;
    }
}