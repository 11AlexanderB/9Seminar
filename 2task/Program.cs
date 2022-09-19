try
{
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int Numbers(int N, int M)
    {
        if (N > M) return 0;
        return N + Numbers(N+1, M);
    }
    Console.WriteLine(Numbers(n, m));
}
catch
{
    Console.WriteLine("Ошибка");
}
