namespace AutomotiveWebApi.Models
{
    public class Engine
    {
        public string Type { get; set; }           // e.g. "Petrol", "Diesel", "Electric", "Hybrid"
        public int Cylinders { get; set; }         // e.g. 4, 6, 8
        public double DisplacementL { get; set; }  // e.g. 2.0 (liters)
        public int Horsepower { get; set; }        // e.g. 150
        public int TorqueNm { get; set; }          // e.g. 320 Nm
        public string FuelSystem { get; set; }     // e.g. "Direct Injection"
        public string Position { get; set; }       // e.g. "Front", "Rear", "Mid"
        public string Aspiration { get; set; }     // e.g. "Turbocharged", "Naturally Aspirated"
    }
}
