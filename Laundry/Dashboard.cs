using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Luthor.lib;

namespace Laundry
{
    public partial class Dashboard : Form
    {
        string getRole;
        //FIeld
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Dashboard()
        {
            InitializeComponent();
            constumizeDesign();
            //Strukturator
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        //Struktur
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
          // public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(24, 242, 111);
            public static Color color8 = Color.FromArgb(255, 106, 0);
            public static Color color9 = Color.FromArgb(227, 2, 2);
          // public static Color color10 = Color.FromArgb(20, 2, 2);
        }

        //Method
        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DissableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DissableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Panel Setting
        private void constumizeDesign()
        {
            panelData.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelData.Visible == false)
                panelData.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //Pemanggilan user control
        private void openPage(UserControl usercontrol)
        {
            pageWrapper.Controls.Clear();
            usercontrol.Dock = DockStyle.Fill;
            pageWrapper.Controls.Add(usercontrol);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToLongTimeString();
            lblHariTanggal.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;

            if (Session.getUserLogged().Rows[0].Field<string>("nama_role") == "Kasir")
            {
                btnAkun.Visible = false;
                panelData.Visible = false;
                btnPengeluaran.Visible = false;
            }
        }

        //Button Close, Maximiza, Minimize
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Keluar dari aplikasi???", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Button Menu
        private void btnAkun_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelData);
            activateButton(sender, RGBColor.color5);
        }

        private void BtnDataAdmin_Click_1(object sender, EventArgs e)
        {
            openPage(new UserControlDataUser());
            hideSubMenu();
        }

        private void btnKurir_Click(object sender, EventArgs e)
        {
            openPage(new UserControlKurir());
            hideSubMenu();
        }

        private void btnJenis_Click(object sender, EventArgs e)
        {
            openPage(new UserControlJenisPaket());
            hideSubMenu();
        }

        private void btnOutlet_Click(object sender, EventArgs e)
        {
            openPage(new UserControlOutlet());
            hideSubMenu();
        }

        private void btnPelanggan_Click_1(object sender, EventArgs e)
        {
            openPage(new UserControlPelanggan());
            activateButton(sender, RGBColor.color4);
        }

        private void btnPaketCucian_Click(object sender, EventArgs e)
        {
            openPage(new UserControlPaketLaundry());
            activateButton(sender, RGBColor.color3);
        }

        private void btnTransaksi_Click_1(object sender, EventArgs e)
        {
            openPage(new UserControlTransaksi());
            activateButton(sender, RGBColor.color6);
        }

        private void btnPengeluaran_Click_1(object sender, EventArgs e)
        {
            openPage(new UserControlPengeluaran());
            activateButton(sender, RGBColor.color7);
        }

        private void btnLaporan_Click_1(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color8);
        }

        private void btnPengaturan_Click_1(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color1);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color9);
            if (MessageBox.Show("Keluar dari Akun???", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
        }

        //Waktu
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToLongTimeString();
            lblHariTanggal.Text = DateTime.Now.ToLongDateString();
        }

        //Tidak terpakai
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
