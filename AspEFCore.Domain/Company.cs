using System;
using System.Collections.Generic;

namespace AspEFCore.Domain
{
    public class Company
    {
        public Company()
        {
            CityCompanies = new List<CityCompany>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EstablishData { get; set; }
        public string LegalPerson { get; set; }
        public List<CityCompany> CityCompanies { get; set; }
    }
}
