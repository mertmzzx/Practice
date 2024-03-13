namespace Zad28
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string rallyName = Console.ReadLine();
                int rallyYear = int.Parse(Console.ReadLine());

                if (rallyName.Length < 0 && rallyYear < 0)
                {
                    throw new Exception("Invalid rally info!");
                }

                Rally rally = new Rally(rallyName, rallyYear);


                Console.WriteLine("[a]dd [v]iew [q]uit");
                string input = Console.ReadLine();

                while (input != "q")
                {
                    if (input == null || input.Length < 1)
                    {
                        throw new Exception("The selected option is invalid!");
                    }

                    if (input == "a")
                    {
                        Console.Write("Pilot name: ");
                        string pName = Console.ReadLine();

                        if (pName.Length < 0)
                        {
                            throw new Exception("Invalid Pilot Name!");
                        }

                        Console.Write("Age: ");
                        int pAge = int.Parse(Console.ReadLine());

                        if (pAge < 18)
                        {
                            throw new Exception("Invalid Pilot Age!");
                        }

                        Console.Write("Category (A|B|C): ");
                        string pCategory = Console.ReadLine();

                        if (pCategory != "A" && pCategory != "B" && pCategory != "C")
                        {
                            throw new Exception("Invalid Pilot Category!");
                        }

                        Console.Write("Car model: ");
                        string carModel = Console.ReadLine();

                        if (carModel.Length < 0)
                        {
                            throw new Exception("Invalid Car Model!");
                        }

                        Console.Write("Car power (hp): ");
                        int carHp = int.Parse(Console.ReadLine());

                        if (carHp < 0)
                        {
                            throw new Exception("Invalid Car HorsePower!");
                        }

                        Car car = new Car(carModel, carHp);
                        Pilot pilot = new Pilot(pName, pAge, car, pCategory);
                        rally.AddPilot(pilot);
                    }
                    else if (input == "v")
                    {
                        Console.WriteLine(rally.ToString());
                    }
                    else if (input == "q")
                    {
                        return;
                    }

                    Console.WriteLine("[a]dd [v]iew [q]uit");
                    input = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}