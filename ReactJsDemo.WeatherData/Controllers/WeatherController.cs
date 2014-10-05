using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using Newtonsoft.Json;
using ReactJsDemo.WeatherData.Services;

namespace ReactJsDemo.WeatherData.Controllers
{
    public class WeatherController : ApiController
    {
        private readonly WeatherDataService _weatherDataService;

        public WeatherController() : this(new WeatherDataService())
        {
            
        }
        public WeatherController(WeatherDataService weatherDataService)
        {
            _weatherDataService = weatherDataService;
        }

        public IEnumerable<object> Get()
        {
            return _weatherDataService.GetLocal();
        }

    }
}
