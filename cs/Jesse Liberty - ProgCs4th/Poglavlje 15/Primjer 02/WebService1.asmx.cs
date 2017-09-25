using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Primjer_02
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double x, double y)
        {
            return x + y;
        }

        [WebMethod]
        public double Sub(double x, double y)
        {
            return x - y;
        }

        [WebMethod]
        public double Mult(double x, double y)
        {
            return x * y;
        }

        [WebMethod]
        public double Div(double x, double y)
        {
            return x / y;
        }

        [WebMethod]
        public double Pow(double x, double y)
        {
            double retVal = x;
            for(int i = 0; i < y - 1; i++)
            {
                retVal *= x;
            }
            return retVal;
        }
    }
}
