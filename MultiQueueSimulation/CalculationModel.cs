using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels; 


namespace MultiQueueSimulation
{
    class CalculationModel
    {
        public static Random random = new Random();
        /// <summary>
        /// for every row in datagrid 
        ///     calculate cumm and min & max (range) 
        ///     
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="DGV"></param>
        public static void calculateTimeDistribution(ref SimulationSystem obj, DataGridView DGV)
        {
            decimal cummulative = 0;
            int range = 0; 
            for(int i = 0; i < DGV.RowCount- 1; i++)
            {
                /*
                 * |    0     |    1   |
                 * |----------|--------|
                 * |    time  |  dist  |
                 * |----------|--------|
                 */
                int time = int.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                decimal prob = decimal.Parse(DGV.Rows[i].Cells[1].Value.ToString());

                TimeDistribution TDobj = new TimeDistribution();
                // add instance of timeDistruibution into list of interarrivalDistributin
                obj.InterarrivalDistribution.Add(TDobj);
                obj.InterarrivalDistribution[i].Time = time;
                obj.InterarrivalDistribution[i].Probability = prob;
                cummulative += obj.InterarrivalDistribution[i].Probability;
                obj.InterarrivalDistribution[i].CummProbability = cummulative;
                // should we satrat with -1 ? 
                obj.InterarrivalDistribution[i].MinRange = range + 1;
                obj.InterarrivalDistribution[i].MaxRange = Convert.ToInt32(cummulative * 100);
                range = obj.InterarrivalDistribution[i].MaxRange;


            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="DGV"></param>
        public static void calculateTimeDistributionForServers(ref Server obj , DataGridView DGV)
        {
            decimal cummulative = 0;
            int range = 0;
            /*
                * |    0     |    1   |
                * |----------|--------|
                * |    time  |  dist  |
                * |----------|--------|
                */
            for (int i = 0; i < DGV.RowCount-1; i++)
            {
                int time = int.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                decimal prob = decimal.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                TimeDistribution TDobj = new TimeDistribution();
                obj.TimeDistribution.Add(TDobj);
                obj.TimeDistribution[i].Time = time;
                obj.TimeDistribution[i].Probability = prob;
                cummulative += obj.TimeDistribution[i].Probability;
                obj.TimeDistribution[i].CummProbability = cummulative;
                obj.TimeDistribution[i].MinRange = range + 1;
                obj.TimeDistribution[i].MaxRange = Convert.ToInt32(cummulative * 100);
                range = obj.TimeDistribution[i].MaxRange;

            }
        }
        /// <summary>
        /// get the next randome number in range  (1,100) 
        /// </summary>
        /// <returns></returns>
        
        public static int getRaondomeNumber()
        {
            int randomenumber = random.Next(1, 100);
            return randomenumber;
        }
        /// <summary>
        ///  get the arrival time by looking the Randome value fit in the Range ;
        /// </summary>
        /// <param name="RandomNumber"></param>
        /// <param name="simobj"></param>
        /// <returns></returns>
        public static int timeBetweenArrival(int RandomNumber, SimulationSystem simobj)
        {
            /*
              * |    0     |    1   |Range |
              * |----------|--------|------|
              * |    time  |  dist  |      |
              * |----------|--------|      |
              * search throght the ranges to see for the randome number in the range; 
              * if not return 0 ; 
              * 
              */
            for (int i = 0; i < simobj.InterarrivalDistribution.Count; i++)
            {
                if (RandomNumber <= simobj.InterarrivalDistribution[i].MaxRange)
                {
                    return simobj.InterarrivalDistribution[i].Time;
                }
            }
            return 0; 
        }
        public static int getServerTime(int RandomNumber , Server serverobj)
        {
            for (int i = 0; i < serverobj.TimeDistribution.Count; i++)
            {
                if (RandomNumber <= serverobj.TimeDistribution[i].MaxRange)
                    return serverobj.TimeDistribution[i].MaxRange;

            }
            return 0;
        }





    }
}
