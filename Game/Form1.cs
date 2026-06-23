using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            //starting..
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Alishba Starting 

        }
        bool playerturn = true; //true=0, false=x
        int movecount = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.Text == "")
            {
                if (playerturn)
                    button3.Text = "O";

                else
                    button3.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (playerturn)
                    button8.Text = "O";

                else
                    button8.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (playerturn)
                    button2.Text = "O";

                else
                    button2.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (playerturn)
                    button4.Text = "O";

                else
                    button4.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (playerturn)
                    button5.Text = "O";

                else
                    button5.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (playerturn)
                    button6.Text = "O";

                else
                    button6.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (playerturn)
                    button7.Text = "O";

                else
                    button7.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (playerturn)
                    button9.Text = "O";

                else
                    button9.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "")
            {
                if (playerturn)
                    button10.Text = "O";

                else
                    button10.Text = "X";
                playerturn = !playerturn;
                movecount++;
                checkwinner();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            playerturn = true;
            movecount = 0;

        }
        private void checkwinner()
        {
            // Rows
            if (button2.Text != "" && button2.Text == button3.Text && button3.Text == button4.Text)
                Winner(button2.Text);

            else if (button5.Text != "" && button5.Text == button6.Text && button6.Text == button7.Text)
                Winner(button5.Text);

            else if (button8.Text != "" && button8.Text == button9.Text && button9.Text == button10.Text)
                Winner(button8.Text);

            // Columns
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
                Winner(button2.Text);

            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
                Winner(button3.Text);

            else if (button4.Text != "" && button4.Text == button7.Text && button7.Text == button10.Text)
                Winner(button4.Text);
            // Diagonals
            else if (button2.Text != "" && button2.Text == button6.Text && button6.Text == button10.Text)
                Winner(button2.Text);

            else if (button4.Text != "" && button4.Text == button6.Text && button6.Text == button8.Text)
                Winner(button4.Text);

            // Draw
            else if (movecount == 9)
            {
                MessageBox.Show("Match Draw!");
            }
        }
        private void Winner(string player)
        {
            label7.Text = player + " WINS!";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
