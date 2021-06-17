using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using QRCoder;

namespace FoodOrderingSystem
{
    class ForQRCode
    {
        public static string GenerateInfo(string nama, string meja, string noRef, string tanggal,
            string waktu, string jumlah1, string jumlah2, string jumlah3, string jumlah4,
            string jumlah5, string jumlah6, string jumlah7, string jumlah8, string jumlah9, string note1,
            string note2)
        {
            int total1 = 8000 * Convert.ToInt32(jumlah1);
            int total2 = 10000 * Convert.ToInt32(jumlah2);
            int total3 = 10000 * Convert.ToInt32(jumlah3);
            int total4 = 12000 * Convert.ToInt32(jumlah4);
            int total5 = 12000 * Convert.ToInt32(jumlah5);
            int total6 = 14000 * Convert.ToInt32(jumlah6);
            int total7 = 3000 * Convert.ToInt32(jumlah7);
            int total8 = 3000 * Convert.ToInt32(jumlah8);
            int total9 = 3000 * Convert.ToInt32(jumlah9);
            int totalsemua = total1+total2+total3+total4+total5+total6+total7+total8+total9;

            string result = "=====================================================================" +
                Environment.NewLine +"\t\t\t NOTA PESANAN" +
                Environment.NewLine + "=====================================================================" +
                Environment.NewLine + "Pesanan Atas Nama : " + nama +
                Environment.NewLine + "Nomor Meja   \t : " + meja +
                Environment.NewLine + "Nomor Referensi   \t : " + noRef +
                Environment.NewLine + "Tanggal  \t\t : " + tanggal +
                Environment.NewLine + "Waktu  \t\t : " + waktu +
                Environment.NewLine +
                Environment.NewLine + "Menu \t\t\t\t Jumlah Porsi \t Total Harga" +
                Environment.NewLine + "Nasi Gudeg \t\t\t " + jumlah1 + "\t\t Rp " + Convert.ToString(total1) +
                Environment.NewLine + "Nasi Gudeg Sambal Goreng \t\t " + jumlah2 + "\t\t Rp " + Convert.ToString(total2) +
                Environment.NewLine + "Nasi Gudeg Telur \t\t\t " + jumlah3 + "\t\t Rp " + Convert.ToString(total3) + "\n" +
                Environment.NewLine + "Nasi Gudeg Telur Sambal Goreng \t " + jumlah4 + "\t\t Rp " + Convert.ToString(total4) +
                Environment.NewLine + "Nasi Gudeg Ayam \t\t\t " + jumlah5 + "\t\t Rp " + Convert.ToString(total5) +
                Environment.NewLine + "Nasi Gudeg Ayam Sambal Goreng \t " + jumlah6 + "\t\t Rp " + Convert.ToString(total6) +
                Environment.NewLine + note1 + "Teh \t\t\t\t " + jumlah7 + "\t\t Rp " + Convert.ToString(total7) +
                Environment.NewLine + note2 + "Jeruk \t\t\t\t " + jumlah8 + "\t\t Rp " + Convert.ToString(total8) +
                Environment.NewLine + "Air Mineral \t\t\t " + jumlah9 + "\t\t Rp " + Convert.ToString(total9) +
                Environment.NewLine + "\t\t\t\t Total Harga : \t Rp " + Convert.ToString(totalsemua);
            return result;
        }
        public static string GenerateInfo(string nama, string meja, string noRef, string tanggal,
            string waktu, string jumlah1, string jumlah2, string jumlah3, string jumlah4,
            string jumlah5, string jumlah6, string jumlah7, string jumlah8, string jumlah9, string note1,
            string note2, out Bitmap QrBitmap)
        {
            string text = GenerateInfo(nama, meja, noRef, tanggal, waktu, jumlah1, jumlah2, jumlah3,
                jumlah4, jumlah5, jumlah6, jumlah7, jumlah8, jumlah9, note1, note2);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            QrBitmap = qrCode.GetGraphic(20);
            return text;
        }
    }
}
