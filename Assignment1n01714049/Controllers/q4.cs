using Microsoft.AspNetCore.Mvc;

namespace Assignment1n01714049.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4 : Controller
    {
        /// <summary>
        /// Receives an HTTP POST request and provides a message.
        /// </summary>
        /// <returns>
        /// It returns a message like "Who's there?"
        /// </returns>
        /// <example>
        /// POST api/q4/knockknock -> Who's there?
        /// </example>
        [HttpPost(template:"knockknock")]
        public string knockknock()
        {
            return ("Who's there?");
        }

        /// <summary>
        /// Receives an HTTP POST request and provides a message.
        /// </summary>
        /// <returns>
        /// It returns a message like "Too lazy to answer!"
        /// </returns>
        /// <example>
        /// POST api/q4/example -> Too lazy to answer!
        /// </example>
        [HttpPost(template:"example")]
        public string example()
        {
            return ("Too lazy to answer!");
        }
    }
}
