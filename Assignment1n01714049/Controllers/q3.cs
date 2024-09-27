﻿using Microsoft.AspNetCore.Mvc;

namespace Assignment1n01714049.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3 : Controller
    {
        /// <summary>
        /// It calculates the cube of a given number
        /// </summary>
        /// <param name="num">The number which we want to be cubed</param>
        /// <returns>
        /// It returns the cube of the entered number
        /// </returns>
        /// <example>
        /// GET api/q3/cube/4 -> 64
        /// GET api/q3/cube/-4 -> -64
        /// GET api/q3/cube/10 -> 1000
        /// </example>
        [HttpGet(template: "cube/{num}")]
        public int cube(int num)
        {
            int cubenum = num * num * num;
            return cubenum;
        }
    }
}