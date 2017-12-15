using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Apprenda.Sample.OWIN
{
    public class DemoController : ApiController
    {
        public string Get()
        {
            return "Hello world";
        }
    }
}
