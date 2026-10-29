using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOP4
{
    internal class InternationalShipment : Shipment, ITrackable,IInsurable
    {

        private string destinationCountry;
        private decimal customsFee;
        #region constractor ching 3 answer 3 part 2
        public InternationalShipment(string t, string de, decimal W, decimal df, DeliveryAddress d, string desCoun, decimal Custom) : base(t, de, W, df, d)
        {
            DestinationCountry = desCoun;
            CustomsFee = Custom;

        }
        #endregion
        public string DestinationCountry
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;

                }
            }
            get
            {
                return destinationCountry;
            }
        }
        // over ride 2
        public override decimal EstimatedCost
        {
            get { return EstimatedCost + CustomsFee; }

        }
        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }


            }

        }

        public override string PrintShipment()
        {
            return $"TrackingNumber: {TrackingCode}Description: {Descrption}EstimatedCost: {EstimatedCost}DestinationCountry: {DestinationCountry}CustomsFee:{CustomsFee}";
        }
        //answer 7 
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("internationalSgipment");
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }
        //override from interface
        public decimal CalculateInsurance()
{
    return EstimatedCost * 0.12m;
}
    }
}
