Console.Write("Введите X точки А:");
int A_x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки А:");
int A_y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z точки А:");
int A_z = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X точки B:");
int B_x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки B:");
int B_y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z точки B:");
int B_z = Convert.ToInt32(Console.ReadLine());



double  d12 = Math.Sqrt(Math.Pow((B_x-A_x),2) + Math.Pow((B_y-A_y),2) + Math.Pow((B_z-A_z),2));

string s = d12.ToString("N2");

Console.WriteLine($"Растояние между точками {s}");