namespace Zad1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Weather> weathers = new List<Weather>();
            double lowestTemp = 1000;

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Въведете дата(day.month.year): ");
                string date = Console.ReadLine();

                Console.WriteLine("Въведете температура както следва: ");
                Console.WriteLine("Сутрин: ");
                double morning = double.Parse(Console.ReadLine());

                Console.WriteLine("Обед: ");
                double noon = double.Parse(Console.ReadLine());

                Console.WriteLine("Вечер: ");
                double night = double.Parse(Console.ReadLine());

                lowestTemp = LowestTemp(lowestTemp, morning, noon, night);
                double avgTemp = (morning + noon + night) / 3;

                Weather weather = new Weather(date, avgTemp);
                weathers.Add(weather);
            }

            if (weathers[0].Temperature > weathers[1].Temperature)
            {
                Console.WriteLine($"Денят с най-висока средна температура е {weathers[0].Date} г. с {weathers[0].Temperature:f2}°C");
            }
            else
            {
                Console.WriteLine($"Денят с най-висока средна температура е {weathers[1].Date} г. с {weathers[1].Temperature:f2}°C");
            }

            Console.WriteLine($"Най-ниската измерена температура през двата дни е {lowestTemp}°C");
        }

        public static double LowestTemp(double lowestTemp, double morning, double noon, double night)
        {
            if (morning < noon && morning < night && morning < lowestTemp)
            {
                lowestTemp = morning;
            }
            else if (noon < morning && noon < night && noon < lowestTemp)
            {
                lowestTemp = noon;
            }
            else if (night < morning && night < noon && night < lowestTemp)
            {
                lowestTemp = night;
            }

            return lowestTemp;
        }
    }
}