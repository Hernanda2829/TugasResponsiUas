using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasResponsiUas
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Penjualan> dataPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4] : ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;
                    case 2:
                        HapusPenjualan();
                        break;
                    case 3:
                        TampilPenjualan();
                        break;
                    case 4: // keluar dari program
                        return;
                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu

            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan ");
            Console.WriteLine("2. Hapus Penjualan ");
            Console.WriteLine("3. Tampilkan Penjualan ");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Penjualan penjualan = new Penjualan();
            Console.WriteLine("Tambah Data Penjualan \n");
            Console.Write("Nota : ");
            penjualan.Nota = double.Parse(Console.ReadLine());
            Console.Write("Tanggal : ");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("Customer  : ");
            penjualan.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K]  : ");
            penjualan.Jenis = Console.ReadLine();
            Console.Write("total Nota : ");
            penjualan.Total = double.Parse(Console.ReadLine());
            dataPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menghapus data penjualan dari dalam collection

            int nomor = -1, hapus = -1;
            Console.WriteLine();
            Console.WriteLine("Hapus Data Penjualan\n");
            Console.Write("Nota : ");
            int NotaP = Convert.ToInt32(Console.ReadLine());
            foreach (Penjualan penjualan in dataPenjualan)
            {
                nomor++;
                if (penjualan.Nota == NotaP)
                {
                    hapus = nomor;
                }
            }
            if (hapus != -1)
            {
                dataPenjualan.RemoveAt(hapus);
                Console.Write("\nNOta : ");
                Console.Write(NotaP);
                Console.WriteLine(" \n\nData Penjualan Berhasil Dihapus ");
            }
            else
            {
                Console.WriteLine("\n\nNota Tidak Ditemukan ");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan data Penjualan yang ada di dalam collection

            int urutan = 0;
            Console.WriteLine("Data Penjualan\n");
            foreach (Penjualan penjualan in dataPenjualan)
            {
                string Jenis = "0";
                if (penjualan.Jenis == "T" || penjualan.Jenis == "t")
                {
                    Jenis = "Tunai";
                } else if (penjualan.Jenis == "K" || penjualan.Jenis == "k")
                {
                    Jenis = "Kredit";
                }
                urutan++;
                Console.WriteLine("{0}. Nota  : {1},   Tanggal  : {2},   Customer   : {3},   Jenis   : {4},     Total Nota   : Rp. {5:n0}", urutan, penjualan.Nota, penjualan.Tanggal, penjualan.Customer, Jenis, penjualan.Total);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
