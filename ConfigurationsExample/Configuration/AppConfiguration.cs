using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationsExample.Configuration
{
    public class AppConfiguration
    {
        public int TimeOut { get; set; }
        public string DefaultDbConnection { get; set; }
        public FallbackDb[] FallbackDb { get; set; }
    }
}
