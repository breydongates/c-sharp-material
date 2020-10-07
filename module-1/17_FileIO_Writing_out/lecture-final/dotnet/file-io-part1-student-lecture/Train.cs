using System;
using System.Collections.Generic;
using System.Text;

namespace FileInputLecture
{
    public abstract class Train
    {
        private int numCowsHit = 0;

        public Train(string driver)
        {
            this.Manufacturer = "Acme";
            // this.Driver = driver;
            this.YearBuilt = 2020;
        }

        public Train(string manufacturer, int yearBuilt)
        {
            this.Manufacturer = manufacturer;
            this.YearBuilt = yearBuilt;
        }

        public abstract void DriveTrain();

        public int YearBuilt { get; set; }
        public string Manufacturer { get; set; }

        public int NumCars
        {
            get
            {
                return this.cars.Count;
            }
        }

        public int TotalCargoWeight
        {
            get
            {
                int sum = 0;
                foreach (ITrainAttachment car in this.cars)
                {
                    sum += car.Weight;
                }

                return sum;
            }
        }

        public void AddCar(ITrainAttachment car)
        {
            this.cars.Add(car);
        }

        private List<ITrainAttachment> cars = new List<ITrainAttachment>();

        // Would like to know what type of train cars we have
    }

    public interface ITrainAttachment
    {
        int Weight { get; }
        int Length { get; }
    }

    public class CoalCar : ITrainAttachment
    {
        public int Weight { get; } = 500;
        public int Length { get; } = 30;
    }

    public class CircusWagon : ITrainAttachment
    {
        public int Weight { get; } = 100000;
        public int Length { get; } = 300;
    }

    public class DieselTrain : Train
    {
        public DieselTrain(string manufacturer, int year, int initialFuel) : base(manufacturer, year)
        {
            this.DieselLeft = initialFuel;
        }

        public override void DriveTrain()
        {
            this.DieselLeft -= 1;
        }

        public int DieselLeft { get; set; }

        public void Fuel(int dieselToAdd)
        {
            this.DieselLeft += dieselToAdd;
        }
    }

    public class ElectricTrain : Train
    {
        public ElectricTrain(string manufacturer, int year) : base(manufacturer, year)
        {

        }

        public override void DriveTrain()
        {
            // Weeeeeeeee!!!!!!
        }
    }

    public class RailwayCompany 
    {
        public static void PlayWithTrains()
        {
            DieselTrain train = new DieselTrain("Zeus", 1984, 50);
            train.YearBuilt = 2081; // For tax purposes
            MaintainTrain(train);
            UseTrain(train);

            ElectricTrain electric = new ElectricTrain("Poseidon", 1994);
            MaintainTrain(electric);
            UseTrain(electric);
        }

        public static void UseTrain(Train train)
        {
            ITrainAttachment car = new CircusWagon();
            train.AddCar(car);

            train.DriveTrain();
        }

        public static void MaintainTrain(DieselTrain train)
        {
            // Fix stuff
        }

        public static void MaintainTrain(ElectricTrain train)
        {
            // Fix stuff
        }
    }
}
