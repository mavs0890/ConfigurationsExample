using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationsExample.Configuration
{
    public class AppConfig
    {
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public AppConfiguration AppConfiguration { get; set; }
    }
}
