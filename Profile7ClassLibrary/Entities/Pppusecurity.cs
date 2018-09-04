using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Pppusecurity
    {
        public string PuscEncryptedpassword { get; set; }
        public long? PuscFinancial { get; set; }
        public long? PuscClinical { get; set; }
        public long PppuId { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public short PuscIslockedout { get; set; }
        public string ObjGuid { get; set; }
        public short Usetwofactors { get; set; }
        public long? Swipecardtype { get; set; }
        public string Swipecardnumber { get; set; }
        public string PuscPasswordHash { get; set; }

        public Pppu Pppu { get; set; }
    }
}
