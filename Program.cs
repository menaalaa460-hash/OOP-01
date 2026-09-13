#region
//public struct DeliveryAddress
//{
//    public string City; public string Street;
//}
//public class Customer
//{
//    public string Name;
//}
//a)	 What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
//    ..Because DeliveryAddress is a struct (value type), copying it creates an independent copy. 
//    Modifying the copied variable does not affect the original variable.

//B)b) What happens when a Customer variable is copied into another variable and one variable modifies the objec
//Because Customer is a class (reference type), copying the variable copies the reference to the same object
#endregion

#region
//public struct Shipment
//{
//    public string Description; public double Weight; public decimal DeliveryFee;
//}

//a)	a) Identify at least three problems with this design from an encapsulation perspective.

//   1- The fields are public
//   2-There is no validation 
//   3-The internal data is not protected

//b)	b) How can private fields and public properties improve this design ?
// Private fields protect the data
// Public properties provide controlled access and validation
#endregion

#region Practical
//User Story: You are building a simple Smart Delivery Management System for a delivery company. The system man-ages shipment data,
//delivery addresses, price and shipment searching. Build it as a Console Application that reads data from the user and prints shipment information.

//struct DeliveryAddress
//{
//    public string City;
//    public string Street;
//    public int BuildingNumber;

//    public DeliveryAddress(string city, string street, int buildingNumber)
//    {
//        City = city;
//        Street = street;
//        BuildingNumber = buildingNumber;
//    }
//    public string GetFullAddress()
//    {
//        return $"{BuildingNumber} {Street}, {City}";
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        DeliveryAddress address1 =
//            new DeliveryAddress("Cairo", "Maadi Street", 233);
//        DeliveryAddress address2 = address1;
//        address2.City = "Cairo";
//        address2.Street = " october ";
//        address2.BuildingNumber = 20;

//        Console.WriteLine("Original Address: " + address1.GetFullAddress());

//        Console.WriteLine("Copied Address: " + address2.GetFullAddress());
//    }
//}
#endregion




