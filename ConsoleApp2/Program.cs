Console.WriteLine("Hello, World!");
const float nombre1 = 10;
int age = 17;
char lettre ='A';
string message = "bonjour! le monde";
bool isPresent = true;
float nombre;
float nombre2;
float resultat;

Console.WriteLine("variable nombre1" + nombre1);
Console.WriteLine("variable age" + age);
Console.WriteLine("variable lettre" + lettre);
Console.WriteLine("variable isPresent" + isPresent);

// LECTURE

Console.WriteLine("Entre le nombre1 :");
nombre = int.Parse (Console.ReadLine());

Console.WriteLine("Entre le nombre2 :");
nombre2 = int.Parse(Console.ReadLine());

// LES OPERATEURS
// ARITHEMETIQUE + - / *

resultat = nombre + nombre2;

Console.WriteLine("le resultat de l'addiion:" +resultat);