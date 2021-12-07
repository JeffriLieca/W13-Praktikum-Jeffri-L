using System;
using System.Collections.Generic;
namespace W13_Praktikum_Jeffri_Lieca_H_0706022110016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Berapa Data = ");
            int data = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            var listNim = new List<string>() { " " };
            var listGuild = new List<string>();
            string pertanyaan = "o";
            while (true)
            {
                int data2;
                Console.WriteLine();
                while (counter < data)
                {
                    Console.WriteLine($"data ke-{counter + 1}");
                    Console.Write("NIM : ");
                    string nim = Console.ReadLine();
                    int tes = 2;
                    for (int i = 0; i <= counter; i++)
                    {
                        while (nim.CompareTo(listNim[i]) == 0)
                        {
                            Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                            Console.Write("NIM : ");
                            nim = Console.ReadLine();
                        }
                    }
                    listNim.Add(nim);
                    Console.Write("NAMA : ");
                    string nama = Console.ReadLine();
                    Console.Write("JENIS KELAMIN : ");
                    string jenisKelamin = Console.ReadLine();
                    Console.Write("TAHUN MASUK : ");
                    int tahunMasuk = Convert.ToInt32(Console.ReadLine());
                    Console.Write("PROGRAM STUDI : ");
                    string programStudi = Console.ReadLine();
                    Console.Write("KELAS : ");
                    string kelas = Console.ReadLine();
                    listGuild.Add(String.Format(" {0,-3} {1,-6} {2,-25} {3,-18} {4,-14} {5,-19} {6,-6} ", counter + 1,
                   nim, nama, jenisKelamin, tahunMasuk, programStudi, kelas));
                    counter++;
                    Console.WriteLine();
                }
                Console.WriteLine();
                while (pertanyaan != "y" && pertanyaan != "n")
                {
                    Console.Write("PRINT HASIL ? (y/n) ...");
                    pertanyaan = Console.ReadLine();
                }
                if (pertanyaan == "y")
                {
                    Console.Clear();
                }
                else if (pertanyaan == "n")
                {
                    System.Environment.Exit(1);
                }
                Console.WriteLine(String.Format(" {0,-3} {1,-6} {2,-25} {3,-18} {4,-14} {5,-19} {6,-6} ", "NO",
               "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS"));
                Console.WriteLine();
                for (int i = 0; i < listGuild.Count; i++)
                {
                    Console.WriteLine(listGuild[i].ToUpper());
                }
                Console.WriteLine();
                Console.Write("Tambah Data? (y/n) ... ");
                string tambahData = Console.ReadLine();
                while (tambahData != "y" && tambahData != "n")
                {
                    Console.Write("Tambah Data? (y/n) ... ");
                    tambahData = Console.ReadLine();
                }
                Console.WriteLine();
                if (tambahData == "y")
                {
                    Console.Write("Berapa Data = ");
                    data2 = Convert.ToInt32(Console.ReadLine());
                    data += data2;
                }
                else if (tambahData == "n")
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}