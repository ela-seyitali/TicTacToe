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
    public partial class Form4 : Form
    {
        int nr = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b2.Text && b2.Text == b3.Text && b3.Text == b4.Text && b4.Text == b5.Text && b5.Text == b6.Text && b6.Text == b7.Text) ||
                (!string.IsNullOrEmpty(b8.Text) && b8.Text == b9.Text && b9.Text == b10.Text && b10.Text == b11.Text && b11.Text == b12.Text && b12.Text == b13.Text && b13.Text == b14.Text) ||
                (!string.IsNullOrEmpty(b15.Text) && b15.Text == b16.Text && b16.Text == b17.Text && b17.Text == b18.Text && b18.Text == b19.Text && b19.Text == b20.Text && b20.Text == b21.Text) ||
                (!string.IsNullOrEmpty(b22.Text) && b22.Text == b23.Text && b23.Text == b24.Text && b24.Text == b25.Text && b25.Text == b26.Text && b26.Text == b27.Text && b27.Text == b28.Text) ||
                (!string.IsNullOrEmpty(b29.Text) && b29.Text == b30.Text && b30.Text == b31.Text && b31.Text == b32.Text && b32.Text == b33.Text && b33.Text == b34.Text && b34.Text == b35.Text) ||
                (!string.IsNullOrEmpty(b36.Text) && b36.Text == b37.Text && b37.Text == b38.Text && b38.Text == b39.Text && b39.Text == b40.Text && b40.Text == b41.Text && b41.Text == b42.Text) ||
                (!string.IsNullOrEmpty(b43.Text) && b43.Text == b44.Text && b44.Text == b45.Text && b45.Text == b46.Text && b46.Text == b47.Text && b47.Text == b48.Text && b48.Text == b49.Text) ||

                // Dikey doğrular (Sütunlar)
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b8.Text && b8.Text == b15.Text && b15.Text == b22.Text && b22.Text == b29.Text && b29.Text == b36.Text && b36.Text == b43.Text) ||
                (!string.IsNullOrEmpty(b2.Text) && b2.Text == b9.Text && b9.Text == b16.Text && b16.Text == b23.Text && b23.Text == b30.Text && b30.Text == b37.Text && b37.Text == b44.Text) ||
                (!string.IsNullOrEmpty(b3.Text) && b3.Text == b10.Text && b10.Text == b17.Text && b17.Text == b24.Text && b24.Text == b31.Text && b31.Text == b38.Text && b38.Text == b45.Text) ||
                (!string.IsNullOrEmpty(b4.Text) && b4.Text == b11.Text && b11.Text == b18.Text && b18.Text == b25.Text && b25.Text == b32.Text && b32.Text == b39.Text && b39.Text == b46.Text) ||
                (!string.IsNullOrEmpty(b5.Text) && b5.Text == b12.Text && b12.Text == b19.Text && b19.Text == b26.Text && b26.Text == b33.Text && b33.Text == b40.Text && b40.Text == b47.Text) ||
                (!string.IsNullOrEmpty(b6.Text) && b6.Text == b13.Text && b13.Text == b20.Text && b20.Text == b27.Text && b27.Text == b34.Text && b34.Text == b41.Text && b41.Text == b48.Text) ||
                (!string.IsNullOrEmpty(b7.Text) && b7.Text == b14.Text && b14.Text == b21.Text && b21.Text == b28.Text && b28.Text == b35.Text && b35.Text == b42.Text && b42.Text == b49.Text) ||

                // Çapraz doğrular
                (!string.IsNullOrEmpty(b1.Text) && b1.Text == b9.Text && b9.Text == b17.Text && b17.Text == b25.Text && b25.Text == b33.Text && b33.Text == b41.Text && b41.Text == b49.Text) ||
                (!string.IsNullOrEmpty(b7.Text) && b7.Text == b13.Text && b13.Text == b19.Text && b19.Text == b25.Text && b25.Text == b31.Text && b31.Text == b37.Text && b37.Text == b43.Text);

            // Kazanan var mı kontrolü
            if (winnerExists)
            {
                string winner = (nr % 2 != 0) ? "X" : "O";  // Eğer son oynanan hamle X ise kazanan X, O ise kazanan O
                MessageBox.Show($"{winner} Wins");
                this.Close();  // Oyunu kapat
            }
            else if (nr == 49)  // Eğer tüm butonlar tıklanmışsa (yani 49 hamle yapıldıysa) ve kazanan yoksa
            {
                MessageBox.Show("Draw! No one wins.");
                this.Close();  // Oyunu kapat
            }
        }

    }
}
