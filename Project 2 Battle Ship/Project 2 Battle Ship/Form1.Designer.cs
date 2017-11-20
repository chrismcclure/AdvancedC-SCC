namespace Project_2_Battle_Ship
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.cbxCarrier = new System.Windows.Forms.CheckBox();
            this.cbxBattleShip = new System.Windows.Forms.CheckBox();
            this.cbxSubmarine = new System.Windows.Forms.CheckBox();
            this.cbxDestroyer1 = new System.Windows.Forms.CheckBox();
            this.cbxDestroyer2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbSunkShips = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(42, 10);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(681, 586);
            this.pnlButtons.TabIndex = 0;
            // 
            // cbxCarrier
            // 
            this.cbxCarrier.AutoSize = true;
            this.cbxCarrier.Location = new System.Drawing.Point(769, 37);
            this.cbxCarrier.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxCarrier.Name = "cbxCarrier";
            this.cbxCarrier.Size = new System.Drawing.Size(100, 17);
            this.cbxCarrier.TabIndex = 1;
            this.cbxCarrier.Text = "Carrier 5 Blocks";
            this.cbxCarrier.UseVisualStyleBackColor = true;
            // 
            // cbxBattleShip
            // 
            this.cbxBattleShip.AutoSize = true;
            this.cbxBattleShip.Location = new System.Drawing.Point(769, 65);
            this.cbxBattleShip.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxBattleShip.Name = "cbxBattleShip";
            this.cbxBattleShip.Size = new System.Drawing.Size(116, 17);
            this.cbxBattleShip.TabIndex = 2;
            this.cbxBattleShip.Text = "Battleship 4 Blocks";
            this.cbxBattleShip.UseVisualStyleBackColor = true;
            // 
            // cbxSubmarine
            // 
            this.cbxSubmarine.AutoSize = true;
            this.cbxSubmarine.Location = new System.Drawing.Point(769, 96);
            this.cbxSubmarine.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxSubmarine.Name = "cbxSubmarine";
            this.cbxSubmarine.Size = new System.Drawing.Size(120, 17);
            this.cbxSubmarine.TabIndex = 3;
            this.cbxSubmarine.Text = "Submarine 3 Blocks";
            this.cbxSubmarine.UseVisualStyleBackColor = true;
            // 
            // cbxDestroyer1
            // 
            this.cbxDestroyer1.AutoSize = true;
            this.cbxDestroyer1.Location = new System.Drawing.Point(769, 127);
            this.cbxDestroyer1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxDestroyer1.Name = "cbxDestroyer1";
            this.cbxDestroyer1.Size = new System.Drawing.Size(115, 17);
            this.cbxDestroyer1.TabIndex = 4;
            this.cbxDestroyer1.Text = "Destroyer 2 Blocks";
            this.cbxDestroyer1.UseVisualStyleBackColor = true;
            // 
            // cbxDestroyer2
            // 
            this.cbxDestroyer2.AutoSize = true;
            this.cbxDestroyer2.Location = new System.Drawing.Point(769, 160);
            this.cbxDestroyer2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxDestroyer2.Name = "cbxDestroyer2";
            this.cbxDestroyer2.Size = new System.Drawing.Size(115, 17);
            this.cbxDestroyer2.TabIndex = 5;
            this.cbxDestroyer2.Text = "Destroyer 2 Blocks";
            this.cbxDestroyer2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ships Sunk";
            // 
            // rtbSunkShips
            // 
            this.rtbSunkShips.Location = new System.Drawing.Point(769, 226);
            this.rtbSunkShips.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rtbSunkShips.Name = "rtbSunkShips";
            this.rtbSunkShips.Size = new System.Drawing.Size(93, 150);
            this.rtbSunkShips.TabIndex = 7;
            this.rtbSunkShips.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(769, 389);
            this.btnStart.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 20);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(769, 420);
            this.btnEndGame.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(91, 20);
            this.btnEndGame.TabIndex = 9;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(990, 624);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbSunkShips);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDestroyer2);
            this.Controls.Add(this.cbxDestroyer1);
            this.Controls.Add(this.cbxSubmarine);
            this.Controls.Add(this.cbxBattleShip);
            this.Controls.Add(this.cbxCarrier);
            this.Controls.Add(this.pnlButtons);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Battle Ship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.CheckBox cbxCarrier;
        private System.Windows.Forms.CheckBox cbxBattleShip;
        private System.Windows.Forms.CheckBox cbxSubmarine;
        private System.Windows.Forms.CheckBox cbxDestroyer1;
        private System.Windows.Forms.CheckBox cbxDestroyer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbSunkShips;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEndGame;
    }
}

