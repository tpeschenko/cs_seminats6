// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со
// сторонами такой длины.

void Task39()
{
    FindMaxSide(2, 8, 5);

}    

void FindMaxSide(int sideA, int sideB, int sideC)
{
    if((sideA < sideB + sideC) && (sideB < sideA + sideC) && (sideC < sideA + sideB))
    {
        Console.Write("Треугольник возможен ");
    }
    else
    {
        Console.Write("Треугольник не возможен");
    }
 
}

Task39();
















