//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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
WriteLine($"Количество положительных элементов - > {countWork}");
