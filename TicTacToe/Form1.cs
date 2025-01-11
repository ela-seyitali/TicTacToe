using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int nr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            nr++;

            Button b = (Button)sender;
            if (nr % 2 != 0)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            b.Enabled = false;

            // Kazananı kontrol et
            bool winnerExists =
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b2.Text && b2.Text == b3.Text) ||
                (!string.IsNullOrEmpty(b4.Text) && b4.Text == b5.Text && b5.Text == b6.Text) ||
                (!string.IsNullOrEmpty(b7.Text) && b7.Text == b8.Text && b8.Text == b9.Text) ||
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b4.Text && b4.Text == b7.Text) ||
                (!string.IsNullOrEmpty(b2.Text) && b2.Text == b5.Text && b5.Text == b8.Text) ||
                (!string.IsNullOrEmpty(b3.Text) && b3.Text == b6.Text && b6.Text == b9.Text) ||
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b5.Text && b5.Text == b9.Text) ||
                (!string.IsNullOrEmpty(b3.Text) && b3.Text == b5.Text && b5.Text == b7.Text);

            if (winnerExists)
            {
                string winner = (nr % 2 != 0) ? "X" : "O";
                MessageBox.Show($"{winner} Wins");
                this.Close();
            }
            else if (nr == 9) // Eğer tüm butonlar tıklanmışsa ve kazanan yoksa
            {
                MessageBox.Show("Draw! No one wins.");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
