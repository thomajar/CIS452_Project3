using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model                               
{
    class PageTableRowView
    {
        private Segment seg;
        private int logical;
        private int physical;

        public Segment Seg
        {
            get
            {
                return seg;
            }
            set
            {
                seg = value;
            }
        }

        public int Logical
        {
            get
            {
                return logical;
            }
            set
            {
                logical = value;
            }
        }

        public int Physical
        {
            get
            {
                return physical;
            }
            set
            {
                physical = value;
            }
        }

        public PageTableRowView()
        {
            seg = Segment.None;
            logical = 0;
            physical = 0;
        }
    }

    class PhysicalMemoryRowView
    {
        private int frame;
        private int pid;
        private Segment seg;
        private int page;

        public int FrameNumber
        {
            get
            {
                return frame;
            }
            set
            {
                frame = value;
            }
        }

        public int PID
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
            }
        }

        public Segment Seg
        {
            get
            {
                return seg;
            }
            set
            {
                seg = value;
            }
        }

        public int PageNumber
        {
            get
            {
                return page;
            }
            set
            {
                page = value;
            }
        }

        public PhysicalMemoryRowView()
        {
            frame = 0;
            pid = 0;
            seg = Segment.None;
            page = 0;
        }
    }

    class ViewState
    {
        private int memorySize;
        private int pageCount;
        private int pageSize;
        private int pagesUsed;
        private int processPageCount;

        private List<PhysicalMemoryRowView> rows;
        private List<PageTableRowView> tablerows;
        

        public int MemorySize
        {
            get 
            {
                return memorySize;
            }
            set
            {
                memorySize = value;
            }
        }

        public int PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }

        public int PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = value;
            }
        }

        public int PagesUsed
        {
            get
            {
                return pagesUsed;
            }
            set
            {
                pagesUsed = value;
            }
        }

        public List<PhysicalMemoryRowView> Rows
        {
            get
            {
                return rows;
            }
            set
            {
                rows = value;
            }
        }

        public List<PageTableRowView> PageTableRows
        {
            get
            {
                return tablerows;
            }
            set
            {
                tablerows = value;
            }
        }

        public int ProcessPageCount
        {
            get
            {
                return processPageCount;
            }
            set
            {
                processPageCount = value;
            }
        }

        public ViewState()
        {
            
        }
    }
}
