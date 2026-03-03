using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

int inte = 0;
int doub = 0;
int stri = 0;
int boole = 0;

object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };

Console.WriteLine("[전체 데이터 출력]");
PrintAll(data);

Console.WriteLine("[타입별 통계]");
Console.WriteLine($"정수: {inte}");
Console.WriteLine($"실수: {doub}");
Console.WriteLine($"문자열: {stri}");
Console.WriteLine($"논리값: {boole}");


void PrintData(object data)
{
    if(data.GetType() == typeof(int))
    {
        Console.WriteLine($"정수: {data}");
        inte++;
    }
    else if(data.GetType() == typeof(double))
    {
        Console.WriteLine($"실수: {data:F2}");
        doub++;
    }
    else if( data.GetType() == typeof(string))
    {
        string str = (string)data;
        Console.WriteLine($"실수: {str} (길이: {str.Length})");
        stri++;
    }
    else if(data.GetType() == typeof(bool))
    {
        Console.WriteLine($"논리값: {data} → 거짓");
        boole ++;
    }
}
void PrintAll(object[] data)
{
    foreach (object item in data)
    {
        PrintData(item);
    }
}