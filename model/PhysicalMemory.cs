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
        private Page[] pages;
        private List<int> freeIndices;
        private List<int> usedIndices;

        public PhysicalMemory(int pages, int pageSize)
        {
            totalMemory = pages * pageSize;
            pageMemory = pageSize;
            this.pages = new Page[pages];
            freeIndices = new List<int>();
            usedIndices = new List<int>();
            InitializeMemory(pageSize);
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
            for (int i = 0; i < pages.Length; i++)
            {
                pages[i].ClearPage();
                usedIndices.Remove(i);
                freeIndices.Add(i);
            }
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

        public Boolean AddPageAtIndex(int index, int pid, Segment type, int pageNumber)
        {
            if (!freeIndices.Remove(index))
            {
                return false;
            }
            usedIndices.Add(index);
            pages[index].SetPage(pid, type, pageNumber);
            return true;
        }

        public Boolean RemovePageAtIndex(int index)
        {
            if (!usedIndices.Remove(index))
            {
                return false;
            }
            freeIndices.Add(index);
            pages[index].ClearPage();
            return true;
        }

        public Boolean RemoveProcessPages(int pid)
        {
            Boolean removedItem = false;
            for (int i = 0; i < pages.Length; i++)
            {
                if (pages[i].Pid == pid)
                {
                    RemovePageAtIndex(i);
                    removedItem = true;
                }
            }
            return removedItem;
        }

        public Boolean RemoveProcessSegment(int pid, Segment segmentType)
        {
            Boolean removedItem = false;
            for (int i = 0; i < pages.Length; i++)
            {
                if (pages[i].Pid == pid && pages[i].SegmentType == segmentType)
                {
                    RemovePageAtIndex(i);
                    removedItem = true;
                }
            }
            return removedItem;
        }

        public Boolean RemoveProcessPage(int pid, Segment segmentType, int pageNumber)
        {
            Boolean removedItem = false;
            for (int i = 0; i < pages.Length; i++)
            {
                if (pages[i].Pid == pid && pages[i].SegmentType == segmentType && pages[i].PageNumber == pageNumber)
                {
                    RemovePageAtIndex(i);
                    removedItem = true;
                }
            }
            return removedItem;
        }

        private void InitializeMemory(int pageSize)
        {
            for (int i = 0; i < pages.Length; i++)
            {
                pages[i] = new Page(pageSize);
                freeIndices.Add(i);
            }
        }
    }
}
