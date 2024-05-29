using System.Runtime.InteropServices;
using System.Text;

namespace CSC240_06_01_BedAndBreakfast_MB
{
    public partial class RoomLayout : Form
    {
        public RoomLayout()
        {
            InitializeComponent();
        }
        public double roomPrice { get; set; } = 0.00;
        public double singleRoomPrice;
        public double singleKingRoomPrice;
        public double doubleRoomPrice;
        public double belleAireRoomPrice;
        public double lincolnRoomPrice;
        public int roomCount = 0;
        private string text;

        public string SelectedRoomText
        {
            get => text;
            set => text = value;
        }

        private void RoomLayout_Load(object sender, EventArgs e)
        {
            INIREAD();
            ComboBox_Creation();
            Resize();
        }

        private void ComboBox_Creation()
        {

            int numOfBoxes = Convert.ToInt32(text);

            for (int i = 0; i < numOfBoxes; i++)
            {
                string label = "Room " + (i + 1);
                ComboBox roomComboBox = new ComboBox();

              roomComboBox.Anchor = AnchorStyles.Top
                roomComboBox.Name = "roomComboBox" + i;
                roomComboBox.Items.AddRange(new object[]
                { "Single  " + singleRoomPrice.ToString("C"),
                  "Single king  " + singleKingRoomPrice.ToString("C"),
                  "Double  " + doubleRoomPrice.ToString("C"),
                  "BelleAire suit  " + belleAireRoomPrice.ToString("C"),
                  "Licoln suit  " + lincolnRoomPrice.ToString("C") });

                roomComboBox.Size = new Size(260, 31);
                roomComboBox.Location = new Point(123, 78 + i * 40);
                Controls.Add(roomComboBox);

                Label roomLabel = new Label();
                roomLabel.AutoSize = true;
                roomLabel.Location = new Point(25, 78 + i * 40);
                roomLabel.Name = "roomLabel" + i;
                roomLabel.Size = new Size(79, 23);
                roomLabel.Text = label;
                Controls.Add(roomLabel);
                roomCount++;
            }


            Button selectButton = new Button();
            selectButton.Location = new Point(124, 118 + roomCount * 40);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(183, 38);
            selectButton.TabIndex = 0;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            Controls.Add(selectButton);
        }



        private void GetRoom_Information()
        {

            List<int> selectedItems = new List<int>();
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedItem == null)
                    {
                        MessageBox.Show("Please select all the rooms.");
                        return;
                    }
                    else
                        selectedItems.Add(((ComboBox)control).SelectedIndex);
                }
            }

            int[] room = selectedItems.ToArray();

            foreach (int item in room)
            {
                switch (item)
                {
                    case 0:
                        roomPrice += singleRoomPrice;
                        break;
                    case 1:
                        roomPrice += singleKingRoomPrice;
                        break;
                    case 2:
                        roomPrice += doubleRoomPrice;
                        break;
                    case 3:
                        roomPrice += belleAireRoomPrice;
                        break;
                    case 4:
                        roomPrice += lincolnRoomPrice;
                        break;

                }
            }
        }

        private void selectButton_Click(object? sender, EventArgs e)
        {
            GetRoom_Information();
            this.Close();
        }
        private void INIREAD()
        {
            string iniFilePath = "C:\\Users\\flip2\\Desktop\\test.ini";
            IniFile iniFile = new IniFile(iniFilePath);
            singleRoomPrice = Convert.ToDouble(iniFile.Read("Room Prices", "Single"));
            singleKingRoomPrice = Convert.ToDouble(iniFile.Read("Room Prices", "Single king"));
            doubleRoomPrice = Convert.ToDouble(iniFile.Read("Room Prices", "Double"));
            belleAireRoomPrice = Convert.ToDouble(iniFile.Read("Room Prices", "BelleAire suit"));
            lincolnRoomPrice = Convert.ToDouble(iniFile.Read("Room Prices", "Lincoln suit"));
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

            int padding = 0;
            width += padding;
            height += padding;
            this.Size = new Size(width, height + 50);
        }
    }
}








public class IniFile
{
    public string Path { get; }

    // Import the GetPrivateProfileString method
    [DllImport("kernel32")]
    private static extern long GetPrivateProfileString(string section, string key, string @default, StringBuilder retVal, int size, string filePath);

    public IniFile(string path)
    {
        Path = path;
    }

    // Method to read a value from the .ini file
    public string Read(string section, string key)
    {
        var retVal = new StringBuilder(255);
        GetPrivateProfileString(section, key, "", retVal, 255, Path);
        return retVal.ToString();
    }
}



