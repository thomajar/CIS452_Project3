using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class PageTable
    {
        private List<int> logicalPointer;
        private List<int> physicalPointer;

        public PageTable()
        {
            logicalPointer = new List<int>();
            physicalPointer = new List<int>();
        }

        public PageTable Copy()
        {
            PageTable pageTable = new PageTable();
            pageTable.SetTable(this.logicalPointer, this.physicalPointer);
            return pageTable;
        }

        public void SetTable(List<int> logical, List<int> physical)
        {
            this.logicalPointer.Clear();
            this.physicalPointer.Clear();
            foreach (int item in logical)
            {
                this.logicalPointer.Add(item);
            }
            foreach (int item in physical)
            {
                this.physicalPointer.Add(item);
            }
        }

        public Boolean AddSegment(int startIndex, List<int> logical, 
            List<int> physical)
        {
            if (logical.Count != physical.Count)
            {
                return false;
            }
            for (int i = 0; i < logical.Count; i++)
            {
                logicalPointer.Add(logical[i]+startIndex);
                physicalPointer.Add(physical[i]);
            }
            return true;
        }

        public List<int> GetPhysicalAddresses()
        {
            return physicalPointer;
        }

        public int GetLogicalMatch(int physical)
        {
            int index = physicalPointer.IndexOf(physical);
            if (index > -1)
            {
                return logicalPointer[index];
            }
            return -1;
        }

    }
}
