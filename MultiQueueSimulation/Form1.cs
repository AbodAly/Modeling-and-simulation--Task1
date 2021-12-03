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
    public partial class Form1 : Form
    {
        public static string FN = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog path_test = new OpenFileDialog();
            if (path_test.ShowDialog() == DialogResult.OK)
            {
                FN = path_test.FileName;
                textBox1.Text = FN;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimulationSystem obj = new SimulationSystem();
            //PerformanceTable f = new PerformanceTable(obj);
            // obj.FileName = "TestCase1.txt";
            obj.FileName = FN;
            Table forn = new Table(obj);
            forn.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
