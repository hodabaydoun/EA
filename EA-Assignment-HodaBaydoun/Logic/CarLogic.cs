using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Logic
{
    public class CarLogic : ICarLogic
{
    private ICarsRepo repo { get; set; }
    private Messages GetMessages (string lang)
    {
        switch(lang)
        {
            case "ar": return new MessagesAr();
            case "en": return new MessagesEn();
        }
        return new MessagesEn();
    }
    public IEnumerable<CarObj> GetAll(int start, int end, string lang = "en")
    {
        IEnumerable<CarsModel> cars = repo.GetAll(start, end);
        IEnumerable<CarObj> carsObj = new List<CarObj>();
        Messages m = GetMessages(lang);
        foreach (CarsModel car in cars)
        {
            CarObj carObj = new CarObj();
            carObj.Body = m.GetMessage(car.Body);
            //Here we set other attributes with their messages in specific language
            carsObj.Append(carObj);
        }
        return carsObj;
    }
}
}
