using HotelProject.Model;
using System;
using System.Text;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class Form1 : Form
    {
        Hotel hotelObject;

        public Form1(Hotel h)
        {
            InitializeComponent();
            hotelObject = h;
        }

        #region ReportNeedForCleaning
        private void ButtonReportNeedForCleaning_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            AddTextBoxToPane("RoomNumberToClean");
            AddButtonToPane("Report");
            Button b = (Button)flowLayoutPanel.Controls[2];
            b.Click += (s, ea) => { ReportNeedForCleaningButtonClick(); };
        }

        private void ReportNeedForCleaningButtonClick()
        {
            TextBox tb = (TextBox)flowLayoutPanel.Controls[1];
            int roomNumber = Int32.Parse(tb.Text);
            hotelObject.ReportNeedForCleaning(roomNumber);
            if(flowLayoutPanel.Controls.Count == 4)
            {
                flowLayoutPanel.Controls.RemoveAt(3);
                Label l = new Label { Text = "Already reported" };
                flowLayoutPanel.Controls.Add(l);
            }
            else
            {
                Label l = new Label { Text = "Reported" };
                flowLayoutPanel.Controls.Add(l);
            }
        }
        #endregion

        #region ReportNeedForRepairing
        private void ButtonReportNeedForRepair_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            AddTextBoxToPane("RoomNumberToRepair");
            AddButtonToPane("Report");
            Button b = (Button)flowLayoutPanel.Controls[2];
            b.Click += (s, ea) => { ReportNeedForRepairingButtonClick(); };
        }

        private void ReportNeedForRepairingButtonClick()
        {
            TextBox tb = (TextBox)flowLayoutPanel.Controls[1];
            int roomNumber = Int32.Parse(tb.Text);
            hotelObject.ReportNeedForRepair(roomNumber);
            if (flowLayoutPanel.Controls.Count == 4)
            {
                flowLayoutPanel.Controls.RemoveAt(3);
                Label l = new Label { Text = "Already reported" };
                flowLayoutPanel.Controls.Add(l);
            }
            else
            {
                Label l = new Label { Text = "Reported" };
                flowLayoutPanel.Controls.Add(l);
            }
        }
        #endregion

        #region ReportExecutionOfRepairing
        private void ButtonReportExecutionOfRepair_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            AddTextBoxToPane("RepairedRoomNumber");
            AddCheckBoxToPane("Occupied", "Check if room is occupied");
            AddButtonToPane("Report");
            Button b = (Button)flowLayoutPanel.Controls[4];
            b.Click += (s, ea) => { ReportExecutionOfRepairButtonClick(); };
        }

        private void ReportExecutionOfRepairButtonClick()
        {
            TextBox tb = (TextBox)flowLayoutPanel.Controls[1];
            int roomNumber = Int32.Parse(tb.Text);
            CheckBox cb = (CheckBox)flowLayoutPanel.Controls[3];
            bool occupied = cb.Checked;
            hotelObject.ReportExecutionOfRepair(roomNumber, occupied);
            if (flowLayoutPanel.Controls.Count == 6)
            {
                flowLayoutPanel.Controls.RemoveAt(5);
                Label l = new Label { Text = "Already reported" };
                flowLayoutPanel.Controls.Add(l);
            }
            else
            {
                Label l = new Label { Text = "Reported" };
                flowLayoutPanel.Controls.Add(l);
            }
        }
        #endregion

        #region ReportExecutionOfCleaning
        private void ButtonReportExecutionOfCleaning_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            AddTextBoxToPane("CleanedRoomNumber");
            AddCheckBoxToPane("Occupied", "Check if room is occupied");
            AddButtonToPane("Report");
            Button b = (Button)flowLayoutPanel.Controls[4];
            b.Click += (s, ea) => { ReportExecutionOfCleaningButtonClick(); };
        }

        private void ReportExecutionOfCleaningButtonClick()
        {
            TextBox tb = (TextBox)flowLayoutPanel.Controls[1];
            int roomNumber = Int32.Parse(tb.Text);
            CheckBox cb = (CheckBox)flowLayoutPanel.Controls[3];
            bool occupied = cb.Checked;
            hotelObject.ReportExecutionOfCleaning(roomNumber, occupied);
            if (flowLayoutPanel.Controls.Count == 6)
            {
                flowLayoutPanel.Controls.RemoveAt(5);
                Label l = new Label { Text = "Already reported" };
                flowLayoutPanel.Controls.Add(l);
            }
            else
            {
                Label l = new Label { Text = "Reported" };
                flowLayoutPanel.Controls.Add(l);
            }
        }
        #endregion

        #region FindFreeRoom
        private void ButtonFindFreeRoom_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            AddMonthCalendarToPane("StartDate");
            AddMonthCalendarToPane("EndDate");
            AddTextBoxToPane("Capacity");
            AddButtonToPane("Find");
            Button b = (Button)flowLayoutPanel.Controls[6];
            b.Click += (s, ea) => { FindFreeRoomButtonClick(); };
        }

        private void FindFreeRoomButtonClick()
        {
            MonthCalendar mc = (MonthCalendar)flowLayoutPanel.Controls[1];
            DateTime startDate = mc.SelectionStart;
            mc = (MonthCalendar)flowLayoutPanel.Controls[3];
            DateTime endDate = mc.SelectionStart;
            TextBox tb = (TextBox)flowLayoutPanel.Controls[5];
            int capacity = Int32.Parse(tb.Text);
            int[] matchingRoomsNumbers = hotelObject.FindFreeRoom(startDate, endDate, capacity);
            if (flowLayoutPanel.Controls.Count == 8)
                flowLayoutPanel.Controls.RemoveAt(7);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Znalezione pokoje:");
            for (int i = 0; i < matchingRoomsNumbers.Length; i++)
                sb.Append(matchingRoomsNumbers[i] + ", ");
            Label l = new Label { Text = sb.ToString() };
            flowLayoutPanel.Controls.Add(l);
        }
        #endregion

        #region flowLayoutPanel control adders
        /// <summary>
        /// Adds textbox to main pane in gui
        /// </summary>
        /// <param name="name">label contain name, name of textbox is textBox(Name)</param>
        private void AddTextBoxToPane(String name)
        {
            int w = flowLayoutPanel.Width - 10;// tableLayoutPanel1.Width;
            TextBox tb = new TextBox
            {
                Name = "textBox" + name,
                Width = w
            };
            Label l = new Label
            {
                Width = w,
                Text = name
            };
            flowLayoutPanel.Controls.Add(l);
            flowLayoutPanel.Controls.Add(tb);
        }

        /// <summary>
        /// Adds MonthCalendar to main pane in gui
        /// </summary>
        /// <param name="name">label contain name, name of MonethCalendar is monthCalendar(Name)</param>
        private void AddMonthCalendarToPane(String name)
        {
            int w = flowLayoutPanel.Width -  tableLayoutPanel1.Width;
            MonthCalendar mc = new MonthCalendar
            {
                Name = "monthCalendar" + name,
                Width = w
            };
            Label l = new Label
            {
                Width = w,
                Text = "Pick a "+name
            };
            flowLayoutPanel.Controls.Add(l);
            flowLayoutPanel.Controls.Add(mc);
        }

        /// <summary>
        /// Adds textbox to main pane in gui
        /// </summary>
        /// <param name="name">label contain name, name of textbox is textBox(Name)</param>
        private void AddButtonToPane(String name)
        {
            int w = flowLayoutPanel.Width - 10;// tableLayoutPanel1.Width;
            Button b = new Button
            {
                Name = "button" + name,
                Text = name,
                Width = w
            };
            flowLayoutPanel.Controls.Add(b);
        }

        /// <summary>
        /// Adds checkbox to main pane in gui
        /// </summary>
        /// <param name="name">checkbox name will be "checkBox(name)"</param>
        /// <param name="text">Description displayed above checkbox</param>
        private void AddCheckBoxToPane(String name, String text)
        {
            int w = flowLayoutPanel.Width - 10;// tableLayoutPanel1.Width;
            CheckBox cb = new CheckBox
            {
                Name = "checkBox" + name,
                Text = name,
                Width = w
            };
            Label l = new Label
            {
                Width = w,
                Text = text
            };
            flowLayoutPanel.Controls.Add(l);
            flowLayoutPanel.Controls.Add(cb);
        }
        #endregion
    }
}
