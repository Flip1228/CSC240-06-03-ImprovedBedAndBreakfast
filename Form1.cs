namespace CSC240_06_01_BedAndBreakfast_MB
{
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }


        private void BelleAireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (belleAireCheckBox.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                belleAireCheckBox.Checked = false;

            }
        }
        private void LincolnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lincolnCheckBox.Checked)
            {
                LincolnForm lincolnForm = new LincolnForm();
                lincolnForm.ShowDialog();
                lincolnCheckBox.Checked = false;
            }
        }

        private void mealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastform = new BreakfastOptionForm();
            breakfastform.ShowDialog();
        }
    }
}
