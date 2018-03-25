using System;

namespace Primjer03
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    class AutorAttribute : Attribute
    {
        protected string autor;
        protected double verzija;
        protected string vrstaPosla;

        public AutorAttribute(string autor, double verzija)
        {
            this.autor = autor;
            this.verzija = verzija;
        }

        public string Autor
        {
            get { return autor; }
        }

        public double Verzija
        {
            get { return verzija; }
        }

        public string VrstaPosla
        {
            get { return vrstaPosla; }
            set { vrstaPosla = value; }
        }
    }
}
