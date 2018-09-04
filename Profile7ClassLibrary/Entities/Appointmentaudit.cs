using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Appointmentaudit
    {
        public long Oid { get; set; }
        public DateTime ApadDatetime { get; set; }
        public long PppuIdUser { get; set; }
        public string ApadDescription { get; set; }
        public long? ApntId { get; set; }
        public short ApadIsappointmentdeleted { get; set; }
        public long? PtntId { get; set; }
        public DateTime? ApadBooktime { get; set; }
        public long? ApadDuration { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public Appointment Apnt { get; set; }
        public Pppu PppuIdUserNavigation { get; set; }
        public Patient Ptnt { get; set; }
    }
}
