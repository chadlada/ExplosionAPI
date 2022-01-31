using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{str}")]
        public string Explosion(string str = "1234")  //Why isn't it defaulting when I run in insomnia?
        {
            // var newString = "";
            // foreach (var number in str)
            // {
            //     for (var index = 0; index < number - '0'; index++)
            //     {
            //         newString += number;
            //     }
            // }
            // return newString;
            return string.Concat(str.Select(n => new string(n, int.Parse(n.ToString()))));
        }
    }
}


// * Create a controller for explosion
//     * Create a new Controller called ExplosionController
//     * This will have one HttpGet method
//     * The method will accept a string either as a URL parameter or a query parameter. Your choice.
//     * This endpoint method will take the string passed to it, manipulate it according to the kata Digits Explosion and return the result
//     * Have your code return the string