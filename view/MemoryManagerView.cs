
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CIS452_Project3_MemoryManagement.model;

namespace CIS452_Project3_MemoryManagement
{
    public partial class MemoryManagerView: Form
    {
        private const int DISPLAY_PHYSICAL_MEMORY_PAGE_COLUMNS = 12;
        private const int DISPLAY_PHYSICAL_MEMORY_PAGE_ROWS = 4;
        private const int DISPLAY_PHYSICAL_MEMORY_PAGE_OFFEST = 2;

        private const int DISPLAY_PAGE_TABLE_COLUMNS = 12;
        private const int DISPLAY_PAGE_TABLE_ROWS = 3;
        private const int DISPLAY_PAGE_TABLE_OFFSET = 2;

        private Label[,] physicalMemoryLabels;
        private Label[,] processPageTableLabels;

        public MemoryManagerView()
        {
            

            InitializeComponent();

            physicalMemoryLabels = new Label[
              DISPLAY_PHYSICAL_MEMORY_PAGE_COLUMNS,
              DISPLAY_PHYSICAL_MEMORY_PAGE_ROWS];
            for (int i = 0; i < DISPLAY_PHYSICAL_MEMORY_PAGE_COLUMNS; i++)
            {
                for (int j = 0; j < DISPLAY_PHYSICAL_MEMORY_PAGE_ROWS; j++)
                {
                    Label label = new Label();
                    label.Text = ".";
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    physicalMemoryLabels[i, j] = label;
                    tlpPhysicalMemoryLayout.Controls.Add(
                        physicalMemoryLabels[i, j],
                        j, i + DISPLAY_PHYSICAL_MEMORY_PAGE_OFFEST);
                }
            }
            processPageTableLabels = new Label[
                DISPLAY_PAGE_TABLE_COLUMNS,
                DISPLAY_PAGE_TABLE_ROWS];
            for (int i = 0; i < DISPLAY_PAGE_TABLE_COLUMNS; i++)
            {
                for (int j = 0; j < DISPLAY_PAGE_TABLE_ROWS; j++)
                {
                    Label label = new Label();
                    label.Text = ".";
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    processPageTableLabels[i, j] = label;
                    tlpProcessPageTable.Controls.Add(
                        processPageTableLabels[i, j],
                        j, i + DISPLAY_PAGE_TABLE_OFFSET);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          



            // to be removed
            Computer cpu = new Computer(4096, 512);
            List<Segment> segs = new List<Segment>();
            segs.Add(Segment.Text);
            segs.Add(Segment.Data);
            List<int> sizes = new List<int>();
            sizes.Add(1044);
            sizes.Add(940);
            cpu.SpawnProcess(segs, sizes);
            segs.Clear();
            sizes.Clear();
            segs.Add(Segment.Text);
            segs.Add(Segment.Data);
            sizes.Add(340);
            sizes.Add(345);
            cpu.SpawnProcess(segs, sizes);
            cpu.TerminateProcess(0);
            cpu.SpawnProcess(segs, sizes);
            int c = 4;
        }
    }
}
