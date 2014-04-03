using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class Process
    {
        int pid;
        PageTable table;
        ProcessControlBlock pcb;
        public Process(int pid)
        {
            this.pid = pid;
            table = new PageTable();
            pcb = new ProcessControlBlock();
        }

        public Process Copy()
        {
            Process p = new Process(this.pid);
            p.SetPCB(pcb.Copy());
            p.SetTable(table.Copy());
            return p;
            
        }

        public void SetTable(PageTable table)
        {
            this.table = table;
        }

        public void SetPCB(ProcessControlBlock pcb)
        {
            this.pcb = pcb;
        }

        public void AddSegment(Segment seg, List<int> logical, 
            List<int>physical)
        {
            pcb.AddSegment(seg, logical.Count);
            table.AddSegment(pcb.GetSegmentPointer(seg),logical, physical);
        }

        public int GetPID()
        {
            return pid;
        }

        public List<int> GetPhysicalAddresses()
        {
            return table.GetPhysicalAddresses();
        }

        public int GetLogicalAddress(int physicalAddress)
        {
            return table.GetLogicalMatch(physicalAddress);
        }

        public Segment GetSegmentType(int logicalAddress)
        {
            return pcb.GetSegmentType(logicalAddress);
        }
    }
}
