using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{str}")]
        public string Mumbling(string str)
        {
            var index = 1;
            var phrase = string.Join("-", str.Select(c => new String(c, index++))).ToLower();
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }
    }
}


// * Create a controller for mumbling
//     * Create a new Controller called MumblingController
//     * This will have one HttpGet method
//     * The method will accept a string either as a URL parameter or a query parameter. Your choice.
//     * This endpoint method will take the string passed to it, manipulate it according to the kata Mumbling and return the result
//     * Have your code return the string