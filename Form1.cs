namespace CSC240_06_01_BedAndBreakfast_MB
{
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }



        public string SelectedRoomText => roomBox.SelectedItem?.ToString() ?? "No room selected";
        private void GuestBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Convert.ToInt32(guestBox.SelectedIndex);
            RoomBox_DropDown(selectedIndex);
        }
        private void RoomBox_DropDown(int selectedIndex)
        {

            roomBox.Items.Clear();                             // Clear startbox from start.

            // begin loop
            for (int i = 1; i <= Math.Min(selectedIndex + 1, 20); i++) // this loops the Selected index so if 6 is added it will add upto 6 rooms
            {
                roomBox.Items.Add(i.ToString());
                /*beings we used a conditional for startValue we can skip 4 but this removes room because even with double bed a room can only fit 4 people
                 * there for anything over 4 people must get atleast 2 rooms. any reservation over 8 people must get 3 rooms etc. */
                if (i >= 5)
                    roomBox.Items.Remove("1");
                if (i >= 9)
                    roomBox.Items.Remove("2");
                if (i >= 13)
                    roomBox.Items.Remove("3");
                if (i >= 17)
                    roomBox.Items.Remove("4");
            }

        }

        private void layoutButton_Click(object sender, EventArgs e)
        {
            if (guestBox.SelectedItem != null && roomBox.SelectedItem != null)
            {

                RoomLayout layout = new RoomLayout();
                layout.SelectedRoomText = this.SelectedRoomText;
                layout.FormClosed += SetPrice;
                layout.ShowDialog();
            }
            else
                MessageBox.Show("Please select Guests and Rooms.");
        }

        private void SetPrice(object sender, FormClosedEventArgs e)
        {
            RoomLayout layout = (RoomLayout)sender;
            double roomPrice = layout.roomPrice;
            priceLabel.Text = "Price: ";
            priceLabel.Text += roomPrice.ToString("C");  // switch this when done with meal options
            priceLabel.Visible = true;
        }
            
        private void CheckinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Take Money and give key");
        }
    }
}
