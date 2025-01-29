using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using pr78.Classes;
using pr78.CustomControls;
using pr78.DataModel;

namespace pr78.Windows
{
    /// <summary>
    /// Логика взаимодействия для ShowWeatherAtTimeWindow.xaml
    /// </summary>
    public partial class ShowWeatherAtTimeWindow : Window
    {
        private Prognosis prognosis;

        // Изменённый конструктор окна
        public ShowWeatherAtTimeWindow(Prognosis prog)
        {
            InitializeComponent();
            prognosis = prog;
            LabelContent.Content += " " + prognosis.Date.Value.ToShortDateString();
            LoadDataWrapPanel(prog.Time);
        }

        // Метод для обновления данных объекта полученных с окна
        private void LoadDataWrapPanel(string info)
        {
            List<ComplexWeatherInfo> infos;

            // Десериализация объекта Xml в объект класса List<ComplexWeatherInfo>
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ComplexWeatherInfo>));

            using (StringReader reader = new StringReader(info))
            {
                infos = xmlSerializer.Deserialize(reader) as List<ComplexWeatherInfo>;
            }

            // Загрузка в wrapPanelWeather новых элементов WeatherCustomControl
            // С данными из десериализованного объекта Xml
            infos.ForEach(item => wrapPanelWeather.Children.Add(new WeatherCustomControl(item)));
        }
    }
}
