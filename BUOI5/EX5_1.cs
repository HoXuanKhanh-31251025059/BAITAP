using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.BUOI5
{
    internal class EX5_1
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n===MENU===");
            Console.WriteLine("1. Tìm số lớn nhất trong 3 số");
            Console.WriteLine("2. Tính giai thừa");
            Console.WriteLine("3. Kiểm tra số nguyên tố ");
            Console.WriteLine("4. Tìm số nguyên tố");
            Console.WriteLine("5. Số hoàn hảo");
            Console.WriteLine("6. Chuỗi Pangram");
            Console.WriteLine("0. Thoát");
            Console.Write(" Chọn bài tập: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                        case 1:
                            Console.Write("Nhập 3 số: ");
                            int a = int.Parse(Console.ReadLine());
                            int b = int.Parse(Console.ReadLine());
                            int c = int.Parse(Console.ReadLine());
                            Console.WriteLine("Max = " + MaxOfThree(a, b, c));
                        break;

                case 2:
                    Console.Write("Nhập số n: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{n2}! = " + Factorial(n2));
                        break;

                        case 3:
                            Console.Write("Nhập số n: ");
                            int n3 = int.Parse(Console.ReadLine());
                    bool  kq = IsPrime(n3);
                    if (kq)
                        Console.WriteLine(n3 + " là số nguyên tố");
                    else 
                        Console.WriteLine(n3 + " không phải là số nguyên tố");
                            break;

                        case 4:
                            Console.Write("Nhập giới hạn N: ");
                            int n4 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Các số nguyên tố < N:");
                            PrintPrimesLessThan(n4);

                            Console.Write("Nhập số lượng M: ");
                            int m4 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Đầu tiên {m4} số nguyên tố:");
                            PrintFirstNPrimes(m4);
                            break;

                        case 5:
                            Console.Write("Nhập số n để kiểm tra: ");
                            int n5 = int.Parse(Console.ReadLine());
                            Console.WriteLine(IsPerfect(n5) ? "Hoàn hảo" : "Không hoàn hảo");

                            Console.WriteLine("Các số hoàn hảo < 1000:");
                            PrintPerfectNumbersLessThan1000();
                            break;

                        case 6:
                            Console.Write("Nhập chuỗi: ");
                            string s = Console.ReadLine();
                            Console.WriteLine(IsPangram(s) ? "Là Pangram" : "Không phải Pangram");
                            break;

                        case 0:
                            return;

                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ!");
                            break;
                    }
                }
            // ===== Các hàm =====
            static int MaxOfThree(int a, int b, int c) => Math.Max(a, Math.Max(b, c));

            static int MaxOfNumbers(params int[] numbers)
            {
                if (numbers.Length == 0) throw new ArgumentException("At least one number required");
                int max = numbers[0];
                foreach (int n in numbers)
                    if (n > max) max = n;
                return max;
            }

            static long Factorial(int n2)
            {
                if (n2 < 0) throw new ArgumentException("Number must be non-negative");
                long result = 1;
                for (int i = 2; i <= n2; i++) result *= i;
                return result;
            }

            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(number);i++) 
            {
                if (number % i == 0) return false;

            }
            return true;

        }    
       

            static void PrintPrimesLessThan(int limit)
            {
                for (int i = 2; i < limit; i++)
                    if (IsPrime(i)) Console.Write(i + " ");
                Console.WriteLine();
            }

            static void PrintFirstNPrimes(int N)
            {
                int count = 0, num = 2;
                while (count < N)
                {
                    if (IsPrime(num))
                    {
                        Console.Write(num + " ");
                        count++;
                    }
                    num++;
                }
                Console.WriteLine();
            }

            static bool IsPerfect(int n)
            {
                int sum = 0;
                for (int i = 1; i <= n / 2; i++)
                    if (n % i == 0) sum += i;
                return sum == n;
            }

            static void PrintPerfectNumbersLessThan1000()
            {
                for (int i = 2; i < 1000; i++)
                    if (IsPerfect(i)) Console.WriteLine(i);
            }

            static bool IsPangram(string input)
            {
                input = input.ToLower();
                for (char c = 'a'; c <= 'z'; c++)
                    if (!input.Contains(c)) return false;
                return true;
            }
        }
    }
