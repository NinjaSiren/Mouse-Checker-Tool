using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

//** Created by: John Daniel Esguerra, for private and public use, all source code is open sourced **//

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int currentdelta = 0;
        int scrollines = 0;
        int totaldelta = 0;
        int totalscrolllines = 0;

        public Form1()
        {
            InitializeComponent();

            display.Enabled = false;
            delta.Enabled = false;
            tdelta.Enabled = false;
            lines.Enabled = false;

            this.MouseWheel += Form_MouseWheel;
            this.MouseDoubleClick += Form_MouseDoubleClick;
            this.MouseClick += Form_MouseClick;
            this.MouseDown += Form_MouseDown;
            this.MouseUp += Form_MouseUp;         
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    display.Items.Add("Left Pressed");
                    break;

                case MouseButtons.Right:
                    display.Items.Add("Right Pressed");
                    break;

                case MouseButtons.Middle:
                    display.Items.Add("Middle Pressed");
                    break;

                case MouseButtons.XButton1:
                    display.Items.Add("Button A Pressed");
                    break;

                case MouseButtons.XButton2:
                    display.Items.Add("Button B Pressed");
                    break;
            }

            display.SelectedIndex = display.Items.Count - 1;
            display.SelectedIndex = -1;
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    display.Items.Add("Left Released");
                    break;

                case MouseButtons.Right:
                    display.Items.Add("Right Released");
                    break;

                case MouseButtons.Middle:
                    display.Items.Add("Middle Released");
                    break;

                case MouseButtons.XButton1:
                    display.Items.Add("Button A Released");
                    break;

                case MouseButtons.XButton2:
                    display.Items.Add("Button B Released");
                    break;
            }

            display.SelectedIndex = display.Items.Count - 1;
            display.SelectedIndex = -1;
        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    display.Items.Add("Left Clicked");
                    break;

                case MouseButtons.Right:
                    display.Items.Add("Right Clicked");
                    break;

                case MouseButtons.Middle:
                    display.Items.Add("Middle Clicked");
                    break;

                case MouseButtons.XButton1:
                    display.Items.Add("Button A Clicked");
                    break;

                case MouseButtons.XButton2:
                    display.Items.Add("Button B Clicked");
                    break;
            }

            display.SelectedIndex = display.Items.Count - 1;
            display.SelectedIndex = -1;
        }

        private void Form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    display.Items.Add("Left Double Clicked");
                    break;

                case MouseButtons.Right:
                    display.Items.Add("Right Double Clicked");
                    break;

                case MouseButtons.Middle:
                    display.Items.Add("Middle Double Clicked");
                    break;

                case MouseButtons.XButton1:
                    display.Items.Add("Button A Double Clicked");
                    break;

                case MouseButtons.XButton2:
                    display.Items.Add("Button B Double Clicked");
                    break;               
            }

            display.SelectedIndex = display.Items.Count - 1;
            display.SelectedIndex = -1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            display.Items.Clear();
            delta.Clear();
            tdelta.Clear();
            lines.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            currentdelta = e.Delta;
            scrollines = SystemInformation.MouseWheelScrollLines;

            totaldelta = totaldelta + currentdelta;
            totalscrolllines = scrollines * totaldelta / 120;

            delta.Text = currentdelta.ToString();
            tdelta.Text = totaldelta.ToString();
            lines.Text = totalscrolllines.ToString();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            string message = "Mouse Checker Tool\r\n"
                + "Version 1.0 build a1\r\n"
                + "Developed by John Daniel Esguerra/NinjaSiren\r\n"
                + "All source code is open-sourced and free to use\r\n"
                + "for both private, commercial, and public use.\r\n"
                + "\r\nSupport me on:\r\n"
                + "Soundcloud:\r\n" + "https://soundcloud.com/ninjasiren" + "\r\n"
                + "YouTube:\r\n" + "https://www.youtube.com/channel/UCcSzMZjAZA8xVqDOWUEcwZQ" + "\r\n"
                + "DeviantArt:\r\n" + "https://jdesguerra17.deviantart.com/" + "\r\n"
                + "ModDB:\r\n" + "http://www.moddb.com/members/ninjasiren" + "\r\n"
                + "\r\nFollow me on:\r\n"
                + "Twitter:\r\n" + "https://twitter.com/JDEsguerra17" + "\r\n"
                + "Facebook:\r\n" + "https://www.facebook.com/NinjaSiren" + "\r\n";
            string topbar = "About";

            MessageBox.Show(message,topbar, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
