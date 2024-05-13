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
    }
}
