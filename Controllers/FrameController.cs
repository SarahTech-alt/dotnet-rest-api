using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using seeSharpAPI.Models;
using seeSharpAPI.Services;

namespace seeSharpAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FrameController : ControllerBase
    {
        public FrameController()
        {
        }

        [HttpGet]
        public ActionResult<List<Frame>> GetAll() =>
    GlassesStore.GetAll();

        // GET by Id action
        [HttpGet("{id}")]
public ActionResult<Frame> Get(int id)
{
    var frame = GlassesStore.Get(id);

    if(frame == null)
        return NotFound();

    return frame;
}

        // POST action

        // PUT action

        // DELETE action
    }
}