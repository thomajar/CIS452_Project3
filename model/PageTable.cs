using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class PageTable
    {
        private List<Segment> segments;
        private List<int> logicalPointer;
        private List<int> physicalPointer;

        public PageTable()
        {

        }

        public void SetPageTable(List<Segment> segs, List<int> logicalPointer, List<int> physicalPointer)
        {
            this.segments = segs;
            this.logicalPointer = logicalPointer;
            this.physicalPointer = physicalPointer;
        }
    }
}
