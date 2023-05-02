Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "alex")
{
    Console.WriteLine("Yoohooo, it's ALEX!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}