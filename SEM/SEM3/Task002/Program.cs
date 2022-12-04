// Написать программу, которая по заданному номеру четверти показывает авозможные координаты точек в этой четверти (х и у)

System.Console.WriteLine("Введите номер четверти");
string q = Console.ReadLine();



string result = Range(q);

Console.WriteLine(result);
string Range(string num)
{
    if(num == "1") return "xc > 0 && yc > 0";
    if(num == "2") return "xc < 0 && yc > 0";
    if(num == "3") return "xc < 0 && yc < 0";
    if(num == "4") return "xc > 0 && yc < 0";
    return "ошибка ввода";
}




