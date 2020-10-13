using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Device
{
    public partial class Index
    {
        public RestClient rc;
        public string deviceId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string deviceId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.deviceId = deviceId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && deviceId != null)
            {
                return $"{parent.Path()}/device/{deviceId}";
            }

            return $"{parent.Path()}/device";
        }

        /// <summary>
        /// Operation: Get Device
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/device/{deviceId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyDevices
        /// </summary>
        public async Task<RingCentral.GetDeviceInfoResponse> Get(ReadDeviceParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.deviceId == null)
            {
                throw new System.ArgumentNullException("deviceId");
            }

            return await rc.Get<RingCentral.GetDeviceInfoResponse>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Device
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/device/{deviceId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyDevices
        /// </summary>
        public async Task<RingCentral.GetDeviceInfoResponse> Put(RingCentral.AccountDeviceUpdate accountDeviceUpdate,
            UpdateDeviceParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (this.deviceId == null)
            {
                throw new System.ArgumentNullException("deviceId");
            }

            return await rc.Put<RingCentral.GetDeviceInfoResponse>(this.Path(), accountDeviceUpdate, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Device.Index Device(string deviceId = null)
        {
            return new Restapi.Account.Device.Index(this, deviceId);
        }
    }
}