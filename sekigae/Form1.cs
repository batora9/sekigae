using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;

namespace sekigae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // FormBorderStyle 参照
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("人数を選択してください", "席替えソフト", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            else if(textBox2.Text == comboBox1.Text)
            {
                Form2 f2 = new Form2(comboBox1.Text + textBox1.Text);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("人数を設定しなおしてください", "席替えソフト", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                using (StreamReader streamReader = new StreamReader(filename))
                {

                    //textBox1.Text = streamReader.ReadToEnd();
                    label4.Text = Path.GetFileName(filename);
                    string a1 = streamReader.ReadToEnd();
                    textBox1.Text = a1;

                    if (0 <= a1.IndexOf("/sekigae/"))
                    {
                        string sea = a1.Substring(2, 2);
                        //人数取得
                        textBox2.Text = sea;
                        
                        button1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("データが破損しています", "席替えソフト", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        button1.Enabled = false;
                    }
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
