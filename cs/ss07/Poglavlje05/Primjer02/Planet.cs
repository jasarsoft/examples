using System;

namespace Primjer02
{
    class Planet
    {
        private bool life;
        public bool atmosfera;
        private string nazivPlaneta;

        public Planet(string name, bool life, bool atm)
        {
            nazivPlaneta = name;
            this.life = life;
            atmosfera = atm;
        }

        public void PormjeniLife(bool life)
        {
            this.life = life;
        }
    }
}
