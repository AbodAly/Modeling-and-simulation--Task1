using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiQueueModels;
using System.Text.RegularExpressions;// to split the lines array 
using System.Windows.Forms;//to use dataGridview

namespace MultiQueueSimulation
{
    public class DistrubutionValues
    {
        public int Time { get; set; }
        public decimal Probability { get; set; }
    }

    class readFromFile
    {
        /*  Objective : read data into simulationSystem instance 
           make instance form simulatinSystem class 
            read all lines in the file into stirng array 
            number of servers in line 1 
            stoping number in line 4
            stoping criteria in line number 7 zero-based 
            selected methode in line number 10 zero-based 
            add methode inputdata() to class simulationSystem 
            */
        public static SimulationSystem readData(String FilePath)
        {
            SimulationSystem simObj = new SimulationSystem();
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            int indexFristRow = 13; //first row in time distribution table
            int numberOfServers = int.Parse(lines[1]);
            int stopingNumber = int.Parse(lines[4]);
            int stopingCriteria = int.Parse(lines[7]) - 1;
            int selectedMethode = int.Parse(lines[10]) - 1;
            simObj.inputData(numberOfServers, stopingNumber, stopingCriteria, selectedMethode);
            setArrivalTime(ref simObj, ref indexFristRow, lines);
            //set server 
            setServer(ref simObj, ref indexFristRow, lines);

            return simObj;

        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lastIndex"></param>
        /// <param name="lines"></param>
        public static void setServer(ref SimulationSystem obj , ref int lastIndex , string[] lines)
        {
            for(int i = 0;i< obj.NumberOfServers; i++)
            {
                Server serverobj = new Server();
                serverobj.ID = i + 1;
                lastIndex++;
                serverobj.ServerPriorty = 1 + i;
                DataGridView DGV = new DataGridView();
                converToDGV(getDistrubutionValues(ref lastIndex, lastIndex, lines), ref DGV);
                //calc time dist 
                obj.Servers.Add(serverobj);



            }
        }


        /*setting a table of interArrivalDistribution 
         * making data Grid 
         * convert list of distribution to data Grid 
         * calculat the Range using calculations model send obj , DGV
         */
        public static void setArrivalTime(ref SimulationSystem obj, ref int indexFristRow, string[] lines)
        {
            DataGridView DGV = new DataGridView();
            converToDGV(getDistrubutionValues(ref indexFristRow, indexFristRow, lines), ref DGV);
            /*calculation model */ 

        }
        /*making a list to drow a gridview of timedistrubtions
         * make list 
         * itrate lines array untill end (file or table) 
         * add time to time var in distrubution
         * repeat 4 for probability 
         * return DV  list 
         */
        public static List<DistrubutionValues> getDistrubutionValues(ref int LastIndex, int StartIndex, string[] lines)
        {
            List<DistrubutionValues> DV = new List<DistrubutionValues>();
            while (lines[LastIndex] != "")
            {
                DistrubutionValues obj = new DistrubutionValues();
                DV.Add(obj);
                string[] index = Regex.Split(lines[LastIndex], ", ");
                DV[LastIndex - StartIndex].Time = int.Parse(index[0]);
                DV[LastIndex - StartIndex].Probability = decimal.Parse(index[1]);
                LastIndex++;
                if (LastIndex == lines.Count()) break; //reated the end of file 


            }
            return DV;
        }
        /*convert Dv to DGV 
         * 
         */
        public static void converToDGV(List<DistrubutionValues> DV, ref DataGridView obj)
        {
            obj.Columns.Add("", "");
            obj.Columns.Add("1", "1");
            for (int i = 0; i < DV.Count; i++)
            {
                obj.Rows.Add();
                obj.Rows[1].Cells[0].Value = DV[i].Time;
                obj.Rows[1].Cells[1].Value = DV[i].Probability;
            }
        }
    }
   
}
