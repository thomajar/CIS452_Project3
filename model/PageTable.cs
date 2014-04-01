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

        public Boolean AddSegment(int startIndex, List<int> logical, List<int> physical)
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
    }
}
