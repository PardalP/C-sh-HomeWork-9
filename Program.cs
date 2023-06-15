Console.Clear();


// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// static void PrintNumbers(int n)
// {
//     if (n <= 0)
//         return;

//     Console.Write(n + ", ");
//     PrintNumbers(n - 1);
// }

// System.Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(N);
// Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.   
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// static int SumNum(int M, int N)
// {
//     if (M > N)
//         return 0;

//     return M + SumNum(M + 1, N);
// }

// System.Console.Write("Введите число 1: ");
// int M = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число 2: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int sum = SumNum(M, N);
// Console.WriteLine(sum);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

static int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (n == 0)
        return Ack(m - 1, 1);

    return Ack(m - 1, Ack(m, n - 1));
}

System.Console.Write("Введите число 1: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число 2: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = Ack(A, B);
Console.WriteLine(result);

