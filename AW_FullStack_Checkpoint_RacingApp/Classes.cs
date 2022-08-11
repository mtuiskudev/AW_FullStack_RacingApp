using System;
using System.Collections.Generic;
using System.Text;

namespace AW_FullStack_Checkpoint_RacingApp
{
    public class Car
    {
        public string TeamName { get; set; }
        public string Motor { get; set; }

        public int Placing { get; set; }
        public Driver Racer { get; set; }

        public string CarStatus { get; set; }

        public Car(string t_name, string motor, Driver driver)
        {
            this.TeamName = t_name;
            this.Motor = motor;
            this.Racer = driver;
        }

        internal string PrintRacer()
        {
            return (this.Racer.Name + " " + this.TeamName);
        }

        public bool IsOk()
        {
            if (this.CarStatus != string.Empty)
                return false;

            return true;
        }
    }

    public class Driver
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public string DriverStatus { get; set; }

        public Driver(string name)
        {

            this.Name = name;
        }

    }
}
