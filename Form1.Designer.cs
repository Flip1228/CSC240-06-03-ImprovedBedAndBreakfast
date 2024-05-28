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
            guestBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            roomBox = new ComboBox();
            layoutButton = new Button();
            mealOptionsButton = new Button();
            checkinButton = new Button();
            priceLabel = new Label();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(116, 26);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(248, 29);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to Bailey's";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateLabel.Location = new Point(160, 74);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(164, 25);
            rateLabel.TabIndex = 2;
            rateLabel.Text = "Check our rates";
            // 
            // guestBox
            // 
            guestBox.FormattingEnabled = true;
            guestBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            guestBox.Location = new Point(376, 127);
            guestBox.Name = "guestBox";
            guestBox.Size = new Size(53, 31);
            guestBox.TabIndex = 3;
            guestBox.SelectedIndexChanged += GuestBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 4;
            label1.Text = "How many guest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 5;
            label2.Text = "How many rooms";
            // 
            // roomBox
            // 
            roomBox.FormattingEnabled = true;
            roomBox.Location = new Point(376, 184);
            roomBox.Name = "roomBox";
            roomBox.Size = new Size(53, 31);
            roomBox.TabIndex = 6;
            // 
            // layoutButton
            // 
            layoutButton.BackColor = Color.DarkGoldenrod;
            layoutButton.FlatStyle = FlatStyle.Flat;
            layoutButton.Location = new Point(281, 240);
            layoutButton.Name = "layoutButton";
            layoutButton.Size = new Size(204, 33);
            layoutButton.TabIndex = 7;
            layoutButton.Text = "Select room layout";
            layoutButton.UseVisualStyleBackColor = false;
            layoutButton.Click += layoutButton_Click;
            // 
            // mealOptionsButton
            // 
            mealOptionsButton.BackColor = Color.DarkGoldenrod;
            mealOptionsButton.FlatStyle = FlatStyle.Flat;
            mealOptionsButton.Location = new Point(13, 240);
            mealOptionsButton.Name = "mealOptionsButton";
            mealOptionsButton.Size = new Size(212, 33);
            mealOptionsButton.TabIndex = 8;
            mealOptionsButton.Text = "Select meal options";
            mealOptionsButton.UseVisualStyleBackColor = false;
            // 
            // checkinButton
            // 
            checkinButton.BackColor = Color.DarkGoldenrod;
            checkinButton.FlatStyle = FlatStyle.Flat;
            checkinButton.Location = new Point(13, 379);
            checkinButton.Name = "checkinButton";
            checkinButton.Size = new Size(472, 38);
            checkinButton.TabIndex = 9;
            checkinButton.Text = "Check in";
            checkinButton.UseVisualStyleBackColor = false;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Tempus Sans ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(135, 304);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(90, 35);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Price: ";
            priceLabel.Visible = false;
            // 
            // BaileysForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(501, 429);
            Controls.Add(priceLabel);
            Controls.Add(checkinButton);
            Controls.Add(mealOptionsButton);
            Controls.Add(layoutButton);
            Controls.Add(roomBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guestBox);
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
        private ComboBox guestBox;
        private Label label1;
        private Label label2;
        private ComboBox roomBox;
        private Button layoutButton;
        private Button mealOptionsButton;
        private Button checkinButton;
        private Label priceLabel;
    }
}
