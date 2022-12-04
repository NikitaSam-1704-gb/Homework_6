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

// Не используя рекурсию выведите первые N чисел Фибоначи
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
WriteLine($" ряд Фибоначи для {numberWork} элементов {series}");