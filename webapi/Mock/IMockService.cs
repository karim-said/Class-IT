using System;
using System.Collections.Generic;
using System.Linq;
using webapi.model;

namespace webapi.Mock
{
    public interface IMockService
    {  
       List<Shape> GetShapes();
       Shape GetShapeById(int id);
       Shape GetShapeByName(string name);
       void CreateShapes(Shape shape);
       void UpdateShapes(Shape shape);
       void RevmoeShapes(int id);
    }
}
