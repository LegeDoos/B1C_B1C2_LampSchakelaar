using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1C_B1C2_LampSchakelaar
{
    /// <summary>
    /// Representeert een lamp
    /// </summary>
    public class Lamp
    {
        /*
        private bool status;
        public bool Status
        {
            get
            {
                return status;
            }
            private set
            {
                status = value;
            }
        }*/
        /// <summary>
        /// Geeft aan of de lamp aan staat (true) of uit (false)
        /// </summary>
        public bool Status { get; private set; }
        /// <summary>
        /// Geeft de huidige lichtopbrengst van de lamp in Lumen (Lm)
        /// </summary>
        public int LichtOpbrengst { get; private set; }

        public Schakelaar Schakelaar{ get; set; }

        /// <summary>
        /// Zet de lamp aan
        /// </summary>
        public void Aanzetten()
        {
            Status = true;
            LichtOpbrengst = 340;
        }
        /// <summary>
        /// Zet de lamp uit
        /// </summary>
        public void Uitzetten()
        {
            Status = false;
            LichtOpbrengst = 0;
        }
    }
}
