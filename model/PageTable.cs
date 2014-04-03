using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class PageTable
    {
        /// <summary>
        /// List of logical pointers.
        /// </summary>
        private List<int> logicalPointer;
        /// <summary>
        /// List of physical pointers
        /// </summary>
        private List<int> physicalPointer;

        /// <summary>
        /// Default constructor initializes logical and physical pointer
        /// to empty lists.
        /// </summary>
        public PageTable()
        {
            logicalPointer = new List<int>();
            physicalPointer = new List<int>();
        }

        /// <summary>
        /// Creates a deep copy of PageTable object.
        /// </summary>
        /// <returns>Deep copy of PageTable object.</returns>
        public PageTable Copy()
        {
            PageTable pageTable = new PageTable();
            pageTable.SetTable(this.logicalPointer, this.physicalPointer);
            return pageTable;
        }

        /// <summary>
        /// Sets the table to new logical and physical lists.
        /// </summary>
        /// <param name="logical">Logical pointer list.</param>
        /// <param name="physical">Physical pointer list.</param>
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

        /// <summary>
        /// Adds a segment to page table.
        /// </summary>
        /// <param name="startIndex">Where the segment should begin.</param>
        /// <param name="logical">List of logical adddresses.</param>
        /// <param name="physical">List of physical addresses.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Obtains the physical addresses.
        /// </summary>
        /// <returns>List of physical addresses.</returns>
        public List<int> GetPhysicalAddresses()
        {
            return physicalPointer;
        }

        /// <summary>
        /// Obtains a logical match for physical index.
        /// </summary>
        /// <param name="physical">Physical index to match.</param>
        /// <returns>Logical index matching physical index.</returns>
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
