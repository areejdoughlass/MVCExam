using MVCExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Services
{
   public  interface ICountryService
    {
        List<Country> LoadCountries();
    }
}
