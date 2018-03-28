using System;

namespace Primjer04
{
    /// <summary>
    /// Klasa za rad sa temperaturama  
    /// </summary>
    /// <remarks>
    /// Klasa Celzius nema definiran konstruktor.
    /// Temperatura se zadaje preko svojstva.
    /// </remarks>
    class Celzius
    {
        /// <summary>
        /// Varijabla sadrzaje trenutnu temperaturu koja se zadaje preko svojstva
        /// </summary>
        private double trenutnaTemp;

        /// <summary>
        /// Get/Set svojstvo za varijablu trenutnaTemparautra
        /// </summary>
        /// <value>Vrijednost koja se zadaje mora biti tipa double</value>
        public double TrenutnaTemp
        {
            get
            {
                return trenutnaTemp;
            }
            set
            {
                trenutnaTemp = value;
            }
        }

        /// <summary>
        /// Metoda vraca vrijednost temperature u Klevinima
        /// za zadanu vrijednost u Celziusima
        /// </summary>
        /// <param name="tempCelzius">Temperatura koja se pretvara u Kelvine</param>
        /// <returns>Vraca se double vrijednost temeprature u Klevinima</returns>
        public double Kelvin(double tempCelzius)
        {
            return tempCelzius + 273.15;
        }
    }
}
