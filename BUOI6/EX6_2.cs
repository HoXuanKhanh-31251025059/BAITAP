using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.BUOI6
{
    internal class EX6_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1. SAP XEP NOI BOT");
            int[] mang = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mang.Length - 1; i++)
            {
                for (int j = 0; j < mang.Length - 1 - i; j++)
                {
                    if (mang[j] > mang[j + 1])
                    {
                        int tam = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = tam;
                    }
                }
            }

            Console.WriteLine("Mang sau khi sap xep: " + string.Join(" ", mang));
            Console.WriteLine();

            Console.WriteLine(" 2. TIM KIEM TUYEN TINH ");

            Console.Write("Nhap mot cau: ");
            string cau = Console.ReadLine();

            Console.Write("Nhap tu can tim: ");
            string tuCanTim = Console.ReadLine();
            string[] cacTu = cau.Split(' ');
            bool timThay = false;
            for (int i = 0; i < cacTu.Length; i++)
            {
                if (cacTu[i].ToLower() == tuCanTim.ToLower())
                {
                    timThay = true;
                    break; 
                }
            }
            if (timThay)
                Console.WriteLine($"Ket qua: Tu '{tuCanTim}' CO xuat hien trong cau.");
            else
                Console.WriteLine($"Ket qua: Tu '{tuCanTim}' KHONG xuat hien trong cau.");

            Console.ReadLine();
        }
    }
}

