using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace weather.Models
{
    public class weather_stuff
    {
        public object GetCurrentWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Detroit&APPID=f034c681a6edc9235b67986bf6d680cc&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<object>(content);

            return jsonContent;

        }
    }
}