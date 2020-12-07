namespace RingCentral
{
    // Information on a greeting language. Supported for types 'StopRecording', 'StartRecording', 'AutomaticRecording'
    public class CustomCompanyGreetingLanguageInfo
    {
        /// <summary>
        /// Internal identifier of a greeting language
        /// </summary>
        public string id;

        /// <summary>
        /// Link to a greeting language
        /// </summary>
        public string uri;

        /// <summary>
        /// Name of a greeting language
        /// </summary>
        public string name;

        /// <summary>
        /// Locale code of a greeting language
        /// </summary>
        public string localeCode;
    }
}