using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.BUOI1_2
{
    internal class EX1
    {
        static void SumTwoNumbers()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Tổng = " + (a + b));
            Console.ReadLine();
        }
        static void SwapTwoNumbers()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Nhập số d: ");
            double d = double.Parse(Console.ReadLine());
            double temp = c;
            c = d;
            d = temp;
            Console.WriteLine($"Sau khi hoán đổi: c={c}" + $" d={d}");
            Console.ReadLine();
        }
        static void MultiplyFloats()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số thực thứ nhất: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số thực thứ hai: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tích = " + (a * b));
            Console.ReadLine();
        }
        static void FeettoMeter()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số feet: ");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine("Meters = " + (feet * 0.3048));
            Console.ReadLine();
        }

        static void TemperatureConvert()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Enter Celsius: ");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit = " + f);

            Console.Write("Enter Fahrenheit: ");
            f = double.Parse(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine("Celsius = " + c);
            Console.ReadLine();
        }
        static void SizeOfDataTypes()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kích thước của int: " + sizeof(int));
            Console.WriteLine("Kích thước của float: " + sizeof(float));
            Console.WriteLine("Kích thước của double: " + sizeof(double));
            Console.WriteLine("Kích thước của char: " + sizeof(char));
            Console.ReadLine();
        }
        static void ASCIIValue()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập một ký tự: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine("\nASCII value = " + (int)ch);
            Console.ReadLine();
        }
        static void AreaCircle()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập bán kính: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình tròn = " + (Math.PI * r * r));
            Console.ReadLine();
        }
        static void AreaSquare()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập cạnh hình vuông: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình vuông = " + (a * a));
            Console.ReadLine();
        }
        static void DaysConvert()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số ngày: ");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int weeks = (days % 365) / 7;
            int remainingDays = (days % 365) % 7;
            Console.WriteLine($"{days} ngày = {years} năm, {weeks} tuần, {remainingDays} ngày");
            Console.ReadLine();
        }
        static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                int choice;

                do
                {
                    Console.WriteLine("\n===== MENU =====");
                    Console.WriteLine("1. Sum two numbers");
                    Console.WriteLine("2. Swap two numbers");
                    Console.WriteLine("3. Multiply two floats");
                    Console.WriteLine("4. Convert feet to meter");
                    Console.WriteLine("5. Temperature conversion");
                    Console.WriteLine("6. Size of data types");
                    Console.WriteLine("7. ASCII value");
                    Console.WriteLine("8. Area of circle");
                    Console.WriteLine("9. Area of square");
                    Console.WriteLine("10. Convert days");
                    Console.WriteLine("0. Exit");

                    Console.Write("Choose: ");
                    while (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        Console.Write("Choose: ");
                    }

                    switch (choice)
                    {
                        case 1:
                            SumTwoNumbers();
                            break;
                        case 2:
                            SwapTwoNumbers();
                            break;
                        case 3:
                            MultiplyFloats();
                            break;
                        case 4:
                            FeettoMeter();
                            break;
                        case 5:
                            TemperatureConvert();
                            break;
                        case 6:
                            SizeOfDataTypes();
                            break;
                        case 7:
                            ASCIIValue();
                            break;
                        case 8:
                            AreaCircle();
                            break;
                        case 9:
                            AreaSquare();
                            break;
                        case 10:
                            DaysConvert();
                            break;
                        case 0:
                            Console.WriteLine("Exit program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }

                } while (choice != 0);
            }
        }
    }
