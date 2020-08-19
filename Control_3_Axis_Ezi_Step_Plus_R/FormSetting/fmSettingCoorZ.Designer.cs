namespace Control_3_Axis_Ezi_Step_Plus_R.FormSetting
{
    partial class fmSettingCoorZ
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslPosZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnJOGminus = new System.Windows.Forms.Button();
            this.btnJOGplus = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZCoorConcave = new System.Windows.Forms.TextBox();
            this.txtZCoorConvex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbPoint = new System.Windows.Forms.ComboBox();
            this.btnMoveConvex = new System.Windows.Forms.Button();
            this.btnMoveConcave = new System.Windows.Forms.Button();
            this.radConvex = new System.Windows.Forms.RadioButton();
            this.radConcave = new System.Windows.Forms.RadioButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 260);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPosZ});
            this.statusStrip1.Location = new System.Drawing.Point(0, 238);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslPosZ
            // 
            this.tslPosZ.Name = "tslPosZ";
            this.tslPosZ.Size = new System.Drawing.Size(33, 17);
            this.tslPosZ.Text = "PosZ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnJOGminus);
            this.groupControl2.Controls.Add(this.btnJOGplus);
            this.groupControl2.Location = new System.Drawing.Point(12, 158);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(523, 64);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "JOG";
            // 
            // btnJOGminus
            // 
            this.btnJOGminus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnJOGminus.Location = new System.Drawing.Point(275, 20);
            this.btnJOGminus.Name = "btnJOGminus";
            this.btnJOGminus.Size = new System.Drawing.Size(246, 42);
            this.btnJOGminus.TabIndex = 1;
            this.btnJOGminus.Text = "JOG-";
            this.btnJOGminus.UseVisualStyleBackColor = true;
            this.btnJOGminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOGminus_MouseDown);
            this.btnJOGminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // btnJOGplus
            // 
            this.btnJOGplus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnJOGplus.Location = new System.Drawing.Point(2, 20);
            this.btnJOGplus.Name = "btnJOGplus";
            this.btnJOGplus.Size = new System.Drawing.Size(267, 42);
            this.btnJOGplus.TabIndex = 0;
            this.btnJOGplus.Text = "JOG+";
            this.btnJOGplus.UseVisualStyleBackColor = true;
            this.btnJOGplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJOGplus_MouseDown);
            this.btnJOGplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Stop);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.btnMoveConcave);
            this.groupControl1.Controls.Add(this.btnMoveConvex);
            this.groupControl1.Controls.Add(this.cbbPoint);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtZCoorConcave);
            this.groupControl1.Controls.Add(this.txtZCoorConvex);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(523, 140);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Z Coordinate Bending";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "mm";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(395, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Z Coor for Bending Concave:";
            // 
            // txtZCoorConcave
            // 
            this.txtZCoorConcave.Location = new System.Drawing.Point(252, 104);
            this.txtZCoorConcave.Name = "txtZCoorConcave";
            this.txtZCoorConcave.Size = new System.Drawing.Size(130, 21);
            this.txtZCoorConcave.TabIndex = 1;
            this.txtZCoorConcave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtZCoorConvex
            // 
            this.txtZCoorConvex.Location = new System.Drawing.Point(252, 69);
            this.txtZCoorConvex.Name = "txtZCoorConvex";
            this.txtZCoorConvex.Size = new System.Drawing.Size(130, 21);
            this.txtZCoorConvex.TabIndex = 0;
            this.txtZCoorConvex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Z Coor for Bending Convex:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Point:";
            // 
            // cbbPoint
            // 
            this.cbbPoint.FormattingEnabled = true;
            this.cbbPoint.Location = new System.Drawing.Point(252, 29);
            this.cbbPoint.Name = "cbbPoint";
            this.cbbPoint.Size = new System.Drawing.Size(130, 21);
            this.cbbPoint.TabIndex = 4;
            this.cbbPoint.SelectedIndexChanged += new System.EventHandler(this.cbbPoint_SelectedIndexChanged);
            // 
            // btnMoveConvex
            // 
            this.btnMoveConvex.Location = new System.Drawing.Point(422, 67);
            this.btnMoveConvex.Name = "btnMoveConvex";
            this.btnMoveConvex.Size = new System.Drawing.Size(88, 23);
            this.btnMoveConvex.TabIndex = 5;
            this.btnMoveConvex.Text = "Move convex";
            this.btnMoveConvex.UseVisualStyleBackColor = true;
            this.btnMoveConvex.Click += new System.EventHandler(this.btnMoveConvex_Click);
            // 
            // btnMoveConcave
            // 
            this.btnMoveConcave.Location = new System.Drawing.Point(422, 102);
            this.btnMoveConcave.Name = "btnMoveConcave";
            this.btnMoveConcave.Size = new System.Drawing.Size(88, 23);
            this.btnMoveConcave.TabIndex = 5;
            this.btnMoveConcave.Text = "Move concave";
            this.btnMoveConcave.UseVisualStyleBackColor = true;
            this.btnMoveConcave.Click += new System.EventHandler(this.btnMoveConcave_Click);
            // 
            // radConvex
            // 
            this.radConvex.AutoSize = true;
            this.radConvex.Checked = true;
            this.radConvex.Location = new System.Drawing.Point(9, 28);
            this.radConvex.Name = "radConvex";
            this.radConvex.Size = new System.Drawing.Size(62, 17);
            this.radConvex.TabIndex = 6;
            this.radConvex.TabStop = true;
            this.radConvex.Text = "Convex";
            this.radConvex.UseVisualStyleBackColor = true;
            this.radConvex.CheckedChanged += new System.EventHandler(this.radConvex_CheckedChanged);
            // 
            // radConcave
            // 
            this.radConcave.AutoSize = true;
            this.radConcave.Location = new System.Drawing.Point(9, 73);
            this.radConcave.Name = "radConcave";
            this.radConcave.Size = new System.Drawing.Size(67, 17);
            this.radConcave.TabIndex = 6;
            this.radConcave.Text = "Concave";
            this.radConcave.UseVisualStyleBackColor = true;
            this.radConcave.CheckedChanged += new System.EventHandler(this.radConcave_CheckedChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.radConvex);
            this.groupControl3.Controls.Add(this.radConcave);
            this.groupControl3.Location = new System.Drawing.Point(5, 29);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(93, 106);
            this.groupControl3.TabIndex = 7;
            // 
            // fmSettingCoorZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 260);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmSettingCoorZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Coordinate Z";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmSettingCoorZ_FormClosing);
            this.Load += new System.EventHandler(this.fmSettingCoorZ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtZCoorConvex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZCoorConcave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslPosZ;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnJOGminus;
        private System.Windows.Forms.Button btnJOGplus;
        private System.Windows.Forms.Button btnMoveConcave;
        private System.Windows.Forms.Button btnMoveConvex;
        private System.Windows.Forms.ComboBox cbbPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radConcave;
        private System.Windows.Forms.RadioButton radConvex;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}