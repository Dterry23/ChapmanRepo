namespace WindowsFormsAppFoodOrders
{
    partial class FormOrderHistory
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
            this.foodOrderListBox = new System.Windows.Forms.ListBox();
            this.orderTracker1 = new WindowsFormsAppFoodOrders.OrderTracker();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foodOrderListBox
            // 
            this.foodOrderListBox.FormattingEnabled = true;
            this.foodOrderListBox.Location = new System.Drawing.Point(12, 32);
            this.foodOrderListBox.Name = "foodOrderListBox";
            this.foodOrderListBox.Size = new System.Drawing.Size(184, 316);
            this.foodOrderListBox.TabIndex = 0;
            this.foodOrderListBox.SelectedIndexChanged += new System.EventHandler(this.FoodOrderListBox_SelectedIndexChanged);
            // 
            // orderTracker1
            // 
            this.orderTracker1.Location = new System.Drawing.Point(446, 12);
            this.orderTracker1.Name = "orderTracker1";
            this.orderTracker1.Size = new System.Drawing.Size(200, 414);
            this.orderTracker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(311, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "label2";
            // 
            // FormOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderTracker1);
            this.Controls.Add(this.foodOrderListBox);
            this.Name = "FormOrderHistory";
            this.Text = "FormOrderHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox foodOrderListBox;
        private OrderTracker orderTracker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
    }
}