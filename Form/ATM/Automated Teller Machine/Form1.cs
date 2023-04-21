using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void header_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void more1_TextChanged(object sender, EventArgs e)
        {

        }

        private void keyboard_Click(object sender, EventArgs e)
        {
            keyboardCtrl.Visible = true;
            closeCtrl.Visible = true;
            cancelCtrl.Visible = true;
            clearCtrl.Visible = true;
            enterCtrl.Visible = true;
            oneCtrl.Visible = true;
            twoCtrl.Visible = true;
            threeCtrl.Visible = true;
            fourCtrl.Visible = true;
            fiveCtrl.Visible = true;
            sixCtrl.Visible = true;
            sevenCtrl.Visible = true;
            eightCtrl.Visible = true;
            nineCtrl.Visible = true;
            zero1Ctrl.Visible = true;
            zero2Ctrl.Visible = true;
            zero3Ctrl.Visible = true;

            ////////////////////////
            ///
            message.Text = "Salam";
        }

        private void closeCtrl_Click(object sender, EventArgs e)
        {
            keyboardCtrl.Visible = false;
            closeCtrl.Visible = false;
            cancelCtrl.Visible = false;
            clearCtrl.Visible = false;
            enterCtrl.Visible = false;
            oneCtrl.Visible = false;
            twoCtrl.Visible = false;
            threeCtrl.Visible = false;
            fourCtrl.Visible = false;
            fiveCtrl.Visible = false;
            sixCtrl.Visible = false;
            sevenCtrl.Visible = false;
            eightCtrl.Visible = false;
            nineCtrl.Visible = false;
            zero1Ctrl.Visible = false;
            zero2Ctrl.Visible = false;
            zero3Ctrl.Visible = false;
        }

        private void cardBank_Click(object sender, EventArgs e)
        {

        }

        private void keyboard_MouseHover(object sender, EventArgs e)
        {
        }

        private void client_MouseEnter(object sender, EventArgs e)
        {
        }

        private void client_MouseMove(object sender, MouseEventArgs e)
        {
            cardBank.Location = e.Location;
        }

        private void cardBank_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void cardInput_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void cardInput_MouseEnter(object sender, EventArgs e)
        {
            cardBank.Visible = false;
            client.Enabled = false;
            keyboard.Visible = true;
            messages.Text = "Enter Your Password:";
            inputCnt.Visible = true;
            inputCnt.Text.ToString();
        }

        private void cardInput_MouseMove(object sender, MouseEventArgs e)
        {
;
        }

        private void cardInput_Click(object sender, EventArgs e)
        {
        }

        private void oneCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "1";
        }

        private void twoCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "2";
        }

        private void threeCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "3";
        }

        private void fourCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "4";
        }

        private void fiveCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "5";
        }

        private void sixCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "6";
        }

        private void sevenCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "7";
        }

        private void eightCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "8";
        }

        private void nineCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "9";
        }

        private void zero1Ctrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "0";
        }

        private void zero2Ctrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "00";
        }

        private void zero3Ctrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text += "000";
        }

        private void cancelCtrl_Click(object sender, EventArgs e)
        {
            cardBank.Visible = true;
            client.Enabled = true;
            keyboard.Visible = false;
            messages.Text = "Enter Your Card";
            inputCnt.Text = "";
            inputCnt.Visible = false;


            keyboardCtrl.Visible = false;
            closeCtrl.Visible = false;
            cancelCtrl.Visible = false;
            clearCtrl.Visible = false;
            enterCtrl.Visible = false;
            oneCtrl.Visible = false;
            twoCtrl.Visible = false;
            threeCtrl.Visible = false;
            fourCtrl.Visible = false;
            fiveCtrl.Visible = false;
            sixCtrl.Visible = false;
            sevenCtrl.Visible = false;
            eightCtrl.Visible = false;
            nineCtrl.Visible = false;
            zero1Ctrl.Visible = false;
            zero2Ctrl.Visible = false;
            zero3Ctrl.Visible = false;
        }

        private void clearCtrl_Click(object sender, EventArgs e)
        {
            inputCnt.Text = "";
        }

        private void enterCtrl_Click(object sender, EventArgs e)
        {
            if (inputCnt.Text == "1399")
            {
                inputCnt.Visible = false;
                inputCnt.Text = "";
                messages.Text = "";

                /////////////////////////////
                keyboardCtrl.Visible = false;
                closeCtrl.Visible = false;
                cancelCtrl.Visible = false;
                clearCtrl.Visible = false;
                enterCtrl.Visible = false;
                oneCtrl.Visible = false;
                twoCtrl.Visible = false;
                threeCtrl.Visible = false;
                fourCtrl.Visible = false;
                fiveCtrl.Visible = false;
                sixCtrl.Visible = false;
                sevenCtrl.Visible = false;
                eightCtrl.Visible = false;
                nineCtrl.Visible = false;
                zero1Ctrl.Visible = false;
                zero2Ctrl.Visible = false;
                zero3Ctrl.Visible = false;
                /////////////////////////////
                more1.Visible = true;
                more1.Text = "Other";

                more2.Visible = true;
                more2.Text = "More...";

                more3.Visible = true;
                more3.Text = "$ 10";

                more4.Visible = true;
                more4.Text = "$ 20";

                more5.Visible = true;
                more5.Text = "$ 50";

                more6.Visible = true;
                more6.Text = "$ 100";

                more7.Visible = true;
                more7.Text = "$ 500";

                more8.Visible = true;
                more8.Text = "$ 1000";
                ////////////////////////////
                moreBtn1.Enabled = true;
                moreBtn2.Enabled = true;
                moreBtn3.Enabled = true;
                moreBtn4.Enabled = true;
                moreBtn5.Enabled = true;
                moreBtn6.Enabled = true;
                moreBtn7.Enabled = true;
                moreBtn8.Enabled = true;
            }
        }
    }
}
