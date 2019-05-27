using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{   
    
    public partial class Form1 : Form
    {
        string[] List = new string[]
        {
            "홍차", "녹차", "루이보스차", "국화차"
        };
        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <this.List.Length; i++)
            {
                this.cbList.Items.Add(this.List[i]);
            }
            this.cbList.SelectedIndex = 0;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbList.SelectedIndex == 0) // 홍차
            {
                
            }
            else if(this.cbList.SelectedIndex == 1) // 녹차
            {

            }
            else if (this.cbList.SelectedIndex == 2) // 루이보스차
            {

            }
            else if (this.cbList.SelectedIndex == 3) // 국화차
            {

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.cbList.SelectedIndex == 0) // 홍차 ,, 이미 0이 선택되어있음 ㅠ
            {
                this.Timer.Interval = 2000;
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "티백이 모두 우려졌습니다",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lbresult.Text = this.OrgStr + "2분" ;
            }
            else if (this.cbList.SelectedIndex == 1) // 녹차
            {
                this.Timer.Interval = 3000;
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "티백이 모두 우려졌습니다",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lbresult.Text = this.OrgStr + "3분";
            }
            else if (this.cbList.SelectedIndex == 2) // 루이보스차
            {
                this.Timer.Interval = 5000;
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "티백이 모두 우려졌습니다",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lbresult.Text = this.OrgStr + "5분";
            }
            else if (this.cbList.SelectedIndex == 3) // 국화차
            {
                this.Timer.Interval = 2000;
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "티백이 모두 우려졌습니다",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lbresult.Text = this.OrgStr + "2분";
            }
            else
            {
                MessageBox.Show("어딘가 잘못되었습니다", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            
        }
    }

    // 죄송합니다 선생님... 다 못했지만 제출은 할게욥.. 저 혼자서 더 해보겠습니다ㅠㅠ
}
