

using CITP_Portfolio_Subproject_2.DataLayer;
using CITP_Portfolio_Subproject_2.DataLayer.Domain;
using Microsoft.AspNetCore.Mvc;


namespace WebServer.Controllers
{
    [Route("api/attributes")]
    public class AttributeController : ControllerBase
    {
        private IDataService _dataService = new DataService();

        [HttpGet]
        public IActionResult Get()
        {
            var attributes = _dataService.GetAkaAttributes();
            return Ok(attributes);
        }

        [HttpGet("tconst")]
        public IActionResult GetAkaAttribute(string tconst)
        {
            var attribute = _dataService.GetAkaAttribute(tconst);

            if(attribute == null)
            {
                return NotFound();
            }
            var model = new AkaAttribute
            {
                Url = "http://localhost:5001/api/attributes" + attribute.Tconst,
                Ordering = attribute.Ordering,
                Attribute = attribute.Attribute
            };
            return Ok(model);
        }
    }
}
