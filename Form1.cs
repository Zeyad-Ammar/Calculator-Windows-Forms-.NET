using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    enum enOp
    {
        ADD,SUB,MUL,DIV
    }
    public partial class frmCalculator : Form
    {

        int Num1 = 0;
        int Num2 = 0;
        enOp op;
        public frmCalculator()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            op = enOp.ADD;
            LabCurOperation.Text = "+";
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
          
            op = enOp.SUB;
            LabCurOperation.Text = "-";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
           
            op = enOp.MUL;
            LabCurOperation.Text = "*";

        }

        private void BtnDivison_Click(object sender, EventArgs e)
        {
           
            op = enOp.DIV;
            LabCurOperation.Text = "/";

        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if(!(TxtNum1.Text.Length==0))
               Num1 = Convert.ToInt32(TxtNum1.Text);
            if (!(TxtNum2.Text.Length == 0))
               Num2 = Convert.ToInt32(TxtNum2.Text);

            long Result = 0;

            switch (op)
            {
                case enOp.ADD:
                    Result=Num1 + Num2;
                    break;
                    case enOp.SUB:
                    Result=Num1 - Num2;
                    break;
                    case enOp.MUL:
                    Result=Num1 * Num2;
                    break;
                    case enOp.DIV:
                    Result= (Num2!=0)? Num1 / Num2:Num1;
                    break;
               
            }

            TxtResult.Text=Convert.ToString(Result);
            

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtNum1.Text = "";
            TxtNum2.Text = "";
            TxtResult.Text = "";

        }

    

       
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }

            
        }

        private void TxtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
