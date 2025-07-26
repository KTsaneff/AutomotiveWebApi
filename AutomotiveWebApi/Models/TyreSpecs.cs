namespace AutomotiveWebApi.Models
{
    public class TyreSpecs
    {
        public string Size { get; set; } = null!;     // e.g. "225/45 R17"
        public string Type { get; set; } = "Summer";  // Summer, Winter, All-season
        public int LoadIndex { get; set; }            // e.g. 91
        public string SpeedRating { get; set; } = "V"; // e.g. V = 240 km/h
    }
}
