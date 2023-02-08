Console.Write("Введиет координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиет координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0 ) Console.WriteLine("1 quater");
else if (x < 0 && y > 0 ) Console.WriteLine("2 quater");
else if (x < 0 && y < 0 ) Console.WriteLine("3 quater");
else if (x > 0 && y < 0 ) Console.WriteLine("4 quater");
