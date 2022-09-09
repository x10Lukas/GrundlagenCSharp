//Aufgabe 1
Console.WriteLine("  .-. ");
Console.WriteLine(" (o o) ");
Console.WriteLine(" | O | ");
Console.WriteLine(" |   | ");
Console.WriteLine(" '~~~' ");

//Aufgabe 2
string vorname = "Lukas";
string nachname = "Zangen";
string alter = "22";

Console.WriteLine("Vorname: {0}", vorname);
Console.WriteLine("Nachname: {0}", nachname);
Console.WriteLine("Alter: {0}", alter);

//Aufgabe 3
string Vorname;
string Alter;
string Klasse;

Console.WriteLine("Geben Sie ihre Daten ein!");
Vorname = Console.ReadLine();
Alter = Console.ReadLine();
Klasse = Console.ReadLine();

Console.WriteLine($"{Vorname} ist {Alter} Jahre alt und besucht die {Klasse} des Georg-Simon-Ohm Berufskollegs.");
