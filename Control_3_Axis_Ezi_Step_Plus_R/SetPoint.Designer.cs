namespace Control_3_Axis_Ezi_Step_Plus_R
{
    partial class SetPoint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPoint));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpPoint = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoorY = new System.Windows.Forms.Label();
            this.lblCoorX = new System.Windows.Forms.Label();
            this.btnJogY_Back = new DevExpress.XtraEditors.SimpleButton();
            this.btnJogX_Back = new DevExpress.XtraEditors.SimpleButton();
            this.btnJogY_Up = new DevExpress.XtraEditors.SimpleButton();
            this.btnJogX_Up = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslMeasurement = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnJogZ_Plus = new DevExpress.XtraEditors.SimpleButton();
            this.btnJogZ_Minus = new DevExpress.XtraEditors.SimpleButton();
            this.lblCoorZ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPoint)).BeginInit();
            this.grpPoint.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpPoint, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 217);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // grpPoint
            // 
            this.grpPoint.Appearance.BackColor = System.Drawing.Color.White;
            this.grpPoint.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPoint.Appearance.Options.UseBackColor = true;
            this.grpPoint.Appearance.Options.UseBorderColor = true;
            this.grpPoint.Appearance.Options.UseFont = true;
            this.grpPoint.Appearance.Options.UseForeColor = true;
            this.grpPoint.Appearance.Options.UseTextOptions = true;
            this.grpPoint.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpPoint.CaptionImageOptions.Image")));
            this.grpPoint.Controls.Add(this.label2);
            this.grpPoint.Controls.Add(this.label4);
            this.grpPoint.Controls.Add(this.label1);
            this.grpPoint.Controls.Add(this.lblCoorZ);
            this.grpPoint.Controls.Add(this.lblCoorY);
            this.grpPoint.Controls.Add(this.btnJogZ_Minus);
            this.grpPoint.Controls.Add(this.lblCoorX);
            this.grpPoint.Controls.Add(this.btnJogY_Back);
            this.grpPoint.Controls.Add(this.btnJogZ_Plus);
            this.grpPoint.Controls.Add(this.btnJogX_Back);
            this.grpPoint.Controls.Add(this.btnJogY_Up);
            this.grpPoint.Controls.Add(this.btnJogX_Up);
            this.grpPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPoint.Location = new System.Drawing.Point(3, 3);
            this.grpPoint.Name = "grpPoint";
            this.grpPoint.Size = new System.Drawing.Size(711, 145);
            this.grpPoint.TabIndex = 0;
            this.grpPoint.Text = "Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "(mm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "(mm)";
            // 
            // lblCoorY
            // 
            this.lblCoorY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoorY.Location = new System.Drawing.Point(242, 43);
            this.lblCoorY.Name = "lblCoorY";
            this.lblCoorY.Size = new System.Drawing.Size(167, 24);
            this.lblCoorY.TabIndex = 1;
            this.lblCoorY.Text = "0";
            this.lblCoorY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoorX
            // 
            this.lblCoorX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoorX.Location = new System.Drawing.Point(17, 43);
            this.lblCoorX.Name = "lblCoorX";
            this.lblCoorX.Size = new System.Drawing.Size(167, 24);
            this.lblCoorX.TabIndex = 1;
            this.lblCoorX.Text = "0";
            this.lblCoorX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogY_Back
            // 
            this.btnJogY_Back.Location = new System.Drawing.Point(343, 90);
            this.btnJogY_Back.Name = "btnJogY_Back";
            this.btnJogY_Back.Size = new System.Drawing.Size(94, 31);
            this.btnJogY_Back.TabIndex = 0;
            this.btnJogY_Back.Text = "JOG Y-";
            this.btnJogY_Back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogY_Back_MouseDown);
            this.btnJogY_Back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // btnJogX_Back
            // 
            this.btnJogX_Back.Location = new System.Drawing.Point(121, 90);
            this.btnJogX_Back.Name = "btnJogX_Back";
            this.btnJogX_Back.Size = new System.Drawing.Size(97, 31);
            this.btnJogX_Back.TabIndex = 0;
            this.btnJogX_Back.Text = "JOG X-";
            this.btnJogX_Back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogX_Back_MouseDown);
            this.btnJogX_Back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // btnJogY_Up
            // 
            this.btnJogY_Up.Location = new System.Drawing.Point(242, 90);
            this.btnJogY_Up.Name = "btnJogY_Up";
            this.btnJogY_Up.Size = new System.Drawing.Size(95, 31);
            this.btnJogY_Up.TabIndex = 0;
            this.btnJogY_Up.Text = "JOG Y+";
            this.btnJogY_Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogY_Up_MouseDown);
            this.btnJogY_Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // btnJogX_Up
            // 
            this.btnJogX_Up.Location = new System.Drawing.Point(20, 90);
            this.btnJogX_Up.Name = "btnJogX_Up";
            this.btnJogX_Up.Size = new System.Drawing.Size(95, 31);
            this.btnJogX_Up.TabIndex = 0;
            this.btnJogX_Up.Text = "JOG X+";
            this.btnJogX_Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogX_Up_MouseDown);
            this.btnJogX_Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(366, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(345, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(360, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslMeasurement});
            this.statusStrip1.Location = new System.Drawing.Point(0, 195);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(717, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "Measurement Value:";
            // 
            // tslMeasurement
            // 
            this.tslMeasurement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslMeasurement.ForeColor = System.Drawing.Color.Black;
            this.tslMeasurement.Name = "tslMeasurement";
            this.tslMeasurement.Size = new System.Drawing.Size(16, 17);
            this.tslMeasurement.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // btnJogZ_Plus
            // 
            this.btnJogZ_Plus.Location = new System.Drawing.Point(479, 90);
            this.btnJogZ_Plus.Name = "btnJogZ_Plus";
            this.btnJogZ_Plus.Size = new System.Drawing.Size(95, 31);
            this.btnJogZ_Plus.TabIndex = 0;
            this.btnJogZ_Plus.Text = "JOG Z+";
            this.btnJogZ_Plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogZ_Plus_MouseDown);
            this.btnJogZ_Plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // btnJogZ_Minus
            // 
            this.btnJogZ_Minus.Location = new System.Drawing.Point(580, 90);
            this.btnJogZ_Minus.Name = "btnJogZ_Minus";
            this.btnJogZ_Minus.Size = new System.Drawing.Size(94, 31);
            this.btnJogZ_Minus.TabIndex = 0;
            this.btnJogZ_Minus.Text = "JOG Z-";
            this.btnJogZ_Minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogZ_Minus_MouseDown);
            this.btnJogZ_Minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // lblCoorZ
            // 
            this.lblCoorZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoorZ.Location = new System.Drawing.Point(479, 43);
            this.lblCoorZ.Name = "lblCoorZ";
            this.lblCoorZ.Size = new System.Drawing.Size(167, 24);
            this.lblCoorZ.TabIndex = 1;
            this.lblCoorZ.Text = "0";
            this.lblCoorZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "(mm)";
            // 
            // SetPoint
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 217);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Default Point Measurement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetPoint_FormClosing);
            this.Load += new System.EventHandler(this.SetPoint_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPoint)).EndInit();
            this.grpPoint.ResumeLayout(false);
            this.grpPoint.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnJogY_Back;
        private DevExpress.XtraEditors.SimpleButton btnJogX_Back;
        private DevExpress.XtraEditors.SimpleButton btnJogY_Up;
        private DevExpress.XtraEditors.SimpleButton btnJogX_Up;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label lblCoorY;
        private System.Windows.Forms.Label lblCoorX;
        public DevExpress.XtraEditors.GroupControl grpPoint;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslMeasurement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCoorZ;
        private DevExpress.XtraEditors.SimpleButton btnJogZ_Minus;
        private DevExpress.XtraEditors.SimpleButton btnJogZ_Plus;
    }
}