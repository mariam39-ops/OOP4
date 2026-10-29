using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOP4
{
    internal class DeliveryCenter
    {


        public string CenterName { get; set; }
        private int counter;
        private Shipment[] shiments = new Shipment[20];
       

        public DeliveryCenter(string c)
        {
            CenterName = c;
        }
        public Shipment this[int shi]
        {
            get
            {
                if (shi >= 0 && shi < shiments.Length)


                    return shiments[shi];
                return default!;

            }
            set
            {
                if (shi >= 0 && shi < shiments.Length)
                {
                    shiments[shi] = value;
                }
            }
        }
        public Shipment this[string code]
        {
            get
            {
                for (int i = 0; i < shiments.Length; i++)
                {
                    if (shiments[i].TrackingCode == code)
                    {
                        return shiments[i];
                    }
                }
                return default;
            }
        }


        public bool AddShipment(Shipment s)
        {
            for (int i = 0; i < shiments.Length; i++)
            {
                if (shiments[i] == null)
                {
                    shiments[i] = s;
                    counter++;
                    Console.WriteLine("the shipment is added  succsesfely");
                    return true;
                }
            }
            return false;


        }
        public bool RemoveShipment(string trackingCode)
        {
            int index = -1;

            for (int i = 0; i < counter; i++)
            {
                if (shiments[i].TrackingCode == trackingCode)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
                return false;
            for (int i = index; i < counter - 1; i++)
            {
                shiments[i] = shiments[i + 1];
            }
            counter--;
            shiments[counter] = null;
            return true;

        }
        public void PrintAllShipment()
        {
            if (counter == 0)
            {
                Console.WriteLine("no shipment storege");
                return;
            }
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(shiments[i].PrintShipment());
            }


      
       }
        //q6
        public void PrintTrackingStatuses()
        {
            foreach (Shipment shipment in shiments)
            {
                ITrackable trackable = (ITrackable)shipment;
                Console.WriteLine(trackable.GetTrackingStatus());
            }
        }
        //
    }
    }
