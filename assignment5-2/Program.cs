using assignment5_2.struct1;
using assignment5_2.struct1.srruct3;
using assignment5_2.struct1.struct2.assignment6.ship;

namespace assignment5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions Q1
            //(A)  What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //===========solution=========
            // DeliveryAddress=>struct
            // بيتخزن جوا ال stack
            // وهو عباره عن =<value type 
            //وبكدا هيكون عندي اتنين object
            //والمتغير الاصلي مش هيتاثر بالتغيير 

            //(B)What happens when a Customer variable is copied into another variable and one variable modifies the object
            // Customer=>class
            //عباره عن refrence type
            //بتتخزن جوا ال heab
            // one object
            // وبكدا هيحصل تغيير في المتغير الاصلي 
            #endregion
            #region Theoretical Questions Q2 
            //a) Identify at least three problems with this design from an encapsulation perspective.
            //==============solution===============
            //1 لازم البيانات  اللي جوا ال struct تكون من نوع private.عشان امنع ان اي حد يدخل ويعدل عليها من برا
            //2 مفيش تحكم بالقيم الي داخله 
            //=======================================================
            //  b) How can private fields and public properties improve this design?
            //======================الحل =================
            //private =(لمنع دخول اي حد من برا الكلاس يدخل يعدل علي الfields)

            //public properties=(بتديني امكانيه اني اتجكم في القيم الي داخله لي )
            #endregion
            #region Smart Delivery Management System Q3
            //DelivryAddress address1 = new DelivryAddress(74, "elharam","giza");

            //DelivryAddress address2 = address1;
            //address2.City = "barcelona";
            //address2.BuildingNumber = 10;
            //address2.Street = "lm";
            //Console.WriteLine($"Original Address {address1.GetFullAddress()}");
            //Console.WriteLine($"After change {address2.GetFullAddress()}");

            #endregion
            #region Shipment Q4
            //Shipment s1 = new Shipment("OOP");
            //s1.PrintShipment();
            //Console.WriteLine(s1);
            #endregion

            #region Question6
            //// a. Create a DeliveryCenter
            //DeliveryCenter center = new DeliveryCenter("Cairo Main Center");

            //// b & c. Read data for 3 shipments and add them to DeliveryCenter
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine($"--- Enter Details for Shipment {i} ---");
            //    Console.Write("Tracking Code: ");
            //    string code = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string desc = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    double weight = double.Parse(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal fee = decimal.Parse(Console.ReadLine());

            //    Console.Write("Building Number: ");
            //    int bNum = int.Parse(Console.ReadLine());

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    DeliveryAddress address = new DeliveryAddress(bNum, street, city);
            //    Shipment shipment = new Shipment(code, desc, weight, fee, address);

            //    center.AddShipment(shipment);
            //    Console.WriteLine();
            //}

            //// d. Print the 3 shipments using integer indexer
            //Console.WriteLine("=== Displaying All Shipments (using int indexer) ===");
            //for (int i = 0; i < 3; i++)
            //{
                
            //        center[i].PrintShipment();

            //}


            //// h Ask for tracking code & search using string indexer
            //Console.WriteLine("\n Search Shipment ");
            //Console.Write("Enter tracking code to search: ");
            //string searchCode = Console.ReadLine();

            //Shipment foundShipment = center[searchCode];

            //// g. Print if found, otherwise print error

            //{
            //    Console.WriteLine("Shipment found:");
            //    foundShipment.PrintShipment();

     
            //    DeliveryAddress addr1 = new DeliveryAddress(10, "El-Tahrir St", "Cairo");
            //    DeliveryAddress addr2 = addr1; 

            //    addr2.City = "Alexandria"; 

            //    Console.WriteLine($"Original Address (addr1): {addr1}");
            //    Console.WriteLine($"Copied Address   (addr2): {addr2}");
            //}
            #endregion
        }

    }
}
    

