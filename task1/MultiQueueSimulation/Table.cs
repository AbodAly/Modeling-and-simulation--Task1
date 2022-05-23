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
<<<<<<< HEAD
        SimulationSystem SimulationSystemobj;
=======
        public static string pub;

        SimulationSystem simSysObj;
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2
        SimulationSystem obj2 = new SimulationSystem();

        public Dictionary<int, List<int>> server;

        public Table(SimulationSystem obj)
        {
            InitializeComponent();
<<<<<<< HEAD
            SimulationSystemobj = obj;
=======
            simSysObj = obj;
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2
            filename = obj.FileName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            if (simSysObj.FileName != null)
                simSysObj = readFromFile.readData(filename);

            CalculationModel.calcaTable(ref simSysObj);
            for (int i = 0; i < simSysObj.SimulationTable.Count(); i++)
            {
                DGV1.Rows.Add();
                DGV1.Rows[i].Cells[0].Value = simSysObj.SimulationTable[i].CustomerNumber;
                DGV1.Rows[i].Cells[1].Value = simSysObj.SimulationTable[i].RandomInterArrival;
                DGV1.Rows[i].Cells[2].Value = simSysObj.SimulationTable[i].InterArrival;
                DGV1.Rows[i].Cells[3].Value = simSysObj.SimulationTable[i].ArrivalTime;
                DGV1.Rows[i].Cells[4].Value = simSysObj.SimulationTable[i].RandomService;
                DGV1.Rows[i].Cells[5].Value = simSysObj.SimulationTable[i].AssignedServer.ID;
                DGV1.Rows[i].Cells[6].Value = simSysObj.SimulationTable[i].StartTime;
                DGV1.Rows[i].Cells[7].Value = simSysObj.SimulationTable[i].ServiceTime;
                DGV1.Rows[i].Cells[8].Value = simSysObj.SimulationTable[i].EndTime;
                DGV1.Rows[i].Cells[9].Value = simSysObj.SimulationTable[i].TimeInQueue;
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2

            }



<<<<<<< HEAD
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
=======
            CalculationModel.PerformanceSysMeasure(ref simSysObj);
            DGV1.Rows.Add();

          //  SimulationSystemobj.PerformanceMeasures.WaitingProbability=0.99;

            DGV1.Rows[DGV1.Rows.Count - 1].Cells[9].Value = CalculationModel.TotalQeueuTime(simSysObj);
            label11.Text = rounder(simSysObj.PerformanceMeasures.AverageWaitingTime, 4);

            label12.Text = rounder(simSysObj.PerformanceMeasures.WaitingProbability,4);
            label13.Text = rounder(simSysObj.PerformanceMeasures.MaxQueueLength,4);
            

            CalculationModel.MaxQueue(ref simSysObj);
            CalculationModel.performanceForEachServer(ref simSysObj);

            if (pub == "1")
            {
                pub = Constants.FileNames.TestCase1;
            }
            else if(pub=="2")
            {
                pub = Constants.FileNames.TestCase2;

            }
            else if(pub=="3")
            {
                pub = Constants.FileNames.TestCase3;
            }
            string result = MultiQueueTesting.TestingManager.Test(simSysObj, pub);
            MessageBox.Show(result);

            obj2 = simSysObj;
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2

            for (int i = 0; i < obj2.NumberOfServers; i++)
            {
                comboBox1.Items.Add(obj2.Servers[i].ID.ToString());
            }
            server = CalculationModel.chartofserver(ref obj2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
        {
            graph g = new graph(SimulationSystemobj);
            g.Show();
        }

=======
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2
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
<<<<<<< HEAD

=======
        public string rounder(decimal num,int point)
        {
           return Math.Round(num, point).ToString(); 
        }
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();

                label6.Text = "";
                label5.Text = "";
                label7.Text = "";
<<<<<<< HEAD
                CalculationModel.MaxQueue(ref SimulationSystemobj);
                CalculationModel.performanceForEachServer(ref SimulationSystemobj);
=======
                CalculationModel.MaxQueue(ref simSysObj);
                CalculationModel.performanceForEachServer(ref simSysObj);
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2

                int ID = int.Parse(comboBox1.SelectedItem.ToString());


<<<<<<< HEAD
                for (int i = 0; i < SimulationSystemobj.NumberOfServers; i++)
                {
                    if (ID == SimulationSystemobj.Servers[i].ID)
                    {
                        label5.Text = SimulationSystemobj.Servers[i].IdleProbability.ToString();
                        label6.Text = SimulationSystemobj.Servers[i].AverageServiceTime.ToString();
                        label7.Text = SimulationSystemobj.Servers[i].Utilization.ToString();
=======
                for (int i = 0; i < simSysObj.NumberOfServers; i++)
                {
                    if (ID == simSysObj.Servers[i].ID)
                    {
                        label5.Text = rounder(simSysObj.Servers[i].IdleProbability, 4);
                        label6.Text = rounder(simSysObj.Servers[i].AverageServiceTime,4);
                        label7.Text = rounder(simSysObj.Servers[i].Utilization, 4);
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2

                    }
                }


                chart1.Series.Add(ID.ToString());
                // 0,  2  5  6  7
                // 1,  1 2  8  9  10   12 13

                for (int i = 0; i < server[ID].Count; i++)
                {
                    chart1.Series[ID.ToString()].Points.AddXY(server[ID][i], 1);
                }
<<<<<<< HEAD
                chart1.Titles.Add("Server" + ID.ToString());
            }
        }
=======
                chart1.Titles.Add("Server : " + ID.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 forn = new Form1();
            forn.Show();
            this.Hide();
        }
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2
    }
}
