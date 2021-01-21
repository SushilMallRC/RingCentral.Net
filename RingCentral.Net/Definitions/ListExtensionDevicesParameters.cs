namespace RingCentral
{
    public class ListExtensionDevicesParameters
    {
        /// <summary>
        /// Pooling type of a device
        /// Enum: Host, Guest, None
        /// </summary>
        public string linePooling { get; set; }

        /// <summary>
        /// Device feature or multiple features supported
        /// Enum: Intercom, Paging, BLA, HELD
        /// </summary>
        public string feature { get; set; }
    }
}