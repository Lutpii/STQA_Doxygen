using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STQA_Doxygen
{
    /// <summary>
    /// Main class
    /// </summary>
    /// <remarks>Class kasir dapat membuat operasi input, display, create teks </remarks>
    public class Kasir
    {
        public void KasirCafe()
        {
            {
                Console.WriteLine("+=============================================+");
                Console.WriteLine("         Program Kasir Cafe Simple             ");
                Console.WriteLine("                  Cafe Pudidi                  ");
                Console.WriteLine("+=============================================+");
                Console.Write("\n");
                Console.WriteLine("   Silahkan Memilih Item Dari Menu   ");
                Console.Write("\n");
                //menampilkan menu makanan
                Console.WriteLine("===============Makanan===============");
                Console.Write("\n");
                Console.WriteLine(" 1. Mie Dokdok       : Rp 10000");
                Console.WriteLine(" 2. Nasi Ayam Bali   : Rp 11000");
                Console.WriteLine(" 3. Intel Kornet     : Rp 12000");
                Console.WriteLine(" 4. Intel Sosis      : Rp 11000");
                //menampilkan menu minuman 
                Console.WriteLine("===============Minuman===============");
                Console.Write("\n");
                Console.WriteLine(" 1. Eskopsu          : Rp 8000");
                Console.WriteLine(" 2. Teh Manis        : Rp 5000");
                Console.WriteLine(" 3. STMJ             : Rp 6000");
                Console.WriteLine(" 4. Jahe             : Rp 7000");

                int jumlah;
                //looping dengan menginput jumlah barang menggunakan kondisi do while
                do
                {
                    Console.Write("\nMasukkan Jumlah Barang : ");
                    jumlah = int.Parse(Console.ReadLine());
                } while (jumlah <= 0 || jumlah > 100);

                //mendeklarasikan atau mendefinisikan variabel data
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;


                //menampilkan masukan nama pelanggan
                Console.WriteLine("===========================");
                Console.Write("Masukkan Nama Pelanggan : ");

                //deklarasi variabel data string
                string namap1 = Console.ReadLine();

                //looping menggunakan kombinasi array
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //menampilkan input harga
                        Console.WriteLine("==============================");
                        Console.Write("Masukkan Nama Barang Ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                        //user harus menginput nama barang diatas 0 karakter sampai 20 karakter
                    }
                    while (nama[i].Length <= 0 || nama[i].Length >= 20);

                    do
                    {
                        //menampilkan input harga
                        Console.Write("Masukkan Harga Barang Ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());
                        //user harus menginput harga barang min 4000 sampai 1000000
                    }
                    while (harga[i] <= 4000 || harga[i] >= 1000000);
                }
                //menampilkan barang dan harga yang sudah dipilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==============================");
                Console.WriteLine("Daftar Barang Yang Dipilih");
                Console.WriteLine("==============================");
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                }
                foreach (int i in harga)
                {
                    total += i;
                }

                //menampilkan total harga 
                Console.WriteLine("==============================");
                Console.WriteLine("Total Harga : Rp" + total);

                do
                {
                    Console.Write("Masukkan Tunai: Rp");
                    bayar = int.Parse(Console.ReadLine());

                    //menampilkan kembalian uang dari uang yang dibayarkan dikurangi uang total
                    kembalian = bayar - total;

                    //konsidi jika input uang yang dibayarkan kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("Maaf Uangmu Tidak Cukup!");
                    }
                    //kondisi dimana input uang yang dibayarkan lebih
                    else //menampilkan uang kembalian
                    {
                        Console.WriteLine("Uang Kembalian Anda : Rp" + kembalian);
                    }

                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan: {0}", namap1.ToString());
                Console.Write("\n");
                //menampilkan tanggal dan waktu transaksi
                Console.WriteLine("Tanggal Transaksi :" + DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Jam Transaksi :" + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("==============================");
                Console.WriteLine("Nama Kasir : Adi Luthfi ");
                Console.WriteLine("Terima Kasih");
                Console.WriteLine("==============================");

                //mencetak nota dengan menggunakan streamwriter
                using (StreamWriter sw = new StreamWriter(@"D:\Visual studio\VSCODE COM 22\STQA_Doxygen\STQA_Doxygen.txt"))//lokasi tempat file nota dicetak
                {
                    sw.WriteLine("========================================");
                    sw.WriteLine("=========== NOTA PEMBAYARAN ============");
                    sw.WriteLine("========================================");
                    sw.WriteLine("        Nama Barang Yang Dibeli         ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                    }
                    sw.WriteLine("+======================================+");
                    sw.WriteLine("Total Harga     : Rp" + total);
                    sw.WriteLine("Tunai           : Rp" + bayar);
                    sw.WriteLine("Kembalian       : Rp" + kembalian);
                    sw.WriteLine("\n");
                    //menampilkan nama pelanggan 
                    sw.WriteLine("Nama Pelanggan : {0}", namap1.ToString());
                    //menampilkan tanggal dan waktu transaksi
                    sw.WriteLine("Tanggal Transaksi :" + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam Transaksi :" + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("+======================================+");
                    sw.WriteLine("         Nama Kasir : Adi Luthfi        ");
                    sw.WriteLine("             Terima Kasih               ");
                    sw.WriteLine("+======================================+");
                    Console.Write("\n");
                    Console.WriteLine("Nota Telah di Print");

                }
                Console.WriteLine();
                Console.Write("Tekan 'ENTER' Untuk Keluar.....");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            //memanggil kelas kasircafe
            Kasir KasirC = new Kasir();
            KasirC.KasirCafe();
        }
    }
}