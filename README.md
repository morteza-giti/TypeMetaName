# TypeMetaName - Simplifying Object Type Resolution using Attributes and Reflection in C#

The TypeMetaName project is a C# showcase that leverages reflection and custom attributes to streamline the resolution of object types based on specified string values. The project includes a custom attribute, TypeMetaNameAttribute, which can be applied to classes to associate them with specific type names.

## Example Classes
In this project, several example classes inherit from an abstract base class, Vehicle. Each derived class represents a type of vehicle, such as cars, bikes, buses, and a generic vehicle.

- GenericVehicle: Represents a generic vehicle.
- Car: Represents a car.
- Bike: Represents a bike.
- Bus: Represents a bus.

## Simplified Type Resolution

Traditionally, developers would use conditional constructs like switch-case to map input strings to the appropriate object types. However, in this project, the use of reflection and the TypeMetaNameAttribute allows for a more flexible and maintainable approach.

Instead of using explicit conditionals, the project demonstrates the use of reflection to dynamically instantiate objects based on the provided type name. This technique simplifies the code and enhances maintainability, especially as the number of types grows.

The provided console application showcases both the traditional conditional approach and the reflection-based approach, highlighting the benefits of using reflection and custom attributes for type resolution.
