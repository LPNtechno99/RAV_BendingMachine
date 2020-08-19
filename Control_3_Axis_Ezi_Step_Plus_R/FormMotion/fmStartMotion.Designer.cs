namespace Control_3_Axis_Ezi_Step_Plus_R.FormMotion
{
    partial class fmStartMotion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tpnPoints = new System.Windows.Forms.TableLayoutPanel();
            this.lviPointMeasurement = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosY = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus,
            this.tslPosX,
            this.tslPosY,
            this.tslPosZ});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tpnPoints);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lviPointMeasurement);
            this.splitContainer1.Size = new System.Drawing.Size(944, 446);
            this.splitContainer1.SplitterDistance = 568;
            this.splitContainer1.TabIndex = 1;
            // 
            // tpnPoints
            // 
            this.tpnPoints.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tpnPoints.ColumnCount = 4;
            this.tpnPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnPoints.Location = new System.Drawing.Point(0, 0);
            this.tpnPoints.Name = "tpnPoints";
            this.tpnPoints.RowCount = 6;
            this.tpnPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnPoints.Size = new System.Drawing.Size(568, 446);
            this.tpnPoints.TabIndex = 0;
            // 
            // lviPointMeasurement
            // 
            this.lviPointMeasurement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lviPointMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviPointMeasurement.FullRowSelect = true;
            this.lviPointMeasurement.GridLines = true;
            this.lviPointMeasurement.Location = new System.Drawing.Point(0, 0);
            this.lviPointMeasurement.Name = "lviPointMeasurement";
            this.lviPointMeasurement.Size = new System.Drawing.Size(372, 446);
            this.lviPointMeasurement.TabIndex = 0;
            this.lviPointMeasurement.UseCompatibleStateImageBehavior = false;
            this.lviPointMeasurement.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Point";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Measurement(mm)";
            this.columnHeader3.Width = 157;
            // 
            // tsStatus
            // 
            this.tsStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(43, 19);
            this.tsStatus.Text = "Status";
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
            this.tslPosZ.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tslPosZ.Name = "tslPosZ";
            this.tslPosZ.Size = new System.Drawing.Size(37, 19);
            this.tslPosZ.Text = "PosZ";
            // 
            // fmStartMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fmStartMotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Motion";
            this.Load += new System.EventHandler(this.fmStartMotion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tpnPoints;
        private System.Windows.Forms.ListView lviPointMeasurement;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslPosX;
        private System.Windows.Forms.ToolStripStatusLabel tslPosY;
        private System.Windows.Forms.ToolStripStatusLabel tslPosZ;
    }
}