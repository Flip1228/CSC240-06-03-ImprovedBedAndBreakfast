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
        public double price { get; set; } = 0.00;
        public int roomCount = 0;
        private string text;

        public string SelectedRoomText
        {
            get => text;
            set => text = value;
        }
        private void ComboBox_Creation()
        {

            int test = Convert.ToInt32(text);

            for (int i = 0; i < test; i++)
            {
                string label = "Room " + (i + 1);
                ComboBox roomComboBox = new ComboBox();

                roomComboBox.Name = "roomComboBox" + i;
                roomComboBox.Items.AddRange(new object[] { "Single", "Single King", "Double", "BelleAire Suit", "Licoln Suit" });
                roomComboBox.Size = new Size(260, 31);
                roomComboBox.Location = new Point(123, 78 + i * 40);
                Controls.Add(roomComboBox);

                Label roomLabel = new Label();
                roomLabel.Location = new Point(25, 78 + i * 40);
                roomLabel.Name = "roomLabel" + i;
                roomLabel.Size = new Size(79, 23);
                roomLabel.Text = label;
                Controls.Add(roomLabel);
                roomCount++;
            }
            LinkLabel roomInfo = new LinkLabel();
            roomInfo.Location = new Point(144, 86 + roomCount * 40);
            roomInfo.Name = "roomInfo_link";
            roomInfo.Size = new Size(150, 23);
            roomInfo.Text = "Room Information";
            roomInfo.Click += RoomInfo_Click;
            Controls.Add(roomInfo);

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

        private void RoomInfo_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GetRoom_Information()
        {

            string iniFilePath = "C:\\Users\\flip2\\Desktop\\test.ini";
            IniFile iniFile = new IniFile(iniFilePath);
            double singleRoomPrice = Convert.ToDouble(iniFile.Read("Room Prices", "Single"));

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
            int count = 0;

            foreach (int item in room)
            {
                switch (item)
                {
                    case 0:
                        MessageBox.Show("Room " + (room[count] + 1) + " is a single");
                        price += singleRoomPrice;
                        count++;
                        break;
                    case 1:
                        MessageBox.Show("Room " + (room[count] + 1) + " is a Single King");
                        price += 100.00;
                        count++;
                        break;
                    case 2:
                        MessageBox.Show("Room " + (room[count] + 1) + " is a Double");
                        count++;
                        break;
                    case 3:
                        MessageBox.Show("Room " + (room[count] + 1) + " is the BelleAire Suit");
                        count++;
                        break;
                    case 4:
                        MessageBox.Show("Room " + (room[count] + 1) + " is The lincoln suit");
                        count++;
                        break;

                }
            }
        }

        private void RoomLayout_Load(object sender, EventArgs e)
        {
            ComboBox_Creation();
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

        private void selectButton_Click(object? sender, EventArgs e)
        {
            GetRoom_Information();
            this.Close();
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



