using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Objects
{
    public class CarObj
{
    public long CarId { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public int ImageCount { get; set; }
    public string SharingLink { get; set; }
    public string Milage { get; set; }
    public int MakeId { get; set; }
    public int ModelId { get; set; }
    public int BodyId { get; set; }
    public int Year { get; set; }
    public string Model { get; set; }
    public string Body { get; set; }
    public AuctionObj AuctionObj { get; set; }
}
}
