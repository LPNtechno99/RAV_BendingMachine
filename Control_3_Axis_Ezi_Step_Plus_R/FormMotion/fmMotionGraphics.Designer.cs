namespace Control_3_Axis_Ezi_Step_Plus_R.FormMotion
{
    partial class fmMotionGraphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMotionGraphics));
            this.pnBackGround = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnGraphics = new System.Windows.Forms.Panel();
            this.lviPointMeasurement = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosY = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackGround
            // 
            this.pnBackGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBackGround.Controls.Add(this.splitContainer1);
            this.pnBackGround.Controls.Add(this.toolStrip1);
            this.pnBackGround.Controls.Add(this.statusStrip1);
            this.pnBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackGround.Location = new System.Drawing.Point(0, 0);
            this.pnBackGround.Name = "pnBackGround";
            this.pnBackGround.Size = new System.Drawing.Size(746, 552);
            this.pnBackGround.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblProcess);
            this.splitContainer1.Panel1.Controls.Add(this.lblStatus);
            this.splitContainer1.Panel1.Controls.Add(this.pnGraphics);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lviPointMeasurement);
            this.splitContainer1.Size = new System.Drawing.Size(744, 492);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(131, 14);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(16, 23);
            this.lblProcess.TabIndex = 1;
            this.lblProcess.Text = ".";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(24, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(28, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "...";
            // 
            // pnGraphics
            // 
            this.pnGraphics.ForeColor = System.Drawing.Color.White;
            this.pnGraphics.Location = new System.Drawing.Point(20, 51);
            this.pnGraphics.Name = "pnGraphics";
            this.pnGraphics.Size = new System.Drawing.Size(340, 420);
            this.pnGraphics.TabIndex = 0;
            // 
            // lviPointMeasurement
            // 
            this.lviPointMeasurement.BackColor = System.Drawing.Color.DarkGray;
            this.lviPointMeasurement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.lviPointMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviPointMeasurement.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviPointMeasurement.FullRowSelect = true;
            this.lviPointMeasurement.GridLines = true;
            this.lviPointMeasurement.Location = new System.Drawing.Point(0, 0);
            this.lviPointMeasurement.Name = "lviPointMeasurement";
            this.lviPointMeasurement.Size = new System.Drawing.Size(362, 492);
            this.lviPointMeasurement.TabIndex = 3;
            this.lviPointMeasurement.UseCompatibleStateImageBehavior = false;
            this.lviPointMeasurement.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "POINT";
            this.columnHeader2.Width = 57;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MEASUREMENT (mm)";
            this.columnHeader3.Width = 178;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DELTA";
            this.columnHeader1.Width = 111;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.toolStripSeparator1,
            this.btnStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 31);
            this.btnStart.Text = "START";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 31);
            this.btnStop.Text = "STOP";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPosX,
            this.tslPosY,
            this.tslPosZ});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslPosX
            // 
            this.tslPosX.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tslPosX.Name = "tslPosX";
            this.tslPosX.Size = new System.Drawing.Size(37, 19);
            this.tslPosX.Text = "PosX";
            // 
            // tslPosY
            // 
            this.tslPosY.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tslPosY.Name = "tslPosY";
            this.tslPosY.Size = new System.Drawing.Size(37, 19);
            this.tslPosY.Text = "PosY";
            // 
            // tslPosZ
            // 
            this.tslPosZ.Name = "tslPosZ";
            this.tslPosZ.Size = new System.Drawing.Size(33, 19);
            this.tslPosZ.Text = "PosZ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BENDING VALUE";
            // 
            // fmMotionGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 552);
            this.Controls.Add(this.pnBackGround);
            this.Name = "fmMotionGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMotionGraphics_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMotionGraphics_FormClosed);
            this.Load += new System.EventHandler(this.fmMotionGraphics_Load);
            this.pnBackGround.ResumeLayout(false);
            this.pnBackGround.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackGround;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslPosX;
        private System.Windows.Forms.ToolStripStatusLabel tslPosY;
        private System.Windows.Forms.ToolStripStatusLabel tslPosZ;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ListView lviPointMeasurement;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel pnGraphics;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}