using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region struct shipment

//namespace assignment5_2.struct1.struct2
//{
//  namespace assignment6.ship
// {
//        public struct Shipment
//        {

//            private string Trackingcode;
//            private string Description;
//            private double Weight;
//            private decimal Deliveryfee;
//            private DeliveryAddress Destination;
//            public string trackingcode
//            {

//                get
//                {
//                    return Trackingcode;
//                }
//            }
//            public string description
//            {
//                get { return Description; }

//                set
//                {
//                    if (!string.IsNullOrWhiteSpace(value))
//                    {
//                        Description = value;
//                        return;
//                    }
//                    Console.WriteLine("error");
//                }
//            }
//            public double weight
//            {
//                get { return Weight; }

//                set
//                {
//                    if (value > 0)
//                    {
//                        Weight = value;
//                        return;
//                    }
//                    Console.WriteLine("error");
//                }
//            }

//            public decimal deliveryfee
//            {
//                get { return Deliveryfee; }
//                private set
//                {
//                    if (value > 0)
//                    {
//                        Deliveryfee = value;
//                        return;
//                    }
//                    Console.WriteLine("error");
//                }
//            }
//            public DeliveryAddress destination
//            {
//                get { return Destination; }
//                set { Destination = value; }
//            }
//            public  decimal EstimatedCost
//            {
//                get { return Deliveryfee + ((decimal)Weight * 5); }
//            }
//            public Shipment (string TrackingCode)

//            {

//                this.Trackingcode = TrackingCode;
//                Description = "unknown";
//                Weight = 1;
//                Deliveryfee = 50;
//                Destination = new DeliveryAddress();

//            }
//            public Shipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DeliveryAddress Destination)
//            {
//                this.Description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
//                this.Weight = weight > 0 ? weight : 1.0;
//                this.Deliveryfee = Deliveryfee > 0 ? Deliveryfee : 50;
//                this.Destination = Destination;

//            }
//            public Shipment()
//            {
//            }
//            public void UpdateDeliveryFee(decimal newFee)
//            {
//                if (newFee > 0)
//                {
//                    Deliveryfee = newFee;
//                    return;

//                }
//                Console.WriteLine("erorr");
//            }
//            public override string ToString()
//            {
//                return $"{Trackingcode} ,{Description}, {Weight} ,{Deliveryfee}. {Destination}.{EstimatedCost} ";


//            }
//            public void PrintShipment()
//            {
//                Console.WriteLine(this.ToString());
//            }

//        }
//    }



//}
#endregion