namespace RingCentral
{
    // Query parameters for operation aggregateA2PSMSStatuses
    public class AggregateA2PSMSStatusesParameters
    {
        /// <summary>
        ///     Date to filter message list result. Messages with `creationTime` later than or equal to `dateFrom` value are returned. The default value is 1 day before the current datetime
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     Date to filter message list result. Messages with `creationTime` earlier than `dateTo` value are returned. The default is the current datetime
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     Identifier of a message batch used for filtering records
        /// </summary>
        public string batchId { get; set; }

        /// <summary>
        ///     Direction of a message to filter the message list result. By default there is no filter applied - both Inbound and Outbound messages are returned
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }
    }
}