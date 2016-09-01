using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SilverlightDemoOne
{
    /// <summary>
    /// Summary description for rawebservice
    /// </summary>
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string HelloUser(string username)
        {           
            return "Hello " + username;
        }
        [WebMethod]
        public int Calculator(int x)
        {
            //x = 0;
            //int a = 5;
            //int b = 5;
            //x = a + b;
            return x;
        }
    }
}
