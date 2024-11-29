using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TestString();
        }
        
        public void TestString()
        {
            string txt1 = "안녕하세요";
            string txt2 = "반가워요";

            string txt3 = txt1 + " " + txt2;
            string sResult = ("txt3 = ", txt3) + "\n";

            //-----------------------------------------------

            bool isCheck = false;
            sResult += ("isCheck = " + isCheck) + "\n";

            txtResult.Text = sResult;
        }
    }
}
