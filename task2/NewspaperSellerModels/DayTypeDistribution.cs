using System;
using System.Windows.Forms;

namespace NewspaperSellerModels
{
    public class DayTypeDistribution
    {
        public Enums.DayType DayType { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public void day_Type_Queue(ref DayTypeDistribution d, DataGridViewRow r, decimal CumP, int range)
        {

            if (r.Cells[0].Value.ToString().ToLower() == "good")
                d.DayType = Enums.DayType.Good;
            else if (r.Cells[0].Value.ToString().ToLower() == "fair")
                d.DayType = Enums.DayType.Fair;
            else if (r.Cells[0].Value.ToString().ToLower() == "poor")
                d.DayType = Enums.DayType.Poor;
            else
                d.DayType = Enums.DayType.Error;

            d.Probability = Convert.ToDecimal(r.Cells[1].Value);
            d.CummProbability = d.Probability + CumP;
            d.MinRange = range;
            d.MaxRange = (int)(d.CummProbability * 100);

        }
    }

}
