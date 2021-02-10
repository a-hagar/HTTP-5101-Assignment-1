using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        //GET api/Greeting/ Greetings to People!
        public string Post()
        {
            return "Hello World";
        }

        public string Get(int id)
        {
            string message = "Greetings to " + id + " people!" ;
            return message;
        }
    }
}
