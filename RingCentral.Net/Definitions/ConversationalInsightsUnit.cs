namespace RingCentral
{
    public class ConversationalInsightsUnit
    {
        /// <summary>
        ///     Required
        ///     Example: KeyPhrases
        ///     Enum: ExtractiveSummary, AbstractiveSummaryLong, AbstractiveSummaryShort, KeyPhrases, Tasks, Titles,
        ///     QuestionsAsked, OverallSentiment, Topics
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ConversationalInsightsUnitValues[] values { get; set; }
    }
}