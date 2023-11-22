using System.Linq;
using webapi.model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapeController : ControllerBase
    {
        List<Shape> _mockshaps = new List<Shape>();

        public ShapeController()
        {
            MockShape mock = new MockShape();
            _mockshaps = mock.PushShape();
        }    

        [HttpGet] 
        [Route("")]
        public ActionResult<IEnumerable<Shape>> GetShapes()
        {
            return Ok(_mockshaps);
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<Shape> GetShapeById(int id)
        {
            var shape = _mockshaps.FirstOrDefault(x => x.Id == id);

            if (shape == null)
                return NotFound($"This Entity by id:{id} not found");
            return shape;
        }

        [HttpGet]
        [Route("name")]
        public ActionResult<Shape> GetShapeByName(string name)
        {
            var shape = _mockshaps.FirstOrDefault(x => x.Name == name);

            if (shape == null)
                return NotFound($"This Entity by name:{name} not found");
            return shape;
        }

        [HttpDelete]
        [Route("id")]
        public ActionResult RemoveShapeById(int id)
        {
            var shape = _mockshaps.FirstOrDefault(x => x.Id == id);
            _mockshaps.Remove(shape);

            if (shape == null)
                return NotFound($"This Entity by id:{id} not found");
            return Ok();
        }
    }


    public class MockShape
    {       
        public List<Shape> PushShape()
        {

          var  shapes = new List<Shape>
            {
                new Shape
                {
                    Id = 1,
                    Name = "Triangle",
                    Area = 42,
                    Perimetr = 32,
                    CountOfAngle = 3
                },
                new Shape
                {
                    Id = 2,
                    Name = "Rectangle",
                    Area = 78,
                    Perimetr = 96,
                    CountOfAngle = 4
                },
                new Shape
                {
                    Id = 3,
                    Name = "Square",
                    Area = 96,
                    Perimetr = 36,
                    CountOfAngle = 4
                },
                new Shape
                {
                    Id = 4,
                    Name = "Pentagon",
                    Area = 96,
                    Perimetr = 364,
                    CountOfAngle = 5
                },
                new Shape
                {
                    Id = 5,
                    Name = "Round",
                    Area = 96,
                    Perimetr = 45,
                    CountOfAngle = null
                },
                new Shape
                {
                    Id = 6,
                    Name = "Trapecy",
                    Area = 96,
                    Perimetr = 45,
                    CountOfAngle = 231
                },
                new Shape
                {
                    Id = 7,
                    Name = "Paralelogram",
                    Area = 96,
                    Perimetr = 63,
                    CountOfAngle = 64
                },
            };

            return shapes;
        }
    }

}
