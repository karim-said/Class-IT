namespace DrillAPI.models
{
    public class Drill
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Status { get; set; }
        public string? Mode { get; set; }
        public bool Reverse { get; set; }
        public int Spped { get; set; }
    }
}
