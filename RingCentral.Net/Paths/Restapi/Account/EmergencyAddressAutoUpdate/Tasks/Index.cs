using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Tasks
{
    public partial class Index
    {
        public RestClient rc;
        public string taskId;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent, string taskId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null)
            {
                return $"{parent.Path()}/tasks/{taskId}";
            }

            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        /// Operation: Get Emergency Map Configuration Task
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/tasks/{taskId}
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.AutomaticLocationUpdatesTaskInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.AutomaticLocationUpdatesTaskInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Tasks.Index Tasks(string taskId = null)
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Tasks.Index(this, taskId);
        }
    }
}