﻿//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void task2()
{
    
    Console.WriteLine("Введите занчения b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите занчения k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите занчения b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите занчения k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    
  
    PrintDot(b1, b2 , k1, k2);
    
    void PrintDot(double b1, double b2, double k1, double k2)
    {
        double x = 0;
        double y = 0;
        x = (b2 - b1)/(k1 - k2);
        y = k1 * x + b1;
        
        Console.Write($"({x}; {y})");     
    }

}
task2();
