using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.BUOI3
{
    class EX2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Chọn bài tập từ 1 đến 50: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello: Ho Xuan Khanh" );
                    break;
                case 2:
                    int a2 = 5, b2 = 6;
                    Console.WriteLine(a2 + b2);
                    break;
                case 3:
                    int a3 = 5, b3 = 6;
                    Console.WriteLine(a3 / b3);
                    break;
                case 4:
                    Console.WriteLine(-1 + 4 * 6);
                    Console.WriteLine((35 + 5) % 7);
                    Console.WriteLine(14 + -4 * 6 / 11);
                    Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
                    break;
                case 5:
                    int n1 = 5, n2 = 6; int temp;
                    temp = n1;
                    n1 = n2;
                    n2 = temp;
                    Console.WriteLine($"After Swapping: n1={n1}, n2={n2}");
                    break;
                case 6:
                    int a = 2, b = 3; int c = 4;
                    Console.WriteLine($"{a}x{b}x{c} = {a * b * c}");
                    break;
                case 7:
                    int a7 = 5, b7 = 6;
                    Console.WriteLine($"{a7} + {b7} = {a7 + b7}");
                    Console.WriteLine($"{a7} - {b7} = {a7 - b7}");
                    Console.WriteLine($"{a7} x {b7} = {a7 * b7}");
                    Console.WriteLine($"{a7} / {b7} = {a7 / b7}");

                    Console.WriteLine($"{a7} mod {b7} = {a7 % b7}");
                    break;
                case 8:
                    int a8 = 3;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($" {a8}*{i} = {a8 * i}");
                    }
                    break;
                case 9:
                    int a9 = 1, b9 = 3, c9 = 5, d9 = 10;
                    double avg = (a9 + b9 + c9 + d9) / 4.0;
                    Console.WriteLine($"The average of {a9},{b9},{c9},{d9  } is: {avg}");
                    break;
                case 10:
                    int a10 = 4, b10 = 5, c10  = 6;
                    Console.WriteLine($"( x + y).z = {(a10 + b10) * c10}");
                    Console.WriteLine ($"x.y + y.z = {a10 * b10 + b10 * c10}");
                    break;
                case 11:
                    Console.Write("Enter your age: ");
                    int Age = int.Parse(Console.ReadLine());
                    Console.WriteLine($"You look older than {Age}");
                    break;
                case 12:
                    Console.Write(" Enter a digit: ");
                    int a12 = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} {0} {0} {0}", a12);
                    Console.WriteLine("{0}{0}{0}{0}", a12);
                    Console.WriteLine("{0} {0} {0} {0}", a12);
                    Console.WriteLine("{0}{0}{0}{0}", a12);
                    break;
                case 13:
                    Console.Write("Enter a number: ");
                    string a13 = Console.ReadLine();
                    Console.WriteLine(a13 + a13 + a13);
                    Console.WriteLine(a13 + " " + a13);
                    Console.WriteLine(a13 + " " + a13);
                    Console.WriteLine(a13 + " " + a13);
                    Console.WriteLine(a13 + a13 + a13);
                    break;
                case 14:
                    Console.Write("Enter Celsius: ");
                    double c14 = double.Parse(Console.ReadLine());
                    double k = c14 + 273;
                    double f = c14 * 9 / 5 + 32;
                    Console.WriteLine($" Kelvin = {k}");
                    Console.WriteLine($" Fahteheit = {f}");
                    break;
                case 15:
                    string s = "w3resource";
                    Console.WriteLine(s.Remove(1, 1)); 
                    Console.WriteLine(s.Remove(s.Length - 1, 1)); 
                    Console.WriteLine(s.Remove(0, 1)); 
                    break;
                case 16:
                    string a16 = " w3resource";
                    string b16 = "Python";
                    Console.WriteLine(a16[a16.Length - 1] + a16.Substring(1, a16.Length - 2) + a16[0]);
                    Console.WriteLine(b16[b16.Length - 1] + b16.Substring(1, b16.Length - 2) + b16[0]);
                    break;
                case 17:
                    Console.Write(" Input a string: ");
                    string input = Console.ReadLine();
                    char first = input[0];
                    Console.WriteLine($"{first}{input}{first}");
                    break;
                case 18:
                    Console.Write(" Input first integer: ");
                    int a18 = int.Parse(Console.ReadLine());
                    Console.Write(" Input second integer: ");
                    int b18 = int.Parse(Console.ReadLine());
                    bool result = (a18 < 0 && b18 > 0) || (b18 < 0 && a18 > 0);
                    Console.WriteLine($"Check: {result}");
                    break;
                case 19:
                    Console.Write("Enter first integer: ");
                    int a19 = int.Parse(Console.ReadLine());
                    Console.Write("Enter second integer: ");
                    int b19 = int.Parse(Console.ReadLine());
                    int sum = a19 + b19;
                    if (a19 == b19) Console.WriteLine(sum * 3);
                    else Console.WriteLine(sum);
                    break;
                case 20:
                    Console.Write("Enter first number: ");
                    int a20 = int.Parse(Console.ReadLine());
                    Console.Write("Enter second integer: ");
                    int b20 = int.Parse(Console.ReadLine());
                    int abs = Math.Abs(a20 - b20);
                    if (a20 > b20) Console.WriteLine(abs * 2);
                    else Console.WriteLine(abs);
                    break;
                case 21:
                    Console.Write(" Input first integer: ");
                    int a21 = int.Parse(Console.ReadLine());
                    Console.Write(" Input second integer: ");
                    int b21 = int.Parse(Console.ReadLine());
                    bool result21 = (a21 == 20 || b21 == 20 || a21 + b21 == 20);
                    Console.WriteLine(result21);
                    break;
                case 22:
                    Console.Write("Input an integer: ");
                    int n = int.Parse(Console.ReadLine());
                    bool result22 = (Math.Abs(100 - n) <= 20 || Math.Abs(200 - n) <= 20);
                    Console.WriteLine(result22);
                    break;
                case 23:
                    Console.Write("Enter a string: ");
                    string s23 = Console.ReadLine();
                    Console.WriteLine(s23.ToLower());
                    break;
                case 24:
                    Console.Write("Enter a sentence: ");
                    string s24 = Console.ReadLine();
                    string[] words = s24.Split(' ');
                    string longest = "";
                    foreach (string word in words)
                    {
                        if (word.Length > longest.Length) longest = word;
                    }
                    Console.WriteLine(longest);
                    break;
                case 25:
                    Console.WriteLine("Odd numbers from 1 to 99:");
                    for (int i = 1; i < 100; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 26:
                    int count = 0; int num26 = 2; int sum26 = 0;
                    bool IsPrime(int number)
                    {
                        if (number < 2) return false;
                        for (int i = 2; i <= Math.Sqrt(number); i++)
                        {
                            if (number % i == 0) return false;
                        }
                        return true;
                    }
                    while (count < 500)
                    {
                        if (IsPrime(num26))
                        {
                            sum26 += num26;
                            count++;
                        }
                        num26++;
                    }
                    Console.WriteLine($"Sum of the first 500 prime numbers: {sum26}");
                    break;
                case 27:
                    Console.Write("Input a number: ");
                    int n27 = int.Parse(Console.ReadLine());
                    int sum27 = 0;
                    while (n27 > 0)
                    {
                        sum27 += n27 % 10; 
                        n27 /= 10;       
                    }
                    Console.WriteLine("Sum of digits: " + sum27);
                    break;
                case 28:
                    Console.Write("Enter a sentence: ");
                    string s28 = Console.ReadLine();
                    string[] a28 = s28   .Split(' ');
                    Array.Reverse(a28);
                    Console.WriteLine(string.Join(" ", a28));
                    break;
                case 29:
                    Console.WriteLine(new FileInfo("test.txt").Length);
                    break;
                case 30:
                    Console.Write("Enter hexadecimal number: ");
                    string hex = Console.ReadLine();
                    int dec = Convert.ToInt32(hex, 16);
                    Console.WriteLine($"Decimal number: {dec}");
                    break;
                case 31:
                    int[] a31 = { 1, 3, -5, 4 };
                    int[] b31 = { 1, 4, -5, -2 };
                    Console.WriteLine("Multiply corresponding elements:");
                    for (int i = 0; i < a31.Length; i++)
                    {
                        Console.Write(a31[i] * b31[i] + " ");
                    }
                    break;
                case 32:
                    Console.Write("Input a string: ");
                    string str = Console.ReadLine();
                    if (str.Length < 4) Console.WriteLine(str);
                    else
                    {
                        string last4 = str.Substring(str.Length - 4);
                        Console.WriteLine(string.Concat(last4, last4, last4, last4));
                    }
                    break;
                case 33:
                    Console.Write("Input a positive integer: ");
                    int n33 = int.Parse(Console.ReadLine());
                    Console.WriteLine(n33 % 3 == 0 || n33 % 7 == 0);
                    break;
                case 34:
                    Console.Write("Input a string: ");
                    string s34 = Console.ReadLine();
                    Console.WriteLine(s34.StartsWith("Hello"));
                    break;
                case 35:
                    Console.Write("Input first number (<100): ");
                    int a35 = int.Parse(Console.ReadLine());
                    Console.Write("Input second number (>200): ");
                    int b35 = int.Parse(Console.ReadLine());
                    Console.WriteLine(a35 < 100 && b35 > 200);
                    break;
                case 36:
                    Console.Write("Input first number: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Input second number: ");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine((x >= -10 && x <= 10) || (y >= -10 && y <= 10));
                    break;
                case 37:
                    Console.Write("Input a string: ");
                    string s37 = Console.ReadLine();
                    if (s37.Length >= 3 && s37.Substring(1, 2) == "HP")
                        Console.WriteLine(s37.Remove(1, 2));
                    else Console.WriteLine(s37);
                    break;
                case 38:
                    Console.Write("Input a string: ");
                    string s38 = Console.ReadLine();
                    if (s38.Length >= 2 && s38[0] == 'P' && s38[1] == 'H')
                        Console.WriteLine(s38.Substring(0, 2));
                    else Console.WriteLine("");
                    break;
                case 39:
                    Console.Write("Input first integer: ");
                    int i1 = int.Parse(Console.ReadLine());
                    Console.Write("Input second integer: ");
                    int i2 = int.Parse(Console.ReadLine());
                    Console.Write("Input third integer: ");
                    int i3 = int.Parse(Console.ReadLine());
                    int largest = Math.Max(i1, Math.Max(i2, i3));
                    int lowest = Math.Min(i1, Math.Min(i2, i3));
                    Console.WriteLine($" Largest = {largest}");
                    Console.WriteLine($" Lowest = {lowest}");
                    break;
                case 40:
                    Console.Write("Input first integer: ");
                    int a40 = int.Parse(Console.ReadLine());
                    Console.Write("Input second integer: ");
                    int b40 = int.Parse(Console.ReadLine());
                    if (a40 == b40) Console.WriteLine(0);
                    else
                    {
                        int a1 = Math.Abs(a40 - 20);
                        int b1 = Math.Abs(b40 - 20);
                        Console.WriteLine(a1 < b1 ? a40 : b40);
                    }
                    break;
                case 41:
                    Console.Write("Input a string (contains at least one 'w'): ");
                    string s41 = Console.ReadLine();
                    int count41 = s41.Count(ch => ch == 'w');
                    Console.WriteLine(count41 >= 1 && count41 <= 3 ? "true" : "false");
                    break;
                case 42:
                    Console.Write("Input a string: ");
                    string s42 = Console.ReadLine();
                    if (s42.Length < 4) Console.WriteLine( s42.ToUpper());
                    else
                    {
                        string f4 = s42.Substring(0, 4).ToLower();
                        string r42 = s42.Substring(4).ToUpper();
                        Console.WriteLine(f4 + r42);
                    }
                    break;
                case 43:
                    Console.Write("Input a string: ");
                    string s43 = Console.ReadLine();
                    Console.WriteLine(s43.StartsWith("www"));
                    break;
                case 44:
                    Console.Write("Input a string: ");
                    string s44  = Console.ReadLine();
                    string result44 = "";
                    for (int i = 0; i < s44.Length; i += 2)
                    {
                        result44 += s44[i];
                    }
                    Console.WriteLine(result44);
                    break;
                case 45:
                    int[] a45 = { 1, 2, 5, 3, 5, 7, 9 };
                    Console.Write("Input an integer: ");
                    int num = int.Parse(Console.ReadLine());
                    int count45 = a45.Count(x => x == num);
                    Console.WriteLine( count45 > 0 ? $"The number {num} appears {count45} times in the array." : $"The number {num} does not appear in the array.");
                    break;
                case 46:
                    int[] a46 = { 1, 2, 5, 3, 8, 10 };
                    Console.Write("Input an integer: ");
                    int num46 = int.Parse(Console.ReadLine());
                    Console.WriteLine(a46[0] == num46 || a46[a46.Length - 1] == num46);
                    break;
                case 47:
                    int[] a47 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
                    Console.WriteLine($" Sum: {a47.Sum()}");
                    break;
                case 48:
                    int[] a48 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
                    Console.WriteLine(a48[0] == a48[a48.Length - 1]);
                    break;
                case 49:
                    int[] a49 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
                    int[] b49 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
                    bool check = a49[0] == b49[0] || a49[a49.Length - 1] == b49[b49.Length - 1];
                    Console.WriteLine (check);
                    break;
                case 50:
                    int[] a50 = { 1, 2, 3 };
                    int[] r50 = { a50[1], a50[2], a50[0] };
                    Console.WriteLine($"[{string.Join(", ", r50)}]");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 50.");
                    break;

            }

        }
    }
}
