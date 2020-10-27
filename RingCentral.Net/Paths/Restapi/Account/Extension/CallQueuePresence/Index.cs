using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallQueuePresence
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-queue-presence";
        }

        /// <summary>
        /// Operation: Get Agent’s Call Queue Presence
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence
        /// Rate Limit Group: Light
        /// App Permission: ReadPresence
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.ExtensionCallQueuePresenceList> Get(
            ReadExtensionCallQueuePresenceParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ExtensionCallQueuePresenceList>(this.Path(), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Call Queue Presence
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence
        /// Rate Limit Group: Medium
        /// App Permission: EditPresence
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.ExtensionCallQueuePresenceList> Put(
            RingCentral.ExtensionCallQueueUpdatePresenceList extensionCallQueueUpdatePresenceList,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.ExtensionCallQueuePresenceList>(this.Path(),
                extensionCallQueueUpdatePresenceList, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallQueuePresence.Index CallQueuePresence()
        {
            return new Restapi.Account.Extension.CallQueuePresence.Index(this);
        }
    }
}