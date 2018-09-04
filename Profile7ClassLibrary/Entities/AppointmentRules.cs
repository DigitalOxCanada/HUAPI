using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class AppointmentRules
    {
        public long Cid { get; set; }
        public long Oid { get; set; }
        public string RuleName { get; set; }
        public DateTime RuleStart { get; set; }
        public long? RulePeriod { get; set; }
        public DateTime? RuleFinish { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinish { get; set; }
        public long? Provider { get; set; }
        public long? Pos { get; set; }
        public long? Duration { get; set; }
        public long? DefType { get; set; }
        public long? DefReasonId { get; set; }
        public string DefReasonDesc { get; set; }
        public byte[] RuleDays { get; set; }
        public string RuleCycle { get; set; }
        public byte[] Macro { get; set; }
        public long RulePriority { get; set; }
        public short RuleAllowcover { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long? MeetingLimit { get; set; }
        public long RulePermitaccession { get; set; }
        public long? TempStatus { get; set; }
        public long? TempDay { get; set; }
        public long? TempColor { get; set; }
        public long? TempGroupid { get; set; }
        public long? TempCommonType { get; set; }
        public byte[] TempTimes { get; set; }
        public long? Deletedid { get; set; }
        public string ObjGuid { get; set; }
        public short RuleDouble { get; set; }
        public long? PatientHelpInfo { get; set; }
        public long? ProviderHelpInfo { get; set; }
        public long? SkipMinutes { get; set; }

        public Shortcode DefTypeNavigation { get; set; }
        public Pppu PosNavigation { get; set; }
        public Pppu ProviderNavigation { get; set; }
        public Shortcode TempCommonTypeNavigation { get; set; }
    }
}
