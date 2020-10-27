using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Favorites
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/favorites";
        }

        /// <summary>
        /// Operation: Get Favorite Chats
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/favorites
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipChatsListWithoutNavigation> Get(
            ListFavoriteChatsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipChatsListWithoutNavigation>(this.Path(), queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Favorites.Index Favorites()
        {
            return new Restapi.Glip.Favorites.Index(this);
        }
    }
}