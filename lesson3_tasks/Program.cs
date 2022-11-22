// Работа с текстом
// дан текст. нужно все пробелы заменить черточками
// маленькие буквы "к" заменить большими "К"
// большие "С" заменить маленькими "с"

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012345
// // s[3] = r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

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
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);


// сортировка массива от меньшего числа к большему

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length; // количество элементов массива

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();

// }

// void SelectionSort(int[] array)
// {

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }


//         int temporary = array[i]; // временная позиция
//         array[i] = array[minPosition]; // замена позиции: в текущую кладут минимальную
//         array[minPosition] = temporary;

//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);



// сортировка от большего к меньшему

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length; // количество элементов массива

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }


        int temporary = array[i]; // временная позиция
        array[i] = array[maxPosition]; // замена позиции: в текущую кладут максимальную
        array[maxPosition] = temporary;

    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);