namespace AutomotiveWebApi.Models
{
    public class WheelSpecs
    {
        public int DiameterInches { get; set; }       // e.g. 17
        public double WidthInches { get; set; }          // e.g. 7.5
        public int OffsetMm { get; set; }             // e.g. ET35
        public int BoltPattern { get; set; }          // e.g. 5 (number of bolts)
        public int BoltCircleDiameterMm { get; set; } // e.g. 112
    }
}
