Console.Write("ВВедите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "schredinger")
{
    Console.WriteLine("Schredinger, а мы твоего кота съели =)");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}