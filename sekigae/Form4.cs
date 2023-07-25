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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private string ninzu;
        private string men;
        private string women;
        private string menSeki;
        private string womenSeki;
        private string allSeki;
        private int mode;

        public Form4(string z)
        {
            InitializeComponent();

            // カンマ区切りで分割して配列に格納する
            textBox1.Text = z;
            string[] stArrayData = z.Split(',');
            ninzu = stArrayData[0];
            mode = int.Parse(stArrayData[5]);


            for (int x = 0; x < stArrayData[1].Length - 1; x += 2)
            {
                men = men + "," + (stArrayData[1].Substring(x, 2));
            }
            for (int x = 0; x < stArrayData[2].Length - 1; x += 2)
            {
                women = women + "," + (stArrayData[2].Substring(x, 2));
            }
            for (int x = 0; x < stArrayData[3].Length - 1; x += 2)
            {
                menSeki = menSeki + "," + (stArrayData[3].Substring(x, 2));
            }
            for (int x = 0; x < stArrayData[4].Length - 1; x += 2)
            {
                womenSeki = womenSeki + "," + (stArrayData[4].Substring(x, 2));
            }
            allSeki = menSeki + womenSeki;
            allSeki = allSeki.Remove(0, 1); //文字列
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // FormBorderStyle 参照
            Button[] buttons = new Button[43];
            buttons[0] = button44; buttons[1] = button1; buttons[2] = button2; buttons[3] = button3; buttons[4] = button4; buttons[5] = button5;
            buttons[6] = button6; buttons[7] = button7; buttons[8] = button8; buttons[9] = button9; buttons[10] = button10; buttons[11] = button11; buttons[12] = button12; buttons[13] = button13;
            buttons[14] = button14; buttons[15] = button15; buttons[16] = button16; buttons[17] = button17;
            buttons[18] = button18; buttons[19] = button19; buttons[20] = button20; buttons[21] = button21; buttons[22] = button22; buttons[23] = button23; buttons[24] = button24; buttons[25] = button25; buttons[26] = button26; buttons[27] = button27; buttons[28] = button28; buttons[29] = button29; buttons[30] = button30; buttons[31] = button31; buttons[32] = button32; buttons[33] = button33; buttons[34] = button34; buttons[35] = button35; buttons[36] = button36; buttons[37] = button37; buttons[38] = button38; buttons[39] = button39; buttons[40] = button40; buttons[41] = button41; buttons[42] = button42;
            //swirch 6のみ
            string[] buttonstext = new string[43] { "44", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42" };

            switch (mode)
            {
                case 1://2.0修正済
                    menSeki = menSeki.Remove(0, 1);
                    womenSeki = womenSeki.Remove(0, 1);
                    men = men.Remove(0, 1);
                    women = women.Remove(0, 1);
                    string[] ms = menSeki.Split(',');
                    string[] ws = womenSeki.Split(',');
                    string[] md = men.Split(',');
                    string[] wd = women.Split(',');

                    //デバック
                    if (ms.Length != md.Length || ws.Length != wd.Length)
                    {
                        MessageBox.Show("エラーが発生しました。");
                        Application.Exit();
                    }

                    //,消しと並べる
                    Array.Sort(ms);
                    md = md.OrderBy(i => Guid.NewGuid()).ToArray();
                    for (int j = 0; j < ms.Length; j++)
                    {
                        buttons[int.Parse(ms[j])].Text = md[j];
                    }
                    Array.Sort(ws);
                    wd = wd.OrderBy(i => Guid.NewGuid()).ToArray();
                    for (int j = 0; j < ws.Length; j++)
                    {
                        buttons[int.Parse(ws[j])].Text = wd[j];
                    }

                    //0消し
                    for (int k = 1; k < 42; k++)
                    {
                        if (buttons[k].Text.IndexOf("0") == 0)
                        {
                            buttons[k].Text = buttons[k].Text.Remove(0, 1);
                        }
                    }
                    break;

                case 2://2.0修正済
                    menSeki = menSeki.Remove(0, 1);
                    womenSeki = womenSeki.Remove(0, 1);
                    men = men.Remove(0, 1);

                    //全員の場所
                    string[] aSDataN = allSeki.Split(',');
                    Array.Sort(aSDataN);
                    //人
                    string allpN = men + women;
                    string[] allDN = allpN.Split(',');
                    Array.Sort(allDN); //配列を順番に並び替える


                    //デバック
                    if (aSDataN.Length != allDN.Length)
                    {
                        MessageBox.Show("エラーが発生しました。");
                        Application.Exit();
                    }

                    //men & women
                    //shuffle
                    allDN = allDN.OrderBy(i => Guid.NewGuid()).ToArray();
                    for (int i = 0; i < allDN.Length; i++)
                    {
                        buttons[int.Parse(aSDataN[i])].Text = allDN[i];
                    }
                    //0消し
                    for (int k = 1; k < 42; k++)
                    {
                        if (buttons[k].Text.IndexOf("0") == 0)
                        {
                            buttons[k].Text = buttons[k].Text.Remove(0, 1);
                        }
                    }

                    break;

                case 3://2.0修正済
                    men = men.Remove(0, 1);

                    //全員
                    string all = men + women;
                    string[] alld = all.Split(',');
                    Array.Sort(alld); //配列を順番に並び替える

                    //buttonstext = buttonstext.OrderBy(i => Guid.NewGuid()).ToArray();
                    alld = alld.OrderBy(i => Guid.NewGuid()).ToArray();
                    //シャッフル
                    Random nRandom = new Random();
                    for (int i = 0; i < alld.Length;)
                    {
                        int k1 = nRandom.Next(1, 42);
                        if (buttonstext[k1] != null)
                        {
                            if (buttons[int.Parse(buttonstext[k1])].Text != alld[i])
                            {
                                buttons[k1].Text = alld[i];
                                Array.Clear(buttonstext, k1, 1);//nullになる
                                i++;
                            }
                        }
                    }


                    //0消し
                    for (int k = 1; k < 42; k++)
                    {
                        if (buttons[k].Text.IndexOf("0") == 0)
                        {
                            buttons[k].Text = buttons[k].Text.Remove(0, 1);
                        }
                    }
                    break;

                case 4: //2.0修正済
                    {
                        menSeki = menSeki.Remove(0, 1);
                        womenSeki = womenSeki.Remove(0, 1);
                        men = men.Remove(0, 1);
                        women = women.Remove(0, 1);
                        string[] mSData = menSeki.Split(',');
                        string[] wSData = womenSeki.Split(',');
                        string[] mData = men.Split(',');
                        string[] wData = women.Split(',');

                        for (int c = 0; c < mSData.Length; c++)
                        {
                            buttons[int.Parse(mSData[c])].Text = mData[c];
                        }

                        for (int c = 0; c < wSData.Length; c++)
                        {
                            buttons[int.Parse(wSData[c])].Text = wData[c];
                        }

                        //デバック
                        if (mSData.Length != mData.Length || wSData.Length != wData.Length)
                        {
                            MessageBox.Show("エラーが発生しました。");
                            Application.Exit();
                        }

                        //男子
                        //men配列
                        Array.Sort(mSData);
                        //shuffle
                        mData = mData.OrderBy(i => Guid.NewGuid()).ToArray();
                        Random cRandom = new System.Random();
                        for (int c = 0; c < mSData.Length;)
                        {
                            int i1 = cRandom.Next(0, mSData.Length);
                            if (mData[i1] != null)
                            {
                                if (buttons[int.Parse(mSData[c])].Text != mData[i1])
                                {
                                    string menkesi = mData[i1];
                                    if (menkesi.IndexOf("0") == 0)
                                    {
                                        menkesi = menkesi.Remove(0, 1);
                                    }
                                    buttons[int.Parse(mSData[c])].Text = menkesi;
                                    Array.Clear(mData, i1, 1);//nullになる
                                    c++;
                                }
                            }
                        }

                        //女子
                        //women配列
                        Array.Sort(wSData);
                        //shuffle
                        wData = wData.OrderBy(i => Guid.NewGuid()).ToArray();

                        for (int f = 0; f < wSData.Length;)
                        {
                            int i2 = cRandom.Next(0, wSData.Length);
                            if (wData[i2] != null)
                            {
                                if (buttons[int.Parse(wSData[f])].Text != wData[i2])
                                {
                                    string womenkesi = wData[i2];
                                    if (womenkesi.IndexOf("0") == 0)
                                    {
                                        womenkesi = womenkesi.Remove(0, 1);
                                    }
                                    buttons[int.Parse(wSData[f])].Text = womenkesi;
                                    Array.Clear(wData, i2, 1);//nullになる
                                    f++;
                                }
                            }
                        }

                    }
                    break;

                case 5://2.0修正済
                    {
                        menSeki = menSeki.Remove(0, 1);
                        womenSeki = womenSeki.Remove(0, 1);
                        men = men.Remove(0, 1);
                        //初期位置
                        string[] mSData = menSeki.Split(',');
                        string[] wSData = womenSeki.Split(',');
                        string[] mData = men.Split(',');
                        string[] wData = women.Split(',');
                        for (int c = 0; c < mSData.Length; c++)
                        {
                            buttons[int.Parse(mSData[c])].Text = mData[c];
                        }

                        for (int c = 0; c < wSData.Length; c++)
                        {
                            buttons[int.Parse(wSData[c])].Text = wData[c];
                        }

                        //全員
                        string[] aSData = allSeki.Split(',');
                        Array.Sort(aSData);

                        string allp = men + women;
                        string[] allD = allp.Split(','); //配列化
                        Array.Sort(allD); //配列を順番に並び替える

                        //デバック
                        if (aSData.Length != allD.Length)
                        {
                            MessageBox.Show("エラーが発生しました。");
                            Application.Exit();
                        }

                        //men & women
                        //shuffle
                        allD = allD.OrderBy(i => Guid.NewGuid()).ToArray();
                        Random mRandom = new System.Random();
                        for (int i = 0; i < allD.Length;)
                        {
                            int m1 = mRandom.Next(0, allD.Length);
                            if (allD[m1] != null)
                            {
                                if (buttons[int.Parse(aSData[i])].Text != allD[m1])
                                {
                                    string t = allD[m1];
                                    if (t.IndexOf("0") == 0)
                                    {
                                        t = t.Remove(0, 1);
                                    }
                                    buttons[int.Parse(aSData[i])].Text = t;
                                    Array.Clear(allD, m1, 1);//nullになる
                                    i++;
                                }
                            }
                        }
                    }
                    break;

                case 6://2.0修正済
                    {
                        menSeki = menSeki.Remove(0, 1);
                        womenSeki = womenSeki.Remove(0, 1);
                        men = men.Remove(0, 1);
                        //初期位置
                        string[] mSData = menSeki.Split(',');
                        string[] wSData = womenSeki.Split(',');
                        string[] mData = men.Split(',');
                        string[] wData = women.Split(',');
                        for (int c = 0; c < mSData.Length; c++)
                        {
                            buttons[int.Parse(mSData[c])].Text = mData[c];
                        }

                        for (int c = 0; c < wSData.Length; c++)
                        {
                            buttons[int.Parse(wSData[c])].Text = wData[c];
                        }

                        //全員
                        string allp = men + women;
                        string[] allD = allp.Split(',');
                        Array.Sort(allD); //配列を順番に並び替える

                        allD = allD.OrderBy(i => Guid.NewGuid()).ToArray();
                        Random pRandom = new System.Random();
                        for (int i = 0; i < allD.Length;)
                        {
                            int k1 = pRandom.Next(1, 42);
                            if (buttonstext[k1] != null)
                            {
                                if (buttons[int.Parse(buttonstext[k1])].Text != allD[i])
                                {
                                    string l = allD[i];
                                    if (l.IndexOf("0") == 0)
                                    {
                                        l = l.Remove(0, 1);
                                    }
                                    buttons[k1].Text = l;
                                    Array.Clear(buttonstext, k1, 1);//nullになる
                                    i++;
                                }
                            }
                        }

                        //消えてないとこを修正
                        for (int m = 1; m < 42; m++)
                        {
                            if (buttonstext[m] != null)
                            {
                                buttons[int.Parse(buttonstext[m])].Text = "";
                            }
                        }
                    }
                    break;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(textBox1.Text);
            f3.Show();
            this.Hide();
        }

        private void button45_Click(object sender, EventArgs e)
        {

        }



        private void button44_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(men.Substring(0,1) == ",")
            {
                men = men.Remove(0, 1);
            }

            if (women.Substring(0, 1) == ",")
            {
                women = women.Remove(0, 1);
            }
            string[] menSet = men.Split(',');
            string[] womenSet = women.Split(',');
            Button[] buttons = new Button[43];
            buttons[0] = button44; buttons[1] = button1; buttons[2] = button2; buttons[3] = button3; buttons[4] = button4; buttons[5] = button5;
            buttons[6] = button6; buttons[7] = button7; buttons[8] = button8; buttons[9] = button9; buttons[10] = button10; buttons[11] = button11; buttons[12] = button12; buttons[13] = button13;
            buttons[14] = button14; buttons[15] = button15; buttons[16] = button16; buttons[17] = button17;
            buttons[18] = button18; buttons[19] = button19; buttons[20] = button20; buttons[21] = button21; buttons[22] = button22; buttons[23] = button23; buttons[24] = button24; buttons[25] = button25; buttons[26] = button26; buttons[27] = button27; buttons[28] = button28; buttons[29] = button29; buttons[30] = button30; buttons[31] = button31; buttons[32] = button32; buttons[33] = button33; buttons[34] = button34; buttons[35] = button35; buttons[36] = button36; buttons[37] = button37; buttons[38] = button38; buttons[39] = button39; buttons[40] = button40; buttons[41] = button41; buttons[42] = button42;

            //0消し
            for(int m1 = 0; m1 < menSet.Length; m1++)
            {
                if(menSet[m1].IndexOf("0") == 0)
                {
                    menSet[m1] = menSet[m1].Remove(0, 1);
                }
            }
            for (int w1 = 0; w1 < womenSet.Length; w1++)
            {
                if (womenSet[w1].IndexOf("0") == 0)
                {
                    womenSet[w1] = womenSet[w1].Remove(0, 1);
                }
            }

            if (checkBox1.Checked == true)
            {
                for(int t = 1; t < 42; t++)
                {
                    if (Array.IndexOf(menSet, buttons[t].Text) != -1)
                    {
                        buttons[t].BackColor = Color.FromArgb(128, 128, 255);
                    }
                    else if (buttons[t].Text != "")
                    {
                            buttons[t].BackColor = Color.FromArgb(255, 128, 128);
                    }
                }
            }
            else
            {
                for (int t = 1; t < 42; t++)
                {
                    buttons[t].BackColor = Color.FromArgb(224, 224, 224);
                }
            }
        }
    }
}