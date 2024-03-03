// Метод вывода массива на экран
void PrintArray(string[] array)
{
    System.Console.Write("[" + array[0]);
    if (array.Length > 0)
    {
        for (int i = 1; i < array.Length; i++)
        {
            System.Console.Write("," + " " + array[i]);
        }
    }
    System.Console.Write("]");
    
    // else
    // {
    //     System.Console.Write("[]");
    // }
}

// Метод подсчёта количества элементов (строк) в исходном массиве с длиной не более 3 символов 
int CountingNum(string[] array)
{
    int count = 0;
    if (array.Length > 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length < 4) count++;
        }
    }
    return count;
}

// Метод формирование нового массива из существующего 
string[] MakeArray(string[] array)
{
    int count = CountingNum(array);
    //string[] NewArray = new string[count];
    if (count > 0)
    {
        string[] NewArray = new string[count];
        int number = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length < 4)
            {
                NewArray[number] = array[i];
                number++;
            }
        }
        return NewArray;
    }
    else 
    {
        string[] NewArray = new string[1];
        NewArray[0] = "";
        return NewArray;
    }
}

//------------------------------------------------------------------------
//
// Задаём массив из строк
// string[] StrArray = new string[4] {"1", "1234", "Hello", "world"};
string[] StrArray = new string[3] {"1234", "Hello", "world"};
// Формируем новый массив из элементов исходного массива, 
// длина которых не больше 3 символов
string[] NewStrArray = MakeArray(StrArray);
// Вывод массивов на экран
PrintArray(StrArray);
System.Console.Write(" -> ");
PrintArray(NewStrArray);