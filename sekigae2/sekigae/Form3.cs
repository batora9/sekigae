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
using System.Threading;

namespace sekigae
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string go)
        {
            InitializeComponent();
            textBox1.Text = go;
        }

       
        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox1.Visible = false;

            label2.Text = "準備しています...";
            label1.Text = "0%";

            //コントロールを初期化する
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;  // 最大値の設定
            label1.Update();
            label2.Update();
            progressBar1.Update();
            //時間のかかる処理を開始する
            for (int N = 0; N <= 1000; N++)
            {
                int a = N / 10;
                label1.Text = a.ToString() + "%";
                if(N > 200　&& N < 550)
                {
                    label2.Text = " パターンを作成しています...";
                    label2.Update();
                }
                if (N > 800)
                {
                    label2.Text = "並び替えています...";
                    label2.Update();
                }
                label1.Update();
                Thread.Sleep(10);
                progressBar1.Value = N;
            }
            Thread.Sleep(500);
            Form4 f4 = new Form4(textBox1.Text);
            f4.Show();
            this.Close();
        }


        protected override CreateParams CreateParams
        {
            [SecurityPermission(SecurityAction.Demand,
                Flags = SecurityPermissionFlag.UnmanagedCode)]
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;

                return cp;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
