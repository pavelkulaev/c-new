// вид 1
// void Method1 ()
// {
//     Console.Writeline ("Автор Кулаев Павел");
// }
// Method1 ();  //вызов метода 









// Вид 2
// void Method2(string msg)
// {
//     Console.Writeline(msg);
// }
// Method2("текст сообщения");

// void Method21(string msg)
// {
//     Console.Writeline(msg);
//     i++;
// }
// Method21(msg:"текст сообщения", count: 4);

// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4

// string Method4 (int count, string text)
// {
//     int i=0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
 
//  string res = Method4(10, "asdf");
//  Console.WriteLine(res);

// string Method4 (int count, string text)
// {
    
//     string result = String.Empty;
//     for (int i=0;i < count;i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
 
//  string res = Method4(10, "asdf");
//  Console.WriteLine(res);


// for (int i=2;i <=10 ;i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i}x{j}={i*j}");
//     }
//     Console.WriteLine();
// }


// работа с текстом
// Дан текст. В тексте нужно все пробелы заменит точками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// String text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// // string s = "qwerty"
// //             012345
// //S[3] = r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
        
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);



// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.


int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j]< array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);