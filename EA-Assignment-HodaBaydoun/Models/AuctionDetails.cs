using System;

namespace EA-Assignment-HodaBaydoun.Models
{
    public class AuctionDetails
    {
        public long BidsCount { get; set; }
        public DateTime EndDate { get; set; }
        public string Currency { get; set; }
        public int Lot { get; set; }
        public int Priority { get; set; }
        public int VATPercent { get; set; }
        public bool IsModified { get; set; }
        public int ItemId { get; set; }
        public int ICarId { get; set; }
        public string IVinNumber { get; set; }
    }
}
