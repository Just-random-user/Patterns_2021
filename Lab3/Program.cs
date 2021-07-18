using System;

namespace PatternsLab3
{
    class Program
    {
        //take 160 psngrs
        static uint MaxWeight = 1500;
        static void Main(string[] args)
        {
            var stewardesses = new CStewardess();
            var pilots = new CPilots();
            var class1 = new CClass1();
            var classb = new CClassB();
            var classe = new CClassE();

            while (stewardesses.stewardess.Count < stewardesses.MaxObjectAmount)
                stewardesses.AddUnit(new PStewardess());
            while (pilots.pilots.Count < pilots.MaxObjectAmount)
                pilots.AddUnit(new PPilot());

            Console.WriteLine("Enter amount of passengers");
            int amount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < amount; i++)
            {
                var psng = getRandomPassenger();
                AssignPassengerToClass(ref psng, ref class1, ref classb, ref classe);
            }

            Console.WriteLine("Pilots:");
            foreach (PPilot item in pilots.pilots)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            Console.WriteLine("Stewardesses:");
            foreach (PStewardess item in stewardesses.stewardess)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            uint counter = 1;
            Console.WriteLine("Class1:");
            foreach (PPassenger item in class1.passengers)
            {
                Console.Write($"Seat #C {counter++}\t");
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            counter = 1;
            Console.WriteLine("Buisness Class:");
            foreach (PPassenger item in classb.passengers)
            {
                Console.Write($"Seat #B {counter++}\t");
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            counter = 1;
            Console.WriteLine("Economy Class:");
            foreach (PPassenger item in classe.passengers)
            {
                Console.Write($"Seat #E {counter++}\t");
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static PPassenger getRandomPassenger()
        {
            var rand = new Random();
            return new PPassenger((uint)rand.Next(1, 50));
        }
        public static void AssignPassengerToClass(ref PPassenger passenger,
            ref CClass1 c1, ref CClassB cb, ref CClassE ce)
        {
            if (passenger.GetLaggageWeight() > 35)
                c1.AddUnit(passenger);
            else if (passenger.GetLaggageWeight() > 20)
                cb.AddUnit(passenger);
            else ce.AddUnit(passenger);


            while (c1.GetLaggageWeight() + cb.GetLaggageWeight() + ce.GetLaggageWeight() > MaxWeight)
            {
                PPassenger target = (PPassenger)ce.passengers.Find(psng => (psng as PPassenger).LuggageWeight != 0);
                target.LuggageWeight = 0;
            }
        }
    }
}
