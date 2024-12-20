Console.Write("Введите элементы массива (разделяйте их пробелом): ");
string n = Console.ReadLine();

string[] y = n.Split(' ');
int[] arr = new int[n.Length];

for (int i = 0; i < y.Length; i++)
{
    arr[i] = int.Parse(y[i]);
}

int sum = 0;

foreach (int num in arr)
{
    if (num % 7 == 0)
    {
        sum += num;
    }
}

Console.WriteLine($"Сумма всех чисел, кратных 7: {sum}");