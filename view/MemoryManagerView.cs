
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
            MemoryManager model = new MemoryManager(4096, 512);
            List<Segment> segs = new List<Segment>();
            segs.Add(Segment.Text);
            segs.Add(Segment.Data);
            List<int> sizes = new List<int>();
            sizes.Add(1044);
            sizes.Add(940);
            model.AllocateMemory(45, segs, sizes);
            //model.AllocateMemory(46, segs, sizes);
            model.FreeMemory(45);
        }
    }
}
