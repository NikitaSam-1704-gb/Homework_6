// Задача 42 напишите программу преодразования десятичного числа в двоичное
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
WriteLine(codeBinary);
