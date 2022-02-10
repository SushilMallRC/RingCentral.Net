using Newtonsoft.Json;

namespace RingCentral
{
    /// <summary>
    ///     APS (Apple Push Service) information/ priority data
    /// </summary>
    public class APSInfo
    {
        /// <summary>
        ///     If the value is '1' then notification is turned on even if the application is in background
        /// </summary>
        [JsonProperty("content-available")] public long? contentAvailable;
    }
}