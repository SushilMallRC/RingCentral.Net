using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Chats.Tasks
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Chats.Index parent;

        public Index(Restapi.Glip.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        /// Operation: Get Chat Tasks
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/tasks
        /// Rate Limit Group: Heavy
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GlipTaskList> Get(ListChatTasksParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipTaskList>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Task
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/tasks
        /// Rate Limit Group: Medium
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GlipTaskInfo> Post(RingCentral.GlipCreateTask glipCreateTask,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipTaskInfo>(this.Path(), glipCreateTask, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Tasks.Index Tasks()
        {
            return new Restapi.Glip.Chats.Tasks.Index(this);
        }
    }
}