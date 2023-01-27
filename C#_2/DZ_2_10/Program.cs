int num_1 = Convert.ToInt32(Console.ReadLine());

if (num_1 > 9)
{
    string index = num_1.ToString();
    Console.WriteLine($"{index[1]}");
}
else
{
    Console.WriteLine("введите положительное число, более одного десятка");    
}



