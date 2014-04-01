
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
    public partial class MemoryManagerView : Form
    {
        public MemoryManagerView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
