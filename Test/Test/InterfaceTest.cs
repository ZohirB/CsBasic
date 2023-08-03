namespace Test;

public class InterfaceTest
{
    public static void testInterface()
    {
        IMove m = new MyVehicle();
        m.Move();
        m.Turn();


        Vehicle v1 = new Honda("BMW", "M4", 2022);
        Honda v2 = new Honda("BMW", "M5", 2023);
        ILoader v3 = new SuperVehicle("AUDI", "A4", 2023);
        v3.Load();
    }

    interface IMove
    {
        void Turn()
        {
            Console.WriteLine("turniing");
        }
        void Move();
    }
    
    interface IDisplay
    {
        void Move();
    }

    class MyVehicle : IMove,IDisplay
    {
        void IMove.Move()
        {
            Console.WriteLine("IMove move");
        }

        void IDisplay.Move()
        {
            Console.WriteLine("IDisplay move");
        }
    }
    
    abstract class Vehicle
    {
        protected string Brand;
        protected string Model;
        protected int Year;

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }

    class Honda : Vehicle, IDrivable // CONCRETE
    {
        public Honda(string brand, string model, int year) : base(brand, model, year)
        {

        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping");
        }
    }

    interface IDrivable
    {
        void Move();
        void Stop();
    }

    interface ILoader
    {
        void Load();
        void Unload();
    }

    class SuperVehicle : Vehicle, ILoader, IDrivable
    {
        public SuperVehicle(string brand, string model, int year) : base(brand, model, year)
        {

        }

        public void Load()
        {
            Console.WriteLine("Loading");
        }

        public void Unload()
        {
            Console.WriteLine("NotLoading");
        }
        
        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping");
        }
    }
}    