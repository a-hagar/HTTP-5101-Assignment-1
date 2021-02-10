using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            int final = ( ( id * 5 ) / 2 ) + 7 - 4;
            return final;
        }
    }
}
