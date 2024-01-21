namespace Creatures;

public class Orc : Creature {
    // Wird der Konstruktor einer Klasse aufgerufen, die die Kindklasse einer anderen
    // Klasse ist, erfolgt der Aufruf des Basiskonstruktors vor dem Aufruf des eigenen
    // Konstruktors
    public Orc() : base(30, 12) {
        Console.WriteLine("alora");
    }
}