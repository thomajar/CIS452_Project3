using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class ProcessControlBlock
    {
        private int textIndex;
        private int textLength;
        private int dataIndex;
        private int dataLength;
        private int nextIndex = 0;
        
        public ProcessControlBlock()
        {
            
        }

        public ProcessControlBlock Copy()
        {
            ProcessControlBlock pcb = new ProcessControlBlock();
            pcb.SetTextSegment(this.textIndex, this.textLength);
            pcb.SetDataSegment(this.dataIndex, this.dataLength);
            pcb.SetNextIndex(this.nextIndex);
            return pcb;
        }

        public void SetNextIndex(int index)
        {
            this.nextIndex = index;
        }

        public void SetDataSegment(int index, int length)
        {
            this.dataIndex = index;
            this.dataLength = length;
        }
        public void SetTextSegment(int index, int length)
        {
            this.textIndex = index;
            this.textLength = length;
        }

        public int GetSegmentPointer(Segment s)
        {
            switch (s)
            {
                case Segment.Text:
                    return textIndex;
                case Segment.Data:
                    return textIndex + textLength;
                default:
                    return -1;
            }
        }

        public Boolean AddSegment(Segment s, int length)
        {
            Boolean addResult = true;
            switch (s)
            {
                case Segment.Text:
                    textIndex = 0;
                    textLength = length;
                    nextIndex = length;
                    break;
                case Segment.Data:
                    dataIndex = textIndex + textLength;
                    dataLength = length;
                    nextIndex += length;
                    break;
                default:
                    addResult = false;
                    break;
            }
            return addResult;
        }

        public Segment GetSegmentType(int logicalAddress)
        {
            if (logicalAddress >= textIndex && 
                logicalAddress < textIndex + textLength)
            {
                return Segment.Text;
            }
            else if (logicalAddress >= dataIndex && 
                logicalAddress < dataIndex + dataLength)
            {
                return Segment.Data;
            }
            else
            {
                return Segment.None;
            }
        }
    }
}
