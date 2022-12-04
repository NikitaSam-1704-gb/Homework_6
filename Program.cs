// Задача 44. Не используя рекурсию выведите первые N чисел Фибоначи
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