namespace Program_4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radDenver = new System.Windows.Forms.RadioButton();
            this.radKC = new System.Windows.Forms.RadioButton();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStatusOut = new System.Windows.Forms.Label();
            this.lblFlightInfoOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(949, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1173, 113);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to SCC Airlines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(718, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Step 1: Select Your Destination";
            // 
            // radDenver
            // 
            this.radDenver.Appearance = System.Windows.Forms.Appearance.Button;
            this.radDenver.AutoSize = true;
            this.radDenver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDenver.Location = new System.Drawing.Point(43, 43);
            this.radDenver.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radDenver.Name = "radDenver";
            this.radDenver.Size = new System.Drawing.Size(203, 68);
            this.radDenver.TabIndex = 3;
            this.radDenver.Text = "&Denver";
            this.radDenver.UseVisualStyleBackColor = true;
            this.radDenver.CheckedChanged += new System.EventHandler(this.radDenver_CheckedChanged);
            // 
            // radKC
            // 
            this.radKC.Appearance = System.Windows.Forms.Appearance.Button;
            this.radKC.AutoSize = true;
            this.radKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKC.Location = new System.Drawing.Point(325, 43);
            this.radKC.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radKC.Name = "radKC";
            this.radKC.Size = new System.Drawing.Size(312, 68);
            this.radKC.TabIndex = 4;
            this.radKC.Text = "&Kansas City";
            this.radKC.UseVisualStyleBackColor = true;
            this.radKC.CheckedChanged += new System.EventHandler(this.radKC_CheckedChanged);
            // 
            // piclogo
            // 
            this.piclogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.piclogo.Image = global::Program_4.Properties.Resources.Lincoln;
            this.piclogo.InitialImage = null;
            this.piclogo.Location = new System.Drawing.Point(0, 0);
            this.piclogo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(693, 1464);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            this.piclogo.WaitOnLoad = true;
            this.piclogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDenver);
            this.groupBox1.Controls.Add(this.radKC);
            this.groupBox1.Location = new System.Drawing.Point(1776, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(800, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 624);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(570, 58);
            this.label3.TabIndex = 8;
            this.label3.Text = "Step 3: Select Your Seat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(582, 58);
            this.label4.TabIndex = 9;
            this.label4.Text = "Step 2: Enter Your Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(709, 1227);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(612, 58);
            this.label5.TabIndex = 10;
            this.label5.Text = "Step 4: Check Your Status";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1605, 460);
            this.txtName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(971, 38);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name";
            // 
            // lblStatusOut
            // 
            this.lblStatusOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatusOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusOut.Location = new System.Drawing.Point(1474, 1242);
            this.lblStatusOut.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStatusOut.Name = "lblStatusOut";
            this.lblStatusOut.Size = new System.Drawing.Size(1104, 55);
            this.lblStatusOut.TabIndex = 12;
            // 
            // lblFlightInfoOut
            // 
            this.lblFlightInfoOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFlightInfoOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightInfoOut.Location = new System.Drawing.Point(1605, 312);
            this.lblFlightInfoOut.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFlightInfoOut.Name = "lblFlightInfoOut";
            this.lblFlightInfoOut.Size = new System.Drawing.Size(971, 117);
            this.lblFlightInfoOut.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2608, 1464);
            this.Controls.Add(this.lblFlightInfoOut);
            this.Controls.Add(this.lblStatusOut);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.piclogo);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "SCC Airlines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radDenver;
        private System.Windows.Forms.RadioButton radKC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStatusOut;
        private System.Windows.Forms.Label lblFlightInfoOut;
    }
}

