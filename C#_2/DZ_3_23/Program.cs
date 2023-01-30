int num_1 = Convert.ToInt32(Console.ReadLine());

string index = num_1.ToString();
string obr = "";
int lega = index.Length;
int pd1 = 1;



while(num_1 >= pd1)
{
    if (num_1 > pd1)
    {
        obr +=  Math.Pow(pd1,3) + ",";
        pd1 += 1;
    }
    else
    {
        obr +=  Math.Pow(pd1,3);
        pd1 += 1;
    }
}

Console.WriteLine(obr);