using System.Linq;
using webapi.model;
using System.Collections.Generic;

namespace webapi.Mock
{
    public class MockService : IMockService
    { 
        List<Shape> Shapes = new List<Shape>
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

        public List<Shape> GetShapes()
        {
            return Shapes;
        }

        public Shape GetShapeById(int id)
        {
            return Shapes.FirstOrDefault(s => s.Id == id);
        }

        public Shape GetShapeByName(string name)
        {
            return Shapes.FirstOrDefault(s => s.Name == name);
        }
        public void CreateShapes(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void RevmoeShapes(int id)
        {
           var shape =  Shapes.FirstOrDefault(s => s.Id == id);

            Shapes.Remove(shape);
        }

        public void UpdateShapes(Shape _shape)
        {
            var shape = Shapes.FirstOrDefault(s => s.Id == _shape.Id);

            var index = Shapes.IndexOf(shape);

            Shapes[index].Id = _shape.Id;
            Shapes[index].Name = _shape.Name;
            Shapes[index].Area = _shape.Area;
            Shapes[index].Perimetr = _shape.Perimetr;
        }
    }
}
