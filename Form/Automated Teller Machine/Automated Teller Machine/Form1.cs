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

        bool cardAccept = false;

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

        private void cardInput_Click(object sender, EventArgs e)
        {
            keyboard.Visible = true;
        }
    }
}
