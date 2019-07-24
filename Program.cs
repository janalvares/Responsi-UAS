using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]] : ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        return;
                        break;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampil Produk");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Produk");
            Console.WriteLine();
            Console.Write("Kode Produk : ");
            produk.Kode = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.Nama = Console.ReadLine();
            Console.Write("Harga Beli  : ");
            produk.Beli = Convert.ToInt32(Console.ReadLine());
            Console.Write("Harga Jual  : ");
            produk.Jual = Convert.ToInt32(Console.ReadLine());

            daftarProduk.Add(produk);
        }

        static void HapusProduk()
        {
            Console.Clear();
            Console.WriteLine("Hapus Produk");
            Console.WriteLine();

            Produk produk = new Produk();
            Console.Write("Kode Produk : ");
            string kode = Console.ReadLine();
            Produk hapus = daftarProduk.SingleOrDefault(f => f.Kode == kode);
            if (daftarProduk.Contains(hapus) == true)
            {
                daftarProduk.Remove(hapus);
                Console.WriteLine("Data Produk Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("Data Produk Tidak di temukan");
            }

            Console.Write("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            int nomor = 1;

            Console.WriteLine("Data Produk");
            Console.WriteLine();

            foreach (Produk x in daftarProduk)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", nomor, x.Kode, x.Nama, x.Beli, x.Jual);
                nomor++;
            }

            Console.Write("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
        
   

