int num_1 = Convert.ToInt32(Console.ReadLine());

string index = num_1.ToString();
string obr = "";
int lega = index.Length;


while (lega >= 1)
{
    obr += index[lega-1];
    lega = lega - 1;
}

int result = Int32.Parse(obr);

if (num_1 == result)
{
    Console.WriteLine($"входящее {num_1}, перевертыш {result}. Итог, является палиндромом");
}

