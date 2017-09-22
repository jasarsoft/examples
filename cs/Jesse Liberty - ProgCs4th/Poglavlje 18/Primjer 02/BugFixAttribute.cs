using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection
{
    //stvara prilagodjeni atribut koji ce biti dodjeljen clanu klase
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = true)]
    public class BugFixAttribute : System.Attribute
    {
        //podaci privatni clanova
        private int bugID;
        private string comment;
        private string date;
        private string programmer;

        //konstruktor atributa za pozicijske parametre
        public BugFixAttribute(int bugID, string programmer, string date)
        {
            this.bugID = bugID;
            this.programmer = programmer;
            this.date = date;
        }

        //pristupnik
        public int BugID
        {
            get { return bugID; }
        }

        //svojstvo za imenovani parametar
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        //pritupnik
        public string Date
        {
            get { return date; }
        }

        //pristupnik
        public string Programmer
        {
            get { return programmer; }
        }
    }
}
