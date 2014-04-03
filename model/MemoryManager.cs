using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class MemoryManager
    {
        /// <summary>
        /// Actual memory used by memory manager.
        /// </summary>
        private PhysicalMemory memory;

        // private Disk disk ~ Not yet implemented

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public MemoryManager()
        {

        }

        /// <summary>
        /// Initializes memory manager to have physical memory and
        /// the corresponding size of each page.
        /// </summary>
        /// <param name="physicalMemory">Size of physical memory.</param>
        /// <param name="pageSize">Size of page.</param>
        public MemoryManager(int physicalMemory, int pageSize)
        {
            int pageCount = physicalMemory / pageSize;
            memory = new PhysicalMemory(pageCount, pageSize);
        }

        /// <summary>
        /// Retrievs deep copy of MemoryManager.
        /// </summary>
        /// <returns>Deep copy of MemoryManager.</returns>
        public MemoryManager Copy()
        {
            MemoryManager mm = new MemoryManager();
            mm.SetMemory(memory.Copy());
            return mm;
        }

        /// <summary>
        /// Sets the physical portion of memory.
        /// </summary>
        /// <param name="mem">Memory to set to.</param>
        public void SetMemory(PhysicalMemory mem)
        {
            this.memory = mem;
        }

        /// <summary>
        /// Function attempts to allocate memory for process p consisting
        /// of a list of segments and corresponding sizes.
        /// </summary>
        /// <param name="p">Process to add memory to.</param>
        /// <param name="segments">List of segments to add.</param>
        /// <param name="sizes">List of segment sizes.</param>
        /// <returns></returns>
        public Boolean AllocateMemory(ref Process p, List<Segment> segments,
            List<int> sizes)
        {
            if (segments.Count != sizes.Count)
            {
                throw new Exception(
                    "MemoryManager.AllocateMemory : segments.count did" + 
                    " not match sizes.count.");
            }

            // determine how many pages we need
            int requestedPages = 0;
            for (int i = 0; i < segments.Count; i++)
            {
                Double temp = Convert.ToDouble(sizes[i]) / 
                    Convert.ToDouble(memory.PageSize);
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
                throw new Exception("MemoryManager.AllocateMemory : Not " + 
                    "enough memory available in physical memory.");
            }

            // enough space, get indices and begin to fill in
            List<int> freeIndices = memory.GetFreeIndices();
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
                        // some sort of error between memory manager
                    }
                }
                p.AddSegment(segments[i], logicalIndicies, physicalIndicies);
            }

            return true;
            
        }

        /// <summary>
        /// Process frees physical memory, it is thus available to use
        /// for new processes.
        /// </summary>
        /// <param name="physicalAddresses">List of physical memory
        /// to free.</param>
        public void FreeMemory(List<int> physicalAddresses)
        {
            for (int i = 0; i < physicalAddresses.Count; i++)
            {
                memory.ReleaseMemory(physicalAddresses[i]);
            }
        }

        /// <summary>
        /// Getst the total size of physical memory.
        /// </summary>
        /// <returns></returns>
        public int GetMemorySize()
        {
            return memory.TotalMemory;
        }

        /// <summary>
        /// Gets the total page count.
        /// </summary>
        /// <returns></returns>
        public int GetPageCount()
        {
            return memory.TotalMemory / memory.PageSize;
        }

        /// <summary>
        /// Gets the page size.
        /// </summary>
        /// <returns></returns>
        public int GetPageSize()
        {
            return memory.PageSize;
        }

        /// <summary>
        /// Gets number of pages used.
        /// </summary>
        /// <returns></returns>
        public int GetPagesUsed()
        {
            return memory.GetUsedIndices().Count;
        }
    }
}
