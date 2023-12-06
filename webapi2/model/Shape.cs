using System.Text.Json.Serialization;

namespace webapi.model
{
    public class Shape
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Perimetr { get; set; }
        public int? CountOfAngle { get; set; }
        public int CategoryId { get; set; }
        public ShapeCategory ShapeCategory   { get; set; }
    }
}
