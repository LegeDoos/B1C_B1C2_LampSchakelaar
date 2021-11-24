using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1C_B1C2_LampSchakelaar
{
    /// <summary>
    /// Een schakelaar die een lamp kan aanzetten
    /// </summary>
    class Schakelaar
    {
        /// <summary>
        /// Geeft aan of de schakelaar is ingeschakeld
        /// </summary>
        private bool Ingeschakeld { get; set; }
        /// <summary>
        /// De lampen die worden aangestuurd door de schakelaar
        /// </summary>
        public List<Lamp> Lampen { get; set; }
        /// <summary>
        /// Zet de schakelaar om
        /// </summary>
        public void Omschakelen()
        {
            Ingeschakeld = !Ingeschakeld;
            foreach (var lamp in Lampen)
            {
                if (Ingeschakeld)
                {
                    lamp.Aanzetten();
                }
                else
                {
                    lamp.Uitzetten();
                }
            }
        }
    }
}
