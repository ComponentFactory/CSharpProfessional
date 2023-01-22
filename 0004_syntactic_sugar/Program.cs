
//-------------------------------
// foreach over an Enumerator
//-------------------------------
var x = new List<int> { 1, 2, 3 };
foreach(var i in x)
    Console.WriteLine(i);

// Rewritten code
IEnumerator<int> enumerator = x.GetEnumerator();
try
{
    while (enumerator.MoveNext())
    {
        int i = enumerator.Current;
        Console.WriteLine(i);
    }
}
finally
{
    if (enumerator != null)
        enumerator.Dispose();
}


//-------------------------------
// foreach over an Array
//-------------------------------
var x = new int[] { 1, 2, 3 };
foreach(var i in x)
    Console.WriteLine(i);

// Rewritten code
int num = 0;
while (num < x.Length)
{
    int i = x[num];
    Console.WriteLine(i);
    num++;
}  


//-------------------------------
// Lamba assigned to an Action
//-------------------------------
Action<string> z1 = (name) => Console.WriteLine(name);

// Rewritten code
Action<string> z2 = Lambda.Method ?? (Lambda.Method = new Action<string>(Lambda.Singleton.Body));


//-------------------------------
// Closure assigend to an Action
//-------------------------------
var prefix = "Yo ";
Action<string> x1 = (name) => Console.WriteLine(prefix + name);
var prefix = "Hi ";
x1("Alice");

// Rewritten code
Closure c = new Closure();
c.prefix = "Yo ";
Action<string> x2 = new Action<string>(c.Body);
c.prefix = "Hi ";
x2("Alice");


//-------------------------------
// Lamba assigned to an Action
//-------------------------------
internal sealed class Lambda
{
    public static readonly Lambda Singleton = new Lambda();
    public static Action<string> Method;

    internal void Body(string name)
    {
        Console.WriteLine(name);
    }
}

//-------------------------------
// Closure assigend to an Action
//-------------------------------
internal sealed class Closure
{
    public string prefix;

    internal void Body(string name)
    {
        Console.WriteLine(string.Concat(prefix, name));
    }
}
