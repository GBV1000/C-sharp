int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());


int Acker (int M, int N)
{

    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0)
    {
        return Acker(M - 1, 1);
    }
    else
    {
        return Acker(M -1, Acker(M, N - 1));
    }

return Acker(M, N);
}

Console.WriteLine($"A({M},{N}) = {Acker(M, N)}");


// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))