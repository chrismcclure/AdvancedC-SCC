namespace PizzaStore_Project
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
            this.grpPizza = new System.Windows.Forms.GroupBox();
            this.cbxVeggie = new System.Windows.Forms.CheckBox();
            this.cbxBlackOlive = new System.Windows.Forms.CheckBox();
            this.cbxGreenPepper = new System.Windows.Forms.CheckBox();
            this.cbxHamburger = new System.Windows.Forms.CheckBox();
            this.cbxCheeze = new System.Windows.Forms.CheckBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveFromOrder = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.lbxOrderedItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbDrinks = new System.Windows.Forms.RadioButton();
            this.rbSalads = new System.Windows.Forms.RadioButton();
            this.rbSpecials = new System.Windows.Forms.RadioButton();
            this.rbCoolStuff = new System.Windows.Forms.RadioButton();
            this.LblTax = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPizza
            // 
            this.grpPizza.Controls.Add(this.cbxVeggie);
            this.grpPizza.Controls.Add(this.cbxBlackOlive);
            this.grpPizza.Controls.Add(this.cbxGreenPepper);
            this.grpPizza.Controls.Add(this.cbxHamburger);
            this.grpPizza.Controls.Add(this.cbxCheeze);
            this.grpPizza.Controls.Add(this.rbLarge);
            this.grpPizza.Controls.Add(this.rbMedium);
            this.grpPizza.Controls.Add(this.rbSmall);
            this.grpPizza.Location = new System.Drawing.Point(167, 565);
            this.grpPizza.Name = "grpPizza";
            this.grpPizza.Size = new System.Drawing.Size(1028, 474);
            this.grpPizza.TabIndex = 5;
            this.grpPizza.TabStop = false;
            this.grpPizza.Text = "Pizza";
            // 
            // cbxVeggie
            // 
            this.cbxVeggie.AutoSize = true;
            this.cbxVeggie.Location = new System.Drawing.Point(589, 383);
            this.cbxVeggie.Name = "cbxVeggie";
            this.cbxVeggie.Size = new System.Drawing.Size(143, 36);
            this.cbxVeggie.TabIndex = 7;
            this.cbxVeggie.Text = "Veggie";
            this.cbxVeggie.UseVisualStyleBackColor = true;
            // 
            // cbxBlackOlive
            // 
            this.cbxBlackOlive.AutoSize = true;
            this.cbxBlackOlive.Location = new System.Drawing.Point(589, 313);
            this.cbxBlackOlive.Name = "cbxBlackOlive";
            this.cbxBlackOlive.Size = new System.Drawing.Size(196, 36);
            this.cbxBlackOlive.TabIndex = 6;
            this.cbxBlackOlive.Text = "Black Olive";
            this.cbxBlackOlive.UseVisualStyleBackColor = true;
            // 
            // cbxGreenPepper
            // 
            this.cbxGreenPepper.AutoSize = true;
            this.cbxGreenPepper.Location = new System.Drawing.Point(589, 235);
            this.cbxGreenPepper.Name = "cbxGreenPepper";
            this.cbxGreenPepper.Size = new System.Drawing.Size(231, 36);
            this.cbxGreenPepper.TabIndex = 5;
            this.cbxGreenPepper.Text = "Green Pepper";
            this.cbxGreenPepper.UseVisualStyleBackColor = true;
            // 
            // cbxHamburger
            // 
            this.cbxHamburger.AutoSize = true;
            this.cbxHamburger.Location = new System.Drawing.Point(589, 160);
            this.cbxHamburger.Name = "cbxHamburger";
            this.cbxHamburger.Size = new System.Drawing.Size(194, 36);
            this.cbxHamburger.TabIndex = 4;
            this.cbxHamburger.Text = "Hamburger";
            this.cbxHamburger.UseVisualStyleBackColor = true;
            // 
            // cbxCheeze
            // 
            this.cbxCheeze.AutoSize = true;
            this.cbxCheeze.Location = new System.Drawing.Point(589, 79);
            this.cbxCheeze.Name = "cbxCheeze";
            this.cbxCheeze.Size = new System.Drawing.Size(151, 36);
            this.cbxCheeze.TabIndex = 3;
            this.cbxCheeze.Text = "Cheeze";
            this.cbxCheeze.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(67, 383);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(125, 36);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(67, 234);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(153, 36);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(67, 99);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(124, 36);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(632, 1088);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(275, 73);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(1043, 1088);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(391, 73);
            this.btnRemoveFromOrder.TabIndex = 7;
            this.btnRemoveFromOrder.Text = "Remove From Order";
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            this.btnRemoveFromOrder.Click += new System.EventHandler(this.btnRemoveFromOrder_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Location = new System.Drawing.Point(1832, 1083);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(308, 78);
            this.btnFinishOrder.TabIndex = 8;
            this.btnFinishOrder.Text = "Finish Order";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // lbxOrderedItems
            // 
            this.lbxOrderedItems.FormattingEnabled = true;
            this.lbxOrderedItems.ItemHeight = 31;
            this.lbxOrderedItems.Location = new System.Drawing.Point(1251, 477);
            this.lbxOrderedItems.Name = "lbxOrderedItems";
            this.lbxOrderedItems.Size = new System.Drawing.Size(1318, 469);
            this.lbxOrderedItems.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1547, 1083);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1663, 1083);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 32);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "total";
            // 
            // rbPizza
            // 
            this.rbPizza.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPizza.AutoSize = true;
            this.rbPizza.Location = new System.Drawing.Point(184, 178);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Padding = new System.Windows.Forms.Padding(60);
            this.rbPizza.Size = new System.Drawing.Size(215, 162);
            this.rbPizza.TabIndex = 12;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza";
            this.rbPizza.UseVisualStyleBackColor = true;
            // 
            // rbDrinks
            // 
            this.rbDrinks.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDrinks.AutoSize = true;
            this.rbDrinks.Location = new System.Drawing.Point(588, 178);
            this.rbDrinks.Name = "rbDrinks";
            this.rbDrinks.Padding = new System.Windows.Forms.Padding(60);
            this.rbDrinks.Size = new System.Drawing.Size(225, 162);
            this.rbDrinks.TabIndex = 13;
            this.rbDrinks.TabStop = true;
            this.rbDrinks.Text = "Drinks";
            this.rbDrinks.UseVisualStyleBackColor = true;
            // 
            // rbSalads
            // 
            this.rbSalads.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSalads.AutoSize = true;
            this.rbSalads.Location = new System.Drawing.Point(1014, 178);
            this.rbSalads.Name = "rbSalads";
            this.rbSalads.Padding = new System.Windows.Forms.Padding(60);
            this.rbSalads.Size = new System.Drawing.Size(233, 162);
            this.rbSalads.TabIndex = 14;
            this.rbSalads.TabStop = true;
            this.rbSalads.Text = "Salads";
            this.rbSalads.UseVisualStyleBackColor = true;
            // 
            // rbSpecials
            // 
            this.rbSpecials.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSpecials.AutoSize = true;
            this.rbSpecials.Location = new System.Drawing.Point(1457, 178);
            this.rbSpecials.Name = "rbSpecials";
            this.rbSpecials.Padding = new System.Windows.Forms.Padding(60);
            this.rbSpecials.Size = new System.Drawing.Size(254, 162);
            this.rbSpecials.TabIndex = 15;
            this.rbSpecials.TabStop = true;
            this.rbSpecials.Text = "Specials";
            this.rbSpecials.UseVisualStyleBackColor = true;
            // 
            // rbCoolStuff
            // 
            this.rbCoolStuff.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCoolStuff.AutoSize = true;
            this.rbCoolStuff.Location = new System.Drawing.Point(1879, 178);
            this.rbCoolStuff.Name = "rbCoolStuff";
            this.rbCoolStuff.Padding = new System.Windows.Forms.Padding(60);
            this.rbCoolStuff.Size = new System.Drawing.Size(270, 162);
            this.rbCoolStuff.TabIndex = 16;
            this.rbCoolStuff.TabStop = true;
            this.rbCoolStuff.Text = "Cool Stuff";
            this.rbCoolStuff.UseVisualStyleBackColor = true;
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Location = new System.Drawing.Point(1663, 1023);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(53, 32);
            this.LblTax.TabIndex = 18;
            this.LblTax.Text = "tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1547, 1023);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tax:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(1663, 971);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(116, 32);
            this.lblSubTotal.TabIndex = 20;
            this.lblSubTotal.Text = "subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1505, 971);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Subtotal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2618, 1225);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbCoolStuff);
            this.Controls.Add(this.rbSpecials);
            this.Controls.Add(this.rbSalads);
            this.Controls.Add(this.rbDrinks);
            this.Controls.Add(this.rbPizza);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxOrderedItems);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.btnRemoveFromOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpPizza);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Pizza Emporium";
            this.grpPizza.ResumeLayout(false);
            this.grpPizza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPizza;
        private System.Windows.Forms.CheckBox cbxVeggie;
        private System.Windows.Forms.CheckBox cbxBlackOlive;
        private System.Windows.Forms.CheckBox cbxGreenPepper;
        private System.Windows.Forms.CheckBox cbxHamburger;
        private System.Windows.Forms.CheckBox cbxCheeze;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveFromOrder;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.ListBox lbxOrderedItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbDrinks;
        private System.Windows.Forms.RadioButton rbSalads;
        private System.Windows.Forms.RadioButton rbSpecials;
        private System.Windows.Forms.RadioButton rbCoolStuff;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label5;
    }
}

