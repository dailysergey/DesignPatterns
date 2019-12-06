using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            OS.Current.Name="Windows 10";
            comp.OS = OS.Current;
            Console.WriteLine(comp.OS.Name);

            Console.ReadLine();
        }
    }
    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS.Current.Name = osName;
        }
    }
    class OS
    {
        private static readonly OS instance = new OS("");
        public static OS Current => instance;
        private OS(string name) {
            Name = name;
        }
       // private static OS instance;

        public string Name { get;  set; }

    }
}
