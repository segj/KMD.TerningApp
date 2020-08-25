using System;
using System.Collections.Generic;
using System.Text;

namespace KMD.TerningApp.Kerne
{
    public class LudoTerning : Terning
    {
        private const int antalSider = 6;
        public LudoTerning() : base(antalSider)
        {
            
        }

        public override void UdskrivTerning()
        {
            if (base.Værdi == 6)
            {
                Console.WriteLine($"Terningtype: {this.GetType()} \nTerningværdi *");
            }
            else
            {
                Console.WriteLine($"Terningtype: {this.GetType()} \nTerningværdi {this.Værdi}");
            }
            
        }
    }
}
