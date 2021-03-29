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
            }
            return e.Handled;
        }

        public Boolean Huruf (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\b]");
            if(regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean Huruf_Spasi (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean Huruf_Angka_Spasi (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean Huruf_Angka_Simbol_Spasi (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9_.,\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean Angka (KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean Batas_Persen (TextBox TB, double persen, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if((!char.IsDigit(c)||Convert.ToDouble(TB.Text+c) > persen || TB.Text == "0") && c!= '\b')
            {
                e.Handled = true;
            }
            return e.Handled;
        }
    }
}
