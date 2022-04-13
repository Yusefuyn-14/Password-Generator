using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YK_47_Password_Generator
{
    public partial class passwordGeneratorForm : Form
    {
        public passwordGeneratorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                txtPassword.Text += randomChar().ToString();
            }
        }
        Random r = new Random();
        List<int> charList = new List<int>();

        private object randomChar()
        {
            return Convert.ToChar(charList[r.Next(0, charList.Count)]);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLowChar.Checked)
                for (int i = 97; i < 123; i++)
                    charList.Add(i);
            else
                for (int i = 97; i < 123; i++)
                    charList.Remove(i);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUpChar.Checked)
                for (int i = 65; i < 91; i++)
                    charList.Add(i);
            else
                for (int i = 65; i < 91; i++)
                    charList.Remove(i);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNumeric.Checked)
                for (int i = 48; i < 58; i++)
                    charList.Add(i);
            else
                for (int i = 48; i < 58; i++)
                    charList.Remove(i);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSymbol.Checked == true)
            {
                for (int i = 33; i < 48; i++)
                    charList.Add(i);
                for (int i = 58; i < 64; i++)
                    charList.Add(i);
                for (int i = 91; i < 97; i++)
                    charList.Add(i);
                for (int i = 123; i < 127; i++)
                    charList.Add(i);
            }
            else if (checkBoxSymbol.Checked == false)
            {
                for (int i = 33; i < 48; i++)
                    charList.Remove(i);
                for (int i = 58; i < 64; i++)
                    charList.Remove(i);
                for (int i = 91; i < 97; i++)
                    charList.Remove(i);
                for (int i = 123; i < 127; i++)
                    charList.Remove(i);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpecial.Checked == true)
                for (int i = 768; i < 865; i++)
                    charList.Add(i);
            if (checkBoxSpecial.Checked == false)
                for (int i = 768; i < 865; i++)
                    charList.Remove(i);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            Clipboard.SetText(txtPassword.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxLowChar.Checked = true;
            checkBoxUpChar.Checked = true;
            checkBoxNumeric.Checked = true;
            checkBoxSpecial.Checked = true;
            checkBoxSymbol.Checked = true;
        }
    }
}
