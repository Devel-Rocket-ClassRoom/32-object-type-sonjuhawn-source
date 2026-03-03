using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("'''");
object obj1 = 42;
object obj2 = 3.14;
object obj3 = "Hello";
object obj4 = true;

Console.WriteLine(obj1);
Console.WriteLine(obj2);
Console.WriteLine(obj3);
Console.WriteLine(obj4);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Stack stack = new Stack();
stack.Push("sausage");
string s = (string)stack.Pop();
Console.WriteLine(s);

stack.Push(3);
int three = (int)stack.Pop();
Console.WriteLine(three);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
int i = 1234;
Object o = i;
Console.WriteLine(o);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
object o1= 1234;
int j = (int)o1;
Console.WriteLine(j);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
int k = 42;
object o2 = k;
Console.WriteLine(o2);

Console.WriteLine("'''\n");


Console.WriteLine("'''");
Point p = new Point { X = 10, Y = 20 };
IDisplayable d = p;
Console.WriteLine(d.GetType().Name);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
int x = 3;
object o3 = x;
x = 5;
Console.WriteLine($"원본: {x}");
Console.WriteLine($"박싱된 값: {o3}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
object o4 = 42;
int y = (int)o4;
try
{
    //long l = (long)boxed;  
}
catch (InvalidCastException)
{
    Console.WriteLine("잘못된 타입으로 언박싱 시도");
}

int temp = (int)o4;
long temp1 = (long)temp;
Console.WriteLine(temp1);

Console.WriteLine("'''\n");


Console.WriteLine("'''");
int sum1 = 0;
for (int a = 0; a < 1000; a++)
{
    object boxed = i;       
    sum1 += (int)boxed;     
}
Console.WriteLine($"박싱 사용: {sum1}");

// 좋은 예: 박싱 없이 직접 처리
int sum2 = 0;
for (int r = 0; r < 1000; r++)
{
    sum2 += i;              
}
Console.WriteLine($"직접 처리: {sum2}");

Console.WriteLine("'''\n");


Console.WriteLine("'''");
GenericStack<int> intStack = new GenericStack<int>();
intStack.Push(42);       
int value = intStack.Pop();  
Console.WriteLine(value);

Console.WriteLine("'''\n");


class Stack
{
    private int position;
    private object[] _data = new object[10];

    public void Push(object obj)
    {
        _data[position++] = obj; 
    }
    public object Pop()
    {
        return _data[--position];
    }
}

interface IDisplayable
{
}

struct Point : IDisplayable
{
    public int X;
    public int Y;
}

class GenericStack<T>
{
    private T[] _items = new T[100];
    private int _top = 0;

    public void Push(T item)
    {
        _items[_top++] = item;
    }

    public T Pop()
    {
        return _items[--_top];
    }
}