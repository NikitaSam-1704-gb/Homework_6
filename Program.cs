// Напишите программу, которая на вход принимает три числа и проверят,
// можетли существовать треугольник со сторонами данной длины

using static System.Console;
Clear();

/*(int sideA, int sideB, int sideC) ParamretrTriangle()
{
    (int sideA, int sideB, int sideC)triangle;
    Write("Введите значение стороны треугольника A ");
    triangle.sideA=Convert.ToInt16(ReadLine());
    Write("Введите значение стороны треугольника B ");
    triangle.sideB=Convert.ToInt16(ReadLine());
    Write("Введите значение стороны треугольника C ");
    triangle.sideC=Convert.ToInt16(ReadLine());
    return triangle;
}*/

int InputSide( string message)
{
    Write(message);
    int side=Convert.ToInt16(ReadLine());
    //if(side<=0)
    //    WriteLine(" Ошибка. Значения сторон положительные числа");
    return side;
}

void RpintSide(int sideA, int sideB, int sideC)
{
    Write($" сторона А {sideA}  сторона B {sideB}  сторона C {sideC} ");
    WriteLine();
//    int chislo=Convert.ToInt16(ReadLine());
//    return chislo;
}


string text;
WriteLine ("Введите значения сторон треугольника");
text=(" Введите значение стороны A -> ");
int sideA=InputSide(text);
text=(" Введите значение стороны B -> ");
int sideB=InputSide(text);
text=(" Введите значение стороны C -> ");
int sideC=InputSide(text);
//(int sideA, int sideB, int sideC)triangleWork=ParamretrTriangle();
RpintSide(sideA, sideB, sideC);
