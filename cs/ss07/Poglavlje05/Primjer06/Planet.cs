using System;

namespace Primjer06
{
    class Planet
    {
        private bool life;
        private bool atmosfera;
        private string nazivPlaneta;

        public Planet(string name, bool lf, bool atm)
        {
            nazivPlaneta = name;
            life = lf;
            atmosfera = atm;
        }

        public bool Life
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
            }
        }
    }
}
