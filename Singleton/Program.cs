using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            //can't change OS, cause it's already initialized
            comp.OS = OS.GetCurrent("Windows 10");
            Console.WriteLine(comp.OS.Name);

            Console.ReadLine();
        }
    }
    class Computer
    {
        public OS OS { get; set; }
        
        public void Launch(string osName)
        {
            OS = OS.GetCurrent(osName);
        }
    }

    /// <summary>
    /// Not thread safe
    /// </summary>
    sealed class OS
    {
        private static OS current = null;

        private OS(string name)
        {
            Name = name;
        }

        public static OS GetCurrent(string name)
        {
            if (current == null)
                current = new OS(name);
            return current;
        }

        public string Name { get; set; }
    }
}
