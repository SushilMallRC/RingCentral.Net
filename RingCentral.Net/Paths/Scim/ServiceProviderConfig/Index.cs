using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.ServiceProviderConfig
{
    public partial class Index
    {
        public RestClient rc;
        public Scim.Index parent;

        public Index(Scim.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/ServiceProviderConfig";
        }

        /// <summary>
        /// Get Service Provider Config
        /// HTTP Method: GET
        /// Endpoint: /scim/v2/ServiceProviderConfig
        /// Rate Limit Group: NoThrottling
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.ServiceProviderConfig> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ServiceProviderConfig>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.ServiceProviderConfig.Index ServiceProviderConfig()
        {
            return new Scim.ServiceProviderConfig.Index(this);
        }
    }
}