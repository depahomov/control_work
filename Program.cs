//Методы вывода массива на экран

void PrintArray(string[] array)
{
    System.Console.Write("[" + array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write("," + " " + array[i]);
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

// Задаём массив из 4 строк
string[] StrArray = new string[4] {"Hello", "2", "world", ":-)"};

// Метод подсчёта количества элементов (строк) в исходном массиве с длиной не более 3 символов 
int CountingNum(string[] array);
{
    
}

PrintArray(StrArray);