
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int summ = 0;

int var_i = N - M + 1;


for (int i = 1; var_i >= i; i++ , M++)
{
    summ = summ + M ;
    Console.WriteLine(i);
}


Console.WriteLine(summ);
