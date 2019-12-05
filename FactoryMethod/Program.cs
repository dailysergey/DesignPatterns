using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer devevloperA = new PanelDeveloper("CityTower");
            House panelHouse = devevloperA.Create();

            Developer developerB = new WoodDeveloper("Private Developer");
            House priateHouse = developerB.Create();

            Console.ReadLine();
        }
    }


    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }

        //
        abstract public House Create();
    }

    //CityTower
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }

    //Brick Developer
    class BrickDeveloper : Developer
    {
        public BrickDeveloper(string n):base(n)
        {
        }

        public override House Create()
        {
            return new BrickHouse();
        }
    }

    //Private Developer
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House
    {
        public abstract void Build();
    }

    class BrickHouse : House
    {
        public BrickHouse()
        {
            Console.WriteLine("Brick House has built.");
        }

        public override void Build()
        {
            Console.WriteLine("Use brick.");
        }
    }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house has built.");
        }
        public override void Build()
        {
            Console.WriteLine("Pandel");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wooden house has built.");
        }
        public override void Build()
        {
            Console.WriteLine("Use wood.");
        }
    }
}
