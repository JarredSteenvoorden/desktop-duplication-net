namespace DesktopDuplication.Demo
{
    partial class FormDemo
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
            this.lblFps = new System.Windows.Forms.Label();
            this.ckbUpdateInput = new System.Windows.Forms.CheckBox();
            this.ckbLimitFps = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtTargetPosX = new System.Windows.Forms.TextBox();
            this.txtTargetPosY = new System.Windows.Forms.TextBox();
            this.txtTargetPosWidth = new System.Windows.Forms.TextBox();
            this.txtTargetPosHeight = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.ckbInvert = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbBlur = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(9, 487);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(44, 13);
            this.lblFps.TabIndex = 3;
            this.lblFps.Text = "XX FPS";
            // 
            // ckbUpdateInput
            // 
            this.ckbUpdateInput.AutoSize = true;
            this.ckbUpdateInput.Checked = true;
            this.ckbUpdateInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUpdateInput.Location = new System.Drawing.Point(314, 487);
            this.ckbUpdateInput.Name = "ckbUpdateInput";
            this.ckbUpdateInput.Size = new System.Drawing.Size(134, 17);
            this.ckbUpdateInput.TabIndex = 4;
            this.ckbUpdateInput.Text = "Update Preview Image";
            this.ckbUpdateInput.UseVisualStyleBackColor = true;
            // 
            // ckbLimitFps
            // 
            this.ckbLimitFps.AutoSize = true;
            this.ckbLimitFps.Checked = true;
            this.ckbLimitFps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLimitFps.Location = new System.Drawing.Point(454, 487);
            this.ckbLimitFps.Name = "ckbLimitFps";
            this.ckbLimitFps.Size = new System.Drawing.Size(70, 17);
            this.ckbLimitFps.TabIndex = 5;
            this.ckbLimitFps.Text = "Limit FPS";
            this.ckbLimitFps.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 193);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(512, 288);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // txtTargetPosX
            // 
            this.txtTargetPosX.Location = new System.Drawing.Point(92, 20);
            this.txtTargetPosX.Name = "txtTargetPosX";
            this.txtTargetPosX.Size = new System.Drawing.Size(40, 20);
            this.txtTargetPosX.TabIndex = 7;
            this.txtTargetPosX.Text = "100";
            // 
            // txtTargetPosY
            // 
            this.txtTargetPosY.Location = new System.Drawing.Point(138, 20);
            this.txtTargetPosY.Name = "txtTargetPosY";
            this.txtTargetPosY.Size = new System.Drawing.Size(40, 20);
            this.txtTargetPosY.TabIndex = 8;
            this.txtTargetPosY.Text = "300";
            // 
            // txtTargetPosWidth
            // 
            this.txtTargetPosWidth.Location = new System.Drawing.Point(92, 46);
            this.txtTargetPosWidth.Name = "txtTargetPosWidth";
            this.txtTargetPosWidth.Size = new System.Drawing.Size(40, 20);
            this.txtTargetPosWidth.TabIndex = 9;
            this.txtTargetPosWidth.Text = "200";
            // 
            // txtTargetPosHeight
            // 
            this.txtTargetPosHeight.Location = new System.Drawing.Point(138, 46);
            this.txtTargetPosHeight.Name = "txtTargetPosHeight";
            this.txtTargetPosHeight.Size = new System.Drawing.Size(40, 20);
            this.txtTargetPosHeight.TabIndex = 10;
            this.txtTargetPosHeight.Text = "100";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 117);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 20);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "1000 / 1000";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(133, 16);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(40, 20);
            this.txtThreshold.TabIndex = 12;
            this.txtThreshold.Text = "100";
            // 
            // ckbInvert
            // 
            this.ckbInvert.AutoSize = true;
            this.ckbInvert.Checked = true;
            this.ckbInvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbInvert.Location = new System.Drawing.Point(9, 19);
            this.ckbInvert.Name = "ckbInvert";
            this.ckbInvert.Size = new System.Drawing.Size(53, 17);
            this.ckbInvert.TabIndex = 13;
            this.ckbInvert.Text = "Invert";
            this.ckbInvert.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbBlur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtThreshold);
            this.groupBox1.Controls.Add(this.ckbInvert);
            this.groupBox1.Location = new System.Drawing.Point(230, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 77);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre Processing";
            // 
            // ckbBlur
            // 
            this.ckbBlur.AutoSize = true;
            this.ckbBlur.Checked = true;
            this.ckbBlur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbBlur.Location = new System.Drawing.Point(9, 42);
            this.ckbBlur.Name = "ckbBlur";
            this.ckbBlur.Size = new System.Drawing.Size(44, 17);
            this.ckbBlur.TabIndex = 15;
            this.ckbBlur.Text = "Blur";
            this.ckbBlur.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "X / Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Width / Height";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTargetPosX);
            this.groupBox2.Controls.Add(this.txtTargetPosY);
            this.groupBox2.Controls.Add(this.txtTargetPosWidth);
            this.groupBox2.Controls.Add(this.txtTargetPosHeight);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 80);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target Box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preview Image (OCR works best with black text on white background)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Result Text";
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ckbLimitFps);
            this.Controls.Add(this.ckbUpdateInput);
            this.Controls.Add(this.lblFps);
            this.DoubleBuffered = true;
            this.Name = "FormDemo";
            this.Text = "Desktop Duplication API Demo";
            this.Shown += new System.EventHandler(this.FormDemo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.CheckBox ckbUpdateInput;
        private System.Windows.Forms.CheckBox ckbLimitFps;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtTargetPosX;
        private System.Windows.Forms.TextBox txtTargetPosY;
        private System.Windows.Forms.TextBox txtTargetPosWidth;
        private System.Windows.Forms.TextBox txtTargetPosHeight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.CheckBox ckbInvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbBlur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

