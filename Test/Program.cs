using Test.Methods;

Console.WriteLine("Добро пожаловать в калькулятор!");

while (true)
{
    Console.WriteLine("Введите х: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите y: ");
    double y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Выберите оператор: \n1. + \n2. -, \n3. *\n4. /");
    char symbol = Convert.ToChar(Console.ReadLine());

    var result = MyClassMatch.MyOperations(x, y, symbol);
    Console.WriteLine($"{result.Message} {result.Value}");

    Console.WriteLine("Для продолжения введите: y \nДля выхода введите: n");
    string input = Console.ReadLine();
    if (input == "n")
    {
        Console.Clear();
        Console.WriteLine("Выход из программы");
        Console.ReadLine();
        break;
    }
    else if (input == "y")
    {
        Console.Clear();
        continue;
    }
}






