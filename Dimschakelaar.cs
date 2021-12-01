using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1C_B1C2_LampSchakelaar
{
    /// <summary>
    /// Representeert de dimschakelaar als afgeleidde class van schakelaar
    /// </summary>
    class Dimschakelaar : Schakelaar
    {
        /// <summary>
        /// Geeft de hoeveelheid stroom aan die de schakelaar afgeeft
        /// </summary>
        public int Hoeveelheidstroom { get; set; }

        /// <summary>
        /// Dim de schakelaar
        /// </summary>
        public void Dimmen()
        {
            // implementeer!
        }

        /// <summary>
        /// Versterk de schakelaar
        /// </summary>
        public void Versterken()
        {
            // implementeer
        }
    }
}
