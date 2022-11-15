using CITP_Portfolio_Subproject_2.DataLayer;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models.Profiles;
using static System.Net.WebRequestMethods;

namespace WebServer.Controllers
{
    [Route("api/names")]
    public class NameController : ControllerBase
    {
        private IDataService _DataService = new DataService();
        [HttpGet("{nconst}")]
        public IActionResult GetName(string nconst)
        {
            var name = _DataService.GetName(nconst);

            if (name == null)
            {
                return NotFound();
            }
            var model = new NameBasicModel
            {
                Url = "http://localhost:5001/api/names" + name.Nconst,
                PrimaryName = name.PrimaryName,
                Birthyear = name.Birthyear,
                Deathyear = name.Deathyear,
                NameRating = name.NameRating
            };

            return Ok(model);
        }
    }
}
