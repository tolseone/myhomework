// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string Rank(int count)
{
    string msg = String.Empty;
    if ( count == 1 ) msg = "x (0; + бесконечность) и y (0; + бесконечность)";
    else if ( count == 2) msg = "x (0; + бесконечность) и y (0; - бесконечность)";
    else if ( count == 3) msg = "x (0; - бесконечность) и y (0; - бесконечность)";
    else if ( count == 4) msg = "x (0; - бесконечность) и y (0; + бесконечность)";
    else msg = "Такой четверти не существует!";
    
    return msg;
}

int n = Prompt("Введите номер четверти");
Console.WriteLine(Rank(n));