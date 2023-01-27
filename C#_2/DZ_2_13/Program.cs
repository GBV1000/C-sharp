int num_1 = Convert.ToInt32(Console.ReadLine());

string index = num_1.ToString();
int lega = index.Length;

if (lega > 2)
{
    Console.WriteLine($"{index[2]}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}