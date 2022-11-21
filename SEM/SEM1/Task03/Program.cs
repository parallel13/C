// программа, которая выдает название дня недели по введенному числу
Console.WriteLine("Введите номер");
int num1 = Convert.ToInt32(Console.ReadLine());
switch (num1)
{
    
case 1:
Console.WriteLine("Понедельник");
break;

case 2:
Console.WriteLine("вторник");
break;
case 3:
Console.WriteLine("среда");
break;
case 4:
Console.WriteLine("среда");
break;

case 5:
Console.WriteLine("пятница");
break;

case 6:
Console.WriteLine("суббота");
break;
case 7:
Console.WriteLine("воскресенье");
break;

default:
Console.WriteLine("нет такого дня недели");
break;

}
