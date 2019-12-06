using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            Camel camel = new Camel();
            // use adapter
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            driver.Travel(camelTransport);

            Console.Read();
        }
    }

    interface ITransport
    {
        void Drive();
    }
    

    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Car drives");
        }
    }

    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
    
    interface IAnimal
    {
        void Move();
    }

    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Camel walks along the dessert");
        }
    }

    // Adapter from Camel to Transport
    class CamelToTransportAdapter : ITransport
    {
        readonly Camel camel;
        public CamelToTransportAdapter(Camel c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}
