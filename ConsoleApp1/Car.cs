using TypeMetaName;

namespace ConsoleApp1
{
    [TypeMetaName("Car")]
    public class Car : Vehicle
    {
        public override string Name { get; set; } = "This is a car.";
    }
}
