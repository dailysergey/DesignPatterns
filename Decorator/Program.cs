using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1);
            Console.WriteLine($"Name: {pizza1.Name}");
            Console.WriteLine($"Цена: {pizza1.GetCost()}");

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);
            Console.WriteLine($"Name: {pizza2.Name}");
            Console.WriteLine($"Price: {pizza2.GetCost()}");

            Pizza pizza3 = new ChicagoPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);
            Console.WriteLine($"Name: {pizza3.Name}" );
            Console.WriteLine($"Price: { pizza3.GetCost()}");

            Console.ReadLine();
        }
    }

    abstract class Pizza
    {
        public Pizza(string name)
        {
            this.Name = name;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian Pizza")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }

    class ChicagoPizza : Pizza
    {
        public ChicagoPizza()
            : base("Chicago Pizza")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }

    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }

    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza)
            : base($"{ pizza.Name } with tomatos", pizza)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }

    class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza)
            : base($"{ pizza.Name } with cheeze", pizza)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}
