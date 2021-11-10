using System;
using System.Collections.Generic;

namespace ConsoleApp14
{
    class Car
    {
        protected string label;
        protected int power, year;
        public Car(string label, int power, int year)
        {
            this.label = label;
            this.power = power;
            this.year = year;
        }
        public class PassengerCar : Car
        {
            protected int number_of_passengers;
            protected Dictionary<string, int> repair_book = new Dictionary<string, int>();
            public PassengerCar(string label, int power, int year, int number_of_passengers, Dictionary<string,int> repair_book) : base(label, power, year)
            {
                this.number_of_passengers = number_of_passengers;
                this.repair_book = repair_book;
            }
            public void repair_book_add(string spares, int replacement_year)
            {
                repair_book.Add(spares, replacement_year);
            }
            public void repair_book_list()
            {
                foreach (var a in repair_book)
                {
                    Console.WriteLine(a.Key, a.Value);
                }
            }
            public int repair_book_fromName(string spares)
            {
                repair_book.TryGetValue(spares, out int replacement_year);
                return replacement_year;
            }
            public override string ToString()
            {
                return $"{label}, {power}, {year}, {number_of_passengers}";
            }
        }
        public class Truck : Car
        {
            protected int maximum_capacity;
            protected string SN_driver;
            protected Dictionary<string, int> cargo = new Dictionary<string, int>();

            public Truck(string label, int power, int year, int maximum_capacity, string SN_driver, Dictionary<string, int> cargo) : base(label, power, year)
            {
                this.maximum_capacity = maximum_capacity;
                this.SN_driver = SN_driver;
                this.cargo = cargo;
            }
            public string Driver
            {
                set { SN_driver = value; }
            }
            public void AddCargo(string name, int capacity)
            {
                cargo.Add(name, capacity);
            }
            public void RemoveCargo(string name)
            {
                cargo.Remove(name);
            }
            public void Cargo()
            {
                foreach (var c in cargo)
                {
                    Console.WriteLine($"{c.Key} {c.Value}");
                }
            }
            public override string ToString()
            {
                return $"{label}, {power}, {year}, {maximum_capacity}, {SN_driver}";
            }
        }
        public class AutoPark
        {
            protected string name;
            protected List<PassengerCar> PassengerCars = new List<PassengerCar>();
            protected List<Truck> trucks = new List<Truck>();
            public AutoPark(string name, List<PassengerCar> PassengerCars,List<Truck> trucks)
            {
                this.name = name;
                this.PassengerCars = PassengerCars;
                this.trucks = trucks;
            }
            public override string ToString()
            {
                string result = "";
                foreach(PassengerCar car in PassengerCars)
                {
                    result += car.ToString();
                }
                foreach(Truck car in trucks)
                {
                    result += car.ToString();
                }
                return result;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
