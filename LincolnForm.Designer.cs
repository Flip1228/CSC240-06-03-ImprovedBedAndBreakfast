namespace CSC240_06_01_BedAndBreakfast_MB
{
    partial class LincolnForm
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
            lincolnDesctriptionLabel = new Label();
            lincolnPrice = new Label();
            SuspendLayout();
            // 
            // lincolnDesctriptionLabel
            // 
            lincolnDesctriptionLabel.AutoSize = true;
            lincolnDesctriptionLabel.Location = new Point(27, 47);
            lincolnDesctriptionLabel.Name = "lincolnDesctriptionLabel";
            lincolnDesctriptionLabel.Size = new Size(237, 46);
            lincolnDesctriptionLabel.TabIndex = 0;
            lincolnDesctriptionLabel.Text = "Return to the 1850s in this \r\nlovely room with private bath.";
            // 
            // lincolnPrice
            // 
            lincolnPrice.AutoSize = true;
            lincolnPrice.Location = new Point(170, 130);
            lincolnPrice.Name = "lincolnPrice";
            lincolnPrice.Size = new Size(121, 23);
            lincolnPrice.TabIndex = 1;
            lincolnPrice.Text = "$110 per night";
            // 
            // LincolnForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(321, 243);
            Controls.Add(lincolnPrice);
            Controls.Add(lincolnDesctriptionLabel);
            Name = "LincolnForm";
            Text = "Lincoln Room";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lincolnDesctriptionLabel;
        private Label lincolnPrice;
    }
}