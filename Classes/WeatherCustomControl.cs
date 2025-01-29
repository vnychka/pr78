using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using pr78.Classes;


namespace pr78.Classes
{
    public partial class WeatherCustomControl : UserControl
    {
        private ComplexWeatherInfo _weather;

        public WeatherCustomControl()
        {
            InitializeComponent();
        }
        
        public WeatherCustomControl(ComplexWeatherInfo complex)
        {
            InitializeComponent();
            Fill(complex);
        }

        public void Fill(ComplexWeatherInfo complex)
        {
            _weather = complex ?? throw new ArgumentNullException(nameof(_weather));
            label_Time.Content = _weather.Time;
            label_Humidity.Content = _weather.Humidity;
            label_Type.Content = _weather.Weather.Name;
            label_Time.Content = _weather.Time;
        }
    }
}
