﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
            ///
            FinishTime = 0;
            TotalWorkingTime = 0; 
        }

        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int NumOfCustomers = 0; 
        public  int ServerPriorty { get; set; }



        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }
    }
}
