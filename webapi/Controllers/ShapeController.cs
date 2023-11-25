using webapi.Mock;
using webapi.model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapeController : ControllerBase
    {
        private readonly IMockService _mockService;
        public ShapeController(IMockService mockService)
        {
            _mockService = mockService;
        }    

        [HttpGet] 
        [Route("")]
        public ActionResult<IEnumerable<Shape>> GetShapes()
        {
            return Ok(_mockService.GetShapes());
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<Shape> GetShapeById(int id)
        {
            var shape = _mockService.GetShapeById(id);

            if (shape == null)
                return NotFound($"This Entity by id:{id} not found");
            return shape;
        }

        [HttpGet]
        [Route("name")]
        public ActionResult<Shape> GetShapeByName(string name)
        {
            var shape = _mockService.GetShapeByName(name);

            if (shape == null)
                return NotFound($"This Entity by name:{name} not found");
            return shape;
        }

        [HttpPost]
        [Route("")]
        public ActionResult CreateShape(Shape shape)
        {
            _mockService.CreateShapes(shape);

            return Ok();
        }

        [HttpPut]
        [Route("id")]
        public ActionResult UpdateShapeById(Shape shape)
        {
            _mockService.UpdateShapes(shape);

            return Ok();
        }

        [HttpDelete]
        [Route("id")]
        public ActionResult RemoveShapeById(int id)
        {
            _mockService.RevmoeShapes(id);

            return Ok();
        }
    }
}
