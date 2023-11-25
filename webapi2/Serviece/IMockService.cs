using webapi.model;
using System.Collections.Generic;

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
