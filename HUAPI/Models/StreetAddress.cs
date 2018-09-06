namespace HUAPICore.Models
{
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