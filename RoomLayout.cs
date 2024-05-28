using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_06_01_BedAndBreakfast_MB
{
    public partial class RoomLayout : Form
    {
        public RoomLayout()
        {
            InitializeComponent();
        }
        public int count = 0;
        private int roomIndex;
        private string text;

        public int SelectedRoomIndex
        {
            get => roomIndex;
            set => roomIndex = value;
        }
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
                roomComboBox.Items.AddRange(new object[] { "Test 1", "Test 2" });
                roomComboBox.Size = new Size(260, 31);
                roomComboBox.Location = new Point(123, 78 + i * 40);
                Controls.Add(roomComboBox);

                Label roomLabel = new Label();
                roomLabel.Location = new Point(25, 78 + i * 40);
                roomLabel.Name = "roomLabel" + i;
                roomLabel.Size = new Size(79, 23);
                roomLabel.Text = label;
                Controls.Add(roomLabel);
                count++;
            }
        }
        private void GetRoom_Properties()
        {
            List<Object> selectedItems = new List<object>();
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox roomProperties = (ComboBox)control;
                    selectedItems.Add(roomProperties.SelectedItem);
                }
            }
            object[] room = selectedItems.ToArray();

            foreach (object item in room)
            {
                MessageBox.Show(item.ToString());
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
                height += control.PreferredSize.Height;
            }

            int padding = 50;
            width += padding;
            height += padding;
            this.Size = new Size(width, height);

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            GetRoom_Properties();
        }
    }
}
