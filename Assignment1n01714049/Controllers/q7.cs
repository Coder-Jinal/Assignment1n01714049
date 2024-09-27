using Microsoft.AspNetCore.Mvc;

namespace Assignment1n01714049.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7 : Controller
    {
        /// <summary>
        /// It gives the current date adjusted by the specified number of days, formatted as yyyy-MM-dd
        /// </summary>
        /// <param name="days">The number of days to adjust the current date by</param>
        /// <returns>
        /// It returns the date in yyyy-MM-dd format
        /// </returns>
        /// <example>
        /// GET api/q7/timemachine?days=1 -> 2024-09-28
        /// GET api/q7/timemachine?days=-1 -> 2024-09-26
        /// </example>
        [HttpGet(template:"timemachine")]
        public string timemachine(int days)
        {
            DateTime CurrentDate = DateTime.Today;
            DateTime CalculatedDays = CurrentDate.AddDays(days);
            return CalculatedDays.ToString("yyyy-MM-dd");
        }
    }
}
