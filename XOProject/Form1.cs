using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOProject
{
    public partial class XO : Form
    {
        enum PlayWhat
        {
            X = 1,
            O = 2
        }
        private PlayWhat playNext = (PlayWhat)1;
        public XO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logic()
        {
            if (btn1.Text.StartsWith('X') && btn2.Text.StartsWith('X') && btn3.Text.StartsWith('X'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn4.Text.StartsWith('X') && btn5.Text.StartsWith('X') && btn6.Text.StartsWith('X'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn7.Text.StartsWith('X') && btn8.Text.StartsWith('X') && btn9.Text.StartsWith('X'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn1.Text.StartsWith('X') && btn4.Text.StartsWith('X') && btn7.Text.StartsWith('X'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn2.Text.StartsWith('X') && btn5.Text.StartsWith('X') && btn8.Text.StartsWith('X'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn3.Text.StartsWith('X') && btn6.Text.StartsWith('X') && btn9.Text.StartsWith('X'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn1.Text.StartsWith('X') && btn5.Text.StartsWith('X') && btn9.Text.StartsWith('X'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn3.Text.StartsWith('X') && btn5.Text.StartsWith('X') && btn7.Text.StartsWith('X'))
            {
                MessageBox.Show("You're Win :)");
            }

            else if (btn1.Text.StartsWith('O') && btn2.Text.StartsWith('O') && btn3.Text.StartsWith('O'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn4.Text.StartsWith('O') && btn5.Text.StartsWith('O') && btn6.Text.StartsWith('O'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn7.Text.StartsWith('O') && btn8.Text.StartsWith('O') && btn9.Text.StartsWith('O'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn1.Text.StartsWith('O') && btn4.Text.StartsWith('O') && btn7.Text.StartsWith('O'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn2.Text.StartsWith('O') && btn5.Text.StartsWith('O') && btn8.Text.StartsWith('O'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn3.Text.StartsWith('O') && btn6.Text.StartsWith('O') && btn9.Text.StartsWith('O'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn1.Text.StartsWith('O') && btn5.Text.StartsWith('O') && btn9.Text.StartsWith('O'))
            {
                MessageBox.Show("You're Win :)");
            }
            else if (btn3.Text.StartsWith('O') && btn5.Text.StartsWith('O') && btn7.Text.StartsWith('O'))
            {
                MessageBox.Show("You're Win :)");
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn1.Text = "X";
                playNext = (PlayWhat)2;
                btn1.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn1.Text = "O";
                playNext = (PlayWhat)1;
                btn1.Enabled = false;
                logic();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn2.Text = "X";
                playNext = (PlayWhat)2;
                btn2.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn2.Text = "O";
                playNext = (PlayWhat)1;
                btn2.Enabled = false;
                logic();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn3.Text = "X";
                playNext = (PlayWhat)2;
                btn3.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn3.Text = "O";
                playNext = (PlayWhat)1;
                btn3.Enabled = false;
                logic();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn4.Text = "X";
                playNext = (PlayWhat)2;
                btn4.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn4.Text = "O";
                playNext = (PlayWhat)1;
                btn4.Enabled = false;
                logic();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn5.Text = "X";
                playNext = (PlayWhat)2;
                btn5.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn5.Text = "O";
                playNext = (PlayWhat)1;
                btn5.Enabled = false;
                logic();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn6.Text = "X";
                playNext = (PlayWhat)2;
                btn6.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn6.Text = "O";
                playNext = (PlayWhat)1;
                btn6.Enabled = false;
                logic();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn7.Text = "X";
                playNext = (PlayWhat)2;
                btn7.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn7.Text = "O";
                playNext = (PlayWhat)1;
                btn7.Enabled = false;
                logic();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn8.Text = "X";
                playNext = (PlayWhat)2;
                btn8.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn8.Text = "O";
                playNext = (PlayWhat)1;
                btn8.Enabled = false;
                logic();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (playNext == (PlayWhat)1)
            {
                btn9.Text = "X";
                playNext = (PlayWhat)2;
                btn9.Enabled = false;
                logic();
            }
            else if (playNext == (PlayWhat)2)
            {
                btn9.Text = "O";
                playNext = (PlayWhat)1;
                btn9.Enabled = false;
                logic();
            }
        }
    }
}
