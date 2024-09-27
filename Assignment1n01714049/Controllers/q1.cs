using Microsoft.AspNetCore.Mvc;

namespace Assignment1n01714049.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1 : Controller
    {
        /// <summary>
        /// It provides welcoming message by receiving the GET request.
        /// </summary>
        /// <returns>
        /// It returns the HTTP response with a body indicating "welcome to 5125!"
        /// </returns>
        /// <example>
        /// GET api/q1/welcome -> "welcome to 5125!"
        /// </example>
        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return ("Welcome to 5125!");
        }

        /// <summary>
        /// It provides the message by receiving the GET request.
        /// </summary>
        /// <returns>
        /// It returns the HTTP response with a string "This is Jinal Patel."
        /// </returns>
        /// <example>
        /// GET api/q1/example -> This is Jinal Patel.
        /// </example>
        [HttpGet(template:"example")]
        public string example()
        {
            return ("This is Jinal Patel.");
        }
    }
}
