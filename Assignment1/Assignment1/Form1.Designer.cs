namespace Assignment1
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
            this.txtPricePerKWh = new System.Windows.Forms.TextBox();
            this.txtCurrentWatage = new System.Windows.Forms.TextBox();
            this.txtCostPerHour = new System.Windows.Forms.TextBox();
            this.txtCostPerDay = new System.Windows.Forms.TextBox();
            this.txtCostPerYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlButtonHolder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtPricePerKWh
            // 
            this.txtPricePerKWh.Location = new System.Drawing.Point(590, 141);
            this.txtPricePerKWh.Name = "txtPricePerKWh";
            this.txtPricePerKWh.Size = new System.Drawing.Size(297, 38);
            this.txtPricePerKWh.TabIndex = 0;
            // 
            // txtCurrentWatage
            // 
            this.txtCurrentWatage.Location = new System.Drawing.Point(590, 278);
            this.txtCurrentWatage.Name = "txtCurrentWatage";
            this.txtCurrentWatage.Size = new System.Drawing.Size(297, 38);
            this.txtCurrentWatage.TabIndex = 1;
            // 
            // txtCostPerHour
            // 
            this.txtCostPerHour.Location = new System.Drawing.Point(1335, 147);
            this.txtCostPerHour.Name = "txtCostPerHour";
            this.txtCostPerHour.Size = new System.Drawing.Size(279, 38);
            this.txtCostPerHour.TabIndex = 2;
            // 
            // txtCostPerDay
            // 
            this.txtCostPerDay.Location = new System.Drawing.Point(1335, 284);
            this.txtCostPerDay.Name = "txtCostPerDay";
            this.txtCostPerDay.Size = new System.Drawing.Size(279, 38);
            this.txtCostPerDay.TabIndex = 3;
            // 
            // txtCostPerYear
            // 
            this.txtCostPerYear.Location = new System.Drawing.Point(1335, 410);
            this.txtCostPerYear.Name = "txtCostPerYear";
            this.txtCostPerYear.Size = new System.Drawing.Size(279, 38);
            this.txtCostPerYear.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price per k Wh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Watage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1128, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cost per hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1128, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost per day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1128, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cost per year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(670, 58);
            this.label6.TabIndex = 10;
            this.label6.Text = "Devices we can turn on or off";
            // 
            // pnlButtonHolder
            // 
            this.pnlButtonHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtonHolder.Location = new System.Drawing.Point(141, 576);
            this.pnlButtonHolder.Name = "pnlButtonHolder";
            this.pnlButtonHolder.Size = new System.Drawing.Size(1769, 937);
            this.pnlButtonHolder.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2125, 1587);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCostPerYear);
            this.Controls.Add(this.txtCostPerDay);
            this.Controls.Add(this.txtCostPerHour);
            this.Controls.Add(this.txtCurrentWatage);
            this.Controls.Add(this.txtPricePerKWh);
            this.Controls.Add(this.pnlButtonHolder);
            this.MinimumSize = new System.Drawing.Size(2157, 1133);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPricePerKWh;
        private System.Windows.Forms.TextBox txtCurrentWatage;
        private System.Windows.Forms.TextBox txtCostPerHour;
        private System.Windows.Forms.TextBox txtCostPerDay;
        private System.Windows.Forms.TextBox txtCostPerYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlButtonHolder;
    }
}

