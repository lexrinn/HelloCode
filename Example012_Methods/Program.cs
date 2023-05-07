// Вид 1    Ничего не принимают и ничего не возвращают.

void Method1()                          // В скобочках не никаких аргументов.
{
    Console.WriteLine ("Autor ...");    // Тело метода. Что-то может показывать на экран.
}
Method1();                              // Вариант как вызывается подобного рода методы. 
                                        // Указать идентификатор метода и круглые скобки.
                                            
// Вид 2    Ничего не возвращают, но могут принимать аргументы.

void Method2(string msg)               // Идентификатор и какое-то количество аргументов.
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)               // Идентификатор и какое-то количество аргументов.
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine (msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);                   // Если использовать именованные аргументы, 
                                                    // не обязательно писать их по порядку.


// Вид 3    Ничего не принимают и что-то возвращают.    

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

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
string res = Method4(10, "z");
Console.WriteLine(res);

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
string rslt = Method41(10, "asdf");
Console.WriteLine(rslt);
