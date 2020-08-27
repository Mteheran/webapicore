using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapicore.Services;

namespace webapicore.Helpers
{
    public class DataGenerator
    {
        IDataService dataService;

        public DataGenerator(IDataService dataservice)
        {
            dataService = dataservice;
        }
        
    }
}