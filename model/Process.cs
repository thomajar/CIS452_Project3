using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class Process
    {
        /// <summary>
        /// pid of Process.
        /// </summary>
        private int pid;
        /// <summary>
        /// Page Table for the process.
        /// </summary>
        private PageTable table;
        /// <summary>
        /// PCB for process.
        /// </summary>
        private ProcessControlBlock pcb;
        
        /// <summary>
        /// Creates a new process. Process pid is set to pid.  
        /// </summary>
        /// <param name="pid">Pid of process.</param>
        public Process(int pid)
        {
            this.pid = pid;
            table = new PageTable();
            pcb = new ProcessControlBlock();
        }

        /// <summary>
        /// Create a deep copy of process object.
        /// </summary>
        /// <returns>Deep copy of process object.</returns>
        public Process Copy()
        {
            Process p = new Process(this.pid);
            p.SetPCB(pcb.Copy());
            p.SetTable(table.Copy());
            return p;
            
        }

        /// <summary>
        /// Sets teh page table for process.
        /// </summary>
        /// <param name="table">PageTable to set processes' page table to.
        /// </param>
        public void SetTable(PageTable table)
        {
            this.table = table;
        }

        /// <summary>
        /// Sets PCB for process.
        /// </summary>
        /// <param name="pcb">PCB for process.</param>
        public void SetPCB(ProcessControlBlock pcb)
        {
            this.pcb = pcb;
        }

        /// <summary>
        /// Adds a segment to process, this stores pointer in the pcb
        /// and page table.
        /// </summary>
        /// <param name="seg">Tyep of segment.</param>
        /// <param name="logical">List of logical addresses.</param>
        /// <param name="physical">List of matching physical addresses.
        /// </param>
        public void AddSegment(Segment seg, List<int> logical, 
            List<int>physical)
        {
            pcb.AddSegment(seg, logical.Count);
            table.AddSegment(pcb.GetSegmentPointer(seg),logical, physical);
        }

        /// <summary>
        /// Gets the pid of process.
        /// </summary>
        /// <returns>Pid of process.</returns>
        public int GetPID()
        {
            return pid;
        }

        /// <summary>
        /// Gets a list of physical addresses in page table.
        /// </summary>
        /// <returns>List of physical addresses.</returns>
        public List<int> GetPhysicalAddresses()
        {
            return table.GetPhysicalAddresses();
        }

        /// <summary>
        /// Finds the logical address matching physical address.
        /// </summary>
        /// <param name="physicalAddress">Physical address to match.</param>
        /// <returns>Logical address index matching physical address.
        /// </returns>
        public int GetLogicalAddress(int physicalAddress)
        {
            return table.GetLogicalMatch(physicalAddress);
        }

        /// <summary>
        /// Determines the segment type for a logical address.
        /// </summary>
        /// <param name="logicalAddress">Logical address to retrieve segment
        /// type for.</param>
        /// <returns>Type of segment.</returns>
        public Segment GetSegmentType(int logicalAddress)
        {
            return pcb.GetSegmentType(logicalAddress);
        }
    }
}
