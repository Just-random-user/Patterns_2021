using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VehicleBuilder> vehicles = new List<VehicleBuilder>();
            List<Driver> drivers = new List<Driver>();
            List<Passenger> passengers = new List<Passenger>();
            Console.Write("Choose the vehicle: 0 for bus, 1 for taxi: ");
            while (true)
            {
                Console.Write("Enter comand code:" + Environment.NewLine +
                    "1 - Add item" + Environment.NewLine +
                    "2 - List items" + Environment.NewLine +
                    "3 - Load/unload mode" + Environment.NewLine +
                    "4 - Launch a vehicle" + Environment.NewLine +
                    "0 - Exit " + Environment.NewLine +
                    "Comand code: ");
                int choise;
                try
                {
                    choise = int.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }

                switch (choise)
                {
                    case 0:
                        {
                            return;
                        }
                    case 1:
                        {
                            Console.WriteLine("Type: 1 for vehicle, 2 for driver and 3 for passenger");
                            int create, amount, ans;
                            VehicleList chosenVehicle;
                            try
                            {
                                create = int.Parse(Console.ReadLine());
                                Console.WriteLine("How much?");
                                amount = int.Parse(Console.ReadLine());
                                if (amount < 0) throw new IndexOutOfRangeException();
                                Console.WriteLine("What type: 0 for Bus or 1 for Taxi");
                                ans = int.Parse(Console.ReadLine());
                                chosenVehicle = (VehicleList)ans;
                            }
                            catch
                            {
                                break;
                            }
                            switch (create)
                            {
                                case 1:
                                    {
                                        if (chosenVehicle == VehicleList.Bus)
                                        {
                                            for (int i = 0; i < amount; i++)
                                            {
                                                vehicles.Add(new BusBuilder());
                                            }
                                        }
                                        else if (chosenVehicle == VehicleList.Taxi)
                                        {
                                            for (int i = 0; i < amount; i++)
                                            {
                                                vehicles.Add(new TaxiBuilder());
                                            }
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        for (int i = 0; i < amount; i++)
                                        {
                                            drivers.Add(new Driver(chosenVehicle));
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        for (int i = 0; i < amount; i++)
                                        {
                                            Console.WriteLine("Is child and is beneficial? Pattern: '0 0'");
                                            bool child = bool.Parse(Console.ReadLine());
                                            bool benef = bool.Parse(Console.ReadLine());
                                            passengers.Add(new Passenger(child, benef));
                                        }
                                        break;
                                    }
                                default: { break; }
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (var item in vehicles)
                            {
                                item.ToString();
                                Console.WriteLine();
                            }
                            foreach (var item in drivers)
                            {
                                item.ToString();
                                Console.WriteLine();
                            }
                            foreach (var item in passengers)
                            {
                                item.ToString();
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                int who, amount, ans;
                                VehicleList chosenVehicle;

                                Console.WriteLine("Type: 1 for Bus or 2 for Taxi");
                                ans = int.Parse(Console.ReadLine());
                                chosenVehicle = (VehicleList)ans;

                                Console.WriteLine("Who: 1 for driver or 2 for passengers");
                                who = int.Parse(Console.ReadLine());

                                if (who == 2)
                                {
                                    Console.WriteLine("How much?");
                                    amount = int.Parse(Console.ReadLine());
                                    if (amount < 0) throw new IndexOutOfRangeException();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            break;
                        }

                }
            }
        }
    }
}
