using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.BUOI6
{
    internal class EX6_1
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rand = new Random();
            int[] mang = new int[10];
            for (int i = 0; i < mang.Length; i++) 
            {
                mang[i] = rand.Next(1, 21);
            }
            Console.WriteLine("Mảng ngẫu nhiên:" + string.Join(", ", mang));
            Console.WriteLine("-------------------------------");
            //Câu 1;         
            double tb = avg(mang);
            Console.WriteLine($"Trùng bình giá trị trong mãng: {tb}");
            //Câu 2:
            int check2 = 10;
            bool value = ContainsValue(mang, check2);
            Console.WriteLine($"Giá trị {check2} có trong mảng: {value}");
            //Câu 3:
            
            int chiso = FindIndex(mang,10);
            Console.WriteLine($"Chỉ số phần tử {10} là: {chiso}");
            //Câu 4:
            int n = mang.Length;
            Console.Write("Nhập phần tử cần xóa: ");
            int x = int.Parse(Console.ReadLine());
            bool kq = xoa_phantu(mang, ref n, x);
            if (!kq)
            {
                Console.WriteLine("Khong tim thay phan tu can xoa");
            }
            else
            {
                Console.Write("Mảng sau khi xóa: ");
                In_mang(mang, n);
            }
            //Câu 5:
            TimMaxMin(mang, out int max, out int min);
            Console.WriteLine($"Giá trị lớn nhất trong mảng: {max}");
            Console.WriteLine($"Giá trị nhỏ nhất trong mảng: {min}");
            //Câu 6:
            int[] daoNguoc = DaoNguocMang(mang);
            Console.WriteLine("Mảng sau khi đảo ngược: " + string.Join(", ", daoNguoc));
            //Câu 7:
            int[] trungLap = GiaTriTrungLap(mang);
            Console.WriteLine("Các giá trị trùng lặp trong mảng: " + string.Join(", ", trungLap));
            //Câu 8:
            int[] Mangkhongtrunglap = LoaiBoTrungLap(mang);
            Console.WriteLine("Mảng sau khi loại bỏ trùng lặp: " + string.Join(", ", Mangkhongtrunglap));

        }
        static double avg(int[] mang)
        {
            double a = 0, sum = 0;
            foreach (int i in mang)
                sum += i;
            a = sum / mang.Length;
            return a;
        }
        static bool ContainsValue(int[] mang, int n)
        {
            foreach (int i in mang)
            {
                if (i == n) return true;
            }
            return false;
        }
        static int FindIndex(int[] mang, int a)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == a) return i;
            }
            return -1;
        }
        static bool xoa_phantu(int[] mang, ref int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (mang[i] == x)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        mang[j] = mang[j + 1];
                    }
                    n--;
                    return true;
                }
            }
            return false;
        }
        static void In_mang(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }
        static void TimMaxMin(int[] mang, out int max, out int min)
        {
            max = mang[0];
            min = mang[0];
            foreach (int i in mang)
            {
                if (i > max) max = i;
                if (i < min) min = i;
            }
        }
        static int[] DaoNguocMang (int[] mang)
        {
            int[] result = new int[mang.Length];
            int vitri = 0;
            for ( int i = mang.Length - 1; i >= 0; i--)
            {
                result[vitri] = mang[i];
                vitri++;
            }
            return result;
        }
        static int[] GiaTriTrungLap(int[] mang)
        {
            List<int> trunglap = new List<int>();
            List<int> daXet = new List<int>();
            foreach ( int item in mang  )
            {
                if (daXet.Contains(item) && !trunglap.Contains(item))
                {
                    trunglap.Add(item);
                }
                daXet.Add(item);
            }
            return trunglap.ToArray();
        }
        static int[]LoaiBoTrungLap(int[] mang)
        {
            List<int> KetQua = new List<int>();
            foreach (int item in mang)
            {
                if (!KetQua.Contains(item))
                {
                    KetQua.Add(item);
                }
            }
            return KetQua.ToArray();
        }
    } 
}





