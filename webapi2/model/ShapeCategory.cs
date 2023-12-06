using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapi.model
{
    public class ShapeCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Shape> Shapes { get; set; }
    }
}
