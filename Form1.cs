using System.Diagnostics.Eventing.Reader;
using System.Numerics;

namespace CSC240_06_01_BedAndBreakfast_MB
{
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }



        public string SelectedRoomText => roomBox.SelectedItem?.ToString() ?? "No room selected";
        public double roomPrice;
        public double mealPrice;
      
        
        
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



        public void SetRoomPrice(object sender, FormClosedEventArgs e)
        {
            RoomLayout layout = (RoomLayout)sender;
            roomPrice = layout.roomPrice;
            priceLabel.Text = "Price: ";
            priceLabel.Text += roomPrice.ToString("C");  // switch this when done with meal options
            priceLabel.Visible = true;
        }


        private void layoutButton_Click(object sender, EventArgs e)
        {
            if (guestBox.SelectedItem != null && roomBox.SelectedItem != null)
            {

                RoomLayout layout = new RoomLayout();
                layout.SelectedRoomText = this.SelectedRoomText;
                layout.FormClosed += SetRoomPrice;
                layout.ShowDialog();
            }
            else
                MessageBox.Show("Please select Guests and Rooms.");
        }

        public void SetMealPrice(object sender, FormClosedEventArgs e)
        {
                MealOptions mealOptions = (MealOptions)sender;
                mealPrice = mealOptions.mealPrice;
                priceLabel.Text = "Price: ";
                double totalPrice = mealPrice + roomPrice;
                priceLabel.Text += totalPrice.ToString("C");
        }
       
        private void MealOptions_Window(object sender, EventArgs e)
        {
            if (roomPrice != 0 && SelectedRoomText != "No room selected")
            {
                MealOptions mealOptions = new MealOptions();
                mealOptions.SelectedmealText = this.SelectedRoomText;
                mealOptions.FormClosed += SetMealPrice;
                mealOptions.ShowDialog();
            }
            else
                MessageBox.Show("Must select Guest, Rooms, and Room Layout's before continuing.");
        }

        private void CheckinButton_Click(object sender, EventArgs e)
        {
            double total = mealPrice + roomPrice;
            DialogResult result;
            if (roomPrice != 0)
            {
                if (mealPrice == 0)
                {
                    result = MessageBox.Show("Are you sure the free meal option is correct?", "Free Meal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        MessageBox.Show("Collect " + total.ToString("C") + " and make keys for room's");
                }
            }
            else
                MessageBox.Show("Please make sure all options are selected!");
            
        }
    }
}
