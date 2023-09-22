using TypeMetaName;

namespace ConsoleApp1
{
    [TypeMetaName("Generic Vehicle")]
    public class GenericVehicle : Vehicle
    {
        public override string Name { get; set; } = "This is a generic vehicle.";
    }
}
