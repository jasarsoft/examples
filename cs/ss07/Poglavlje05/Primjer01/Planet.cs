using System;

namespace Primjer01
{
    class Planet
    {
        private bool life;
        private bool atmosfera;
        private sbyte brojSatelita;
        private int promjer;
        private float brzinaOkoOsi;
        private float brzinaOkoSunca;
        private string nazivPlaneta;

        public Planet(string name, sbyte brojsat)
        {
            nazivPlaneta = name;
            brojSatelita = brojsat;
        }

        public Planet(string name, bool life, bool atm)
        {
            nazivPlaneta = name;
            this.life = life;
            atmosfera = atm;
        }

        public Planet(string name, bool life, bool atm, sbyte brojsat, int promjer, float brzina1, float brzina2)
        {
            nazivPlaneta = name;
            this.life = life;
            atmosfera = atm;
            brojSatelita = brojsat;
            this.promjer = promjer;
            brzinaOkoOsi = brzina1;
            brzinaOkoSunca = brzina2;
        }
    }
}
