namespace CSC240_06_01_BedAndBreakfast_MB
{
    partial class RoomLayout
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
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Tempus Sans ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 20);
            label2.Name = "label2";
            label2.Size = new Size(257, 42);
            label2.TabIndex = 1;
            label2.Text = "Room Selection";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoomLayout
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(431, 208);
            Controls.Add(label2);
            Name = "RoomLayout";
            Text = "Room Layout";
            Load += RoomLayout_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
    }
}