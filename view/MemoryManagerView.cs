
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CIS452_Project3_MemoryManagement.controller;
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

        private const int MEM_FRAME_INDEX = 0;
        private const int MEM_PID_INDEX = 1;
        private const int MEM_SEGMENT_INDEX = 2;
        private const int MEM_PAGE_INDEX = 3;

        private const int PROC_SEGMENT_INDEX = 0;
        private const int PROC_LOGICAL_INDEX = 1;
        private const int PROC_PHYSICAL_INDEX = 2;

        private Label[,] physicalMemoryLabels;
        private Label[,] processPageTableLabels;

        private Controller ctrl;
        private int physicalMemoryIndex = 0;
        private int pageTableIndex = 0;
        private int processNumber = 0;

        public MemoryManagerView()
        {
            InitializeComponent();

            // initialize controller
            ctrl = new Controller();

            // initialize physical memory labels
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
            // initialize page table labels
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
            colors = new Color[DISPLAY_PAGE_TABLE_COLUMNS];
            colors[0] = Color.Salmon;
            colors[1] = Color.DodgerBlue;
            colors[2] = Color.LimeGreen;
            colors[3] = Color.PeachPuff;
            colors[4] = Color.Turquoise;
            colors[5] = Color.Gold;
            colors[6] = Color.DeepSkyBlue;
            colors[7] = Color.OrangeRed;
            colors[8] = Color.Chartreuse;
            colors[9] = Color.Aqua;
            colors[10] = Color.Orange;
            colors[11] = Color.Teal;
            colorPID = new int[DISPLAY_PAGE_TABLE_COLUMNS];

            for (int i = 0; i < colorPID.Length; i++)
            {
                colorPID[i] = -1;
            }

        }

        private Color[] colors;
        private int[] colorPID;

        private void UpdateView()
        {
            this.SuspendLayout();
            ViewState view = ctrl.GetViewState(physicalMemoryIndex,
                processNumber, pageTableIndex);
            lblMemorySizeOut.Text = "Memory Size : " + view.MemorySize + 
                " (Bytes)";
            lblPageCountOut.Text = "Page Count : " + view.PageCount;
            lblPageSizeOut.Text = "Page Size : " + view.PageSize + " (Bytes)";
            lblPageUsedOut.Text = "Pages Used : " + view.PagesUsed;
            pbMemoryUsed.Value = 100 * view.PagesUsed / view.PageCount;

            Boolean[] colorStillUsed = new Boolean[DISPLAY_PAGE_TABLE_COLUMNS];

            for (int i = 0; i < view.Rows.Count; i++)
            {
                if (view.Rows[i].Seg == Segment.None)
                {
                    physicalMemoryLabels[i, MEM_FRAME_INDEX].Text = "" +
                        (physicalMemoryIndex + i);
                    physicalMemoryLabels[i, MEM_FRAME_INDEX].BackColor =
                        Color.FromKnownColor(KnownColor.Control);
                    physicalMemoryLabels[i, MEM_PID_INDEX].Text = ".";
                    physicalMemoryLabels[i, MEM_PID_INDEX].BackColor = 
                        Color.FromKnownColor(KnownColor.Control);
                    physicalMemoryLabels[i, MEM_SEGMENT_INDEX].Text = ".";
                    physicalMemoryLabels[i, MEM_SEGMENT_INDEX].BackColor = 
                        Color.FromKnownColor(KnownColor.Control);
                    physicalMemoryLabels[i, MEM_PAGE_INDEX].Text = ".";
                    physicalMemoryLabels[i, MEM_PAGE_INDEX].BackColor =
                        Color.FromKnownColor(KnownColor.Control);
                }
                else
                {
                    
                    Boolean foundColorMatch = false;
                    Color color = Color.FromKnownColor(KnownColor.Control);
                    // check if pid already has color associated with it
                    for (int j = 0; j < colorPID.Length; j++)
                    {
                        if (colorPID[j] == view.Rows[i].PID)
                        {
                            colorStillUsed[j] = true;
                            color = colors[j];
                            foundColorMatch = true;
                            break;
                        }
                    }
                    //  need to pick out a color
                    if (!foundColorMatch)
                    {
                        for (int j = 0; j < colorPID.Length; j++)
                        {
                            if (colorPID[j] == -1)
                            {
                                colorPID[j] = view.Rows[i].PID;
                                color = colors[j];
                                break;
                            }
                        }
                    }

                    physicalMemoryLabels[i, MEM_FRAME_INDEX].Text = "" +
                        view.Rows[i].FrameNumber;
                    physicalMemoryLabels[i, MEM_FRAME_INDEX].BackColor = color;
                    physicalMemoryLabels[i, MEM_PID_INDEX].Text = "" + 
                        view.Rows[i].PID;
                    physicalMemoryLabels[i, MEM_PID_INDEX].BackColor = color;
                    physicalMemoryLabels[i, MEM_SEGMENT_INDEX].Text = "" + 
                        view.Rows[i].Seg;
                    physicalMemoryLabels[i, MEM_SEGMENT_INDEX].BackColor = 
                        color;
                    physicalMemoryLabels[i, MEM_PAGE_INDEX].Text = "" + 
                        view.Rows[i].PageNumber;
                    physicalMemoryLabels[i, MEM_PAGE_INDEX].BackColor = color;
                }
                
            }

            for (int i = 0; i < colorStillUsed.Length; i++)
            {
                if (!colorStillUsed[i])
                {
                    colorPID[i] = -1;
                }
            }

            int textPages = 0;
            int dataPages = 0;


            for (int i = 0; i < view.PageTableRows.Count; i++)
            {
                switch (view.PageTableRows[i].Seg)
                {
                    case Segment.Text:
                        textPages++;
                        break;
                    case Segment.Data:
                        dataPages++;
                        break;
                    default:
                        break;
                }              
            }
            lblProcessTextOut.Text = "Text Pages : " + textPages;
            lblProcessDataOut.Text = "Data Pages : " + dataPages;

            for (int i = 0; i < view.PageTableRows.Count 
                && i < DISPLAY_PAGE_TABLE_COLUMNS; i++)
            {
                processPageTableLabels[i, PROC_SEGMENT_INDEX].Text = "" +
                    view.PageTableRows[i].Seg;
                processPageTableLabels[i, PROC_LOGICAL_INDEX].Text = "" +
                    view.PageTableRows[i].Logical;
                processPageTableLabels[i, PROC_PHYSICAL_INDEX].Text = "" +
                    view.PageTableRows[i].Physical;
            }
            for (int i = view.PageTableRows.Count;
                i < DISPLAY_PAGE_TABLE_COLUMNS; i++)
            {
                processPageTableLabels[i, PROC_SEGMENT_INDEX].Text = ".";
                processPageTableLabels[i, PROC_LOGICAL_INDEX].Text = ".";
                processPageTableLabels[i, PROC_PHYSICAL_INDEX].Text = ".";
            }

            lblProcessNumberOut.Text = "Process " + processNumber;
            gbProcessInfo.Text = "Process " + processNumber + 
                " Memory Information";
            lblPageTableForProcess.Text = "Page Table for Process " +
                processNumber;

            int scrollBarMax = view.PageCount - 1;
            if (scrollBarMax < 0)
            {
                scrollBarMax = 0;
            }
            scrollbarPhysicalMemory.Maximum = scrollBarMax;

            scrollBarMax = view.ProcessPageCount - 1;
            if (scrollBarMax < 0)
            {
                scrollBarMax = 0;
            }
            scrollBarPageTable.Maximum = scrollBarMax;

            scrollScriptIndex.Maximum = ctrl.GetSteps() - 1;
            scrollScriptIndex.Value = ctrl.GetStepIndex();

            lblLastCommandOut.Text = ctrl.GetLastCommand();
            txtCommandIn.Text = ctrl.GetCurrentCommand();

            this.ResumeLayout();
        }


        private void btnStartComputer_Click(object sender, EventArgs e)
        {
            int physicalMemorySize;
            try
            {
                physicalMemorySize = 
                    Convert.ToInt32(txtPhysicalMemoryIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to start computer." +
                    Environment.NewLine + "Physical Memory Size : " +
                    txtPhysicalMemoryIn.Text + " unrecognized.",
                    "Error");
                return;
            }
            int pageSize;
            try
            {
                pageSize = Convert.ToInt32(txtPageSizeIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to start computer." +
                    Environment.NewLine + "Page Size : " +
                    txtPageSizeIn.Text + " unrecognized.",
                    "Error");
                return;
            }
            if (!ctrl.StartComputer(physicalMemorySize,pageSize))
            {
                MessageBox.Show("Unable to start computer.",
                    "Error");
                return;
            }
            btnStartComputer.Enabled = false;
            btnRestartComputer.Enabled = true;
            btnDestroyComputer.Enabled = true;
            txtPhysicalMemoryIn.ReadOnly = true;
            txtPageSizeIn.ReadOnly = true;
            gbCommands.Enabled = true;
            tlpPhysicalMemoryLayout.Enabled = true;
            tlpProcessLayout.Enabled = true;
            processNumber = 0;
            pageTableIndex = 0;
            physicalMemoryIndex = 0;

            for (int i = 0; i < DISPLAY_PAGE_TABLE_COLUMNS; i++)
            {
                physicalMemoryLabels[i, MEM_FRAME_INDEX].Text = "" +
                    (physicalMemoryIndex + i);
                physicalMemoryLabels[i, MEM_FRAME_INDEX].BackColor = 
                    Color.FromKnownColor(KnownColor.Control);
                physicalMemoryLabels[i, MEM_PID_INDEX].Text = ".";
                physicalMemoryLabels[i, MEM_PID_INDEX].BackColor = 
                    Color.FromKnownColor(KnownColor.Control);
                physicalMemoryLabels[i, MEM_SEGMENT_INDEX].Text = ".";
                physicalMemoryLabels[i, MEM_SEGMENT_INDEX].BackColor = 
                    Color.FromKnownColor(KnownColor.Control);
                physicalMemoryLabels[i, MEM_PAGE_INDEX].Text = ".";
                physicalMemoryLabels[i, MEM_PAGE_INDEX].BackColor = 
                    Color.FromKnownColor(KnownColor.Control);
            }

            // update view
            UpdateView();
            
        }

        private void btnRestartComputer_Click(object sender, EventArgs e)
        {
            if (ctrl.RestartComputer())
            {
                // update view
                processNumber = 0;
                pageTableIndex = 0;
                physicalMemoryIndex = 0;
                UpdateView();
            }
        }

        private void btnDestroyComputer_Click(object sender, EventArgs e)
        {
            if (ctrl.DestroyComputer())
            {
                btnStartComputer.Enabled = true;
                btnRestartComputer.Enabled = false;
                btnDestroyComputer.Enabled = false;
                txtPhysicalMemoryIn.ReadOnly = false;
                txtPhysicalMemoryIn.Text = "";
                txtPageSizeIn.ReadOnly = false;
                txtPageSizeIn.Text = "";
                gbCommands.Enabled = false;
                tlpPhysicalMemoryLayout.Enabled = false;
                tlpProcessLayout.Enabled = false;

                // update view
                //UpdateView();
            }
        }

        private void btnSpawnProcess_Click(object sender, EventArgs e)
        {
            int textSize;
            int dataSize;
            try
            {
                textSize = Convert.ToInt32(txtTextSizeIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to spawn process." + 
                    Environment.NewLine +
                    "Text size : " + txtTextSizeIn.Text + " unrecognized.",
                    "Error");
                return;
            }
            try
            {
                dataSize = Convert.ToInt32(txtDataSizeIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to spawn process." + 
                    Environment.NewLine +
                    "Data size : " + txtDataSizeIn.Text + " unrecognized.",
                    "Error");
                return;
            }
            int pid = ctrl.SpawnProcess(textSize, dataSize);
            if (pid > -1)
            {
                // udpate view
                processNumber = pid;
                pageTableIndex = 0;
                UpdateView();
            }
            else
            {
                MessageBox.Show("Unable to spawn process." + 
                    Environment.NewLine +
                    "Computer may be out of memory.",
                    "Error");
                return;
            }
        }

        private void btnPreviousProcess_Click(object sender, EventArgs e)
        {
            processNumber = ctrl.GetPreviousPID(processNumber);
            if (processNumber < 0)
                processNumber = 0;
            pageTableIndex = 0;
            UpdateView();
        }

        private void btnNextProcess_Click(object sender, EventArgs e)
        {
            processNumber = ctrl.GetNextPID(processNumber);
            if (processNumber < 0)
                processNumber = 0;
            pageTableIndex = 0;
            UpdateView();
        }

        private void scrollbarPhysicalMemory_Scroll(object sender, 
            ScrollEventArgs e)
        {
            physicalMemoryIndex += e.NewValue - e.OldValue;
            UpdateView();
        }

        private void scrollBarPageTable_Scroll(object sender, 
            ScrollEventArgs e)
        {
            pageTableIndex += e.NewValue - e.OldValue;
            UpdateView();
        }

        private void btnTerminateProcess_Click(object sender, EventArgs e)
        {
            ctrl.TerminateProcess(processNumber);
            processNumber = ctrl.GetNextPID(processNumber);
            UpdateView();
        }

        private void btnSubmitCommand_Click(object sender, EventArgs e)
        {
            if (ctrl.GetStepIndex() + 1 != ctrl.GetSteps())
            {
                MessageBox.Show("Cannot edit history.", "Error");
                return;
            }
            if (!ctrl.InterpretCommand(txtCommandIn.Text))
            {
                MessageBox.Show("Unable to interpret and execute command.",
                    "Error");
            }
            else
            {
                txtCommandIn.ResetText();
            }
            UpdateView();
        }

        private void txtCommandIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnSubmitCommand_Click(null, EventArgs.Empty);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Data Files (*.data)|*.data";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ctrl.LoadScript(ofd.FileName);
                UpdateView();
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            ctrl.NextStep();
            UpdateView();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ctrl.PreviousStep();
            UpdateView();
        }

        private void scrollScriptIndex_Scroll(object sender, EventArgs e)
        {
            ctrl.JumpToStep(scrollScriptIndex.Value);
            UpdateView();
        }



        
    }
}
