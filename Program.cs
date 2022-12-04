//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


using static System.Console;
Clear();
(int a, int b, int c) CoefficientStraightline()
{
    (int a, int b, int c) line;
    Write(" Введите коэффициент А  ");
    line.a=Convert.ToInt16(ReadLine());
    Write(" Введите коэффициент В ");
    line.b=Convert.ToInt16(ReadLine());
    Write(" Введите коэффициент C ");
    line.c=Convert.ToInt32(ReadLine());
    Clear();
    return line;
}

WriteLine(" Введите коэффициенты  уравнения прямой №1 ");
(int a1, int b1, int c1) line1=CoefficientStraightline();

WriteLine(" Введите коэффициенты  уравнения прямой №2 ");
(int a2, int b2, int c2) line2=CoefficientStraightline();

WriteLine($" Уравнение прямой №1 {line1.a1}x+{line1.b1}y+{line1.c1}=0");
WriteLine($" Уравнение прямой №2 {line2.a2}x+{line2.b2}y+{line2.c2}=0");

double y= (line2.a2*line1.c1-line1.a1*line2.c2)/(line2.b2*line1.a1-line1.b1*line2.a2);
double x=(-line1.c1/line1.a1)-(line1.b1/line1.a1)*y;
WriteLine($" Кординаты точки пересечения ({x},{y})");
