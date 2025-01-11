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
    public partial class Form3 : Form
    {
        int nr = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            nr++;  // Hamle sayısını artır

            Button b = (Button)sender;  // Tıklanan buton

            // X ve O'nun dönüşümlü olarak yerleştirilmesi
            if (nr % 2 != 0)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            b.Enabled = false;  // Buton bir kere tıklanıp "X" veya "O" yazıldığında devre dışı bırakılır

            // Kazananı kontrol et
            bool winnerExists =
                // Yatay doğrular (Satırlar)
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b2.Text && b2.Text == b3.Text && b3.Text == b4.Text && b4.Text == b5.Text) ||
                (!string.IsNullOrEmpty(b6.Text) && b6.Text == b7.Text && b7.Text == b8.Text && b8.Text == b9.Text && b9.Text == b10.Text) ||
                (!string.IsNullOrEmpty(b11.Text) && b11.Text == b12.Text && b12.Text == b13.Text && b13.Text == b14.Text) ||
                (!string.IsNullOrEmpty(b16.Text) && b16.Text == b17.Text && b17.Text == b18.Text && b18.Text == b19.Text) ||
                (!string.IsNullOrEmpty(b21.Text) && b21.Text == b22.Text && b22.Text == b23.Text && b23.Text == b24.Text) ||

                // Dikey doğrular (Sütunlar)
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b6.Text && b6.Text == b11.Text && b11.Text == b16.Text && b16.Text == b21.Text) ||
                (!string.IsNullOrEmpty(b2.Text) && b2.Text == b7.Text && b7.Text == b12.Text && b12.Text == b17.Text && b17.Text == b22.Text) ||
                (!string.IsNullOrEmpty(b3.Text) && b3.Text == b8.Text && b8.Text == b13.Text && b13.Text == b18.Text && b18.Text == b23.Text) ||
                (!string.IsNullOrEmpty(b4.Text) && b4.Text == b9.Text && b9.Text == b14.Text && b14.Text == b19.Text && b19.Text == b24.Text) ||
                (!string.IsNullOrEmpty(b5.Text) && b5.Text == b10.Text && b10.Text == b15.Text && b15.Text == b20.Text && b20.Text == b25.Text) ||

                // Çapraz doğrular
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b7.Text && b7.Text == b13.Text && b13.Text == b19.Text && b19.Text == b25.Text) ||
                (!string.IsNullOrEmpty(b5.Text) && b5.Text == b9.Text && b9.Text == b13.Text && b13.Text == b17.Text && b17.Text == b21.Text);

            // Kazanan var mı kontrolü
            if (winnerExists)
            {
                string winner = (nr % 2 != 0) ? "X" : "O";  // Eğer son oynanan hamle X ise kazanan X, O ise kazanan O
                MessageBox.Show($"{winner} Wins");
                this.Close();  // Oyunu kapat
            }
            else if (nr == 25)  // Eğer tüm butonlar tıklanmışsa (yani 25 hamle yapıldıysa) ve kazanan yoksa
            {
                MessageBox.Show("Draw! No one wins.");
                this.Close();  // Oyunu kapat
            }
        }

    }
}
