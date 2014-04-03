using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS452_Project3_MemoryManagement.model
{
    class ProcessControlBlock
    {
        /// <summary>
        /// Index in page table where text section begins.
        /// </summary>
        private int textIndex;
        /// <summary>
        /// Length of text section in page table.
        /// </summary>
        private int textLength;
        /// <summary>
        /// Index in page table where data sectioni begins.
        /// </summary>
        private int dataIndex;
        /// <summary>
        /// Length of data section in page table.
        /// </summary>
        private int dataLength;
        /// <summary>
        /// Index to store next segment at.
        /// </summary>
        private int nextIndex = 0;
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ProcessControlBlock()
        {
            
        }

        /// <summary>
        /// Creates a deep copy of ProcessControlBlock object.
        /// </summary>
        /// <returns>Copy of ProcessControlBlock Object.</returns>
        public ProcessControlBlock Copy()
        {
            ProcessControlBlock pcb = new ProcessControlBlock();
            pcb.SetTextSegment(this.textIndex, this.textLength);
            pcb.SetDataSegment(this.dataIndex, this.dataLength);
            pcb.SetNextIndex(this.nextIndex);
            return pcb;
        }

        /// <summary>
        /// Sets the index for where next segment should begin.
        /// </summary>
        /// <param name="index">Index where next segment begins.</param>
        public void SetNextIndex(int index)
        {
            this.nextIndex = index;
        }

        /// <summary>
        /// Sets data segment index and length.
        /// </summary>
        /// <param name="index">Start index.</param>
        /// <param name="length">Segment Length.</param>
        public void SetDataSegment(int index, int length)
        {
            this.dataIndex = index;
            this.dataLength = length;
        }

        /// <summary>
        /// Sets text segment index and length.
        /// </summary>
        /// <param name="index">Start index.</param>
        /// <param name="length">Segment length.</param>
        public void SetTextSegment(int index, int length)
        {
            this.textIndex = index;
            this.textLength = length;
        }

        /// <summary>
        /// Gets index in page table of segment.
        /// </summary>
        /// <param name="s">Segment to find.</param>
        /// <returns>Index of segment.</returns>
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

        /// <summary>
        /// Stores segment information for new segment.
        /// </summary>
        /// <param name="s">Segment type.</param>
        /// <param name="length">Segment length.</param>
        /// <returns>True on success, False otherwise.</returns>
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

        /// <summary>
        /// Gets the type of a segment at logical address.
        /// </summary>
        /// <param name="logicalAddress">Logical address to search.</param>
        /// <returns>Type of segment.</returns>
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
