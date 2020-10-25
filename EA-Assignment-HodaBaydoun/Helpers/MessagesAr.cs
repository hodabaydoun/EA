using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Helpers
{
    public class MessagesAr: Messages
{
    private Dictionary<string,string> m = new Dictionary<string, string>();

    public MessagesAr()
    {
        m.Add("description", "");
        m.Add("sharingMsg", "السعر الحالي: 100,n19 تسلسل# n101950\میني - كوبر اس للبیع بالمزاد n2013")
       //Here we need to add all other messages
    }
    public string GetMessage(string key)
    {
        return this.m.GetValueOrDefault(key);
    }
}
}