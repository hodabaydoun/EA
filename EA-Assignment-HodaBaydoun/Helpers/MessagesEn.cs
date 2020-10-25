using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Helpers
{
    public class MessagesEn: Messages
{
    private Dictionary<string, string> m = new Dictionary<string, string>();

    public MessagesEn()
    {
        m.Add("description", "");
        m.Add("sharingMsg", "Emirates Auction\n2013 Mini - Cooper S for auction\nLot# 101950\nCurrentPrice: AED 19,100\nAuction Ends on 4 Jul 6:00 PM")
       //Here we need to add all other messages
    }
    public string GetMessage(string key)
    {
        return this.m.GetValueOrDefault(key);
    }
}
}
