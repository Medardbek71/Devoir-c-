using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


int studentCount = 3;
int subjectCount = 5;

Console.WriteLine("Application de gestion de notes - 3 élèves, 5 matières\n");

var defaultSubjects = new[] { "Mathématiques", "Français", "Histoire", "Anglais", "Sciences" };
var subjects = new string[subjectCount];
Console.WriteLine("Entrez les noms des 5 matières (appuyez sur Entrée pour utiliser la valeur par défaut) :");
for (int i = 0; i < subjectCount; i++)
{
    Console.Write($"Matière {i + 1} [{defaultSubjects[i]}]: ");
    var input = Console.ReadLine()?.Trim();
    subjects[i] = string.IsNullOrEmpty(input) ? defaultSubjects[i] : input;
}

// Lire les élèves et leurs notes
var students = new List<Student>(studentCount);
for (int s = 0; s < studentCount; s++)
{
    Console.WriteLine($"\n-- Élève {s + 1} --");
    string name;
    while (true)
    {
        Console.Write("Nom de l'élève : ");
        name = Console.ReadLine()?.Trim();
        if (!string.IsNullOrEmpty(name)) break;
        Console.WriteLine("Le nom ne peut pas être vide. Réessayez.");
    }

    var grades = new double[subjectCount];
    for (int m = 0; m < subjectCount; m++)
    {
        grades[m] = ReadGrade($"Note pour {subjects[m]} (0 - 20) : ");
    }

    students.Add(new Student { Name = name, Grades = grades });
}

// Calculs
foreach (var st in students)
    st.CalculateAverage();

var classAverage = students.SelectMany(s => s.Grades).Average();

// Moyenne par matière
var subjectAverages = new double[subjectCount];
for (int m = 0; m < subjectCount; m++)
    subjectAverages[m] = students.Average(s => s.Grades[m]);

// Classement des élèves par moyenne (décroissant)
var ranked = students.OrderByDescending(s => s.Average).ToList();

// Affichage du bilan
Console.WriteLine("\n===== BILAN DES NOTES =====\n");

Console.WriteLine("Détail par élève :\n");
foreach (var st in ranked)
{
    Console.WriteLine($"{st.Name} - Moyenne: {st.Average:F2}");
    for (int m = 0; m < subjectCount; m++)
    {
        Console.WriteLine($"  {subjects[m],-15}: {st.Grades[m]:F2}");
    }
    Console.WriteLine();
}

Console.WriteLine("Classement :");
for (int i = 0; i < ranked.Count; i++)
{
    Console.WriteLine($"{i + 1}. {ranked[i].Name} - Moyenne: {ranked[i].Average:F2}");
}

Console.WriteLine($"\nMoyenne générale de la classe : {classAverage:F2}");

Console.WriteLine("\nMoyenne par matière :");
for (int m = 0; m < subjectCount; m++)
{
    Console.WriteLine($"{subjects[m],-15}: {subjectAverages[m]:F2}");
}

// Meilleur élève par matière
Console.WriteLine("\nMeilleur élève par matière :");
for (int m = 0; m < subjectCount; m++)
{
    double bestGrade = students.Max(s => s.Grades[m]);
    var bestStudents = students.Where(s => Math.Abs(s.Grades[m] - bestGrade) < 1e-9).Select(s => s.Name).ToArray();
    Console.WriteLine($"{subjects[m],-15}: {bestGrade:F2} - {string.Join(", ", bestStudents)}");
}

Console.WriteLine("\nAppuyez sur une touche pour quitter...");
Console.ReadKey();


// ---------- Fonctions et classes ----------

double ReadGrade(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var raw = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(raw))
        {
            Console.WriteLine("Veuillez entrer une note.");
            continue;
        }

        // Autoriser , ou . comme séparateur décimal
        raw = raw.Replace(',', '.');
        if (double.TryParse(raw, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out double value))
        {
            if (value >= 0 && value <= 20) return value;
            Console.WriteLine("La note doit être comprise entre 0 et 20.");
        }
        else
        {
            Console.WriteLine("Format de note invalide. Utilisez un nombre (ex: 15 ou 15.5).");
        }
    }
}

class Student
{
    public string Name { get; set; } = string.Empty;
    public double[] Grades { get; set; } = Array.Empty<double>();
    public double Average { get; private set; }

    public void CalculateAverage()
    {
        if (Grades == null || Grades.Length == 0) { Average = 0; return; }
        Average = Grades.Average();
    }
}
