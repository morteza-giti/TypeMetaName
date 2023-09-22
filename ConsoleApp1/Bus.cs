using TypeMetaName;

namespace ConsoleApp1
{
    [TypeMetaName("Bus")]
    public class Bus : Vehicle
    {
        public override string Name { get; set; } = "This is a bus.";
    }
}
