using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;

namespace Laundry
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            //Jam & Tanggal
            lblJam.Text = DateTime.Now.ToLongTimeString();
            lblHariTanggal.Text = DateTime.Now.ToLongDateString();
            timer.Enabled = true;

            lblRole.Text = Session.getUserLogged().Rows[0].Field<string>("nama");

            //Laundry
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                lblPelanggan.Text = Db.Read($"SELECT COUNT(*) AS total FROM tb_member").Rows[0].Field<Int64>("total").ToString();
                lblBaru.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'baru'").Rows[0].Field<Int64>("total").ToString();
                lblProses.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'proses'").Rows[0].Field<Int64>("total").ToString();
                lblSelesai.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'selesai'").Rows[0].Field<Int64>("total").ToString();
                lblAmbil.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'diambil'").Rows[0].Field<Int64>("total").ToString();
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                lblPelanggan.Text = Db.Read("SELECT COUNT(*) AS total FROM tb_member").Rows[0].Field<Int64>("total").ToString();
                lblBaru.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'baru' AND tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
                lblProses.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'proses' AND tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
                lblSelesai.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'selesai' AND tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
                lblAmbil.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'diambil' AND tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
            }
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToLongTimeString();
            lblHariTanggal.Text = DateTime.Now.ToLongDateString();
        }
    }
}
