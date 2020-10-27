using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Join
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Teams.Index parent;

        public Index(Restapi.Glip.Teams.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/join";
        }

        /// <summary>
        /// Operation: Join Team
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}/join
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Join.Index Join()
        {
            return new Restapi.Glip.Teams.Join.Index(this);
        }
    }
}