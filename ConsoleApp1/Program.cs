using ConsoleApp1;
using System.Reflection;
using TypeMetaName;

Console.WriteLine("Enter your type name...");
var targetTypeName = Console.ReadLine();
Vehicle vehicle;

// The way I have seen it done in many cases
switch (targetTypeName)
{
    case "Car":
        vehicle = new Car();
        break;
    case "Bike":
        vehicle = new Bike();
        break;
    case "Bus":
        vehicle = new Bus();
        break;
    default:
        vehicle = new GenericVehicle();
        break;
}
Console.WriteLine(vehicle?.Name);

//The way I have implemented it using Reflection
var targetType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(type =>
{
    var typeMetaNameAttribute = type.GetCustomAttribute<TypeMetaNameAttribute>();
    return typeMetaNameAttribute != null && typeMetaNameAttribute.TypeName == targetTypeName;
});
vehicle = Activator.CreateInstance(targetType) as Vehicle;
Console.WriteLine(vehicle?.Name);

Console.ReadKey();