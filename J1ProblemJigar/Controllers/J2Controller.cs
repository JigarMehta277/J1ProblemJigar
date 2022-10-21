using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace J1ProblemJigar.Controllers
{
    public class J2Controller : ApiController
    {
        //This is the solution of Adapted J2 - Roll the Dice, taken from instruction pdf.
        /// <summary>
        /// This function returns number of ways to get sum "10" after inputing two integer values
        /// <example>Get api/J2</example>
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>"There are "+waycounter +" To get sum of 10"</returns>
        [Route("api/J2/{m}/{n}")]
        public string Get(int m,int n)
        {
            int sumoften = 10;
            int sum;
            int waycounter=0;
            for(int i=1;i<=m;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    sum = i + j;
                    if(sum == sumoften)
                    {
                        waycounter++;
                    }
                }
            }
            return "There are "+waycounter +" To get sum of 10";
        }

    }
}
