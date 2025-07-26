using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AutomotiveWebApi.Models
{
    public class Vehicle
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }

        public string Transmission { get; set; } = null!;

        public  int FuelTankCapacityL { get; set; }

        public int HorsePower { get; set; }
        public int Torque { get; set; } // in Nm (Newton-meters)
        public string FuelType { get; set; } = null!;
        public int Mileage { get; set; }
        public string Color { get; set; } = null!;

        //public string VIN { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int TopSpeed { get; set; }

        public double AccelerationSec0To100Kph {  get; set; }

        public double AccelerationSec0To200Kph { get; set; }

        public  double FuelConsumptionPer100km { get; set; }

        public double Co2EmissionsGPerKm { get; set; }

        public string ImageUrl { get; set; } = string.Empty!;

        public List<string> GalleryUrls { get; set; } = new List<string>();

        public Drivetrain Drivetrain { get; set; }

        public VehicleType Type { get; set; }

        public Engine Engine { get; set; } = new Engine();
        public Dimensions Dimensions { get; set; } = new Dimensions();

        public WheelSpecs RimSpecs { get; set; } = new WheelSpecs();

        public TyreSpecs FrontTyre { get; set; } = new TyreSpecs();

        public TyreSpecs RearTyre { get; set; } = new TyreSpecs();
    }
}
