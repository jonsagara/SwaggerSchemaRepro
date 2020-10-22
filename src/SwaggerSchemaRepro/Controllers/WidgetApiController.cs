using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerSchemaRepro.Controllers
{
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
        public List<WidgetModel> Widgets { get; private set; } = new List<WidgetModel>();
    }

    public class WidgetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
