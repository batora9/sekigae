using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekigae
{
    public partial class FormSet : Form
    {
        public FormSet()
        {
            InitializeComponent();
        }

        public FormSet(string Set)
        {
            InitializeComponent();
            textBox1.Text =  Set;
        }
        private int setting;

        private void FormSet_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // FormBorderStyle 参照
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            textBox1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (radioButton3.Checked == true)
                {
                    setting = 1;
                }
                else if (radioButton4.Checked == true)
                {
                    setting = 2;
                }
                else if (radioButton5.Checked == true)
                {
                    setting = 3;
                }
            }
            else
            {
                if (radioButton3.Checked == true)
                {
                    setting = 4;
                }
                else if (radioButton4.Checked == true)
                {
                    setting = 5;
                }
                else if (radioButton5.Checked == true)
                {
                    setting = 6;
                }

            }
            Form3 f3 = new Form3(textBox1.Text + "," + setting.ToString());
            f3.Show();
            this.Close();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "ランダムで配置されます。";
            }
            else
            {
                label2.Text = "配置に前回と重ならないようにします。";
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "ランダムで配置されます。";
            }
            else
            {
                label2.Text = "前回の配置と重ならないようにします。";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //f2.Show();
            this.Close();
        }

        private void FormSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
