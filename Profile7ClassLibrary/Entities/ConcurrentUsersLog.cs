using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class ConcurrentUsersLog
    {
        public long Oid { get; set; }
        public DateTime CulDate { get; set; }
        public DateTime CulNextDate { get; set; }
        public long CulUsers { get; set; }
        public long CulSessions { get; set; }
    }
}
