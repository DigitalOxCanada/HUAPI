using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class DataImportLog
    {
        public long Oid { get; set; }
        public DateTime StartedDt { get; set; }
        public DateTime FinishedDt { get; set; }
        public long Status { get; set; }
        public long? ScheduledTaskId { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }
    }
}
