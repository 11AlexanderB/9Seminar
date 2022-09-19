try
{
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    string Numbers(int N, int M)
    {
        if (N > M) return " ";
        return Numbers(N, M - 1) + M + " ";
    }
    Console.WriteLine(Numbers(n, m));
}
catch
{
    Console.WriteLine("Ошибка");
}