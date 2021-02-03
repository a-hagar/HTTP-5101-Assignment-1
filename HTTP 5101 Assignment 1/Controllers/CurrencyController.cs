using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class CurrencyController : ApiController
    {
        /*objective: create methods which describe how much money you have given a certain amount of money */

        //<returns> a sentence that describes the total amount of money</return>
        //GET api/Currency/10 --> "You have $20 dollars"
        //GET api/Currency/1 --> "You have $2 dollars"

        public string Get(int id)
        {
            //value of twoonie is $2.00
            int twoonie = 2;
            int amount = id * twoonie;

            string message = "You have $"+amount.ToString()+" dollars";

            return message;

        }

        //public: modifier accessible by public

        /*
        summary:this method will take in an input of $2 and will input the total value

        <param name="id">input of number of $2</param>
         */

        
        /*objective: create methods which describe how much money you have given a certain amount of quarters */

        //<returns> a sentence that describes the total amount of money</return>
        //POST api/Currency/10 --> "You have $2.50 dollars"
        //POST api/Currency/1 --> "You have $0.25 dollars"

        public string Post(int id)
        {
            decimal quarter = 0.25M;
            decimal amount = id * quarter;

            string message = "You have $" + amount.ToString() + " dollars";

            return message;
        }

    }
}
