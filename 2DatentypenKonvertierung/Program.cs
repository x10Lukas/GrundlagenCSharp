//Aufgabe 1
/*
    16 Bit
    32767
    -32768
*/

Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
Console.WriteLine(" ");

/*
    Bit 32
    2147483647
    -2147483648
*/

//Aufgabe 2

string vorname = "Lukas";
short alter = 22;
bool frage = true;

Console.WriteLine("Ihre Antworten:");
Console.WriteLine($"1. {vorname}\n2. {alter}\n3. {frage}");

//Aufgabe 3
/*
int Dollarzahl = 36;
char Dollar = Dollarzahl;
*/
//Aufgabe 4

Console.WriteLine(" ");
Console.WriteLine("Geben Sie die erste Variable ein!");
string v1_str = Console.ReadLine();

short v1_short = Convert.ToInt16(v1_str);

Console.WriteLine(v1_short);
