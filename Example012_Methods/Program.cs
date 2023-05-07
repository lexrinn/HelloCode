// Вид 1    Ничего не принимают и ничего не возвращают.

void Method1()                          // В скобочках не никаких аргументов.
{
    Console.WriteLine ("Autor ...");    // Тело метода. Что-то может показывать на экран.
}
//Method1();                              // Вариант как вызывается подобного рода методы. 
                                        // Указать идентификатор метода и круглые скобки.
                                            
// Вид 2    Ничего не возвращают, но могут принимать аргументы.

void Method2(string msg)               // Идентификатор и какое-то количество аргументов.
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)               // Идентификатор и какое-то количество аргументов.
{
    int i=0;                                       // i - счетчик.
    while (i<count)
    {
        Console.WriteLine (msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);                   // Если использовать именованные аргументы, 
                                                    // не обязательно писать их по порядку.


// Вид 3    Ничего не принимают и что-то возвращают.    

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

// Вид 4    Что-то принимают и что-то возвращают.

string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;
    
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(10, "z");
//Console.WriteLine(res);

// Вид 4 с использованием цикла for.    Что-то принимают и что-то возвращают.

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i=0; i<count; i++)
        {
        result = result + text;
    }
    return result;
}
//string rslt = Method41(10, "asdf");
//Console.WriteLine(rslt);

// Цикл в цикле

// for (int i=2; i<=10; i++)
// {
//     for (int j=2; j<=10; j++)
//     {
//         Console.WriteLine($"{i}x{j}={i*j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//               012 
// s[3] // r

string Replace(string text, char oldValue, char newValue)           // char - конкретный символ.
{
    string result = String.Empty;                                   // Инициализация пустой строки - "result" присвоить String.Empty (пустую строку).

    int lenght=text.Length;                                         // Выдаст длину текста.
    for (int i=0; i<lenght; i++)                                    // Пробегаемся от нулевого символа до конца,
    {
        if(text[i] == oldValue) result = result + $"{newValue}";    // делая эти действия.    
        else result = result + $"{text[i]}";                        // {text[i]} - текущий символ.
    }
    return result;
}
// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);

// Сортировка.

int[] arr={1, 3, 5, 3, 7, 4, 8, 1};

void PrintArray(int[] array)                                        // Назвали метод PrintArray
{
    int count = array.Length;
    
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)                                    // Назвали метод SelectionSort. В качестве аргумента будет приходить некий массив.
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;

        for (int j=i+1; j<array.Length; j++)
        {
            if(array[j]<array[minPosition]) minPosition=j; 
        }

        int temporary = array[i];                               // Обмен мест переменных.
        array[i] = array [minPosition];
        array [minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);