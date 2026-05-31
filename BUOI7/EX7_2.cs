using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BAITAP.BUOI7
{
    internal class EX7_2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n 1. In chuỗi");
            Inchuoi(" Welcome, w3resource ");

            Console.WriteLine("\n 2. Độ dài chuỗi");
            Console.WriteLine(" Độ dài: " + Tinhdodaichuoi("w3resource.com"));

            Console.WriteLine("\n 3. Tách ký tự");
            Tachkytu("w3resource.com");
            Console.WriteLine();

            Console.WriteLine("\n 4. In ngược ký tự");
            Innguockytu("w3resource.com");
            Console.WriteLine();

            Console.WriteLine("\n 5. Đếm số từ trong chuỗi");
            Console.WriteLine(" Số từ: " + Demsotu("This is w3resource.com"));

            Console.WriteLine("\n 6. So sánh 2 chuỗi");
            int result = Sosanh2chuoi("This is first string", "This is first string");
            if (result == 0)
                Console.WriteLine("Độ dài của cả hai chuỗi là bằng nhau và hai chuỗi cũng giống hệt nhau.");
            else if (result == 1)
                Console.WriteLine(" Hai chuỗi có độ dài khác nhau");
            else
                Console.WriteLine(" Hai chuỗi khác nhau");


            Console.WriteLine("\n 7. Đếm số chữ cái, số, ký tự đặc biệt");
            Dem("Welcome to w3resource.com");

            Console.WriteLine("\n 8. Copy chuỗi");
            string copy = Copychuoi("This is a string to be copied.");
            Console.WriteLine(" Copies: " + copy);

            Console.WriteLine("\n 9. Đếm nguyên âm và phụ âm");
            Demnguyenamphuam("Welcome to w3resource.com");

            Console.WriteLine("\n 10. Ký tự xuất hiện nhiều nhất");
            char maxChar;
            int maxCount = Kytuxuathiennhieu("Welcome to w3resource.com", out maxChar);
            Console.WriteLine($" Ký tự xuất hiện nhiều nhất: '{maxChar}' với {maxCount} lần xuất hiện");

            Console.WriteLine("\n 11. Sắp xếp ký tự trong chuỗi");
            string sorted = Sapxepkytu("this is a string");
            Console.WriteLine($" Chuỗi sau khi sắp xếp: {sorted}");

            Console.WriteLine("\n 12. Sắp xếp nổi bọt chuỗi mảng");
            string[] input = { "zxcv", "abcd", "mnop" };
            string[] sb = Sapxepnoibot(input);

            Console.WriteLine($" Chuỗi sau khi sắp xếp nổi bọt: ");
            foreach (string s in sb) Console.WriteLine(s);

            Console.WriteLine("\n 13. Lấy chuỗi con");
            Console.WriteLine($" Chuỗi con: {Laychuoicon("This is a test string", 5, 5)}");

            Console.WriteLine("\n 14. Kiểm tra chuỗi con");
            string str = "This is a test string";
            string sub = "test";
            if (Kiemtrachuoicon(str, sub))
                Console.WriteLine($" Chuỗi '{sub}' là chuỗi con của '{str}'");
            else
                Console.WriteLine($" Chuỗi '{sub}' không phải là chuỗi con của '{str}'");

            Console.WriteLine("\n 15. Đổi chữ hoa thành chữ thường và ngược lại");
            Console.WriteLine($" Chuỗi sau khi đổi: {Doichuhoa_thương("This is a Test String")}");
        }

        //1. In chuỗi
        static void Inchuoi(string s)
        {
            Console.WriteLine(" Chuỗi đã nhập: " + s);
        }
        //2. Tính độ dài chuỗi
        static int Tinhdodaichuoi(string s)
        {
            int count = 0;
            foreach (char c in s) count++;
            return count;
        }
        //3. Tách ký tự
        static void Tachkytu(string s)
        {
            Console.WriteLine(" Các ký tự trong chuỗi: ");
            foreach (char c in s)
            {
                Console.Write(c + " ");
            }
        }
        //4. In ngược ký tự
        static void Innguockytu(string s)
        {
            Console.WriteLine(" Các ký tự của chuỗi theo thứ tự ngược: ");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i] + " ");
            }
        }
        //5. Đếm số từ trong chuỗi
        static int Demsotu(string s)
        {
            string[] words = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        //6. So sánh chuỗi
        static int Sosanh2chuoi(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return 1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    return 2;
            }
            return 0;
        }
        //7. Đếm số chữ cái, số, ký tự đặc biệt
        static void Dem(string s)
        {
            int chu = 0, so = 0, kyTuDacBiet = 0;
            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                    chu++;
                else if (Char.IsDigit(c))
                    so++;
                else
                    kyTuDacBiet++;
            }
            Console.WriteLine(" Số chữ cái: " + chu);
            Console.WriteLine(" Số chữ số: " + so);
            Console.WriteLine(" Số ký tự đặc biệt: " + kyTuDacBiet);

            Console.WriteLine("\n 14. Kiểm tra chuỗi con ");
            string str = " This í a test string";
            string sub = "test";
            if (Kiemtrachuoicon(str, sub))
                Console.WriteLine($" Chuỗi '{sub}' là chuỗi con của '{str}'");
            else
                Console.WriteLine($" Chuỗi '{sub}' không phải là chuỗi con của '{str}'");
        }
        //8. Copy chuỗi
        static string Copychuoi(string s)
        {
            string copy = "";
            foreach (char item in s) copy += item;
            return copy;
        }
        //9. Đếm nguyên âm và phụ âm
        static void Demnguyenamphuam(string s)
        {
            int nguyenAm = 0, phuAm = 0;
            foreach (char c in s.ToLower())
            {
                if ("aeiouAEIOU".Contains(c))
                    nguyenAm++;
                else if (Char.IsLetter(c))
                    phuAm++;
            }
            Console.WriteLine($" Số nguyên âm: {nguyenAm}, Số phụ âm: {phuAm}");
        }
        //10. Ký tự xuất hiện nhiều nhất
        static int Kytuxuathiennhieu(string s, out char maxChar)
        {
            int[] fregn = new int[256];
            foreach (char c in s) fregn[c]++;
            int max = 0;
            maxChar = ' ';
            for (int i = 0; i < 256; i++)
            {
                if (fregn[i] > max)
                {
                    max = fregn[i];
                    maxChar = (char)i;
                }
            }
            return max;
        }
        //11. Sắp xếp ký tự trong chuỗi
        static string Sapxepkytu(string s)
        {
            char[] arr = s.Replace(" ", "").ToCharArray();
            Array.Sort(arr);
            return string.Join("", arr);
        }
        //12. Sắp xếp nổi bọt chuỗi mảng
        static string[] Sapxepnoibot(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        //13. Lấy chuỗi con
        static string Laychuoicon(string s, int pos, int len)
        {
            string sub = "";
            for (int i = pos; i < pos + len && i < s.Length; i++)
            {
                sub += s[i];
            }
            return sub;
        }
        //14. Kiểm tra chuỗi con
        static bool Kiemtrachuoicon (string s, string sub)
        {
            {
               return s.Contains(sub);
            }
        }
        //15. Đôi chữ hoa _ thường
        static string Doichuhoa_thương(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    result += char.ToLower(c);
                else if (char.IsLower(c))
                    result += char.ToUpper(c);
                else
                    result += c;
            }
            return result;
        }
    }
}




