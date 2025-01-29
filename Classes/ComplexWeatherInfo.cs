using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pr78.DataModel;

namespace pr78.Classes
{
    public class ComplexWeatherInfo
    {
        private string _time;

        public string Time
        {
            get { return _time; }
            set { _time = value ?? throw
                    new ArgumentNullException(nameof(_time)); 
            }
        }

        private Type_of_weather _weather;
        public Type_of_weather Weather
        {
            get { return _weather; }
            set
            {
                _weather = value?? 
                    throw new ArgumentNullException(nameof(_weather));
            }
        }

        public double Tempreture { get; set; }
        public double Humidity { get; set; }

        public ComplexWeatherInfo(string time, Type_of_weather weather, double tempreture, double humidity)
        {
            Time = time;
            Weather = weather;
            Tempreture = tempreture;
            Humidity = humidity;
        }
    }
}
