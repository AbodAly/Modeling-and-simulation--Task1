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
        public static void calcTimeDist(ref SimulationSystem obj, DataGridView DGV)
        {
            decimal cummulative = 0;
            int range = 0;
            for (int i = 0; i < DGV.RowCount - 1; i++)
            {
                /*
                 * |    0     |    1   |
                 * |----------|--------|
                 * |    time  |  dist  |
                 * |----------|--------|
                 */
                TimeDistribution TDobj = new TimeDistribution();
                obj.InterarrivalDistribution.Add(TDobj);

                int time = int.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                decimal prob = decimal.Parse(DGV.Rows[i].Cells[1].Value.ToString());

                // add instance of timeDistruibution into list of interarrivalDistributin
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
        public static void calcServersTable(ref Server obj, DataGridView DGV)
        {
            decimal cummulative = 0;
            int range = 0;
            /*
                * |    0     |    1   |
                * |----------|--------|
                * |    time  |  dist  |
                * |----------|--------|
                */
            for (int i = 0; i < DGV.RowCount - 1; i++)
            {

                TimeDistribution TDobj = new TimeDistribution();
                obj.TimeDistribution.Add(TDobj);
                int time = int.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                decimal prob = Decimal.Parse(DGV.Rows[i].Cells[1].Value.ToString());
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
            return random.Next(1, 100);
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
        public static int getServerTime(int RandomNumber, Server serObj)
        {
            for (int i = 0; i < serObj.TimeDistribution.Count; i++)
            {
                if (RandomNumber <= serObj.TimeDistribution[i].MaxRange)
                    return serObj.TimeDistribution[i].Time;

            }
            return 0;
        }

        public static void calcaTable(ref SimulationSystem simSysObj)
        {
            if (simSysObj.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
            {
                for (int i = 0; i < simSysObj.StoppingNumber; i++)
                {
                    SimulationCase simulationCaseobj = new SimulationCase();
                    simSysObj.SimulationTable.Add(simulationCaseobj);

                    if (i == 0)
                    {
                        simSysObj.SimulationTable[i].RandomInterArrival = getRaondomeNumber();//
                        simSysObj.SimulationTable[i].InterArrival = timeBetweenArrival(simSysObj.SimulationTable[i].RandomInterArrival, simSysObj);//
                        simSysObj.SimulationTable[i].ArrivalTime = 0;////
                        simSysObj.SimulationTable[i].RandomService = getRaondomeNumber();
                        simSysObj.SimulationTable[i].AssignedServer = getServer(simSysObj, simSysObj.SimulationTable[i].ArrivalTime);
                        simSysObj.SimulationTable[i].CustomerNumber = i + 1;
                        simSysObj.SimulationTable[i].TimeInQueue = 0;////
                        simSysObj.SimulationTable[i].ServiceTime = getServerTime(simSysObj.SimulationTable[i].RandomService, simSysObj.SimulationTable[i].AssignedServer);
                        simSysObj.SimulationTable[i].StartTime = 0;///
                        simSysObj.SimulationTable[i].EndTime = simSysObj.SimulationTable[i].ServiceTime;
                    }

                    else
                    {
                        simSysObj.SimulationTable[i].CustomerNumber = i + 1;
                        simSysObj.SimulationTable[i].RandomInterArrival = getRaondomeNumber();
                        simSysObj.SimulationTable[i].InterArrival = timeBetweenArrival(simSysObj.SimulationTable[i].RandomInterArrival, simSysObj);
                        simSysObj.SimulationTable[i].ArrivalTime = simSysObj.SimulationTable[i - 1].ArrivalTime + simSysObj.SimulationTable[i].InterArrival;//
                        simSysObj.SimulationTable[i].RandomService = getRaondomeNumber();
                        simSysObj.SimulationTable[i].AssignedServer = getServer(simSysObj, simSysObj.SimulationTable[i].ArrivalTime);
                        simSysObj.SimulationTable[i].ServiceTime = getServerTime(simSysObj.SimulationTable[i].RandomService, simSysObj.SimulationTable[i].AssignedServer);
                        simSysObj.SimulationTable[i].TimeInQueue = GetTimeInQueue(simSysObj.SimulationTable[i].AssignedServer, simSysObj.SimulationTable[i].ArrivalTime);
                        simSysObj.SimulationTable[i].StartTime = simSysObj.SimulationTable[i].ArrivalTime + simSysObj.SimulationTable[i].TimeInQueue;
                        simSysObj.SimulationTable[i].EndTime = simSysObj.SimulationTable[i].ServiceTime + simSysObj.SimulationTable[i].StartTime;
                    }



                    UpdateDataInServer(ref simSysObj, simSysObj.SimulationTable[i].AssignedServer.ID, simSysObj.SimulationTable[i].ServiceTime, simSysObj.SimulationTable[i].EndTime);


                }    // outer for 
            }



            if (simSysObj.StoppingCriteria == Enums.StoppingCriteria.SimulationEndTime)
            {
                int i = 0;
                SimulationCase simulationCaseobj = new SimulationCase();
                simSysObj.SimulationTable.Add(simulationCaseobj);

                simSysObj.SimulationTable[0].RandomInterArrival = 1;
                simSysObj.SimulationTable[0].InterArrival = 1;
                simSysObj.SimulationTable[0].ArrivalTime = 0;
                simSysObj.SimulationTable[0].RandomService = getRaondomeNumber();
                simSysObj.SimulationTable[i].AssignedServer = getServer(simSysObj, 0);
                simSysObj.SimulationTable[0].CustomerNumber = 0 + 1;
                simSysObj.SimulationTable[0].TimeInQueue = 0;
                simSysObj.SimulationTable[0].ServiceTime = getServerTime(simSysObj.SimulationTable[0].RandomService, simSysObj.SimulationTable[i].AssignedServer);
                simSysObj.SimulationTable[0].StartTime = 0;
                simSysObj.SimulationTable[0].EndTime = simSysObj.SimulationTable[0].ServiceTime;

                UpdateDataInServer(ref simSysObj, simSysObj.SimulationTable[0].AssignedServer.ID, simSysObj.SimulationTable[0].ServiceTime, simSysObj.SimulationTable[0].EndTime);


                while (simSysObj.StoppingNumber >= simSysObj.SimulationTable[i].ArrivalTime)
                {
                    i++;
                    simulationCaseobj = new SimulationCase();
                    simSysObj.SimulationTable.Add(simulationCaseobj);

                    simSysObj.SimulationTable[i].CustomerNumber = i + 1;
                    simSysObj.SimulationTable[i].RandomInterArrival = getRaondomeNumber();
                    simSysObj.SimulationTable[i].InterArrival = timeBetweenArrival(simSysObj.SimulationTable[i].RandomInterArrival, simSysObj);
                    simSysObj.SimulationTable[i].ArrivalTime = simSysObj.SimulationTable[i - 1].ArrivalTime + simSysObj.SimulationTable[i].InterArrival;
                    simSysObj.SimulationTable[i].RandomService = getRaondomeNumber();
                    simSysObj.SimulationTable[i].AssignedServer = getServer(simSysObj, simSysObj.SimulationTable[i].ArrivalTime);
                    simSysObj.SimulationTable[i].ServiceTime = getServerTime(simSysObj.SimulationTable[i].RandomService, simSysObj.SimulationTable[i].AssignedServer);
                    simSysObj.SimulationTable[i].TimeInQueue = GetTimeInQueue(simSysObj.SimulationTable[i].AssignedServer, simSysObj.SimulationTable[i].ArrivalTime);
                    simSysObj.SimulationTable[i].StartTime = simSysObj.SimulationTable[i].ArrivalTime + simSysObj.SimulationTable[i].TimeInQueue;
                    simSysObj.SimulationTable[i].EndTime = simSysObj.SimulationTable[i].ServiceTime + simSysObj.SimulationTable[i].StartTime;



                    if (simSysObj.SimulationTable[i].ArrivalTime > simSysObj.StoppingNumber)
                    {
                        simSysObj.SimulationTable.RemoveAt(i);
                        break;
                    }

                    UpdateDataInServer(ref simSysObj, simSysObj.SimulationTable[i].AssignedServer.ID, simSysObj.SimulationTable[i].ServiceTime, simSysObj.SimulationTable[i].EndTime);

                }

            }
        }


        public static void UpdateDataInServer(ref SimulationSystem simulationSystemobj, int ServerId, int ServiceTime, int EndTime)
        {
            for (int i = 0; i < simulationSystemobj.Servers.Count; i++)
            {
                if (simulationSystemobj.Servers[i].ID == ServerId)
                {
                    simulationSystemobj.Servers[i].FinishTime = EndTime;
                    simulationSystemobj.Servers[i].TotalWorkingTime += ServiceTime; // bouns
                    simulationSystemobj.Servers[i].NumOfCustomers++;
                }
            }
        }
        public static int GetTimeInQueue(Server serObj, int ArrivalTime)
        {
            if (serObj.FinishTime > ArrivalTime)
                return serObj.FinishTime - ArrivalTime;
                return 0; // no wait
        }

        public static Server getServer(SimulationSystem simSysObj, int arrivalTime)
        {
            List<Server> serList = new List<Server>(); // List Of Classes
          
                serList.Add(simSysObj.Servers[0]);
            
            for (int i = 1; i < simSysObj.NumberOfServers; i++)
            {
                                              // 1                           0
                    if (simSysObj.Servers[i].FinishTime == serList[0].FinishTime)
                    {
                        serList.Add(simSysObj.Servers[i]); // add server same finish time
                    }
                    //  7      
                    if (simSysObj.Servers[i].FinishTime < serList[0].FinishTime)   ///   '4'             4
                    {
                        //  4  4  4
                        //  4
                        if (serList[0].FinishTime <= arrivalTime)
                        {
                            serList.Add(simSysObj.Servers[i]);
                        }
                        else  // if > End Time
                        {
                            serList.Clear();
                            serList.Add(simSysObj.Servers[i]);
                        }
                    }
            }

            // 4
            if (serList.Count == 1)
            {
                return serList[0];
            }
            else
            {
                return GetServerHelper(simSysObj, serList);
            }


        }

        public static Server GetServerHelper(SimulationSystem simSysObj, List<Server> SersObj)
        {
            Server serobj = new Server();

            if (simSysObj.SelectionMethod == Enums.SelectionMethod.HighestPriority)
            {
                serobj = SersObj[0];
            }
            else if (simSysObj.SelectionMethod == Enums.SelectionMethod.LeastUtilization)
            {
                serobj = SersObj[0];

                for (int i = 0; i < SersObj.Count; i++)
                {
                    if (serobj.TotalWorkingTime > SersObj[i].TotalWorkingTime)
                    {
                        serobj = SersObj[i];
                    }
                }
            }
            else
            {
                //  4   4   4  >> 0   2  // ret number less than ServersObject.Count 
                serobj = SersObj[random.Next(SersObj.Count)];
            }

            return serobj;

        }

        public static void PerformanceSysMeasure(ref SimulationSystem obj)
        {
            decimal totalTimeInQ = 0;
            decimal num_customersWaiting = 0;

            int Customers_num = obj.SimulationTable.Count;

            for (int i = 0; i < Customers_num; i++)
            {
                if (obj.SimulationTable[i].TimeInQueue != 0)
                {
                    num_customersWaiting++;
                }
                totalTimeInQ += obj.SimulationTable[i].TimeInQueue;

            }
            if (Customers_num != 0)
            {
                obj.PerformanceMeasures.AverageWaitingTime = totalTimeInQ / Customers_num;
                obj.PerformanceMeasures.WaitingProbability = num_customersWaiting / Customers_num;
            }

            else
            {
                obj.PerformanceMeasures.AverageWaitingTime = 0;
                obj.PerformanceMeasures.WaitingProbability = 0;
            }

            MaxQueue(ref obj);
        }
        public static void MaxQueue(ref SimulationSystem obj)
        {
            List<int> arrivalTime = new List<int>();  //   3    4       5       6

            List<int> startTime = new List<int>();   //    4    7       7       7
                                                     //0    1    1       2       3     3                         8
            int len = 0;
            for (int i = 0; i < obj.SimulationTable.Count; i++)
            {
                if (obj.SimulationTable[i].TimeInQueue != 0)
                {
                    arrivalTime.Add(obj.SimulationTable[i].ArrivalTime);
                    startTime.Add(obj.SimulationTable[i].StartTime);

                }
            }

            for (int i = 0; i < arrivalTime.Count; i++)
            {
                int n = 0;
                for (int j = i; j < arrivalTime.Count; j++)
                {
                    if (startTime[i] > arrivalTime[j])
                    {
                        n++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (n >= len)
                {
                    len = n; // 0  3   7  
                }
            }
            obj.PerformanceMeasures.MaxQueueLength = len;


        }

        public static int TotalQeueuTime(SimulationSystem obj)
        {
            int totalNumberCostumer = obj.SimulationTable.Count;
            int totalInQueue = 0;
            for (int i = 0; i < totalNumberCostumer; i++)
            {
                totalInQueue += obj.SimulationTable[i].TimeInQueue;

            }
            return totalInQueue;
        }

        public static void performanceForEachServer(ref SimulationSystem obj)
        {

            for (int i = 0; i < obj.Servers.Count; i++)
            {

                if (obj.Servers[i].NumOfCustomers != 0)
                {
                    obj.Servers[i].AverageServiceTime = obj.Servers[i].TotalWorkingTime;
                    obj.Servers[i].AverageServiceTime /= obj.Servers[i].NumOfCustomers;    // 2 customers per hour
                }
                else
                
                obj.Servers[i].AverageServiceTime = 0;
                int max = -1;
                for (int j = 0; j < obj.SimulationTable.Count; j++)
                {
                    if (obj.SimulationTable[j].EndTime > max)
                        max = obj.SimulationTable[j].EndTime;
                }

                decimal idle = max - obj.Servers[i].TotalWorkingTime; // out  20-1 =19   19/20

                if (max != 0)
                {

                    obj.Servers[i].IdleProbability = idle;  /// 19/20
                    obj.Servers[i].IdleProbability /= max;

                    obj.Servers[i].Utilization = obj.Servers[i].TotalWorkingTime;  // 1/20
                    obj.Servers[i].Utilization /= max;
                }
                else
                {
                    obj.Servers[i].Utilization = 0;
                    obj.Servers[i].IdleProbability = 0;
                }
            }
        }

        public static Dictionary<int, List<int>> chartofserver(ref SimulationSystem obj)
        {             // 1   [2,3,4]
                      // 2   [4,5,6]  
                      // key value
            Dictionary<int, List<int>> graphofServer = new Dictionary<int, List<int>>();

            for (int i = 0; i < obj.NumberOfServers; i++)
            {
                graphofServer.Add(obj.Servers[i].ID, new List<int>());  // 0  empty list  ,  1  empty list
            }
            // 0,  2  5  6  7
            // 1,  1 2  8  9  10   12 13

            for (int i = 0; i < obj.SimulationTable.Count; i++)
            {
                int x = obj.SimulationTable[i].StartTime;  //  1

                while (x < obj.SimulationTable[i].EndTime)   //  2 <  3
                {
                    graphofServer[obj.SimulationTable[i].AssignedServer.ID].Add(x);
                    x++;
                }


            }
            return graphofServer;

        }

       

    }
}
