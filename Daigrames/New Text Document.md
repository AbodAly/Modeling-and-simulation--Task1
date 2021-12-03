# modeling simulation 

''' mermaid
    CLASSDIAGRAM
    subgraph MultiQueueSimulation{
        class TableValues{
            + int time 
            + decimal probabiltiy 
        }
        class readFromFile{
            +readData(String filepath):simObj
            +void fillServerTable(ref simlationSystem obj , ref int lastindex, string[] lines  )
            +List<tableValues> calcSysTable(ref int lastIndex , int startIndex , string[] lines) : DV 
            +void convertToDGV(List<TableValues>DV , ref Datagridview obj)
            

            
        }
        class CalulationModel{
            +Randome randome
            +void calcTimeDist(ref SimulationSystem obj, DataGridView DGV)
            +void calcServersTable(ref Server obj, DataGridView DGV)
            +getRaondomeNumber():int
            +timeBetweenArrival(int RandomNumber, SimulationSystem simobj):int
            +getServerTime(int RandomNumber, Server serObj):int
            +void calcaTable(ref SimulationSystem simSysObj)
            +void UpdateDataInServer(ref SimulationSystem +simulationSystemobj, int ServerId, int ServiceTime, int EndTime)
            +GetTimeInQueue(Server serObj, int ArrivalTime):int
            +getServer(SimulationSystem simSysObj, int arrivalTime):Server
            +void PerformanceSysMeasure(ref SimulationSystem obj)
            +void MaxQueue(ref SimulationSystem obj)
            +TotalQeueuTime(SimulationSystem obj):int
            +void performanceForEachServer(ref SimulationSystem obj)
            +chartofserver(ref SimulationSystem obj):Dictionary<int, List<int>>
        }

        
    }
    end
'''