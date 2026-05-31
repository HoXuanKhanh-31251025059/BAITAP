using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.BUOI7
{
    internal class EX7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //1. In chuỗi
            Console.WriteLine("\n Câu 1: In chuỗi ");
            string str1 = "Cơ sở lập trình";
            Console.WriteLine("Chuỗi đã nhập: " + str1);

            //2. Tính độ dài
            Console.WriteLine("\n Câu 2: Tính độ dài ");
            string str2 = "Xin chào";
            Console.WriteLine("Độ dài: " + Đodaichuoi(str2));

            //3. Tách ký tự
            Console.WriteLine("\n Câu 3: In ký tự ");
            string str3 = "Lập trình";
            Inkytu(str3);

            //4. In chuỗi ngược
            Console.WriteLine("\n Câu 4: In chuỗi ngược ");
            string str4 = "Hello World";
            Chuoinguoc(str4);

            //5.Đếm tổng số từ trong chuỗi
            Console.WriteLine("\n Câu 5: Đếm tổng số từ trong chuỗi ");
            string str5 = "Xin chào";
            Console.WriteLine(" Số từ trong chuỗi: " + Sotu(str5));

            //6. So sánh 2 chuỗi
            Console.WriteLine("\n Câu 6: So sánh 2 chuỗi ");           
            string str6_1 = "Xin chào";
            string str6_2 = "Xin chao";
            Console.WriteLine(" Kết quả so sánh: " + Sosanh(str6_1, str6_2));

            //7. Đếm chữ cái, số, ký tự đặc biệt
            Console.WriteLine("\n Câu 7: Đếm chữ cái, số, ký tự đặc biệt ");
            string str7 = "Hello123!";
            Dem(str7);

            //8. Đếm nguyên âm và phụ âm
            Console.WriteLine("\n Câu 8: Đếm nguyên âm và phụ âm ");
            string str8 ="Hello";
            Demnguyenamphuam(str8);

            //9. Kiểm tra chuỗi con
            Console.WriteLine("\n Câu 9: Kiểm tra chuỗi con "); 
            string str9 = "Cơ sở lập trình";
            string sub9 = "lập trình";
            Console.WriteLine(" Kết quả kiểm tra chuỗi con: " + Kiemtrachuoicon(str9, sub9));

            //10. Vị trí chuỗi con
            Console.WriteLine("\n Câu 10: Vị trí chuỗi con ");
            string str10 = "Xin chào mọi người";
            string sub10 = "mọi";
            Console.WriteLine(" Vị trí đầu tiên: " + Vitri(str10, sub10));

            //11. Kiểm tra ký tự
            Console.WriteLine("\n Câu 11: Kiểm tra ký tự");
            char ch = 'A';
            Kiemtrakytu(ch);

            //12. Đếm số lần xuất hiện của chuỗi con
            Console.WriteLine("\n Câu 12:  Đếm số lần xuất hiện chuỗi con");
            string str12 = "abc abc abc";
            string sub12 = "abc";
            Console.WriteLine(" Số lần xuất hiện của chuỗi con: " + Demsolanxuathien(str12, sub12));

            //13. Chèn chuỗi trước lần xuất hiện đầu tiên
            Console.WriteLine("\n Câu 13: Chèn chuỗi trước lần xuất hiện đầu tiên");
            string str13 = "Lập trình khó";
            string sub13 = "khó"; 
            string insert = "rất ";
            Console.WriteLine(" Sau khi chèn: " + Chenchuoi(str13, sub13, insert));
        }
        
        //2. Tính độ dài
        static int Đodaichuoi(string str)
        {
            int len = 0;
            foreach (char c in str)
            {
                len++;
            }
            return len;
        }
        //3. In ký tự
        static void Inkytu(string str)
        {
            Console.WriteLine(" Các ký tự trong chuỗi: ");
            foreach (char c in str)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        //4. In chuỗi ngược
        static void Chuoinguoc(string str)
        {
            Console.WriteLine("Chuỗi ngược: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }
        //5. Đếm tổng số từ trong chuỗi
        static int Sotu(string str)
        {
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        //6. So sánh 2 chuỗi
        static bool Sosanh(string str1, string str2)
        {
            if (str1 != str2)
                return false;
            for (int i = 0; i < str1.Length; i++)
                if (str1[i] != str2[i])
                    return false;
            return true;
        }
        // 7. Đếm chữ cái, số, ký tự đặc biệt
        static void Dem(string str)
        {
            int Letter = 0;
            int Digit = 0;
            int Special = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                    Letter++;
                else if (char.IsDigit(c))
                    Digit++;
                else
                    Special++;
            }
            Console.WriteLine(" Số chữ cái: " + Letter);
            Console.WriteLine(" Số chữ số: " + Digit);
            Console.WriteLine(" Số ký tự đặc biệt: " + Special);
        }
        //8. Đếm nguyên âm và phụ âm
        static void Demnguyenamphuam(string str)
        {
            int nguyenan = 0, phuam = 0;
            foreach (char c in str)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                    nguyenan++;
                else if (char.IsLetter(c))
                    phuam++;
            }
            Console.WriteLine($" Số nguyên âm: {nguyenan}  Số phụ âm: {phuam}");
        }
        //9. Kiểm tra chuỗi con
        static bool Kiemtrachuoicon(string str, string sub)
        {
            return str.Contains(sub);
        }
        //10. Vị trí chuỗi con
        static int Vitri(string str, string sub)
        {
            int pos = str.IndexOf(sub);
            return pos == -1 ? -1 : pos + 1;
        }
        //11. Kiểm tra ký tự
        static void Kiemtrakytu(char ch)
        {
            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                    Console.WriteLine("Ký tự là chữ hoa");
                else Console.WriteLine("Ký tự là chữ thường");
            }
            else Console.WriteLine("Không phải chữ cái");    
        }
        //12. Đếm số lần xuất hiện của chuỗi con
        static int Demsolanxuathien(string s, string sub)
        {
            int count = 0, pos = 0;
            while ((pos = s.IndexOf(sub, pos)) != -1)
            {
                count++;
                pos += sub.Length;
            }
            return count;
        }
        //13. Chèn chuỗi trước lần xuất hiện đầu tiên
        static string Chenchuoi(string str, string sub, string insert)
        {
            int pos = str.IndexOf(sub);
            if (pos == -1) return str;
            return str.Substring(0, pos) + insert + str.Substring(pos);
        }
    }
}


