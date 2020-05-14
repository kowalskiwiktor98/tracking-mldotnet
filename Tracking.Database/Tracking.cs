using System;
using System.Collections.Generic;

namespace Tracking.Database
{
    public partial class Tracking
    {
        public int? Id { get; set; }
        public string ShipmentIdentcode { get; set; }
        public long? ContractTypeId { get; set; }
        public DateTime? ShipmentCreatedate { get; set; }
        public long? UnixShipmentCreatedate { get; set; }
        public DateTime? FirstEvent { get; set; }
        public long? UnixFirstEvent { get; set; }
        public DateTime? LastEvent { get; set; }
        public long? UnixLastEvent { get; set; }
        public long? UnixDifference { get; set; }
        public string ReceiverCountryCode { get; set; }
        public string ReceiverCityName { get; set; }
        public string ReceiverZip { get; set; }
        public decimal? ReceiverLatitude { get; set; }
        public decimal? ReceiverLongitude { get; set; }
        public string SenderCountryCode { get; set; }
        public string SenderCityName { get; set; }
        public string SenderZip { get; set; }
        public decimal? SenderLatitude { get; set; }
        public decimal? SenderLongitude { get; set; }
        public float? Distance { get; set; }
    }
}
