//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Clear();
System.Console.Write("Введите количество планируемых вводимых чисел: \t");

int elementsCount = int.Parse(Console.ReadLine());
int [] array = new int[elementsCount];
for (int i = 0; i < array.Length; i++)
{

    System.Console.Write("Введите число: ");
    array[i] = int.Parse(Console.ReadLine());   
    Console.Clear();

}

System.Console.Write($"Числа: ");



for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($" {array[i]} ");
}

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");

System.Console.WriteLine(sum);