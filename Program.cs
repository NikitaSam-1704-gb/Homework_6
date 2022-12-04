/* Задача 40// Напишите программу, которая на вход принимает три числа и проверят,
// можетли существовать треугольник со сторонами данной длины

using static System.Console;
Clear();

int [] InputSide( int size, string[] message)
{
    int[] array= new int[size];
    WriteLine(message[0]);
    for(int i=0; i<array.Length; i++)
    {
        Write(message[i+1]);
        array[i]=Convert.ToInt16(ReadLine());
    }
    return array;
}

void RpintSide(int[] array)
{
    Write($" сторона А-> {array[0]}  сторона B-> {array[1]}  сторона C-> {array[2]} ");
    WriteLine();
}



string[] text=new string[4];
text[0]=("Введите значения сторон треугольника");
text[1]=(" Значение стороны A -> ");
text[2]=(" Значение стороны B -> ");
text[3]=(" Значение стороны C -> ");

int[] sideArray=InputSide(3, text);
RpintSide(sideArray);

int sideMaх=-1;
int summ=0;
for(int i=0; i<sideArray.Length; i++)
{
    if(sideArray[i]<=0)
    {
        WriteLine(" Ошибка, значение любой стороны треугольника должно быть больше 0");
        break;
    }
    if(sideMaх<sideArray[i])
        sideMaх=sideArray[i];
    summ+=sideArray[i];
}

if(summ-sideMaх>sideMaх)
    WriteLine("Можно построить треугольник с данными значениями сторон ");
else
    WriteLine(" Сданными значениями сторон треугольник построить НЕЛЬЗЯ");*/

/*// Задача 42 напишите программу преодразования десятичного числа в двоичное
// 45 -> 101101
// 3-> 11
// 2-> 10 

using static System.Console;
Clear();

 int IntFromConsole( string message)
 {
    Write(message);
    int chislo=Convert.ToInt16(ReadLine());
    return chislo;
 }

 string ConvertingNumberDecimalBinary(int chislo)
 {
    string code=(" ");
    while(chislo!=0)
    {
        code=chislo%2+code;
        chislo=chislo/2;
    } 
    return code;
 }

String text=(" Введите число ");
int chisloWork=IntFromConsole(text);
Write($" Число   {chisloWork}  в двоичной системе -> ");
string codeBinary=ConvertingNumberDecimalBinary(chisloWork);
WriteLine(codeBinary);*/

/*// Не используя рекурсию выведите первые N чисел Фибоначи
// Если N=5 -> 0 1 1 2 3
// Если N=7 -> 0 1 1 2 3 5 8

using static System.Console;
Clear();

 int IntFromConsole( string message)
 {
    Write(message);
    int number=Convert.ToInt16(ReadLine());
    return number;
 }

 string FibonacciSeries(int number)
 {
    string fibonacci="";
    int[] summ=new int[number+1];
    summ[0]=0;
    summ[1]=1;
    if(number>=2)
        fibonacci=fibonacci+summ[0]+summ[1];
    else
    {
        fibonacci=fibonacci+summ[0];
        return fibonacci;
    }

    
    for(int i=2; i<number; i++)
    {
        summ[i]=summ[i-1]+summ[i-2];
        fibonacci=fibonacci+summ[i];
    }
    return fibonacci;
 }

String text=(" Введите число элементов N-> ");
int numberWork=IntFromConsole(text);
string series=FibonacciSeries(numberWork);
WriteLine($" ряд Фибоначи для {numberWork} элементов {series}");*/

/*//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

using static System.Console;
Clear();

 string IntFromConsole( string message)
 {
    string str=""; 
    Write(message);
    str=ReadLine();
    return str;
 }

 int CountPositive(string str)
 {
    int count=0;
    int flag=1;
    for(int i=0; i<str.Length; i++)
    {
        if(str[i]=='-' || str[i]=='0')
            flag=-1;
        
        if(str[i]==' '&& flag==-1)
            flag=1;
        else 
        {
            if(str[i]==' ' && flag==1)
                count++;
        }
        if(str[i]==str[str.Length-1] && flag==1)
         count++;
    }
    return count;
 }

String text=(" Введите  N  чисел , через пробел, и нажмите Enter ");
string strWork=IntFromConsole(text);

int countWork=CountPositive(strWork);
WriteLine($"Количество положительных элементов - > {countWork}");*/

/*//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
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
WriteLine($" Кординаты точки пересечения ({x},{y})");*/
