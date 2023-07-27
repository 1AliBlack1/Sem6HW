Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void mas(int m)
{
for (int i = 0; i < m; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива");
Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int kol(int[] Array)
{
int i=0;
int sum = 0;
while (i < Array.Length)
{
if(Array[i]>0)
sum = sum + 1;
i = i + 1;
}
return sum;
}

mas(m);
Console.Write($"n Чисел больше нуля: {kol(Array)}");



Console.WriteLine("Введите переменную b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"n Точка пересечения двух прямых: [{x},{y}]");