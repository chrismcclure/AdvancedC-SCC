namespace Practice2PhotoCopier
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
            this.grbToner = new System.Windows.Forms.GroupBox();
            this.grbPaper = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfCopies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReplaceToner = new System.Windows.Forms.Button();
            this.txtPaperToAdd = new System.Windows.Forms.TextBox();
            this.btnAddPaper = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToner = new System.Windows.Forms.Label();
            this.lblPaper = new System.Windows.Forms.Label();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.lblPrinterMessage = new System.Windows.Forms.Label();
            this.btnFixJam = new System.Windows.Forms.Button();
            this.grbToner.SuspendLayout();
            this.grbPaper.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbToner
            // 
            this.grbToner.Controls.Add(this.lblToner);
            this.grbToner.Location = new System.Drawing.Point(229, 285);
            this.grbToner.Name = "grbToner";
            this.grbToner.Size = new System.Drawing.Size(228, 221);
            this.grbToner.TabIndex = 0;
            this.grbToner.TabStop = false;
            this.grbToner.Text = "Toner Level";
            // 
            // grbPaper
            // 
            this.grbPaper.Controls.Add(this.lblPaper);
            this.grbPaper.Location = new System.Drawing.Point(557, 285);
            this.grbPaper.Name = "grbPaper";
            this.grbPaper.Size = new System.Drawing.Size(218, 221);
            this.grbPaper.TabIndex = 1;
            this.grbPaper.TabStop = false;
            this.grbPaper.Text = "Paper Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1718, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number Copies";
            // 
            // txtNumberOfCopies
            // 
            this.txtNumberOfCopies.Location = new System.Drawing.Point(1964, 183);
            this.txtNumberOfCopies.Name = "txtNumberOfCopies";
            this.txtNumberOfCopies.Size = new System.Drawing.Size(241, 38);
            this.txtNumberOfCopies.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1718, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reset Everything";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1964, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(241, 64);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1964, 365);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(241, 63);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReplaceToner
            // 
            this.btnReplaceToner.Location = new System.Drawing.Point(1964, 641);
            this.btnReplaceToner.Name = "btnReplaceToner";
            this.btnReplaceToner.Size = new System.Drawing.Size(241, 70);
            this.btnReplaceToner.TabIndex = 8;
            this.btnReplaceToner.Text = "Replace Toner";
            this.btnReplaceToner.UseVisualStyleBackColor = true;
            this.btnReplaceToner.Click += new System.EventHandler(this.btnReplaceToner_Click);
            // 
            // txtPaperToAdd
            // 
            this.txtPaperToAdd.Location = new System.Drawing.Point(1964, 775);
            this.txtPaperToAdd.Name = "txtPaperToAdd";
            this.txtPaperToAdd.Size = new System.Drawing.Size(241, 38);
            this.txtPaperToAdd.TabIndex = 9;
            // 
            // btnAddPaper
            // 
            this.btnAddPaper.Location = new System.Drawing.Point(1964, 863);
            this.btnAddPaper.Name = "btnAddPaper";
            this.btnAddPaper.Size = new System.Drawing.Size(241, 66);
            this.btnAddPaper.TabIndex = 10;
            this.btnAddPaper.Text = "Add Paper";
            this.btnAddPaper.UseVisualStyleBackColor = true;
            this.btnAddPaper.Click += new System.EventHandler(this.btnAddPaper_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(219, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(784, 58);
            this.label3.TabIndex = 11;
            this.label3.Text = "Canon 500 sheet capacity copier";
            // 
            // lblToner
            // 
            this.lblToner.AutoSize = true;
            this.lblToner.Location = new System.Drawing.Point(57, 80);
            this.lblToner.Name = "lblToner";
            this.lblToner.Size = new System.Drawing.Size(31, 32);
            this.lblToner.TabIndex = 0;
            this.lblToner.Text = "0";
            // 
            // lblPaper
            // 
            this.lblPaper.AutoSize = true;
            this.lblPaper.Location = new System.Drawing.Point(43, 80);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(31, 32);
            this.lblPaper.TabIndex = 0;
            this.lblPaper.Text = "0";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(229, 667);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(1463, 243);
            this.rtbMessages.TabIndex = 0;
            this.rtbMessages.Text = "";
            // 
            // lblPrinterMessage
            // 
            this.lblPrinterMessage.AutoSize = true;
            this.lblPrinterMessage.Location = new System.Drawing.Point(229, 629);
            this.lblPrinterMessage.Name = "lblPrinterMessage";
            this.lblPrinterMessage.Size = new System.Drawing.Size(235, 32);
            this.lblPrinterMessage.TabIndex = 12;
            this.lblPrinterMessage.Text = "Printer Messages";
            // 
            // btnFixJam
            // 
            this.btnFixJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixJam.Location = new System.Drawing.Point(229, 943);
            this.btnFixJam.Name = "btnFixJam";
            this.btnFixJam.Size = new System.Drawing.Size(1463, 67);
            this.btnFixJam.TabIndex = 13;
            this.btnFixJam.Text = "Magic Fix Button";
            this.btnFixJam.UseVisualStyleBackColor = true;
            this.btnFixJam.Click += new System.EventHandler(this.btnFixJam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2351, 1054);
            this.Controls.Add(this.btnFixJam);
            this.Controls.Add(this.lblPrinterMessage);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddPaper);
            this.Controls.Add(this.txtPaperToAdd);
            this.Controls.Add(this.btnReplaceToner);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfCopies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbPaper);
            this.Controls.Add(this.grbToner);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cheap Printer 5000";
            this.grbToner.ResumeLayout(false);
            this.grbToner.PerformLayout();
            this.grbPaper.ResumeLayout(false);
            this.grbPaper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbToner;
        private System.Windows.Forms.GroupBox grbPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfCopies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReplaceToner;
        private System.Windows.Forms.TextBox txtPaperToAdd;
        private System.Windows.Forms.Button btnAddPaper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToner;
        private System.Windows.Forms.Label lblPaper;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Label lblPrinterMessage;
        private System.Windows.Forms.Button btnFixJam;
    }
}

