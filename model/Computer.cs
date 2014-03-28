using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class Computer
    {
        private List<ProcessControlBlock> processes;
        private List<PageTable> pageTables;
        private MemoryManager memory;

        private int nextPID;

        public Computer(int physicalMemory, int pageSize)
        {
            processes = new List<ProcessControlBlock>();
            pageTables = new List<PageTable>();
            memory = new MemoryManager(physicalMemory, pageSize);
            nextPID = 0;
        }

        public int SpawnProcess(List<Segment> segs, List<int> sizes)
        {
            int pid = nextPID;

            // attempt to allocate memory
            if (memory.AllocateMemory(pid, segs, sizes))
            {
                nextPID++;
                ProcessControlBlock pcb = new ProcessControlBlock();
                PageTable pt = new PageTable();

                processes.Add(pcb);
                pageTables.Add(pt);
            }
            else
            {
                pid = -1;
            }
            return pid;
        }


        
    }
}
