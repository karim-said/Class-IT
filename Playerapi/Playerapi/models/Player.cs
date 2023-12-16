namespace Playerapi.models
{
    public class Player
    {
        public int Id { get; set; }
        public string? NameAlbum { get; set; }
        public string? Author { get; set; }
        public string? Singer { get; set; }
        public bool Status { get; set; }
        public string? Playlistname { get; set; }
        public int Speed { get; set; }
        public string? NextTrack { get; set; }
        public string? BackTrack { get; set; }
        public bool Pause {  get; set; }
        public bool Stop {  get; set; }
        public bool Play {  get; set; }
    }
}
