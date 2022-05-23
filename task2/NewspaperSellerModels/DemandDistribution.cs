using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NewspaperSellerModels
{
    public class DemandDistribution
    {
        public DemandDistribution()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
        }
        public int Demand { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }

        public void demand_Dist_Queue(ref DemandDistribution dd, DataGridViewRow r, decimal cum_g, decimal cum_f, decimal cum_p, int range_g, int range_f, int range_p)
        {
            dd.Demand = Convert.ToInt32(r.Cells[0].Value);
            DayTypeDistribution d = new DayTypeDistribution();
            d.DayType = Enums.DayType.Good;
            d.Probability = Convert.ToDecimal(r.Cells[1].Value) + cum_g;
            d.CummProbability = d.Probability;
            d.MinRange = range_g;
            d.MaxRange = (int)(d.CummProbability * 100);
            dd.DayTypeDistributions.Add(d);

            DayTypeDistribution d2 = new DayTypeDistribution();
            d2.DayType = Enums.DayType.Fair;
            d2.Probability = Convert.ToDecimal(r.Cells[2].Value) + cum_f;
            d2.CummProbability = d2.Probability;
            d2.MinRange = range_f;
            d2.MaxRange = (int)(d2.CummProbability * 100);
            dd.DayTypeDistributions.Add(d2);

            DayTypeDistribution d3 = new DayTypeDistribution();
            d3.DayType = Enums.DayType.Poor;
            d3.Probability = Convert.ToDecimal(r.Cells[3].Value) + cum_p;
            d3.CummProbability = d3.Probability;
            d3.MinRange = range_p;
            d3.MaxRange = (int)(d3.CummProbability * 100);
            dd.DayTypeDistributions.Add(d3);
        }
    }
}

