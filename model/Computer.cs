using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class Computer
    {
        private List<Process> processes;
        private MemoryManager memory;

        private int nextPID;

        public Computer(int physicalMemory, int pageSize)
        {
            processes = new List<Process>();
            memory = new MemoryManager(physicalMemory, pageSize);
            nextPID = 0;
        }

        public int SpawnProcess(List<Segment> segs, List<int> sizes)
        {
            int pid = nextPID;
            Process p = new Process(nextPID);

            memory.AllocateMemory(ref p, segs, sizes);

            processes.Add(p);
           
            return pid;
        }

        public void TerminateProcess(int pid)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].GetPID() == pid)
                {
                    //memory.FreeMemory
                }
            }
        }


        
    }
}
