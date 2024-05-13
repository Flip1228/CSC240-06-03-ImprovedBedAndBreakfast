namespace CSC240_06_01_BedAndBreakfast_MB
{
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }

        private void BelleAirCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (belleAirCheckBox.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
            }
        }
    }
}
