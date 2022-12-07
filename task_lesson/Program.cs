// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

void task39()
{
    int[] array = {1, 3, 6, 3, 3};
    int sizeArray = array.Length;
    int size = sizeArray - 1;
    int temp = 0;

    
    // TurnArray_1(array);
    TurnArray_2(array);
    PrintArray(array);
    
//  Первый способ(через переменную)
//    void TurnArray_1(int[] num)
//    {    
//         for(int i = 0; i < sizeArray/2; i++)
//         {   
//             temp = num[i];
//             num[i] = num[size - i];
//             num[size - i] = temp;

//         }

//  Второй способ, через кортеж. 
    void TurnArray_2(int[] num)
   {    
        for(int i = 0; i < sizeArray/2; i++)
        {   
            (num[i], num[size - i]) = (num[size - i], num[i]);
        }
   }
   void PrintArray(int[] num)
    {
        Console.WriteLine("Перевёрнутый массив: ");
        for(int i = 0; i < sizeArray; i++)
        {
            Console.Write(num[i] + " ");
        }
        Console.WriteLine();
    }
}

task39();