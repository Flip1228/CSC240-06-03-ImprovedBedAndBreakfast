namespace CSC240_06_01_BedAndBreakfast_MB
{
    partial class BreakfastOptionForm
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
            label1 = new Label();
            contRadioButton = new RadioButton();
            fullRadioButton = new RadioButton();
            deluxeRadioButton = new RadioButton();
            priceLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(261, 27);
            label1.TabIndex = 0;
            label1.Text = "Select your breakfast option.";
            // 
            // contRadioButton
            // 
            contRadioButton.AutoSize = true;
            contRadioButton.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contRadioButton.Location = new Point(93, 84);
            contRadioButton.Name = "contRadioButton";
            contRadioButton.Size = new Size(125, 28);
            contRadioButton.TabIndex = 1;
            contRadioButton.TabStop = true;
            contRadioButton.Text = "Continental";
            contRadioButton.UseVisualStyleBackColor = true;
            contRadioButton.CheckedChanged += ContRadioButton_CheckedChanged;
            // 
            // fullRadioButton
            // 
            fullRadioButton.AutoSize = true;
            fullRadioButton.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullRadioButton.Location = new Point(93, 132);
            fullRadioButton.Name = "fullRadioButton";
            fullRadioButton.Size = new Size(63, 31);
            fullRadioButton.TabIndex = 2;
            fullRadioButton.TabStop = true;
            fullRadioButton.Text = "Full";
            fullRadioButton.UseVisualStyleBackColor = true;
            fullRadioButton.CheckedChanged += FullRadioButton_CheckedChanged;
            // 
            // deluxeRadioButton
            // 
            deluxeRadioButton.AutoSize = true;
            deluxeRadioButton.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deluxeRadioButton.Location = new Point(93, 178);
            deluxeRadioButton.Name = "deluxeRadioButton";
            deluxeRadioButton.Size = new Size(91, 31);
            deluxeRadioButton.TabIndex = 3;
            deluxeRadioButton.TabStop = true;
            deluxeRadioButton.Text = "Deluxe";
            deluxeRadioButton.UseVisualStyleBackColor = true;
            deluxeRadioButton.CheckedChanged += DeluxeRadioButton_CheckedChanged;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(177, 254);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(66, 27);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(324, 324);
            Controls.Add(priceLabel);
            Controls.Add(deluxeRadioButton);
            Controls.Add(fullRadioButton);
            Controls.Add(contRadioButton);
            Controls.Add(label1);
            Name = "BreakfastOptionForm";
            Text = "BreakfastOptionForm";
            Load += BreakfastOptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton contRadioButton;
        private RadioButton fullRadioButton;
        private RadioButton deluxeRadioButton;
        private Label priceLabel;
    }
}