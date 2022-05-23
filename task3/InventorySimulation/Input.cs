using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTesting;
using InventoryModels;
using System.IO;

namespace InventorySimulation
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
            this.system = new SimulationSystem();
         }
        SimulationSystem system;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Results res = new Results(system);
            res.Show();
            this.Hide();

        }

        private void ReadData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////

             openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                if (openFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    while (sr.Peek() != -1)
                    {
                        string res = sr.ReadLine();
                        if (res == "OrderUpTo")
                        {
                            string Order = sr.ReadLine();

                            dataGridView1.Rows[0].Cells[0].Value = Order;

                           system.OrderUpTo = int.Parse(Order);
                        }
                        else if (res == "ReviewPeriod")
                        {
                            string RP = sr.ReadLine();

                            dataGridView1.Rows[0].Cells[1].Value = RP;

                             system.ReviewPeriod = int.Parse(RP);
                        }
                        else if (res == "StartInventoryQuantity")
                        {
                            string SIQ = sr.ReadLine();

                            dataGridView1.Rows[0].Cells[2].Value = SIQ;

                             system.StartInventoryQuantity = int.Parse(SIQ);
                        }
                        else if (res == "StartLeadDays")
                        {
                            string SLD = sr.ReadLine();

                            dataGridView1.Rows[0].Cells[3].Value = SLD;

                             system.StartLeadDays = int.Parse(SLD);
                        }
                        else if (res == "StartOrderQuantity")
                        {
                            string SOQ = sr.ReadLine();

                            dataGridView1.Rows[0].Cells[4].Value = SOQ;

                             system.StartOrderQuantity = int.Parse(SOQ);
                        }
                        else if (res == "NumberOfDays")
                        {
                            string NOD = sr.ReadLine();

                            dataGridView1.Rows[0].Cells[5].Value = NOD;

                             system.NumberOfDays = int.Parse(NOD);
                        }
                        else if (res == "DemandDistribution")
                        {
                           
                                       decimal cumProb = 0;
                                        int min = 1;
                                        int max;
                           
                            string str = "";
                            while ((str = sr.ReadLine()) != "")
                            {

                                if (str == null || str == "")
                                {
                                    break;
                                }
                                string[] splt = str.Split(',');
                                Distribution dis = new Distribution();
                                dis.Value = int.Parse(splt[0]);
                                dis.Probability = decimal.Parse(splt[1].TrimStart());
                                cumProb += dis.Probability;
                                dis.CummProbability = cumProb;
                                dis.MinRange = min;
                                max = (int)(cumProb * 100);
                                dis.MaxRange = max;
                                min = max + 1;
                                system.DemandDistribution.Add(dis);
                                dataGridView2.Rows.Add(splt[0], splt[1],cumProb,min,max);
                            }

                        }
                        else if (res == "LeadDaysDistribution")
                        {
                            
                                        decimal cumProb = 0;
                                        int min = 1;
                                        int max;
                           
                            string str = "";
                            while ((str = sr.ReadLine()) != "")
                            {
                                if (str == null || str == "")
                                {
                                    break;
                                }
                                string[] splt = str.Split(',');
                                Distribution dis = new Distribution();
                                dis.Value = int.Parse(splt[0]);
                                dis.Probability = decimal.Parse(splt[1].TrimStart());
                                cumProb += dis.Probability;
                                dis.CummProbability = cumProb;
                                dis.MinRange = min;
                                max = (int)(cumProb * 100);
                                dis.MaxRange = max;
                                min = max + 1;
                                system.LeadDaysDistribution.Add(dis);
                                dataGridView3.Rows.Add(splt[0], splt[1],cumProb,min,max);
                            }
                        }
                    }
                    sr.Close();

                }
                else
                {
                    MessageBox.Show("Error! Please Choose Correct File!");
                }
            }

            //////////////////////////////////////////////////

            //string path = "../../TestCases/TestCase1.txt";
            //this.ReadInput(path);
            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("Order Up to", typeof(int));
            //dataTable.Columns.Add("Review Period", typeof(int));
            //dataTable.Columns.Add("Start Inventory Quantity", typeof(int));
            //dataTable.Columns.Add("Start Lead Days", typeof(int));
            //dataTable.Columns.Add("Start Order Quantity", typeof(int));
            //dataTable.Columns.Add("Number of Days", typeof(int));
            //dataTable.Rows.Add(system.OrderUpTo, system.ReviewPeriod, system.StartInventoryQuantity, system.StartLeadDays, system.StartOrderQuantity, system.NumberOfDays);
            //dataGridView1.DataSource = dataTable;

            //DataTable dataTable2 = new DataTable();
            //dataTable2.Columns.Add("Demand", typeof(int));
            //dataTable2.Columns.Add("Probability", typeof(decimal));
            //dataTable2.Columns.Add("Cumulative Probability", typeof(decimal));
            //dataTable2.Columns.Add("MinRange", typeof(int));
            //dataTable2.Columns.Add("MaxRang", typeof(int));
            //for (int i = 0; i < system.DemandDistribution.Count; i++)
            //{
            //    dataTable2.Rows.Add(system.DemandDistribution[i].Value, system.DemandDistribution[i].Probability, system.DemandDistribution[i].CummProbability, system.DemandDistribution[i].MinRange, system.DemandDistribution[i].MaxRange);
            //}
            //dataGridView2.DataSource = dataTable2;
            //DataTable dataTable3 = new DataTable();
            //dataTable3.Columns.Add("Demand", typeof(int));
            //dataTable3.Columns.Add("Probability", typeof(decimal));
            //dataTable3.Columns.Add("Cumulative Probability", typeof(decimal));
            //dataTable3.Columns.Add("MinRange", typeof(int));
            //dataTable3.Columns.Add("MaxRang", typeof(int));
            //for (int i = 0; i < system.LeadDaysDistribution.Count; i++)
            //{
            //    dataTable3.Rows.Add(system.LeadDaysDistribution[i].Value, system.LeadDaysDistribution[i].Probability, system.LeadDaysDistribution[i].CummProbability, system.LeadDaysDistribution[i].MinRange, system.LeadDaysDistribution[i].MaxRange);
            //}
            //dataGridView3.DataSource = dataTable3;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private int Int32Converter(string order)
        //{
        //    throw new NotImplementedException();
        //}
        //public void ReadInput(string path)

        //{

        //    string[] lines = System.IO.File.ReadAllLines(path);
        //    for (int i = 0; i < lines.Length; i++)
        //    {
        //        if (lines[i] == "") { continue; }
        //        else if (lines[i] == "OrderUpTo")
        //        {
        //            i++;
        //            system.OrderUpTo = int.Parse(lines[i]);
        //        }
        //        else if (lines[i] == "ReviewPeriod")
        //        {
        //            i++;
        //            system.ReviewPeriod = int.Parse(lines[i]);
        //        }
        //        else if (lines[i] == "StartInventoryQuantity")
        //        {
        //            i++;
        //            system.StartInventoryQuantity = int.Parse(lines[i]);
        //        }
        //        else if (lines[i] == "StartLeadDays")
        //        {
        //            i++;
        //            system.StartLeadDays = int.Parse(lines[i]);
        //        }
        //        else if (lines[i] == "StartOrderQuantity")
        //        {
        //            i++;
        //            system.StartOrderQuantity = int.Parse(lines[i]);
        //        }
        //        else if (lines[i] == "NumberOfDays")
        //        {
        //            i++;
        //            system.NumberOfDays = int.Parse(lines[i]);
        //        }
        //        else if (lines[i] == "DemandDistribution")
        //        {
        //            i++;
        //            decimal cumProb = 0;
        //            int min = 1;
        //            int max;
        //            while (lines[i] != "")
        //            {
        //                string[] line = lines[i].Split(',');
        //                Distribution dis = new Distribution();
        //                dis.Value = int.Parse(line[0]);
        //                dis.Probability = decimal.Parse(line[1].TrimStart());
        //                cumProb += dis.Probability;
        //                dis.CummProbability = cumProb;
        //                dis.MinRange = min;
        //                max = (int)(cumProb * 100);
        //                dis.MaxRange = max;
        //                min = max + 1;
        //                system.DemandDistribution.Add(dis);
        //                i++;
        //            }
        //        }
        //        else if (lines[i] == "LeadDaysDistribution")
        //        {
        //            i++;
        //            decimal cumProb = 0;
        //            int min = 1;
        //            int max;
        //            while (i < lines.Length && lines[i] != "")
        //            {
        //                string[] line = lines[i].Split(',');
        //                Distribution dis = new Distribution();
        //                dis.Value = int.Parse(line[0]);
        //                dis.Probability = decimal.Parse(line[1].TrimStart());
        //                cumProb += dis.Probability;
        //                dis.CummProbability = cumProb;
        //                dis.MinRange = min;
        //                max = (int)(cumProb * 100);
        //                dis.MaxRange = max;
        //                min = max + 1;
        //                system.LeadDaysDistribution.Add(dis);
        //                i++;
        //            }
        //        }

        //    }
        //}

    }
}
