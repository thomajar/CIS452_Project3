using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class Computer
    {
        /// <summary>
        /// List of all processes currently in use.
        /// </summary>
        private List<Process> processes;
        /// <summary>
        /// Managere of memory.
        /// </summary>
        private MemoryManager memory;
        /// <summary>
        /// PID to give next process spawned.
        /// </summary>
        private int nextPID;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Computer()
        {

        }

        /// <summary>
        /// Initializes computer memory and list of processes.
        /// </summary>
        /// <param name="physicalMemory">Amount of memory to give computer.
        /// </param>
        /// <param name="pageSize">Amount of memory on each page.</param>
        public Computer(int physicalMemory, int pageSize)
        {
            processes = new List<Process>();
            memory = new MemoryManager(physicalMemory, pageSize);
            nextPID = 0;
        }

        /// <summary>
        /// Retrieves a deep copy of object.
        /// </summary>
        /// <returns>Copy of computer.</returns>
        public Computer Copy()
        {
            Computer cpu = new Computer();
            List<Process> procs = new List<Process>();
            foreach (Process item in processes)
            {
                procs.Add(item.Copy());
            }
            cpu.SetComputer(procs, memory.Copy(),this.nextPID);
            return cpu;
            
        }

        /// <summary>
        /// Sets the process list and memory of computer.
        /// </summary>
        /// <param name="ps">List of processes.</param>
        /// <param name="mem">Memory manager.</param>
        /// <param name="pid">Next pid.</param>
        public void SetComputer(List<Process> ps, MemoryManager mem, int pid)
        {
            this.processes = ps;
            this.memory = mem;
            this.nextPID = pid;
        }

        /// <summary>
        /// Spawns a new process with the next available pid.
        /// </summary>
        /// <param name="segs">List of segments to allocate memory for.
        /// </param>
        /// <param name="sizes">Size of segments to allocate memory for.
        /// </param>
        /// <returns>Pid of new process or -1 on failure.</returns>
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

        /// <summary>
        /// Terminates process pid.
        /// </summary>
        /// <param name="pid">Pid of process to terminate.</param>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean TerminateProcess(int pid)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].GetPID() == pid)
                {
                    List<int> memoryToFree = 
                        processes[i].GetPhysicalAddresses();
                    memory.FreeMemory(memoryToFree);
                    processes.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the total size of memory on cpu.
        /// </summary>
        /// <returns>Total size of memory.</returns>
        public int GetMemorySize()
        {
            return memory.GetMemorySize();
        }

        /// <summary>
        /// Gets the total page count on cpu.
        /// </summary>
        /// <returns>Total page count.</returns>
        public int GetPageCount()
        {
            return memory.GetPageCount();
        }

        /// <summary>
        /// Gets the size of each page.
        /// </summary>
        /// <returns>Size of each page.</returns>
        public int GetPageSize()
        {
            return memory.GetPageSize();
        }

        /// <summary>
        /// Gets how many pages are currently in use.
        /// </summary>
        /// <returns>Number of pages used.</returns>
        public int GetPagesUsed()
        {
            return memory.GetPagesUsed();
        }

        /// <summary>
        /// Gets the next pid in process list.
        /// </summary>
        /// <param name="pid">Lookup pid.</param>
        /// <returns>Pid of next pid in process list.</returns>
        public int GetNextPID(int pid)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].GetPID() == pid)
                {
                    if (i == processes.Count - 1 && processes.Count > 0)
                    {
                        return processes[0].GetPID();
                    }
                    else
                    {
                        return processes[i + 1].GetPID();
                    }
                }
            }
            if (processes.Count != 0)
            {
                return processes[0].GetPID();
            }
            return -1;
        }

        /// <summary>
        /// Gets the previous pid in process list.
        /// </summary>
        /// <param name="pid">Pid to lookup.</param>
        /// <returns>Previous pid in process list.</returns>
        public int GetPreviousPID(int pid)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].GetPID() == pid)
                {
                    if (i == 0 && processes.Count > 0)
                    {
                        return processes[processes.Count - 1].GetPID();
                    }
                    else
                    {
                        return processes[i - 1].GetPID();
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Gets a row of physical memory for display.
        /// </summary>
        /// <param name="index">Physical memory to find.</param>
        /// <returns></returns>
        public PhysicalMemoryRowView GetPhysicalMemoryRow(int index)
        {
            PhysicalMemoryRowView row = new PhysicalMemoryRowView();
            for (int i = 0; i < processes.Count; i++)
            {
                int logicalIndex = processes[i].GetLogicalAddress(index);
                if (logicalIndex > -1)
                {
                    // match, need to find what segment it is in
                    row.FrameNumber = index;
                    row.PID = processes[i].GetPID();
                    row.Seg = processes[i].GetSegmentType(logicalIndex);
                    row.PageNumber = 4;
                    return row;
                }
            }
            return row;
        }

        /// <summary>
        /// Gets page table variables for selected process.
        /// </summary>
        /// <param name="process"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public List<PageTableRowView> GetProcessPageTable(int process,
            int startIndex)
        {
            List<PageTableRowView> pageTableView = 
                new List<PageTableRowView>();
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].GetPID() == process)
                {
                    // found a match, get page table data
                    List<int> addresses = processes[i].GetPhysicalAddresses();
                    for (int j = startIndex; j < addresses.Count; j++)
                    {
                        PageTableRowView rowView = new PageTableRowView();
                        rowView.Physical = addresses[j];
                        rowView.Logical = 
                            processes[i].GetLogicalAddress(addresses[j]);
                        rowView.Seg = 
                            processes[i].GetSegmentType(rowView.Logical);
                        pageTableView.Add(rowView);
                    }
                    return pageTableView;
                }
            }
            return pageTableView;
        }

        /// <summary>
        /// Gets the process page count for desired process.
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public int GetProcessPageCount(int process)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].GetPID() == process)
                {
                    return processes[i].GetPhysicalAddresses().Count;
                }
            }
            return -1;
        }
    }
}
