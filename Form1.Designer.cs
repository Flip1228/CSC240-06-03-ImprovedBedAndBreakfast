namespace CSC240_06_01_BedAndBreakfast_MB
{
    partial class BaileysForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            rateLabel = new Label();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(27, 48);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(248, 29);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to Bailey's";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateLabel.Location = new Point(79, 110);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(164, 25);
            rateLabel.TabIndex = 2;
            rateLabel.Text = "Check our rates";
            // 
            // BaileysForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 340);
            Controls.Add(rateLabel);
            Controls.Add(welcomeLabel);
            Name = "BaileysForm";
            Text = "Baileys Bed and Breakfast";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label rateLabel;
    }
}
