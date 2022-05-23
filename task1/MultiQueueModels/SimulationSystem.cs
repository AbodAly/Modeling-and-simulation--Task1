using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public string FileName = null;

        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }
        public int AssignedServer { get; set; }
        
        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }


        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        public void inputData(int NumberOfSer, int StopNumber , int Stop, int SelectMethode)
        {
            StoppingNumber = StopNumber;
            NumberOfServers = NumberOfSer;
            if (Stop == 0)
                StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else
                StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
            switch (SelectMethode)
            {
                case 0: SelectionMethod = Enums.SelectionMethod.HighestPriority;
                    break;
                case 1: SelectionMethod = Enums.SelectionMethod.Random;
                    break;
                case 2: SelectionMethod = Enums.SelectionMethod.LeastUtilization;
                    break;
                default:
                    Console.WriteLine("peroblem in inputData methode ");
                    break;

            }

        }

    }
}
