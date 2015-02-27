using System;


namespace Assingment03Vinobaje_Manohar_Assingment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet Jupiter = new GiantPlanet("Gas", "Jupiter", 5000000, 80000000);
            TerrestriaPlanet earth = new TerrestriaPlanet(true, "Earth", 9.6786870000, 178908989);


            Console.Write("\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("******************************* Giant Planet ******************************");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            Console.WriteLine(Jupiter.ToString());
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("*************************** Terrestrial Planet ****************************");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine(earth.ToString());
            WaitForAnyKey();
        }

        public static void WaitForAnyKey()
        {
            Console.WriteLine("Please press any key to exit....");
            Console.ReadKey();
        }
    }
}
