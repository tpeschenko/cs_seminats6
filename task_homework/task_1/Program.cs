// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Task_1()
{
    Console.Write("Введите люболе кол-во чисел через запятую : ");
    string? numbers = Console.ReadLine();
    string[] newNumbers =  numbers.Split(", ");


    PrintSumNumberZero(newNumbers);
    
    void PrintSumNumberZero(string[] nums)
    {
        int size = nums.Length;
        int sum = 0;
        int num = 0;
        for(int i = 0; i < size; i++)
        {
            num = Convert.ToInt32(nums[i]);
            if (num > 0)
            {
                sum++;
            }
        }  
          
        Console.Write(sum);
    }
}

Task_1();