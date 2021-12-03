using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;

using MultiQueueTesting;


namespace MultiQueueSimulation
{
    public partial class Table : Form
    {
        public static string filename;
        SimulationSystem SimulationSystemobj;
        SimulationSystem obj2 = new SimulationSystem();

        public Dictionary<int, List<int>> server;

        public Table(SimulationSystem obj)
        {
            InitializeComponent();
            SimulationSystemobj = obj;
            filename = obj.FileName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (SimulationSystemobj.FileName != null)
                SimulationSystemobj = readFromFile.readData(filename);

            CalculationModel.calcaTable(ref SimulationSystemobj);
            for (int i = 0; i < SimulationSystemobj.SimulationTable.Count(); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = SimulationSystemobj.SimulationTable[i].CustomerNumber;
                dataGridView1.Rows[i].Cells[1].Value = SimulationSystemobj.SimulationTable[i].RandomInterArrival;
                dataGridView1.Rows[i].Cells[2].Value = SimulationSystemobj.SimulationTable[i].InterArrival;
                dataGridView1.Rows[i].Cells[3].Value = SimulationSystemobj.SimulationTable[i].ArrivalTime;
                dataGridView1.Rows[i].Cells[4].Value = SimulationSystemobj.SimulationTable[i].RandomService;
                dataGridView1.Rows[i].Cells[5].Value = SimulationSystemobj.SimulationTable[i].AssignedServer.ID;
                dataGridView1.Rows[i].Cells[6].Value = SimulationSystemobj.SimulationTable[i].StartTime;
                dataGridView1.Rows[i].Cells[7].Value = SimulationSystemobj.SimulationTable[i].ServiceTime;
                dataGridView1.Rows[i].Cells[8].Value = SimulationSystemobj.SimulationTable[i].EndTime;
                dataGridView1.Rows[i].Cells[9].Value = SimulationSystemobj.SimulationTable[i].TimeInQueue;

            }



            CalculationModel.PerformanceSysMeasure(ref SimulationSystemobj);
            dataGridView1.Rows.Add();

          //  SimulationSystemobj.PerformanceMeasures.WaitingProbability=0.99;

            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[9].Value = CalculationModel.TotalQeueuTime(SimulationSystemobj);
            label1.Text = SimulationSystemobj.PerformanceMeasures.AverageWaitingTime.ToString();
            label2.Text = SimulationSystemobj.PerformanceMeasures.WaitingProbability.ToString();
            label3.Text = SimulationSystemobj.PerformanceMeasures.MaxQueueLength.ToString();

            CalculationModel.MaxQueue(ref SimulationSystemobj);
            CalculationModel.performanceForEachServer(ref SimulationSystemobj);

            string result = MultiQueueTesting.TestingManager.Test(SimulationSystemobj, Constants.FileNames.TestCase2);
            MessageBox.Show(result);

            obj2 = SimulationSystemobj;

            for (int i = 0; i < obj2.NumberOfServers; i++)
            {
                comboBox1.Items.Add(obj2.Servers[i].ID.ToString());
            }
            server = CalculationModel.chartofserver(ref obj2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            graph g = new graph(SimulationSystemobj);
            g.Show();
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //aa

            

        }

        private void Table_CursorChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();

                label6.Text = "";
                label5.Text = "";
                label7.Text = "";
                CalculationModel.MaxQueue(ref SimulationSystemobj);
                CalculationModel.performanceForEachServer(ref SimulationSystemobj);

                int ID = int.Parse(comboBox1.SelectedItem.ToString());


                for (int i = 0; i < SimulationSystemobj.NumberOfServers; i++)
                {
                    if (ID == SimulationSystemobj.Servers[i].ID)
                    {
                        label5.Text = SimulationSystemobj.Servers[i].IdleProbability.ToString();
                        label6.Text = SimulationSystemobj.Servers[i].AverageServiceTime.ToString();
                        label7.Text = SimulationSystemobj.Servers[i].Utilization.ToString();

                    }
                }


                chart1.Series.Add(ID.ToString());
                // 0,  2  5  6  7
                // 1,  1 2  8  9  10   12 13

                for (int i = 0; i < server[ID].Count; i++)
                {
                    chart1.Series[ID.ToString()].Points.AddXY(server[ID][i], 1);
                }
                chart1.Titles.Add("Server" + ID.ToString());
            }
        }
    }
}
