namespace lab1_task1
{
    public partial class Form1 : Form
    {
        char[] sixteenSIletters = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F' };
        Color ErrorColor = Color.Transparent;
        public Form1()
        {
            InitializeComponent();


            ChangeColor();
        }
        bool isSwapValueComplete = true;
        private void ChangeColor()
        {
            if (isSwapValueComplete)
            {
                int red, green, blue;
                if (radioButtonDec.Checked)
                {
                    red = Convert.ToInt32(textboxRed.Text, 10);
                    green = Convert.ToInt32(textBoxGreen.Text, 10);
                    blue = Convert.ToInt32(textBoxBlue.Text, 10);
                }
                else
                {
                    red = Convert.ToInt32(textboxRed.Text, 16);
                    green = Convert.ToInt32(textBoxGreen.Text, 16);
                    blue = Convert.ToInt32(textBoxBlue.Text, 16);
                }
                if (radioButtonDec.Checked)
                {
                    panel1.BackColor = Color.FromArgb(red, green, blue);
                }
                else
                {
                    panel1.BackColor = Color.FromArgb(red, green, blue);
                }
            }
        }
        private string CheckMaxValue(string value)
        {

            if (radioButtonDec.Checked)
            {
                int val = Convert.ToInt32(value, 10);
                if (val >= 255)
                {
                    val = 255;
                    return val.ToString();
                }
                return val.ToString();
            }
            else
            {
                int val = Convert.ToInt32(value, 16);
                if (val >= 255)
                {
                    return "FF";
                }
                return value;
            }
        }

        private void textboxRed_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textboxRed.Text))
            {
                textboxRed.Text = CheckMaxValue(textboxRed.Text);
                ChangeColor();
            }
            else
            {
                textboxRed.Text = "0";
            }
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGreen.Text.StartsWith("0"))
            {
                textBoxGreen.Text.Remove(0, 1);
            }
            if (!string.IsNullOrWhiteSpace(textBoxGreen.Text))
            {
                textBoxGreen.Text = CheckMaxValue(textBoxGreen.Text);
                ChangeColor();
            }
            else
            {
                textBoxGreen.Text = "0";
            }
        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBlue.Text.StartsWith("0"))
            {
                textBoxBlue.Text.Remove(0, 1);
            }
            if (!string.IsNullOrWhiteSpace(textBoxBlue.Text))
            {
                textBoxBlue.Text = CheckMaxValue(textBoxBlue.Text);
                ChangeColor();
            }
            else
            {
                textBoxBlue.Text = "0";
            }
        }

        private void textboxRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!radioButtonDec.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && !sixteenSIletters.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBoxGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!radioButtonDec.Checked)
            {
                if (!sixteenSIletters.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!radioButtonDec.Checked)
            {
                if (!sixteenSIletters.Contains(e.KeyChar) && e.KeyChar != (char)Keys.ShiftKey)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDec.Checked)
            {
                isSwapValueComplete = false;
                textboxRed.Text = Convert.ToInt32(textboxRed.Text, 16).ToString();
                textBoxGreen.Text = Convert.ToInt32(textBoxGreen.Text, 16).ToString();
                textBoxBlue.Text = Convert.ToInt32(textBoxBlue.Text, 16).ToString();
                isSwapValueComplete = true;
            }
            else
            {
                isSwapValueComplete = false;
                textboxRed.Text = Convert.ToInt32(textboxRed.Text).ToString("x");
                textBoxGreen.Text = Convert.ToInt32(textBoxGreen.Text).ToString("x");
                textBoxBlue.Text = Convert.ToInt32(textBoxBlue.Text).ToString("x");
                isSwapValueComplete = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public static class Extensions
    {
        public static string ConvertToHex(this string value)
        {
            return int.Parse(value, System.Globalization.NumberStyles.HexNumber).ToString();
        }
    }
}