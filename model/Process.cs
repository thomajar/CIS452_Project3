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

        public void AddSegment(Segment seg, List<int> logical, List<int>physical)
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

        /*public List<int> GetSegmentAddresses()
        {

        }*/
    }
}
