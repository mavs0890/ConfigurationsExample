using ConfigurationsExample.Configuration;
using ConfigurationsExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationsExample.Controllers
{
    [Route("[controller]")]
    public class ConfigurationsController : Controller
    {
        private readonly IOptions<AppConfig> _options;

        public ConfigurationsController(IOptions<AppConfig> options)
        {
            _options = options;
        }

        [Route("")]
        public IActionResult Configurations()
        {
            var model = new ConfigurationModel()
            {
                CreatedTime = _options.Value.CreationTime
            };
            return View(model);
        }
    }
}
