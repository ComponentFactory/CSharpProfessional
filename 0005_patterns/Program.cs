object x = 43;

//---------------------------
// Type pattern
//---------------------------
if (x is int)
{
    int a = (int)x;
    Console.WriteLine($"x = {a}");
}

switch(x)
{
    case int:
        int b = (int)x;
        Console.WriteLine($"x = {b}");
        break;
}

string output1 = x switch
{
    int => $"x = {(int)x}",
    _ => throw new ArgumentException("Unknown", nameof(x)),
};


//---------------------------
// Declaration pattern
//---------------------------
if (x is int c)
{
    Console.WriteLine($"x = {c}");
}

switch(x)
{
    case int d:
        Console.WriteLine($"x = {d}");
        break;
}

string output2 = x switch
{
    int e => $"x = {e}",
    _ => throw new ArgumentException("Unknown", nameof(x)),
};


//----------------------------------
// Constant pattern
// (Values or const fields/local)
//----------------------------------

if (x is 43)
{
    Console.WriteLine("everything");
}

const int constLocal = 43;
if (x is constLocal)
{
    Console.WriteLine("everything");
}

if (x is "Everything")
{
    Console.WriteLine("C#");
}

if (x is null)
{
    Console.WriteLine("null");
}

string output3 = x switch
{
    43 => "everything",
    "Everything" => "C#",
    null => "null",
    _ => throw new ArgumentException("Unknown", nameof(x)),
};


//---------------------------
// Relational pattern
// <, <=, >, >=
// (Only against constants)
//---------------------------

if (x is > 42)
{
    Console.WriteLine("more than 42");
}

string output4 = x switch
{
    < 42 => "less than",
    >= 42 => "more or equal",
    _ => throw new ArgumentException("Unmatched", nameof(x)),
};


//---------------------------
// Logical pattern
// not, and, or
//---------------------------

if (x is not null)
{
    Console.WriteLine("!null");
}

if (x is < 'b' or > 'b')
{
    Console.WriteLine("is not 'b'");
}

if (x is int f and > 42 and < 44)
{
    Console.WriteLine($"x = {f}");
}

string output6 = x switch
{
    > 42 and < 44 => "43",
    _ => throw new ArgumentException("Unmatched", nameof(x)),
};


//---------------------------
// Property pattern
//---------------------------

object q = DateTime.Now;

if (q is DateTime { Year: 2023, Month: 1 or 2 or 3 } dt1)
{
    Console.WriteLine(dt1.ToShortDateString());
}

if (DateTime.Now is { DayOfWeek: DayOfWeek.Tuesday } or { Year: 2023 })
{
    Console.WriteLine("Tues or 2034");
}


//---------------------------
// Positional pattern
//---------------------------

//---------------------------
// var pattern
//---------------------------

//---------------------------
// Discard pattern
//---------------------------

//---------------------------
// Parenthesized  pattern
//---------------------------

//---------------------------
// List   pattern
//---------------------------