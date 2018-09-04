namespace HUAPICore.Models
{

    /// <summary>
    /// Command line arguments deserialized class
    /// </summary>
    public class CommandObject
    {
        public bool Check { get; set; } //check the structure
        public bool Addresses { get; set; }
        public bool PostalCodes { get; set; }
        public bool UpdateDB { get; set; } = false;
        public bool TestData { get; set; } = false;
        public bool MultiplePasses { get; set; } = false;
        public bool Verbose { get; set; }
        public int LimitRecords { get; set; }
    }

    //used to fill from RegEx match
    public class StreetAddress
    {
        public string HouseNumber { get; set; }
        public string StreetPrefix { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetSuffix { get; set; }
        public string Apt { get; set; }
        public string POBox { get; set; }
        public string RR { get; set; }
    }

}