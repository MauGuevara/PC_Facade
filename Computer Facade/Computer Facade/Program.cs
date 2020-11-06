using System;

namespace Computer_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            PcFacade facade = new PcFacade();
            facade.Starting_Pc();
            Console.ReadKey();
        }
    }
}
