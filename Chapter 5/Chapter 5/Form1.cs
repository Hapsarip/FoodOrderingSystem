using FoodOrderingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodOrderDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.foodOrderDataSet.Table);

            DateTime iDate = DateTime.Now;
            tbTanggal.Text = iDate.ToString("dd/MM/yyyy");
            tbWaktu.Text = iDate.ToString("HH:mm:ss");

            tbJumlah1.Text = "0";
            tbJumlah2.Text = "0";
            tbJumlah3.Text = "0";
            tbJumlah4.Text = "0";
            tbJumlah5.Text = "0";
            tbJumlah6.Text = "0";
            tbJumlah7.Text = "0";
            tbJumlah8.Text = "0";
            tbJumlah9.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNama.Text = "";
            tbMeja.Text = "";
            tbRef.Text = "";
            tbJumlah1.Text = "0";
            tbJumlah2.Text = "0";
            tbJumlah3.Text = "0";
            tbJumlah4.Text = "0";
            tbJumlah5.Text = "0";
            tbJumlah6.Text = "0";
            tbJumlah7.Text = "0";
            tbJumlah8.Text = "0";
            tbJumlah9.Text = "0";
            tbNote1.Text = "";
            tbNote2.Text = "";
            tbNote3.Text = "";
            tbNote4.Text = "";
            tbNote5.Text = "";
            tbNote6.Text = "";
            tbNote7.Text = "";
            tbNote8.Text = "";
            tbNote9.Text = "";
        }

        private void btPesan_Click(object sender, EventArgs e)
        {
            Bitmap qr;
            tbQR.Text = ForQRCode.GenerateInfo(tbNama.Text, tbMeja.Text, tbRef.Text, tbTanggal.Text,
                tbWaktu.Text, tbJumlah1.Text, tbJumlah2.Text, tbJumlah3.Text, tbJumlah4.Text, tbJumlah5.Text,
                tbJumlah6.Text, tbJumlah7.Text, tbJumlah8.Text, tbJumlah9.Text, tbNote7.Text,
                tbNote8.Text, out qr);
            pbQR.BackgroundImage = qr;
        }
    }
}
