
int dayNumber = 5;

switch (dayNumber)
{
    case 5 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}
// 2
int score = 78;

switch (score)
{
    case >= 0 and < 39:
        Console.WriteLine("неудовлетворительно");
        break;
    case >= 40 and < 59:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 79:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}
//3
int a = 13;
string result = a switch
{
    >= 35 => " Очень жарко ",
    >= 34 => "жарко",
    >= 24 => "Комфортно",
    >= 14 => "прохладно",
    _ => "мороз"

};
Console.WriteLine(result);
// 4
string role = "teacher";

string b = role switch
{
    "teacher" => "Доступ преподавателя",
    "admin" => "Доступ админа",
    not "teacher" and not "admin" => "Ограниченный доступ"
};
Console.WriteLine(b);

int age = 20;
bool hasticket = true;
switch (age)
{
    case >= 18 when hasticket:
        Console.WriteLine("Вход разрешен ");
}
