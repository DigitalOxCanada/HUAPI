using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Partition
    {
        public Partition()
        {
            CareTeam = new HashSet<CareTeam>();
            InversePartitionContainer = new HashSet<Partition>();
        }

        public long Oid { get; set; }
        public string PrtnCode { get; set; }
        public string PrtnName { get; set; }
        public long Deletedid { get; set; }
        public long PrtnType { get; set; }
        public long PrtnStatus { get; set; }
        public long PartitionStructureId { get; set; }
        public long? PartitionContainerId { get; set; }

        public Partition PartitionContainer { get; set; }
        public ICollection<CareTeam> CareTeam { get; set; }
        public ICollection<Partition> InversePartitionContainer { get; set; }
    }
}
