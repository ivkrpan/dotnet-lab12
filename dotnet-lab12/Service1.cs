using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace dotnet_lab12
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        List<Klub> sviKlubovi = new List<Klub>()
        {
            new Klub(1, "klub1", "Rukomet", "Hrvatska", 1945),
            new Klub(2, "drugi", "Kosarka", "UK", 1950),
            new Klub(3, "treci33", "Vaterpolo", "Rusija", 1921),
            new Klub(4, "cetvrti", "Bejzbol", "Francuska", 1918),
            new Klub(12, "test", "Nogomet", "Njemacka", 1920),
        };

        public Klub DajKlub(string id)
        {
            try
            {
                int praviId = Int32.Parse(id);
                return sviKlubovi.Find(klub => klub.Id == praviId);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ID nije ispravan!");
            }
        }

        public List<Klub> DajSveKlubove()
        {
            return sviKlubovi;
        }
    }
}
