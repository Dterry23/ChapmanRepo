namespace WindowsFormsApplicationMyCircles
{
    partial class MainPage
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
            this.circleButton = new System.Windows.Forms.Button();
            this.circleDetailsTextBox = new System.Windows.Forms.TextBox();
            this.squareButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(66, 191);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(83, 23);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Get Circles";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // circleDetailsTextBox
            // 
            this.circleDetailsTextBox.Location = new System.Drawing.Point(43, 261);
            this.circleDetailsTextBox.Multiline = true;
            this.circleDetailsTextBox.Name = "circleDetailsTextBox";
            this.circleDetailsTextBox.Size = new System.Drawing.Size(419, 145);
            this.circleDetailsTextBox.TabIndex = 1;
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(211, 191);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(86, 23);
            this.squareButton.TabIndex = 2;
            this.squareButton.Text = "Get Squares";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(355, 191);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(84, 23);
            this.triangleButton.TabIndex = 3;
            this.triangleButton.Text = "Get Triangles";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 505);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.circleDetailsTextBox);
            this.Controls.Add(this.circleButton);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.TextBox circleDetailsTextBox;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button triangleButton;
    }
}

