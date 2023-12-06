using System;
using webapi.Mock;
using webapi.model;
using System.Linq;
using System.Collections.Generic;
using webapi2.Data;

namespace webapi2.Serviece
{
    public class SQLService : IMockService
    {
        private readonly DbContextShape _context;

        public SQLService(DbContextShape context)
        {
            _context = context;
        }

        public void CreateShapes(Shape shape)
        {
            _context.Shapes.Add(shape);
        }

        public Shape GetShapeById(int id)
        {
            var shape = _context.Shapes.FirstOrDefault(shape => shape.Id == id);

            return shape;
        }

        public Shape GetShapeByName(string name)
        {
            var shape = _context.Shapes.FirstOrDefault(s => s.Name == name);

            return shape;
        }

        public List<Shape> GetShapes()
        {
            List<Shape> shapes = _context.Shapes.ToList();

            return shapes;
        }

        public void RevmoeShapes(int id)
        {
            var shape = _context.Shapes.FirstOrDefault(shape => shape.Id == id);

            _context.Remove(shape);
            _context.SaveChanges();

        }

        public void UpdateShapes(Shape shape)
        {
            _context.Update(shape);
            _context.SaveChanges();
        }
    }
}
