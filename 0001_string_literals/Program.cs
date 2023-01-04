//----------------------------------------
// Challenge
//----------------------------------------

var _ = $$$""""
        Lorem ipsum dolor sit amet, consectetur adipiscing 
        elit, sed do eiusmod tempor incididunt ut labore et 
        dolore magna aliqua. Ut enim ad minim veniam, quis 
        nostrud exercitation ullamco laboris nisi ut aliquip 
        ex ea commodo consequat.
        """";   

//----------------------------------------
// 1 - Quoted literal
//----------------------------------------

var a = "Great for single line text without escaped characters";
var b = "C:\\YouTube\\Data\\Documents\\";


//----------------------------------------
// 2 - Verbatim literal
//----------------------------------------

var c = @"C:\YouTube\Data\Documents\";

var d = @"Shall I compare Thee to a Summers day?
Thou art more lovely and more temperate:";

var e = @"Shall I compare ""Thee"" to a Summers day?
Thou art more lovely and more temperate:";


//----------------------------------------
// 3 - Raw literal
//----------------------------------------

var f = """
Shall I compare "Thee" to a Summers day?
Thou art more lovely and more temperate:
""";

var g = """
        Shall I compare "Thee" to a Summers day?
        Thou art more lovely and more temperate:
        """;

var h = """"
        Shall I compare """Thee""" to a Summers day?
        Thou art more lovely and more temperate:
        """";


//----------------------------------------
// 4 - Interpolated quoted literal
//----------------------------------------

var i = $"C:\\YouTube\\Data\\{DateTime.Now.DayOfWeek}\\";

//----------------------------------------
// 5 - Interpolated verbatim literal
//----------------------------------------

var j = $@"C:\YouTube\Data\{DateTime.Now.DayOfWeek}\";
var k = @$"C:\YouTube\Data\{DateTime.Now.DayOfWeek}\";

//----------------------------------------
// 6 - Interpolated raw literal
//----------------------------------------
var l = $""""
        Shall I compare Three to a {DateTime.Now.DayOfWeek}?
        Thou art more lovely and more temperate:
        """";

var m = $$""""
        How can I use curly brackets {like this} on a {{DateTime.Now.DayOfWeek}}?
        """";   

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(i);
Console.WriteLine(j);
Console.WriteLine(k);
Console.WriteLine(l);
Console.WriteLine(m);

