using System;

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
