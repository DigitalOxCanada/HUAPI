using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Address
    {
        public Address()
        {
            Appointment = new HashSet<Appointment>();
        }

        public long Oid { get; set; }
        public long AddressType { get; set; }
        public long? PtntId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public long? Postalstate { get; set; }
        public string Building { get; set; }
        public long? Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public string Direction { get; set; }
        public string GeoCoordX { get; set; }
        public string GeoCoordY { get; set; }
        public string Meshblock { get; set; }
        public string Quintile { get; set; }
        public string GeoDhb { get; set; }
        public string GeoUncertaintycode { get; set; }
        public double? GeoLatitude { get; set; }
        public double? GeoLongitude { get; set; }
        public long GeoStatus { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long? NokRelationship { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Sourceref { get; set; }
        public short Isinactive { get; set; }
        public string ObjGuid { get; set; }
        public string Cellphone { get; set; }
        public string Workphone { get; set; }
        public string Decile { get; set; }
        public string DomicileCode { get; set; }
        public string TlaName { get; set; }
        public string DomicileDescription { get; set; }
        public long Deletedid { get; set; }
        public long? ModifiedBy { get; set; }

        public Shortcode AddressTypeNavigation { get; set; }
        public Pppu ModifiedByNavigation { get; set; }
        public Lookuplist NokRelationshipNavigation { get; set; }
        public Lookuplist PostalstateNavigation { get; set; }
        public Patient Ptnt { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}
