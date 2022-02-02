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
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        public string ReverseString(string word = "Hello World")
        {
            return new string(word.ToArray().Reverse().ToArray());

            // return string.Concat(word.ToArray().Reverse());

        }
    }
}

// * Create a controller for ReverseString
//     * Create a new Controller called ReverseStringController
//     * This will have one HttpGet method
//     * The method will accept a string either as a URL parameter or a query parameter. Your choice.
//     * This endpoint method will reverse the string passed to it, manipulate it according to the kata Reverse String and return the result
//     * Have your code return the string