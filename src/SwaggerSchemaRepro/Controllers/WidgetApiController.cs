using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SwaggerSchemaRepro.Controllers
{
    [ApiController]
    [Route("widgets")]
    public class WidgetApiController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWidgetsModel model)
        {
            await Task.CompletedTask;

            return Created("/", null);
        }
    }


    public class CreateWidgetsModel
    {
        [SwaggerSchema(ReadOnly = false)]
        public List<WidgetModel> Widgets { get; private set; } = new List<WidgetModel>();
    }

    public class WidgetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
