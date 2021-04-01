using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Laundry
{
    class Validasi
    {
        public Boolean Huruf_Kecil(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-z\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show($"Hanya bisa di isi huruf kecil", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return e.Handled;
        }

        public Boolean Huruf (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\b]");
            if(regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show($"Hanya bisa di isi huruf.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return e.Handled;
        }

        public Boolean Huruf_Spasi (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show($"kata tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return e.Handled;
        }

        public Boolean Huruf_Angka_Spasi (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show($"kata tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return e.Handled;
        }

        public Boolean Huruf_Angka_Simbol_Spasi (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9_.,\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show($"kata/simbol tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return e.Handled;
        }

        public Boolean Angka(Object sender, KeyPressEventArgs e)
        {
            var obj = (sender as TextBox);
            var regex = new Regex(@"[^0-9\b]");
            char c = e.KeyChar;
            if (regex.IsMatch(e.KeyChar.ToString()) && obj.Text.Length <= 0)
            {
                e.Handled = true;
                MessageBox.Show($"Angka tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return e.Handled;
        }

        public Boolean Batas_Persen(TextBox TB, double persen, KeyPressEventArgs e)
        {
            
            char c = e.KeyChar;
            if ((!char.IsDigit(c) || Convert.ToDouble(TB.Text + c) > persen || TB.Text == "0") && c != '\b')
            {
                var regex = new Regex(@"[^0-9\b]");
                if(TB.Text.Length <= 0)
                {
                    MessageBox.Show($"Nilai maksimal hanya sampai {persen} ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB.Text = "0";
                }
            }
            return e.Handled;
       }
    }
}
