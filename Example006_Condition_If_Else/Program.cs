Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // Оператор ToLower()выравнивает регистр введенного имяни всегда с маленькой буквы.
{
    Console.WriteLine("Ура, это же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}