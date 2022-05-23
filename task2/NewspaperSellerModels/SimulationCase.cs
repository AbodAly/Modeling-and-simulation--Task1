using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationCase
    {
        public SimulationCase() { }
        public SimulationCase(int DayNum)
        {
            this.DayNo = DayNum;
        }
        public int DayNo { get; set; }
        public int RandomNewsDayType { get; set; }
        public Enums.DayType NewsDayType { get; set; }
        public int RandomDemand { get; set; }
        public int Demand { get; set; }
        public decimal DailyCost { get; set; }
        public decimal SalesProfit { get; set; }
        public decimal LostProfit { get; set; }
        public decimal ScrapProfit { get; set; }
        public decimal DailyNetProfit { get; set; }

        public void Calculate_case(List<DayTypeDistribution> dtd, List<DemandDistribution> dd,
            int NumOfNewspapers, int NumOfRecords, decimal PurchasePrice,
            decimal SellingPrice, decimal ScrapPrice, decimal UnitProfit, int r_day, int r_dem)
        {
            // return day type good   -  fair  -  poor  
            RandomNewsDayType = r_day;
            foreach (DayTypeDistribution d in dtd)
            {
                if (RandomNewsDayType >= d.MinRange && RandomNewsDayType <= d.MaxRange)
                {
                    NewsDayType = d.DayType;
                    break;
                }
            }
            RandomDemand = r_dem;
            // return demand of the choosen day type
            if (NewsDayType == Enums.DayType.Good)
            {
                foreach (DemandDistribution d in dd)
                {
                    if (RandomDemand >= d.DayTypeDistributions[0].MinRange && RandomDemand <= d.DayTypeDistributions[0].MaxRange)
                    {
                        Demand = d.Demand;
                    }
                }
            }
            else if (NewsDayType == Enums.DayType.Fair)
            {
                foreach (DemandDistribution d in dd)
                {
                    if (RandomDemand >= d.DayTypeDistributions[1].MinRange && RandomDemand <= d.DayTypeDistributions[1].MaxRange)
                    {
                        Demand = d.Demand;
                    }
                }
            }
            else if (NewsDayType == Enums.DayType.Poor)
            {
                foreach (DemandDistribution d in dd)
                {
                    if (RandomDemand >= d.DayTypeDistributions[2].MinRange && RandomDemand <= d.DayTypeDistributions[2].MaxRange)
                    {
                        Demand = d.Demand;
                    }
                }
            }
            //  cost of PurchasePrice every day
            DailyCost = NumOfNewspapers * PurchasePrice;

            // check if there is lost profit or scrap profit paper 
            if (Demand > NumOfNewspapers)
            {
                SalesProfit = Decimal.Round(NumOfNewspapers * SellingPrice, 1);
                LostProfit = (Demand - NumOfNewspapers) * (SellingPrice - PurchasePrice);
                ScrapProfit = 0;
            }
            else if (Demand < NumOfNewspapers)
            {
                SalesProfit = Decimal.Round(Demand * SellingPrice, 1);
                LostProfit = 0;
                ScrapProfit = ScrapPrice * (NumOfNewspapers - Demand);
            }
            else
            {
                SalesProfit = Decimal.Round(NumOfNewspapers * SellingPrice, 1);
                LostProfit = 0;
                ScrapProfit = 0;
            }
            DailyNetProfit = SalesProfit - DailyCost - LostProfit + ScrapProfit;
        }
    }

}
