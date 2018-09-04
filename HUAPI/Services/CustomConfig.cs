namespace HUAPICore.Services
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// 
    /// </summary>
    public class CustomConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public SystemConfig SystemConfig { get; set; }
    }

    public class Exchange
    {

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Pwd { get; set; }
    }

    public class Wire2Air
    {

        /// <summary>
        /// 
        /// </summary>
        public string ServiceUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShortCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string VASID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProfileId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CharLimit { get; set; }
    }

    public class Twilio
    {

        /// <summary>
        /// 
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AuthToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FromPhone { get; set; }
    }

    public class SMSService
    {

        /// <summary>
        /// 
        /// </summary>
        public string ServiceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TestMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TestPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Exchange Exchange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Wire2Air Wire2Air { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Twilio Twilio { get; set; }
    }

    public class SystemConfig
    {

        /// <summary>
        /// 
        /// </summary>
        public string ServerJaffaPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ScrapeCustomFormsCRON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SMSService SMSService { get; set; }
    }



#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
