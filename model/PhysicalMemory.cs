using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class PhysicalMemory
    {
        /// <summary>
        /// Total memory in physical memory.
        /// </summary>
        private int totalMemory;
        /// <summary>
        /// Amount of memory on each page.
        /// </summary>
        private int pageMemory;
        /// <summary>
        /// Total count of pages.
        /// </summary>
        private int pageCount;
        /// <summary>
        /// List of all free pages not currently being used in memory.
        /// </summary>
        private List<int> freeIndices;

        /// <summary>
        /// Initializes physical memory to have pages number of pages of 
        /// size pageSize.
        /// </summary>
        /// <param name="pages">Number of pages in memory.</param>
        /// <param name="pageSize">Size of each page.</param>
        public PhysicalMemory(int pages, int pageSize)
        {
            pageCount = pages;
            totalMemory = pages * pageSize;
            pageMemory = pageSize;
            freeIndices = new List<int>();
            InitializeMemory();
        }

        /// <summary>
        /// Creates a deep copy of PhysicalMemory.
        /// </summary>
        /// <returns>Deep copy of physical memory.</returns>
        public PhysicalMemory Copy()
        {
            PhysicalMemory mem = new PhysicalMemory(this.pageCount,
                this.pageMemory);
            mem.SetFreeIndicies(this.freeIndices);
            return mem;

        }

        /// <summary>
        /// Sets the free indicies list.
        /// </summary>
        /// <param name="freeIndices"></param>
        public void SetFreeIndicies(List<int> freeIndices)
        {
            this.freeIndices.Clear();
            foreach (int item in freeIndices)
            {
                this.freeIndices.Add(item);
            }
        }

        /// <summary>
        /// Total amount of memory.
        /// </summary>
        public int TotalMemory
        {
            get
            {
                return totalMemory;
            }
        }

        /// <summary>
        /// Size of page.
        /// </summary>
        public int PageSize
        {
            get
            {
                return pageMemory;
            }
        }

        /// <summary>
        /// Amount of memory unused.
        /// </summary>
        /// <returns>Amount of memory unused.</returns>
        public int GetFreeMemorySize()
        {
            return freeIndices.Count * pageMemory;
        }

        public void ClearMemory()
        {
            freeIndices.Clear();
            for (int i = 0; i < pageCount; i++)
            {
                freeIndices.Add(i);
            }
        }

        /// <summary>
        /// Obtains a list of free page indicies.
        /// </summary>
        /// <returns>List of free memory pages.</returns>
        public List<int> GetFreeIndices()
        {
            List<int> retFreeIndices = new List<int>();
            foreach (int item in freeIndices)
            {
                retFreeIndices.Add(item);
            }
            retFreeIndices.Sort();
            return retFreeIndices;
        }

        /// <summary>
        /// Obtains a list of used page indicies.
        /// </summary>
        /// <returns>List of used memory pages.</returns>
        public List<int> GetUsedIndices()
        {
            List<int> retUsedIndices = new List<int>();
            for (int i = 0; i < pageCount; i++)
            {
                if (!freeIndices.Contains(i))
                {
                    retUsedIndices.Add(i);
                }
            }
            return retUsedIndices;
        }

        /// <summary>
        /// Requests memory for particular page.
        /// </summary>
        /// <param name="index">Page index to request.</param>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean RequestMemory(int index)
        {
            Boolean isMemoryOpen = false;
            if (freeIndices.Contains(index))
            {
                isMemoryOpen = true;
                freeIndices.Remove(index);
            }
            return isMemoryOpen;
        }

        /// <summary>
        /// Releases memory for particular page.
        /// </summary>
        /// <param name="index">Page index to release.</param>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean ReleaseMemory(int index)
        {
            Boolean isMemoryUsed = false;
            if (!freeIndices.Contains(index))
            {
                isMemoryUsed = true;
                freeIndices.Add(index);
            }
            return isMemoryUsed;
        }

        /// <summary>
        /// Initializes memory.
        /// </summary>
        private void InitializeMemory()
        {
            for (int i = 0; i < pageCount; i++)
            {
                freeIndices.Add(i);
            }
        }
    }
}
