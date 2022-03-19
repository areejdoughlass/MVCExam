using MVCExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Services
{
    public class CountryService : ICountryService
    {
        HRContext context;
        public CountryService(HRContext _context)
        {
            context = _context;
        }

        public List<Country> LoadCountries()
        {
            List<Country> liCountry = context.country.ToList();
            return liCountry;
        }
    }
    
}
