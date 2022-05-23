using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        public SimulationSystem(List<DayTypeDistribution> temp_day, List<DemandDistribution> temp_dem, string numofpapers, string Numofrecords, string Purchaseprice, string scraps, string sel_Price)
        {
            DayTypeDistributions = temp_day;
            DemandDistributions = temp_dem;
            this.NumOfNewspapers = Convert.ToInt32(numofpapers);
            this.NumOfRecords = Convert.ToInt32(Numofrecords);
            this.PurchasePrice = Convert.ToDecimal(Purchaseprice);
            this.ScrapPrice = Convert.ToDecimal(scraps);
            this.SellingPrice = Convert.ToDecimal(sel_Price);
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        public void Calculate_table()
        {
            Random rnd = new Random();
            int[] arr_newDay = { 94, 77, 49, 45, 43, 32, 49, 100, 16, 24, 31, 14, 41, 61, 85, 8, 15, 97, 52, 78 };
            int[] arr_dem = { 80, 20, 15, 88, 98, 65, 86, 73, 24, 60, 60, 29, 18, 90, 93, 73, 21, 45, 76, 96 };
            for (int i = 1; i <= NumOfRecords; i++)
            {
                SimulationCase sc = new SimulationCase(i);
                sc.Calculate_case(DayTypeDistributions, DemandDistributions, NumOfNewspapers, NumOfRecords, PurchasePrice, SellingPrice, ScrapPrice, UnitProfit, rnd.Next(1, 101), rnd.Next(1, 101));
                SimulationTable.Add(sc);
            }
        }

        public void calculate_Performance()
        {
            int dem_days = 0, unsold_days = 0;
            decimal total_netprofit = 0, total_scrap = 0, total_lostProfit = 0, total_revenue = 0;
            foreach (SimulationCase sc in SimulationTable)
            {
                if (sc.Demand > NumOfNewspapers)
                {
                    dem_days++;
                }
                else if (NumOfNewspapers > sc.Demand)
                {
                    unsold_days++;
                }
                total_lostProfit += sc.LostProfit;
                total_netprofit += sc.DailyNetProfit;
                total_revenue += sc.SalesProfit;
                total_scrap += sc.ScrapProfit;
            }
            PerformanceMeasures.DaysWithMoreDemand = dem_days;
            PerformanceMeasures.DaysWithUnsoldPapers = unsold_days;
            PerformanceMeasures.TotalCost = (NumOfNewspapers * PurchasePrice) * NumOfRecords;
            PerformanceMeasures.TotalNetProfit = total_netprofit;
            PerformanceMeasures.TotalLostProfit = total_lostProfit;
            PerformanceMeasures.TotalSalesProfit = total_revenue;
            PerformanceMeasures.TotalScrapProfit = total_scrap;
        }
        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

    }
}