
#region struct DeliveryCenter

//using assignment5_2.struct1.struct2.assignment6.ship;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace assignment5_2.struct1.srruct3
//{
//   public struct DeliveryCenter
//   {
//        private Shipment[] shipments;
//        private int count;

//        public string CenterName { get; set; }

//        public DeliveryCenter()
//        {
//            shipments = new Shipment[20];
//            count = 0;
//        }

//        public DeliveryCenter(string centerName) : this()
//        {
//            CenterName = centerName;
//        }

//        public Shipment this[int index]
//        {
//            get
//            {
//                if (index >= 0 && index < count)
//                    return shipments[index];

//                return default;
//            }

//            set
//            {
//                if (index >= 0 && index < count)
//                    shipments[index] = value;
//            }
//        }

//        public Shipment this[string trackingCode]
//        {
//            get
//            {
//                for (int i = 0; i < count; i++)
//                {
//                    if (shipments[i].trackingcode == trackingCode)
//                        return shipments[i];
//                }

//                return default;
//            }
//        }

//        public bool AddShipment(Shipment shipment)
//        {
//            if (count >= shipments.Length)
//                return false;

//            shipments[count] = shipment;
//            count++;

//            return true;
//        }
//  }
//}
#endregion