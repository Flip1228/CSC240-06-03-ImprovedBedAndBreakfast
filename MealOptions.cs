using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CSC240_06_01_BedAndBreakfast_MB
{
    public partial class MealOptions : Form
    {
        public MealOptions()
        {
            InitializeComponent();
        }

        public double mealPrice { get; set; }
        private string text;
        public double freeMealPrice;
        public double contMealPrice;
        public double fullMealPrice;
        public double deluxMealPrice;
        public int test = 15;
        public string SelectedmealText
        {
            get => text;
            set => text = value;
        }


        //start of execution
        private void MealOptions_Load(object sender, EventArgs e)
        {
            INIREAD();
            ComboBox_Creation();
            Resize();

        }


        //create combo boxes
        private void ComboBox_Creation()
        {

                int numOfBoxes = Convert.ToInt32(text);
                int mealCount = 0;

                for (int i = 0; i < numOfBoxes; i++)
                {
                    string label = "Select Meal option for room " + (i + 1);
                    ComboBox mealSelectionComboBox = new ComboBox();

                    mealSelectionComboBox.Name = "mealSelectionComboBox" + i;
                    mealSelectionComboBox.Items.AddRange(new object[]
                    {   "Free" + freeMealPrice.ToString("C"),
                    "Continental " + contMealPrice.ToString("C"),
                    "Full " + fullMealPrice.ToString("C"),
                    "Delux " + deluxMealPrice.ToString("C"),
                    });

                    mealSelectionComboBox.Size = new Size(260, 31);
                    mealSelectionComboBox.Location = new Point(250 + test, 78 + i * 40);
                    Controls.Add(mealSelectionComboBox);

                    Label mealLabel = new Label();
                    mealLabel.Location = new Point(1 + test , 80 + i * 40);
                    mealLabel.Name = "mealLabel" + i;
                    mealLabel.Size = new Size(240, 23);
                    mealLabel.Text = label;
                    Controls.Add(mealLabel);
                    mealCount++;
                }

                Button selectButton = new Button();
                selectButton.Location = new Point(200, 118 + mealCount * 40);
                selectButton.Name = "selectButton";
                selectButton.Size = new Size(183, 38);
                selectButton.TabIndex = 0;
                selectButton.Text = "Select";
                selectButton.UseVisualStyleBackColor = true;
                Controls.Add(selectButton);
                selectButton.Click += SelectButton_Click;

        }

        private void SelectButton_Click(object? sender, EventArgs e)
        {
            GetMeal_Information();
            this.Close();
        }

        private void GetMeal_Information()
        {

            List<int> selectedItems = new List<int>();
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedItem == null)
                    {
                        MessageBox.Show("Please select all the meals.");
                        return;
                    }
                    else
                        selectedItems.Add(((ComboBox)control).SelectedIndex);
                }
            }

            int[] meal = selectedItems.ToArray();

            foreach (int item in meal)
            {
                switch (item)
                {
                    case 0:
                        mealPrice += deluxMealPrice;
                        break;
                    case 1:
                        mealPrice += contMealPrice;
                        break;
                    case 2:
                        mealPrice += fullMealPrice;
                        break;
                    default:
                        mealPrice += freeMealPrice;
                        break;


                }
            }
        }
            private void INIREAD()
            {
                string iniFilePath = "C:\\Users\\flip2\\Desktop\\test.ini";
                IniFile iniFile = new IniFile(iniFilePath);
                freeMealPrice = Convert.ToDouble(iniFile.Read("Meal Prices", "Free"));
                contMealPrice = Convert.ToDouble(iniFile.Read("Meal Prices", "Continental"));
                fullMealPrice = Convert.ToDouble(iniFile.Read("Meal Prices", "Full"));
                deluxMealPrice = Convert.ToDouble(iniFile.Read("Meal Prices", "Delux"));
            }
        public void Resize()
        {
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
            this.AutoSize = true;

            int width = 0;
            int height = 0;

            foreach (Control control in this.Controls)
            {
                width = Math.Max(width, control.PreferredSize.Width);
                if (control is ComboBox or Button)
                    height += control.PreferredSize.Height;
            }

            int padding = 20;
            width += padding;
            height += padding;
            this.Size = new Size(width, height + 50);
            
        }

    }
}
