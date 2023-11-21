namespace Zad1._2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Weather
    {
        public Weather(string date, double temperature)
        {
            Date = date;
            Temperature = temperature;
        }

        public string Date { get; set; }

        public double Temperature { get; set; }
    }
}
