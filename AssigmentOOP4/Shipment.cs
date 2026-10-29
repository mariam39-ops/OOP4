using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOP4
{
    internal  abstract class Shipment
    {


        private string trackingCode;
        private string descrption;
        private decimal weight;
        private decimal deleiveryFee;
        public DeliveryAddress destination { get; set; }
        public Shipment()
        {

        }
        public Shipment(string t)
        {
            trackingCode = t;
            descrption = "unknow";
            weight = 1;
            deleiveryFee = 50;
            destination = new DeliveryAddress();
        }
        public Shipment(string t, string d, decimal i, decimal de, DeliveryAddress delive)
        {
            TrackingCode = t;
            Descrption = d;
            Weight = i;
            DeleiveryFee = de;
            destination = delive;
        }
        //
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }

        }
        public string Descrption
        {
            get
            {
                return descrption;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    descrption = value;

                }
            }

        }
        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public virtual decimal DeleiveryFee
        {
            get
            {
                return deleiveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    deleiveryFee = value;
                }
                deleiveryFee = 150;
            }

        }
       //answer 2 part 2
        public abstract decimal EstimatedCost { get; }


        
        
        public void UpdateDeliveryFee(decimal newfee)
        {
            if (newfee > 0)
            {
                deleiveryFee = newfee;
            }

        }
        #region abstract method
        public abstract string PrintShipment();
        
        #endregion
        #region overloding weigth answer 2 part2
        public void upDateWeigth(decimal weigth)
        {
            weigth = weigth;
        }
        public void upDateWeigthExtra(decimal weigth, decimal extra)
        {
            Weight = weigth + extra;

        }
        #endregion
    }
}
