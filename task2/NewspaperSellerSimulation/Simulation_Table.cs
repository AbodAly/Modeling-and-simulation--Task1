using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerSimulation;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Simulation_Table : Form
    {
        SimulationSystem ss_obj;
 
        public Simulation_Table(SimulationSystem obj)
        {
            ss_obj = obj;
            InitializeComponent();
        }

        private void Simulation_Table_Load_1(object sender, EventArgs e)
        {

            for (int i = 0; i < ss_obj.SimulationTable.Count; i++)
            {
                Demand_dist.Rows.Add(ss_obj.SimulationTable[i].DayNo,
                    ss_obj.SimulationTable[i].RandomNewsDayType,
                    ss_obj.SimulationTable[i].NewsDayType, ss_obj.SimulationTable[i].RandomDemand,
                    ss_obj.SimulationTable[i].Demand, ss_obj.SimulationTable[i].SalesProfit,
                    ss_obj.SimulationTable[i].LostProfit, ss_obj.SimulationTable[i].ScrapProfit,
                    ss_obj.SimulationTable[i].DailyNetProfit);
            }
         
            TotalSalesProfit.Text = ss_obj.PerformanceMeasures.TotalSalesProfit.ToString();
            TotalCost.Text = ss_obj.PerformanceMeasures.TotalCost.ToString();
            TotalLostProfit.Text = ss_obj.PerformanceMeasures.TotalLostProfit.ToString();
            TotalNetProfit.Text = ss_obj.PerformanceMeasures.TotalNetProfit.ToString();
            DaysWithMoreDemand.Text = ss_obj.PerformanceMeasures.DaysWithMoreDemand.ToString();
            DaysWithUnsoldPapers.Text = ss_obj.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
            TotalScrapProfit.Text = ss_obj.PerformanceMeasures.TotalScrapProfit.ToString();

        }

        private void Demand_dist_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
