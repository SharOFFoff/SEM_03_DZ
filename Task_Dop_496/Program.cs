// Task_Dop_496
Console.Clear();
Console.Write("Введите кол-во элементов:\n");
int n = Convert.ToInt32(Console.ReadLine()), resultSum = 0;
while (n < 3 || n > 1000)
{
   Console.WriteLine("Ошибка! Введите кол-во элементов:\n");
   n = Convert.ToInt32(Console.ReadLine()); 
}
Console.Write("Введите элементы:\n");
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
     array[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < array.Length - 1; i++)
{
if (resultSum < array[i - 1] + array[i] + array[i + 1])
    resultSum = array[i - 1] + array[i] + array[i + 1];
}

if (resultSum < array[n - 1] + array[n - 2] + array[0])
    resultSum = array[n - 1] + array[n - 2] + array[0];
if (resultSum < array[0] + array[1] + array[n - 1])
    resultSum = array[0] + array[1] + array[n - 1];
//Console.WriteLine(resultSum);
Console.WriteLine($"Max = {resultSum}");