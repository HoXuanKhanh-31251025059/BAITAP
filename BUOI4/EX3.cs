using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.BUOI4
{
    internal class EX3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Chọn 1-5 (0 thoát): ");
            if (!int.TryParse(Console.ReadLine(), out int c)) return;

            switch (c)
            {
                case 0: return;

                case 1:
                    Console.Write("a: "); double.TryParse(Console.ReadLine(), out double a);
                    Console.Write("b: "); double.TryParse(Console.ReadLine(), out double b);
                    Console.Write("op (+ - * x /): "); char op = (Console.ReadLine() ?? "+")[0];
                    double? res = op switch
                    {
                        '+' => a + b,
                        '-' => a - b,
                        '*' => a * b,
                        'x' or 'X' => a * b,
                        '/' => b != 0 ? a / b : double.NaN,
                        _ => null
                    };
                    Console.WriteLine(res == null ? "Phép sai" : $"KQ: {res}");
                    break;

                case 2:
                    for (int y = -5; y <= 5; y++) Console.WriteLine($"{y}\t{y * y + 2 * y + 1}");
                    break;

                case 3:
                    Console.Write("Km: "); double.TryParse(Console.ReadLine(), out double km);
                    Console.Write("Giờ: "); double.TryParse(Console.ReadLine(), out double hh);
                    Console.Write("Phút: "); double.TryParse(Console.ReadLine(), out double mm);
                    Console.Write("Giây: "); double.TryParse(Console.ReadLine(), out double ss);
                    double hrs = hh + mm / 60.0 + ss / 3600.0;
                    if (hrs <= 0) Console.WriteLine("Thời gian sai");
                    else { double kmh = km / hrs; Console.WriteLine($"{kmh:F3} km/h | {kmh * 0.621371:F3} mph"); }
                    break;

                case 4:
                    Console.Write("r: ");
                    if (double.TryParse(Console.ReadLine(), out double r0) && r0 >= 0)
                    {
                        Console.WriteLine($"S: {4 * Math.PI * r0 * r0:F4}");
                        Console.WriteLine($"V: {4.0 / 3.0 * Math.PI * r0 * r0 * r0:F4}");
                    }
                    else Console.WriteLine("Bán kính sai");
                    break;

                case 5:
                    Console.Write("Ký tự: "); string s = Console.ReadLine() ?? "";
                    if (s == "") Console.WriteLine("Không có");
                    else
                    {
                        char ch = s[0];
                        if (char.IsDigit(ch)) Console.WriteLine("Chữ số");
                        else if ("aeiouAEIOU".IndexOf(ch) >= 0) Console.WriteLine("Nguyên âm");
                        else Console.WriteLine("Khác");
                    }
                    break;

                default:
                    Console.WriteLine("Chỉ 1-5");
                    break;

            }
        }
    }
}
