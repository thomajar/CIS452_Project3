using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class MemoryManager
    {
        private PhysicalMemory memory;

        public MemoryManager(int physicalMemory, int pageSize)
        {
            int pageCount = physicalMemory / pageSize;
            memory = new PhysicalMemory(pageCount, pageSize);
        }

        public Boolean AllocateMemory(int pid, List<Segment> segments, List<int> sizes)
        {
            if (segments.Count != sizes.Count)
            {
                throw new Exception("MemoryManager.AllocateMemory : segments.count did not match sizes.count.");
            }

            // determine how many pages we need
            int requestedPages = 0;
            for (int i = 0; i < segments.Count; i++)
            {
                Double temp = Convert.ToDouble(sizes[i]) / Convert.ToDouble(memory.PageSize);
                if (temp - (Double)Math.Floor(temp) > 0)
                {
                    requestedPages += Convert.ToInt32(Math.Floor(temp) + 1);
                }
                else
                {
                    requestedPages += Convert.ToInt32(Math.Floor(temp));
                }
            }

            if (memory.GetFreeMemorySize() < requestedPages * memory.PageSize)
            {
                throw new Exception("MemoryManager.AllocateMemory : Not enough memory available in physical memory.");
            }

            // enough space, get indices and begin to fill in
            int[] freeIndices = memory.GetFreeIndices();
            int insertIndex = 0;
            for (int i = 0; i < segments.Count; i++)
            {
                Double temp = (Double)sizes[i] / (Double)memory.PageSize;
                int pageRequest = 0;
                if (temp - (Double)Math.Floor(temp) > 0)
                {
                    pageRequest = Convert.ToInt32(Math.Floor(temp) + 1);
                }
                else
                {
                    pageRequest = Convert.ToInt32(Math.Floor(temp));
                }
                for (int j = 0; j < pageRequest; j++)
                {
                    memory.AddPageAtIndex(freeIndices[insertIndex], pid, segments[i], j);
                    insertIndex++;
                }
            }

            return true;
            
        }

        public Boolean FreeMemory(int pid)
        {
            return memory.RemoveProcessPages(pid);
        }




    }
}
