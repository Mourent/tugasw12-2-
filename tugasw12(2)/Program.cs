using System;
using System.Collections.Generic;

namespace Tugasw12
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Urut berdasarkan Nama Belakang (Ascending)");
            Console.WriteLine("2. Urut berdasarkan Nama Depan (Ascending), Kemudian Experience Yearnya(Ascending)");
            Console.WriteLine("3. Munculkan Nama dengan tahun lahir dibawah input");
            Console.Write("Pilih Menu : ");
        }
        static void Main(string[] args)
        {
            string[,] listNama = new string[7, 4];
            listNama[0, 0] = "Yohan";
            listNama[0, 1] = "Anthony";
            listNama[0, 2] = "10-Jun-2001";
            listNama[0, 3] = "2";
            listNama[1, 0] = "Briaan";
            listNama[1, 1] = "Putrantio";
            listNama[1, 2] = "09-Aug-1998";
            listNama[1, 3] = "7";
            listNama[2, 0] = "Billy";
            listNama[2, 1] = "Anthony";
            listNama[2, 2] = "09-Dec-2002";
            listNama[2, 3] = "3";
            listNama[3, 0] = "Billy";
            listNama[3, 1] = "Jefferson";
            listNama[3, 2] = "11-Feb-1997";
            listNama[3, 3] = "6";
            listNama[4, 0] = "Billy";
            listNama[4, 1] = "Agustian";
            listNama[4, 2] = "06-Oct-2003";
            listNama[4, 3] = "5";
            listNama[5, 0] = "Billy";
            listNama[5, 1] = "Panjaitan";
            listNama[5, 2] = "06-Aug-2000";
            listNama[5, 3] = "4";
            listNama[6, 0] = "Cliffton";
            listNama[6, 1] = "Sunarto";
            listNama[6, 2] = "12-Feb-2003";
            listNama[6, 3] = "4";
            int[] tahunLahir = new int[7];
            tahunLahir[0] = 2001;
            tahunLahir[1] = 1998;
            tahunLahir[2] = 2002;
            tahunLahir[3] = 1997;
            tahunLahir[4] = 2003;
            tahunLahir[5] = 2000;
            tahunLahir[6] = 2003;
            string[] formatTulisan = new string[7];
            for (int i = 0; i < 7; i++)
            {
                formatTulisan[i] = $"{listNama[i, 0]} {listNama[i, 1]} ~ {listNama[i, 2].Substring(0, 7) + listNama[i, 2].Substring(9)} ~ Experience : {listNama[i, 3]}";
            }
            Menu();
            int menu = Convert.ToInt32(Console.ReadLine());
            while (menu == 1 || menu == 2 || menu == 3)
            {
                if (menu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1\n\n");
                    var urutanNamaBelakang = new List<string>();
                    for (int i = 0; i < 7; i++)
                    {
                        urutanNamaBelakang.Add(listNama[i, 1]);
                    }
                    urutanNamaBelakang.Sort();
                    for (int i = 0; i < urutanNamaBelakang.Count; i++)
                    {
                        for (int j = 0; j < urutanNamaBelakang.Count; j++)
                        {
                            if (i != j)
                            {
                                if (urutanNamaBelakang[i] == urutanNamaBelakang[j])
                                {
                                    urutanNamaBelakang.Remove(urutanNamaBelakang[j]);
                                }
                            }
                        }
                    } // Menghapus nama yg sama
                    for (int i = 0; i < urutanNamaBelakang.Count; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (urutanNamaBelakang[i] == listNama[j, 1])
                            {
                                Console.WriteLine(formatTulisan[j]);
                            }
                        }
                    }
                }
                else if (menu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("2\n\n");
                    var urutanNamaDepan = new List<string>();
                    for (int i = 0; i < 7; i++)
                    {
                        urutanNamaDepan.Add(listNama[i, 0]);
                    }
                    urutanNamaDepan.Sort();
                    var urutanYear = new List<string>();
                    for (int i = 0; i < 7; i++)
                    {
                        urutanYear.Add(listNama[i, 3]);
                    }
                    urutanYear.Sort();
                    for (int i = 0; i < urutanNamaDepan.Count; i++)
                    {
                        for (int j = 0; j < urutanNamaDepan.Count; j++)
                        {
                            if (i != j)
                            {
                                if (urutanNamaDepan[i] == urutanNamaDepan[j])
                                {
                                    urutanNamaDepan.Remove(urutanNamaDepan[j]);
                                }
                            }
                        }
                    } // Menghapus nama yg sama
                    for (int i = 0; i < urutanNamaDepan.Count; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (urutanNamaDepan[i] == listNama[j, 0])
                            {
                                Console.WriteLine(formatTulisan[j]);
                            }
                        }
                    }
                }
                else if (menu == 3)
                {
                    int Counter = 0;
                    Console.Clear();
                    Console.WriteLine("3\n\n");
                    Console.WriteLine("Tahun Lahir di bawah tahun : ");
                    int maksTahunLahir = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < 7; i++)
                    {
                        if (maksTahunLahir > tahunLahir[i])
                        {
                            Console.WriteLine(formatTulisan[i]);
                            Counter++;
                        }
                    }
                    if (Counter == 0)
                    {
                        Console.WriteLine("\nTidak ada nama dengan tahun lahir dibawah " + maksTahunLahir);
                    }
                }
                Console.WriteLine("\n");
                Menu();
                menu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}