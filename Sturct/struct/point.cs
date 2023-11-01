using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoliNav
{
    public struct SpaceStruct : PointStruct
    {
        public int _z;       

    }

    public struct PointStruct
    {
        public int _x;
        public int _y;         
    }

    public class PointClass
    {
        public PointClass()
        {

        }
        public int x { get; set; }
        public int y { get; set; }
    }
}
