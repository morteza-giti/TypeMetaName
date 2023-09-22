using TypeMetaName;

namespace ConsoleApp1
{
    [TypeMetaName("Bike")]
    public class Bike : Vehicle
    {
        public override string Name { get; set; } = "This is a bike.";
    }
}
