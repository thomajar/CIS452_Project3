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

        public Boolean AllocateMemory(ref Process p, List<Segment> segments, List<int> sizes)
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
                List<int> logicalIndicies = new List<int>();
                List<int> physicalIndicies = new List<int>();

                for (int j = 0; j < pageRequest; j++)
                {
                    if (memory.RequestMemory(freeIndices[insertIndex]))
                    {
                        logicalIndicies.Add(j);
                        physicalIndicies.Add(freeIndices[insertIndex]);
                        insertIndex++;
                    }
                    else
                    {
                        // some sort of error between memory manager and physical memory sync
                    }
                }
                p.AddSegment(segments[i], logicalIndicies, physicalIndicies);
            }

            return true;
            
        }

        public void FreeMemory(List<int> physicalAddresses)
        {
            for (int i = 0; i < physicalAddresses.Count; i++)
            {
                memory.ReleaseMemory(physicalAddresses[i]);
            }
        }




    }
}
