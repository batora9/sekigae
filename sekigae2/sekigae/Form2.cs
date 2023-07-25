using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace sekigae
{
    public partial class Form2 : Form
    {
        private int i;

        public Form2()
        {
            InitializeComponent();
        }



        public Form2(string ninzu)
        {
            InitializeComponent();
            string p = ninzu.Substring(0, 2);
            string s = ninzu.Substring(2);//2 15
            s = s.Replace(Environment.NewLine, "");
            textBox1.Text = s;
            label2.Text = p;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            Form1 form1 = new Form1();
            form1.Close();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // FormBorderStyle 参照
            MessageBox.Show(label2.Text + "人分の席を設定します。クラスの番号順に席の場所のボタンをクリックして下さい", "席替えソフト", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            i = 0;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button14.Text = s;
                button14.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button1.Text = s;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button2.Text = s;
                button2.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button3.Text = s;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button4.Text = s;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button5.Text = s;
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button6.Text = s;
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button7.Text = s;
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button8.Text = s;
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button9.Text = s;
                button9.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button10.Text = s;
                button10.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button11.Text = s;
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button12.Text = s;
                button12.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button13.Text = s;
                button13.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button15.Text = s;
                button15.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button16.Text = s;
                button16.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button17.Text = s;

                button17.Enabled = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button18.Text = s;
                button18.Enabled = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button19.Text = s;
                button19.Enabled = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button20.Text = s;
                button20.Enabled = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button21.Text = s;
                button21.Enabled = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button22.Text = s;
                button22.Enabled = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button23.Text = s;
                button23.Enabled = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button24.Text = s;
                button24.Enabled = false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button25.Text = s;
                button25.Enabled = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button26.Text = s;
                button26.Enabled = false;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button27.Text = s;
                button27.Enabled = false;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button28.Text = s;
                button28.Enabled = false;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button29.Text = s;
                button29.Enabled = false;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button30.Text = s;
                button30.Enabled = false;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button31.Text = s;
                button31.Enabled = false;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button32.Text = s;
                button32.Enabled = false;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button33.Text = s;
                button33.Enabled = false;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button34.Text = s;
                button34.Enabled = false;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button35.Text = s;
                button35.Enabled = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button36.Text = s;
                button36.Enabled = false;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button37.Text = s;
                button37.Enabled = false;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button38.Text = s;
                button38.Enabled = false;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button39.Text = s;
                button39.Enabled = false;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button40.Text = s;
                button40.Enabled = false;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button41.Text = s;
                button41.Enabled = false;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i < num)
            {
                i = i + 1;
                string s = i.ToString();
                button42.Text = s;
                button42.Enabled = false;
            }
        }

        private string subwww;
        private string womensub;

        private void button43_Click(object sender, EventArgs e)
        {
            string st = label2.Text;
            int num = int.Parse(st);
            if (i == num)
            {
                string s1 = textBox1.Text;
                int rar = (s1.IndexOf(";men") + 4);
                int rar2 = (s1.IndexOf("//mEnd") - 17);
                string men = s1.Substring(rar, rar2);

                int rar3 = (s1.IndexOf(";women") + 6);
                string sb = s1.Substring(rar3);
                int sbb = sb.Length;
                string women = sb.Substring(0, sbb - 6);


                Button[] buttons = new Button[43];
                buttons[0] = button44; buttons[1] = button1; buttons[2] = button2; buttons[3] = button3; buttons[4] = button4; buttons[5] = button5;
                buttons[6] = button6; buttons[7] = button7; buttons[8] = button8; buttons[9] = button9; buttons[10] = button10; buttons[11] = button11; buttons[12] = button12; buttons[13] = button13;
                buttons[14] = button14; buttons[15] = button15; buttons[16] = button16; buttons[17] = button17;
                buttons[18] = button18; buttons[19] = button19; buttons[20] = button20; buttons[21] = button21; buttons[22] = button22; buttons[23] = button23; buttons[24] = button24; buttons[25] = button25; buttons[26] = button26; buttons[27] = button27; buttons[28] = button28; buttons[29] = button29; buttons[30] = button30; buttons[31] = button31; buttons[32] = button32; buttons[33] = button33; buttons[34] = button34; buttons[35] = button35; buttons[36] = button36; buttons[37] = button37; buttons[38] = button38; buttons[39] = button39; buttons[40] = button40; buttons[41] = button41; buttons[42] = button42;

                string[] mains = new string[] { buttons[0].Text,buttons[1].Text, buttons[2].Text, buttons[3].Text, buttons[4].Text, buttons[5].Text, buttons[6].Text, buttons[7].Text, buttons[8].Text, buttons[9].Text, buttons[10].Text, buttons[11].Text, buttons[12].Text, buttons[13].Text, buttons[14].Text, buttons[15].Text, buttons[16].Text, buttons[17].Text, buttons[18].Text, buttons[19].Text, buttons[20].Text, buttons[21].Text, buttons[22].Text, buttons[23].Text, buttons[24].Text, buttons[25].Text, buttons[26].Text, buttons[27].Text, buttons[28].Text, buttons[29].Text, buttons[30].Text, buttons[31].Text, buttons[32].Text, buttons[33].Text, buttons[34].Text, buttons[35].Text, buttons[36].Text, buttons[37].Text, buttons[38].Text, buttons[39].Text, buttons[40].Text, buttons[41].Text, buttons[42].Text };
                //男子
                for (int v = 0; v < men.Length - 1; v += 2)
                {
                    string ment = men.Substring(v, 2);
                    int om = ment.IndexOf("0");
                    //0削除
                    if (om == 0)
                    {
                        ment = ment.Remove(0, 1);
                    }
                    //検出
                    for (int countselect = 1; countselect <= 42;)
                    {
                        if (ment == mains[countselect])
                        {
                            string www = countselect.ToString();
                            if(www.Length == 1)
                            {　www = "0" + www;　}
                            subwww = subwww + www;
                            countselect = 50;
                        }
                        else
                        { countselect++; }  
                    }

                }
                string menSeki = subwww;

                //女子
                for (int v = 0; v < women.Length - 1; v += 2)
                {
                    string ment = women.Substring(v, 2);
                    int om = ment.IndexOf("0");
                    //0削除
                    if (om == 0)
                    {
                        ment = ment.Remove(0, 1);
                    }
                    //検出
                    for (int countselect2 = 0; countselect2 < 43;)
                    {
                        if (ment == mains[countselect2])
                        {
                            string www = countselect2.ToString();
                            if (www.Length == 1)
                            { www = "0" + www; }
                            womensub = womensub + www;
                            countselect2 = 43;
                        }
                        else
                        { countselect2++; }
                    }
                }
                string woSeki = womensub;


                //MessageBox.Show(menSeki + "A" + woSeki);
                Form4 f4 = new Form4();
                FormSet fS = new FormSet(label2.Text + "," + men + "," + women + "," + menSeki + "," + woSeki);
                DialogResult fS2 = fS.ShowDialog();
                if(Enum.GetName(typeof(DialogResult), fS2) == "Yes")
                {
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("すべての人数を選択してください", "席替えソフト", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Button[] buttons = new Button[43];
            buttons[0] = button44;
            buttons[1] = button1;
            buttons[2] = button2;
            buttons[3] = button3;
            buttons[4] = button4;
            buttons[5] = button5;
            buttons[6] = button6;
            buttons[7] = button7;
            buttons[8] = button8;
            buttons[9] = button9;
            buttons[10] = button10;
            buttons[11] = button11;
            buttons[12] = button12;
            buttons[13] = button13;
            buttons[14] = button14;
            buttons[15] = button15;
            buttons[16] = button16;
            buttons[17] = button17;
            buttons[18] = button18;
            buttons[19] = button19;
            buttons[20] = button20;
            buttons[21] = button21;
            buttons[22] = button22;
            buttons[23] = button23;
            buttons[24] = button24;
            buttons[25] = button25;
            buttons[26] = button26;
            buttons[27] = button27;
            buttons[28] = button28;
            buttons[29] = button29;
            buttons[30] = button30;
            buttons[31] = button31;
            buttons[32] = button32;
            buttons[33] = button33;
            buttons[34] = button34;
            buttons[35] = button35;
            buttons[36] = button36;
            buttons[37] = button37;
            buttons[38] = button38;
            buttons[39] = button39;
            buttons[40] = button40;
            buttons[41] = button41;
            buttons[42] = button42;

            if (MessageBox.Show(
"リセットしますか？",
"席替えソフト",
MessageBoxButtons.YesNo,  // ボタンの一覧は MessageBoxButtons 参照
MessageBoxIcon.Question   // アイコンの一覧は  MessageBoxIcon 参照
)
== DialogResult.Yes)
            {
                int reset = 1;
                while (reset < 43)
                {
                    buttons[reset].Text = "";
                    buttons[reset].Enabled = true;
                    reset++;
                }
                i = 0;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
        "取り消しますか？",
        "席替えソフト",
        MessageBoxButtons.YesNo,  // ボタンの一覧は MessageBoxButtons 参照
        MessageBoxIcon.Question   // アイコンの一覧は  MessageBoxIcon 参照
    )
    == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
