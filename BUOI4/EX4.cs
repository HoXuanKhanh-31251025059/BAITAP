namespace BAITAP.BUOI4
{
    internal class EX4
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n====MENU BAI TAP====");
                Console.WriteLine("1. Kiểm tra số chẵn/lẻ");
                Console.WriteLine("2. Tìm số lớn nhất trong 3 số");
                Console.WriteLine("3. Xác định góc phần tư của tọa độ");
                Console.WriteLine("4. Kiểm tra loại tam giác");
                Console.WriteLine("5. Tính tổng và trung bình của 10 số");
                Console.WriteLine("6. Bảng cửu chương");
                Console.WriteLine("7. In tam giác số");
                Console.WriteLine("8. In tam giác kiểu 1,2,3...");
                Console.WriteLine("9. Chuỗi Harmonic");
                Console.WriteLine("10. Tìm số hoàn hảo trong khoảng");
                Console.WriteLine("11. Kiểm tra số nguyên tố");
                Console.WriteLine(" 0. Thoát");
                Console.Write(" Chọn bài tập");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập số: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine(n % 2 == 0 ? "Số chẵn" : " Số lẽ");
                        break;
                    case 2:
                        Console.Write(" Nhập a2: ");
                        int a2 = int.Parse(Console.ReadLine());
                        Console.Write(" Nhập số b2: ");
                        int b2 = int.Parse(Console.ReadLine());
                        Console.Write(" Nhập c2: ");
                        int c2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($" Số lớn nhất là {Math.Max(a2, Math.Max(b2, c2))}");
                        break;
                    case 3:
                        Console.Write(" Nhập x: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write(" Nhập y: ");
                        int y = int.Parse(Console.ReadLine());
                        if (x > 0 && y > 0) Console.WriteLine("Điểm nằm ở góc phần tư I");
                        else if (x < 0 && y > 0) Console.WriteLine("Điểm nằm ở góc phần tư II");
                        else if (x < 0 && y < 0) Console.WriteLine("Điểm nằm ở góc phần tư III");
                        else if (x > 0 && y < 0) Console.WriteLine("Điểm nằm ở góc phần tư IV");
                        else if (x == 0 && y != 0) Console.WriteLine("Điểm nằm trên trục tung");
                        else if (y == 0 && x != 0) Console.WriteLine("Điểm nằm trên trục hoành");
                        else Console.WriteLine("Điểm nằm tại gốc tọa độ");
                        break;
                    case 4:
                        Console.WriteLine(" Nhập cạnh a4: ");
                        int a4 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Nhập cạnh b4: ");
                        int b4 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Nhập cạnh c4: ");
                        int c4 = int.Parse(Console.ReadLine());
                        if (a4 == b4 && b4 == c4) Console.WriteLine("Tam giác đều");
                        else if (a4 == b4 || b4 == c4 || a4 == c4) Console.WriteLine("Tam giác cân");
                        else Console.WriteLine("Tam giác thường");
                        break;
                    case 5:
                        int sum = 0;
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write($"Nhập số thứ {i}: ");
                            int num5 = int.Parse(Console.ReadLine());
                            sum += num5;
                        }
                        Console.WriteLine($"Tổng: {sum}, Trung bình: {(double)sum / 10}");
                        break;
                    case 6:
                        Console.Write(" Nhập số: ");
                        int n6 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Bảng cửu chương:");
                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine($"{n6} x {i} = {n6 * i}");
                        break;
                    case 7:
                        Console.Write(" Nhập số hàng: ");
                        int rows = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= rows; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(1 + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 8:
                        Console.Write(" Nhập số dòng: ");
                        int lines = int.Parse(Console.ReadLine());
                        int num8 = 1;
                        for (int i = 1; i <= lines; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(num8 + " ");
                                num8++;

                            }
                            Console.WriteLine();
                        }
                        break;
                    case 9:
                        Console.Write(" Nhập n: ");
                        int n9 = int.Parse(Console.ReadLine());
                        double harmonicSum = 0;
                        for (int i = 1; i <= n9; i++)
                        {
                            harmonicSum += 1.0 / i;
                            Console.Write($"1/{i} ");
                        }
                        Console.WriteLine($"\n = {harmonicSum}");
                        break;
                    case 10:
                        Console.Write(" Nhập khoảng từ: ");
                        int start = int.Parse(Console.ReadLine());
                        Console.Write(" đến: ");
                        int end = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Số hoàn hảo trong khoảng:");
                        for (int i = start; i <= end; i++)
                        {
                            int sumDivisors = 0;
                            for (int j = 1; j < i; j++)
                            {
                                if (i % j == 0) sumDivisors += j;
                            }
                            if (sumDivisors == i) Console.WriteLine(i);
                        }
                        break;
                    case 11:
                        Console.Write(" Nhập số: ");
                        int num11 = int.Parse(Console.ReadLine());
                        bool isPrime = true;
                        if (num11 <= 1) isPrime = false;
                        else
                        {
                            for (int i = 2; i <= Math.Sqrt(num11); i++)
                            {
                                if (num11 % i == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine(isPrime ? "Số nguyên tố" : "Không phải số nguyên tố");
                        break;
                    case 0:
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
