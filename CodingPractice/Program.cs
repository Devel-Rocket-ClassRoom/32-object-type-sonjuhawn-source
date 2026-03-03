using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


Console.WriteLine("'''");
int q = 123;
string hel = "hello";
char c = 'a';
double ar = 3.14;
object ob = new object();

Console.WriteLine(q.GetType());  
Console.WriteLine(hel.GetType());  
Console.WriteLine(c.GetType());  
Console.WriteLine(ar.GetType()); 
Console.WriteLine(ob.GetType());  

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Console.WriteLine(typeof(int));        
Console.WriteLine(typeof(string));     
Console.WriteLine(typeof(double));

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Point1 p1 = new Point1 { X = 10, Y = 20 };
Console.WriteLine(p1.GetType().Name);              
Console.WriteLine(typeof(Point).Name);            
Console.WriteLine(p1.GetType() == typeof(Point));  
Console.WriteLine(p1.X.GetType().Name);            
Console.WriteLine(p1.Y.GetType().FullName);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
int ab = 42;
double pi = 3.14;
bool tr = true;
Console.WriteLine(ab.ToString()); 
Console.WriteLine(pi.ToString());      
Console.WriteLine(tr.ToString());

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Panda panda = new Panda();
panda.Name = "Petey";
Console.WriteLine(panda);
Console.WriteLine(panda.ToString());

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Player player = new Player() { Name = "Hero", Level = 10, Health = 100 };
Console.WriteLine(player.ToString());
Console.WriteLine("'''\n");

Console.WriteLine("'''");
string s1 = "Hello";
string s2 = "Hello";
string s3 = s1;

Console.WriteLine($"ReferenceEquals(s1, s2): {object.ReferenceEquals(s1, s2)}"); 
Console.WriteLine($"ReferenceEquals(s1, s3): {object.ReferenceEquals(s1, s3)}");  

// 새 객체 생성 시
object ob1 = new object();
object ob2 = new object();
object ob3 = obj1;

Console.WriteLine($"obj1.Equals(obj2): {ob1.Equals(obj2)}");           
Console.WriteLine($"ReferenceEquals(obj1, obj2): {object.ReferenceEquals(ob1, obj2)}");  
Console.WriteLine($"ReferenceEquals(obj1, obj3): {object.ReferenceEquals(ob1, obj3)}");  

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

class Point1
{
    public int X;
    public int Y;
}

class Panda
{
    public string Name;

    public override string ToString()
    {
        return Name;
    }
}

class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"Player {{ Name = {Name}, Level = {Level}, Health = {Health} }}";
    }
}