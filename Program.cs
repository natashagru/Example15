// программа которая на вход принимает цифру, обозначающую день недели и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Проверим является ли этот день выходным");
Console.WriteLine("введите цифру обозначающую день недели");
int n = int.Parse(Console.ReadLine()!);
if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
{
    Console.WriteLine("нет");
}
else if (n == 6 || n == 7)
{
    Console.WriteLine("да!");
}
else 
{
    Console.WriteLine("число не является днем недели");
}