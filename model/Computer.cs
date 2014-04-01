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
            try
            {
                memory.AllocateMemory(ref p, segs, sizes);
            }
            catch (Exception)
            {
                pid = -1;
            }
            // if pid is 0 or greater, no error occured allocating memory
            if (pid > -1)
            {
                nextPID++;
                processes.Add(p);
            }
            return pid;
        }

        public Boolean TerminateProcess(int pid)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].GetPID() == pid)
                {
                    List<int> memoryToFree = processes[i].GetPhysicalAddresses();
                    memory.FreeMemory(memoryToFree);
                    processes.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }


        
    }
}
