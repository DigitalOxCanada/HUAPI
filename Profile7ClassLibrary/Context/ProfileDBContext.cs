using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Profile7ClassLibrary.Entities;

namespace Profile7ClassLibrary
{
    public partial class ProfileDBContext : DbContext
    {
        public ProfileDBContext()
        {
        }

        public ProfileDBContext(DbContextOptions<ProfileDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Alias> Alias { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Appointmentaudit> Appointmentaudit { get; set; }
        public virtual DbSet<AppointmentRules> AppointmentRules { get; set; }
        public virtual DbSet<AppRole> AppRole { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<Bcase> Bcase { get; set; }
        public virtual DbSet<Blobs> Blobs { get; set; }
        public virtual DbSet<CareTeam> CareTeam { get; set; }
        public virtual DbSet<CaseAudit> CaseAudit { get; set; }
        public virtual DbSet<CaseAuditDetails> CaseAuditDetails { get; set; }
        public virtual DbSet<CaseMergeLog> CaseMergeLog { get; set; }
        public virtual DbSet<CaseTemplates> CaseTemplates { get; set; }
        public virtual DbSet<CdoOrganization> CdoOrganization { get; set; }
        public virtual DbSet<CdoPerson> CdoPerson { get; set; }
        public virtual DbSet<CdoPersonImage> CdoPersonImage { get; set; }
        public virtual DbSet<CdoTermset> CdoTermset { get; set; }
        public virtual DbSet<CdoTermsetConcept> CdoTermsetConcept { get; set; }
        public virtual DbSet<CdoTermsetTerm> CdoTermsetTerm { get; set; }
        public virtual DbSet<CdoTrans> CdoTrans { get; set; }
        public virtual DbSet<CdoTransdata> CdoTransdata { get; set; }
        public virtual DbSet<ConcurrentUsersLog> ConcurrentUsersLog { get; set; }
        public virtual DbSet<ContactActionLink> ContactActionLink { get; set; }
        public virtual DbSet<DatabaseInfo> DatabaseInfo { get; set; }
        public virtual DbSet<DataImportLog> DataImportLog { get; set; }
        public virtual DbSet<DataOutputLog> DataOutputLog { get; set; }
        public virtual DbSet<Diseasecode> Diseasecode { get; set; }
        public virtual DbSet<Headline> Headline { get; set; }
        public virtual DbSet<Lookuplist> Lookuplist { get; set; }
        public virtual DbSet<OrgStructure> OrgStructure { get; set; }
        public virtual DbSet<Partition> Partition { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientAlternatName> PatientAlternatName { get; set; }
        public virtual DbSet<PatientAudit> PatientAudit { get; set; }
        public virtual DbSet<PatientGrp> PatientGrp { get; set; }
        public virtual DbSet<PatientInfoAudit> PatientInfoAudit { get; set; }
        public virtual DbSet<PatientInfoAuditDetails> PatientInfoAuditDetails { get; set; }
        public virtual DbSet<PatientMergeLog> PatientMergeLog { get; set; }
        public virtual DbSet<Patientproblem> Patientproblem { get; set; }
        public virtual DbSet<Patientrecallvisit> Patientrecallvisit { get; set; }
        public virtual DbSet<PostCodes> PostCodes { get; set; }
        public virtual DbSet<Pppu> Pppu { get; set; }
        public virtual DbSet<Pppuimage> Pppuimage { get; set; }
        public virtual DbSet<Pppupos> Pppupos { get; set; }
        public virtual DbSet<Pppuroles> Pppuroles { get; set; }
        public virtual DbSet<Pppusecurity> Pppusecurity { get; set; }
        public virtual DbSet<ProfilePatientGroup> ProfilePatientGroup { get; set; }
        public virtual DbSet<Shortcode> Shortcode { get; set; }
        public virtual DbSet<ShortcodeType> ShortcodeType { get; set; }
        public virtual DbSet<UserSecurityLog> UserSecurityLog { get; set; }
        public virtual DbSet<ViewAudit> ViewAudit { get; set; }
        public virtual DbSet<Workstation> Workstation { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=.\\dev;Database=ProfileNHU710;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ADDRESS");

                entity.HasIndex(e => e.AddressType)
                    .HasName("ADDRESS_TYPE_FK_SHORTCODE");

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("FK_ADDRESS_PPPU_MODIFIED_BY");

                entity.HasIndex(e => e.NokRelationship)
                    .HasName("ADDRESS_FK_RELATIONSHIP");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_ADDRESS");

                entity.HasIndex(e => e.Postalstate)
                    .HasName("ADDRESS_FK_POSTALSTATE");

                entity.HasIndex(e => e.PtntId)
                    .HasName("ADDRESS_PTNT_FK_PATIENT");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressType).HasColumnName("ADDRESS_TYPE");

                entity.Property(e => e.Building)
                    .HasColumnName("BUILDING")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Cellphone)
                    .HasColumnName("CELLPHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasColumnName("COUNTRY");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Decile)
                    .HasColumnName("DECILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.Direction)
                    .HasColumnName("DIRECTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DomicileCode)
                    .HasColumnName("DOMICILE_CODE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DomicileDescription)
                    .HasColumnName("DOMICILE_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.GeoCoordX)
                    .HasColumnName("GEO_COORD_X")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeoCoordY)
                    .HasColumnName("GEO_COORD_Y")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeoDhb)
                    .HasColumnName("GEO_DHB")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GeoLatitude)
                    .HasColumnName("GEO_LATITUDE")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.GeoLongitude)
                    .HasColumnName("GEO_LONGITUDE")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.GeoStatus).HasColumnName("GEO_STATUS");

                entity.Property(e => e.GeoUncertaintycode)
                    .HasColumnName("GEO_UNCERTAINTYCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Isinactive).HasColumnName("ISINACTIVE");

                entity.Property(e => e.Meshblock)
                    .HasColumnName("MESHBLOCK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.NokRelationship).HasColumnName("NOK_RELATIONSHIP");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Postalstate).HasColumnName("POSTALSTATE");

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PtntId).HasColumnName("PTNT_ID");

                entity.Property(e => e.Quintile)
                    .HasColumnName("QUINTILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sourceref)
                    .HasColumnName("SOURCEREF")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasColumnName("SUBURB")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TlaName)
                    .HasColumnName("TLA_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Workphone)
                    .HasColumnName("WORKPHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressTypeNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AddressType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ADDRESS_TYPE_FK_SHORTCODE");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.NokRelationshipNavigation)
                    .WithMany(p => p.AddressNokRelationshipNavigation)
                    .HasForeignKey(d => d.NokRelationship)
                    .HasConstraintName("ADDRESS_FK_RELATIONSHIP");

                entity.HasOne(d => d.PostalstateNavigation)
                    .WithMany(p => p.AddressPostalstateNavigation)
                    .HasForeignKey(d => d.Postalstate)
                    .HasConstraintName("ADDRESS_FK_POSTALSTATE");

                entity.HasOne(d => d.Ptnt)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.PtntId)
                    .HasConstraintName("ADDRESS_PTNT_FK_PATIENT");
            });

            modelBuilder.Entity<Alias>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ALIAS");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_ALIAS");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("ALIAS_I_OBJECT_TYPE");

                entity.HasIndex(e => new { e.AlisCode, e.PartitionId })
                    .HasName("ALIAS_I_CODE")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjectId, e.ObjectType })
                    .HasName("ALIAS_I_OBJECT_ID_TYPE")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlisCode)
                    .IsRequired()
                    .HasColumnName("ALIS_CODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ColourId)
                    .HasColumnName("COLOUR_ID")
                    .HasDefaultValueSql("((50331647))");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.ObjectId).HasColumnName("OBJECT_ID");

                entity.Property(e => e.ObjectType).HasColumnName("OBJECT_TYPE");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.ApntId);

                entity.ToTable("APPOINTMENT");

                entity.HasIndex(e => e.ApntBooktime)
                    .HasName("APPOINTMENT_I_APNT_BOOKTIME");

                entity.HasIndex(e => e.ApntCancellationReason)
                    .HasName("APNT_FK_CANCELLATION_REASON");

                entity.HasIndex(e => e.ApntCaseId)
                    .HasName("APPOINTMENT_FK_APNT_CASE_ID");

                entity.HasIndex(e => e.ApntEndtime)
                    .HasName("APPOINTMENT_I_APNT_ENDTIME");

                entity.HasIndex(e => e.ApntFrontDeskNoteId)
                    .HasName("FK_APPOINTMENT_FDNOTE");

                entity.HasIndex(e => e.ApntGroup)
                    .HasName("APPOINTMENT_FK_GROUP");

                entity.HasIndex(e => e.ApntIsclosed)
                    .HasName("APPOINTMENT_I_APNT_ISCLOSED");

                entity.HasIndex(e => e.ApntLocationAddressId)
                    .HasName("FK_APNT_LOCATION_ADDRESS_ID");

                entity.HasIndex(e => e.ApntMainApptId)
                    .HasName("FK_APNT_MAIN_APPT_ID");

                entity.HasIndex(e => e.ApntPrappovId)
                    .HasName("APPOINTMENT_FK_APNT_PRAPPOV_");

                entity.HasIndex(e => e.ApntPrvsId)
                    .HasName("APNT_PRVS_FK_PRVS");

                entity.HasIndex(e => e.ApntRecurrency)
                    .HasName("APPOINTMENT_FK_APNT_RECURREN");

                entity.HasIndex(e => e.ApntReferralId)
                    .HasName("APPOINTMENT_FK_APNT_REFERRAL");

                entity.HasIndex(e => e.ApntSeentime)
                    .HasName("APPOINTMENT_I_APNT_SEENTIME");

                entity.HasIndex(e => e.ApntSessionId)
                    .HasName("APPOINTMENT_FK_SESSION_ID");

                entity.HasIndex(e => e.ApntSourceref)
                    .HasName("APPOINTMENT_I_SOURCEREF");

                entity.HasIndex(e => e.ApntStatus)
                    .HasName("APPOINTMENT_I_STATUS");

                entity.HasIndex(e => e.Createdby)
                    .HasName("FK_APPT_CREATEDBY_PPPU");

                entity.HasIndex(e => e.Modifiedby)
                    .HasName("FK_APPT_MODIFIEDBY_PPPU");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_APPOINTMENT");

                entity.HasIndex(e => e.PppuIdPos)
                    .HasName("APPOINTMENT_FK_POS");

                entity.HasIndex(e => e.PppuIdProvider)
                    .HasName("APPOINTMENT_FK_PROVIDER");

                entity.HasIndex(e => e.PppuIdSeenby)
                    .HasName("APNT_FK_PPPU_SEENBY");

                entity.HasIndex(e => e.PrivacyPppuId)
                    .HasName("APPOINTMENT_FK_PPPU");

                entity.HasIndex(e => e.PtntId)
                    .HasName("APPOINTMENT_FK_PTNT_ID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("FK_APPOINTMENT_ROLE_ID");

                entity.HasIndex(e => e.ShcdIdLocation)
                    .HasName("APNT_FK_PPPU_LOCATION");

                entity.HasIndex(e => e.ShcdIdPaycode)
                    .HasName("APPOINTMENT_FK_SHCD_ID_PAYCO");

                entity.HasIndex(e => e.ShcdIdPriority)
                    .HasName("APNT_FK_PPPU_PRIORITY");

                entity.HasIndex(e => e.ShcdIdType)
                    .HasName("APNT_FOREIGN_SHORTCODE");

                entity.HasIndex(e => e.SrvcIdReason)
                    .HasName("APPOINTMENT_FK_REASON");

                entity.HasIndex(e => new { e.ApntIsdeleted, e.PppuIdProvider, e.ApntBooktime, e.ApntEndtime, e.PartitionId })
                    .HasName("idx_APPOINTMENT_APNT_ISDELETED_PPPU_ID_PROVIDER_APNT_BOOKTIME_APNT_ENDTIME_PARTITION_ID");

                entity.Property(e => e.ApntId)
                    .HasColumnName("APNT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApntAcknowledged).HasColumnName("APNT_ACKNOWLEDGED");

                entity.Property(e => e.ApntAnonymous).HasColumnName("APNT_ANONYMOUS");

                entity.Property(e => e.ApntArrivaltime)
                    .HasColumnName("APNT_ARRIVALTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntBooktime)
                    .HasColumnName("APNT_BOOKTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntCancellationReason).HasColumnName("APNT_CANCELLATION_REASON");

                entity.Property(e => e.ApntCaseId).HasColumnName("APNT_CASE_ID");

                entity.Property(e => e.ApntComment)
                    .HasColumnName("APNT_COMMENT")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ApntConfirmtime)
                    .HasColumnName("APNT_CONFIRMTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntConsultDuration)
                    .HasColumnName("APNT_CONSULT_DURATION")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntCreatedOn)
                    .HasColumnName("APNT_CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntDischargetime)
                    .HasColumnName("APNT_DISCHARGETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntDuration).HasColumnName("APNT_DURATION");

                entity.Property(e => e.ApntEndtime)
                    .HasColumnName("APNT_ENDTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntFlags)
                    .HasColumnName("APNT_FLAGS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApntFrontDeskNoteId).HasColumnName("APNT_FRONT_DESK_NOTE_ID");

                entity.Property(e => e.ApntGroup).HasColumnName("APNT_GROUP");

                entity.Property(e => e.ApntInternallyInitiated).HasColumnName("APNT_INTERNALLY_INITIATED");

                entity.Property(e => e.ApntInvoicetime)
                    .HasColumnName("APNT_INVOICETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntIsManuallyClosed).HasColumnName("APNT_IS_MANUALLY_CLOSED");

                entity.Property(e => e.ApntIsMeeting).HasColumnName("APNT_IS_MEETING");

                entity.Property(e => e.ApntIsNotified).HasColumnName("APNT_IS_NOTIFIED");

                entity.Property(e => e.ApntIscancelled).HasColumnName("APNT_ISCANCELLED");

                entity.Property(e => e.ApntIsclosed).HasColumnName("APNT_ISCLOSED");

                entity.Property(e => e.ApntIsdeleted).HasColumnName("APNT_ISDELETED");

                entity.Property(e => e.ApntIsdna).HasColumnName("APNT_ISDNA");

                entity.Property(e => e.ApntIslocked).HasColumnName("APNT_ISLOCKED");

                entity.Property(e => e.ApntIsreschedule).HasColumnName("APNT_ISRESCHEDULE");

                entity.Property(e => e.ApntKm).HasColumnName("APNT_KM");

                entity.Property(e => e.ApntLastNotificationRslt)
                    .HasColumnName("APNT_LAST_NOTIFICATION_RSLT")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ApntLetter).HasColumnName("APNT_LETTER");

                entity.Property(e => e.ApntLocationAddressId).HasColumnName("APNT_LOCATION_ADDRESS_ID");

                entity.Property(e => e.ApntLocationType).HasColumnName("APNT_LOCATION_TYPE");

                entity.Property(e => e.ApntMainApptId).HasColumnName("APNT_MAIN_APPT_ID");

                entity.Property(e => e.ApntMeetingLimit).HasColumnName("APNT_MEETING_LIMIT");

                entity.Property(e => e.ApntNeedconfirmation).HasColumnName("APNT_NEEDCONFIRMATION");

                entity.Property(e => e.ApntPendingInvoice)
                    .HasColumnName("APNT_PENDING_INVOICE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntPrappovId).HasColumnName("APNT_PRAPPOV_ID");

                entity.Property(e => e.ApntPrvsId).HasColumnName("APNT_PRVS_ID");

                entity.Property(e => e.ApntReasondescription)
                    .HasColumnName("APNT_REASONDESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApntRecurrency).HasColumnName("APNT_RECURRENCY");

                entity.Property(e => e.ApntReferralId).HasColumnName("APNT_REFERRAL_ID");

                entity.Property(e => e.ApntSeenDuration).HasColumnName("APNT_SEEN_DURATION");

                entity.Property(e => e.ApntSeentime)
                    .HasColumnName("APNT_SEENTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApntSessionId).HasColumnName("APNT_SESSION_ID");

                entity.Property(e => e.ApntSourceref)
                    .HasColumnName("APNT_SOURCEREF")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ApntStatus).HasColumnName("APNT_STATUS");

                entity.Property(e => e.ApntUnbooked).HasColumnName("APNT_UNBOOKED");

                entity.Property(e => e.ApntVersion).HasColumnName("APNT_VERSION");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EarlierRequest)
                    .HasColumnName("EARLIER_REQUEST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PppuIdPos).HasColumnName("PPPU_ID_POS");

                entity.Property(e => e.PppuIdProvider).HasColumnName("PPPU_ID_PROVIDER");

                entity.Property(e => e.PppuIdSeenby).HasColumnName("PPPU_ID_SEENBY");

                entity.Property(e => e.PrivacyOrg).HasColumnName("PRIVACY_ORG");

                entity.Property(e => e.PrivacyPppuId).HasColumnName("PRIVACY_PPPU_ID");

                entity.Property(e => e.PtntId).HasColumnName("PTNT_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.ShcdIdLocation).HasColumnName("SHCD_ID_LOCATION");

                entity.Property(e => e.ShcdIdPaycode).HasColumnName("SHCD_ID_PAYCODE");

                entity.Property(e => e.ShcdIdPriority).HasColumnName("SHCD_ID_PRIORITY");

                entity.Property(e => e.ShcdIdType).HasColumnName("SHCD_ID_TYPE");

                entity.Property(e => e.SrvcIdReason).HasColumnName("SRVC_ID_REASON");

                entity.HasOne(d => d.ApntCancellationReasonNavigation)
                    .WithMany(p => p.AppointmentApntCancellationReasonNavigation)
                    .HasForeignKey(d => d.ApntCancellationReason)
                    .HasConstraintName("APNT_FK_CANCELLATION_REASON");

                entity.HasOne(d => d.ApntCase)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.ApntCaseId)
                    .HasConstraintName("APPOINTMENT_FK_APNT_CASE_ID");

                entity.HasOne(d => d.ApntGroupNavigation)
                    .WithMany(p => p.InverseApntGroupNavigation)
                    .HasForeignKey(d => d.ApntGroup)
                    .HasConstraintName("APPOINTMENT_FK_GROUP");

                entity.HasOne(d => d.ApntLocationAddress)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.ApntLocationAddressId)
                    .HasConstraintName("FK_APNT_LOCATION_ADDRESS_ID");

                entity.HasOne(d => d.ApntMainAppt)
                    .WithMany(p => p.InverseApntMainAppt)
                    .HasForeignKey(d => d.ApntMainApptId)
                    .HasConstraintName("FK_APNT_MAIN_APPT_ID");

                entity.HasOne(d => d.ApntPrvs)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.ApntPrvsId)
                    .HasConstraintName("APNT_PRVS_FK_PRVS");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.AppointmentCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("FK_APPT_CREATEDBY_PPPU");

                entity.HasOne(d => d.ModifiedbyNavigation)
                    .WithMany(p => p.AppointmentModifiedbyNavigation)
                    .HasForeignKey(d => d.Modifiedby)
                    .HasConstraintName("FK_APPT_MODIFIEDBY_PPPU");

                entity.HasOne(d => d.PppuIdPosNavigation)
                    .WithMany(p => p.AppointmentPppuIdPosNavigation)
                    .HasForeignKey(d => d.PppuIdPos)
                    .HasConstraintName("APPOINTMENT_FK_POS");

                entity.HasOne(d => d.PppuIdProviderNavigation)
                    .WithMany(p => p.AppointmentPppuIdProviderNavigation)
                    .HasForeignKey(d => d.PppuIdProvider)
                    .HasConstraintName("APPOINTMENT_FK_PROVIDER");

                entity.HasOne(d => d.PppuIdSeenbyNavigation)
                    .WithMany(p => p.AppointmentPppuIdSeenbyNavigation)
                    .HasForeignKey(d => d.PppuIdSeenby)
                    .HasConstraintName("APNT_FK_PPPU_SEENBY");

                entity.HasOne(d => d.PrivacyPppu)
                    .WithMany(p => p.AppointmentPrivacyPppu)
                    .HasForeignKey(d => d.PrivacyPppuId)
                    .HasConstraintName("APPOINTMENT_FK_PPPU");

                entity.HasOne(d => d.Ptnt)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.PtntId)
                    .HasConstraintName("APPOINTMENT_FK_PTNT_ID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_APPOINTMENT_ROLE_ID");

                entity.HasOne(d => d.ShcdIdLocationNavigation)
                    .WithMany(p => p.AppointmentShcdIdLocationNavigation)
                    .HasForeignKey(d => d.ShcdIdLocation)
                    .HasConstraintName("APNT_FK_PPPU_LOCATION");

                entity.HasOne(d => d.ShcdIdPaycodeNavigation)
                    .WithMany(p => p.AppointmentShcdIdPaycodeNavigation)
                    .HasForeignKey(d => d.ShcdIdPaycode)
                    .HasConstraintName("APPOINTMENT_FK_SHCD_ID_PAYCO");

                entity.HasOne(d => d.ShcdIdPriorityNavigation)
                    .WithMany(p => p.AppointmentShcdIdPriorityNavigation)
                    .HasForeignKey(d => d.ShcdIdPriority)
                    .HasConstraintName("APNT_FK_PPPU_PRIORITY");

                entity.HasOne(d => d.ShcdIdTypeNavigation)
                    .WithMany(p => p.AppointmentShcdIdTypeNavigation)
                    .HasForeignKey(d => d.ShcdIdType)
                    .HasConstraintName("APNT_FOREIGN_SHORTCODE");
            });

            modelBuilder.Entity<Appointmentaudit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("APPOINTMENTAUDIT");

                entity.HasIndex(e => e.ApntId)
                    .HasName("APPOINTMENTAUDIT_FK_APNT");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_APPOINTMENTAUDIT");

                entity.HasIndex(e => e.PppuIdUser)
                    .HasName("APAD_USER");

                entity.HasIndex(e => e.PtntId)
                    .HasName("APPOINTMENTAUDIT_FK_PTNT_ID");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApadBooktime)
                    .HasColumnName("APAD_BOOKTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApadDatetime)
                    .HasColumnName("APAD_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApadDescription)
                    .HasColumnName("APAD_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApadDuration)
                    .HasColumnName("APAD_DURATION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApadIsappointmentdeleted).HasColumnName("APAD_ISAPPOINTMENTDELETED");

                entity.Property(e => e.ApntId).HasColumnName("APNT_ID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PppuIdUser).HasColumnName("PPPU_ID_USER");

                entity.Property(e => e.PtntId).HasColumnName("PTNT_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Apnt)
                    .WithMany(p => p.Appointmentaudit)
                    .HasForeignKey(d => d.ApntId)
                    .HasConstraintName("APPOINTMENTAUDIT_FK_APNT");

                entity.HasOne(d => d.PppuIdUserNavigation)
                    .WithMany(p => p.Appointmentaudit)
                    .HasForeignKey(d => d.PppuIdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("APAD_USER");

                entity.HasOne(d => d.Ptnt)
                    .WithMany(p => p.Appointmentaudit)
                    .HasForeignKey(d => d.PtntId)
                    .HasConstraintName("APPOINTMENTAUDIT_FK_PTNT_ID");
            });

            modelBuilder.Entity<AppointmentRules>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("APPOINTMENT_RULES");

                entity.HasIndex(e => e.DefReasonId)
                    .HasName("FK_APRL_SRVC");

                entity.HasIndex(e => e.DefType)
                    .HasName("FK_APRL_SHCD");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_APPOINTMENT_RULES");

                entity.HasIndex(e => e.PatientHelpInfo)
                    .HasName("FK_APPTRL_PTNT_HELP_INFO");

                entity.HasIndex(e => e.Pos)
                    .HasName("FK_APRL_POS_PPPU");

                entity.HasIndex(e => e.Provider)
                    .HasName("FK_APRL_PROV_PPPU");

                entity.HasIndex(e => e.ProviderHelpInfo)
                    .HasName("FK_APPTRL_PROV_HELP_INFO");

                entity.HasIndex(e => e.RuleFinish)
                    .HasName("APPT_RULES_I_RULE_FINISH");

                entity.HasIndex(e => e.RulePriority)
                    .HasName("APRL_PRIORITY");

                entity.HasIndex(e => e.RuleStart)
                    .HasName("APPT_RULES_I_RULE_START");

                entity.HasIndex(e => e.TempCommonType)
                    .HasName("APNT_RULES_FK_TYPE");

                entity.HasIndex(e => e.TempGroupid)
                    .HasName("FK_APNT_RULES_PROV_GROUP");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DefReasonDesc)
                    .HasColumnName("DEF_REASON_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DefReasonId).HasColumnName("DEF_REASON_ID");

                entity.Property(e => e.DefType).HasColumnName("DEF_TYPE");

                entity.Property(e => e.Deletedid)
                    .HasColumnName("DELETEDID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Macro)
                    .HasColumnName("MACRO")
                    .HasColumnType("image");

                entity.Property(e => e.MeetingLimit).HasColumnName("MEETING_LIMIT");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PatientHelpInfo).HasColumnName("PATIENT_HELP_INFO");

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.Provider).HasColumnName("PROVIDER");

                entity.Property(e => e.ProviderHelpInfo).HasColumnName("PROVIDER_HELP_INFO");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RuleAllowcover)
                    .HasColumnName("RULE_ALLOWCOVER")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RuleCycle)
                    .IsRequired()
                    .HasColumnName("RULE_CYCLE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RuleDays)
                    .HasColumnName("RULE_DAYS")
                    .HasColumnType("image");

                entity.Property(e => e.RuleDouble).HasColumnName("RULE_DOUBLE");

                entity.Property(e => e.RuleFinish)
                    .HasColumnName("RULE_FINISH")
                    .HasColumnType("datetime");

                entity.Property(e => e.RuleName)
                    .IsRequired()
                    .HasColumnName("RULE_NAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.RulePeriod).HasColumnName("RULE_PERIOD");

                entity.Property(e => e.RulePermitaccession).HasColumnName("RULE_PERMITACCESSION");

                entity.Property(e => e.RulePriority).HasColumnName("RULE_PRIORITY");

                entity.Property(e => e.RuleStart)
                    .HasColumnName("RULE_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.SkipMinutes).HasColumnName("SKIP_MINUTES");

                entity.Property(e => e.TempColor).HasColumnName("TEMP_COLOR");

                entity.Property(e => e.TempCommonType).HasColumnName("TEMP_COMMON_TYPE");

                entity.Property(e => e.TempDay).HasColumnName("TEMP_DAY");

                entity.Property(e => e.TempGroupid).HasColumnName("TEMP_GROUPID");

                entity.Property(e => e.TempStatus).HasColumnName("TEMP_STATUS");

                entity.Property(e => e.TempTimes)
                    .HasColumnName("TEMP_TIMES")
                    .HasColumnType("image");

                entity.Property(e => e.TimeFinish)
                    .HasColumnName("TIME_FINISH")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStart)
                    .HasColumnName("TIME_START")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.DefTypeNavigation)
                    .WithMany(p => p.AppointmentRulesDefTypeNavigation)
                    .HasForeignKey(d => d.DefType)
                    .HasConstraintName("FK_APRL_SHCD");

                entity.HasOne(d => d.PosNavigation)
                    .WithMany(p => p.AppointmentRulesPosNavigation)
                    .HasForeignKey(d => d.Pos)
                    .HasConstraintName("FK_APRL_POS_PPPU");

                entity.HasOne(d => d.ProviderNavigation)
                    .WithMany(p => p.AppointmentRulesProviderNavigation)
                    .HasForeignKey(d => d.Provider)
                    .HasConstraintName("FK_APRL_PROV_PPPU");

                entity.HasOne(d => d.TempCommonTypeNavigation)
                    .WithMany(p => p.AppointmentRulesTempCommonTypeNavigation)
                    .HasForeignKey(d => d.TempCommonType)
                    .HasConstraintName("APNT_RULES_FK_TYPE");
            });

            modelBuilder.Entity<AppRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("APP_ROLE");

                entity.HasIndex(e => e.Createdby)
                    .HasName("ROLE_FK_CREATEDBY");

                entity.HasIndex(e => e.DefCefformId)
                    .HasName("I_APPROLE_DEFCEFFORM");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_APP_ROLE");

                entity.HasIndex(e => e.ParentRole)
                    .HasName("ROLE_FK_PARENT_ROLE");

                entity.HasIndex(e => e.PrivacyEntryId)
                    .HasName("FK_APPROLE_PRIVACY_ENTRY");

                entity.HasIndex(e => new { e.RoleName, e.PartitionId, e.Deletedid })
                    .HasName("APP_ROLE_NAME")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Conditions)
                    .HasColumnName("CONDITIONS")
                    .HasColumnType("image");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnName("CREATEDON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefCefformId).HasColumnName("DEF_CEFFORM_ID");

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.DisabledOps)
                    .HasColumnName("DISABLED_OPS")
                    .HasColumnType("image");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmrIsReadonly).HasColumnName("EMR_IS_READONLY");

                entity.Property(e => e.EnabledOps)
                    .HasColumnName("ENABLED_OPS")
                    .HasColumnType("image");

                entity.Property(e => e.EncountersStyle).HasColumnName("ENCOUNTERS_STYLE");

                entity.Property(e => e.EncountersWindowStyle)
                    .HasColumnName("ENCOUNTERS_WINDOW_STYLE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LimitEmrsAndCases).HasColumnName("LIMIT_EMRS_AND_CASES");

                entity.Property(e => e.MaxCases).HasColumnName("MAX_CASES");

                entity.Property(e => e.MaxEmrs).HasColumnName("MAX_EMRS");

                entity.Property(e => e.MaxEmrsAndCases).HasColumnName("MAX_EMRS_AND_CASES");

                entity.Property(e => e.MaxNewenc).HasColumnName("MAX_NEWENC");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.ObjectRights)
                    .HasColumnName("OBJECT_RIGHTS")
                    .HasColumnType("image");

                entity.Property(e => e.ParentRole).HasColumnName("PARENT_ROLE");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PrivacyEntryId).HasColumnName("PRIVACY_ENTRY_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RemotePrivacy)
                    .IsRequired()
                    .HasColumnName("REMOTE_PRIVACY")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoleName)
                    .HasColumnName("ROLE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Roletype).HasColumnName("ROLETYPE");

                entity.Property(e => e.UpdateCaseDependencies)
                    .HasColumnName("UPDATE_CASE_DEPENDENCIES")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.UseForPrivacy)
                    .HasColumnName("USE_FOR_PRIVACY")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.AppRole)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("ROLE_FK_CREATEDBY");

                entity.HasOne(d => d.DefCefform)
                    .WithMany(p => p.AppRole)
                    .HasForeignKey(d => d.DefCefformId)
                    .HasConstraintName("I_APPROLE_DEFCEFFORM");

                entity.HasOne(d => d.ParentRoleNavigation)
                    .WithMany(p => p.InverseParentRoleNavigation)
                    .HasForeignKey(d => d.ParentRole)
                    .HasConstraintName("ROLE_FK_PARENT_ROLE");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasKey(e => e.AudtId);

                entity.ToTable("AUDIT_");

                entity.HasIndex(e => e.AudtLogoncode)
                    .HasName("IDX_AUDT_LOGONCODE");

                entity.HasIndex(e => e.AudtPppuId)
                    .HasName("AUDT_FK_PPPU_ID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_AUDIT_");

                entity.HasIndex(e => new { e.AudtDate, e.AudtLogoncomputer })
                    .HasName("I_AUDIT_DATE_LOGONCOMPUTER");

                entity.Property(e => e.AudtId)
                    .HasColumnName("AUDT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuditIp)
                    .HasColumnName("AUDIT_IP")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.AudtAction)
                    .HasColumnName("AUDT_ACTION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AudtDate)
                    .HasColumnName("AUDT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AudtLogoffDate)
                    .HasColumnName("AUDT_LOGOFF_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AudtLogoncode)
                    .HasColumnName("AUDT_LOGONCODE")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AudtLogoncomputer)
                    .HasColumnName("AUDT_LOGONCOMPUTER")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AudtNic)
                    .HasColumnName("AUDT_NIC")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AudtPppuId).HasColumnName("AUDT_PPPU_ID");

                entity.Property(e => e.AudtResultcode).HasColumnName("AUDT_RESULTCODE");

                entity.Property(e => e.AudtSecurityc).HasColumnName("AUDT_SECURITYC");

                entity.Property(e => e.AudtSecurityf).HasColumnName("AUDT_SECURITYF");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserText)
                    .HasColumnName("USER_TEXT")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.AudtPppu)
                    .WithMany(p => p.Audit)
                    .HasForeignKey(d => d.AudtPppuId)
                    .HasConstraintName("AUDT_FK_PPPU_ID");
            });

            modelBuilder.Entity<Bcase>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("BCASE");

                entity.HasIndex(e => e.AlteredById)
                    .HasName("BCASE_FK_ALTERED_BY_ID");

                entity.HasIndex(e => e.CaseInitDiagId)
                    .HasName("BCASE_FK_CASE_INIT_DIAG_ID");

                entity.HasIndex(e => e.CaseMngrId)
                    .HasName("BCASE_FK_CASE_MNGR_ID");

                entity.HasIndex(e => e.CaseRoleId)
                    .HasName("FK_CASE_ROLE_ID");

                entity.HasIndex(e => e.CaseSettings)
                    .HasName("FK_BCASE_SETTINGS");

                entity.HasIndex(e => e.CaseTemplate)
                    .HasName("FK_BCASE_CASE_TEMPLATE_ID");

                entity.HasIndex(e => e.Condition)
                    .HasName("BCASE_FK_CONDITION");

                entity.HasIndex(e => e.CreatorId)
                    .HasName("BCASE_FK_CREATOR_ID");

                entity.HasIndex(e => e.Financial)
                    .HasName("FK_CASE_CASE_FINANCIAL");

                entity.HasIndex(e => e.ForceCase)
                    .HasName("FK_BCASE_FORCECASE");

                entity.HasIndex(e => e.LeadProvId)
                    .HasName("BCASE_FK_LEAD_PROV_ID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_BCASE");

                entity.HasIndex(e => e.OrgStructureId)
                    .HasName("FK_BCASE_ORGSTRUCTURE");

                entity.HasIndex(e => e.Origination)
                    .HasName("BCASE_FK_ORIGINATION");

                entity.HasIndex(e => e.PatientId)
                    .HasName("BCASE_FK_PATIENT_ID");

                entity.HasIndex(e => e.Presentation)
                    .HasName("BCASE_FK_PRESENTATION");

                entity.HasIndex(e => e.PrivacyPppuId)
                    .HasName("BCASE_FK_PPPU");

                entity.HasIndex(e => e.RefOid)
                    .HasName("BCASE_FK_REF_OID");

                entity.HasIndex(e => e.RoleOid)
                    .HasName("BCASE_FK_ROLE_OID");

                entity.HasIndex(e => e.RoleOidAdmin)
                    .HasName("FK_CASEROLEADMIN_OID");

                entity.HasIndex(e => e.SepDiagId)
                    .HasName("BCASE_FK_SEP_DIAG_ID");

                entity.HasIndex(e => e.SepOutcomeId)
                    .HasName("BCASE_FK_SEP_OUTCOME_ID");

                entity.HasIndex(e => e.SepServiceId)
                    .HasName("BCASE_FK_SEP_SERVICE_ID");

                entity.HasIndex(e => e.ServicePosId)
                    .HasName("BCASE_FK_SERVICE_POS_ID");

                entity.HasIndex(e => e.ShcdCaserisk)
                    .HasName("FK_BCASE_CASERISK_SHCD_ID");

                entity.HasIndex(e => e.ShcdDischargedtoid)
                    .HasName("FK_CASEDISCHARGEDTO_SHCD_ID");

                entity.HasIndex(e => e.ShcdPriorityid)
                    .HasName("FK_CASEPRIORITY_SHCD_ID");

                entity.HasIndex(e => e.ShcdSource1)
                    .HasName("BCASE_SRC1_FK_SHORTCODE");

                entity.HasIndex(e => e.ShcdSource2)
                    .HasName("BCASE_SRC2_FK_SHORTCODE");

                entity.HasIndex(e => e.Source)
                    .HasName("BCASE_FK_SOURCE");

                entity.HasIndex(e => e.Sourceref)
                    .HasName("BCASE_I_SOURCEREF");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlteredById).HasColumnName("ALTERED_BY_ID");

                entity.Property(e => e.AlteredOn)
                    .HasColumnName("ALTERED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarePlan)
                    .HasColumnName("CARE_PLAN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CaseAvailInAccession)
                    .HasColumnName("CASE_AVAIL_IN_ACCESSION")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CaseInitDiagId).HasColumnName("CASE_INIT_DIAG_ID");

                entity.Property(e => e.CaseMngrId).HasColumnName("CASE_MNGR_ID");

                entity.Property(e => e.CaseRoleId).HasColumnName("CASE_ROLE_ID");

                entity.Property(e => e.CaseSettings).HasColumnName("CASE_SETTINGS");

                entity.Property(e => e.CaseTemplate).HasColumnName("CASE_TEMPLATE");

                entity.Property(e => e.CaseTitle)
                    .HasColumnName("CASE_TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CasemixComm)
                    .HasColumnName("CASEMIX_COMM")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CasemixFinal).HasColumnName("CASEMIX_FINAL");

                entity.Property(e => e.CasemixInitial).HasColumnName("CASEMIX_INITIAL");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.ClosedOn)
                    .HasColumnName("CLOSED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Condition).HasColumnName("CONDITION");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatorId).HasColumnName("CREATOR_ID");

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Financial).HasColumnName("FINANCIAL");

                entity.Property(e => e.Firstvisit)
                    .HasColumnName("FIRSTVISIT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ForceCase).HasColumnName("FORCE_CASE");

                entity.Property(e => e.LeadProvId).HasColumnName("LEAD_PROV_ID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.OpenedOn)
                    .HasColumnName("OPENED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrgStructureId).HasColumnName("ORG_STRUCTURE_ID");

                entity.Property(e => e.Origination)
                    .HasColumnName("ORIGINATION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.Presentation).HasColumnName("PRESENTATION");

                entity.Property(e => e.PrivacyOrg).HasColumnName("PRIVACY_ORG");

                entity.Property(e => e.PrivacyPppuId).HasColumnName("PRIVACY_PPPU_ID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.RefCid).HasColumnName("REF_CID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefOid).HasColumnName("REF_OID");

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .HasColumnName("REFERRER")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RelevantInf)
                    .HasColumnName("RELEVANT_INF")
                    .HasMaxLength(900)
                    .IsUnicode(false);

                entity.Property(e => e.RoleOid).HasColumnName("ROLE_OID");

                entity.Property(e => e.RoleOidAdmin).HasColumnName("ROLE_OID_ADMIN");

                entity.Property(e => e.SepDiagId).HasColumnName("SEP_DIAG_ID");

                entity.Property(e => e.SepOutcomeId).HasColumnName("SEP_OUTCOME_ID");

                entity.Property(e => e.SepServiceId).HasColumnName("SEP_SERVICE_ID");

                entity.Property(e => e.ServicePosId).HasColumnName("SERVICE_POS_ID");

                entity.Property(e => e.ShcdCaserisk).HasColumnName("SHCD_CASERISK");

                entity.Property(e => e.ShcdDischargedtoid).HasColumnName("SHCD_DISCHARGEDTOID");

                entity.Property(e => e.ShcdPriorityid).HasColumnName("SHCD_PRIORITYID");

                entity.Property(e => e.ShcdSource1).HasColumnName("SHCD_SOURCE1");

                entity.Property(e => e.ShcdSource2).HasColumnName("SHCD_SOURCE2");

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Source1date)
                    .HasColumnName("SOURCE1DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Source2date)
                    .HasColumnName("SOURCE2DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sourceref)
                    .HasColumnName("SOURCEREF")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.HasOne(d => d.AlteredBy)
                    .WithMany(p => p.BcaseAlteredBy)
                    .HasForeignKey(d => d.AlteredById)
                    .HasConstraintName("BCASE_FK_ALTERED_BY_ID");

                entity.HasOne(d => d.CaseInitDiag)
                    .WithMany(p => p.BcaseCaseInitDiag)
                    .HasForeignKey(d => d.CaseInitDiagId)
                    .HasConstraintName("BCASE_FK_CASE_INIT_DIAG_ID");

                entity.HasOne(d => d.CaseMngr)
                    .WithMany(p => p.BcaseCaseMngr)
                    .HasForeignKey(d => d.CaseMngrId)
                    .HasConstraintName("BCASE_FK_CASE_MNGR_ID");

                entity.HasOne(d => d.CaseRole)
                    .WithMany(p => p.BcaseCaseRole)
                    .HasForeignKey(d => d.CaseRoleId)
                    .HasConstraintName("FK_CASE_ROLE_ID");

                entity.HasOne(d => d.CaseSettingsNavigation)
                    .WithMany(p => p.BcaseCaseSettingsNavigation)
                    .HasForeignKey(d => d.CaseSettings)
                    .HasConstraintName("FK_BCASE_SETTINGS");

                entity.HasOne(d => d.CaseTemplateNavigation)
                    .WithMany(p => p.Bcase)
                    .HasForeignKey(d => d.CaseTemplate)
                    .HasConstraintName("FK_BCASE_CASE_TEMPLATE_ID");

                entity.HasOne(d => d.ConditionNavigation)
                    .WithMany(p => p.BcaseConditionNavigation)
                    .HasForeignKey(d => d.Condition)
                    .HasConstraintName("BCASE_FK_CONDITION");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.BcaseCreator)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BCASE_FK_CREATOR_ID");

                entity.HasOne(d => d.ForceCaseNavigation)
                    .WithMany(p => p.BcaseForceCaseNavigation)
                    .HasForeignKey(d => d.ForceCase)
                    .HasConstraintName("FK_BCASE_FORCECASE");

                entity.HasOne(d => d.LeadProv)
                    .WithMany(p => p.BcaseLeadProv)
                    .HasForeignKey(d => d.LeadProvId)
                    .HasConstraintName("BCASE_FK_LEAD_PROV_ID");

                entity.HasOne(d => d.OrgStructure)
                    .WithMany(p => p.BcaseOrgStructure)
                    .HasForeignKey(d => d.OrgStructureId)
                    .HasConstraintName("FK_BCASE_ORGSTRUCTURE");

                entity.HasOne(d => d.OriginationNavigation)
                    .WithMany(p => p.BcaseOriginationNavigation)
                    .HasForeignKey(d => d.Origination)
                    .HasConstraintName("BCASE_FK_ORIGINATION");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Bcase)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BCASE_FK_PATIENT_ID");

                entity.HasOne(d => d.PresentationNavigation)
                    .WithMany(p => p.BcasePresentationNavigation)
                    .HasForeignKey(d => d.Presentation)
                    .HasConstraintName("BCASE_FK_PRESENTATION");

                entity.HasOne(d => d.PrivacyPppu)
                    .WithMany(p => p.BcasePrivacyPppu)
                    .HasForeignKey(d => d.PrivacyPppuId)
                    .HasConstraintName("BCASE_FK_PPPU");

                entity.HasOne(d => d.RoleO)
                    .WithMany(p => p.BcaseRoleO)
                    .HasForeignKey(d => d.RoleOid)
                    .HasConstraintName("BCASE_FK_ROLE_OID");

                entity.HasOne(d => d.RoleOidAdminNavigation)
                    .WithMany(p => p.BcaseRoleOidAdminNavigation)
                    .HasForeignKey(d => d.RoleOidAdmin)
                    .HasConstraintName("FK_CASEROLEADMIN_OID");

                entity.HasOne(d => d.SepDiag)
                    .WithMany(p => p.BcaseSepDiag)
                    .HasForeignKey(d => d.SepDiagId)
                    .HasConstraintName("BCASE_FK_SEP_DIAG_ID");

                entity.HasOne(d => d.SepOutcome)
                    .WithMany(p => p.BcaseSepOutcome)
                    .HasForeignKey(d => d.SepOutcomeId)
                    .HasConstraintName("BCASE_FK_SEP_OUTCOME_ID");

                entity.HasOne(d => d.ServicePos)
                    .WithMany(p => p.BcaseServicePos)
                    .HasForeignKey(d => d.ServicePosId)
                    .HasConstraintName("BCASE_FK_SERVICE_POS_ID");

                entity.HasOne(d => d.ShcdCaseriskNavigation)
                    .WithMany(p => p.BcaseShcdCaseriskNavigation)
                    .HasForeignKey(d => d.ShcdCaserisk)
                    .HasConstraintName("FK_BCASE_CASERISK_SHCD_ID");

                entity.HasOne(d => d.ShcdDischargedto)
                    .WithMany(p => p.BcaseShcdDischargedto)
                    .HasForeignKey(d => d.ShcdDischargedtoid)
                    .HasConstraintName("FK_CASEDISCHARGEDTO_SHCD_ID");

                entity.HasOne(d => d.ShcdPriority)
                    .WithMany(p => p.BcaseShcdPriority)
                    .HasForeignKey(d => d.ShcdPriorityid)
                    .HasConstraintName("FK_CASEPRIORITY_SHCD_ID");

                entity.HasOne(d => d.ShcdSource1Navigation)
                    .WithMany(p => p.BcaseShcdSource1Navigation)
                    .HasForeignKey(d => d.ShcdSource1)
                    .HasConstraintName("BCASE_SRC1_FK_SHORTCODE");

                entity.HasOne(d => d.ShcdSource2Navigation)
                    .WithMany(p => p.BcaseShcdSource2Navigation)
                    .HasForeignKey(d => d.ShcdSource2)
                    .HasConstraintName("BCASE_SRC2_FK_SHORTCODE");

                entity.HasOne(d => d.SourceNavigation)
                    .WithMany(p => p.BcaseSourceNavigation)
                    .HasForeignKey(d => d.Source)
                    .HasConstraintName("BCASE_FK_SOURCE");
            });

            modelBuilder.Entity<Blobs>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("BLOBS");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_BLOBS");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasColumnType("image");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareTeam>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CARE_TEAM");

                entity.HasIndex(e => e.Createdby)
                    .HasName("CARE_TEAM_FK_CREATEDBY");

                entity.HasIndex(e => e.CtCaseId)
                    .HasName("CARETEAM_FK_CASE_ID");

                entity.HasIndex(e => e.CtClosedBy)
                    .HasName("CT_FK_CLOSED_BY_CDO_PERSON");

                entity.HasIndex(e => e.CtOriginPartitionId)
                    .HasName("FK_CT_ORGN_PARTITION_ID");

                entity.HasIndex(e => e.CtPatient)
                    .HasName("CARETEAM_FK_PATIENT");

                entity.HasIndex(e => e.CtPayerId)
                    .HasName("CARE_TEAM_FK_PAYER_ID");

                entity.HasIndex(e => e.CtPersonId)
                    .HasName("CARETEAM_FK_PERSON_ID");

                entity.HasIndex(e => e.CtPppuRole)
                    .HasName("CARE_TEAM_FK_PPPU_ROLE");

                entity.HasIndex(e => e.CtPrivacyid)
                    .HasName("CT_FK_PRIVACYID");

                entity.HasIndex(e => e.CtRole)
                    .HasName("CARETEAM_FK_ROLE");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("CARE_TEAM_FK_DELETEDBY");

                entity.HasIndex(e => e.MasterId)
                    .HasName("CARE_TEAM_FK_MASTER");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CARE_TEAM");

                entity.HasIndex(e => e.PrivacyPppuId)
                    .HasName("CARE_TEAM_FK_PPPU");

                entity.HasIndex(e => new { e.MasterId, e.Version })
                    .HasName("CARE_TEAM_I_MASTERVERS")
                    .IsUnique();

                entity.HasIndex(e => new { e.CtPatient, e.CtCaseId, e.CtRole })
                    .HasName("CARE_TEAM_I_PTNT_CASE_ROLE");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.CtCaseId).HasColumnName("CT_CASE_ID");

                entity.Property(e => e.CtClosedBy).HasColumnName("CT_CLOSED_BY");

                entity.Property(e => e.CtClosedDate)
                    .HasColumnName("CT_CLOSED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('30-DEC-1899')");

                entity.Property(e => e.CtComments)
                    .HasColumnName("CT_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CtDate)
                    .HasColumnName("CT_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('30-DEC-1899')");

                entity.Property(e => e.CtDateFrom)
                    .HasColumnName("CT_DATE_FROM")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('30-DEC-1899')");

                entity.Property(e => e.CtDateTo)
                    .HasColumnName("CT_DATE_TO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('30-DEC-1899')");

                entity.Property(e => e.CtIscurrent).HasColumnName("CT_ISCURRENT");

                entity.Property(e => e.CtOriginPartitionId).HasColumnName("CT_ORIGIN_PARTITION_ID");

                entity.Property(e => e.CtPatient).HasColumnName("CT_PATIENT");

                entity.Property(e => e.CtPayerId).HasColumnName("CT_PAYER_ID");

                entity.Property(e => e.CtPersonId).HasColumnName("CT_PERSON_ID");

                entity.Property(e => e.CtPppuRole).HasColumnName("CT_PPPU_ROLE");

                entity.Property(e => e.CtPrincipal).HasColumnName("CT_PRINCIPAL");

                entity.Property(e => e.CtPrivacyid).HasColumnName("CT_PRIVACYID");

                entity.Property(e => e.CtRole).HasColumnName("CT_ROLE");

                entity.Property(e => e.CtSharedPlanPrivacy).HasColumnName("CT_SHARED_PLAN_PRIVACY");

                entity.Property(e => e.CtStatus).HasColumnName("CT_STATUS");

                entity.Property(e => e.CtType).HasColumnName("CT_TYPE");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PrivacyOrg).HasColumnName("PRIVACY_ORG");

                entity.Property(e => e.PrivacyPppuId).HasColumnName("PRIVACY_PPPU_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.CareTeamCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("CARE_TEAM_FK_CREATEDBY");

                entity.HasOne(d => d.CtCase)
                    .WithMany(p => p.CareTeam)
                    .HasForeignKey(d => d.CtCaseId)
                    .HasConstraintName("CARETEAM_FK_CASE_ID");

                entity.HasOne(d => d.CtClosedByNavigation)
                    .WithMany(p => p.CareTeamCtClosedByNavigation)
                    .HasForeignKey(d => d.CtClosedBy)
                    .HasConstraintName("CT_FK_CLOSED_BY_CDO_PERSON");

                entity.HasOne(d => d.CtOriginPartition)
                    .WithMany(p => p.CareTeam)
                    .HasForeignKey(d => d.CtOriginPartitionId)
                    .HasConstraintName("FK_CT_ORGN_PARTITION_ID");

                entity.HasOne(d => d.CtPatientNavigation)
                    .WithMany(p => p.CareTeamCtPatientNavigation)
                    .HasForeignKey(d => d.CtPatient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CARETEAM_FK_PATIENT");

                entity.HasOne(d => d.CtPayer)
                    .WithMany(p => p.CareTeamCtPayer)
                    .HasForeignKey(d => d.CtPayerId)
                    .HasConstraintName("CARE_TEAM_FK_PAYER_ID");

                entity.HasOne(d => d.CtPerson)
                    .WithMany(p => p.CareTeamCtPerson)
                    .HasForeignKey(d => d.CtPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CARETEAM_FK_PERSON_ID");

                entity.HasOne(d => d.CtPppuRoleNavigation)
                    .WithMany(p => p.CareTeamCtPppuRoleNavigation)
                    .HasForeignKey(d => d.CtPppuRole)
                    .HasConstraintName("CARE_TEAM_FK_PPPU_ROLE");

                entity.HasOne(d => d.CtPrivacy)
                    .WithMany(p => p.CareTeamCtPrivacy)
                    .HasForeignKey(d => d.CtPrivacyid)
                    .HasConstraintName("CT_FK_PRIVACYID");

                entity.HasOne(d => d.CtRoleNavigation)
                    .WithMany(p => p.CareTeam)
                    .HasForeignKey(d => d.CtRole)
                    .HasConstraintName("CARETEAM_FK_ROLE");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.CareTeamDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("CARE_TEAM_FK_DELETEDBY");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.InverseMaster)
                    .HasForeignKey(d => d.MasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CARE_TEAM_FK_MASTER");

                entity.HasOne(d => d.PrivacyPppu)
                    .WithMany(p => p.CareTeamPrivacyPppu)
                    .HasForeignKey(d => d.PrivacyPppuId)
                    .HasConstraintName("CARE_TEAM_FK_PPPU");
            });

            modelBuilder.Entity<CaseAudit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CASE_AUDIT");

                entity.HasIndex(e => e.CaseId)
                    .HasName("CASE_AUDIT_FK_CASE_ID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CASE_AUDIT");

                entity.HasIndex(e => e.ObserverPtntId)
                    .HasName("FK_CAUDIT_OBSPTNTID");

                entity.HasIndex(e => e.PppuId)
                    .HasName("CASE_AUDIT_FK_PPPU_ID");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessCode)
                    .HasColumnName("ACCESS_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.Computername)
                    .HasColumnName("COMPUTERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDatetime)
                    .HasColumnName("END_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.ObserverPtntId).HasColumnName("OBSERVER_PTNT_ID");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PppuId).HasColumnName("PPPU_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StartDatetime)
                    .HasColumnName("START_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserText)
                    .HasColumnName("USER_TEXT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseAudit)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("CASE_AUDIT_FK_CASE_ID");

                entity.HasOne(d => d.ObserverPtnt)
                    .WithMany(p => p.CaseAudit)
                    .HasForeignKey(d => d.ObserverPtntId)
                    .HasConstraintName("FK_CAUDIT_OBSPTNTID");

                entity.HasOne(d => d.Pppu)
                    .WithMany(p => p.CaseAudit)
                    .HasForeignKey(d => d.PppuId)
                    .HasConstraintName("CASE_AUDIT_FK_PPPU_ID");
            });

            modelBuilder.Entity<CaseAuditDetails>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CASE_AUDIT_DETAILS");

                entity.HasIndex(e => e.CadAuditId)
                    .HasName("CAD_AUDIT_ID_FK");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CASE_AUDIT_DETAILS");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CadAlertdate)
                    .HasColumnName("CAD_ALERTDATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CadAuditId).HasColumnName("CAD_AUDIT_ID");

                entity.Property(e => e.CadDescription)
                    .HasColumnName("CAD_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CadType).HasColumnName("CAD_TYPE");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.CadAudit)
                    .WithMany(p => p.CaseAuditDetails)
                    .HasForeignKey(d => d.CadAuditId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CAD_AUDIT_ID_FK");
            });

            modelBuilder.Entity<CaseMergeLog>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CASE_MERGE_LOG");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("CASE_MERGE_LOG_I_CREATED_BY");

                entity.HasIndex(e => e.Masterid)
                    .HasName("CASE_MERGE_LOG_I_MASTERID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("CASE_MERGE_LOG_I_OBJ_GUID");

                entity.HasIndex(e => e.Subid)
                    .HasName("CASE_MERGE_LOG_I_SUBID");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Masterid).HasColumnName("MASTERID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Subid).HasColumnName("SUBID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CaseMergeLog)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CASE_MERGE_LOG_FK_CREATED_BY");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.CaseMergeLogMaster)
                    .HasForeignKey(d => d.Masterid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CASE_MERGE_LOG_FK_MASTERID");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.CaseMergeLogSub)
                    .HasForeignKey(d => d.Subid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CASE_MERGE_LOG_FK_SUBID");
            });

            modelBuilder.Entity<CaseTemplates>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CASE_TEMPLATES");

                entity.HasIndex(e => e.AdminPrivacy)
                    .HasName("FK_CT_ADMIN_PRIVACY");

                entity.HasIndex(e => e.Careplan)
                    .HasName("FK_CASE_TEMPL_CAREPLAN");

                entity.HasIndex(e => e.CasePrivacy)
                    .HasName("FK_CT_CASE_PRIVACY");

                entity.HasIndex(e => e.CaseSetting)
                    .HasName("FK_CT_CASE_SETTING");

                entity.HasIndex(e => e.ClinicalPrivacy)
                    .HasName("FK_CT_CLINICAL_PRIVACY");

                entity.HasIndex(e => e.EventTemplate)
                    .HasName("FK_CASE_TEMPL_EVENT_TEMPL");

                entity.HasIndex(e => e.Macro)
                    .HasName("FK_CASE_TEMPL_MACRO");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CASE_TEMPLATES");

                entity.HasIndex(e => new { e.Code, e.Deletedid, e.PartitionId })
                    .HasName("I_CODE_DELID_PARID")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdminPrivacy).HasColumnName("ADMIN_PRIVACY");

                entity.Property(e => e.AdminPrivacyEnabled).HasColumnName("ADMIN_PRIVACY_ENABLED");

                entity.Property(e => e.Careplan).HasColumnName("CAREPLAN");

                entity.Property(e => e.CareplanEnabled).HasColumnName("CAREPLAN_ENABLED");

                entity.Property(e => e.CasePrivacy).HasColumnName("CASE_PRIVACY");

                entity.Property(e => e.CasePrivacyEnabled).HasColumnName("CASE_PRIVACY_ENABLED");

                entity.Property(e => e.CaseSetting).HasColumnName("CASE_SETTING");

                entity.Property(e => e.CaseSettingEnabled).HasColumnName("CASE_SETTING_ENABLED");

                entity.Property(e => e.ClinicalPrivacy).HasColumnName("CLINICAL_PRIVACY");

                entity.Property(e => e.ClinicalPrivacyEnabled).HasColumnName("CLINICAL_PRIVACY_ENABLED");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Colour).HasColumnName("COLOUR");

                entity.Property(e => e.ColourEnabled).HasColumnName("COLOUR_ENABLED");

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventTemplate).HasColumnName("EVENT_TEMPLATE");

                entity.Property(e => e.EventTemplateEnabled).HasColumnName("EVENT_TEMPLATE_ENABLED");

                entity.Property(e => e.Macro).HasColumnName("MACRO");

                entity.Property(e => e.MacroEnabled).HasColumnName("MACRO_ENABLED");

                entity.Property(e => e.Mix).HasColumnName("MIX");

                entity.Property(e => e.MixComment)
                    .HasColumnName("MIX_COMMENT")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MixCommentEnabled).HasColumnName("MIX_COMMENT_ENABLED");

                entity.Property(e => e.MixEnabled).HasColumnName("MIX_ENABLED");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TitleEnabled).HasColumnName("TITLE_ENABLED");

                entity.HasOne(d => d.AdminPrivacyNavigation)
                    .WithMany(p => p.CaseTemplatesAdminPrivacyNavigation)
                    .HasForeignKey(d => d.AdminPrivacy)
                    .HasConstraintName("FK_CT_ADMIN_PRIVACY");

                entity.HasOne(d => d.CasePrivacyNavigation)
                    .WithMany(p => p.CaseTemplatesCasePrivacyNavigation)
                    .HasForeignKey(d => d.CasePrivacy)
                    .HasConstraintName("FK_CT_CASE_PRIVACY");

                entity.HasOne(d => d.CaseSettingNavigation)
                    .WithMany(p => p.CaseTemplates)
                    .HasForeignKey(d => d.CaseSetting)
                    .HasConstraintName("FK_CT_CASE_SETTING");

                entity.HasOne(d => d.ClinicalPrivacyNavigation)
                    .WithMany(p => p.CaseTemplatesClinicalPrivacyNavigation)
                    .HasForeignKey(d => d.ClinicalPrivacy)
                    .HasConstraintName("FK_CT_CLINICAL_PRIVACY");

                entity.HasOne(d => d.EventTemplateNavigation)
                    .WithMany(p => p.CaseTemplates)
                    .HasForeignKey(d => d.EventTemplate)
                    .HasConstraintName("FK_CASE_TEMPL_EVENT_TEMPL");

                entity.HasOne(d => d.MacroNavigation)
                    .WithMany(p => p.CaseTemplates)
                    .HasForeignKey(d => d.Macro)
                    .HasConstraintName("FK_CASE_TEMPL_MACRO");
            });

            modelBuilder.Entity<CdoOrganization>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CDO_ORGANIZATION");

                entity.HasIndex(e => e.Code)
                    .HasName("CDO_ORG_I_CODE");

                entity.HasIndex(e => e.Createdby)
                    .HasName("CDO_ORGANIZATION_FK_CREATEDBY");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("CDO_ORGANIZATION_FK_DELETEDBY");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CDO_ORGANIZATION");

                entity.HasIndex(e => e.Organization)
                    .HasName("CDO_ORGANIZATION_FK_ORGAN");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('?')");

                entity.Property(e => e.Contacts)
                    .HasColumnName("CONTACTS")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Organization).HasColumnName("ORGANIZATION");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.CdoOrganizationCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("CDO_ORGANIZATION_FK_CREATEDBY");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.CdoOrganizationDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("CDO_ORGANIZATION_FK_DELETEDBY");

                entity.HasOne(d => d.OrganizationNavigation)
                    .WithMany(p => p.InverseOrganizationNavigation)
                    .HasForeignKey(d => d.Organization)
                    .HasConstraintName("CDO_ORGANIZATION_FK_ORGAN");
            });

            modelBuilder.Entity<CdoPerson>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CDO_PERSON");

                entity.HasIndex(e => e.Cid)
                    .HasName("I_CDO_PERSON_CID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CDO_PERSON");

                entity.HasIndex(e => e.RealId)
                    .HasName("CDO_PERSON_REAL_ID_I");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessionPrefs)
                    .HasColumnName("ACCESSION_PREFS")
                    .HasColumnType("image");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RealId).HasColumnName("REAL_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdoPersonImage>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CDO_PERSON_IMAGE");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CDO_PERSON_IMAGE");

                entity.HasIndex(e => e.PersonId)
                    .HasName("CDO_PERSON_IMAGE_FK_PERSON_I");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PimgData)
                    .HasColumnName("PIMG_DATA")
                    .HasColumnType("image");

                entity.Property(e => e.PimgMime)
                    .HasColumnName("PIMG_MIME")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PimgType).HasColumnName("PIMG_TYPE");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CdoPersonImage)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CDO_PERSON_IMAGE_FK_PERSON_I");
            });

            modelBuilder.Entity<CdoTermset>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CDO_TERMSET");

                entity.HasIndex(e => e.Copyrights)
                    .HasName("FK_TERMSET_COPYRIGHTS");

                entity.HasIndex(e => e.Createdby)
                    .HasName("CDO_TERMSET_FK_CREATEDBY");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CDO_TERMSET");

                entity.HasIndex(e => e.Organization)
                    .HasName("CDO_TERMSET_FK_ORGAN");

                entity.HasIndex(e => new { e.Code, e.PartitionId })
                    .HasName("CDO_TERMSET_I_CODE")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT_")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Copyrights).HasColumnName("COPYRIGHTS");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hierarchical).HasColumnName("HIERARCHICAL");

                entity.Property(e => e.Maxcode)
                    .IsRequired()
                    .HasColumnName("MAXCODE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Organization).HasColumnName("ORGANIZATION");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.CopyrightsNavigation)
                    .WithMany(p => p.CdoTermset)
                    .HasForeignKey(d => d.Copyrights)
                    .HasConstraintName("FK_TERMSET_COPYRIGHTS");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.CdoTermset)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("CDO_TERMSET_FK_CREATEDBY");

                entity.HasOne(d => d.OrganizationNavigation)
                    .WithMany(p => p.CdoTermset)
                    .HasForeignKey(d => d.Organization)
                    .HasConstraintName("CDO_TERMSET_FK_ORGAN");
            });

            modelBuilder.Entity<CdoTermsetConcept>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CDO_TERMSET_CONCEPT");

                entity.HasIndex(e => e.Createdby)
                    .HasName("CDO_TC_FK_CREATED_BY");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CDO_TERMSET_CONCEPT");

                entity.HasIndex(e => e.Organization)
                    .HasName("TERMSET_CONCEPT_FK_ORGAN");

                entity.HasIndex(e => e.Prefterm)
                    .HasName("TERMSET_CONCEPT_FK_TERM");

                entity.HasIndex(e => e.Termset)
                    .HasName("CDO_CONCEPT_FK_TERMSET");

                entity.HasIndex(e => new { e.Code, e.Termset, e.PartitionId })
                    .HasName("CDO_CONCEPT_I_CODETERMSET")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid)
                    .HasColumnName("CID")
                    .HasDefaultValueSql("((100010))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Organization).HasColumnName("ORGANIZATION");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.Prefterm).HasColumnName("PREFTERM");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Termset)
                    .HasColumnName("TERMSET")
                    .HasDefaultValueSql("((2))");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.CdoTermsetConcept)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("CDO_TC_FK_CREATED_BY");

                entity.HasOne(d => d.OrganizationNavigation)
                    .WithMany(p => p.CdoTermsetConcept)
                    .HasForeignKey(d => d.Organization)
                    .HasConstraintName("TERMSET_CONCEPT_FK_ORGAN");

                entity.HasOne(d => d.PreftermNavigation)
                    .WithMany(p => p.CdoTermsetConcept)
                    .HasForeignKey(d => d.Prefterm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TERMSET_CONCEPT_FK_TERM");

                entity.HasOne(d => d.TermsetNavigation)
                    .WithMany(p => p.CdoTermsetConcept)
                    .HasForeignKey(d => d.Termset)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CDO_CONCEPT_FK_TERMSET");
            });

            modelBuilder.Entity<CdoTermsetTerm>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CDO_TERMSET_TERM");

                entity.HasIndex(e => e.Code)
                    .HasName("TERMCODE_IND");

                entity.HasIndex(e => e.Createdby)
                    .HasName("CDO_TERMSET_TERM_FK_CREATEDB");

                entity.HasIndex(e => e.Description)
                    .HasName("CDO_TERMSET_TERMINDEX3");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CDO_TERMSET_TERM");

                entity.HasIndex(e => e.Organization)
                    .HasName("TERMSET_TERM_FK_ORGAN");

                entity.HasIndex(e => e.Termset)
                    .HasName("CDO_TERM_FK_TERMSET");

                entity.HasIndex(e => e.Upperdescription)
                    .HasName("INDEX_CDO_TERMUPPERDESCRIPTION");

                entity.HasIndex(e => new { e.Code, e.Termset, e.PartitionId })
                    .HasName("CDO_TERM_I_CODETERMSET")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Organization).HasColumnName("ORGANIZATION");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.Plural)
                    .HasColumnName("PLURAL")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Termset)
                    .HasColumnName("TERMSET")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Upperdescription)
                    .HasColumnName("UPPERDESCRIPTION")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.CdoTermsetTerm)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("CDO_TERMSET_TERM_FK_CREATEDB");

                entity.HasOne(d => d.OrganizationNavigation)
                    .WithMany(p => p.CdoTermsetTerm)
                    .HasForeignKey(d => d.Organization)
                    .HasConstraintName("TERMSET_TERM_FK_ORGAN");

                entity.HasOne(d => d.TermsetNavigation)
                    .WithMany(p => p.CdoTermsetTerm)
                    .HasForeignKey(d => d.Termset)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CDO_TERM_FK_TERMSET");
            });

            modelBuilder.Entity<CdoTrans>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CDO_TRANS");

                entity.HasIndex(e => e.AqHcpAssigned)
                    .HasName("CDO_TRANS_FK_AQ_HCP_ASSIGNED");

                entity.HasIndex(e => e.AqHcpAuthorized)
                    .HasName("CDO_TRANS_FK_AQ_HCP_AUTHORIZ");

                entity.HasIndex(e => e.AqSource)
                    .HasName("CDO_TRANS_FK_AQ_SOURCE");

                entity.HasIndex(e => e.AttendanceId)
                    .HasName("CDO_TRANS_FK_APPOINTMENT");

                entity.HasIndex(e => e.BcaseOid)
                    .HasName("CDO_TRANS_FK_BCASE_OID");

                entity.HasIndex(e => e.CaseServiceId)
                    .HasName("FK_CDO_TRANS_CS_ID");

                entity.HasIndex(e => e.Code)
                    .HasName("CDO_TRANS_I_CODE");

                entity.HasIndex(e => e.ContactTypeId)
                    .HasName("CDO_TRANS_FK_CONTACT_TYPE");

                entity.HasIndex(e => e.Createdby)
                    .HasName("CDO_TRANS_FK_CREATEDBY");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("CDO_TRANS_FK_DELETEDBY");

                entity.HasIndex(e => e.DocCategoryId)
                    .HasName("CDO_TRANS_DOC_CATEGORY_FK");

                entity.HasIndex(e => e.Dtdisplay)
                    .HasName("I_CDO_TRANS_DTDISPLAY");

                entity.HasIndex(e => e.Ehcr)
                    .HasName("CDO_TRANS_FK_EHCR");

                entity.HasIndex(e => e.EncounterType)
                    .HasName("FK_CDOTRANS_ENCOUNTER_TYPE");

                entity.HasIndex(e => e.FilingCategory)
                    .HasName("I_CDO_TRANS_FILING_CATEGORY");

                entity.HasIndex(e => e.Firstcreated)
                    .HasName("I_CDOTRANS_FIRSTCREATED");

                entity.HasIndex(e => e.Firstcreatedby)
                    .HasName("FK_CDO_TRANS_FIRSTCREATEDBY");

                entity.HasIndex(e => e.GroupSessionId)
                    .HasName("FK_GROUP_SESSION_ID");

                entity.HasIndex(e => e.IsAbnormal)
                    .HasName("I_CDO_TRANS_IS_ABNORMAL");

                entity.HasIndex(e => e.LocationId)
                    .HasName("FK_CDOTRANS_LOCATION");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CDO_TRANS");

                entity.HasIndex(e => e.Organization)
                    .HasName("CDO_TRANS_FK_ORGANIZATION");

                entity.HasIndex(e => e.PosId)
                    .HasName("CDO_TRANS_FK_POS_ID");

                entity.HasIndex(e => e.PrivacyPppuId)
                    .HasName("CDO_TRANS_FK_PPPU");

                entity.HasIndex(e => e.Ref2Oid)
                    .HasName("CDO_TRANS_FK_REF2_OID");

                entity.HasIndex(e => e.RoleOid)
                    .HasName("CDO_TRANS_FK_ROLE_OID");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("FK_CDOTRANS_SERVICE");

                entity.HasIndex(e => new { e.Code, e.Version })
                    .HasName("I_CDOTRANS_CODEVERSION")
                    .IsUnique();

                entity.HasIndex(e => new { e.Dt1, e.Cid })
                    .HasName("CDO_TRANS_I_DT1_CID");

                entity.HasIndex(e => new { e.Ref1, e.PartitionId })
                    .HasName("CDO_TRANS_I_REF1");

                entity.HasIndex(e => new { e.AqHcpAssigned, e.AqHcpAuthorized, e.Deleted, e.Ehcr })
                    .HasName("I_UNSIGNED");

                entity.HasIndex(e => new { e.Ehcr, e.Deleted, e.Dt1, e.Cid, e.PartitionId })
                    .HasName("CDO_TRANS_I_EHCR_DEL_DT1_CID");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accessrights).HasColumnName("ACCESSRIGHTS");

                entity.Property(e => e.Amendrights).HasColumnName("AMENDRIGHTS");

                entity.Property(e => e.AqDtAuthorized)
                    .HasColumnName("AQ_DT_AUTHORIZED")
                    .HasColumnType("datetime");

                entity.Property(e => e.AqHcpAssigned).HasColumnName("AQ_HCP_ASSIGNED");

                entity.Property(e => e.AqHcpAssignedCid).HasColumnName("AQ_HCP_ASSIGNED_CID");

                entity.Property(e => e.AqHcpAuthorized).HasColumnName("AQ_HCP_AUTHORIZED");

                entity.Property(e => e.AqHcpAuthorizedCid).HasColumnName("AQ_HCP_AUTHORIZED_CID");

                entity.Property(e => e.AqSource).HasColumnName("AQ_SOURCE");

                entity.Property(e => e.AqSourcetransref)
                    .HasColumnName("AQ_SOURCETRANSREF")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AqWasgehr).HasColumnName("AQ_WASGEHR");

                entity.Property(e => e.AttendanceId).HasColumnName("ATTENDANCE_ID");

                entity.Property(e => e.BcaseOid).HasColumnName("BCASE_OID");

                entity.Property(e => e.BlockFromPtnt).HasColumnName("BLOCK_FROM_PTNT");

                entity.Property(e => e.CaseServiceId).HasColumnName("CASE_SERVICE_ID");

                entity.Property(e => e.Childprotect).HasColumnName("CHILDPROTECT");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTypeId).HasColumnName("CONTACT_TYPE_ID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Direction).HasColumnName("DIRECTION");

                entity.Property(e => e.DocCategoryId).HasColumnName("DOC_CATEGORY_ID");

                entity.Property(e => e.Dt1)
                    .HasColumnName("DT1")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dt2)
                    .HasColumnName("DT2")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dtdisplay)
                    .HasColumnName("DTDISPLAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ehcr).HasColumnName("EHCR");

                entity.Property(e => e.EncounterType).HasColumnName("ENCOUNTER_TYPE");

                entity.Property(e => e.FilingCategory).HasColumnName("FILING_CATEGORY");

                entity.Property(e => e.Firstcreated)
                    .HasColumnName("FIRSTCREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstcreatedby).HasColumnName("FIRSTCREATEDBY");

                entity.Property(e => e.GroupSessionId).HasColumnName("GROUP_SESSION_ID");

                entity.Property(e => e.HcpA).HasColumnName("HCP_A");

                entity.Property(e => e.HcpACid).HasColumnName("HCP_A_CID");

                entity.Property(e => e.HcpL).HasColumnName("HCP_L");

                entity.Property(e => e.HcpLCid).HasColumnName("HCP_L_CID");

                entity.Property(e => e.InclInCumulative)
                    .HasColumnName("INCL_IN_CUMULATIVE")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.IsAbnormal).HasColumnName("IS_ABNORMAL");

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Organization).HasColumnName("ORGANIZATION");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PatientConsentBlock).HasColumnName("PATIENT_CONSENT_BLOCK");

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.PrivacyOrg).HasColumnName("PRIVACY_ORG");

                entity.Property(e => e.PrivacyPppuId).HasColumnName("PRIVACY_PPPU_ID");

                entity.Property(e => e.Ref1).HasColumnName("REF1");

                entity.Property(e => e.Ref1Cid).HasColumnName("REF1_CID");

                entity.Property(e => e.Ref2Cid).HasColumnName("REF2_CID");

                entity.Property(e => e.Ref2Oid).HasColumnName("REF2_OID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RoleOid).HasColumnName("ROLE_OID");

                entity.Property(e => e.ServiceId).HasColumnName("SERVICE_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Texts)
                    .HasColumnName("TEXTS")
                    .HasColumnType("image");

                entity.Property(e => e.Transdatatype).HasColumnName("TRANSDATATYPE");

                entity.Property(e => e.Transtype).HasColumnName("TRANSTYPE");

                entity.Property(e => e.Unmatchedcopyto).HasColumnName("UNMATCHEDCOPYTO");

                entity.Property(e => e.Unmatchedhrm).HasColumnName("UNMATCHEDHRM");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.AqHcpAssignedNavigation)
                    .WithMany(p => p.CdoTransAqHcpAssignedNavigation)
                    .HasForeignKey(d => d.AqHcpAssigned)
                    .HasConstraintName("CDO_TRANS_FK_AQ_HCP_ASSIGNED");

                entity.HasOne(d => d.AqHcpAuthorizedNavigation)
                    .WithMany(p => p.CdoTransAqHcpAuthorizedNavigation)
                    .HasForeignKey(d => d.AqHcpAuthorized)
                    .HasConstraintName("CDO_TRANS_FK_AQ_HCP_AUTHORIZ");

                entity.HasOne(d => d.AqSourceNavigation)
                    .WithMany(p => p.CdoTransAqSourceNavigation)
                    .HasForeignKey(d => d.AqSource)
                    .HasConstraintName("CDO_TRANS_FK_AQ_SOURCE");

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.CdoTrans)
                    .HasForeignKey(d => d.AttendanceId)
                    .HasConstraintName("CDO_TRANS_FK_APPOINTMENT");

                entity.HasOne(d => d.BcaseO)
                    .WithMany(p => p.CdoTrans)
                    .HasForeignKey(d => d.BcaseOid)
                    .HasConstraintName("CDO_TRANS_FK_BCASE_OID");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.CdoTransContactType)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("CDO_TRANS_FK_CONTACT_TYPE");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.CdoTransCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("CDO_TRANS_FK_CREATEDBY");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.CdoTransDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("CDO_TRANS_FK_DELETEDBY");

                entity.HasOne(d => d.DocCategory)
                    .WithMany(p => p.CdoTransDocCategory)
                    .HasForeignKey(d => d.DocCategoryId)
                    .HasConstraintName("CDO_TRANS_DOC_CATEGORY_FK");

                entity.HasOne(d => d.EncounterTypeNavigation)
                    .WithMany(p => p.CdoTransEncounterTypeNavigation)
                    .HasForeignKey(d => d.EncounterType)
                    .HasConstraintName("FK_CDOTRANS_ENCOUNTER_TYPE");

                entity.HasOne(d => d.FirstcreatedbyNavigation)
                    .WithMany(p => p.CdoTransFirstcreatedbyNavigation)
                    .HasForeignKey(d => d.Firstcreatedby)
                    .HasConstraintName("FK_CDO_TRANS_FIRSTCREATEDBY");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.CdoTransLocation)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_CDOTRANS_LOCATION");

                entity.HasOne(d => d.OrganizationNavigation)
                    .WithMany(p => p.CdoTransOrganizationNavigation)
                    .HasForeignKey(d => d.Organization)
                    .HasConstraintName("CDO_TRANS_FK_ORGANIZATION");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.CdoTransPos)
                    .HasForeignKey(d => d.PosId)
                    .HasConstraintName("CDO_TRANS_FK_POS_ID");

                entity.HasOne(d => d.PrivacyPppu)
                    .WithMany(p => p.CdoTransPrivacyPppu)
                    .HasForeignKey(d => d.PrivacyPppuId)
                    .HasConstraintName("CDO_TRANS_FK_PPPU");

                entity.HasOne(d => d.Ref2O)
                    .WithMany(p => p.CdoTransRef2O)
                    .HasForeignKey(d => d.Ref2Oid)
                    .HasConstraintName("CDO_TRANS_FK_REF2_OID");

                entity.HasOne(d => d.RoleO)
                    .WithMany(p => p.CdoTrans)
                    .HasForeignKey(d => d.RoleOid)
                    .HasConstraintName("CDO_TRANS_FK_ROLE_OID");
            });

            modelBuilder.Entity<CdoTransdata>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CDO_TRANSDATA");

                entity.HasIndex(e => e.Code)
                    .HasName("CDO_TRANSDATA_I_CODE");

                entity.HasIndex(e => e.Collection)
                    .HasName("CDO_TRANSDATA_FK_COLLECTION");

                entity.HasIndex(e => e.Concept)
                    .HasName("CDO_TRANSDATA_FK_CONCEPT");

                entity.HasIndex(e => e.Conceptvalue)
                    .HasName("CDO_TRANSDATA_FK_CONCEPTVALU");

                entity.HasIndex(e => e.DataE)
                    .HasName("CDO_TRANSDATA_FK_DATA_E");

                entity.HasIndex(e => e.Dt1)
                    .HasName("I_CDOTRANSDATA_DT1");

                entity.HasIndex(e => e.Infoprovider)
                    .HasName("CDO_TRANSDATA_FK_INFOPROVIDE");

                entity.HasIndex(e => e.LinkedobjectOid)
                    .HasName("CDO_TRANSDATA_I_LINKOBJ_OID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CDO_TRANSDATA");

                entity.HasIndex(e => e.Obsref)
                    .HasName("CDO_TRANSDATA_FK_OBSREF");

                entity.HasIndex(e => e.PosId)
                    .HasName("CDO_TRANSDATA_FK_POS_ID");

                entity.HasIndex(e => e.Qunit)
                    .HasName("CDO_TRANSDATA_FK_QUNIT");

                entity.HasIndex(e => e.Qunit2)
                    .HasName("CDO_TRANSDATA_FK_QUNIT2");

                entity.HasIndex(e => e.Qvalue)
                    .HasName("I_CDOTRANSDATA_QVALUE");

                entity.HasIndex(e => e.Term)
                    .HasName("CDO_TRANSDATA_FK_TERM");

                entity.HasIndex(e => e.Trans)
                    .HasName("CDO_TRANSDATA_FK_TRANS");

                entity.HasIndex(e => new { e.Trans, e.Concept })
                    .HasName("CDO_TRANSDATA_I_TRANS_CONCEPT");

                entity.HasIndex(e => new { e.Infoprovider, e.Cid, e.Conceptvalue })
                    .HasName("CDO_TRANSDATA_I_UNRESOLVED");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbnormalCode)
                    .HasColumnName("ABNORMAL_CODE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BlockFromPtnt).HasColumnName("BLOCK_FROM_PTNT");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Code).HasColumnName("CODE");

                entity.Property(e => e.Collection).HasColumnName("COLLECTION");

                entity.Property(e => e.Concept).HasColumnName("CONCEPT");

                entity.Property(e => e.Conceptvalue).HasColumnName("CONCEPTVALUE");

                entity.Property(e => e.DataE).HasColumnName("DATA_E");

                entity.Property(e => e.Dt1)
                    .HasColumnName("DT1")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dtobserved)
                    .HasColumnName("DTOBSERVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Emphasis)
                    .HasColumnName("EMPHASIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.InclInCumulative)
                    .HasColumnName("INCL_IN_CUMULATIVE")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Infoprovider).HasColumnName("INFOPROVIDER");

                entity.Property(e => e.LinkedobjectCid).HasColumnName("LINKEDOBJECT_CID");

                entity.Property(e => e.LinkedobjectOid).HasColumnName("LINKEDOBJECT_OID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Obsref).HasColumnName("OBSREF");

                entity.Property(e => e.Ord).HasColumnName("ORD");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.Qmax).HasColumnName("QMAX");

                entity.Property(e => e.Qmin).HasColumnName("QMIN");

                entity.Property(e => e.Qunit).HasColumnName("QUNIT");

                entity.Property(e => e.Qunit2).HasColumnName("QUNIT2");

                entity.Property(e => e.Qvalue).HasColumnName("QVALUE");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Term).HasColumnName("TERM");

                entity.Property(e => e.Texts)
                    .HasColumnName("TEXTS")
                    .HasColumnType("image");

                entity.Property(e => e.Trans).HasColumnName("TRANS");

                entity.Property(e => e.Versionmax).HasColumnName("VERSIONMAX");

                entity.Property(e => e.Versionmin).HasColumnName("VERSIONMIN");

                entity.HasOne(d => d.CollectionNavigation)
                    .WithMany(p => p.InverseCollectionNavigation)
                    .HasForeignKey(d => d.Collection)
                    .HasConstraintName("CDO_TRANSDATA_FK_COLLECTION");

                entity.HasOne(d => d.ConceptNavigation)
                    .WithMany(p => p.CdoTransdataConceptNavigation)
                    .HasForeignKey(d => d.Concept)
                    .HasConstraintName("CDO_TRANSDATA_FK_CONCEPT");

                entity.HasOne(d => d.ConceptvalueNavigation)
                    .WithMany(p => p.CdoTransdataConceptvalueNavigation)
                    .HasForeignKey(d => d.Conceptvalue)
                    .HasConstraintName("CDO_TRANSDATA_FK_CONCEPTVALU");

                entity.HasOne(d => d.InfoproviderNavigation)
                    .WithMany(p => p.CdoTransdata)
                    .HasForeignKey(d => d.Infoprovider)
                    .HasConstraintName("CDO_TRANSDATA_FK_INFOPROVIDE");

                entity.HasOne(d => d.ObsrefNavigation)
                    .WithMany(p => p.InverseObsrefNavigation)
                    .HasForeignKey(d => d.Obsref)
                    .HasConstraintName("CDO_TRANSDATA_FK_OBSREF");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.CdoTransdata)
                    .HasForeignKey(d => d.PosId)
                    .HasConstraintName("CDO_TRANSDATA_FK_POS_ID");

                entity.HasOne(d => d.TermNavigation)
                    .WithMany(p => p.CdoTransdata)
                    .HasForeignKey(d => d.Term)
                    .HasConstraintName("CDO_TRANSDATA_FK_TERM");

                entity.HasOne(d => d.TransNavigation)
                    .WithMany(p => p.CdoTransdata)
                    .HasForeignKey(d => d.Trans)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CDO_TRANSDATA_FK_TRANS");
            });

            modelBuilder.Entity<ConcurrentUsersLog>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CONCURRENT_USERS_LOG");

                entity.HasIndex(e => e.CulNextDate)
                    .HasName("CUL_I_NEXT_DATE");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CulDate)
                    .HasColumnName("CUL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CulNextDate)
                    .HasColumnName("CUL_NEXT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CulSessions).HasColumnName("CUL_SESSIONS");

                entity.Property(e => e.CulUsers).HasColumnName("CUL_USERS");
            });

            modelBuilder.Entity<ContactActionLink>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CONTACT_ACTION_LINK");

                entity.HasIndex(e => e.CoalCaseid)
                    .HasName("FK_COAL_CASEID");

                entity.HasIndex(e => e.CoalCntcOid)
                    .HasName("CAL_FK_CNTC_OID");

                entity.HasIndex(e => e.CoalInvoiceOid)
                    .HasName("COAL_FK_INVOICE_OID");

                entity.HasIndex(e => e.CoalLinkCid)
                    .HasName("COAL_I_LINKCID");

                entity.HasIndex(e => e.CoalLinkOid)
                    .HasName("CONTACT_ACTION_LINK_I_LOID");

                entity.HasIndex(e => e.CoalParentServiceOid)
                    .HasName("COAL_FK_PARENT_SERVICE_OID");

                entity.HasIndex(e => e.CoalPatient)
                    .HasName("COAL_PATIENT_FK");

                entity.HasIndex(e => e.CoalPos)
                    .HasName("COAL_POS_FK");

                entity.HasIndex(e => e.CoalProvider)
                    .HasName("COAL_PROVIDER_FK");

                entity.HasIndex(e => e.CoalQuoteId)
                    .HasName("FK_CAL_QUOTEID");

                entity.HasIndex(e => e.CoalRate)
                    .HasName("CONTACT_ACTION_LINK_FK_RATE");

                entity.HasIndex(e => e.CoalServiceOid)
                    .HasName("COAL_FK_SERVICE_OID");

                entity.HasIndex(e => e.Code)
                    .HasName("CONTACTACTIONLINK_I_CODE");

                entity.HasIndex(e => e.Createdby)
                    .HasName("ACTION_LINK_FK_CREATEDBY");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("ACTION_LINK_FK_DELETEDBY");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_CONTACT_ACTION_LINK");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoalActioned)
                    .HasColumnName("COAL_ACTIONED")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoalBill).HasColumnName("COAL_BILL");

                entity.Property(e => e.CoalCaseid).HasColumnName("COAL_CASEID");

                entity.Property(e => e.CoalCntcOid).HasColumnName("COAL_CNTC_OID");

                entity.Property(e => e.CoalConcluded)
                    .HasColumnName("COAL_CONCLUDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoalDescription)
                    .HasColumnName("COAL_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CoalHowConcluded).HasColumnName("COAL_HOW_CONCLUDED");

                entity.Property(e => e.CoalInvoiceNote)
                    .HasColumnName("COAL_INVOICE_NOTE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CoalInvoiceOid).HasColumnName("COAL_INVOICE_OID");

                entity.Property(e => e.CoalIsMasterService).HasColumnName("COAL_IS_MASTER_SERVICE");

                entity.Property(e => e.CoalLinkCid).HasColumnName("COAL_LINK_CID");

                entity.Property(e => e.CoalLinkOid).HasColumnName("COAL_LINK_OID");

                entity.Property(e => e.CoalParentServiceOid).HasColumnName("COAL_PARENT_SERVICE_OID");

                entity.Property(e => e.CoalPatient).HasColumnName("COAL_PATIENT");

                entity.Property(e => e.CoalPending)
                    .HasColumnName("COAL_PENDING")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoalPos).HasColumnName("COAL_POS");

                entity.Property(e => e.CoalProvider).HasColumnName("COAL_PROVIDER");

                entity.Property(e => e.CoalQuantity).HasColumnName("COAL_QUANTITY");

                entity.Property(e => e.CoalQuoteId).HasColumnName("COAL_QUOTE_ID");

                entity.Property(e => e.CoalRate)
                    .HasColumnName("COAL_RATE")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CoalReceived)
                    .HasColumnName("COAL_RECEIVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoalServiceOid).HasColumnName("COAL_SERVICE_OID");

                entity.Property(e => e.CoalSrvforceontonextinv).HasColumnName("COAL_SRVFORCEONTONEXTINV");

                entity.Property(e => e.CoalStatus).HasColumnName("COAL_STATUS");

                entity.Property(e => e.CoalVerb).HasColumnName("COAL_VERB");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CoalCase)
                    .WithMany(p => p.ContactActionLink)
                    .HasForeignKey(d => d.CoalCaseid)
                    .HasConstraintName("FK_COAL_CASEID");

                entity.HasOne(d => d.CoalCntcO)
                    .WithMany(p => p.ContactActionLink)
                    .HasForeignKey(d => d.CoalCntcOid)
                    .HasConstraintName("CAL_FK_CNTC_OID");

                entity.HasOne(d => d.CoalPatientNavigation)
                    .WithMany(p => p.ContactActionLink)
                    .HasForeignKey(d => d.CoalPatient)
                    .HasConstraintName("COAL_PATIENT_FK");

                entity.HasOne(d => d.CoalPosNavigation)
                    .WithMany(p => p.ContactActionLinkCoalPosNavigation)
                    .HasForeignKey(d => d.CoalPos)
                    .HasConstraintName("COAL_POS_FK");

                entity.HasOne(d => d.CoalProviderNavigation)
                    .WithMany(p => p.ContactActionLinkCoalProviderNavigation)
                    .HasForeignKey(d => d.CoalProvider)
                    .HasConstraintName("COAL_PROVIDER_FK");

                entity.HasOne(d => d.CoalRateNavigation)
                    .WithMany(p => p.ContactActionLink)
                    .HasForeignKey(d => d.CoalRate)
                    .HasConstraintName("CONTACT_ACTION_LINK_FK_RATE");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.ContactActionLinkCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("ACTION_LINK_FK_CREATEDBY");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.ContactActionLinkDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("ACTION_LINK_FK_DELETEDBY");
            });

            modelBuilder.Entity<DatabaseInfo>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("DATABASE_INFO");

                entity.HasIndex(e => e.DiName)
                    .HasName("DATABASEINFO_UK_NAME")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiName)
                    .IsRequired()
                    .HasColumnName("DI_NAME")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.DiValue)
                    .HasColumnName("DI_VALUE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataImportLog>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("DATA_IMPORT_LOG");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_DATA_IMPORT_LOG");

                entity.HasIndex(e => e.ScheduledTaskId)
                    .HasName("FK_DILOG_SCHEDULED_TASK");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinishedDt)
                    .HasColumnName("FINISHED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledTaskId).HasColumnName("SCHEDULED_TASK_ID");

                entity.Property(e => e.StartedDt)
                    .HasColumnName("STARTED_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<DataOutputLog>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("DATA_OUTPUT_LOG");

                entity.HasIndex(e => e.DolUserId)
                    .HasName("FK_DATA_OUTPUT_LOG_PPPU");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("DATA_OUTPUT_LOG_I_OBJ_GUID");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DolActionType).HasColumnName("DOL_ACTION_TYPE");

                entity.Property(e => e.DolDescription)
                    .HasColumnName("DOL_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DolStartDateTime)
                    .HasColumnName("DOL_START_DATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.DolUserId).HasColumnName("DOL_USER_ID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.DolUser)
                    .WithMany(p => p.DataOutputLog)
                    .HasForeignKey(d => d.DolUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DATA_OUTPUT_LOG_PPPU");
            });

            modelBuilder.Entity<Diseasecode>(entity =>
            {
                entity.HasKey(e => e.DscdId);

                entity.ToTable("DISEASECODE");

                entity.HasIndex(e => e.Concept)
                    .HasName("DISEASECODE_FK_CONCEPT");

                entity.HasIndex(e => e.ConceptoidMon1)
                    .HasName("DISEASECODE_FK_CONCEPT_MON1");

                entity.HasIndex(e => e.ConceptoidMon2)
                    .HasName("DISEASECODE_FK_CONCEPT_MON2");

                entity.HasIndex(e => e.DscdCode)
                    .HasName("DSCD_CODE_IND");

                entity.HasIndex(e => e.DscdGroup)
                    .HasName("DISEASECODE_FK_GROUP");

                entity.HasIndex(e => e.DscdKeywords)
                    .HasName("INDEX_DISEASECODE_KEYWORDS");

                entity.HasIndex(e => e.DscdTravelDisease)
                    .HasName("DSCD_TRAVEL_DISEASE_FK");

                entity.HasIndex(e => e.Modifiedby)
                    .HasName("FK_DISEASE_MODIFIEDBY_PPPU");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_DISEASECODE");

                entity.HasIndex(e => e.Term)
                    .HasName("DISEASECODE_FK_TERM");

                entity.HasIndex(e => e.TermoidMon1)
                    .HasName("DISEASECODE_FK_TERM_MON1");

                entity.HasIndex(e => e.TermoidMon2)
                    .HasName("DISEASECODE_FK_TERM_MON2");

                entity.HasIndex(e => new { e.DscdSysid, e.DscdDeletedid, e.PartitionId })
                    .HasName("DISEASECODE_SYSID")
                    .IsUnique();

                entity.HasIndex(e => new { e.DscdCode, e.DscdType, e.DscdDeletedid, e.PartitionId })
                    .HasName("DSCDCODEDELETEDID")
                    .IsUnique();

                entity.Property(e => e.DscdId)
                    .HasColumnName("DSCD_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Changed)
                    .HasColumnName("CHANGED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Concept).HasColumnName("CONCEPT");

                entity.Property(e => e.Conceptcid).HasColumnName("CONCEPTCID");

                entity.Property(e => e.ConceptcidMon1).HasColumnName("CONCEPTCID_MON1");

                entity.Property(e => e.ConceptcidMon2).HasColumnName("CONCEPTCID_MON2");

                entity.Property(e => e.ConceptoidMon1).HasColumnName("CONCEPTOID_MON1");

                entity.Property(e => e.ConceptoidMon2).HasColumnName("CONCEPTOID_MON2");

                entity.Property(e => e.DscdCode)
                    .IsRequired()
                    .HasColumnName("DSCD_CODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DscdDeletedid).HasColumnName("DSCD_DELETEDID");

                entity.Property(e => e.DscdDescription)
                    .HasColumnName("DSCD_DESCRIPTION")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.DscdGroup).HasColumnName("DSCD_GROUP");

                entity.Property(e => e.DscdKeywords)
                    .HasColumnName("DSCD_KEYWORDS")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.DscdOutputcode)
                    .HasColumnName("DSCD_OUTPUTCODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DscdSysid).HasColumnName("DSCD_SYSID");

                entity.Property(e => e.DscdSystem).HasColumnName("DSCD_SYSTEM");

                entity.Property(e => e.DscdSystemcode)
                    .HasColumnName("DSCD_SYSTEMCODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DscdTravelDisease).HasColumnName("DSCD_TRAVEL_DISEASE");

                entity.Property(e => e.DscdType).HasColumnName("DSCD_TYPE");

                entity.Property(e => e.DscdUrl)
                    .HasColumnName("DSCD_URL")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Term).HasColumnName("TERM");

                entity.Property(e => e.TermoidMon1).HasColumnName("TERMOID_MON1");

                entity.Property(e => e.TermoidMon2).HasColumnName("TERMOID_MON2");

                entity.HasOne(d => d.ConceptNavigation)
                    .WithMany(p => p.DiseasecodeConceptNavigation)
                    .HasForeignKey(d => d.Concept)
                    .HasConstraintName("DISEASECODE_FK_CONCEPT");

                entity.HasOne(d => d.ConceptoidMon1Navigation)
                    .WithMany(p => p.DiseasecodeConceptoidMon1Navigation)
                    .HasForeignKey(d => d.ConceptoidMon1)
                    .HasConstraintName("DISEASECODE_FK_CONCEPT_MON1");

                entity.HasOne(d => d.ConceptoidMon2Navigation)
                    .WithMany(p => p.DiseasecodeConceptoidMon2Navigation)
                    .HasForeignKey(d => d.ConceptoidMon2)
                    .HasConstraintName("DISEASECODE_FK_CONCEPT_MON2");

                entity.HasOne(d => d.DscdGroupNavigation)
                    .WithMany(p => p.Diseasecode)
                    .HasForeignKey(d => d.DscdGroup)
                    .HasConstraintName("DISEASECODE_FK_GROUP");

                entity.HasOne(d => d.DscdTravelDiseaseNavigation)
                    .WithMany(p => p.DiseasecodeDscdTravelDiseaseNavigation)
                    .HasForeignKey(d => d.DscdTravelDisease)
                    .HasConstraintName("DSCD_TRAVEL_DISEASE_FK");

                entity.HasOne(d => d.ModifiedbyNavigation)
                    .WithMany(p => p.Diseasecode)
                    .HasForeignKey(d => d.Modifiedby)
                    .HasConstraintName("FK_DISEASE_MODIFIEDBY_PPPU");

                entity.HasOne(d => d.TermNavigation)
                    .WithMany(p => p.DiseasecodeTermNavigation)
                    .HasForeignKey(d => d.Term)
                    .HasConstraintName("DISEASECODE_FK_TERM");

                entity.HasOne(d => d.TermoidMon1Navigation)
                    .WithMany(p => p.DiseasecodeTermoidMon1Navigation)
                    .HasForeignKey(d => d.TermoidMon1)
                    .HasConstraintName("DISEASECODE_FK_TERM_MON1");

                entity.HasOne(d => d.TermoidMon2Navigation)
                    .WithMany(p => p.DiseasecodeTermoidMon2Navigation)
                    .HasForeignKey(d => d.TermoidMon2)
                    .HasConstraintName("DISEASECODE_FK_TERM_MON2");
            });

            modelBuilder.Entity<Headline>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("HEADLINE");

                entity.HasIndex(e => e.HlCategory)
                    .HasName("HL_FK_CATEGORY");

                entity.HasIndex(e => e.HlOrder)
                    .HasName("HEADLINE_I_HL_ORDER");

                entity.HasIndex(e => e.HlOrganisation)
                    .HasName("HEADLINE_FK_ORG_ID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_HEADLINE");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HlCategory).HasColumnName("HL_CATEGORY");

                entity.Property(e => e.HlDateFrom)
                    .HasColumnName("HL_DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.HlDateTo)
                    .HasColumnName("HL_DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.HlDeatailed)
                    .HasColumnName("HL_DEATAILED")
                    .HasColumnType("image");

                entity.Property(e => e.HlHeadlineType).HasColumnName("HL_HEADLINE_TYPE");

                entity.Property(e => e.HlImageindex).HasColumnName("HL_IMAGEINDEX");

                entity.Property(e => e.HlInactive).HasColumnName("HL_INACTIVE");

                entity.Property(e => e.HlOrder).HasColumnName("HL_ORDER");

                entity.Property(e => e.HlOrganisation).HasColumnName("HL_ORGANISATION");

                entity.Property(e => e.HlRequireAck).HasColumnName("HL_REQUIRE_ACK");

                entity.Property(e => e.HlShortdescr)
                    .HasColumnName("HL_SHORTDESCR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HlShowOnce).HasColumnName("HL_SHOW_ONCE");

                entity.Property(e => e.HlSummary)
                    .HasColumnName("HL_SUMMARY")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.HlUrl)
                    .HasColumnName("HL_URL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.HlCategoryNavigation)
                    .WithMany(p => p.Headline)
                    .HasForeignKey(d => d.HlCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HL_FK_CATEGORY");

                entity.HasOne(d => d.HlOrganisationNavigation)
                    .WithMany(p => p.Headline)
                    .HasForeignKey(d => d.HlOrganisation)
                    .HasConstraintName("HEADLINE_FK_ORG_ID");
            });

            modelBuilder.Entity<Lookuplist>(entity =>
            {
                entity.HasKey(e => e.LklsId);

                entity.ToTable("LOOKUPLIST");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_LOOKUPLIST");

                entity.HasIndex(e => new { e.LklsType, e.LklsCode, e.LklsDeletedid, e.PartitionId })
                    .HasName("LKLS_TYPECODE")
                    .IsUnique();

                entity.Property(e => e.LklsId)
                    .HasColumnName("LKLS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LklsChanged)
                    .HasColumnName("LKLS_CHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.LklsCode)
                    .IsRequired()
                    .HasColumnName("LKLS_CODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LklsDeletedid).HasColumnName("LKLS_DELETEDID");

                entity.Property(e => e.LklsDescription)
                    .HasColumnName("LKLS_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LklsTag).HasColumnName("LKLS_TAG");

                entity.Property(e => e.LklsTag2).HasColumnName("LKLS_TAG2");

                entity.Property(e => e.LklsType).HasColumnName("LKLS_TYPE");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrgStructure>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ORG_STRUCTURE");

                entity.HasIndex(e => e.AlertOrganisation)
                    .HasName("ORG_STRUCTURE_FK_ALERT_ORG");

                entity.HasIndex(e => e.AlterpatientFormid)
                    .HasName("FK_ORGSTR_ALTERPAT_FORMID");

                entity.HasIndex(e => e.DefaultAlerttype)
                    .HasName("DEF_ALERTTYPE_FK_SHCDID");

                entity.HasIndex(e => e.DisplaypatientFormid)
                    .HasName("FK_ORGSTR_DISPLAYPAT_FORMID");

                entity.HasIndex(e => e.NewpatientFormid)
                    .HasName("FK_ORGSTR_NEWPAT_FORMID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_ORG_STRUCTURE");

                entity.HasIndex(e => e.OsAdmRoleId)
                    .HasName("FK_OS_ADM_ROLE_ID");

                entity.HasIndex(e => e.OsAdminPos)
                    .HasName("FK_ORG_STRUCTURE_ADMIN_POS");

                entity.HasIndex(e => e.OsCaseRoleId)
                    .HasName("FK_OS_CASE_ROLE_ID");

                entity.HasIndex(e => e.OsClinicalPos)
                    .HasName("FK_ORG_STRUCTURE_CLINICAL_POS");

                entity.HasIndex(e => e.OsClnRoleId)
                    .HasName("FK_OS_CLN_ROLE_ID");

                entity.HasIndex(e => e.OsContactType)
                    .HasName("OS_CONTACT_TYPE_FK");

                entity.HasIndex(e => e.OsEquipLoanPos)
                    .HasName("ORG_STRUCTURE_FK_LOAN_POS");

                entity.HasIndex(e => e.OsGuessedRoleId)
                    .HasName("FK_OS_GUESSED_ROLE_ID");

                entity.HasIndex(e => e.ParentId)
                    .HasName("FK_ORG_STR_PARENT_ID");

                entity.HasIndex(e => e.PppuId)
                    .HasName("FK_ORG_STR_NODE_ID");

                entity.HasIndex(e => e.RxSystemId)
                    .HasName("ORGSTRUCTURE_FK_RXSYSTEM");

                entity.HasIndex(e => e.SchdAdminEncMacro)
                    .HasName("FK_ORG_STR_ADM_ENC_MACRO");

                entity.HasIndex(e => e.SchdClinicalEncMacro)
                    .HasName("FK_ORG_STR_CLIN_ENC_MACRO");

                entity.HasIndex(e => e.ShcdCareType)
                    .HasName("FK_ORG_STRUCTURE_SHCD_ID");

                entity.HasIndex(e => e.ShcdSubtypeId)
                    .HasName("FK_ORG_STR_SHCD_SUBTYPE_ID");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("ORG_STRUCTURE_FK_CDO_TRANSDA");

                entity.HasIndex(e => e.WtbdFromgroup)
                    .HasName("FK_ORGSTR_WTBD_FROM");

                entity.HasIndex(e => e.WtbdTogroup)
                    .HasName("FK_ORGSTR_WTBD_TO");

                entity.HasIndex(e => new { e.RefCode, e.Deletedid, e.PartitionId })
                    .HasName("REF_CODE_IU")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddEncounterCreatedDate).HasColumnName("ADD_ENCOUNTER_CREATED_DATE");

                entity.Property(e => e.AddJobTitle).HasColumnName("ADD_JOB_TITLE");

                entity.Property(e => e.AlertOpenonly)
                    .HasColumnName("ALERT_OPENONLY")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.AlertOrganisation).HasColumnName("ALERT_ORGANISATION");

                entity.Property(e => e.AlertScope).HasColumnName("ALERT_SCOPE");

                entity.Property(e => e.AllowAssignProvsOutOrg).HasColumnName("ALLOW_ASSIGN_PROVS_OUT_ORG");

                entity.Property(e => e.AllowMultipleAdmissions).HasColumnName("ALLOW_MULTIPLE_ADMISSIONS");

                entity.Property(e => e.AllowPatientContext).HasColumnName("ALLOW_PATIENT_CONTEXT");

                entity.Property(e => e.AllowPlanInEmr)
                    .HasColumnName("ALLOW_PLAN_IN_EMR")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.AllowPrivacyMe).HasColumnName("ALLOW_PRIVACY_ME");

                entity.Property(e => e.AllowSectionType).HasColumnName("ALLOW_SECTION_TYPE");

                entity.Property(e => e.Allowcasetypenull)
                    .HasColumnName("ALLOWCASETYPENULL")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Allowsingleopencase).HasColumnName("ALLOWSINGLEOPENCASE");

                entity.Property(e => e.AlterpatientFormid).HasColumnName("ALTERPATIENT_FORMID");

                entity.Property(e => e.AlterpatientSuppresslookup).HasColumnName("ALTERPATIENT_SUPPRESSLOOKUP");

                entity.Property(e => e.AutoUpdateFirstVisit).HasColumnName("AUTO_UPDATE_FIRST_VISIT");

                entity.Property(e => e.CaseForImportedImm)
                    .HasColumnName("CASE_FOR_IMPORTED_IMM")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ComplCommentsMacro)
                    .HasColumnName("COMPL_COMMENTS_MACRO")
                    .HasColumnType("image");

                entity.Property(e => e.ComplCommentsType).HasColumnName("COMPL_COMMENTS_TYPE");

                entity.Property(e => e.CsAutoCloseServices).HasColumnName("CS_AUTO_CLOSE_SERVICES");

                entity.Property(e => e.CsPromptForNewService).HasColumnName("CS_PROMPT_FOR_NEW_SERVICE");

                entity.Property(e => e.DefObjectRightsType).HasColumnName("DEF_OBJECT_RIGHTS_TYPE");

                entity.Property(e => e.DefaultAlerttype).HasColumnName("DEFAULT_ALERTTYPE");

                entity.Property(e => e.Defaultcasetype)
                    .HasColumnName("DEFAULTCASETYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Deletedid)
                    .HasColumnName("DELETEDID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplaypatientFormid).HasColumnName("DISPLAYPATIENT_FORMID");

                entity.Property(e => e.DisplaypatientSuppresslookup).HasColumnName("DISPLAYPATIENT_SUPPRESSLOOKUP");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EncryptDataOnexport).HasColumnName("ENCRYPT_DATA_ONEXPORT");

                entity.Property(e => e.ForceAutocase).HasColumnName("FORCE_AUTOCASE");

                entity.Property(e => e.ForceCaseTitle)
                    .HasColumnName("FORCE_CASE_TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HideCaseList).HasColumnName("HIDE_CASE_LIST");

                entity.Property(e => e.IncludeOtherPatients).HasColumnName("INCLUDE_OTHER_PATIENTS");

                entity.Property(e => e.InsertComplCmntsInCnotes).HasColumnName("INSERT_COMPL_CMNTS_IN_CNOTES");

                entity.Property(e => e.InterventionsMatchRule).HasColumnName("INTERVENTIONS_MATCH_RULE");

                entity.Property(e => e.InterventionsMergeRule).HasColumnName("INTERVENTIONS_MERGE_RULE");

                entity.Property(e => e.IsFinancialGroup).HasColumnName("IS_FINANCIAL_GROUP");

                entity.Property(e => e.LockClosedCase).HasColumnName("LOCK_CLOSED_CASE");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.NewpatientFormid).HasColumnName("NEWPATIENT_FORMID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.ObjectivesMatchRule).HasColumnName("OBJECTIVES_MATCH_RULE");

                entity.Property(e => e.ObjectivesMergeRule).HasColumnName("OBJECTIVES_MERGE_RULE");

                entity.Property(e => e.OmitFromCloseAll)
                    .HasColumnName("OMIT_FROM_CLOSE_ALL")
                    .HasColumnType("image");

                entity.Property(e => e.OsAdmRoleId).HasColumnName("OS_ADM_ROLE_ID");

                entity.Property(e => e.OsAdminPos).HasColumnName("OS_ADMIN_POS");

                entity.Property(e => e.OsAppSystemId)
                    .HasColumnName("OS_APP_SYSTEM_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OsCaseRoleId).HasColumnName("OS_CASE_ROLE_ID");

                entity.Property(e => e.OsCauseGroup)
                    .HasColumnName("OS_CAUSE_GROUP")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.OsClinicalPos).HasColumnName("OS_CLINICAL_POS");

                entity.Property(e => e.OsClnRoleId).HasColumnName("OS_CLN_ROLE_ID");

                entity.Property(e => e.OsContactType).HasColumnName("OS_CONTACT_TYPE");

                entity.Property(e => e.OsEncounterDescType).HasColumnName("OS_ENCOUNTER_DESC_TYPE");

                entity.Property(e => e.OsEquipLoanPos).HasColumnName("OS_EQUIP_LOAN_POS");

                entity.Property(e => e.OsGuessedRoleId).HasColumnName("OS_GUESSED_ROLE_ID");

                entity.Property(e => e.OsIsEquipLoan).HasColumnName("OS_IS_EQUIP_LOAN");

                entity.Property(e => e.OsUseGuessedRole).HasColumnName("OS_USE_GUESSED_ROLE");

                entity.Property(e => e.OverviewHyperlinks)
                    .HasColumnName("OVERVIEW_HYPERLINKS")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PlanPromtType).HasColumnName("PLAN_PROMT_TYPE");

                entity.Property(e => e.PppuId).HasColumnName("PPPU_ID");

                entity.Property(e => e.PrnFormHeaderFooter).HasColumnName("PRN_FORM_HEADER_FOOTER");

                entity.Property(e => e.Promtcasetype).HasColumnName("PROMTCASETYPE");

                entity.Property(e => e.RefCode)
                    .HasColumnName("REF_CODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RelaxRulesOnObjectives).HasColumnName("RELAX_RULES_ON_OBJECTIVES");

                entity.Property(e => e.RequireCaseForBe).HasColumnName("REQUIRE_CASE_FOR_BE");

                entity.Property(e => e.RequireCaseForGs).HasColumnName("REQUIRE_CASE_FOR_GS");

                entity.Property(e => e.RxSystemId).HasColumnName("RX_SYSTEM_ID");

                entity.Property(e => e.SchdAdminEncMacro).HasColumnName("SCHD_ADMIN_ENC_MACRO");

                entity.Property(e => e.SchdClinicalEncMacro).HasColumnName("SCHD_CLINICAL_ENC_MACRO");

                entity.Property(e => e.SelectPatientCase).HasColumnName("SELECT_PATIENT_CASE");

                entity.Property(e => e.ShcdCareType).HasColumnName("SHCD_CARE_TYPE");

                entity.Property(e => e.ShcdSubtypeId).HasColumnName("SHCD_SUBTYPE_ID");

                entity.Property(e => e.ShowPos).HasColumnName("SHOW_POS");

                entity.Property(e => e.ShowUnsigned).HasColumnName("SHOW_UNSIGNED");

                entity.Property(e => e.SyncReferralAndEmbdLetter).HasColumnName("SYNC_REFERRAL_AND_EMBD_LETTER");

                entity.Property(e => e.TemplateId).HasColumnName("TEMPLATE_ID");

                entity.Property(e => e.UcpShowLuckyButton).HasColumnName("UCP_SHOW_LUCKY_BUTTON");

                entity.Property(e => e.UnifiedExcludedPlans)
                    .HasColumnName("UNIFIED_EXCLUDED_PLANS")
                    .HasColumnType("image");

                entity.Property(e => e.UnifiedInternalRule)
                    .HasColumnName("UNIFIED_INTERNAL_RULE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnifiedInternalRuleMacro)
                    .HasColumnName("UNIFIED_INTERNAL_RULE_MACRO")
                    .HasColumnType("image");

                entity.Property(e => e.UnifiedProviders)
                    .HasColumnName("UNIFIED_PROVIDERS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnifiedStandardTmpltCode)
                    .HasColumnName("UNIFIED_STANDARD_TMPLT_CODE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UseAlternatePatientViews).HasColumnName("USE_ALTERNATE_PATIENT_VIEWS");

                entity.Property(e => e.UseUnifiedCarePlan).HasColumnName("USE_UNIFIED_CARE_PLAN");

                entity.Property(e => e.ValidateCarePlanMacro)
                    .HasColumnName("VALIDATE_CARE_PLAN_MACRO")
                    .HasColumnType("image");

                entity.Property(e => e.WtbdAutoEncounter).HasColumnName("WTBD_AUTO_ENCOUNTER");

                entity.Property(e => e.WtbdDelay)
                    .HasColumnName("WTBD_DELAY")
                    .HasDefaultValueSql("((60))");

                entity.Property(e => e.WtbdFromgroup).HasColumnName("WTBD_FROMGROUP");

                entity.Property(e => e.WtbdFromgroupEnabled).HasColumnName("WTBD_FROMGROUP_ENABLED");

                entity.Property(e => e.WtbdTogroup).HasColumnName("WTBD_TOGROUP");

                entity.Property(e => e.WtbdTogroupEnabled).HasColumnName("WTBD_TOGROUP_ENABLED");

                entity.HasOne(d => d.AlertOrganisationNavigation)
                    .WithMany(p => p.InverseAlertOrganisationNavigation)
                    .HasForeignKey(d => d.AlertOrganisation)
                    .HasConstraintName("ORG_STRUCTURE_FK_ALERT_ORG");

                entity.HasOne(d => d.AlterpatientForm)
                    .WithMany(p => p.OrgStructureAlterpatientForm)
                    .HasForeignKey(d => d.AlterpatientFormid)
                    .HasConstraintName("FK_ORGSTR_ALTERPAT_FORMID");

                entity.HasOne(d => d.DefaultAlerttypeNavigation)
                    .WithMany(p => p.OrgStructureDefaultAlerttypeNavigation)
                    .HasForeignKey(d => d.DefaultAlerttype)
                    .HasConstraintName("DEF_ALERTTYPE_FK_SHCDID");

                entity.HasOne(d => d.DisplaypatientForm)
                    .WithMany(p => p.OrgStructureDisplaypatientForm)
                    .HasForeignKey(d => d.DisplaypatientFormid)
                    .HasConstraintName("FK_ORGSTR_DISPLAYPAT_FORMID");

                entity.HasOne(d => d.NewpatientForm)
                    .WithMany(p => p.OrgStructureNewpatientForm)
                    .HasForeignKey(d => d.NewpatientFormid)
                    .HasConstraintName("FK_ORGSTR_NEWPAT_FORMID");

                entity.HasOne(d => d.OsAdmRole)
                    .WithMany(p => p.OrgStructureOsAdmRole)
                    .HasForeignKey(d => d.OsAdmRoleId)
                    .HasConstraintName("FK_OS_ADM_ROLE_ID");

                entity.HasOne(d => d.OsAdminPosNavigation)
                    .WithMany(p => p.OrgStructureOsAdminPosNavigation)
                    .HasForeignKey(d => d.OsAdminPos)
                    .HasConstraintName("FK_ORG_STRUCTURE_ADMIN_POS");

                entity.HasOne(d => d.OsCaseRole)
                    .WithMany(p => p.OrgStructureOsCaseRole)
                    .HasForeignKey(d => d.OsCaseRoleId)
                    .HasConstraintName("FK_OS_CASE_ROLE_ID");

                entity.HasOne(d => d.OsClinicalPosNavigation)
                    .WithMany(p => p.OrgStructureOsClinicalPosNavigation)
                    .HasForeignKey(d => d.OsClinicalPos)
                    .HasConstraintName("FK_ORG_STRUCTURE_CLINICAL_POS");

                entity.HasOne(d => d.OsClnRole)
                    .WithMany(p => p.OrgStructureOsClnRole)
                    .HasForeignKey(d => d.OsClnRoleId)
                    .HasConstraintName("FK_OS_CLN_ROLE_ID");

                entity.HasOne(d => d.OsContactTypeNavigation)
                    .WithMany(p => p.OrgStructureOsContactTypeNavigation)
                    .HasForeignKey(d => d.OsContactType)
                    .HasConstraintName("OS_CONTACT_TYPE_FK");

                entity.HasOne(d => d.OsEquipLoanPosNavigation)
                    .WithMany(p => p.OrgStructureOsEquipLoanPosNavigation)
                    .HasForeignKey(d => d.OsEquipLoanPos)
                    .HasConstraintName("ORG_STRUCTURE_FK_LOAN_POS");

                entity.HasOne(d => d.OsGuessedRole)
                    .WithMany(p => p.OrgStructureOsGuessedRole)
                    .HasForeignKey(d => d.OsGuessedRoleId)
                    .HasConstraintName("FK_OS_GUESSED_ROLE_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_ORG_STR_PARENT_ID");

                entity.HasOne(d => d.Pppu)
                    .WithMany(p => p.OrgStructurePppu)
                    .HasForeignKey(d => d.PppuId)
                    .HasConstraintName("FK_ORG_STR_NODE_ID");

                entity.HasOne(d => d.SchdAdminEncMacroNavigation)
                    .WithMany(p => p.OrgStructureSchdAdminEncMacroNavigation)
                    .HasForeignKey(d => d.SchdAdminEncMacro)
                    .HasConstraintName("FK_ORG_STR_ADM_ENC_MACRO");

                entity.HasOne(d => d.SchdClinicalEncMacroNavigation)
                    .WithMany(p => p.OrgStructureSchdClinicalEncMacroNavigation)
                    .HasForeignKey(d => d.SchdClinicalEncMacro)
                    .HasConstraintName("FK_ORG_STR_CLIN_ENC_MACRO");

                entity.HasOne(d => d.ShcdCareTypeNavigation)
                    .WithMany(p => p.OrgStructureShcdCareTypeNavigation)
                    .HasForeignKey(d => d.ShcdCareType)
                    .HasConstraintName("FK_ORG_STRUCTURE_SHCD_ID");

                entity.HasOne(d => d.ShcdSubtype)
                    .WithMany(p => p.OrgStructureShcdSubtype)
                    .HasForeignKey(d => d.ShcdSubtypeId)
                    .HasConstraintName("FK_ORG_STR_SHCD_SUBTYPE_ID");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.OrgStructureTemplate)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("ORG_STRUCTURE_FK_CDO_TRANSDA");

                entity.HasOne(d => d.WtbdFromgroupNavigation)
                    .WithMany(p => p.OrgStructureWtbdFromgroupNavigation)
                    .HasForeignKey(d => d.WtbdFromgroup)
                    .HasConstraintName("FK_ORGSTR_WTBD_FROM");

                entity.HasOne(d => d.WtbdTogroupNavigation)
                    .WithMany(p => p.OrgStructureWtbdTogroupNavigation)
                    .HasForeignKey(d => d.WtbdTogroup)
                    .HasConstraintName("FK_ORGSTR_WTBD_TO");
            });

            modelBuilder.Entity<Partition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PARTITION");

                entity.HasIndex(e => e.PartitionContainerId)
                    .HasName("PARTITION_FK_CONTAINER");

                entity.HasIndex(e => e.PartitionStructureId)
                    .HasName("FK_PARTITION_STRUCTURE");

                entity.HasIndex(e => new { e.PrtnCode, e.Deletedid })
                    .HasName("PARTITION_I_CODE")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.PartitionContainerId).HasColumnName("PARTITION_CONTAINER_ID");

                entity.Property(e => e.PartitionStructureId)
                    .HasColumnName("PARTITION_STRUCTURE_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrtnCode)
                    .IsRequired()
                    .HasColumnName("PRTN_CODE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PrtnName)
                    .IsRequired()
                    .HasColumnName("PRTN_NAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PrtnStatus).HasColumnName("PRTN_STATUS");

                entity.Property(e => e.PrtnType).HasColumnName("PRTN_TYPE");

                entity.HasOne(d => d.PartitionContainer)
                    .WithMany(p => p.InversePartitionContainer)
                    .HasForeignKey(d => d.PartitionContainerId)
                    .HasConstraintName("PARTITION_FK_CONTAINER");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PtntId);

                entity.ToTable("PATIENT");

                entity.HasIndex(e => e.Code)
                    .HasName("I_PATIENT_CODE");

                entity.HasIndex(e => e.Createdby)
                    .HasName("PATIENT_FK_CREATEDBY");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("PATIENT_FK_DELETEDBY");

                entity.HasIndex(e => e.LklsIdEthnicity)
                    .HasName("FOREIGN_LKLS_ID_ETHNICITY");

                entity.HasIndex(e => e.LklsIdEthnicity2)
                    .HasName("PATIENT_FK_LKLS_ID_ETHNICIT2");

                entity.HasIndex(e => e.LklsIdEthnicity3)
                    .HasName("PATIENT_FK_LKLS_ID_ETHNICIT3");

                entity.HasIndex(e => e.LklsIdEthnicity4)
                    .HasName("PATIENT_FK_ETHNICITY4");

                entity.HasIndex(e => e.LklsIdEthnicity5)
                    .HasName("PATIENT_FK_ETHNICITY5");

                entity.HasIndex(e => e.LklsIdEthnicity6)
                    .HasName("PATIENT_FK_ETHNICITY6");

                entity.HasIndex(e => e.LklsIdMaritalstatus)
                    .HasName("FOREIGN_LKLS_ID_MARITALSTATU");

                entity.HasIndex(e => e.LklsIdOccupation)
                    .HasName("FOREIGN_LKLS_ID_OCCUPATION");

                entity.HasIndex(e => e.LklsIdReligion)
                    .HasName("FOREIGN_LKLS_ID_RELIGION");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PATIENT");

                entity.HasIndex(e => e.PppuIdAltdr)
                    .HasName("FOREIGN_PPPU_ID_ALTDR");

                entity.HasIndex(e => e.PppuIdUsualdr)
                    .HasName("FOREIGN_PPPU_ID_USUALDR");

                entity.HasIndex(e => e.PtntAliasnameupper)
                    .HasName("PATIENT_I_PTNT_ALIASNAMEUPPER");

                entity.HasIndex(e => e.PtntDeletedUserid)
                    .HasName("FK_PTNT_DELETED_USERID");

                entity.HasIndex(e => e.PtntDob)
                    .HasName("PATIENT_I_DOB");

                entity.HasIndex(e => e.PtntEmailaddrupper)
                    .HasName("PATIENT_I_EMAILADDR");

                entity.HasIndex(e => e.PtntEmployerId)
                    .HasName("PTNT_FK_EMPLOYER_ID");

                entity.HasIndex(e => e.PtntFamilyhxOid)
                    .HasName("PATIENT_FK_PTNT_FAMILYHX_OID");

                entity.HasIndex(e => e.PtntFirstnameupper)
                    .HasName("INDEX_PTNT_FIRSTNAMEUPPER");

                entity.HasIndex(e => e.PtntFolder)
                    .HasName("PATIENT_PTNT_FOLDER");

                entity.HasIndex(e => e.PtntIdGuarantor)
                    .HasName("FOREIGN_PTNT_ID_GUARANTOR");

                entity.HasIndex(e => e.PtntIdInsurer)
                    .HasName("PTNT_FOREIGN_INSURER");

                entity.HasIndex(e => e.PtntIdPartner)
                    .HasName("FOREIGN_PTNT_ID_PARTNER");

                entity.HasIndex(e => e.PtntLastactivitydate)
                    .HasName("I_PATIENT_LASTACTIVITYDATE");

                entity.HasIndex(e => e.PtntLeadcaregiver)
                    .HasName("PATIENT_FK_LEADCAREGIVER");

                entity.HasIndex(e => e.PtntLeadcarerel)
                    .HasName("FK_PAT_LEADCARE_REL");

                entity.HasIndex(e => e.PtntMaidennameupper)
                    .HasName("PATIENT_I_PTNT_MAIDENNAMEUPPER");

                entity.HasIndex(e => e.PtntMasterPtntId)
                    .HasName("FK_PTNT_MASTER_PTNT_ID");

                entity.HasIndex(e => e.PtntMpi)
                    .HasName("PATIENT_I_PTNT_MPI");

                entity.HasIndex(e => e.PtntNamesuffix)
                    .HasName("FK_PTNT_NAMESUFFIX_SHORTCODE");

                entity.HasIndex(e => e.PtntNationalnum)
                    .HasName("INDEX_PATIENT_PTNT_NHI");

                entity.HasIndex(e => e.PtntObstetricHxOid)
                    .HasName("PATIENT_FK_PTNT_OBSTETRIC_HX");

                entity.HasIndex(e => e.PtntOrgId)
                    .HasName("FK_PATIENT_ORG_ID");

                entity.HasIndex(e => e.PtntParent1)
                    .HasName("FK_PATIENT_PARENT1");

                entity.HasIndex(e => e.PtntParent1rel)
                    .HasName("FK_PAT_PARENT1_REL");

                entity.HasIndex(e => e.PtntParent2)
                    .HasName("FK_PATIENT_PARENT2");

                entity.HasIndex(e => e.PtntParent2rel)
                    .HasName("FK_PAT_PARENT2_REL");

                entity.HasIndex(e => e.PtntPasthxOid)
                    .HasName("PATIENT_FK_PTNT_PASTHX_OID");

                entity.HasIndex(e => e.PtntPatientcodesort)
                    .HasName("I_PTNT_PATIENTCODESORT");

                entity.HasIndex(e => e.PtntPayerId)
                    .HasName("PATIENT_FK_PAYER_ID");

                entity.HasIndex(e => e.PtntPostalstate)
                    .HasName("PATIENT_FK_PTNT_POSTALSTATE");

                entity.HasIndex(e => e.PtntPrefnameupper)
                    .HasName("I_PATIENT_PTNT_PREFNAMEUPPER");

                entity.HasIndex(e => e.PtntSocialhxOid)
                    .HasName("PATIENT_FK_PTNT_SOCIALHX_OID");

                entity.HasIndex(e => e.PtntSocialhxSrcProviderid)
                    .HasName("FK_PPPU_SOCLHX_SRC_PROVIDERID");

                entity.HasIndex(e => e.PtntSoundexFirstname)
                    .HasName("PTNT_IDX_SOUNDEX_FIRSTNAME");

                entity.HasIndex(e => e.PtntSoundexSurname)
                    .HasName("PATIENT_I_SURNAME_SND");

                entity.HasIndex(e => e.PtntSourceref)
                    .HasName("PATIENT_I_PTNT_SOURCEREF");

                entity.HasIndex(e => e.PtntSrcProviderid)
                    .HasName("FK_PPPU_PTNT_SRC_PROVIDERID");

                entity.HasIndex(e => e.PtntStreetstate)
                    .HasName("PATIENT_FK_PTNT_STREETSTATE");

                entity.HasIndex(e => e.PtntSurnameupper)
                    .HasName("INDEX_PTNT_SURNAMEUPPER");

                entity.HasIndex(e => e.PtntTransferStatusChangedBy)
                    .HasName("PATIENT_FK_TRANSFER_CHANGED_BY");

                entity.HasIndex(e => e.PtntType)
                    .HasName("PATIENT_I_PTNT_TYPE");

                entity.HasIndex(e => e.PtntWebusername)
                    .HasName("IND_WEBUSERNAME");

                entity.HasIndex(e => e.PtntWorkstate)
                    .HasName("PATIENT_FK_PTNT_WORKSTATE");

                entity.HasIndex(e => e.ShcdIdBenefittype)
                    .HasName("FK_PTNT_BEN_TP_SHCD_ID");

                entity.HasIndex(e => e.ShcdIdHealthstatus)
                    .HasName("FK_PTNT_HEAL_ST_SHCD_ID");

                entity.HasIndex(e => e.ShcdIdHomelanguage)
                    .HasName("PATIENT_FK_SHCD_ID_HOMELANGU");

                entity.HasIndex(e => e.ShcdIdJournals)
                    .HasName("PATIENT_FK_SHCD_ID_JOURNALS");

                entity.HasIndex(e => e.ShcdIdLivingsituation)
                    .HasName("FK_PTNT_LIV_SIT_SHCD_ID");

                entity.HasIndex(e => e.ShcdIdPlan)
                    .HasName("PTNT_FOREIGN_PLAN");

                entity.HasIndex(e => e.ShcdIdPreflanguage)
                    .HasName("PATIENT_FK_SHCD_ID_PREFLANGU");

                entity.HasIndex(e => e.ShcdIdServicecategory)
                    .HasName("FK_PTNT_SER_CAT_SHCD_ID");

                entity.HasIndex(e => e.ShcdIdServicediscount)
                    .HasName("PTNT_FOREIGN_SERVICEDISCOUNT");

                entity.HasIndex(e => e.ShcdIdServicerate)
                    .HasName("PTNT_FOREIGN_SERVICERATE");

                entity.HasIndex(e => e.ShcdIdTargettype)
                    .HasName("FK_PTNT_TRG_TP_SHCD_ID");

                entity.HasIndex(e => new { e.PtntDeletedid, e.PtntSurnameupper, e.PartitionId })
                    .HasName("idx_PATIENT_PTNT_DELETEDID_PTNT_SURNAMEUPPER_PARTITION_ID");

                entity.HasIndex(e => new { e.PtntPatientcode, e.PtntDeletedid, e.PartitionId })
                    .HasName("INDEX_PTNT_PARTCODE")
                    .IsUnique();

                entity.HasIndex(e => new { e.PtntSurname, e.PtntFirstname, e.PtntDob })
                    .HasName("INDEX_PTNT_NAMEANDDOB");

                entity.Property(e => e.PtntId)
                    .HasColumnName("PTNT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcknowledgmentLastRead)
                    .HasColumnName("ACKNOWLEDGMENT_LAST_READ")
                    .HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ForceWebPassChange).HasColumnName("FORCE_WEB_PASS_CHANGE");

                entity.Property(e => e.LastCheckedDate)
                    .HasColumnName("LAST_CHECKED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastconfirmedDate)
                    .HasColumnName("LASTCONFIRMED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LklsIdEthnicity).HasColumnName("LKLS_ID_ETHNICITY");

                entity.Property(e => e.LklsIdEthnicity2).HasColumnName("LKLS_ID_ETHNICITY2");

                entity.Property(e => e.LklsIdEthnicity3).HasColumnName("LKLS_ID_ETHNICITY3");

                entity.Property(e => e.LklsIdEthnicity4).HasColumnName("LKLS_ID_ETHNICITY4");

                entity.Property(e => e.LklsIdEthnicity5).HasColumnName("LKLS_ID_ETHNICITY5");

                entity.Property(e => e.LklsIdEthnicity6).HasColumnName("LKLS_ID_ETHNICITY6");

                entity.Property(e => e.LklsIdMaritalstatus).HasColumnName("LKLS_ID_MARITALSTATUS");

                entity.Property(e => e.LklsIdOccupation).HasColumnName("LKLS_ID_OCCUPATION");

                entity.Property(e => e.LklsIdReligion).HasColumnName("LKLS_ID_RELIGION");

                entity.Property(e => e.MpiSystemName)
                    .HasColumnName("MPI_SYSTEM_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PasswordExpiryDate)
                    .HasColumnName("PASSWORD_EXPIRY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientTouchId).HasColumnName("PATIENT_TOUCH_ID");

                entity.Property(e => e.PppuIdAltdr).HasColumnName("PPPU_ID_ALTDR");

                entity.Property(e => e.PppuIdUsualdr).HasColumnName("PPPU_ID_USUALDR");

                entity.Property(e => e.PrivacyOrg).HasColumnName("PRIVACY_ORG");

                entity.Property(e => e.PtntAccredited).HasColumnName("PTNT_ACCREDITED");

                entity.Property(e => e.PtntAliasname)
                    .HasColumnName("PTNT_ALIASNAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntAliasnameupper)
                    .HasColumnName("PTNT_ALIASNAMEUPPER")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntAllowEprescr).HasColumnName("PTNT_ALLOW_EPRESCR");

                entity.Property(e => e.PtntAllowcapitation).HasColumnName("PTNT_ALLOWCAPITATION");

                entity.Property(e => e.PtntAlwaystogurantor).HasColumnName("PTNT_ALWAYSTOGURANTOR");

                entity.Property(e => e.PtntApplyGst).HasColumnName("PTNT_APPLY_GST");

                entity.Property(e => e.PtntAutocase).HasColumnName("PTNT_AUTOCASE");

                entity.Property(e => e.PtntBloodGroup)
                    .HasColumnName("PTNT_BLOOD_GROUP")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntBuildingWork)
                    .HasColumnName("PTNT_BUILDING_WORK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PtntBuildingpostal)
                    .HasColumnName("PTNT_BUILDINGPOSTAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PtntBuildingstreet)
                    .HasColumnName("PTNT_BUILDINGSTREET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PtntCellphone)
                    .HasColumnName("PTNT_CELLPHONE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PtntCheckprivacy).HasColumnName("PTNT_CHECKPRIVACY");

                entity.Property(e => e.PtntCodes)
                    .HasColumnName("PTNT_CODES")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PtntCoinsurancepercentage)
                    .HasColumnName("PTNT_COINSURANCEPERCENTAGE")
                    .HasColumnType("currency");

                entity.Property(e => e.PtntCountryOfBirth).HasColumnName("PTNT_COUNTRY_OF_BIRTH");

                entity.Property(e => e.PtntCtgRegistered).HasColumnName("PTNT_CTG_REGISTERED");

                entity.Property(e => e.PtntDatefirstseen)
                    .HasColumnName("PTNT_DATEFIRSTSEEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntDatelastchanged)
                    .HasColumnName("PTNT_DATELASTCHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntDatelastseen)
                    .HasColumnName("PTNT_DATELASTSEEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntDecile)
                    .HasColumnName("PTNT_DECILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PtntDeletedDate)
                    .HasColumnName("PTNT_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntDeletedReason)
                    .HasColumnName("PTNT_DELETED_REASON")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PtntDeletedUserid).HasColumnName("PTNT_DELETED_USERID");

                entity.Property(e => e.PtntDeletedid).HasColumnName("PTNT_DELETEDID");

                entity.Property(e => e.PtntDhb)
                    .HasColumnName("PTNT_DHB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PtntDirectLogonList).HasColumnName("PTNT_DIRECT_LOGON_LIST");

                entity.Property(e => e.PtntDob)
                    .HasColumnName("PTNT_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntDod)
                    .HasColumnName("PTNT_DOD")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntDomicileCode)
                    .HasColumnName("PTNT_DOMICILE_CODE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PtntDomicileDescription)
                    .HasColumnName("PTNT_DOMICILE_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PtntEmailaddr)
                    .HasColumnName("PTNT_EMAILADDR")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntEmailaddrupper)
                    .HasColumnName("PTNT_EMAILADDRUPPER")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntEmlappntreminders).HasColumnName("PTNT_EMLAPPNTREMINDERS");

                entity.Property(e => e.PtntEmlduerecallsnotif).HasColumnName("PTNT_EMLDUERECALLSNOTIF");

                entity.Property(e => e.PtntEmployerId).HasColumnName("PTNT_EMPLOYER_ID");

                entity.Property(e => e.PtntEmploymentFrom)
                    .HasColumnName("PTNT_EMPLOYMENT_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntEmploymentPosition)
                    .HasColumnName("PTNT_EMPLOYMENT_POSITION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PtntFamilyhead).HasColumnName("PTNT_FAMILYHEAD");

                entity.Property(e => e.PtntFamilyhxOid).HasColumnName("PTNT_FAMILYHX_OID");

                entity.Property(e => e.PtntFirstname)
                    .HasColumnName("PTNT_FIRSTNAME")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntFirstnameupper)
                    .HasColumnName("PTNT_FIRSTNAMEUPPER")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntFolder)
                    .HasColumnName("PTNT_FOLDER")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PtntGeoCoordX)
                    .HasColumnName("PTNT_GEO_COORD_X")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PtntGeoCoordY)
                    .HasColumnName("PTNT_GEO_COORD_Y")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PtntGeoDhb)
                    .HasColumnName("PTNT_GEO_DHB")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PtntGeoLatitude)
                    .HasColumnName("PTNT_GEO_LATITUDE")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.PtntGeoLongitude)
                    .HasColumnName("PTNT_GEO_LONGITUDE")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.PtntGeoStatus).HasColumnName("PTNT_GEO_STATUS");

                entity.Property(e => e.PtntGeoUncertaintycode)
                    .HasColumnName("PTNT_GEO_UNCERTAINTYCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PtntGms)
                    .HasColumnName("PTNT_GMS")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PtntGonedatetime)
                    .HasColumnName("PTNT_GONEDATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntHerecomputer)
                    .HasColumnName("PTNT_HERECOMPUTER")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PtntHeredatetime)
                    .HasColumnName("PTNT_HEREDATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntHomefax)
                    .HasColumnName("PTNT_HOMEFAX")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PtntHomephone)
                    .HasColumnName("PTNT_HOMEPHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PtntIdGuarantor).HasColumnName("PTNT_ID_GUARANTOR");

                entity.Property(e => e.PtntIdInsurer).HasColumnName("PTNT_ID_INSURER");

                entity.Property(e => e.PtntIdPartner).HasColumnName("PTNT_ID_PARTNER");

                entity.Property(e => e.PtntIgnoredDuplSearch).HasColumnName("PTNT_IGNORED_DUPL_SEARCH");

                entity.Property(e => e.PtntIhnOpt).HasColumnName("PTNT_IHN_OPT");

                entity.Property(e => e.PtntIhnPasschanged)
                    .HasColumnName("PTNT_IHN_PASSCHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntIhnPassword)
                    .HasColumnName("PTNT_IHN_PASSWORD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PtntIhnPasswordHint)
                    .HasColumnName("PTNT_IHN_PASSWORD_HINT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PtntInactivationdate)
                    .HasColumnName("PTNT_INACTIVATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntInactivationreason).HasColumnName("PTNT_INACTIVATIONREASON");

                entity.Property(e => e.PtntIndex)
                    .HasColumnName("PTNT_INDEX")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PtntInfantOrDependent).HasColumnName("PTNT_INFANT_OR_DEPENDENT");

                entity.Property(e => e.PtntInterpreterrequired).HasColumnName("PTNT_INTERPRETERREQUIRED");

                entity.Property(e => e.PtntIsemailnotifyallowed).HasColumnName("PTNT_ISEMAILNOTIFYALLOWED");

                entity.Property(e => e.PtntIssmscellphone).HasColumnName("PTNT_ISSMSCELLPHONE");

                entity.Property(e => e.PtntIwi)
                    .HasColumnName("PTNT_IWI")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntJoinCentralAbility).HasColumnName("PTNT_JOIN_CENTRAL_ABILITY");

                entity.Property(e => e.PtntLabel).HasColumnName("PTNT_LABEL");

                entity.Property(e => e.PtntLastactivitydate)
                    .HasColumnName("PTNT_LASTACTIVITYDATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PtntLastaddresschanged)
                    .HasColumnName("PTNT_LASTADDRESSCHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntLastarrivaldate)
                    .HasColumnName("PTNT_LASTARRIVALDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntLastmpidatetime)
                    .HasColumnName("PTNT_LASTMPIDATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntLeadcaregiver).HasColumnName("PTNT_LEADCAREGIVER");

                entity.Property(e => e.PtntLeadcarerel).HasColumnName("PTNT_LEADCAREREL");

                entity.Property(e => e.PtntMaidenname)
                    .HasColumnName("PTNT_MAIDENNAME")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntMaidennameupper)
                    .HasColumnName("PTNT_MAIDENNAMEUPPER")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntMasterPtntId).HasColumnName("PTNT_MASTER_PTNT_ID");

                entity.Property(e => e.PtntMathapu)
                    .HasColumnName("PTNT_MATHAPU")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntMatheritage)
                    .HasColumnName("PTNT_MATHERITAGE")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntMemberid)
                    .HasColumnName("PTNT_MEMBERID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PtntMeshblock)
                    .HasColumnName("PTNT_MESHBLOCK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PtntMiddleinitial)
                    .HasColumnName("PTNT_MIDDLEINITIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PtntMpi)
                    .HasColumnName("PTNT_MPI")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PtntNamesuffix).HasColumnName("PTNT_NAMESUFFIX");

                entity.Property(e => e.PtntNationalnum)
                    .HasColumnName("PTNT_NATIONALNUM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PtntNationalnumExpiry)
                    .HasColumnName("PTNT_NATIONALNUM_EXPIRY")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntNationalnumSystem)
                    .HasColumnName("PTNT_NATIONALNUM_SYSTEM")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PtntNotableperson).HasColumnName("PTNT_NOTABLEPERSON");

                entity.Property(e => e.PtntObstetricHxOid).HasColumnName("PTNT_OBSTETRIC_HX_OID");

                entity.Property(e => e.PtntOccupation)
                    .HasColumnName("PTNT_OCCUPATION")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntOnlineEligibility).HasColumnName("PTNT_ONLINE_ELIGIBILITY");

                entity.Property(e => e.PtntOptOutSharing).HasColumnName("PTNT_OPT_OUT_SHARING");

                entity.Property(e => e.PtntOrgId).HasColumnName("PTNT_ORG_ID");

                entity.Property(e => e.PtntOtherphone)
                    .HasColumnName("PTNT_OTHERPHONE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PtntParent1).HasColumnName("PTNT_PARENT1");

                entity.Property(e => e.PtntParent1rel).HasColumnName("PTNT_PARENT1REL");

                entity.Property(e => e.PtntParent2).HasColumnName("PTNT_PARENT2");

                entity.Property(e => e.PtntParent2rel).HasColumnName("PTNT_PARENT2REL");

                entity.Property(e => e.PtntPasstoinsurer).HasColumnName("PTNT_PASSTOINSURER");

                entity.Property(e => e.PtntPasthxOid).HasColumnName("PTNT_PASTHX_OID");

                entity.Property(e => e.PtntPathapu)
                    .HasColumnName("PTNT_PATHAPU")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPatheritage)
                    .HasColumnName("PTNT_PATHERITAGE")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPatientcode)
                    .HasColumnName("PTNT_PATIENTCODE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPatientcodesort)
                    .HasColumnName("PTNT_PATIENTCODESORT")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPayerId).HasColumnName("PTNT_PAYER_ID");

                entity.Property(e => e.PtntPersonalotherphone)
                    .HasColumnName("PTNT_PERSONALOTHERPHONE")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPlaceofbirth)
                    .HasColumnName("PTNT_PLACEOFBIRTH")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPosid).HasColumnName("PTNT_POSID");

                entity.Property(e => e.PtntPostCountry).HasColumnName("PTNT_POST_COUNTRY");

                entity.Property(e => e.PtntPostal1)
                    .HasColumnName("PTNT_POSTAL1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPostal2)
                    .HasColumnName("PTNT_POSTAL2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPostal3)
                    .HasColumnName("PTNT_POSTAL3")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPostalcode)
                    .HasColumnName("PTNT_POSTALCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPostalstate).HasColumnName("PTNT_POSTALSTATE");

                entity.Property(e => e.PtntPreferredEmailId).HasColumnName("PTNT_PREFERRED_EMAIL_ID");

                entity.Property(e => e.PtntPreferredEmailType)
                    .HasColumnName("PTNT_PREFERRED_EMAIL_TYPE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PtntPreferredPhoneId).HasColumnName("PTNT_PREFERRED_PHONE_ID");

                entity.Property(e => e.PtntPreferredPhoneType)
                    .HasColumnName("PTNT_PREFERRED_PHONE_TYPE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PtntPreferrednotifymethod).HasColumnName("PTNT_PREFERREDNOTIFYMETHOD");

                entity.Property(e => e.PtntPrefname)
                    .HasColumnName("PTNT_PREFNAME")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPrefnameupper)
                    .HasColumnName("PTNT_PREFNAMEUPPER")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PtntPrivacyid).HasColumnName("PTNT_PRIVACYID");

                entity.Property(e => e.PtntQuintile)
                    .HasColumnName("PTNT_QUINTILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PtntRegistered).HasColumnName("PTNT_REGISTERED");

                entity.Property(e => e.PtntResident).HasColumnName("PTNT_RESIDENT");

                entity.Property(e => e.PtntSenddischarge).HasColumnName("PTNT_SENDDISCHARGE");

                entity.Property(e => e.PtntSex)
                    .HasColumnName("PTNT_SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PtntShcdIdIwi).HasColumnName("PTNT_SHCD_ID_IWI");

                entity.Property(e => e.PtntShouldalwaysreconcile).HasColumnName("PTNT_SHOULDALWAYSRECONCILE");

                entity.Property(e => e.PtntShouldholdaccount).HasColumnName("PTNT_SHOULDHOLDACCOUNT");

                entity.Property(e => e.PtntShowintotals).HasColumnName("PTNT_SHOWINTOTALS");

                entity.Property(e => e.PtntSocialhxOid).HasColumnName("PTNT_SOCIALHX_OID");

                entity.Property(e => e.PtntSocialhxSrcProviderid).HasColumnName("PTNT_SOCIALHX_SRC_PROVIDERID");

                entity.Property(e => e.PtntSoundexFirstname)
                    .HasColumnName("PTNT_SOUNDEX_FIRSTNAME")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PtntSoundexSurname)
                    .HasColumnName("PTNT_SOUNDEX_SURNAME")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PtntSourceref)
                    .HasColumnName("PTNT_SOURCEREF")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PtntSrcProviderid).HasColumnName("PTNT_SRC_PROVIDERID");

                entity.Property(e => e.PtntStatus).HasColumnName("PTNT_STATUS");

                entity.Property(e => e.PtntStatusChanged)
                    .HasColumnName("PTNT_STATUS_CHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntStreet1)
                    .HasColumnName("PTNT_STREET1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntStreet2)
                    .HasColumnName("PTNT_STREET2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntStreet3)
                    .HasColumnName("PTNT_STREET3")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntStreetCountry).HasColumnName("PTNT_STREET_COUNTRY");

                entity.Property(e => e.PtntStreetcode)
                    .HasColumnName("PTNT_STREETCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PtntStreetstate).HasColumnName("PTNT_STREETSTATE");

                entity.Property(e => e.PtntSurname)
                    .HasColumnName("PTNT_SURNAME")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntSurnameupper)
                    .HasColumnName("PTNT_SURNAMEUPPER")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntTitle)
                    .HasColumnName("PTNT_TITLE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PtntTlaName)
                    .HasColumnName("PTNT_TLA_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PtntTpaId).HasColumnName("PTNT_TPA_ID");

                entity.Property(e => e.PtntTransferStatus).HasColumnName("PTNT_TRANSFER_STATUS");

                entity.Property(e => e.PtntTransferStatusChangedBy).HasColumnName("PTNT_TRANSFER_STATUS_CHANGED_BY");

                entity.Property(e => e.PtntTransferStatusChangedOn)
                    .HasColumnName("PTNT_TRANSFER_STATUS_CHANGED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntType).HasColumnName("PTNT_TYPE");

                entity.Property(e => e.PtntUser1)
                    .HasColumnName("PTNT_USER1")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntUser2)
                    .HasColumnName("PTNT_USER2")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntUser3)
                    .HasColumnName("PTNT_USER3")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntUser4)
                    .HasColumnName("PTNT_USER4")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntUser5)
                    .HasColumnName("PTNT_USER5")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntUsestreetpostal).HasColumnName("PTNT_USESTREETPOSTAL");

                entity.Property(e => e.PtntUsualpaymentmethod).HasColumnName("PTNT_USUALPAYMENTMETHOD");

                entity.Property(e => e.PtntVersioncode)
                    .HasColumnName("PTNT_VERSIONCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWebPasswordHash)
                    .HasColumnName("PTNT_WEB_PASSWORD_HASH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWebenable).HasColumnName("PTNT_WEBENABLE");

                entity.Property(e => e.PtntWeblastvisit)
                    .HasColumnName("PTNT_WEBLASTVISIT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtntWebpassword)
                    .HasColumnName("PTNT_WEBPASSWORD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWebprofileid).HasColumnName("PTNT_WEBPROFILEID");

                entity.Property(e => e.PtntWebusername)
                    .HasColumnName("PTNT_WEBUSERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWork1)
                    .HasColumnName("PTNT_WORK1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWork2)
                    .HasColumnName("PTNT_WORK2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWork3)
                    .HasColumnName("PTNT_WORK3")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWorkCountry).HasColumnName("PTNT_WORK_COUNTRY");

                entity.Property(e => e.PtntWorkcode)
                    .HasColumnName("PTNT_WORKCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWorkname)
                    .HasColumnName("PTNT_WORKNAME")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWorkphone)
                    .HasColumnName("PTNT_WORKPHONE")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PtntWorkstate).HasColumnName("PTNT_WORKSTATE");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("REG_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Residency)
                    .HasColumnName("RESIDENCY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sealed).HasColumnName("SEALED");

                entity.Property(e => e.ShcdIdBenefittype).HasColumnName("SHCD_ID_BENEFITTYPE");

                entity.Property(e => e.ShcdIdHealthstatus).HasColumnName("SHCD_ID_HEALTHSTATUS");

                entity.Property(e => e.ShcdIdHomelanguage).HasColumnName("SHCD_ID_HOMELANGUAGE");

                entity.Property(e => e.ShcdIdJournals).HasColumnName("SHCD_ID_JOURNALS");

                entity.Property(e => e.ShcdIdLivingsituation).HasColumnName("SHCD_ID_LIVINGSITUATION");

                entity.Property(e => e.ShcdIdPlan).HasColumnName("SHCD_ID_PLAN");

                entity.Property(e => e.ShcdIdPreflanguage).HasColumnName("SHCD_ID_PREFLANGUAGE");

                entity.Property(e => e.ShcdIdServicecategory).HasColumnName("SHCD_ID_SERVICECATEGORY");

                entity.Property(e => e.ShcdIdServicediscount).HasColumnName("SHCD_ID_SERVICEDISCOUNT");

                entity.Property(e => e.ShcdIdServicerate).HasColumnName("SHCD_ID_SERVICERATE");

                entity.Property(e => e.ShcdIdTargettype).HasColumnName("SHCD_ID_TARGETTYPE");

                entity.Property(e => e.ShowAcknowledgment).HasColumnName("SHOW_ACKNOWLEDGMENT");

                entity.Property(e => e.StreetAddressUnknown).HasColumnName("STREET_ADDRESS_UNKNOWN");

                entity.Property(e => e.UsualPayerType).HasColumnName("USUAL_PAYER_TYPE");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.PatientCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("PATIENT_FK_CREATEDBY");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.PatientDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("PATIENT_FK_DELETEDBY");

                entity.HasOne(d => d.LklsIdEthnicityNavigation)
                    .WithMany(p => p.PatientLklsIdEthnicityNavigation)
                    .HasForeignKey(d => d.LklsIdEthnicity)
                    .HasConstraintName("FOREIGN_LKLS_ID_ETHNICITY");

                entity.HasOne(d => d.LklsIdEthnicity2Navigation)
                    .WithMany(p => p.PatientLklsIdEthnicity2Navigation)
                    .HasForeignKey(d => d.LklsIdEthnicity2)
                    .HasConstraintName("PATIENT_FK_LKLS_ID_ETHNICIT2");

                entity.HasOne(d => d.LklsIdEthnicity3Navigation)
                    .WithMany(p => p.PatientLklsIdEthnicity3Navigation)
                    .HasForeignKey(d => d.LklsIdEthnicity3)
                    .HasConstraintName("PATIENT_FK_LKLS_ID_ETHNICIT3");

                entity.HasOne(d => d.LklsIdEthnicity4Navigation)
                    .WithMany(p => p.PatientLklsIdEthnicity4Navigation)
                    .HasForeignKey(d => d.LklsIdEthnicity4)
                    .HasConstraintName("PATIENT_FK_ETHNICITY4");

                entity.HasOne(d => d.LklsIdEthnicity5Navigation)
                    .WithMany(p => p.PatientLklsIdEthnicity5Navigation)
                    .HasForeignKey(d => d.LklsIdEthnicity5)
                    .HasConstraintName("PATIENT_FK_ETHNICITY5");

                entity.HasOne(d => d.LklsIdEthnicity6Navigation)
                    .WithMany(p => p.PatientLklsIdEthnicity6Navigation)
                    .HasForeignKey(d => d.LklsIdEthnicity6)
                    .HasConstraintName("PATIENT_FK_ETHNICITY6");

                entity.HasOne(d => d.LklsIdMaritalstatusNavigation)
                    .WithMany(p => p.PatientLklsIdMaritalstatusNavigation)
                    .HasForeignKey(d => d.LklsIdMaritalstatus)
                    .HasConstraintName("FOREIGN_LKLS_ID_MARITALSTATU");

                entity.HasOne(d => d.LklsIdOccupationNavigation)
                    .WithMany(p => p.PatientLklsIdOccupationNavigation)
                    .HasForeignKey(d => d.LklsIdOccupation)
                    .HasConstraintName("FOREIGN_LKLS_ID_OCCUPATION");

                entity.HasOne(d => d.LklsIdReligionNavigation)
                    .WithMany(p => p.PatientLklsIdReligionNavigation)
                    .HasForeignKey(d => d.LklsIdReligion)
                    .HasConstraintName("FOREIGN_LKLS_ID_RELIGION");

                entity.HasOne(d => d.PppuIdAltdrNavigation)
                    .WithMany(p => p.PatientPppuIdAltdrNavigation)
                    .HasForeignKey(d => d.PppuIdAltdr)
                    .HasConstraintName("FOREIGN_PPPU_ID_ALTDR");

                entity.HasOne(d => d.PppuIdUsualdrNavigation)
                    .WithMany(p => p.PatientPppuIdUsualdrNavigation)
                    .HasForeignKey(d => d.PppuIdUsualdr)
                    .HasConstraintName("FOREIGN_PPPU_ID_USUALDR");

                entity.HasOne(d => d.PtntDeletedUser)
                    .WithMany(p => p.PatientPtntDeletedUser)
                    .HasForeignKey(d => d.PtntDeletedUserid)
                    .HasConstraintName("FK_PTNT_DELETED_USERID");

                entity.HasOne(d => d.PtntEmployer)
                    .WithMany(p => p.InversePtntEmployer)
                    .HasForeignKey(d => d.PtntEmployerId)
                    .HasConstraintName("PTNT_FK_EMPLOYER_ID");

                entity.HasOne(d => d.PtntFamilyhxO)
                    .WithMany(p => p.PatientPtntFamilyhxO)
                    .HasForeignKey(d => d.PtntFamilyhxOid)
                    .HasConstraintName("PATIENT_FK_PTNT_FAMILYHX_OID");

                entity.HasOne(d => d.PtntIdGuarantorNavigation)
                    .WithMany(p => p.InversePtntIdGuarantorNavigation)
                    .HasForeignKey(d => d.PtntIdGuarantor)
                    .HasConstraintName("FOREIGN_PTNT_ID_GUARANTOR");

                entity.HasOne(d => d.PtntIdInsurerNavigation)
                    .WithMany(p => p.InversePtntIdInsurerNavigation)
                    .HasForeignKey(d => d.PtntIdInsurer)
                    .HasConstraintName("PTNT_FOREIGN_INSURER");

                entity.HasOne(d => d.PtntIdPartnerNavigation)
                    .WithMany(p => p.InversePtntIdPartnerNavigation)
                    .HasForeignKey(d => d.PtntIdPartner)
                    .HasConstraintName("FOREIGN_PTNT_ID_PARTNER");

                entity.HasOne(d => d.PtntLeadcaregiverNavigation)
                    .WithMany(p => p.InversePtntLeadcaregiverNavigation)
                    .HasForeignKey(d => d.PtntLeadcaregiver)
                    .HasConstraintName("PATIENT_FK_LEADCAREGIVER");

                entity.HasOne(d => d.PtntLeadcarerelNavigation)
                    .WithMany(p => p.PatientPtntLeadcarerelNavigation)
                    .HasForeignKey(d => d.PtntLeadcarerel)
                    .HasConstraintName("FK_PAT_LEADCARE_REL");

                entity.HasOne(d => d.PtntMasterPtnt)
                    .WithMany(p => p.InversePtntMasterPtnt)
                    .HasForeignKey(d => d.PtntMasterPtntId)
                    .HasConstraintName("FK_PTNT_MASTER_PTNT_ID");

                entity.HasOne(d => d.PtntNamesuffixNavigation)
                    .WithMany(p => p.PatientPtntNamesuffixNavigation)
                    .HasForeignKey(d => d.PtntNamesuffix)
                    .HasConstraintName("FK_PTNT_NAMESUFFIX_SHORTCODE");

                entity.HasOne(d => d.PtntObstetricHxO)
                    .WithMany(p => p.PatientPtntObstetricHxO)
                    .HasForeignKey(d => d.PtntObstetricHxOid)
                    .HasConstraintName("PATIENT_FK_PTNT_OBSTETRIC_HX");

                entity.HasOne(d => d.PtntOrg)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.PtntOrgId)
                    .HasConstraintName("FK_PATIENT_ORG_ID");

                entity.HasOne(d => d.PtntParent1Navigation)
                    .WithMany(p => p.InversePtntParent1Navigation)
                    .HasForeignKey(d => d.PtntParent1)
                    .HasConstraintName("FK_PATIENT_PARENT1");

                entity.HasOne(d => d.PtntParent1relNavigation)
                    .WithMany(p => p.PatientPtntParent1relNavigation)
                    .HasForeignKey(d => d.PtntParent1rel)
                    .HasConstraintName("FK_PAT_PARENT1_REL");

                entity.HasOne(d => d.PtntParent2Navigation)
                    .WithMany(p => p.InversePtntParent2Navigation)
                    .HasForeignKey(d => d.PtntParent2)
                    .HasConstraintName("FK_PATIENT_PARENT2");

                entity.HasOne(d => d.PtntParent2relNavigation)
                    .WithMany(p => p.PatientPtntParent2relNavigation)
                    .HasForeignKey(d => d.PtntParent2rel)
                    .HasConstraintName("FK_PAT_PARENT2_REL");

                entity.HasOne(d => d.PtntPasthxO)
                    .WithMany(p => p.PatientPtntPasthxO)
                    .HasForeignKey(d => d.PtntPasthxOid)
                    .HasConstraintName("PATIENT_FK_PTNT_PASTHX_OID");

                entity.HasOne(d => d.PtntPayer)
                    .WithMany(p => p.InversePtntPayer)
                    .HasForeignKey(d => d.PtntPayerId)
                    .HasConstraintName("PATIENT_FK_PAYER_ID");

                entity.HasOne(d => d.PtntPostalstateNavigation)
                    .WithMany(p => p.PatientPtntPostalstateNavigation)
                    .HasForeignKey(d => d.PtntPostalstate)
                    .HasConstraintName("PATIENT_FK_PTNT_POSTALSTATE");

                entity.HasOne(d => d.PtntSocialhxO)
                    .WithMany(p => p.PatientPtntSocialhxO)
                    .HasForeignKey(d => d.PtntSocialhxOid)
                    .HasConstraintName("PATIENT_FK_PTNT_SOCIALHX_OID");

                entity.HasOne(d => d.PtntSocialhxSrcProvider)
                    .WithMany(p => p.PatientPtntSocialhxSrcProvider)
                    .HasForeignKey(d => d.PtntSocialhxSrcProviderid)
                    .HasConstraintName("FK_PPPU_SOCLHX_SRC_PROVIDERID");

                entity.HasOne(d => d.PtntSrcProvider)
                    .WithMany(p => p.PatientPtntSrcProvider)
                    .HasForeignKey(d => d.PtntSrcProviderid)
                    .HasConstraintName("FK_PPPU_PTNT_SRC_PROVIDERID");

                entity.HasOne(d => d.PtntStreetstateNavigation)
                    .WithMany(p => p.PatientPtntStreetstateNavigation)
                    .HasForeignKey(d => d.PtntStreetstate)
                    .HasConstraintName("PATIENT_FK_PTNT_STREETSTATE");

                entity.HasOne(d => d.PtntTransferStatusChangedByNavigation)
                    .WithMany(p => p.PatientPtntTransferStatusChangedByNavigation)
                    .HasForeignKey(d => d.PtntTransferStatusChangedBy)
                    .HasConstraintName("PATIENT_FK_TRANSFER_CHANGED_BY");

                entity.HasOne(d => d.PtntWorkstateNavigation)
                    .WithMany(p => p.PatientPtntWorkstateNavigation)
                    .HasForeignKey(d => d.PtntWorkstate)
                    .HasConstraintName("PATIENT_FK_PTNT_WORKSTATE");

                entity.HasOne(d => d.ShcdIdBenefittypeNavigation)
                    .WithMany(p => p.PatientShcdIdBenefittypeNavigation)
                    .HasForeignKey(d => d.ShcdIdBenefittype)
                    .HasConstraintName("FK_PTNT_BEN_TP_SHCD_ID");

                entity.HasOne(d => d.ShcdIdHealthstatusNavigation)
                    .WithMany(p => p.PatientShcdIdHealthstatusNavigation)
                    .HasForeignKey(d => d.ShcdIdHealthstatus)
                    .HasConstraintName("FK_PTNT_HEAL_ST_SHCD_ID");

                entity.HasOne(d => d.ShcdIdHomelanguageNavigation)
                    .WithMany(p => p.PatientShcdIdHomelanguageNavigation)
                    .HasForeignKey(d => d.ShcdIdHomelanguage)
                    .HasConstraintName("PATIENT_FK_SHCD_ID_HOMELANGU");

                entity.HasOne(d => d.ShcdIdJournalsNavigation)
                    .WithMany(p => p.PatientShcdIdJournalsNavigation)
                    .HasForeignKey(d => d.ShcdIdJournals)
                    .HasConstraintName("PATIENT_FK_SHCD_ID_JOURNALS");

                entity.HasOne(d => d.ShcdIdLivingsituationNavigation)
                    .WithMany(p => p.PatientShcdIdLivingsituationNavigation)
                    .HasForeignKey(d => d.ShcdIdLivingsituation)
                    .HasConstraintName("FK_PTNT_LIV_SIT_SHCD_ID");

                entity.HasOne(d => d.ShcdIdPlanNavigation)
                    .WithMany(p => p.PatientShcdIdPlanNavigation)
                    .HasForeignKey(d => d.ShcdIdPlan)
                    .HasConstraintName("PTNT_FOREIGN_PLAN");

                entity.HasOne(d => d.ShcdIdPreflanguageNavigation)
                    .WithMany(p => p.PatientShcdIdPreflanguageNavigation)
                    .HasForeignKey(d => d.ShcdIdPreflanguage)
                    .HasConstraintName("PATIENT_FK_SHCD_ID_PREFLANGU");

                entity.HasOne(d => d.ShcdIdServicecategoryNavigation)
                    .WithMany(p => p.PatientShcdIdServicecategoryNavigation)
                    .HasForeignKey(d => d.ShcdIdServicecategory)
                    .HasConstraintName("FK_PTNT_SER_CAT_SHCD_ID");

                entity.HasOne(d => d.ShcdIdServicediscountNavigation)
                    .WithMany(p => p.PatientShcdIdServicediscountNavigation)
                    .HasForeignKey(d => d.ShcdIdServicediscount)
                    .HasConstraintName("PTNT_FOREIGN_SERVICEDISCOUNT");

                entity.HasOne(d => d.ShcdIdServicerateNavigation)
                    .WithMany(p => p.PatientShcdIdServicerateNavigation)
                    .HasForeignKey(d => d.ShcdIdServicerate)
                    .HasConstraintName("PTNT_FOREIGN_SERVICERATE");

                entity.HasOne(d => d.ShcdIdTargettypeNavigation)
                    .WithMany(p => p.PatientShcdIdTargettypeNavigation)
                    .HasForeignKey(d => d.ShcdIdTargettype)
                    .HasConstraintName("FK_PTNT_TRG_TP_SHCD_ID");
            });

            modelBuilder.Entity<PatientAlternatName>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PATIENT_ALTERNAT_NAME");

                entity.HasIndex(e => e.Createdby)
                    .HasName("FK_PTALTNAME_CREATEDBY");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("FK_PTALTNAME_DELETEDBY");

                entity.HasIndex(e => e.MasterId)
                    .HasName("PTAN_PTAN_FK_MASTER");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PATIENT_ALTERNAT_NA");

                entity.HasIndex(e => e.PtanPtntId)
                    .HasName("PAT_ALTERNAT_NAME_PATIENT_FK");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PtanName)
                    .HasColumnName("PTAN_NAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtanNameupper)
                    .HasColumnName("PTAN_NAMEUPPER")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PtanPtntId).HasColumnName("PTAN_PTNT_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.PatientAlternatNameCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("FK_PTALTNAME_CREATEDBY");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.PatientAlternatNameDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("FK_PTALTNAME_DELETEDBY");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.InverseMaster)
                    .HasForeignKey(d => d.MasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PTAN_PTAN_FK_MASTER");

                entity.HasOne(d => d.PtanPtnt)
                    .WithMany(p => p.PatientAlternatName)
                    .HasForeignKey(d => d.PtanPtntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PAT_ALTERNAT_NAME_PATIENT_FK");
            });

            modelBuilder.Entity<PatientAudit>(entity =>
            {
                entity.HasKey(e => e.PaudtId);

                entity.ToTable("PATIENT_AUDIT");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PATIENT_AUDIT");

                entity.HasIndex(e => e.ObserverPtntId)
                    .HasName("FK_PAUDIT_OBSPTNTID");

                entity.HasIndex(e => e.PaudtPppuId)
                    .HasName("PATIENT_AUDIT_FK_PPPU_ID");

                entity.HasIndex(e => e.PaudtPtntId)
                    .HasName("PATIENT_AUDIT_FK_PTNT_ID");

                entity.Property(e => e.PaudtId)
                    .HasColumnName("PAUDT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.ObserverPtntId).HasColumnName("OBSERVER_PTNT_ID");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PaudtComputername)
                    .HasColumnName("PAUDT_COMPUTERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaudtEndDatetime)
                    .HasColumnName("PAUDT_END_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaudtIp)
                    .HasColumnName("PAUDT_IP")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.PaudtPppuId).HasColumnName("PAUDT_PPPU_ID");

                entity.Property(e => e.PaudtPtntId).HasColumnName("PAUDT_PTNT_ID");

                entity.Property(e => e.PaudtStartDatetime)
                    .HasColumnName("PAUDT_START_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserText)
                    .HasColumnName("USER_TEXT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ObserverPtnt)
                    .WithMany(p => p.PatientAuditObserverPtnt)
                    .HasForeignKey(d => d.ObserverPtntId)
                    .HasConstraintName("FK_PAUDIT_OBSPTNTID");

                entity.HasOne(d => d.PaudtPppu)
                    .WithMany(p => p.PatientAudit)
                    .HasForeignKey(d => d.PaudtPppuId)
                    .HasConstraintName("PATIENT_AUDIT_FK_PPPU_ID");

                entity.HasOne(d => d.PaudtPtnt)
                    .WithMany(p => p.PatientAuditPaudtPtnt)
                    .HasForeignKey(d => d.PaudtPtntId)
                    .HasConstraintName("PATIENT_AUDIT_FK_PTNT_ID");
            });

            modelBuilder.Entity<PatientGrp>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PATIENT_GRP");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PATIENT_GRP");

                entity.HasIndex(e => e.PppuId)
                    .HasName("PATIENT_GRP_FK_PPPU");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrpFromdate)
                    .HasColumnName("GRP_FROMDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrpRange).HasColumnName("GRP_RANGE");

                entity.Property(e => e.GrpTodate)
                    .HasColumnName("GRP_TODATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PppuId).HasColumnName("PPPU_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pppu)
                    .WithMany(p => p.PatientGrp)
                    .HasForeignKey(d => d.PppuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PATIENT_GRP_FK_PPPU");
            });

            modelBuilder.Entity<PatientInfoAudit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PATIENT_INFO_AUDIT");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PATIENT_INFO_AUDIT");

                entity.HasIndex(e => e.ObserverPtntId)
                    .HasName("FK_PIAUDIT_OBSPTNTID");

                entity.HasIndex(e => e.PiaudPppuId)
                    .HasName("FK_PAT_INFO_AUDIT_PPPU");

                entity.HasIndex(e => e.PiaudPtntId)
                    .HasName("FK_PAT_INFO_AUDIT_PTNT");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.ObserverPtntId).HasColumnName("OBSERVER_PTNT_ID");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PiaudComputername)
                    .HasColumnName("PIAUD_COMPUTERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PiaudEndDatetime)
                    .HasColumnName("PIAUD_END_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.PiaudIp)
                    .HasColumnName("PIAUD_IP")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.PiaudPppuId).HasColumnName("PIAUD_PPPU_ID");

                entity.Property(e => e.PiaudPtntId).HasColumnName("PIAUD_PTNT_ID");

                entity.Property(e => e.PiaudStartDatetime)
                    .HasColumnName("PIAUD_START_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserText)
                    .HasColumnName("USER_TEXT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ObserverPtnt)
                    .WithMany(p => p.PatientInfoAuditObserverPtnt)
                    .HasForeignKey(d => d.ObserverPtntId)
                    .HasConstraintName("FK_PIAUDIT_OBSPTNTID");

                entity.HasOne(d => d.PiaudPppu)
                    .WithMany(p => p.PatientInfoAudit)
                    .HasForeignKey(d => d.PiaudPppuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_INFO_AUDIT_PPPU");

                entity.HasOne(d => d.PiaudPtnt)
                    .WithMany(p => p.PatientInfoAuditPiaudPtnt)
                    .HasForeignKey(d => d.PiaudPtntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_INFO_AUDIT_PTNT");
            });

            modelBuilder.Entity<PatientInfoAuditDetails>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PATIENT_INFO_AUDIT_DETAILS");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PATIENT_INFO_AUDIT_");

                entity.HasIndex(e => e.PiadAuditId)
                    .HasName("FK_PIAD_AUDIT_ID");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PiadAlertdate)
                    .HasColumnName("PIAD_ALERTDATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PiadAuditId).HasColumnName("PIAD_AUDIT_ID");

                entity.Property(e => e.PiadDescription)
                    .HasColumnName("PIAD_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PiadType).HasColumnName("PIAD_TYPE");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.PiadAudit)
                    .WithMany(p => p.PatientInfoAuditDetails)
                    .HasForeignKey(d => d.PiadAuditId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIAD_AUDIT_ID");
            });

            modelBuilder.Entity<PatientMergeLog>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PATIENT_MERGE_LOG");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("PTNT_MERGE_LOG_FK_CREATED_BY");

                entity.HasIndex(e => e.Masterid)
                    .HasName("PATIENT_MERGE_LOG_FK_MASTERID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PATIENT_MERGE_LOG");

                entity.HasIndex(e => e.Subid)
                    .HasName("PATIENT_MERGE_LOG_FK_SUBID");

                entity.HasIndex(e => new { e.Masterid, e.CreatedOn })
                    .HasName("PTNT_MERGE_LOG_IND1");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Masterid).HasColumnName("MASTERID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Subid).HasColumnName("SUBID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatientMergeLog)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PTNT_MERGE_LOG_FK_CREATED_BY");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.PatientMergeLogMaster)
                    .HasForeignKey(d => d.Masterid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PATIENT_MERGE_LOG_FK_MASTERID");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.PatientMergeLogSub)
                    .HasForeignKey(d => d.Subid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PATIENT_MERGE_LOG_FK_SUBID");
            });

            modelBuilder.Entity<Patientproblem>(entity =>
            {
                entity.HasKey(e => e.PaprId);

                entity.ToTable("PATIENTPROBLEM");

                entity.HasIndex(e => e.CaseId)
                    .HasName("PATPROB_CASE_ID_FK_BCASE");

                entity.HasIndex(e => e.Closedby)
                    .HasName("FK_PPR_CLOSEDBY");

                entity.HasIndex(e => e.Code)
                    .HasName("I_PATIENTPROBLEM_CODE");

                entity.HasIndex(e => e.Createdby)
                    .HasName("PATIENTPROBLEM_FK_CREATEDBY");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("PATIENTPROBLEM_FK_DELETEDBY");

                entity.HasIndex(e => e.ExprId)
                    .HasName("PAPR_FOREIGN_EXPR_ID");

                entity.HasIndex(e => e.ExternalEntityId)
                    .HasName("FK_PTNTPRBL_EXTERNAL_ENTITY_ID");

                entity.HasIndex(e => e.IndicationId)
                    .HasName("FK_PROBLEM_INDICATION");

                entity.HasIndex(e => e.LifeStageFromId)
                    .HasName("FK_PTNTPRBL_LFSTG_FROM");

                entity.HasIndex(e => e.LifeStageIndicationId)
                    .HasName("FK_PTNTPRBL_LFSTG_IND");

                entity.HasIndex(e => e.LifeStageToId)
                    .HasName("FK_PTNTPRBL_LFSTG_TO");

                entity.HasIndex(e => e.PaprAlertorganisation)
                    .HasName("FK_PATIENTPROBLEM_ORGSTRUCTU");

                entity.HasIndex(e => e.PaprAnatomyId)
                    .HasName("PAPR_ANATOMY_ID_FK");

                entity.HasIndex(e => e.PaprCasealerttype)
                    .HasName("PAPR_IND_CASEALERT_FK");

                entity.HasIndex(e => e.PaprCoMorbidTo)
                    .HasName("FK_PAPR_CO_MORBID_TO");

                entity.HasIndex(e => e.PaprDxid)
                    .HasName("PAPR_FOREIGN_DX_ID");

                entity.HasIndex(e => e.PaprDxnature)
                    .HasName("PATPROB_FK_DXNATURE");

                entity.HasIndex(e => e.PaprLocationId)
                    .HasName("PAPR_LOCATION_ID_FK");

                entity.HasIndex(e => e.PaprOutcomeid)
                    .HasName("PATPROB_OUTCOMEID_FK_SHORTCO");

                entity.HasIndex(e => e.PaprPppuidadded)
                    .HasName("PAPR_FOREIGN_PPPUID_ADDED");

                entity.HasIndex(e => e.PaprPppuidaltered)
                    .HasName("PAPR_FOREIGN_PPPUID_ALTERED");

                entity.HasIndex(e => e.PaprPrivateToPos)
                    .HasName("PATIENTPROBLEM_FK_PRV_POS");

                entity.HasIndex(e => e.PaprProviderId)
                    .HasName("PAPR_FOREIGN_PROVIDER_ID");

                entity.HasIndex(e => e.PaprServiceId)
                    .HasName("FK_PATIENTPROBLEM_SERVICE");

                entity.HasIndex(e => e.PaprSourceref)
                    .HasName("I_PAPR_SOURCEREF");

                entity.HasIndex(e => e.PrivacyPppuId)
                    .HasName("PATIENTPROBLEM_FK_PPPU");

                entity.HasIndex(e => e.PtntId)
                    .HasName("PAPR_FOREIGN_PTNT_ID");

                entity.HasIndex(e => e.ReferralId)
                    .HasName("FK_PROBLEM_REFERRAL");

                entity.HasIndex(e => e.RoleOid)
                    .HasName("PAPR_FK_ROLE_OID");

                entity.HasIndex(e => new { e.ObjGuid, e.PaprDeletedid, e.PartitionId })
                    .HasName("I_PATIENTPROBLEM_GUID")
                    .IsUnique();

                entity.Property(e => e.PaprId)
                    .HasColumnName("PAPR_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApproxIndicationDate)
                    .HasColumnName("APPROX_INDICATION_DATE")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.ClosedDatetime)
                    .HasColumnName("CLOSED_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Closedby).HasColumnName("CLOSEDBY");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExprId).HasColumnName("EXPR_ID");

                entity.Property(e => e.ExternalEntityId).HasColumnName("EXTERNAL_ENTITY_ID");

                entity.Property(e => e.FromMode).HasColumnName("FROM_MODE");

                entity.Property(e => e.IndicationDate)
                    .HasColumnName("INDICATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IndicationDescr)
                    .HasColumnName("INDICATION_DESCR")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IndicationId).HasColumnName("INDICATION_ID");

                entity.Property(e => e.IndicationMode).HasColumnName("INDICATION_MODE");

                entity.Property(e => e.IsApproxIndicationDate).HasColumnName("IS_APPROX_INDICATION_DATE");

                entity.Property(e => e.LifeStageFromId).HasColumnName("LIFE_STAGE_FROM_ID");

                entity.Property(e => e.LifeStageIndicationId).HasColumnName("LIFE_STAGE_INDICATION_ID");

                entity.Property(e => e.LifeStageToId).HasColumnName("LIFE_STAGE_TO_ID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PaprAlert).HasColumnName("PAPR_ALERT");

                entity.Property(e => e.PaprAlertorganisation).HasColumnName("PAPR_ALERTORGANISATION");

                entity.Property(e => e.PaprAlerts)
                    .HasColumnName("PAPR_ALERTS")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PaprAlertscope).HasColumnName("PAPR_ALERTSCOPE");

                entity.Property(e => e.PaprAnatomyId).HasColumnName("PAPR_ANATOMY_ID");

                entity.Property(e => e.PaprApproxdatetext)
                    .HasColumnName("PAPR_APPROXDATETEXT")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PaprApproxtodatetext)
                    .HasColumnName("PAPR_APPROXTODATETEXT")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PaprBlockcnotes).HasColumnName("PAPR_BLOCKCNOTES");

                entity.Property(e => e.PaprBlockpatacess).HasColumnName("PAPR_BLOCKPATACESS");

                entity.Property(e => e.PaprCasealertcolor).HasColumnName("PAPR_CASEALERTCOLOR");

                entity.Property(e => e.PaprCasealerttype).HasColumnName("PAPR_CASEALERTTYPE");

                entity.Property(e => e.PaprCoMorbidTo).HasColumnName("PAPR_CO_MORBID_TO");

                entity.Property(e => e.PaprComment2Blob)
                    .HasColumnName("PAPR_COMMENT2_BLOB")
                    .HasColumnType("image");

                entity.Property(e => e.PaprCommentBlob)
                    .HasColumnName("PAPR_COMMENT_BLOB")
                    .HasColumnType("image");

                entity.Property(e => e.PaprConfidenceid).HasColumnName("PAPR_CONFIDENCEID");

                entity.Property(e => e.PaprDate)
                    .HasColumnName("PAPR_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaprDatetimeadded)
                    .HasColumnName("PAPR_DATETIMEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaprDatetimealtered)
                    .HasColumnName("PAPR_DATETIMEALTERED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaprDeletedid).HasColumnName("PAPR_DELETEDID");

                entity.Property(e => e.PaprDxdescription)
                    .HasColumnName("PAPR_DXDESCRIPTION")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PaprDxid).HasColumnName("PAPR_DXID");

                entity.Property(e => e.PaprDxnature).HasColumnName("PAPR_DXNATURE");

                entity.Property(e => e.PaprExtprovname)
                    .HasColumnName("PAPR_EXTPROVNAME")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.PaprHospitalname)
                    .HasColumnName("PAPR_HOSPITALNAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PaprInsyncDisStrmCode)
                    .HasColumnName("PAPR_INSYNC_DIS_STRM_CODE")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaprInsyncValid)
                    .HasColumnName("PAPR_INSYNC_VALID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaprIsapproxdate).HasColumnName("PAPR_ISAPPROXDATE");

                entity.Property(e => e.PaprIsapproxtodate).HasColumnName("PAPR_ISAPPROXTODATE");

                entity.Property(e => e.PaprLocationId).HasColumnName("PAPR_LOCATION_ID");

                entity.Property(e => e.PaprNature)
                    .HasColumnName("PAPR_NATURE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PaprOnsetage).HasColumnName("PAPR_ONSETAGE");

                entity.Property(e => e.PaprOrderWeight)
                    .HasColumnName("PAPR_ORDER_WEIGHT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaprOutcomeid).HasColumnName("PAPR_OUTCOMEID");

                entity.Property(e => e.PaprPppuidadded).HasColumnName("PAPR_PPPUIDADDED");

                entity.Property(e => e.PaprPppuidaltered).HasColumnName("PAPR_PPPUIDALTERED");

                entity.Property(e => e.PaprPresentationId).HasColumnName("PAPR_PRESENTATION_ID");

                entity.Property(e => e.PaprPrincipal).HasColumnName("PAPR_PRINCIPAL");

                entity.Property(e => e.PaprPrivacyid).HasColumnName("PAPR_PRIVACYID");

                entity.Property(e => e.PaprPrivateToPos).HasColumnName("PAPR_PRIVATE_TO_POS");

                entity.Property(e => e.PaprProcedureType)
                    .HasColumnName("PAPR_PROCEDURE_TYPE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaprProviderId).HasColumnName("PAPR_PROVIDER_ID");

                entity.Property(e => e.PaprServiceId).HasColumnName("PAPR_SERVICE_ID");

                entity.Property(e => e.PaprSeverityId).HasColumnName("PAPR_SEVERITY_ID");

                entity.Property(e => e.PaprSourceref)
                    .HasColumnName("PAPR_SOURCEREF")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PaprStatusid).HasColumnName("PAPR_STATUSID");

                entity.Property(e => e.PaprTodate)
                    .HasColumnName("PAPR_TODATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaprTypeid).HasColumnName("PAPR_TYPEID");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PrivacyOrg).HasColumnName("PRIVACY_ORG");

                entity.Property(e => e.PrivacyPppuId).HasColumnName("PRIVACY_PPPU_ID");

                entity.Property(e => e.PtntId).HasColumnName("PTNT_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralId).HasColumnName("REFERRAL_ID");

                entity.Property(e => e.RoleOid).HasColumnName("ROLE_OID");

                entity.Property(e => e.ToMode).HasColumnName("TO_MODE");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.Patientproblem)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("PATPROB_CASE_ID_FK_BCASE");

                entity.HasOne(d => d.ClosedbyNavigation)
                    .WithMany(p => p.PatientproblemClosedbyNavigation)
                    .HasForeignKey(d => d.Closedby)
                    .HasConstraintName("FK_PPR_CLOSEDBY");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.PatientproblemCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("PATIENTPROBLEM_FK_CREATEDBY");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.PatientproblemDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("PATIENTPROBLEM_FK_DELETEDBY");

                entity.HasOne(d => d.Expr)
                    .WithMany(p => p.PatientproblemExpr)
                    .HasForeignKey(d => d.ExprId)
                    .HasConstraintName("PAPR_FOREIGN_EXPR_ID");

                entity.HasOne(d => d.Indication)
                    .WithMany(p => p.PatientproblemIndication)
                    .HasForeignKey(d => d.IndicationId)
                    .HasConstraintName("FK_PROBLEM_INDICATION");

                entity.HasOne(d => d.LifeStageFrom)
                    .WithMany(p => p.PatientproblemLifeStageFrom)
                    .HasForeignKey(d => d.LifeStageFromId)
                    .HasConstraintName("FK_PTNTPRBL_LFSTG_FROM");

                entity.HasOne(d => d.LifeStageIndication)
                    .WithMany(p => p.PatientproblemLifeStageIndication)
                    .HasForeignKey(d => d.LifeStageIndicationId)
                    .HasConstraintName("FK_PTNTPRBL_LFSTG_IND");

                entity.HasOne(d => d.LifeStageTo)
                    .WithMany(p => p.PatientproblemLifeStageTo)
                    .HasForeignKey(d => d.LifeStageToId)
                    .HasConstraintName("FK_PTNTPRBL_LFSTG_TO");

                entity.HasOne(d => d.PaprAlertorganisationNavigation)
                    .WithMany(p => p.Patientproblem)
                    .HasForeignKey(d => d.PaprAlertorganisation)
                    .HasConstraintName("FK_PATIENTPROBLEM_ORGSTRUCTU");

                entity.HasOne(d => d.PaprAnatomy)
                    .WithMany(p => p.PatientproblemPaprAnatomy)
                    .HasForeignKey(d => d.PaprAnatomyId)
                    .HasConstraintName("PAPR_ANATOMY_ID_FK");

                entity.HasOne(d => d.PaprCasealerttypeNavigation)
                    .WithMany(p => p.PatientproblemPaprCasealerttypeNavigation)
                    .HasForeignKey(d => d.PaprCasealerttype)
                    .HasConstraintName("PAPR_IND_CASEALERT_FK");

                entity.HasOne(d => d.PaprCoMorbidToNavigation)
                    .WithMany(p => p.InversePaprCoMorbidToNavigation)
                    .HasForeignKey(d => d.PaprCoMorbidTo)
                    .HasConstraintName("FK_PAPR_CO_MORBID_TO");

                entity.HasOne(d => d.PaprDx)
                    .WithMany(p => p.PatientproblemPaprDx)
                    .HasForeignKey(d => d.PaprDxid)
                    .HasConstraintName("PAPR_FOREIGN_DX_ID");

                entity.HasOne(d => d.PaprDxnatureNavigation)
                    .WithMany(p => p.PatientproblemPaprDxnatureNavigation)
                    .HasForeignKey(d => d.PaprDxnature)
                    .HasConstraintName("PATPROB_FK_DXNATURE");

                entity.HasOne(d => d.PaprLocation)
                    .WithMany(p => p.PatientproblemPaprLocation)
                    .HasForeignKey(d => d.PaprLocationId)
                    .HasConstraintName("PAPR_LOCATION_ID_FK");

                entity.HasOne(d => d.PaprOutcome)
                    .WithMany(p => p.PatientproblemPaprOutcome)
                    .HasForeignKey(d => d.PaprOutcomeid)
                    .HasConstraintName("PATPROB_OUTCOMEID_FK_SHORTCO");

                entity.HasOne(d => d.PaprPppuidaddedNavigation)
                    .WithMany(p => p.PatientproblemPaprPppuidaddedNavigation)
                    .HasForeignKey(d => d.PaprPppuidadded)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PAPR_FOREIGN_PPPUID_ADDED");

                entity.HasOne(d => d.PaprPppuidalteredNavigation)
                    .WithMany(p => p.PatientproblemPaprPppuidalteredNavigation)
                    .HasForeignKey(d => d.PaprPppuidaltered)
                    .HasConstraintName("PAPR_FOREIGN_PPPUID_ALTERED");

                entity.HasOne(d => d.PaprPrivateToPosNavigation)
                    .WithMany(p => p.PatientproblemPaprPrivateToPosNavigation)
                    .HasForeignKey(d => d.PaprPrivateToPos)
                    .HasConstraintName("PATIENTPROBLEM_FK_PRV_POS");

                entity.HasOne(d => d.PaprProvider)
                    .WithMany(p => p.PatientproblemPaprProvider)
                    .HasForeignKey(d => d.PaprProviderId)
                    .HasConstraintName("PAPR_FOREIGN_PROVIDER_ID");

                entity.HasOne(d => d.PrivacyPppu)
                    .WithMany(p => p.PatientproblemPrivacyPppu)
                    .HasForeignKey(d => d.PrivacyPppuId)
                    .HasConstraintName("PATIENTPROBLEM_FK_PPPU");

                entity.HasOne(d => d.Ptnt)
                    .WithMany(p => p.Patientproblem)
                    .HasForeignKey(d => d.PtntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PAPR_FOREIGN_PTNT_ID");

                entity.HasOne(d => d.RoleO)
                    .WithMany(p => p.Patientproblem)
                    .HasForeignKey(d => d.RoleOid)
                    .HasConstraintName("PAPR_FK_ROLE_OID");
            });

            modelBuilder.Entity<Patientrecallvisit>(entity =>
            {
                entity.HasKey(e => e.PrvsId);

                entity.ToTable("PATIENTRECALLVISIT");

                entity.HasIndex(e => e.CarevisitId)
                    .HasName("PTNTRECALLPLAN_FK_RCPV");

                entity.HasIndex(e => e.ContactOid)
                    .HasName("FK_PRVS_CONTACT_OID");

                entity.HasIndex(e => e.Createdby)
                    .HasName("PATRECALLVISIT_FK_CREATEDBY");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("PATRECALLVISIT_FK_DELETEDBY");

                entity.HasIndex(e => e.ExternalEntityId)
                    .HasName("FK_PRVS_EXTERNAL_ENTITY_ID");

                entity.HasIndex(e => e.MasterId)
                    .HasName("PATIENTRECALLVISIT_FK_MASTER");

                entity.HasIndex(e => e.PrivacyPppuId)
                    .HasName("PATIENTRECALLVISIT_FK_PPPU");

                entity.HasIndex(e => e.PrvsCaseId)
                    .HasName("PRVS_FK_CASE_ID");

                entity.HasIndex(e => e.PrvsContactId)
                    .HasName("FK_PRVS_CONTACT_ID");

                entity.HasIndex(e => e.PrvsDate)
                    .HasName("I_PATIENTRECALLVISIT_PRVS_DATE");

                entity.HasIndex(e => e.PrvsExplanationid)
                    .HasName("FK_VISIT_EXPLANATIONID");

                entity.HasIndex(e => e.PrvsExtproviderId)
                    .HasName("FK_PRVS_EXTPROVIDER_ID");

                entity.HasIndex(e => e.PrvsMentalEvent)
                    .HasName("FK_PRVS_MENTAL_EVENT");

                entity.HasIndex(e => e.PrvsOtherPatientId)
                    .HasName("FK_PRVS_OTHER_PATIENT");

                entity.HasIndex(e => e.PrvsParentId)
                    .HasName("FK_PRVS_PARENT_ID");

                entity.HasIndex(e => e.PrvsPerformedbyExtprovid)
                    .HasName("FK_PRVS_PERFORMBY_EXTPROVID");

                entity.HasIndex(e => e.PrvsPerformedbyId)
                    .HasName("FK_PRVS_PERFORMEDBY_ID");

                entity.HasIndex(e => e.PrvsPerformedbyPatientId)
                    .HasName("FK_PRVS_PERFORMEDBY_PATIENT");

                entity.HasIndex(e => e.PrvsPppuId)
                    .HasName("PTNTRECALLVISITFOREIGNKEY2");

                entity.HasIndex(e => e.PrvsPppuPosId)
                    .HasName("FK_PRVS_PPPU_POS_ID");

                entity.HasIndex(e => e.PrvsPriorityid)
                    .HasName("FK_RECVISPRIOR_SHCD_ID");

                entity.HasIndex(e => e.PrvsPrivacyroleId)
                    .HasName("FK_PRVS_PRIVACYROLE_ID");

                entity.HasIndex(e => e.PrvsPrplId)
                    .HasName("PTNTRECALLVISITFOREIGNKEY1");

                entity.HasIndex(e => e.PrvsRecallobjectiveId)
                    .HasName("FK_PRVS_RECALLOBJECTIVE_ID");

                entity.HasIndex(e => e.PrvsRecallrecurrenceId)
                    .HasName("FK_PRVS_RECALLRECURRENCE_ID");

                entity.HasIndex(e => e.PrvsShcdVisittypeId)
                    .HasName("FK_PRVS_SHCD_VISITTYPE_ID");

                entity.HasIndex(e => e.PrvsSpecialtyconceptId)
                    .HasName("FK_PRVS_SPEC_CONCEPT_ID");

                entity.HasIndex(e => e.PrvsSpecialtytypeconceptId)
                    .HasName("FK_PRVS_SPEC_TYPECONCEPT_ID");

                entity.HasIndex(e => e.PrvsSrvcId)
                    .HasName("PTNTRECALLVISITFOREIGNKEY3");

                entity.HasIndex(e => e.PrvsVisittemplateId)
                    .HasName("FK_PRVS_VISITTEMPLATE_ID");

                entity.HasIndex(e => e.ShcdCompleteformid)
                    .HasName("FK_PRV_SHCD_FORMID");

                entity.HasIndex(e => new { e.MasterId, e.Version })
                    .HasName("PATRECALLVISIT_I_MASTERVERS")
                    .IsUnique();

                entity.Property(e => e.PrvsId)
                    .HasColumnName("PRVS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarevisitId).HasColumnName("CAREVISIT_ID");

                entity.Property(e => e.Changed)
                    .HasColumnName("CHANGED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContactOid).HasColumnName("CONTACT_OID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExternalEntityId).HasColumnName("EXTERNAL_ENTITY_ID");

                entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PrivacyOrg).HasColumnName("PRIVACY_ORG");

                entity.Property(e => e.PrivacyPppuId).HasColumnName("PRIVACY_PPPU_ID");

                entity.Property(e => e.PrvsAdjustfrequency).HasColumnName("PRVS_ADJUSTFREQUENCY");

                entity.Property(e => e.PrvsAdjustunit).HasColumnName("PRVS_ADJUSTUNIT");

                entity.Property(e => e.PrvsApprovalStatus).HasColumnName("PRVS_APPROVAL_STATUS");

                entity.Property(e => e.PrvsApproxConclDate)
                    .HasColumnName("PRVS_APPROX_CONCL_DATE")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PrvsCaseId).HasColumnName("PRVS_CASE_ID");

                entity.Property(e => e.PrvsClash)
                    .HasColumnName("PRVS_CLASH")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrvsComment)
                    .HasColumnName("PRVS_COMMENT")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PrvsContactId).HasColumnName("PRVS_CONTACT_ID");

                entity.Property(e => e.PrvsDate)
                    .HasColumnName("PRVS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrvsDatecompleted)
                    .HasColumnName("PRVS_DATECOMPLETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrvsDateconcluded)
                    .HasColumnName("PRVS_DATECONCLUDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrvsDatematchesplan).HasColumnName("PRVS_DATEMATCHESPLAN");

                entity.Property(e => e.PrvsDateseen)
                    .HasColumnName("PRVS_DATESEEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrvsDescription)
                    .HasColumnName("PRVS_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrvsExplanationid).HasColumnName("PRVS_EXPLANATIONID");

                entity.Property(e => e.PrvsExternalVisitType)
                    .HasColumnName("PRVS_EXTERNAL_VISIT_TYPE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrvsExtproviderId).HasColumnName("PRVS_EXTPROVIDER_ID");

                entity.Property(e => e.PrvsForceontoinvoice).HasColumnName("PRVS_FORCEONTOINVOICE");

                entity.Property(e => e.PrvsHold).HasColumnName("PRVS_HOLD");

                entity.Property(e => e.PrvsIsadjustfrequency).HasColumnName("PRVS_ISADJUSTFREQUENCY");

                entity.Property(e => e.PrvsIscompleteformflag).HasColumnName("PRVS_ISCOMPLETEFORMFLAG");

                entity.Property(e => e.PrvsIscreatedwithrefdate).HasColumnName("PRVS_ISCREATEDWITHREFDATE");

                entity.Property(e => e.PrvsIsdateseen).HasColumnName("PRVS_ISDATESEEN");

                entity.Property(e => e.PrvsIshistorysummary).HasColumnName("PRVS_ISHISTORYSUMMARY");

                entity.Property(e => e.PrvsIsnextvisitdate).HasColumnName("PRVS_ISNEXTVISITDATE");

                entity.Property(e => e.PrvsMentalEvent).HasColumnName("PRVS_MENTAL_EVENT");

                entity.Property(e => e.PrvsMoveduedate).HasColumnName("PRVS_MOVEDUEDATE");

                entity.Property(e => e.PrvsNextvisitdate)
                    .HasColumnName("PRVS_NEXTVISITDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrvsNextvisitnote)
                    .HasColumnName("PRVS_NEXTVISITNOTE")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.PrvsOtherPatientId).HasColumnName("PRVS_OTHER_PATIENT_ID");

                entity.Property(e => e.PrvsParentId).HasColumnName("PRVS_PARENT_ID");

                entity.Property(e => e.PrvsPerformedbyAdhoc)
                    .HasColumnName("PRVS_PERFORMEDBY_ADHOC")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.PrvsPerformedbyExtprovid).HasColumnName("PRVS_PERFORMEDBY_EXTPROVID");

                entity.Property(e => e.PrvsPerformedbyId).HasColumnName("PRVS_PERFORMEDBY_ID");

                entity.Property(e => e.PrvsPerformedbyPatientId).HasColumnName("PRVS_PERFORMEDBY_PATIENT_ID");

                entity.Property(e => e.PrvsPerformedbyType).HasColumnName("PRVS_PERFORMEDBY_TYPE");

                entity.Property(e => e.PrvsPppuId).HasColumnName("PRVS_PPPU_ID");

                entity.Property(e => e.PrvsPppuPosId).HasColumnName("PRVS_PPPU_POS_ID");

                entity.Property(e => e.PrvsPriorityid).HasColumnName("PRVS_PRIORITYID");

                entity.Property(e => e.PrvsPrivacyroleId).HasColumnName("PRVS_PRIVACYROLE_ID");

                entity.Property(e => e.PrvsProvidertype).HasColumnName("PRVS_PROVIDERTYPE");

                entity.Property(e => e.PrvsPrplId).HasColumnName("PRVS_PRPL_ID");

                entity.Property(e => e.PrvsRecallobjectiveId).HasColumnName("PRVS_RECALLOBJECTIVE_ID");

                entity.Property(e => e.PrvsRecallrecurrenceId).HasColumnName("PRVS_RECALLRECURRENCE_ID");

                entity.Property(e => e.PrvsRepeatmade).HasColumnName("PRVS_REPEATMADE");

                entity.Property(e => e.PrvsShcdVisittypeId).HasColumnName("PRVS_SHCD_VISITTYPE_ID");

                entity.Property(e => e.PrvsSourceref)
                    .HasColumnName("PRVS_SOURCEREF")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PrvsSpecialtyconceptId).HasColumnName("PRVS_SPECIALTYCONCEPT_ID");

                entity.Property(e => e.PrvsSpecialtytypeconceptId).HasColumnName("PRVS_SPECIALTYTYPECONCEPT_ID");

                entity.Property(e => e.PrvsSrvcId).HasColumnName("PRVS_SRVC_ID");

                entity.Property(e => e.PrvsStatus).HasColumnName("PRVS_STATUS");

                entity.Property(e => e.PrvsVisittemplateId).HasColumnName("PRVS_VISITTEMPLATE_ID");

                entity.Property(e => e.PrvsWindows).HasColumnName("PRVS_WINDOWS");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdCompleteformid).HasColumnName("SHCD_COMPLETEFORMID");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ContactO)
                    .WithMany(p => p.PatientrecallvisitContactO)
                    .HasForeignKey(d => d.ContactOid)
                    .HasConstraintName("FK_PRVS_CONTACT_OID");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.PatientrecallvisitCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("PATRECALLVISIT_FK_CREATEDBY");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.PatientrecallvisitDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("PATRECALLVISIT_FK_DELETEDBY");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.InverseMaster)
                    .HasForeignKey(d => d.MasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PATIENTRECALLVISIT_FK_MASTER");

                entity.HasOne(d => d.PrivacyPppu)
                    .WithMany(p => p.PatientrecallvisitPrivacyPppu)
                    .HasForeignKey(d => d.PrivacyPppuId)
                    .HasConstraintName("PATIENTRECALLVISIT_FK_PPPU");

                entity.HasOne(d => d.PrvsCase)
                    .WithMany(p => p.Patientrecallvisit)
                    .HasForeignKey(d => d.PrvsCaseId)
                    .HasConstraintName("PRVS_FK_CASE_ID");

                entity.HasOne(d => d.PrvsContact)
                    .WithMany(p => p.PatientrecallvisitPrvsContact)
                    .HasForeignKey(d => d.PrvsContactId)
                    .HasConstraintName("FK_PRVS_CONTACT_ID");

                entity.HasOne(d => d.PrvsExplanation)
                    .WithMany(p => p.PatientrecallvisitPrvsExplanation)
                    .HasForeignKey(d => d.PrvsExplanationid)
                    .HasConstraintName("FK_VISIT_EXPLANATIONID");

                entity.HasOne(d => d.PrvsExtprovider)
                    .WithMany(p => p.PatientrecallvisitPrvsExtprovider)
                    .HasForeignKey(d => d.PrvsExtproviderId)
                    .HasConstraintName("FK_PRVS_EXTPROVIDER_ID");

                entity.HasOne(d => d.PrvsOtherPatient)
                    .WithMany(p => p.PatientrecallvisitPrvsOtherPatient)
                    .HasForeignKey(d => d.PrvsOtherPatientId)
                    .HasConstraintName("FK_PRVS_OTHER_PATIENT");

                entity.HasOne(d => d.PrvsParent)
                    .WithMany(p => p.InversePrvsParent)
                    .HasForeignKey(d => d.PrvsParentId)
                    .HasConstraintName("FK_PRVS_PARENT_ID");

                entity.HasOne(d => d.PrvsPerformedbyExtprov)
                    .WithMany(p => p.PatientrecallvisitPrvsPerformedbyExtprov)
                    .HasForeignKey(d => d.PrvsPerformedbyExtprovid)
                    .HasConstraintName("FK_PRVS_PERFORMBY_EXTPROVID");

                entity.HasOne(d => d.PrvsPerformedby)
                    .WithMany(p => p.PatientrecallvisitPrvsPerformedby)
                    .HasForeignKey(d => d.PrvsPerformedbyId)
                    .HasConstraintName("FK_PRVS_PERFORMEDBY_ID");

                entity.HasOne(d => d.PrvsPerformedbyPatient)
                    .WithMany(p => p.PatientrecallvisitPrvsPerformedbyPatient)
                    .HasForeignKey(d => d.PrvsPerformedbyPatientId)
                    .HasConstraintName("FK_PRVS_PERFORMEDBY_PATIENT");

                entity.HasOne(d => d.PrvsPppu)
                    .WithMany(p => p.PatientrecallvisitPrvsPppu)
                    .HasForeignKey(d => d.PrvsPppuId)
                    .HasConstraintName("PTNTRECALLVISITFOREIGNKEY2");

                entity.HasOne(d => d.PrvsPppuPos)
                    .WithMany(p => p.PatientrecallvisitPrvsPppuPos)
                    .HasForeignKey(d => d.PrvsPppuPosId)
                    .HasConstraintName("FK_PRVS_PPPU_POS_ID");

                entity.HasOne(d => d.PrvsPriority)
                    .WithMany(p => p.PatientrecallvisitPrvsPriority)
                    .HasForeignKey(d => d.PrvsPriorityid)
                    .HasConstraintName("FK_RECVISPRIOR_SHCD_ID");

                entity.HasOne(d => d.PrvsPrivacyrole)
                    .WithMany(p => p.Patientrecallvisit)
                    .HasForeignKey(d => d.PrvsPrivacyroleId)
                    .HasConstraintName("FK_PRVS_PRIVACYROLE_ID");

                entity.HasOne(d => d.PrvsShcdVisittype)
                    .WithMany(p => p.PatientrecallvisitPrvsShcdVisittype)
                    .HasForeignKey(d => d.PrvsShcdVisittypeId)
                    .HasConstraintName("FK_PRVS_SHCD_VISITTYPE_ID");

                entity.HasOne(d => d.PrvsSpecialtyconcept)
                    .WithMany(p => p.PatientrecallvisitPrvsSpecialtyconcept)
                    .HasForeignKey(d => d.PrvsSpecialtyconceptId)
                    .HasConstraintName("FK_PRVS_SPEC_CONCEPT_ID");

                entity.HasOne(d => d.PrvsSpecialtytypeconcept)
                    .WithMany(p => p.PatientrecallvisitPrvsSpecialtytypeconcept)
                    .HasForeignKey(d => d.PrvsSpecialtytypeconceptId)
                    .HasConstraintName("FK_PRVS_SPEC_TYPECONCEPT_ID");

                entity.HasOne(d => d.ShcdCompleteform)
                    .WithMany(p => p.PatientrecallvisitShcdCompleteform)
                    .HasForeignKey(d => d.ShcdCompleteformid)
                    .HasConstraintName("FK_PRV_SHCD_FORMID");
            });

            modelBuilder.Entity<PostCodes>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("POST_CODES");

                entity.HasIndex(e => e.Addr2)
                    .HasName("POST_CODES_I_ADDR2");

                entity.HasIndex(e => e.Addr3)
                    .HasName("POST_CODES_I_ADDR3");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_POST_CODES");

                entity.HasIndex(e => e.Postcode)
                    .HasName("POST_CODES_I_POSTCODE");

                entity.HasIndex(e => e.State)
                    .HasName("FK_POSTCODES_STATE");

                entity.HasIndex(e => new { e.State, e.Oid })
                    .HasName("I_POSTCODES_STATEOID");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Addr2)
                    .HasColumnName("ADDR2")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.Addr3)
                    .HasColumnName("ADDR3")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasDefaultValueSql("((554))");

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GeoLatitude)
                    .HasColumnName("GEO_LATITUDE")
                    .HasDefaultValueSql("((90.0))");

                entity.Property(e => e.GeoLongitude)
                    .HasColumnName("GEO_LONGITUDE")
                    .HasDefaultValueSql("((90.0))");

                entity.Property(e => e.GeoMeshblock)
                    .HasColumnName("GEO_MESHBLOCK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeoX)
                    .HasColumnName("GEO_X")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GeoY)
                    .HasColumnName("GEO_Y")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.OldPostcode)
                    .HasColumnName("OLD_POSTCODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.StreetName)
                    .HasColumnName("STREET_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.PostCodes)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_POSTCODES_STATE");
            });

            modelBuilder.Entity<Pppu>(entity =>
            {
                entity.ToTable("PPPU");

                entity.HasIndex(e => e.Createdby)
                    .HasName("PPPU_FK_CREATEDBY");

                entity.HasIndex(e => e.DefaultSupplierIdLaboratory)
                    .HasName("PPPU_FK_DEFSUPPLIER_LABORATORY");

                entity.HasIndex(e => e.DefaultSupplierIdPharmacy)
                    .HasName("PPPU_FK_DEFSUPPLIER_PHARMACY");

                entity.HasIndex(e => e.DefaultSupplierIdRadiology)
                    .HasName("PPPU_FK_DEFSUPPLIER_RADIOLOGY");

                entity.HasIndex(e => e.Deletedby)
                    .HasName("PPPU_FK_DELETEDBY");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PPPU");

                entity.HasIndex(e => e.OrgPayerId)
                    .HasName("FK_PPPU_ORG_PAYER");

                entity.HasIndex(e => e.PppuAccessProfileId)
                    .HasName("FK_PPPU_ACCESS_PROFILE");

                entity.HasIndex(e => e.PppuAltEserviceId)
                    .HasName("FK_PPPU_EMESSAGE_ALT_ESRV_ID");

                entity.HasIndex(e => e.PppuApntSlipId)
                    .HasName("PPPU_APNT_SLIP_ID_FK");

                entity.HasIndex(e => e.PppuAppLocationId)
                    .HasName("FK_PPPU_APP_LOCATION_ID");

                entity.HasIndex(e => e.PppuAssociatesDetailId)
                    .HasName("FK_PPPU_ASSOCIATES_DETAIL_ID");

                entity.HasIndex(e => e.PppuCategory)
                    .HasName("PPPU_IDX_CATEGORY");

                entity.HasIndex(e => e.PppuCoverRule)
                    .HasName("PPPU_FK_COVER_RULE");

                entity.HasIndex(e => e.PppuEformatId)
                    .HasName("FK_PPPU_EFORMAT_ID");

                entity.HasIndex(e => e.PppuExtprovcustomrep)
                    .HasName("FK_EXTPROVCUSTOMREP");

                entity.HasIndex(e => e.PppuExtprovcustomrepmacro)
                    .HasName("FK_EXTPROVCUSTOMREPMACRO");

                entity.HasIndex(e => e.PppuFrontPageId)
                    .HasName("PPPU_FRONT_PAGE_ID_FK");

                entity.HasIndex(e => e.PppuIdBasePos)
                    .HasName("PPPU_CONSTRAINT_POS");

                entity.HasIndex(e => e.PppuIdLocum)
                    .HasName("FK_PPPU_IDLOCUM");

                entity.HasIndex(e => e.PppuOnthegoId)
                    .HasName("FK_PPPU_ONTHEGO");

                entity.HasIndex(e => e.PppuOrgLevel)
                    .HasName("FK_PPPU_ORG_LEVEL");

                entity.HasIndex(e => e.PppuPaycode)
                    .HasName("PPPU_FK_PAYCODE");

                entity.HasIndex(e => e.PppuPosSettingId)
                    .HasName("PPPU_POS_SETTING_FK_SHCD_ID");

                entity.HasIndex(e => e.PppuPostalstate)
                    .HasName("PPPU_FK_PPPU_POSTALSTATE");

                entity.HasIndex(e => e.PppuProvidergroup)
                    .HasName("FK_PPPU_PROVGROUP");

                entity.HasIndex(e => e.PppuRateShcdId)
                    .HasName("FK_PPPURATESHCD");

                entity.HasIndex(e => e.PppuReferencecode)
                    .HasName("PPPU_IDX_REFERENCECODE");

                entity.HasIndex(e => e.PppuReferencesystem)
                    .HasName("PPPU_FK_REFSYS_ID");

                entity.HasIndex(e => e.PppuReferralEserviceId)
                    .HasName("FK_PPPU_EMESSAGE_REF_ESRV_ID");

                entity.HasIndex(e => e.PppuSignatureId)
                    .HasName("FK_PPPU_SIGNATURE_ID");

                entity.HasIndex(e => e.PppuSpecialtyconceptid)
                    .HasName("PPPU_FK_SPECIALTYCONCEPTID");

                entity.HasIndex(e => e.PppuStreetstate)
                    .HasName("PPPU_FK_PPPU_STREETSTATE");

                entity.HasIndex(e => e.PppuSupervisor)
                    .HasName("PPPU_FK_SUPERVISOR");

                entity.HasIndex(e => e.PppuTimezoneId)
                    .HasName("FK_PPPU_TIMEZONE_ID");

                entity.HasIndex(e => e.PppuTypeconceptid)
                    .HasName("PPPU_FK_TYPECONCEPTID");

                entity.HasIndex(e => new { e.PppuLastname, e.PppuPrefname })
                    .HasName("PPPU_LASTPREFINDEX");

                entity.HasIndex(e => new { e.PppuCode, e.PppuDeletedid, e.PartitionId })
                    .HasName("PPPU_I_CODE_DELETEDID")
                    .IsUnique();

                entity.HasIndex(e => new { e.PppuDeletedid, e.PppuIsexternal, e.PppuCategory, e.PartitionId })
                    .HasName("idx_PPPU_PPPU_DELETEDID_PPPU_ISEXTERNAL_PPPU_CATEGORY_PARTITION_ID");

                entity.Property(e => e.PppuId)
                    .HasColumnName("PPPU_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.DateLastPassChange)
                    .HasColumnName("DATE_LAST_PASS_CHANGE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastQuery)
                    .HasColumnName("DATE_LAST_QUERY")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastResult)
                    .HasColumnName("DATE_LAST_RESULT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultSupplierIdLaboratory).HasColumnName("DEFAULT_SUPPLIER_ID_LABORATORY");

                entity.Property(e => e.DefaultSupplierIdPharmacy).HasColumnName("DEFAULT_SUPPLIER_ID_PHARMACY");

                entity.Property(e => e.DefaultSupplierIdRadiology).HasColumnName("DEFAULT_SUPPLIER_ID_RADIOLOGY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ForcePassChange).HasColumnName("FORCE_PASS_CHANGE");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.OrgPayerId).HasColumnName("ORG_PAYER_ID");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PasswordExpiryDate)
                    .HasColumnName("PASSWORD_EXPIRY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayeeId)
                    .HasColumnName("PAYEE_ID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuAccessProfileId).HasColumnName("PPPU_ACCESS_PROFILE_ID");

                entity.Property(e => e.PppuAccessionAccess).HasColumnName("PPPU_ACCESSION_ACCESS");

                entity.Property(e => e.PppuAltEserviceId).HasColumnName("PPPU_ALT_ESERVICE_ID");

                entity.Property(e => e.PppuApntSlipId).HasColumnName("PPPU_APNT_SLIP_ID");

                entity.Property(e => e.PppuAppLocationId).HasColumnName("PPPU_APP_LOCATION_ID");

                entity.Property(e => e.PppuAppt1stmonday)
                    .HasColumnName("PPPU_APPT1STMONDAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.PppuApptcycleweeks).HasColumnName("PPPU_APPTCYCLEWEEKS");

                entity.Property(e => e.PppuAspDeliveryId)
                    .HasColumnName("PPPU_ASP_DELIVERY_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PppuAssociatesDetailId).HasColumnName("PPPU_ASSOCIATES_DETAIL_ID");

                entity.Property(e => e.PppuAutocase).HasColumnName("PPPU_AUTOCASE");

                entity.Property(e => e.PppuAutolockMin).HasColumnName("PPPU_AUTOLOCK_MIN");

                entity.Property(e => e.PppuAutolocking).HasColumnName("PPPU_AUTOLOCKING");

                entity.Property(e => e.PppuBkgndimageHide).HasColumnName("PPPU_BKGNDIMAGE_HIDE");

                entity.Property(e => e.PppuBkgndimagestyle).HasColumnName("PPPU_BKGNDIMAGESTYLE");

                entity.Property(e => e.PppuBkgndimagetransp).HasColumnName("PPPU_BKGNDIMAGETRANSP");

                entity.Property(e => e.PppuBuildingpostal)
                    .HasColumnName("PPPU_BUILDINGPOSTAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PppuBuildingstreet)
                    .HasColumnName("PPPU_BUILDINGSTREET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PppuCategory).HasColumnName("PPPU_CATEGORY");

                entity.Property(e => e.PppuCellphone)
                    .HasColumnName("PPPU_CELLPHONE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuCode)
                    .IsRequired()
                    .HasColumnName("PPPU_CODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PppuCoverRule).HasColumnName("PPPU_COVER_RULE");

                entity.Property(e => e.PppuCoverSplit).HasColumnName("PPPU_COVER_SPLIT");

                entity.Property(e => e.PppuDateadded)
                    .HasColumnName("PPPU_DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PppuDatechanged)
                    .HasColumnName("PPPU_DATECHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PppuDeletedid).HasColumnName("PPPU_DELETEDID");

                entity.Property(e => e.PppuDob)
                    .HasColumnName("PPPU_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.PppuEdiaddress)
                    .HasColumnName("PPPU_EDIADDRESS")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuEdikey)
                    .HasColumnName("PPPU_EDIKEY")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuEdiprivatekey)
                    .HasColumnName("PPPU_EDIPRIVATEKEY")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuEdipublickey)
                    .HasColumnName("PPPU_EDIPUBLICKEY")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuEdireferralsSubpath)
                    .HasColumnName("PPPU_EDIREFERRALS_SUBPATH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PppuEformatAlsoPrint).HasColumnName("PPPU_EFORMAT_ALSO_PRINT");

                entity.Property(e => e.PppuEformatId).HasColumnName("PPPU_EFORMAT_ID");

                entity.Property(e => e.PppuEmail)
                    .HasColumnName("PPPU_EMAIL")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuExternalorgcode)
                    .HasColumnName("PPPU_EXTERNALORGCODE")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuExternalorgcodeset)
                    .HasColumnName("PPPU_EXTERNALORGCODESET")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuExternalorgname)
                    .HasColumnName("PPPU_EXTERNALORGNAME")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.PppuExtprovcustomrep).HasColumnName("PPPU_EXTPROVCUSTOMREP");

                entity.Property(e => e.PppuExtprovcustomrepmacro).HasColumnName("PPPU_EXTPROVCUSTOMREPMACRO");

                entity.Property(e => e.PppuFax)
                    .HasColumnName("PPPU_FAX")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuFrontPageId).HasColumnName("PPPU_FRONT_PAGE_ID");

                entity.Property(e => e.PppuFullname)
                    .IsRequired()
                    .HasColumnName("PPPU_FULLNAME")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeneralComments)
                    .HasColumnName("PPPU_GENERAL_COMMENTS")
                    .HasColumnType("image");

                entity.Property(e => e.PppuGeneralCommentsPlain)
                    .HasColumnName("PPPU_GENERAL_COMMENTS_PLAIN")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoDecile)
                    .HasColumnName("PPPU_GEO_DECILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoDhb)
                    .HasColumnName("PPPU_GEO_DHB")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoDomicileCode)
                    .HasColumnName("PPPU_GEO_DOMICILE_CODE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoDomicileDescription)
                    .HasColumnName("PPPU_GEO_DOMICILE_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoLatitude)
                    .HasColumnName("PPPU_GEO_LATITUDE")
                    .HasDefaultValueSql("((90.0))");

                entity.Property(e => e.PppuGeoLongitude)
                    .HasColumnName("PPPU_GEO_LONGITUDE")
                    .HasDefaultValueSql("((90.0))");

                entity.Property(e => e.PppuGeoMeshblock)
                    .HasColumnName("PPPU_GEO_MESHBLOCK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoQuintile)
                    .HasColumnName("PPPU_GEO_QUINTILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoStatus).HasColumnName("PPPU_GEO_STATUS");

                entity.Property(e => e.PppuGeoTlaName)
                    .HasColumnName("PPPU_GEO_TLA_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoUncertaintycode)
                    .HasColumnName("PPPU_GEO_UNCERTAINTYCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoX)
                    .HasColumnName("PPPU_GEO_X")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGeoY)
                    .HasColumnName("PPPU_GEO_Y")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PppuGroupbasedpreference).HasColumnName("PPPU_GROUPBASEDPREFERENCE");

                entity.Property(e => e.PppuHpiI)
                    .HasColumnName("PPPU_HPI_I")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PppuHpiO)
                    .HasColumnName("PPPU_HPI_O")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PppuIdBasePos).HasColumnName("PPPU_ID_BASE_POS");

                entity.Property(e => e.PppuIdLocum).HasColumnName("PPPU_ID_LOCUM");

                entity.Property(e => e.PppuInvoiceMedicareType).HasColumnName("PPPU_INVOICE_MEDICARE_TYPE");

                entity.Property(e => e.PppuIsDominant).HasColumnName("PPPU_IS_DOMINANT");

                entity.Property(e => e.PppuIsLmo).HasColumnName("PPPU_IS_LMO");

                entity.Property(e => e.PppuIsOmo).HasColumnName("PPPU_IS_OMO");

                entity.Property(e => e.PppuIsRo).HasColumnName("PPPU_IS_RO");

                entity.Property(e => e.PppuIsexternal).HasColumnName("PPPU_ISEXTERNAL");

                entity.Property(e => e.PppuIsimported).HasColumnName("PPPU_ISIMPORTED");

                entity.Property(e => e.PppuIsltremail).HasColumnName("PPPU_ISLTREMAIL");

                entity.Property(e => e.PppuIsltrfax).HasColumnName("PPPU_ISLTRFAX");

                entity.Property(e => e.PppuIsltrmessage).HasColumnName("PPPU_ISLTRMESSAGE");

                entity.Property(e => e.PppuIsltrprint).HasColumnName("PPPU_ISLTRPRINT");

                entity.Property(e => e.PppuJobtitle)
                    .HasColumnName("PPPU_JOBTITLE")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PppuLastname)
                    .HasColumnName("PPPU_LASTNAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuLocationcertificate)
                    .HasColumnName("PPPU_LOCATIONCERTIFICATE")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.PppuLocumactive).HasColumnName("PPPU_LOCUMACTIVE");

                entity.Property(e => e.PppuLocumchanged)
                    .HasColumnName("PPPU_LOCUMCHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PppuLocumexpirydate)
                    .HasColumnName("PPPU_LOCUMEXPIRYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PppuMobileDeviceAccess).HasColumnName("PPPU_MOBILE_DEVICE_ACCESS");

                entity.Property(e => e.PppuNextagedate)
                    .HasColumnName("PPPU_NEXTAGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PppuNpicode)
                    .HasColumnName("PPPU_NPICODE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuOhipPassword)
                    .HasColumnName("PPPU_OHIP_PASSWORD")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PppuOhipProvider).HasColumnName("PPPU_OHIP_PROVIDER");

                entity.Property(e => e.PppuOhipUserid)
                    .HasColumnName("PPPU_OHIP_USERID")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PppuOnthegoId).HasColumnName("PPPU_ONTHEGO_ID");

                entity.Property(e => e.PppuOrgLevel).HasColumnName("PPPU_ORG_LEVEL");

                entity.Property(e => e.PppuOtherInCefmenu).HasColumnName("PPPU_OTHER_IN_CEFMENU");

                entity.Property(e => e.PppuPager)
                    .HasColumnName("PPPU_PAGER")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPaycode).HasColumnName("PPPU_PAYCODE");

                entity.Property(e => e.PppuPersonalUrl)
                    .HasColumnName("PPPU_PERSONAL_URL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPhone1)
                    .HasColumnName("PPPU_PHONE1")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPhone2)
                    .HasColumnName("PPPU_PHONE2")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPlacename)
                    .HasColumnName("PPPU_PLACENAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPosSettingId).HasColumnName("PPPU_POS_SETTING_ID");

                entity.Property(e => e.PppuPostCountry).HasColumnName("PPPU_POST_COUNTRY");

                entity.Property(e => e.PppuPostal1)
                    .HasColumnName("PPPU_POSTAL1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPostal2)
                    .HasColumnName("PPPU_POSTAL2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPostal3)
                    .HasColumnName("PPPU_POSTAL3")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPostal4)
                    .HasColumnName("PPPU_POSTAL4")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPostalcode)
                    .HasColumnName("PPPU_POSTALCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPostalstate).HasColumnName("PPPU_POSTALSTATE");

                entity.Property(e => e.PppuPreferprecedence).HasColumnName("PPPU_PREFERPRECEDENCE");

                entity.Property(e => e.PppuPreferredCommMethod).HasColumnName("PPPU_PREFERRED_COMM_METHOD");

                entity.Property(e => e.PppuPrefname)
                    .HasColumnName("PPPU_PREFNAME")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPrincipalgroup).HasColumnName("PPPU_PRINCIPALGROUP");

                entity.Property(e => e.PppuProvidergroup).HasColumnName("PPPU_PROVIDERGROUP");

                entity.Property(e => e.PppuQualifications)
                    .HasColumnName("PPPU_QUALIFICATIONS")
                    .HasMaxLength(47)
                    .IsUnicode(false);

                entity.Property(e => e.PppuRateShcdId).HasColumnName("PPPU_RATE_SHCD_ID");

                entity.Property(e => e.PppuReferencecode)
                    .HasColumnName("PPPU_REFERENCECODE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuReferenceid).HasColumnName("PPPU_REFERENCEID");

                entity.Property(e => e.PppuReferencesystem).HasColumnName("PPPU_REFERENCESYSTEM");

                entity.Property(e => e.PppuReferralEserviceId).HasColumnName("PPPU_REFERRAL_ESERVICE_ID");

                entity.Property(e => e.PppuSex)
                    .HasColumnName("PPPU_SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PppuSignatureId).HasColumnName("PPPU_SIGNATURE_ID");

                entity.Property(e => e.PppuSignatureScale)
                    .HasColumnName("PPPU_SIGNATURE_SCALE")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.PppuSpecialty).HasColumnName("PPPU_SPECIALTY");

                entity.Property(e => e.PppuSpecialtyconceptid).HasColumnName("PPPU_SPECIALTYCONCEPTID");

                entity.Property(e => e.PppuStatus).HasColumnName("PPPU_STATUS");

                entity.Property(e => e.PppuStreet1)
                    .HasColumnName("PPPU_STREET1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PppuStreet2)
                    .HasColumnName("PPPU_STREET2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PppuStreet3)
                    .HasColumnName("PPPU_STREET3")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PppuStreet4)
                    .HasColumnName("PPPU_STREET4")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PppuStreetCountry).HasColumnName("PPPU_STREET_COUNTRY");

                entity.Property(e => e.PppuStreetcode)
                    .HasColumnName("PPPU_STREETCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PppuStreetstate).HasColumnName("PPPU_STREETSTATE");

                entity.Property(e => e.PppuSupervisor).HasColumnName("PPPU_SUPERVISOR");

                entity.Property(e => e.PppuSxcopayExtractOn).HasColumnName("PPPU_SXCOPAY_EXTRACT_ON");

                entity.Property(e => e.PppuSxcopayStartTrnsid).HasColumnName("PPPU_SXCOPAY_START_TRNSID");

                entity.Property(e => e.PppuTakingNewPatients).HasColumnName("PPPU_TAKING_NEW_PATIENTS");

                entity.Property(e => e.PppuTimezoneId).HasColumnName("PPPU_TIMEZONE_ID");

                entity.Property(e => e.PppuTitle)
                    .HasColumnName("PPPU_TITLE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PppuType).HasColumnName("PPPU_TYPE");

                entity.Property(e => e.PppuTypeconceptid).HasColumnName("PPPU_TYPECONCEPTID");

                entity.Property(e => e.PppuUseprovsrv).HasColumnName("PPPU_USEPROVSRV");

                entity.Property(e => e.PppuUsersid)
                    .HasColumnName("PPPU_USERSID")
                    .HasMaxLength(56)
                    .IsUnicode(false);

                entity.Property(e => e.PppuUsersidDescription)
                    .HasColumnName("PPPU_USERSID_DESCRIPTION")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PppuUsesmddelivery).HasColumnName("PPPU_USESMDDELIVERY");

                entity.Property(e => e.PppuUsestreet).HasColumnName("PPPU_USESTREET");

                entity.Property(e => e.PppuWeblastvisit)
                    .HasColumnName("PPPU_WEBLASTVISIT")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.PppuCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .HasConstraintName("PPPU_FK_CREATEDBY");

                entity.HasOne(d => d.DefaultSupplierIdLaboratoryNavigation)
                    .WithMany(p => p.InverseDefaultSupplierIdLaboratoryNavigation)
                    .HasForeignKey(d => d.DefaultSupplierIdLaboratory)
                    .HasConstraintName("PPPU_FK_DEFSUPPLIER_LABORATORY");

                entity.HasOne(d => d.DefaultSupplierIdPharmacyNavigation)
                    .WithMany(p => p.InverseDefaultSupplierIdPharmacyNavigation)
                    .HasForeignKey(d => d.DefaultSupplierIdPharmacy)
                    .HasConstraintName("PPPU_FK_DEFSUPPLIER_PHARMACY");

                entity.HasOne(d => d.DefaultSupplierIdRadiologyNavigation)
                    .WithMany(p => p.InverseDefaultSupplierIdRadiologyNavigation)
                    .HasForeignKey(d => d.DefaultSupplierIdRadiology)
                    .HasConstraintName("PPPU_FK_DEFSUPPLIER_RADIOLOGY");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.PppuDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .HasConstraintName("PPPU_FK_DELETEDBY");

                entity.HasOne(d => d.OrgPayer)
                    .WithMany(p => p.Pppu)
                    .HasForeignKey(d => d.OrgPayerId)
                    .HasConstraintName("FK_PPPU_ORG_PAYER");

                entity.HasOne(d => d.PppuAppLocation)
                    .WithMany(p => p.PppuPppuAppLocation)
                    .HasForeignKey(d => d.PppuAppLocationId)
                    .HasConstraintName("FK_PPPU_APP_LOCATION_ID");

                entity.HasOne(d => d.PppuCoverRuleNavigation)
                    .WithMany(p => p.PppuPppuCoverRuleNavigation)
                    .HasForeignKey(d => d.PppuCoverRule)
                    .HasConstraintName("PPPU_FK_COVER_RULE");

                entity.HasOne(d => d.PppuExtprovcustomrepNavigation)
                    .WithMany(p => p.PppuPppuExtprovcustomrepNavigation)
                    .HasForeignKey(d => d.PppuExtprovcustomrep)
                    .HasConstraintName("FK_EXTPROVCUSTOMREP");

                entity.HasOne(d => d.PppuExtprovcustomrepmacroNavigation)
                    .WithMany(p => p.PppuPppuExtprovcustomrepmacroNavigation)
                    .HasForeignKey(d => d.PppuExtprovcustomrepmacro)
                    .HasConstraintName("FK_EXTPROVCUSTOMREPMACRO");

                entity.HasOne(d => d.PppuIdBasePosNavigation)
                    .WithMany(p => p.InversePppuIdBasePosNavigation)
                    .HasForeignKey(d => d.PppuIdBasePos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PPPU_CONSTRAINT_POS");

                entity.HasOne(d => d.PppuIdLocumNavigation)
                    .WithMany(p => p.InversePppuIdLocumNavigation)
                    .HasForeignKey(d => d.PppuIdLocum)
                    .HasConstraintName("FK_PPPU_IDLOCUM");

                entity.HasOne(d => d.PppuOrgLevelNavigation)
                    .WithMany(p => p.PppuNavigation)
                    .HasForeignKey(d => d.PppuOrgLevel)
                    .HasConstraintName("FK_PPPU_ORG_LEVEL");

                entity.HasOne(d => d.PppuPaycodeNavigation)
                    .WithMany(p => p.PppuPppuPaycodeNavigation)
                    .HasForeignKey(d => d.PppuPaycode)
                    .HasConstraintName("PPPU_FK_PAYCODE");

                entity.HasOne(d => d.PppuPosSetting)
                    .WithMany(p => p.PppuPppuPosSetting)
                    .HasForeignKey(d => d.PppuPosSettingId)
                    .HasConstraintName("PPPU_POS_SETTING_FK_SHCD_ID");

                entity.HasOne(d => d.PppuPostalstateNavigation)
                    .WithMany(p => p.PppuPppuPostalstateNavigation)
                    .HasForeignKey(d => d.PppuPostalstate)
                    .HasConstraintName("PPPU_FK_PPPU_POSTALSTATE");

                entity.HasOne(d => d.PppuRateShcd)
                    .WithMany(p => p.PppuPppuRateShcd)
                    .HasForeignKey(d => d.PppuRateShcdId)
                    .HasConstraintName("FK_PPPURATESHCD");

                entity.HasOne(d => d.PppuReferencesystemNavigation)
                    .WithMany(p => p.PppuPppuReferencesystemNavigation)
                    .HasForeignKey(d => d.PppuReferencesystem)
                    .HasConstraintName("PPPU_FK_REFSYS_ID");

                entity.HasOne(d => d.PppuSignature)
                    .WithMany(p => p.PppuPppuSignature)
                    .HasForeignKey(d => d.PppuSignatureId)
                    .HasConstraintName("FK_PPPU_SIGNATURE_ID");

                entity.HasOne(d => d.PppuSpecialtyconcept)
                    .WithMany(p => p.PppuPppuSpecialtyconcept)
                    .HasForeignKey(d => d.PppuSpecialtyconceptid)
                    .HasConstraintName("PPPU_FK_SPECIALTYCONCEPTID");

                entity.HasOne(d => d.PppuStreetstateNavigation)
                    .WithMany(p => p.PppuPppuStreetstateNavigation)
                    .HasForeignKey(d => d.PppuStreetstate)
                    .HasConstraintName("PPPU_FK_PPPU_STREETSTATE");

                entity.HasOne(d => d.PppuSupervisorNavigation)
                    .WithMany(p => p.InversePppuSupervisorNavigation)
                    .HasForeignKey(d => d.PppuSupervisor)
                    .HasConstraintName("PPPU_FK_SUPERVISOR");

                entity.HasOne(d => d.PppuTypeconcept)
                    .WithMany(p => p.PppuPppuTypeconcept)
                    .HasForeignKey(d => d.PppuTypeconceptid)
                    .HasConstraintName("PPPU_FK_TYPECONCEPTID");
            });

            modelBuilder.Entity<Pppuimage>(entity =>
            {
                entity.HasKey(e => e.PppuId);

                entity.ToTable("PPPUIMAGE");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PPPUIMAGE");

                entity.HasIndex(e => e.PppuId)
                    .HasName("PPPUIMAGE_PPPUID");

                entity.Property(e => e.PppuId)
                    .HasColumnName("PPPU_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PuimBitmap)
                    .HasColumnName("PUIM_BITMAP")
                    .HasColumnType("image");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pppu)
                    .WithOne(p => p.Pppuimage)
                    .HasForeignKey<Pppuimage>(d => d.PppuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PPPUIMAGE_PPPUID");
            });

            modelBuilder.Entity<Pppupos>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PPPUPOS");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PPPUPOS");

                entity.HasIndex(e => e.PppuId)
                    .HasName("FK_PPPUPOS_PPPU_ID");

                entity.HasIndex(e => e.PppuPosId)
                    .HasName("FK_PPPUPOS_POS_ID");

                entity.HasIndex(e => e.PppuPosReferencesystem)
                    .HasName("PPPUPOS_FK_REFSYS_ID");

                entity.HasIndex(e => e.PppuPosRrpScc)
                    .HasName("PPPUPOS_RRP_SCC_FK");

                entity.HasIndex(e => e.PppuPosTopRole)
                    .HasName("PPPUPOS_I_TOP_ROLE");

                entity.HasIndex(e => new { e.PppuId, e.PppuPosId })
                    .HasName("PPPUPOS_I_POS_PPPU_ID")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorePayeeId)
                    .HasColumnName("CORE_PAYEE_ID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PayeeId)
                    .HasColumnName("PAYEE_ID")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuId).HasColumnName("PPPU_ID");

                entity.Property(e => e.PppuPosDatefrom)
                    .HasColumnName("PPPU_POS_DATEFROM")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01-JAN-1901')");

                entity.Property(e => e.PppuPosDateto)
                    .HasColumnName("PPPU_POS_DATETO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PppuPosHold).HasColumnName("PPPU_POS_HOLD");

                entity.Property(e => e.PppuPosId).HasColumnName("PPPU_POS_ID");

                entity.Property(e => e.PppuPosIsgroupacct).HasColumnName("PPPU_POS_ISGROUPACCT");

                entity.Property(e => e.PppuPosMethod).HasColumnName("PPPU_POS_METHOD");

                entity.Property(e => e.PppuPosMspOptOut).HasColumnName("PPPU_POS_MSP_OPT_OUT");

                entity.Property(e => e.PppuPosReferencecode)
                    .HasColumnName("PPPU_POS_REFERENCECODE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.PppuPosReferencesystem).HasColumnName("PPPU_POS_REFERENCESYSTEM");

                entity.Property(e => e.PppuPosRrpScc).HasColumnName("PPPU_POS_RRP_SCC");

                entity.Property(e => e.PppuPosTopRole).HasColumnName("PPPU_POS_TOP_ROLE");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pppu)
                    .WithMany(p => p.PppuposPppu)
                    .HasForeignKey(d => d.PppuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPPUPOS_PPPU_ID");

                entity.HasOne(d => d.PppuPos)
                    .WithMany(p => p.PppuposPppuPos)
                    .HasForeignKey(d => d.PppuPosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PPPUPOS_POS_ID");

                entity.HasOne(d => d.PppuPosReferencesystemNavigation)
                    .WithMany(p => p.PppuposPppuPosReferencesystemNavigation)
                    .HasForeignKey(d => d.PppuPosReferencesystem)
                    .HasConstraintName("PPPUPOS_FK_REFSYS_ID");

                entity.HasOne(d => d.PppuPosRrpSccNavigation)
                    .WithMany(p => p.PppuposPppuPosRrpSccNavigation)
                    .HasForeignKey(d => d.PppuPosRrpScc)
                    .HasConstraintName("PPPUPOS_RRP_SCC_FK");

                entity.HasOne(d => d.PppuPosTopRoleNavigation)
                    .WithMany(p => p.Pppupos)
                    .HasForeignKey(d => d.PppuPosTopRole)
                    .HasConstraintName("PPPUPOS_FK_TOP_ROLE");
            });

            modelBuilder.Entity<Pppuroles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PPPUROLES");

                entity.HasIndex(e => e.Createdby)
                    .HasName("PPPUROLES_FK_CREATEDBY");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PPPUROLES");

                entity.HasIndex(e => e.Pppuid)
                    .HasName("PPPUROLES_FK_PPPU");

                entity.HasIndex(e => e.Roleid)
                    .HasName("PPPUROLES_FK_ROLEID");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnName("CREATEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ishistoric).HasColumnName("ISHISTORIC");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.Pppuid).HasColumnName("PPPUID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.PppurolesCreatedbyNavigation)
                    .HasForeignKey(d => d.Createdby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PPPUROLES_FK_CREATEDBY");

                entity.HasOne(d => d.Pppu)
                    .WithMany(p => p.PppurolesPppu)
                    .HasForeignKey(d => d.Pppuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PPPUROLES_FK_PPPU");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Pppuroles)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PPPUROLES_FK_ROLEID");
            });

            modelBuilder.Entity<Pppusecurity>(entity =>
            {
                entity.HasKey(e => e.PppuId);

                entity.ToTable("PPPUSECURITY");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PPPUSECURITY");

                entity.HasIndex(e => e.PppuId)
                    .HasName("PPPUSECURITY_FK_PPPU_ID");

                entity.Property(e => e.PppuId)
                    .HasColumnName("PPPU_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PuscClinical).HasColumnName("PUSC_CLINICAL");

                entity.Property(e => e.PuscEncryptedpassword)
                    .HasColumnName("PUSC_ENCRYPTEDPASSWORD")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PuscFinancial).HasColumnName("PUSC_FINANCIAL");

                entity.Property(e => e.PuscIslockedout).HasColumnName("PUSC_ISLOCKEDOUT");

                entity.Property(e => e.PuscPasswordHash)
                    .HasColumnName("PUSC_PASSWORD_HASH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Swipecardnumber)
                    .HasColumnName("SWIPECARDNUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Swipecardtype).HasColumnName("SWIPECARDTYPE");

                entity.Property(e => e.Usetwofactors).HasColumnName("USETWOFACTORS");

                entity.HasOne(d => d.Pppu)
                    .WithOne(p => p.Pppusecurity)
                    .HasForeignKey<Pppusecurity>(d => d.PppuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PPPUSECURITY_FK_PPPU_ID");
            });

            modelBuilder.Entity<ProfilePatientGroup>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PROFILE_PATIENT_GROUP");

                entity.HasIndex(e => e.ComplexFilterOid)
                    .HasName("PROFILE_PTNT_GRP_FK_CF");

                entity.HasIndex(e => e.GroupCategoryId)
                    .HasName("FK_PATIENT_GROUP_CATEGORY_OID");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_PROFILE_PATIENT_GRO");

                entity.HasIndex(e => e.PpgFirstGroup)
                    .HasName("FK_PPG_FIRST_GROUP");

                entity.HasIndex(e => e.PpgOwner)
                    .HasName("FK_PROFILE_PTNT_GRP_PPG_OWNER");

                entity.HasIndex(e => e.PpgPrivacy)
                    .HasName("FK_PPG_PRIVACY");

                entity.HasIndex(e => e.PpgSecondGroup)
                    .HasName("FK_PPG_SECOND_GROUP");

                entity.HasIndex(e => e.PrivateTo)
                    .HasName("PROFILE_PTNT_GRP_FK_PPPU");

                entity.HasIndex(e => new { e.Name, e.Deletedid, e.PartitionId })
                    .HasName("PROF_PATIENT_GR_I_NAME")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.ComplexFilterOid).HasColumnName("COMPLEX_FILTER_OID");

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupCategoryId).HasColumnName("GROUP_CATEGORY_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PpgComparisonDescription)
                    .HasColumnName("PPG_COMPARISON_DESCRIPTION")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PpgComparisonOutputEnabled).HasColumnName("PPG_COMPARISON_OUTPUT_ENABLED");

                entity.Property(e => e.PpgConditions)
                    .HasColumnName("PPG_CONDITIONS")
                    .HasColumnType("image");

                entity.Property(e => e.PpgDenominatorConditions)
                    .HasColumnName("PPG_DENOMINATOR_CONDITIONS")
                    .HasColumnType("image");

                entity.Property(e => e.PpgDenominatorCountVisible).HasColumnName("PPG_DENOMINATOR_COUNT_VISIBLE");

                entity.Property(e => e.PpgDenominatorDescription)
                    .HasColumnName("PPG_DENOMINATOR_DESCRIPTION")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PpgDescription)
                    .HasColumnName("PPG_DESCRIPTION")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PpgFirstGroup).HasColumnName("PPG_FIRST_GROUP");

                entity.Property(e => e.PpgGroupKind)
                    .HasColumnName("PPG_GROUP_KIND")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PpgNumeratorCountVisible).HasColumnName("PPG_NUMERATOR_COUNT_VISIBLE");

                entity.Property(e => e.PpgNumeratorDescription)
                    .HasColumnName("PPG_NUMERATOR_DESCRIPTION")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PpgNumeratorPercentVisible).HasColumnName("PPG_NUMERATOR_PERCENT_VISIBLE");

                entity.Property(e => e.PpgOperation).HasColumnName("PPG_OPERATION");

                entity.Property(e => e.PpgOwner).HasColumnName("PPG_OWNER");

                entity.Property(e => e.PpgPrivacy).HasColumnName("PPG_PRIVACY");

                entity.Property(e => e.PpgSecondGroup).HasColumnName("PPG_SECOND_GROUP");

                entity.Property(e => e.PpgShowOnMobileDevices).HasColumnName("PPG_SHOW_ON_MOBILE_DEVICES");

                entity.Property(e => e.PpgStatus).HasColumnName("PPG_STATUS");

                entity.Property(e => e.PpgViewsettings)
                    .HasColumnName("PPG_VIEWSETTINGS")
                    .HasColumnType("image");

                entity.Property(e => e.PpgViewsettingssource).HasColumnName("PPG_VIEWSETTINGSSOURCE");

                entity.Property(e => e.PrivateTo).HasColumnName("PRIVATE_TO");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.PpgFirstGroupNavigation)
                    .WithMany(p => p.InversePpgFirstGroupNavigation)
                    .HasForeignKey(d => d.PpgFirstGroup)
                    .HasConstraintName("FK_PPG_FIRST_GROUP");

                entity.HasOne(d => d.PpgOwnerNavigation)
                    .WithMany(p => p.ProfilePatientGroupPpgOwnerNavigation)
                    .HasForeignKey(d => d.PpgOwner)
                    .HasConstraintName("FK_PROFILE_PTNT_GRP_PPG_OWNER");

                entity.HasOne(d => d.PpgPrivacyNavigation)
                    .WithMany(p => p.ProfilePatientGroup)
                    .HasForeignKey(d => d.PpgPrivacy)
                    .HasConstraintName("FK_PPG_PRIVACY");

                entity.HasOne(d => d.PpgSecondGroupNavigation)
                    .WithMany(p => p.InversePpgSecondGroupNavigation)
                    .HasForeignKey(d => d.PpgSecondGroup)
                    .HasConstraintName("FK_PPG_SECOND_GROUP");

                entity.HasOne(d => d.PrivateToNavigation)
                    .WithMany(p => p.ProfilePatientGroupPrivateToNavigation)
                    .HasForeignKey(d => d.PrivateTo)
                    .HasConstraintName("PROFILE_PTNT_GRP_FK_PPPU");
            });

            modelBuilder.Entity<Shortcode>(entity =>
            {
                entity.HasKey(e => e.ShcdId);

                entity.ToTable("SHORTCODE");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_SHORTCODE");

                entity.HasIndex(e => e.ShcdParentid)
                    .HasName("FK_SHORTCODE_SHCD_PARENTID");

                entity.HasIndex(e => e.ShcdRoleid)
                    .HasName("FK_SHORTCODE_SHCD_ROLEID");

                entity.HasIndex(e => e.ShcdType)
                    .HasName("SHORTCODE_FK_SHCD_TYPE");

                entity.HasIndex(e => new { e.ShcdSysid, e.ShcdDeletedid, e.PartitionId })
                    .HasName("SHORTCODE_SYSID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShcdCode, e.ShcdType, e.ShcdOwnerpppuid, e.ShcdDeletedid, e.PartitionId })
                    .HasName("CODETYPEDELETEDID")
                    .IsUnique();

                entity.Property(e => e.ShcdId)
                    .HasColumnName("SHCD_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdAdded)
                    .HasColumnName("SHCD_ADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShcdAllowadminenc).HasColumnName("SHCD_ALLOWADMINENC");

                entity.Property(e => e.ShcdBeginnum)
                    .HasColumnName("SHCD_BEGINNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdCaselevel).HasColumnName("SHCD_CASELEVEL");

                entity.Property(e => e.ShcdChanged)
                    .HasColumnName("SHCD_CHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShcdCode)
                    .IsRequired()
                    .HasColumnName("SHCD_CODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdColor)
                    .HasColumnName("SHCD_COLOR")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ShcdComment)
                    .HasColumnName("SHCD_COMMENT")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdCurnum)
                    .HasColumnName("SHCD_CURNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdDeletedid).HasColumnName("SHCD_DELETEDID");

                entity.Property(e => e.ShcdDescription)
                    .HasColumnName("SHCD_DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdEmphasis).HasColumnName("SHCD_EMPHASIS");

                entity.Property(e => e.ShcdEndnum)
                    .HasColumnName("SHCD_ENDNUM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdExtactivity).HasColumnName("SHCD_EXTACTIVITY");

                entity.Property(e => e.ShcdIncludefont).HasColumnName("SHCD_INCLUDEFONT");

                entity.Property(e => e.ShcdMacro)
                    .HasColumnName("SHCD_MACRO")
                    .HasColumnType("image");

                entity.Property(e => e.ShcdOutput)
                    .HasColumnName("SHCD_OUTPUT")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ShcdOverrun).HasColumnName("SHCD_OVERRUN");

                entity.Property(e => e.ShcdOwnerpppuid).HasColumnName("SHCD_OWNERPPPUID");

                entity.Property(e => e.ShcdParentid).HasColumnName("SHCD_PARENTID");

                entity.Property(e => e.ShcdPatientcontact).HasColumnName("SHCD_PATIENTCONTACT");

                entity.Property(e => e.ShcdRate)
                    .HasColumnName("SHCD_RATE")
                    .HasColumnType("currency");

                entity.Property(e => e.ShcdRate2)
                    .HasColumnName("SHCD_RATE2")
                    .HasColumnType("currency");

                entity.Property(e => e.ShcdReadonly).HasColumnName("SHCD_READONLY");

                entity.Property(e => e.ShcdRoleid).HasColumnName("SHCD_ROLEID");

                entity.Property(e => e.ShcdRtftext)
                    .HasColumnName("SHCD_RTFTEXT")
                    .HasColumnType("image");

                entity.Property(e => e.ShcdSysid).HasColumnName("SHCD_SYSID");

                entity.Property(e => e.ShcdTag).HasColumnName("SHCD_TAG");

                entity.Property(e => e.ShcdType).HasColumnName("SHCD_TYPE");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ShcdParent)
                    .WithMany(p => p.InverseShcdParent)
                    .HasForeignKey(d => d.ShcdParentid)
                    .HasConstraintName("FK_SHORTCODE_SHCD_PARENTID");

                entity.HasOne(d => d.ShcdRole)
                    .WithMany(p => p.Shortcode)
                    .HasForeignKey(d => d.ShcdRoleid)
                    .HasConstraintName("FK_SHORTCODE_SHCD_ROLEID");

                entity.HasOne(d => d.ShcdTypeNavigation)
                    .WithMany(p => p.Shortcode)
                    .HasForeignKey(d => d.ShcdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SHORTCODE_FK_SHCD_TYPE");
            });

            modelBuilder.Entity<ShortcodeType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("SHORTCODE_TYPE");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_SHORTCODE_TYPE");

                entity.HasIndex(e => e.ParentTypeId)
                    .HasName("FK_SHORTCODE_TYPE_PARENT");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deletedid).HasColumnName("DELETEDID");

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Editable).HasColumnName("EDITABLE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.ParentTypeId).HasColumnName("PARENT_TYPE_ID");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.ParentType)
                    .WithMany(p => p.InverseParentType)
                    .HasForeignKey(d => d.ParentTypeId)
                    .HasConstraintName("FK_SHORTCODE_TYPE_PARENT");
            });

            modelBuilder.Entity<UserSecurityLog>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("USER_SECURITY_LOG");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_USER_SECURITY_LOG");

                entity.HasIndex(e => e.UslCategoryid)
                    .HasName("USL_CATEGORYID_FK");

                entity.HasIndex(e => e.UslChangedUser)
                    .HasName("FK_USL_CHANGED_USER_CH_USER");

                entity.HasIndex(e => e.UslEntryid)
                    .HasName("USL_ENTRYID_FK");

                entity.HasIndex(e => e.UslPatientid)
                    .HasName("USL_PATIENTID_FK");

                entity.HasIndex(e => e.UslUserid)
                    .HasName("USL_USERID_FK");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UslCategoryid).HasColumnName("USL_CATEGORYID");

                entity.Property(e => e.UslChangedUser).HasColumnName("USL_CHANGED_USER");

                entity.Property(e => e.UslComputername)
                    .HasColumnName("USL_COMPUTERNAME")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.UslCreated)
                    .HasColumnName("USL_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.UslDetails)
                    .HasColumnName("USL_DETAILS")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.UslDetailsExt)
                    .HasColumnName("USL_DETAILS_EXT")
                    .HasColumnType("image");

                entity.Property(e => e.UslEntryid).HasColumnName("USL_ENTRYID");

                entity.Property(e => e.UslIp)
                    .HasColumnName("USL_IP")
                    .HasMaxLength(252)
                    .IsUnicode(false);

                entity.Property(e => e.UslPatientid).HasColumnName("USL_PATIENTID");

                entity.Property(e => e.UslUserid).HasColumnName("USL_USERID");

                entity.HasOne(d => d.UslCategory)
                    .WithMany(p => p.UserSecurityLogUslCategory)
                    .HasForeignKey(d => d.UslCategoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("USL_CATEGORYID_FK");

                entity.HasOne(d => d.UslChangedUserNavigation)
                    .WithMany(p => p.UserSecurityLogUslChangedUserNavigation)
                    .HasForeignKey(d => d.UslChangedUser)
                    .HasConstraintName("FK_USL_CHANGED_USER_CH_USER");

                entity.HasOne(d => d.UslEntry)
                    .WithMany(p => p.UserSecurityLogUslEntry)
                    .HasForeignKey(d => d.UslEntryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("USL_ENTRYID_FK");

                entity.HasOne(d => d.UslPatient)
                    .WithMany(p => p.UserSecurityLog)
                    .HasForeignKey(d => d.UslPatientid)
                    .HasConstraintName("USL_PATIENTID_FK");

                entity.HasOne(d => d.UslUser)
                    .WithMany(p => p.UserSecurityLogUslUser)
                    .HasForeignKey(d => d.UslUserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("USL_USERID_FK");
            });

            modelBuilder.Entity<ViewAudit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("VIEW_AUDIT");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_VIEW_AUDIT");

                entity.HasIndex(e => e.VaudParent)
                    .HasName("FK_VIEW_AUDIT_PARENT");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.VaudEntryTime)
                    .HasColumnName("VAUD_ENTRY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.VaudExitTime)
                    .HasColumnName("VAUD_EXIT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.VaudFilterName)
                    .HasColumnName("VAUD_FILTER_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VaudKind).HasColumnName("VAUD_KIND");

                entity.Property(e => e.VaudObjectCid).HasColumnName("VAUD_OBJECT_CID");

                entity.Property(e => e.VaudObjectOid).HasColumnName("VAUD_OBJECT_OID");

                entity.Property(e => e.VaudParent).HasColumnName("VAUD_PARENT");

                entity.Property(e => e.VaudRootParentCid).HasColumnName("VAUD_ROOT_PARENT_CID");

                entity.Property(e => e.VaudRootParentOid).HasColumnName("VAUD_ROOT_PARENT_OID");

                entity.Property(e => e.VaudViewIndex).HasColumnName("VAUD_VIEW_INDEX");

                entity.HasOne(d => d.VaudParentNavigation)
                    .WithMany(p => p.InverseVaudParentNavigation)
                    .HasForeignKey(d => d.VaudParent)
                    .HasConstraintName("FK_VIEW_AUDIT_PARENT");
            });

            modelBuilder.Entity<Workstation>(entity =>
            {
                entity.HasKey(e => e.WrksId);

                entity.ToTable("WORKSTATION");

                entity.HasIndex(e => e.ObjGuid)
                    .HasName("OBJ_GUID_I_WORKSTATION");

                entity.HasIndex(e => e.PppuIdPos)
                    .HasName("WRKS_PPPU_FOREIGN");

                entity.HasIndex(e => new { e.WrksName, e.PartitionId })
                    .HasName("WRKS_NAME")
                    .IsUnique();

                entity.Property(e => e.WrksId)
                    .HasColumnName("WRKS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtModified)
                    .HasColumnName("DT_MODIFIED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjGuid)
                    .IsRequired()
                    .HasColumnName("OBJ_GUID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.PartitionId).HasColumnName("PARTITION_ID");

                entity.Property(e => e.PppuIdPos).HasColumnName("PPPU_ID_POS");

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RefSys)
                    .HasColumnName("REF_SYS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WrksIpaddress)
                    .HasColumnName("WRKS_IPADDRESS")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.WrksName)
                    .IsRequired()
                    .HasColumnName("WRKS_NAME")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.PppuIdPosNavigation)
                    .WithMany(p => p.Workstation)
                    .HasForeignKey(d => d.PppuIdPos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WRKS_PPPU_FOREIGN");
            });
        }
    }
}
