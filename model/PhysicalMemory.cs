using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class PhysicalMemory
    {
        private int totalMemory;
        private int pageMemory;
        private int pageCount;
        private List<int> freeIndices;
        private List<int> usedIndices;

        public PhysicalMemory(int pages, int pageSize)
        {
            pageCount = pages;
            totalMemory = pages * pageSize;
            pageMemory = pageSize;
            freeIndices = new List<int>();
            usedIndices = new List<int>();
            InitializeMemory();
        }

        public int TotalMemory
        {
            get
            {
                return totalMemory;
            }
        }

        public int PageSize
        {
            get
            {
                return pageMemory;
            }
        }

        public int GetFreeMemorySize()
        {
            return freeIndices.Count * pageMemory;
        }

        public void ClearMemory()
        {
            for (int i = 0; i < usedIndices.Count; i++)
            {
                freeIndices.Add(usedIndices[i]);
            }
            usedIndices.Clear();
        }

        public int[] GetFreeIndices()
        {
            int[] retFreeIndices = new int[freeIndices.Count];
            freeIndices.CopyTo(retFreeIndices, 0);
            return retFreeIndices;
        }

        public int[] GetUsedIndices()
        {
            int[] retUsedIndices = new int[usedIndices.Count];
            usedIndices.CopyTo(retUsedIndices, 0);
            return retUsedIndices;
        }

        public Boolean RequestMemory(int index)
        {
            Boolean isMemoryOpen = false;
            if (freeIndices.Contains(index))
            {
                isMemoryOpen = true;
                freeIndices.Remove(index);
                usedIndices.Add(index);
            }
            return isMemoryOpen;
        }
        public Boolean ReleaseMemory(int index)
        {
            Boolean isMemoryUsed = false;
            if (usedIndices.Contains(index))
            {
                isMemoryUsed = true;
                usedIndices.Remove(index);
                freeIndices.Add(index);
            }
            return isMemoryUsed;
        }
        

        private void InitializeMemory()
        {
            for (int i = 0; i < pageCount; i++)
            {
                freeIndices.Add(i);
            }
        }
    }
}
