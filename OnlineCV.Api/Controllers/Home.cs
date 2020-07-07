using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineCV.Api.Models;

namespace OnlineCV.Api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home
    {
        public string index()
        {                       
            return ("Hello");
        }
    }
}
