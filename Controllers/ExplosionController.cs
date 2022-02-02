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
        [HttpGet("{number}")]
        public string Explosion(string number = "1234")  //Why isn't it defaulting when I run in insomnia?
        {

            return string.Join("", number.Select(character => new String(character, int.Parse(character.ToString()))));
            // return string.Join("", numbers.Select(c => new String(c, int.Parse(c.ToString()))));

            // var newString = "";
            // foreach (var num in number)
            // {
            //     for (var index = 0; index < num - '0'; index++)
            //     {
            //         newString += num;
            //     }
            // }
            // return newString;
        }
    }
}




// * Create a controller for explosion
//     * Create a new Controller called ExplosionController
//     * This will have one HttpGet method
//     * The method will accept a string either as a URL parameter or a query parameter. Your choice.
//     * This endpoint method will take the string passed to it, manipulate it according to the kata Digits Explosion and return the result
//     * Have your code return the string