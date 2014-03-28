using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class Page
    {
        /// <summary>
        /// Number of bytes that fits into page.
        /// </summary>
        private int size;

        /// <summary>
        /// Owner process identification number.
        /// </summary>
        private int pid;

        /// <summary>
        /// Type of segment.
        /// </summary>
        private Segment segmentType;

        /// <summary>
        /// Page number internal to process.
        /// </summary>
        private int pageNumber;

        /// <summary>
        /// Creates a new page.
        /// </summary>
        /// <param name="size">Size of page.</param>
        public Page(int size)
        {
            this.size = size;
            this.pid = -1;
            this.segmentType = Segment.None;
            this.pageNumber = -1;
        }

        /// <summary>
        /// Read only pid.
        /// </summary>
        public int Pid
        {
            get
            {
                return pid;
            }
        }

        /// <summary>
        /// Read only Segment Type.
        /// </summary>
        public Segment SegmentType
        {
            get
            {
                return segmentType;
            }
        }

        /// <summary>
        /// Read only Page Number.
        /// </summary>
        public int PageNumber
        {
            get
            {
                return pageNumber;
            }
        }

        /// <summary>
        /// Sets the page contents.
        /// </summary>
        /// <param name="pid">Owner process identification.</param>
        /// <param name="type">Type of data segment.</param>
        /// <param name="pageNumber">Page number referenced by process.</param>
        public void SetPage(int pid, Segment type, int pageNumber)
        {
            this.pid = pid;
            this.segmentType = type;
            this.pageNumber = pageNumber;
        }

        /// <summary>
        /// Clears the contents of the page.
        /// </summary>
        public void ClearPage()
        {
            this.pid = -1;
            this.segmentType = Segment.None;
            this.pageNumber = -1;
        }

        /// <summary>
        /// Prints contents of Page in string format.
        /// </summary>
        /// <returns>Contents of Page.</returns>
        public override string ToString()
        {
            return "PID: " + pid + " Segment: " + segmentType.ToString() +
                " PageNumber " + pageNumber;
        }
    }
}
