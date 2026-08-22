namespace TASK9ROUTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Object Copying

            // a) What happens when you assign one object variable to another object variable?
            // Both variables reference the same object in memory.

            // b) Does assigning one object to another create a new object? Explain.
            // No, it does not create a new object.
            // It copies the reference, so both variables point to the same object.

            // c) What is the difference between copying an object and copying its reference?
            // Copying an object creates a new independent object.
            // Copying a reference makes two variables point to the same object.

            #endregion
            #region Q2 Shallow Copy vs Deep Copy

            // a) What is a Shallow Copy?
            // A Shallow Copy creates a new object,
            // but reference-type members still point to the same objects.

            // b) What is a Deep Copy?
            // A Deep Copy creates a new object
            // and also creates new copies of its reference-type members.

            // c) What happens to reference-type members when a Shallow Copy is created?
            // They are shared between the original object and the copied object.

            // d) What happens to reference-type members when a Deep Copy is created?
            // New independent copies of the reference-type members are created.

            // e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // Deep Copy is safer when we need to modify the copied object's data
            // without affecting the original object's data.

            #endregion
            #region Q3 Static Members

            // a) What is a static field, and how is it different from an instance field?
            // A static field belongs to the class and is shared between all objects.
            // An instance field belongs to each object separately.

            // b) What is a static method? Can a static method directly access instance members?
            // A static method belongs to the class, not to a specific object.
            // No, it cannot directly access instance members.

            // c) What is a static constructor, and when is it executed?
            // A static constructor is used to initialize static members.
            // It is executed automatically once before the class is used for the first time.

            // d) What is a static class? Can you create an object from a static class?
            // A static class contains static members and belongs to the class itself.
            // No, we cannot create an object from a static class.

            // a) What is a static field, and how is it different from an instance field?
            // A static field belongs to the class and is shared between all objects.
            // An instance field belongs to each object separately.

            // b) What is a static method? Can a static method directly access instance members?
            // A static method belongs to the class, not to a specific object.
            // No, it cannot directly access instance members.

            // c) What is a static constructor, and when is it executed?
            // A static constructor is used to initialize static members.
            // It is executed automatically once before the class is used for the first time.

            // d) What is a static class? Can you create an object from a static class?
            // A static class contains static members and belongs to the class itself.
            // No, we cannot create an object from a static class.

            #endregion
            #region Q4 Extension Methods

            // a) What is an Extension Method?
            // An Extension Method is a method that adds new functionality
            // to an existing class without modifying the original class.

            // b) What keyword must be used in the first parameter of an extension method?
            // The "this" keyword.

            // c) Where must an extension method be declared?
            // It must be declared inside a static class.

            // d) Can an extension method access private members of the class it extends?
            // No, it cannot directly access private members of the class.

            #endregion
            #region Q5 Partial Classes and Partial Methods

            // a) What is a Partial Class?
            // A Partial Class is a class that can be split into multiple files
            // using the "partial" keyword.

            // b) Why would a developer split one class into multiple files?
            // To organize the code and make large classes easier to read and maintain.

            // c) What is a Partial Method?
            // A Partial Method is a method that is declared in one part
            // of a partial class and can be implemented in another part.

            // d) What happens if a declared partial method has no implementation?
            // If the partial method has no implementation, the compiler removes
            // the declaration and its calls.

            #endregion
            //--- Part Two ---
            #region Part 02 - Q1 Object Copying

            DeliveryAddress address = new DeliveryAddress(
                "Cairo",
                "Nasr City",
                10
            );

            Shipment shipment1 = new StandardShipment(
                "SH001",
                "Laptop",
                3,
                50,
                address
            );

            Shipment shipment2 = shipment1;

            Console.WriteLine("Object Copying");
            Console.WriteLine($"Original Shipment : {shipment1.TrackingCode}");
            Console.WriteLine($"Assigned Shipment : {shipment2.TrackingCode}");

            Console.WriteLine($"Same Object : {ReferenceEquals(shipment1, shipment2)}");

            Shipment shipment3 = shipment1.CopyShipment();

            Console.WriteLine($"Copied Shipment : {shipment3.TrackingCode}");
            Console.WriteLine($"Same Object After Copy : {ReferenceEquals(shipment1, shipment3)}");

            #endregion

            #region Part 02 - Q2 Shallow Copy

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Shallow Copy");
            Console.WriteLine("------------------------------------------");

            Shipment shallowCopy = shipment1.ShallowCopy();

            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address : {shallowCopy.Destination.City}");

            Console.WriteLine("Changing copied shipment address...");

            shallowCopy.Destination.City = "Giza";

            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address : {shallowCopy.Destination.City}");

            Console.WriteLine($"Same Shipment Object : {ReferenceEquals(shipment1, shallowCopy)}");

            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shipment1.Destination, shallowCopy.Destination)}");

            #endregion

            #region Part 02 - Q3 Deep Copy

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Deep Copy");
            Console.WriteLine("------------------------------------------");

            // Reset original address after the Shallow Copy demonstration
            shipment1.Destination.City = "Cairo";

            Shipment deepCopy = shipment1.DeepCopy();

            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address : {deepCopy.Destination.City}");

            Console.WriteLine("Changing copied shipment address...");

            deepCopy.Destination.City = "Giza";

            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address : {deepCopy.Destination.City}");

            Console.WriteLine(
                $"Same DeliveryAddress Object : {ReferenceEquals(shipment1.Destination, deepCopy.Destination)}"
            );

            #endregion

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            #region Part 02 - Q7 Static Class

            Console.WriteLine();
            Console.WriteLine("Static Utilities");

            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle();

            Console.WriteLine(
                $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}"
            );

            #endregion

            #region Part 02 - Q10 Partial Method

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Partial Method");
            DeliveryUtilities.PrintSeparator();

            shipment1.UpdateTrackingStatus("Delivered");

            #endregion
        }
    }
}
