//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
//1. Считать от пользователя число

double GetNumberByUser(string text)
{
    Console.Write(text + "  ");
    return Convert.ToDouble(Console.ReadLine());
}
    double b1 = GetNumberByUser("Введите число b1: " );
    double k1 = GetNumberByUser("Введите число k1: " );
    double b2 = GetNumberByUser("Введите число b2: " );
    double k2 = GetNumberByUser("Введите число k2: " );
    

    
//2. нахождение точки пересечения
   
    double x = (b1 - b2)/(-k1 + k2);
    double y = k2 * x + b2;
  
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    

