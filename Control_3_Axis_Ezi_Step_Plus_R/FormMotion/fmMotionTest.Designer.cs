namespace Control_3_Axis_Ezi_Step_Plus_R.FormMotion
{
    partial class fmMotionTest
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetAlarmX = new System.Windows.Forms.Button();
            this.btnMoveOriginX = new System.Windows.Forms.Button();
            this.btnMoveX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPositionX = new System.Windows.Forms.TextBox();
            this.btnJogXminus = new System.Windows.Forms.Button();
            this.btnJogXplus = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetAlarmY = new System.Windows.Forms.Button();
            this.btnMoveOriginY = new System.Windows.Forms.Button();
            this.btnMoveY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPositionY = new System.Windows.Forms.TextBox();
            this.btnJogYminus = new System.Windows.Forms.Button();
            this.btnJogYplus = new System.Windows.Forms.Button();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetAlarmZ = new System.Windows.Forms.Button();
            this.btnMoveOriginZ = new System.Windows.Forms.Button();
            this.btnMoveZ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPositionZ = new System.Windows.Forms.TextBox();
            this.btnJogZminus = new System.Windows.Forms.Button();
            this.btnJogZplus = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosY = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnMotionConvex = new System.Windows.Forms.Button();
            this.btnMotionConcave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.btnResetAlarmX);
            this.groupControl1.Controls.Add(this.btnMoveOriginX);
            this.groupControl1.Controls.Add(this.btnMoveX);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtPositionX);
            this.groupControl1.Controls.Add(this.btnJogXminus);
            this.groupControl1.Controls.Add(this.btnJogXplus);
            this.groupControl1.Location = new System.Drawing.Point(12, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(253, 178);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "JOG Move X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(mm)";
            // 
            // btnResetAlarmX
            // 
            this.btnResetAlarmX.Location = new System.Drawing.Point(146, 138);
            this.btnResetAlarmX.Name = "btnResetAlarmX";
            this.btnResetAlarmX.Size = new System.Drawing.Size(88, 25);
            this.btnResetAlarmX.TabIndex = 4;
            this.btnResetAlarmX.Text = "Reset alarm";
            this.btnResetAlarmX.UseVisualStyleBackColor = true;
            this.btnResetAlarmX.Click += new System.EventHandler(this.btnResetAlarmX_Click);
            // 
            // btnMoveOriginX
            // 
            this.btnMoveOriginX.Location = new System.Drawing.Point(18, 138);
            this.btnMoveOriginX.Name = "btnMoveOriginX";
            this.btnMoveOriginX.Size = new System.Drawing.Size(88, 25);
            this.btnMoveOriginX.TabIndex = 4;
            this.btnMoveOriginX.Text = "Move Origin";
            this.btnMoveOriginX.UseVisualStyleBackColor = true;
            this.btnMoveOriginX.Click += new System.EventHandler(this.btnMoveOriginX_Click);
            // 
            // btnMoveX
            // 
            this.btnMoveX.Location = new System.Drawing.Point(191, 36);
            this.btnMoveX.Name = "btnMoveX";
            this.btnMoveX.Size = new System.Drawing.Size(57, 23);
            this.btnMoveX.TabIndex = 3;
            this.btnMoveX.Text = "Move";
            this.btnMoveX.UseVisualStyleBackColor = true;
            this.btnMoveX.Click += new System.EventHandler(this.btnMoveX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position X:";
            // 
            // txtPositionX
            // 
            this.txtPositionX.Location = new System.Drawing.Point(78, 38);
            this.txtPositionX.Name = "txtPositionX";
            this.txtPositionX.Size = new System.Drawing.Size(75, 21);
            this.txtPositionX.TabIndex = 1;
            this.txtPositionX.Text = "0.000";
            this.txtPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnJogXminus
            // 
            this.btnJogXminus.Location = new System.Drawing.Point(146, 85);
            this.btnJogXminus.Name = "btnJogXminus";
            this.btnJogXminus.Size = new System.Drawing.Size(88, 31);
            this.btnJogXminus.TabIndex = 0;
            this.btnJogXminus.Text = "JOG X-";
            this.btnJogXminus.UseVisualStyleBackColor = true;
            this.btnJogXminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXminus_MouseDown);
            this.btnJogXminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // btnJogXplus
            // 
            this.btnJogXplus.Location = new System.Drawing.Point(18, 85);
            this.btnJogXplus.Name = "btnJogXplus";
            this.btnJogXplus.Size = new System.Drawing.Size(88, 31);
            this.btnJogXplus.TabIndex = 0;
            this.btnJogXplus.Text = "JOG X+";
            this.btnJogXplus.UseVisualStyleBackColor = true;
            this.btnJogXplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXplus_MouseDown);
            this.btnJogXplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.btnResetAlarmY);
            this.groupControl2.Controls.Add(this.btnMoveOriginY);
            this.groupControl2.Controls.Add(this.btnMoveY);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtPositionY);
            this.groupControl2.Controls.Add(this.btnJogYminus);
            this.groupControl2.Controls.Add(this.btnJogYplus);
            this.groupControl2.Location = new System.Drawing.Point(297, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(253, 178);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "JOG Move Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "(mm)";
            // 
            // btnResetAlarmY
            // 
            this.btnResetAlarmY.Location = new System.Drawing.Point(148, 138);
            this.btnResetAlarmY.Name = "btnResetAlarmY";
            this.btnResetAlarmY.Size = new System.Drawing.Size(88, 25);
            this.btnResetAlarmY.TabIndex = 4;
            this.btnResetAlarmY.Text = "Reset alarm";
            this.btnResetAlarmY.UseVisualStyleBackColor = true;
            this.btnResetAlarmY.Click += new System.EventHandler(this.btnResetAlarmY_Click);
            // 
            // btnMoveOriginY
            // 
            this.btnMoveOriginY.Location = new System.Drawing.Point(20, 138);
            this.btnMoveOriginY.Name = "btnMoveOriginY";
            this.btnMoveOriginY.Size = new System.Drawing.Size(88, 25);
            this.btnMoveOriginY.TabIndex = 4;
            this.btnMoveOriginY.Text = "Move Origin";
            this.btnMoveOriginY.UseVisualStyleBackColor = true;
            this.btnMoveOriginY.Click += new System.EventHandler(this.btnMoveOriginY_Click);
            // 
            // btnMoveY
            // 
            this.btnMoveY.Location = new System.Drawing.Point(196, 36);
            this.btnMoveY.Name = "btnMoveY";
            this.btnMoveY.Size = new System.Drawing.Size(52, 23);
            this.btnMoveY.TabIndex = 3;
            this.btnMoveY.Text = "Move";
            this.btnMoveY.UseVisualStyleBackColor = true;
            this.btnMoveY.Click += new System.EventHandler(this.btnMoveY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position Y:";
            // 
            // txtPositionY
            // 
            this.txtPositionY.Location = new System.Drawing.Point(78, 38);
            this.txtPositionY.Name = "txtPositionY";
            this.txtPositionY.Size = new System.Drawing.Size(75, 21);
            this.txtPositionY.TabIndex = 1;
            this.txtPositionY.Text = "0.000";
            this.txtPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnJogYminus
            // 
            this.btnJogYminus.Location = new System.Drawing.Point(148, 85);
            this.btnJogYminus.Name = "btnJogYminus";
            this.btnJogYminus.Size = new System.Drawing.Size(88, 31);
            this.btnJogYminus.TabIndex = 0;
            this.btnJogYminus.Text = "JOG Y-";
            this.btnJogYminus.UseVisualStyleBackColor = true;
            this.btnJogYminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogYminus_MouseDown);
            this.btnJogYminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // btnJogYplus
            // 
            this.btnJogYplus.Location = new System.Drawing.Point(20, 85);
            this.btnJogYplus.Name = "btnJogYplus";
            this.btnJogYplus.Size = new System.Drawing.Size(88, 31);
            this.btnJogYplus.TabIndex = 0;
            this.btnJogYplus.Text = "JOG Y+";
            this.btnJogYplus.UseVisualStyleBackColor = true;
            this.btnJogYplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogYplus_MouseDown);
            this.btnJogYplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Controls.Add(this.btnResetAlarmZ);
            this.groupControl3.Controls.Add(this.btnMoveOriginZ);
            this.groupControl3.Controls.Add(this.btnMoveZ);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.txtPositionZ);
            this.groupControl3.Controls.Add(this.btnJogZminus);
            this.groupControl3.Controls.Add(this.btnJogZplus);
            this.groupControl3.Location = new System.Drawing.Point(572, 13);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(253, 178);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "JOG Move Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "(mm)";
            // 
            // btnResetAlarmZ
            // 
            this.btnResetAlarmZ.Location = new System.Drawing.Point(149, 138);
            this.btnResetAlarmZ.Name = "btnResetAlarmZ";
            this.btnResetAlarmZ.Size = new System.Drawing.Size(88, 25);
            this.btnResetAlarmZ.TabIndex = 4;
            this.btnResetAlarmZ.Text = "Reset alarm";
            this.btnResetAlarmZ.UseVisualStyleBackColor = true;
            this.btnResetAlarmZ.Click += new System.EventHandler(this.btnResetAlarmZ_Click);
            // 
            // btnMoveOriginZ
            // 
            this.btnMoveOriginZ.Location = new System.Drawing.Point(21, 138);
            this.btnMoveOriginZ.Name = "btnMoveOriginZ";
            this.btnMoveOriginZ.Size = new System.Drawing.Size(88, 25);
            this.btnMoveOriginZ.TabIndex = 4;
            this.btnMoveOriginZ.Text = "Move Origin";
            this.btnMoveOriginZ.UseVisualStyleBackColor = true;
            this.btnMoveOriginZ.Click += new System.EventHandler(this.btnMoveOriginZ_Click);
            // 
            // btnMoveZ
            // 
            this.btnMoveZ.Location = new System.Drawing.Point(189, 36);
            this.btnMoveZ.Name = "btnMoveZ";
            this.btnMoveZ.Size = new System.Drawing.Size(59, 23);
            this.btnMoveZ.TabIndex = 3;
            this.btnMoveZ.Text = "Move";
            this.btnMoveZ.UseVisualStyleBackColor = true;
            this.btnMoveZ.Click += new System.EventHandler(this.btnMoveZ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position Z:";
            // 
            // txtPositionZ
            // 
            this.txtPositionZ.Location = new System.Drawing.Point(78, 38);
            this.txtPositionZ.Name = "txtPositionZ";
            this.txtPositionZ.Size = new System.Drawing.Size(62, 21);
            this.txtPositionZ.TabIndex = 1;
            this.txtPositionZ.Text = "0.000";
            this.txtPositionZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnJogZminus
            // 
            this.btnJogZminus.Location = new System.Drawing.Point(149, 85);
            this.btnJogZminus.Name = "btnJogZminus";
            this.btnJogZminus.Size = new System.Drawing.Size(88, 31);
            this.btnJogZminus.TabIndex = 0;
            this.btnJogZminus.Text = "JOG Z-";
            this.btnJogZminus.UseVisualStyleBackColor = true;
            this.btnJogZminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogZminus_MouseDown);
            this.btnJogZminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // btnJogZplus
            // 
            this.btnJogZplus.Location = new System.Drawing.Point(21, 85);
            this.btnJogZplus.Name = "btnJogZplus";
            this.btnJogZplus.Size = new System.Drawing.Size(88, 31);
            this.btnJogZplus.TabIndex = 0;
            this.btnJogZplus.Text = "JOG Z+";
            this.btnJogZplus.UseVisualStyleBackColor = true;
            this.btnJogZplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogZplus_MouseDown);
            this.btnJogZplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPosX,
            this.tslPosY,
            this.tslPosZ});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 24);
            this.statusStrip1.TabIndex = 2;
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
            // btnMotionConvex
            // 
            this.btnMotionConvex.Location = new System.Drawing.Point(12, 207);
            this.btnMotionConvex.Name = "btnMotionConvex";
            this.btnMotionConvex.Size = new System.Drawing.Size(285, 23);
            this.btnMotionConvex.TabIndex = 7;
            this.btnMotionConvex.Text = "Motion Test Point Bending Convex";
            this.btnMotionConvex.UseVisualStyleBackColor = true;
            this.btnMotionConvex.Click += new System.EventHandler(this.btnMotionConvex_Click);
            // 
            // btnMotionConcave
            // 
            this.btnMotionConcave.Location = new System.Drawing.Point(337, 207);
            this.btnMotionConcave.Name = "btnMotionConcave";
            this.btnMotionConcave.Size = new System.Drawing.Size(307, 23);
            this.btnMotionConcave.TabIndex = 8;
            this.btnMotionConcave.Text = "Motion Test Point Bending Concave";
            this.btnMotionConcave.UseVisualStyleBackColor = true;
            this.btnMotionConcave.Click += new System.EventHandler(this.btnMotionConcave_Click);
            // 
            // fmMotionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 278);
            this.Controls.Add(this.btnMotionConcave);
            this.Controls.Add(this.btnMotionConvex);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmMotionTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motion Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMotionTest_FormClosing);
            this.Load += new System.EventHandler(this.fmMotionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPositionX;
        private System.Windows.Forms.Button btnJogXminus;
        private System.Windows.Forms.Button btnJogXplus;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPositionY;
        private System.Windows.Forms.Button btnJogYminus;
        private System.Windows.Forms.Button btnJogYplus;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPositionZ;
        private System.Windows.Forms.Button btnJogZminus;
        private System.Windows.Forms.Button btnJogZplus;
        private System.Windows.Forms.Button btnMoveX;
        private System.Windows.Forms.Button btnMoveY;
        private System.Windows.Forms.Button btnMoveZ;
        private System.Windows.Forms.Button btnMoveOriginX;
        private System.Windows.Forms.Button btnResetAlarmX;
        private System.Windows.Forms.Button btnResetAlarmY;
        private System.Windows.Forms.Button btnMoveOriginY;
        private System.Windows.Forms.Button btnResetAlarmZ;
        private System.Windows.Forms.Button btnMoveOriginZ;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslPosX;
        private System.Windows.Forms.ToolStripStatusLabel tslPosY;
        private System.Windows.Forms.ToolStripStatusLabel tslPosZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMotionConvex;
        private System.Windows.Forms.Button btnMotionConcave;
    }
}