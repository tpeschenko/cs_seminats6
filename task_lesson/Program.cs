// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

void task39()
{
    int[] array = {1, 3, 6, 3, 3};
    int sizeArray = array.Length;
    int[] newArray = new int[sizeArray];
    string str = String.Empty;

    TurnArray(array);
    PrintArray(array);
    

   void TurnArray(int[] num)
   {
        for(int i = sizeArray - 1; i >= 0; i--)
        {   
            str += num[i];                
        }
        for(int i = 0; i < sizeArray; i++)
        {
            array[i] = Convert.ToInt32(str[i]);
        }
   }
   void PrintArray(int[] num)
    {
        int LonArray = num.Length;
        Console.WriteLine("Перевёрнутый массив: ");
        for(int i = 0; i < sizeArray; i++)
        {
            Console.Write(str[i] + " ");
        }
        Console.WriteLine();
    }
}

task39();