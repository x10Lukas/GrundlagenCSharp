//Aufgabe 1
Console.WriteLine(short.MaxValue);
Console.WriteLine(short.MinValue);
/*
16bit
32767
-32768
*/

Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
/* 
32bit
2147483647
-2147483648
 */

Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);
/*
64bit
#9223372036854775807
-9223372036854775808
*/

Console.WriteLine(float.MaxValue);
Console.WriteLine(float.MinValue);
/*
32bit
 3,4028235E+38
-3,4028235E+38
*/

Console.WriteLine(double.MaxValue);
Console.WriteLine(double.MinValue);
/*
64bit
1,7976931348623157E+308
-1,7976931348623157E+308
*/

Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.MinValue);
/*
128bit
79228162514264337593543950335
-79228162514264337593543950335
*/

//Aufgabe 2

string vorname = "Lukas";
short alter = 22;
bool frage = false;

Console.WriteLine($"\nIhre Angaben:\n\n1. {vorname}\n2. {alter}\n3. {frage}");

//Aufgabe 3
/*
int Dollarzahl = 36;
char Dollar = (char)Dollarzahl;
*/

//Aufgabe 4

Console.WriteLine("\nGeben Sie die erste Variable ein!");
string v1_str = Console.ReadLine();
short v1_short = Convert.ToInt16(v1_str);

string v2_str = Console.ReadLine();
double v2_double = Convert.ToDouble(v2_str);
