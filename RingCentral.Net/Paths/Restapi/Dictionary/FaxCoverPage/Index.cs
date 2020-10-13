using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Dictionary.FaxCoverPage
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;

        public Index(Restapi.Dictionary.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/fax-cover-page";
        }

        /// <summary>
        /// Operation: Get Fax Cover Page List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/fax-cover-page
        /// Rate Limit Group: Light
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.ListFaxCoverPagesResponse> Get(ListFaxCoverPagesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ListFaxCoverPagesResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.FaxCoverPage.Index FaxCoverPage()
        {
            return new Restapi.Dictionary.FaxCoverPage.Index(this);
        }
    }
}