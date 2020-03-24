using Microsoft.AspNetCore.Mvc;
using profed.Interfaces;

namespace profed.Controllers.API
{
    [Route("/api/ideas")]
    public class IdeaController : ControllerBase
    {
        private IIdeaService _service;
        public IdeaController(IIdeaService service)
        {
            _service = service;
        }

        public ActionResult GetAll()
        {
            return new OkObjectResult(_service.GetAll());
        }
    }
}