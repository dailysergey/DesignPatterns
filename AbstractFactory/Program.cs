using System;

namespace AbstractFactory
{

    class Program
    {
        static void Main(string[] args)
        {
            HeroFactory orkFactory = new OrkFactory();
            Hero ork = new Hero(orkFactory);
            ork.Hit();
            ork.Run();

            HeroFactory voinFactory = new VoinFactory();
            Hero voin = new Hero(voinFactory);
            voin.Hit();
            voin.Run();

            Console.ReadLine();
        }
    } 
    abstract class Weapon
    {
        public abstract void Hit();
    }


    abstract class Movement
    {
        public abstract void Move();
    }


    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Pif-Paf");
        }
    }


    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Hit with the sword");
        }
    }


    class StepMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Steping");
        }
    }


    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Running");
        }
    }


    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }


    class OrkFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new StepMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }


    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }

    //Client
    //tip: class
    class Hero
    {
        private Weapon weapon;
        private Movement movement;

        //tip: ctor
        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
}

