using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.CallOut
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Index parent;

        public Index(Restapi.Account.Telephony.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-out";
        }

        /// <summary>
        /// Operation: Make CallOut
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/call-out
        /// Rate Limit Group: Heavy
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallSession> Post(RingCentral.MakeCallOutRequest makeCallOutRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallSession>(this.Path(), makeCallOutRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Restapi.Account.Telephony.CallOut.Index CallOut()
        {
            return new Restapi.Account.Telephony.CallOut.Index(this);
        }
    }
}