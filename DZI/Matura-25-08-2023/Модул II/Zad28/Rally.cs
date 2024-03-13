namespace Zad28
{
    using System.Text;

    public class Rally
    {
        public Rally(string name, int year)
        {
            Name = name;
            Year = year;
            Pilots = new List<Pilot>();
        }

        public string Name { get; set; }

        public int Year { get; set; }

        public List<Pilot> Pilots { get; set; }

        public void AddPilot(Pilot pilot)
        {
            if (pilot == null)
            {
                throw new Exception("Incorrect pilot!");
            }

            this.Pilots.Add(pilot);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rally: {this.Name} - {this.Year}");

            foreach (var p in Pilots)
            {
                string pilotInfo = p.ToString();
                sb.AppendLine(pilotInfo);
            }

            return sb.ToString().Trim();
        }
    }
}
