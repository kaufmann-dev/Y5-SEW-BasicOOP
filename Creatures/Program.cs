// See https://aka.ms/new-console-template for more information

using Creatures;

Console.WriteLine("Hello, World!");

//1) Klasse: Die Klasse ist ein Bauplan

//2) Objekt: Die Objekte werden entsprechend dem Bauplan aus der
//         Klasse erzeugt

// Synonym für Objekt: Instanz einer Klasse, Variable

// Variablendefinition
// Datentyp name
// Datentyp -> einfachen Datentypen: int, double, bool, byte, float, long , char, short
//          -> referenz Datentypen: für jeden r Datentypen existiert eine Klassendefinition
//                                  Verhalten (Methoden) und Zustand (Variablen)

// Keyword: new stellt den Speicher auf dem Heap bereit.
// Konstruktor: Ist verantwortlich für das Erstellen der Creature Instanz

// Alternativen zum Anlegen einer Creatureinstanz und zur Dateninitialisierung   


// 3) Klassenobjekt: Für jede KLasse in C# wird ein sogenanntes Klassenobjekt
//                   erstellt. Für jede Klasse kann es immer nur ein einziges
//                   Klassenobjekt geben.




Creature ork = new Creature();

ork.CombatSkill = 3;
ork.Endurance = 7;
Console.WriteLine($"{ork.Endurance}, {ork.CombatSkill}");

var ork2 = new Creature();
ork2.CombatSkill = 2;
ork2.Endurance = 21;
Console.WriteLine($"{ork2.Endurance}, {ork2.CombatSkill}");

var ork3 = new Creature(4, 21);
Console.WriteLine($"{ork3.Endurance}, {ork3.CombatSkill}");

var ork4 = new Creature { Endurance = 100, CombatSkill = 45 };
Console.WriteLine($"{ork4.Endurance}, {ork4.CombatSkill}");

Creature ork5 = new(){ Endurance = 23, CombatSkill = 100};
Console.WriteLine($"{ork5.Endurance}, {ork5.CombatSkill}");