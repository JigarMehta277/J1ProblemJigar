using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace J1ProblemJigar.Controllers
{
    public class J1Controller : ApiController
    {
        //Question link for reference:-https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2021/ccc/juniorEF.pdf
        //This is solution of Problem J1.
        /// <summary>
        /// This method returns atmospheric pressure and sea level.
        /// <example>Get api/J1</example>
        /// </summary>
        /// <param name="b"></param>
        /// <returns>temp:it display's atmospheric tempreture and sealevel:it indicates the sea level</returns>
        [Route("api/J1/{b}")]
        public IEnumerable<string> Get(int b)
        {
            int p; //atmospheric pressure variable
            p = 5 * b - 400;
            string seaLevel;
            if (p == 100)
            {
                seaLevel = "0";
            }
            else if (p < 95)
            {
                seaLevel = "1";
            }
            else
            {
                seaLevel = "-1";
            }
            string temp = p.ToString();
            return new string[] { temp, seaLevel };

        }

    }
}
