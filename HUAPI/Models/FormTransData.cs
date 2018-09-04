using System;

namespace HUAPICore.Models
{
    public class FormTransData
    {
        public long OID { get; set; }
        public long COLLECTION { get; set; }
        public DateTime DT_MODIFIED { get; set; }
        public string DESCRIPTION { get; set; }
        public string CODE { get; set; }
        public long CID { get; set; }
        public long CONCEPT { get; set; }
    }
}
