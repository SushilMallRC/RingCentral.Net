namespace RingCentral
{
    public class GlipMessageAttachmentInfo
    {
        /// <summary>
        ///     Internal identifier of an attachment
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of an attachment
        ///     Default: Card
        ///     Enum: Card, Event, File, Note, Task
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     A string of default text that will be rendered in the case that the client does not support Interactive Messages
        /// </summary>
        public string fallback { get; set; }

        /// <summary>
        ///     A pretext to the message
        /// </summary>
        public string intro { get; set; }

        /// <summary>
        /// </summary>
        public GlipMessageAttachmentAuthorInfo author { get; set; }

        /// <summary>
        ///     Message title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     A large string field (up to 1000 chars) to be displayed as the body of a message (Supports GlipDown)
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Link to an image displayed at the bottom of a message
        /// </summary>
        public string imageUri { get; set; }

        /// <summary>
        ///     Link to an image preview displayed to the right of a message (82x82)
        /// </summary>
        public string thumbnailUri { get; set; }

        /// <summary>
        ///     Information on navigation
        /// </summary>
        public GlipMessageAttachmentFieldsInfo[] fields { get; set; }

        /// <summary>
        /// </summary>
        public GlipMessageAttachmentFootnoteInfo footnote { get; set; }

        /// <summary>
        ///     Internal identifier of a person created an event
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        ///     Datetime of starting an event
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Datetime of ending an event
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        ///     Indicates whether an event has some specific time slot or lasts for the whole day(s)
        /// </summary>
        public bool? allDay { get; set; }

        /// <summary>
        ///     Event recurrence settings.
        ///     Enum: None, Day, Weekday, Week, Month, Year
        /// </summary>
        public string recurrence { get; set; }

        /// <summary>
        ///     Condition of ending
        /// </summary>
        public string endingCondition { get; set; }

        /// <summary>
        ///     Count of iterations. For periodic events only
        /// </summary>
        public long? endingAfter { get; set; }

        /// <summary>
        ///     Iterations end datetime for periodic events
        ///     Default: None
        ///     Enum: None, Count, Date
        /// </summary>
        public string endingOn { get; set; }

        /// <summary>
        ///     Color of Event title, including its presentation in Calendar; or the color of the side border of an interactive
        ///     message of a Card
        ///     Default: Black
        ///     Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        /// </summary>
        public string color { get; set; }

        /// <summary>
        ///     Event location
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Event details
        /// </summary>
        public string description { get; set; }
    }
}