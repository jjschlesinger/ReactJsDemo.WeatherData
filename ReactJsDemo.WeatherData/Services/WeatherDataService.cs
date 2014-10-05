using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Newtonsoft.Json;

namespace ReactJsDemo.WeatherData.Services
{
    public class WeatherDataService
    {
        public IEnumerable<dynamic> GetLocal()
        {
            var jsonObjects = JsonConvert.DeserializeObject<IEnumerable<dynamic>>(File.ReadAllText(GetJsonFilePath()));
            return jsonObjects;
        }

        private string GetJsonFilePath()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).CodeBase);
            appPath = new Uri(appPath).LocalPath;
            return Path.Combine(appPath, "App_Data\\WeatherSource\\history_by_postal_code.json");
        }
    }
}