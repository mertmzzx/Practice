namespace Zad26
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 3 || n > 10000)
                {
                    throw new Exception("Невалиден брой зрелостници!");
                }

                List<double> validWorks = ReadPoints(n);

                double minDpoints = MinDpoints(validWorks);

                Console.WriteLine($"valid works - {validWorks.Count}");
                Console.WriteLine($"minimal difference - {minDpoints:f3} p.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<double> ReadPoints(int n)
        {
            List<double> validWorks = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points < -100 || points > 100)
                {
                    throw new Exception("Невалиден брой точки!");
                }

                if (points > 0)
                {
                    validWorks.Add(points);
                }
            }

            return validWorks;
        }

        public static double MinDpoints(List<double> works)
        {
            double minDpoints = double.MaxValue;
            for (int i = 0; i < works.Count; i++)
            {
                for (int j = i+1; j < works.Count; j++)
                {
                    if (works[i] != works[j])
                    {
                        double dPoints = Math.Abs(works[i] - works[j]);

                        if (dPoints < minDpoints)
                        {
                            minDpoints = dPoints;
                        }
                    }
                }
            }

            return minDpoints;
        }
    }
}