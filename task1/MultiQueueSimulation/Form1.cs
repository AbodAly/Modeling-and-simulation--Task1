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
<<<<<<< HEAD

        private void button1_Click(object sender, EventArgs e)
        {
            SimulationSystem obj = new SimulationSystem();
            //PerformanceTable f = new PerformanceTable(obj);
            // obj.FileName = "TestCase1.txt";
            obj.FileName = FN;
            Table forn = new Table(obj);
            forn.Show();
=======
        SimulationSystem obj;
        private void button1_Click(object sender, EventArgs e)
        {
            obj = new SimulationSystem();
            obj.FileName = textBox1.Text;
            int len = textBox1.Text.Length;
            string str = textBox1.Text.ToString();
            Table.pub= str[len-5].ToString();
            // start from hereeeeeeeeeeee
            Table wind2 = new Table(obj);
            wind2.Show();
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            textBox1.Text = "C:\\Users\\DELL-MCC\\Desktop\\SC\\MultiQueueSimulation\\MultiQueueSimulation\\TestCases\\TestCase1.txt";
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "C:\\Users\\DELL-MCC\\Desktop\\SC\\MultiQueueSimulation\\MultiQueueSimulation\\TestCases\\TestCase1.txt";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "C:\\Users\\DELL-MCC\\Desktop\\SC\\MultiQueueSimulation\\MultiQueueSimulation\\TestCases\\TestCase2.txt";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "C:\\Users\\DELL-MCC\\Desktop\\SC\\MultiQueueSimulation\\MultiQueueSimulation\\TestCases\\TestCase3.txt";
>>>>>>> 3f6541a2e432de7e23f4503175a840658992c8b2

        }
    }
}
