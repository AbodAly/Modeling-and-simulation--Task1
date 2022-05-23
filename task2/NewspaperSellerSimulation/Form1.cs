using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;
using NewspaperSellerModels;
using System.IO;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        List<DayTypeDistribution> DTD;
        List<DemandDistribution> DD;
        SimulationSystem System_Obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Calc_button_Click_1(object sender, EventArgs e)
        {
            if (Day_type.Rows.Count == 0 || Demand_dist.Rows.Count == 0 ||
                Purchaseprice.Text == "" || numofpapers.Text == "" ||
                Numofrecords.Text == "" || scraps.Text == "" || sel_Price.Text == "")
            {
                MessageBox.Show("Error! please Enter values");
              
            }
            else
            {
                DTD = new List<DayTypeDistribution>();
                DD = new List<DemandDistribution>();
                decimal cp = 0;
                int range = 1;
                foreach (DataGridViewRow r in Day_type.Rows)
                {
                    if (r.Cells[0].Value != null)
                    {
                        DayTypeDistribution temp_DTD = new DayTypeDistribution();
                        temp_DTD.day_Type_Queue(ref temp_DTD, r, cp, range);
                        cp = temp_DTD.CummProbability;
                        range = temp_DTD.MaxRange + 1;
                        DTD.Add(temp_DTD);
                    }
                }
                decimal cp_Good = 0;
                decimal cp_Fair = 0;
                decimal cp_poor = 0;
                int range_Good = 1;
                int range_Fair = 1;
                int range_Poor = 1;
                foreach (DataGridViewRow r in Demand_dist.Rows)
                {
                    if (r.Cells[0].Value != null)
                    {
                        DemandDistribution temp_DD = new DemandDistribution();
                        temp_DD.demand_Dist_Queue(ref temp_DD, r, cp_Good, cp_Fair, cp_poor, range_Good, range_Fair, range_Poor);
                        cp_Good = temp_DD.DayTypeDistributions[0].Probability;
                        range_Good = temp_DD.DayTypeDistributions[0].MaxRange + 1;

                        cp_Fair = temp_DD.DayTypeDistributions[1].Probability;
                        range_Fair = temp_DD.DayTypeDistributions[1].MaxRange + 1;

                        cp_poor = temp_DD.DayTypeDistributions[2].Probability;
                        range_Poor = temp_DD.DayTypeDistributions[2].MaxRange + 1;
                        DD.Add(temp_DD);
                    }
                }
                System_Obj = new SimulationSystem(DTD, DD, numofpapers.Text, Numofrecords.Text, Purchaseprice.Text, scraps.Text, sel_Price.Text);
                System_Obj.Calculate_table();
                System_Obj.calculate_Performance();
               
                string testingResult = TestingManager.Test(System_Obj, Constants.FileNames.TestCase1);
                MessageBox.Show(testingResult);

                Simulation_Table st = new Simulation_Table(System_Obj)
                {

                    MinimumSize = new Size(986, 629)
                };

                st.Show();



            }
        }
        private void Read_File_Button_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Refresh_form();
                if (openFileDialog1.FileName != "")
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    while (sr.Peek() != -1)
                    {
                        string res = sr.ReadLine();
                        if (res == "NumOfNewspapers")
                        {
                            string num_p = sr.ReadLine();
                            numofpapers.Text = num_p;
                        }
                        else if (res == "NumOfRecords")
                        {
                            string num_r = sr.ReadLine();
                            Numofrecords.Text = num_r;
                        }
                        else if (res == "PurchasePrice")
                        {
                            string pur_p = sr.ReadLine();
                            Purchaseprice.Text = pur_p;
                        }
                        else if (res == "ScrapPrice")
                        {
                            string scr_p = sr.ReadLine();
                            scraps.Text = scr_p;
                        }
                        else if (res == "SellingPrice")
                        {
                            string sel_p = sr.ReadLine();
                            sel_Price.Text = sel_p;
                        }
                        else if (res == "DayTypeDistributions")
                        {
                            string[] daydist = sr.ReadLine().Split(',');
                            Day_type.Rows.Add("Good", daydist[0]);
                            Day_type.Rows.Add("Fair", daydist[1]);
                            Day_type.Rows.Add("Poor", daydist[2]);
                        }
                        else if (res == "DemandDistributions")
                        {
                            string str = "";
                            while ((str = sr.ReadLine()) != "")
                            {
                                if (str == null || str == "")
                                {
                                    break;
                                }
                                string[] splt = str.Split(',');
                                Demand_dist.Rows.Add(splt[0], splt[1], splt[2], splt[3]);
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
        }

        public void Refresh_form()
        {
            numofpapers.Text = "";
            Numofrecords.Text = "";
            Purchaseprice.Text = "";
            scraps.Text = "";
            sel_Price.Text = "";
            Day_type.Rows.Clear();
            Day_type.Refresh();
            Demand_dist.Rows.Clear();
            Demand_dist.Refresh();
        }

        private void Day_type_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Demand_dist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Purchaseprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void numofpapers_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        

        
    }
}
