using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.BUOI5
{
    internal class EX5_2
    {
        // Bài 1
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        // Bài 2:   
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        //Bài 3:
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        //Bài 4:
        static long TinhGiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i < n; i++)
            {
                kq *= i;
            }
            return kq;
        }
        //Bài 5:
        static string DaoNguocChuoi(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        //Bai 6:
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        //Bài 7:
        static string InFibonacci(int n)
        {
            int a = 0, b = 1;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += a + " ";
                int temp = a + b;
                a = b;
                b = temp;
            }
            return result.Trim();
        }
        //Bài 8:
        static int DemNguyenAm(string s)
        {
            int count = 0;
            string na = "aoeuiAOEUI";
            foreach (char c in s)
            {
                if (na.Contains(c)) count++;
            }
            return count;
        }
        //Bài 9
        static double TinhLuyThua(double x, int y)
        {
            double kq = 1;
            for (int i = 0; i < y; i++)
            {
                kq *= x;
            }
            return kq;
        }
        //Bài 10:
        static double TinhTrungBinh(int[] arr)
        {
            double sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            return sum / arr.Length;
        }
        // Bài 11:
        static bool KiemTraDoiXung(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return s == new string(arr);
        }
        //Bài 12:
        static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }
        //Bài 13:
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            foreach (int x in arr)
                if (x < min) min = x;
            return min;
        }
        //Bài 14:
        static int TongCacChuSo(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 5;
                n /= 10;
            }
            return sum;
        }
        //Bài 15:
        static string SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            return string.Join(" ", arr);
        }
        //Bai 16:
        static string XoaTrungLap(string s)
        {
            string resutl = "";
            foreach (char c in s)
            {
                if (!resutl.Contains(c)) resutl += c;
            }
            return resutl;
        }
        //Bài 17:
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        //Bài 18:
        static string DecimalToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
        //Bài 19:
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
        }
        //Bài 20:
        static int DemSoTu(string sentences)
        {
            return sentences.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 1: Tổng " + TinhTong(3, 5));
            Console.WriteLine("Bài 2: Kết quả: " + KiemTraChan(4));
            Console.WriteLine("Bài 3: Kết quả: " + TimMax(3, 7, 5));
            Console.WriteLine("Bài 4: Kết quả: " + TinhGiaiThua(5));
            Console.WriteLine("Bài 5: Kết quả: " + DaoNguocChuoi("Hello"));
            Console.WriteLine("Bài 6: Kết quả: " + KiemTraNguyenTo(7));
            Console.WriteLine("Bài 7: Kết quả: " + InFibonacci(6));
            Console.WriteLine("Bài 8: Kết quả: " + DemNguyenAm("Hello World"));
            Console.WriteLine("Bài 9: Kết quả: " + TinhLuyThua(2, 3));
            Console.WriteLine("Bài 10: Kết quả: " + TinhTrungBinh(new int[] { 4, 5, 6, 7 }));
            Console.WriteLine("Bài 11: Kết quả: " + KiemTraDoiXung("radar"));
            Console.WriteLine("Bài 12: Kết quả: " + CelsiusToFahrenheit(25));
            Console.WriteLine("Bài 13: Kết quả: " + TimMin(new int[] { 10, 5, 8, 2, 9 }));
            Console.WriteLine("Bài 14: Kết quả: " + TongCacChuSo(1234));
            Console.WriteLine("Bài 15: Kết quả: " + SapXepMang(new int[] { 3, 1, 4, 2 }));
            Console.WriteLine("Bài 16: Kết quả: " + XoaTrungLap("programming"));
            Console.WriteLine("Bài 17: Kết quả: " + UCLN(12, 18));
            Console.WriteLine("Bài 18: Kết quả: " + DecimalToBinary(10));
            Console.WriteLine("Bài 19: Kết quả: " + KiemTraNamNhuan(2024));
            Console.WriteLine("Bài 20: Kết quả: " + DemSoTu("Học lập trình C# rất thú vị"));
        }

    }
}



    
