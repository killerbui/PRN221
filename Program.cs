using System;


class Program
{
    // Hàm kiểm tra xem một số có phải là số nguyên tố không
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int[] numbers = new int[10];

        // Nhập vào mảng 10 số nguyên từ bàn phím
        Console.WriteLine("Nhập vào 10 số nguyên:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nhập số thứ {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // In ra các số là số nguyên tố
        Console.WriteLine("\nCác số nguyên tố trong mảng là:");
        for (int i = 0; i < 10; i++)
        {
            if (IsPrime(numbers[i]))
            {
                Console.WriteLine(numbers[i]);
            }
        }

        Console.ReadLine(); // Dừng chương trình để xem kết quả
    }
}