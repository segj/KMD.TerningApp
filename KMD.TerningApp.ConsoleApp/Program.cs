using KMD.TerningApp.Kerne;
using System;

namespace KMD.TerningApp.ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Terning t = new Terning(2);
            t.Ryst();
            Console.WriteLine(t.Værdi);

            LudoTerning lt = new LudoTerning();

            while (true)
            {
                try
                {
                    Console.ReadKey();
                    lt.Ryst();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }
            }
            
        }
    }
}
 

