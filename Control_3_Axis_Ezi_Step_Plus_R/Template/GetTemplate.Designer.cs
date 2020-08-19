namespace Control_3_Axis_Ezi_Step_Plus_R.Template
{
    partial class GetTemplate
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
            this.pnBackground = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.pnGraphics = new System.Windows.Forms.Panel();
            this.btnGetTemplate = new System.Windows.Forms.Button();
            this.lviPointMeasurement = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosY = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnBackground.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBackground.Controls.Add(this.lblStatus);
            this.pnBackground.Controls.Add(this.lblProcess);
            this.pnBackground.Controls.Add(this.pnGraphics);
            this.pnBackground.Controls.Add(this.btnGetTemplate);
            this.pnBackground.Controls.Add(this.lviPointMeasurement);
            this.pnBackground.Controls.Add(this.statusStrip1);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(585, 555);
            this.pnBackground.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(28, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(28, 23);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "...";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(153, 13);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 23);
            this.lblProcess.TabIndex = 4;
            // 
            // pnGraphics
            // 
            this.pnGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGraphics.Location = new System.Drawing.Point(29, 50);
            this.pnGraphics.Name = "pnGraphics";
            this.pnGraphics.Size = new System.Drawing.Size(340, 420);
            this.pnGraphics.TabIndex = 3;
            // 
            // btnGetTemplate
            // 
            this.btnGetTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGetTemplate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTemplate.Location = new System.Drawing.Point(0, 493);
            this.btnGetTemplate.Name = "btnGetTemplate";
            this.btnGetTemplate.Size = new System.Drawing.Size(393, 36);
            this.btnGetTemplate.TabIndex = 0;
            this.btnGetTemplate.Text = "GET TEMPLATE";
            this.btnGetTemplate.UseVisualStyleBackColor = true;
            this.btnGetTemplate.Click += new System.EventHandler(this.btnGetTemplate_Click);
            // 
            // lviPointMeasurement
            // 
            this.lviPointMeasurement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lviPointMeasurement.Dock = System.Windows.Forms.DockStyle.Right;
            this.lviPointMeasurement.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviPointMeasurement.FullRowSelect = true;
            this.lviPointMeasurement.GridLines = true;
            this.lviPointMeasurement.Location = new System.Drawing.Point(393, 0);
            this.lviPointMeasurement.Name = "lviPointMeasurement";
            this.lviPointMeasurement.Size = new System.Drawing.Size(190, 529);
            this.lviPointMeasurement.TabIndex = 2;
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
            this.columnHeader3.Width = 157;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPosX,
            this.tslPosY,
            this.tslPosZ});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(583, 24);
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
            // GetTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 555);
            this.Controls.Add(this.pnBackground);
            this.Name = "GetTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetTemplate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetTemplate_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetTemplate_FormClosed);
            this.Load += new System.EventHandler(this.GetTemplate_Load);
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.Button btnGetTemplate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslPosX;
        private System.Windows.Forms.ToolStripStatusLabel tslPosY;
        private System.Windows.Forms.ToolStripStatusLabel tslPosZ;
        private System.Windows.Forms.ListView lviPointMeasurement;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel pnGraphics;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblStatus;
    }
}