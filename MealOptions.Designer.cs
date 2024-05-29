namespace CSC240_06_01_BedAndBreakfast_MB
{
    partial class MealOptions
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
            mealOptionsLabel = new Label();
            SuspendLayout();
            // 
            // mealOptionsLabel
            // 
            mealOptionsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mealOptionsLabel.AutoSize = true;
            mealOptionsLabel.Font = new Font("Tempus Sans ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mealOptionsLabel.Location = new Point(161, 20);
            mealOptionsLabel.Name = "mealOptionsLabel";
            mealOptionsLabel.Size = new Size(212, 42);
            mealOptionsLabel.TabIndex = 0;
            mealOptionsLabel.Text = "Meal Options";
            // 
            // MealOptions
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(544, 212);
            Controls.Add(mealOptionsLabel);
            Name = "MealOptions";
            Text = "MealOptions";
            Load += MealOptions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mealOptionsLabel;
    }
}