using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Supervise
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Sessions.Index parent;

        public Index(Restapi.Account.Telephony.Sessions.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/supervise";
        }

        /// <summary>
        /// Operation: Supervise Call Session
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.SuperviseCallSession> Post(
            RingCentral.SuperviseCallSessionRequest superviseCallSessionRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.SuperviseCallSession>(this.Path(), superviseCallSessionRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Supervise.Index Supervise()
        {
            return new Restapi.Account.Telephony.Sessions.Supervise.Index(this);
        }
    }
}