using System;
using System.Collections.Generic;
using System.Linq;

namespace AW_FullStack_Checkpoint_RacingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the races!\n");
            Console.ReadLine();
            Console.WriteLine("Next up is Spa-Francochamps, get ready to race!\n");
            Console.ReadLine();
            Console.WriteLine("Racing...");
            Console.ReadLine();




            List<Car> carList = new List<Car>()
            {
                new Car("Red Bull Racing", "Red Bull Power Unit", new Driver("Max Verstappen")),
                new Car("Red Bull Racing", "Red Bull Power Unit", new Driver("Sergio Perez")),
                new Car("Scuderia Ferrari", "Ferrari", new Driver("Charles Lecler")),
                new Car("Scuderia Ferrari", "Ferrari", new Driver("Carlos Sainz")),
                new Car("Mercedes AMG", "Mercedes", new Driver("Lewis Hamilton")),
                new Car("Mercedes AMG", "Mercedes", new Driver("George Russell")),
                new Car("McLaren Racing", "Mercedes", new Driver("Lando Norris")),
                new Car("McLaren Racing", "Mercedes", new Driver("Daniel Ricciardo")),
                new Car("Alpine", "Renault", new Driver("Fernando Alonso")),
                new Car("Alpine", "Renault", new Driver("Esteban Ocon")),
                new Car("Alfa Romeo", "Ferrari", new Driver("Valtteri Bottas")),
                new Car("Alfa Romeo", "Ferrari", new Driver("Gionghou Zhou")),
                new Car("Williams Racing", "Mercedes", new Driver("Alex Albon")),
                new Car("Williams Racing", "Mercedes", new Driver("Nicholas Latifi")),
                new Car("Haas F1", "Ferrari", new Driver("Kevin Magnussen")),
                new Car("Haas F1", "Ferrari", new Driver("Mick Schumacher")),
                new Car("Aston Martin Racing", "Mercedes", new Driver("Lance Stroll")),
                new Car("Aston Martin Racing", "Mercedes", new Driver("Sebastian Vettel")),
                new Car("Alpha Tauri", "Red Bull Power Unit", new Driver("Pierre Gasly")),
                new Car("Alpha Tauri", "Red Bull Power Unit", new Driver("Yuki Zunoda")),
            };

            Random r = new Random();
            int place = 0;
            List<int> p_list = new List<int>();
            foreach(var t in carList)
            {
                place = r.Next(1, 21);

                while (p_list.Contains(place))
                    place = r.Next(1,21);

                p_list.Add(place);
                t.Placing = place;
                //Console.WriteLine(t.Racer.Name + " " + t.Placing);
            }

            var top3 = carList.Where(car => car.Placing <= 3);
            Console.WriteLine("Our podium places are as follows, congratulations!");
            foreach(var t in top3)
            {
               t.PrintRacer();
            }
            

            int dnf = r.Next(1, 21);

            carList.Where(car => car.Placing > dnf).Select(c => { c.CarStatus = "DNF"; return c; }).ToList();

            var notFinished = carList.Where(car => car.CarStatus == "DNF").OrderBy(c => c.Placing);

            Console.WriteLine("\nDrivers that were forced to retire from the race:");
            foreach(var c in notFinished)
            {
                Console.WriteLine(c.Racer.Name + " " + c.Placing+ " "+c.CarStatus);
            }
            


        }
    }
}
