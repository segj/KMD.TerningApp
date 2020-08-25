using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace KMD.TerningApp.Kerne
{
    public class Terning
    {
        protected static readonly Random rnd = new Random();
        public int Værdi { get; set; }
        public int AntalSider { get; }
        public DateTime RysteTid { get; set; }
        public int AntalSlag { get; set; }
        public int[] Optælling { get; set; }

        public Terning(int antalSider)
        {
            if (antalSider > 0)
            { 
                this.AntalSider = antalSider;
                Optælling = new int[antalSider+1];
                AntalSlag = 0;
                Ryst();
            }
            else
            {
                throw new Exception("Forkert værdi");
            }
        }
        public void Ryst()
        {
            Værdi = rnd.Next(1, AntalSider + 1);
            RysteTid = DateTime.Now;
            AntalSlag++;
            UdskrivStatistik(Værdi);
        }

        public virtual void UdskrivTerning()
        {
            Console.WriteLine($"Terningtype: {this.GetType()} \nTerningværdi {this.Værdi}");
        }

        public void UdskrivStatistik(int værdi)
        {
            Console.Clear();
            Optælling[værdi]++;

            Console.WriteLine("Antal");
            String a = "";

            for (int i = 1; i < Optælling.Length; i++)
            {
                
                for (int p = 1; p <= Optælling[i]; p++)
                {
                    a = String.Concat(a, ".");
                }

                Console.WriteLine($"[{i}]: {(Optælling[i] / AntalSlag) * 100}% {a}");
                a = "";   
            }
        }

    }

}

