using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLibryary
{
    public partial class ColorPicler : UserControl
    {
        private List<TextBox> txtBoxs = new List<TextBox>();

        private string red;
        private string green;
        private string blue;

        public int Red
        {
            get => GetValue(red, isDec);
            set
            {
                int val = NormalizeRange(value);
                red = SetValue(val, isDec);
                txt_Red.Text = red;
                SetColor();
            }
        }

        public int Green
        {
            get => GetValue(green, isDec);
            set
            {
                int val = NormalizeRange(value);
                green = SetValue(val, isDec);
                txt_Green.Text = green;
                SetColor();
            }
        }

        public int Blue
        {
            get => GetValue(blue, isDec);
            set
            {
                int val = NormalizeRange(value);
                blue = SetValue(val, isDec);
                txt_Blue.Text = blue;
                SetColor();
            }
        }

        private bool isDec = true;

        public ColorPicler()
        {
            InitializeComponent();
            txtBoxs.Add(txt_Red);
            txtBoxs.Add(txt_Green);
            txtBoxs.Add(txt_Blue);
        }

        private void SetColor()
        {
            if (Red > 0 && Green > 0 && Blue > 0)
            {
                var color = Color.FromArgb(Red, Green, Blue);
                if (panel_color.BackColor != color)
                {
                    panel_color.BackColor = color;
                    //MessageBox.Show("new color");
                }
            }
        }

        private string SetValue(int num, bool dec) => dec ? num.ToString() : num.ToString("X");

        private int GetValue(string str, bool dec) => dec ? Convert.ToInt32(str) : Convert.ToInt32(str, 16);

        private int NormalizeRange(int num)
        {
            var max = 255;
            var min = 0;

            if (num < min) num = min;
            if (num > max) num = max;
            return num;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isDec)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar) || (e.KeyChar >= 97 && e.KeyChar <= 102) ||
                     (e.KeyChar >= 65 && e.KeyChar <= 70) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void radio_dec_CheckedChanged(object sender, EventArgs e)
        {
            isDec = !isDec;
            var txt = txt_Red;
            if (txt.Text.Length > 0)
            {
                txt.TextChanged -= txt_Red_TextChanged;
                red = SetValue(GetValue(txt.Text, !isDec), isDec);
                txt.Text = red;
                txt.SelectionStart = txt.TextLength;
                txt.TextChanged += txt_Red_TextChanged;
            }

            txt = txt_Green;
            if (txt.Text.Length > 0)
            {
                txt.TextChanged -= txt_Green_TextChanged;
                green = SetValue(GetValue(txt.Text, !isDec), isDec);
                txt.Text = green;
                txt.SelectionStart = txt.TextLength;
                txt.TextChanged += txt_Green_TextChanged;
            }

            txt = txt_Blue;
            if (txt.Text.Length > 0)
            {
                txt.TextChanged -= txt_Blue_TextChanged;
                blue = SetValue(GetValue(txt.Text, !isDec), isDec);
                txt.Text = blue;
                txt.SelectionStart = txt.TextLength;
                txt.TextChanged += txt_Blue_TextChanged;
            }
        }

        private string ValidateText(string text)
        {
            string str = String.Empty;

            foreach (var s in text)
            {
                if (isDec)
                {
                    if (char.IsDigit(s)) str += s;
                }
                else
                {
                    if (char.IsDigit(s) || ((int)s >= 97 && (int)s <= 102) || ((int)s>=65 && (int)s <= 70))
                    {
                        str += s;
                    }
                }
            }

            return str;
        }
        private void txt_Red_TextChanged(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            if (txt.TextLength > 0)
            {                          
                txt.TextChanged -= txt_Red_TextChanged;                
                var selectedIndex = txt.SelectionStart;
                txt.Text = ValidateText(txt.Text);
                Red = NormalizeRange(GetValue(txt.Text, isDec));
                txt.SelectionStart = selectedIndex;
                txt.TextChanged += txt_Red_TextChanged;
            }
        }

        private void txt_Green_TextChanged(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            if (txt.TextLength > 0)
            {
                txt.TextChanged -= txt_Green_TextChanged;                
                var selectedIndex = txt.SelectionStart;
                txt.Text = ValidateText(txt.Text);
                Green = NormalizeRange(GetValue(txt.Text, isDec));
                txt.SelectionStart = selectedIndex;
                txt.TextChanged += txt_Green_TextChanged;
            }
        }

        private void txt_Blue_TextChanged(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            if (txt.TextLength > 0)
            {
                txt.TextChanged -= txt_Blue_TextChanged;                
                var selectedIndex = txt.SelectionStart;
                txt.Text = ValidateText(txt.Text);
                Blue = NormalizeRange(GetValue(txt.Text, isDec));
                txt.SelectionStart = selectedIndex;
                txt.TextChanged += txt_Blue_TextChanged;
            }
        }
    }
}