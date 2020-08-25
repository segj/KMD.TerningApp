using System;
using System.Collections.Generic;
using System.Text;

namespace KMD.TerningApp.Kerne
{
    public class Terning
    {
        protected static readonly Random rnd = new Random();
        public int Værdi { get; set; }
        public int AntalSider { get; }

        public Terning(int antalSider)
        {
            if (antalSider > 0)
            { 
                this.AntalSider = antalSider;
            }
            else
            {
                throw new Exception("Forkert værdi");
            }
        }
        public void Ryst()
        {
            Værdi = rnd.Next(1, AntalSider + 1);
        }

        public virtual void UdskrivTerning()
        {
            Console.WriteLine($"Terningtype: {this.GetType()} \nTerningværdi {this.Værdi}");
        }

    }

}

