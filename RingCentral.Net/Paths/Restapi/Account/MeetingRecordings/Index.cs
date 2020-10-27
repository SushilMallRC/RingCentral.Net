using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MeetingRecordings
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/meeting-recordings";
        }

        /// <summary>
        /// Operation: Get Account Meeting Recordings List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/meeting-recordings
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: MeetingsRecordings
        /// </summary>
        public async Task<RingCentral.ListMeetingRecordingsResponse> Get(
            ListAccountMeetingRecordingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.MeetingRecordings.Index MeetingRecordings()
        {
            return new Restapi.Account.MeetingRecordings.Index(this);
        }
    }
}