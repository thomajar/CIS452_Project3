namespace CIS452_Project3_MemoryManagement
{
    partial class MemoryManagerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPhysicalMemoryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhysicalMemoryFrame = new System.Windows.Forms.Label();
            this.lblPhysicalMemoryPID = new System.Windows.Forms.Label();
            this.lblPhysicalMemorySegment = new System.Windows.Forms.Label();
            this.lblPhysicalMemoryPage = new System.Windows.Forms.Label();
            this.scrollbarPhysicalMemory = new System.Windows.Forms.VScrollBar();
            this.tlpProcessLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpProcessPageTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scrollBarPageTable = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPreviousProcess = new System.Windows.Forms.Button();
            this.btnNextProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProcessTextOut = new System.Windows.Forms.Label();
            this.lblProcessDataOut = new System.Windows.Forms.Label();
            this.lblProcessStackOut = new System.Windows.Forms.Label();
            this.lblProcessHeapOut = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartComputer = new System.Windows.Forms.Button();
            this.btnRestartComputer = new System.Windows.Forms.Button();
            this.btnDestroyComputer = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbVirtualMemoryEnable = new System.Windows.Forms.CheckBox();
            this.txtPageSizeIn = new System.Windows.Forms.TextBox();
            this.txtPhysicalMemoryIn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblComputerInputFeedback = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTextSizeIn = new System.Windows.Forms.TextBox();
            this.txtDataSizeIn = new System.Windows.Forms.TextBox();
            this.btnSpawnProcess = new System.Windows.Forms.Button();
            this.btnSubmitCommand = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCommandIn = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtScriptIn = new System.Windows.Forms.TextBox();
            this.txtFunctionDataCall = new System.Windows.Forms.TextBox();
            this.txtFunctionDataEnd = new System.Windows.Forms.TextBox();
            this.txtMallocIn = new System.Windows.Forms.TextBox();
            this.txtFreeIn = new System.Windows.Forms.TextBox();
            this.btnFunctionCall = new System.Windows.Forms.Button();
            this.btnFunctionEnd = new System.Windows.Forms.Button();
            this.btnMalloc = new System.Windows.Forms.Button();
            this.btnFree = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnTerminateProcess = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPageSizeOut = new System.Windows.Forms.Label();
            this.lblMemoryUsedOut = new System.Windows.Forms.Label();
            this.lblPageCountOut = new System.Windows.Forms.Label();
            this.lblMemorySizeOut = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pbMemoryUsed = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpPhysicalMemoryLayout.SuspendLayout();
            this.tlpProcessLayout.SuspendLayout();
            this.tlpProcessPageTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.Controls.Add(this.tlpPhysicalMemoryLayout, 1, 0);
            this.tlpMain.Controls.Add(this.tlpProcessLayout, 2, 0);
            this.tlpMain.Controls.Add(this.groupBox2, 0, 0);
            this.tlpMain.Controls.Add(this.groupBox3, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1105, 625);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpPhysicalMemoryLayout
            // 
            this.tlpPhysicalMemoryLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpPhysicalMemoryLayout.ColumnCount = 5;
            this.tlpPhysicalMemoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPhysicalMemoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPhysicalMemoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpPhysicalMemoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPhysicalMemoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpPhysicalMemoryLayout.Controls.Add(this.lblPhysicalMemoryFrame, 0, 1);
            this.tlpPhysicalMemoryLayout.Controls.Add(this.lblPhysicalMemoryPID, 1, 1);
            this.tlpPhysicalMemoryLayout.Controls.Add(this.lblPhysicalMemorySegment, 2, 1);
            this.tlpPhysicalMemoryLayout.Controls.Add(this.lblPhysicalMemoryPage, 3, 1);
            this.tlpPhysicalMemoryLayout.Controls.Add(this.scrollbarPhysicalMemory, 4, 2);
            this.tlpPhysicalMemoryLayout.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tlpPhysicalMemoryLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPhysicalMemoryLayout.Location = new System.Drawing.Point(445, 3);
            this.tlpPhysicalMemoryLayout.Name = "tlpPhysicalMemoryLayout";
            this.tlpPhysicalMemoryLayout.RowCount = 14;
            this.tlpMain.SetRowSpan(this.tlpPhysicalMemoryLayout, 2);
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPhysicalMemoryLayout.Size = new System.Drawing.Size(325, 619);
            this.tlpPhysicalMemoryLayout.TabIndex = 2;
            // 
            // lblPhysicalMemoryFrame
            // 
            this.lblPhysicalMemoryFrame.AutoSize = true;
            this.lblPhysicalMemoryFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhysicalMemoryFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicalMemoryFrame.Location = new System.Drawing.Point(4, 216);
            this.lblPhysicalMemoryFrame.Name = "lblPhysicalMemoryFrame";
            this.lblPhysicalMemoryFrame.Size = new System.Drawing.Size(65, 30);
            this.lblPhysicalMemoryFrame.TabIndex = 1;
            this.lblPhysicalMemoryFrame.Text = "Frame";
            this.lblPhysicalMemoryFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhysicalMemoryPID
            // 
            this.lblPhysicalMemoryPID.AutoSize = true;
            this.lblPhysicalMemoryPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhysicalMemoryPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicalMemoryPID.Location = new System.Drawing.Point(76, 216);
            this.lblPhysicalMemoryPID.Name = "lblPhysicalMemoryPID";
            this.lblPhysicalMemoryPID.Size = new System.Drawing.Size(65, 30);
            this.lblPhysicalMemoryPID.TabIndex = 2;
            this.lblPhysicalMemoryPID.Text = "PID";
            this.lblPhysicalMemoryPID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhysicalMemorySegment
            // 
            this.lblPhysicalMemorySegment.AutoSize = true;
            this.lblPhysicalMemorySegment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhysicalMemorySegment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicalMemorySegment.Location = new System.Drawing.Point(148, 216);
            this.lblPhysicalMemorySegment.Name = "lblPhysicalMemorySegment";
            this.lblPhysicalMemorySegment.Size = new System.Drawing.Size(76, 30);
            this.lblPhysicalMemorySegment.TabIndex = 3;
            this.lblPhysicalMemorySegment.Text = "Segment";
            this.lblPhysicalMemorySegment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhysicalMemoryPage
            // 
            this.lblPhysicalMemoryPage.AutoSize = true;
            this.lblPhysicalMemoryPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhysicalMemoryPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicalMemoryPage.Location = new System.Drawing.Point(231, 216);
            this.lblPhysicalMemoryPage.Name = "lblPhysicalMemoryPage";
            this.lblPhysicalMemoryPage.Size = new System.Drawing.Size(65, 30);
            this.lblPhysicalMemoryPage.TabIndex = 4;
            this.lblPhysicalMemoryPage.Text = "Page";
            this.lblPhysicalMemoryPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollbarPhysicalMemory
            // 
            this.scrollbarPhysicalMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollbarPhysicalMemory.Location = new System.Drawing.Point(300, 247);
            this.scrollbarPhysicalMemory.Name = "scrollbarPhysicalMemory";
            this.tlpPhysicalMemoryLayout.SetRowSpan(this.scrollbarPhysicalMemory, 12);
            this.scrollbarPhysicalMemory.Size = new System.Drawing.Size(24, 371);
            this.scrollbarPhysicalMemory.TabIndex = 5;
            // 
            // tlpProcessLayout
            // 
            this.tlpProcessLayout.ColumnCount = 3;
            this.tlpProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpProcessLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpProcessLayout.Controls.Add(this.tlpProcessPageTable, 0, 1);
            this.tlpProcessLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpProcessLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProcessLayout.Location = new System.Drawing.Point(776, 3);
            this.tlpProcessLayout.Name = "tlpProcessLayout";
            this.tlpProcessLayout.RowCount = 3;
            this.tlpMain.SetRowSpan(this.tlpProcessLayout, 2);
            this.tlpProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlpProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProcessLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProcessLayout.Size = new System.Drawing.Size(326, 619);
            this.tlpProcessLayout.TabIndex = 4;
            // 
            // tlpProcessPageTable
            // 
            this.tlpProcessPageTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpProcessPageTable.ColumnCount = 4;
            this.tlpProcessLayout.SetColumnSpan(this.tlpProcessPageTable, 3);
            this.tlpProcessPageTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpProcessPageTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpProcessPageTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpProcessPageTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpProcessPageTable.Controls.Add(this.label2, 0, 1);
            this.tlpProcessPageTable.Controls.Add(this.label3, 1, 1);
            this.tlpProcessPageTable.Controls.Add(this.label4, 2, 1);
            this.tlpProcessPageTable.Controls.Add(this.label5, 0, 0);
            this.tlpProcessPageTable.Controls.Add(this.scrollBarPageTable, 3, 2);
            this.tlpProcessPageTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProcessPageTable.Location = new System.Drawing.Point(3, 178);
            this.tlpProcessPageTable.Name = "tlpProcessPageTable";
            this.tlpProcessPageTable.RowCount = 14;
            this.tlpProcessLayout.SetRowSpan(this.tlpProcessPageTable, 2);
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProcessPageTable.Size = new System.Drawing.Size(320, 438);
            this.tlpProcessPageTable.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logical";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Physical";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tlpProcessPageTable.SetColumnSpan(this.label5, 4);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Page Table for Process _";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollBarPageTable
            // 
            this.scrollBarPageTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollBarPageTable.Location = new System.Drawing.Point(295, 63);
            this.scrollBarPageTable.Name = "scrollBarPageTable";
            this.tlpProcessPageTable.SetRowSpan(this.scrollBarPageTable, 12);
            this.scrollBarPageTable.Size = new System.Drawing.Size(24, 374);
            this.scrollBarPageTable.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpProcessLayout.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnPreviousProcess, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNextProcess, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 169);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnPreviousProcess
            // 
            this.btnPreviousProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreviousProcess.Location = new System.Drawing.Point(3, 3);
            this.btnPreviousProcess.Name = "btnPreviousProcess";
            this.btnPreviousProcess.Size = new System.Drawing.Size(100, 34);
            this.btnPreviousProcess.TabIndex = 0;
            this.btnPreviousProcess.Text = "<";
            this.btnPreviousProcess.UseVisualStyleBackColor = true;
            // 
            // btnNextProcess
            // 
            this.btnNextProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextProcess.Location = new System.Drawing.Point(215, 3);
            this.btnNextProcess.Name = "btnNextProcess";
            this.btnNextProcess.Size = new System.Drawing.Size(102, 34);
            this.btnNextProcess.TabIndex = 1;
            this.btnNextProcess.Text = ">";
            this.btnNextProcess.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process _";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 4);
            this.groupBox1.Size = new System.Drawing.Size(314, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process _ Memory Information";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.lblProcessTextOut, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProcessDataOut, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblProcessStackOut, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblProcessHeapOut, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnTerminateProcess, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(308, 102);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblProcessTextOut
            // 
            this.lblProcessTextOut.AutoSize = true;
            this.lblProcessTextOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessTextOut.Location = new System.Drawing.Point(3, 0);
            this.lblProcessTextOut.Name = "lblProcessTextOut";
            this.lblProcessTextOut.Size = new System.Drawing.Size(199, 25);
            this.lblProcessTextOut.TabIndex = 0;
            this.lblProcessTextOut.Text = "Text";
            this.lblProcessTextOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcessDataOut
            // 
            this.lblProcessDataOut.AutoSize = true;
            this.lblProcessDataOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessDataOut.Location = new System.Drawing.Point(3, 25);
            this.lblProcessDataOut.Name = "lblProcessDataOut";
            this.lblProcessDataOut.Size = new System.Drawing.Size(199, 25);
            this.lblProcessDataOut.TabIndex = 1;
            this.lblProcessDataOut.Text = "Data";
            this.lblProcessDataOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcessStackOut
            // 
            this.lblProcessStackOut.AutoSize = true;
            this.lblProcessStackOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessStackOut.Location = new System.Drawing.Point(3, 50);
            this.lblProcessStackOut.Name = "lblProcessStackOut";
            this.lblProcessStackOut.Size = new System.Drawing.Size(199, 25);
            this.lblProcessStackOut.TabIndex = 2;
            this.lblProcessStackOut.Text = "Stack";
            this.lblProcessStackOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcessHeapOut
            // 
            this.lblProcessHeapOut.AutoSize = true;
            this.lblProcessHeapOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessHeapOut.Location = new System.Drawing.Point(3, 75);
            this.lblProcessHeapOut.Name = "lblProcessHeapOut";
            this.lblProcessHeapOut.Size = new System.Drawing.Size(199, 27);
            this.lblProcessHeapOut.TabIndex = 3;
            this.lblProcessHeapOut.Text = "Heap";
            this.lblProcessHeapOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 214);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer Configuration";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnStartComputer, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRestartComputer, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDestroyComputer, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(430, 193);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnStartComputer
            // 
            this.btnStartComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartComputer.Location = new System.Drawing.Point(3, 3);
            this.btnStartComputer.Name = "btnStartComputer";
            this.btnStartComputer.Size = new System.Drawing.Size(137, 44);
            this.btnStartComputer.TabIndex = 0;
            this.btnStartComputer.Text = "Start";
            this.btnStartComputer.UseVisualStyleBackColor = true;
            // 
            // btnRestartComputer
            // 
            this.btnRestartComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestartComputer.Location = new System.Drawing.Point(146, 3);
            this.btnRestartComputer.Name = "btnRestartComputer";
            this.btnRestartComputer.Size = new System.Drawing.Size(137, 44);
            this.btnRestartComputer.TabIndex = 1;
            this.btnRestartComputer.Text = "Restart";
            this.btnRestartComputer.UseVisualStyleBackColor = true;
            // 
            // btnDestroyComputer
            // 
            this.btnDestroyComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDestroyComputer.Location = new System.Drawing.Point(289, 3);
            this.btnDestroyComputer.Name = "btnDestroyComputer";
            this.btnDestroyComputer.Size = new System.Drawing.Size(138, 44);
            this.btnDestroyComputer.TabIndex = 2;
            this.btnDestroyComputer.Text = "Destroy";
            this.btnDestroyComputer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cbVirtualMemoryEnable, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtPageSizeIn, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtPhysicalMemoryIn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label14, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblComputerInputFeedback, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(424, 137);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Physical Memory";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 39);
            this.label11.TabIndex = 1;
            this.label11.Text = "Page Size";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 39);
            this.label12.TabIndex = 2;
            this.label12.Text = "Virtual Memory";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbVirtualMemoryEnable
            // 
            this.cbVirtualMemoryEnable.AutoSize = true;
            this.cbVirtualMemoryEnable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVirtualMemoryEnable.Location = new System.Drawing.Point(144, 81);
            this.cbVirtualMemoryEnable.Name = "cbVirtualMemoryEnable";
            this.cbVirtualMemoryEnable.Size = new System.Drawing.Size(135, 33);
            this.cbVirtualMemoryEnable.TabIndex = 3;
            this.cbVirtualMemoryEnable.Text = "Enabled";
            this.cbVirtualMemoryEnable.UseVisualStyleBackColor = true;
            // 
            // txtPageSizeIn
            // 
            this.txtPageSizeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageSizeIn.Location = new System.Drawing.Point(144, 47);
            this.txtPageSizeIn.Name = "txtPageSizeIn";
            this.txtPageSizeIn.Size = new System.Drawing.Size(135, 22);
            this.txtPageSizeIn.TabIndex = 4;
            // 
            // txtPhysicalMemoryIn
            // 
            this.txtPhysicalMemoryIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhysicalMemoryIn.Location = new System.Drawing.Point(144, 8);
            this.txtPhysicalMemoryIn.Name = "txtPhysicalMemoryIn";
            this.txtPhysicalMemoryIn.Size = new System.Drawing.Size(135, 22);
            this.txtPhysicalMemoryIn.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(285, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 39);
            this.label13.TabIndex = 6;
            this.label13.Text = "(Bytes)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(285, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 39);
            this.label14.TabIndex = 7;
            this.label14.Text = "(Bytes)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComputerInputFeedback
            // 
            this.lblComputerInputFeedback.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.lblComputerInputFeedback, 3);
            this.lblComputerInputFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComputerInputFeedback.Location = new System.Drawing.Point(3, 117);
            this.lblComputerInputFeedback.Name = "lblComputerInputFeedback";
            this.lblComputerInputFeedback.Size = new System.Drawing.Size(418, 20);
            this.lblComputerInputFeedback.TabIndex = 8;
            this.lblComputerInputFeedback.Text = "Feedback";
            this.lblComputerInputFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 399);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commands";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label27, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.txtTextSizeIn, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtDataSizeIn, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.btnSpawnProcess, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnSubmitCommand, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtCommandIn, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnUndo, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnRedo, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnBrowse, 2, 9);
            this.tableLayoutPanel5.Controls.Add(this.label19, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.txtScriptIn, 1, 9);
            this.tableLayoutPanel5.Controls.Add(this.txtFunctionDataCall, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtFunctionDataEnd, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.txtMallocIn, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.txtFreeIn, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.lable, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label25, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnFunctionCall, 2, 5);
            this.tableLayoutPanel5.Controls.Add(this.btnFunctionEnd, 2, 6);
            this.tableLayoutPanel5.Controls.Add(this.btnMalloc, 2, 7);
            this.tableLayoutPanel5.Controls.Add(this.btnFree, 2, 8);
            this.tableLayoutPanel5.Controls.Add(this.label20, 2, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 11;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(430, 378);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 35);
            this.label16.TabIndex = 0;
            this.label16.Text = "Text";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 35);
            this.label17.TabIndex = 1;
            this.label17.Text = "Data";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTextSizeIn
            // 
            this.txtTextSizeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextSizeIn.Location = new System.Drawing.Point(103, 126);
            this.txtTextSizeIn.Name = "txtTextSizeIn";
            this.txtTextSizeIn.Size = new System.Drawing.Size(224, 22);
            this.txtTextSizeIn.TabIndex = 2;
            // 
            // txtDataSizeIn
            // 
            this.txtDataSizeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataSizeIn.Location = new System.Drawing.Point(103, 161);
            this.txtDataSizeIn.Name = "txtDataSizeIn";
            this.txtDataSizeIn.Size = new System.Drawing.Size(224, 22);
            this.txtDataSizeIn.TabIndex = 3;
            // 
            // btnSpawnProcess
            // 
            this.btnSpawnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSpawnProcess.Location = new System.Drawing.Point(333, 123);
            this.btnSpawnProcess.Name = "btnSpawnProcess";
            this.tableLayoutPanel5.SetRowSpan(this.btnSpawnProcess, 2);
            this.btnSpawnProcess.Size = new System.Drawing.Size(94, 64);
            this.btnSpawnProcess.TabIndex = 4;
            this.btnSpawnProcess.Text = "Spawn Process";
            this.btnSpawnProcess.UseVisualStyleBackColor = true;
            // 
            // btnSubmitCommand
            // 
            this.btnSubmitCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmitCommand.Location = new System.Drawing.Point(333, 53);
            this.btnSubmitCommand.Name = "btnSubmitCommand";
            this.btnSubmitCommand.Size = new System.Drawing.Size(94, 29);
            this.btnSubmitCommand.TabIndex = 5;
            this.btnSubmitCommand.Text = "Submit";
            this.btnSubmitCommand.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 35);
            this.label18.TabIndex = 6;
            this.label18.Text = "Command";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCommandIn
            // 
            this.txtCommandIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandIn.Location = new System.Drawing.Point(103, 56);
            this.txtCommandIn.Name = "txtCommandIn";
            this.txtCommandIn.Size = new System.Drawing.Size(224, 22);
            this.txtCommandIn.TabIndex = 7;
            // 
            // btnUndo
            // 
            this.btnUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUndo.Location = new System.Drawing.Point(3, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(94, 44);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Back";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnRedo
            // 
            this.btnRedo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRedo.Location = new System.Drawing.Point(333, 3);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(94, 44);
            this.btnRedo.TabIndex = 9;
            this.btnRedo.Text = "Next";
            this.btnRedo.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Location = new System.Drawing.Point(333, 333);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtScriptIn
            // 
            this.txtScriptIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScriptIn.Location = new System.Drawing.Point(103, 336);
            this.txtScriptIn.Name = "txtScriptIn";
            this.txtScriptIn.Size = new System.Drawing.Size(224, 22);
            this.txtScriptIn.TabIndex = 12;
            // 
            // txtFunctionDataCall
            // 
            this.txtFunctionDataCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunctionDataCall.Location = new System.Drawing.Point(103, 196);
            this.txtFunctionDataCall.Name = "txtFunctionDataCall";
            this.txtFunctionDataCall.Size = new System.Drawing.Size(224, 22);
            this.txtFunctionDataCall.TabIndex = 13;
            // 
            // txtFunctionDataEnd
            // 
            this.txtFunctionDataEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunctionDataEnd.Location = new System.Drawing.Point(103, 231);
            this.txtFunctionDataEnd.Name = "txtFunctionDataEnd";
            this.txtFunctionDataEnd.Size = new System.Drawing.Size(224, 22);
            this.txtFunctionDataEnd.TabIndex = 14;
            // 
            // txtMallocIn
            // 
            this.txtMallocIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMallocIn.Location = new System.Drawing.Point(103, 266);
            this.txtMallocIn.Name = "txtMallocIn";
            this.txtMallocIn.Size = new System.Drawing.Size(224, 22);
            this.txtMallocIn.TabIndex = 15;
            // 
            // txtFreeIn
            // 
            this.txtFreeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFreeIn.Location = new System.Drawing.Point(103, 301);
            this.txtFreeIn.Name = "txtFreeIn";
            this.txtFreeIn.Size = new System.Drawing.Size(224, 22);
            this.txtFreeIn.TabIndex = 16;
            // 
            // btnFunctionCall
            // 
            this.btnFunctionCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFunctionCall.Location = new System.Drawing.Point(333, 193);
            this.btnFunctionCall.Name = "btnFunctionCall";
            this.btnFunctionCall.Size = new System.Drawing.Size(94, 29);
            this.btnFunctionCall.TabIndex = 23;
            this.btnFunctionCall.Text = "Call";
            this.btnFunctionCall.UseVisualStyleBackColor = true;
            // 
            // btnFunctionEnd
            // 
            this.btnFunctionEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFunctionEnd.Location = new System.Drawing.Point(333, 228);
            this.btnFunctionEnd.Name = "btnFunctionEnd";
            this.btnFunctionEnd.Size = new System.Drawing.Size(94, 29);
            this.btnFunctionEnd.TabIndex = 24;
            this.btnFunctionEnd.Text = "End";
            this.btnFunctionEnd.UseVisualStyleBackColor = true;
            // 
            // btnMalloc
            // 
            this.btnMalloc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMalloc.Location = new System.Drawing.Point(333, 263);
            this.btnMalloc.Name = "btnMalloc";
            this.btnMalloc.Size = new System.Drawing.Size(94, 29);
            this.btnMalloc.TabIndex = 25;
            this.btnMalloc.Text = "Malloc";
            this.btnMalloc.UseVisualStyleBackColor = true;
            // 
            // btnFree
            // 
            this.btnFree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFree.Location = new System.Drawing.Point(333, 298);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(94, 29);
            this.btnFree.TabIndex = 26;
            this.btnFree.Text = "Free";
            this.btnFree.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(103, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(224, 35);
            this.label25.TabIndex = 22;
            this.label25.Text = "Size (Bytes)";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(3, 85);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(94, 35);
            this.lable.TabIndex = 21;
            this.lable.Text = "Name";
            this.lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 330);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 35);
            this.label19.TabIndex = 11;
            this.label19.Text = "Script";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(333, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 35);
            this.label20.TabIndex = 31;
            this.label20.Text = "Process _";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTerminateProcess
            // 
            this.btnTerminateProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTerminateProcess.Location = new System.Drawing.Point(208, 3);
            this.btnTerminateProcess.Name = "btnTerminateProcess";
            this.tableLayoutPanel2.SetRowSpan(this.btnTerminateProcess, 4);
            this.btnTerminateProcess.Size = new System.Drawing.Size(97, 96);
            this.btnTerminateProcess.TabIndex = 4;
            this.btnTerminateProcess.Text = "Terminate Process";
            this.btnTerminateProcess.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tlpPhysicalMemoryLayout.SetColumnSpan(this.tableLayoutPanel6, 5);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblPageSizeOut, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lblMemoryUsedOut, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.lblPageCountOut, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblMemorySizeOut, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.pbMemoryUsed, 0, 5);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(317, 208);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // lblPageSizeOut
            // 
            this.lblPageSizeOut.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lblPageSizeOut, 2);
            this.lblPageSizeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageSizeOut.Location = new System.Drawing.Point(3, 105);
            this.lblPageSizeOut.Name = "lblPageSizeOut";
            this.lblPageSizeOut.Size = new System.Drawing.Size(311, 35);
            this.lblPageSizeOut.TabIndex = 0;
            this.lblPageSizeOut.Text = "Page Size";
            this.lblPageSizeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMemoryUsedOut
            // 
            this.lblMemoryUsedOut.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lblMemoryUsedOut, 2);
            this.lblMemoryUsedOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMemoryUsedOut.Location = new System.Drawing.Point(3, 140);
            this.lblMemoryUsedOut.Name = "lblMemoryUsedOut";
            this.lblMemoryUsedOut.Size = new System.Drawing.Size(311, 35);
            this.lblMemoryUsedOut.TabIndex = 1;
            this.lblMemoryUsedOut.Text = "Memory Used";
            this.lblMemoryUsedOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPageCountOut
            // 
            this.lblPageCountOut.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lblPageCountOut, 2);
            this.lblPageCountOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageCountOut.Location = new System.Drawing.Point(3, 70);
            this.lblPageCountOut.Name = "lblPageCountOut";
            this.lblPageCountOut.Size = new System.Drawing.Size(311, 35);
            this.lblPageCountOut.TabIndex = 2;
            this.lblPageCountOut.Text = "Page Count";
            this.lblPageCountOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMemorySizeOut
            // 
            this.lblMemorySizeOut.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lblMemorySizeOut, 2);
            this.lblMemorySizeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMemorySizeOut.Location = new System.Drawing.Point(3, 35);
            this.lblMemorySizeOut.Name = "lblMemorySizeOut";
            this.lblMemorySizeOut.Size = new System.Drawing.Size(311, 35);
            this.lblMemorySizeOut.TabIndex = 3;
            this.lblMemorySizeOut.Text = "Memory Size";
            this.lblMemorySizeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.label26, 2);
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(311, 35);
            this.label26.TabIndex = 4;
            this.label26.Text = "Physical Memory";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMemoryUsed
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.pbMemoryUsed, 2);
            this.pbMemoryUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMemoryUsed.Location = new System.Drawing.Point(3, 178);
            this.pbMemoryUsed.Name = "pbMemoryUsed";
            this.pbMemoryUsed.Size = new System.Drawing.Size(311, 29);
            this.pbMemoryUsed.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 190);
            this.label15.Name = "label15";
            this.tableLayoutPanel5.SetRowSpan(this.label15, 2);
            this.label15.Size = new System.Drawing.Size(94, 70);
            this.label15.TabIndex = 32;
            this.label15.Text = "Function (Stack)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(3, 260);
            this.label27.Name = "label27";
            this.tableLayoutPanel5.SetRowSpan(this.label27, 2);
            this.label27.Size = new System.Drawing.Size(94, 70);
            this.label27.TabIndex = 33;
            this.label27.Text = "Memory Allocation (Heap)";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 625);
            this.Controls.Add(this.tlpMain);
            this.Name = "MemoryManagerView";
            this.Text = "Memory Management Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpPhysicalMemoryLayout.ResumeLayout(false);
            this.tlpPhysicalMemoryLayout.PerformLayout();
            this.tlpProcessLayout.ResumeLayout(false);
            this.tlpProcessPageTable.ResumeLayout(false);
            this.tlpProcessPageTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpPhysicalMemoryLayout;
        private System.Windows.Forms.Label lblPhysicalMemoryFrame;
        private System.Windows.Forms.Label lblPhysicalMemoryPID;
        private System.Windows.Forms.Label lblPhysicalMemorySegment;
        private System.Windows.Forms.Label lblPhysicalMemoryPage;
        private System.Windows.Forms.VScrollBar scrollbarPhysicalMemory;
        private System.Windows.Forms.TableLayoutPanel tlpProcessLayout;
        private System.Windows.Forms.TableLayoutPanel tlpProcessPageTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar scrollBarPageTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPreviousProcess;
        private System.Windows.Forms.Button btnNextProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblProcessTextOut;
        private System.Windows.Forms.Label lblProcessDataOut;
        private System.Windows.Forms.Label lblProcessStackOut;
        private System.Windows.Forms.Label lblProcessHeapOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnStartComputer;
        private System.Windows.Forms.Button btnRestartComputer;
        private System.Windows.Forms.Button btnDestroyComputer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbVirtualMemoryEnable;
        private System.Windows.Forms.TextBox txtPageSizeIn;
        private System.Windows.Forms.TextBox txtPhysicalMemoryIn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblComputerInputFeedback;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTextSizeIn;
        private System.Windows.Forms.TextBox txtDataSizeIn;
        private System.Windows.Forms.Button btnSpawnProcess;
        private System.Windows.Forms.Button btnSubmitCommand;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCommandIn;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtScriptIn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFunctionDataCall;
        private System.Windows.Forms.TextBox txtFunctionDataEnd;
        private System.Windows.Forms.TextBox txtMallocIn;
        private System.Windows.Forms.TextBox txtFreeIn;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnFunctionCall;
        private System.Windows.Forms.Button btnFunctionEnd;
        private System.Windows.Forms.Button btnMalloc;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnTerminateProcess;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblPageSizeOut;
        private System.Windows.Forms.Label lblMemoryUsedOut;
        private System.Windows.Forms.Label lblPageCountOut;
        private System.Windows.Forms.Label lblMemorySizeOut;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ProgressBar pbMemoryUsed;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label15;
    }
}

