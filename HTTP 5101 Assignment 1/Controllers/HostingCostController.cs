using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class HostingCostController : ApiController

    
    {
        public string Get(int id)

        {
            int FN = 14;
            decimal time = (id / FN) + 1;
            decimal initialCost = time * 5.50m;
            decimal hst = 0.13m;
            decimal Cost = (initialCost * hst);
            decimal taxedCost = Math.Round(Cost, 2);
            decimal finalCost = initialCost + taxedCost;




            string message = time + " fortnights at $5.50/FN = $" + initialCost + " CAD.";
            string message2 = "HST 13% = $" + taxedCost + " CAD.";
            string message3 = "Total = $" + finalCost + " CAD.";

            return message + " " + message2 + " " + message3;
        }
        

    }
}
