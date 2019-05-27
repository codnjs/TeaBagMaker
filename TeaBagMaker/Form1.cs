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
            this.OrgStr = this.

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
