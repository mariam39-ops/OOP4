using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOP4
{
    internal class ExpressShipment : Shipment, ITrackable,IInsurable
    {
        #region ExpressShipment

        private decimal extrafee { get; set; }
        #region constractor chainin g 1 answer 3 part 2
        public ExpressShipment(string t, string d, decimal w, decimal de, DeliveryAddress del, decimal Exr) : base(t, d, w, de, del)
        {
            Extrafee = extrafee;
        }
        #endregion
        public decimal Extrafee
        {
            set
            {
                if (value >= 0)
                {
                    extrafee = value;
                }
            }
            get
            {
                return extrafee;
            }
        }
        //over ride1
        public override decimal EstimatedCost
        {
            get
            {
                return DeleiveryFee + (Weight * 5);
            }
        }


        
        //method over ride 3
        public override string PrintShipment()
        {
            return $"TrackingNumber: {TrackingCode}Description: {Descrption} EstimatedCost:{EstimatedCost}Extrafee: {Extrafee}";
        }
        #endregion
        public string GetTrackingStatus()
        {
            return $" {TrackingCode} is Out for Delivery.";
        }
        // overide from interface
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
