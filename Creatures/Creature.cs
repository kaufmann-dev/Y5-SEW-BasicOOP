namespace Creatures;

public class Creature {
// Für jede Klasse wird default mäßig ein Defaultkonsturktor
// zur Verfügung gestellt, solange keine anderer Konstruktor
// definiert worden ist.

    public Creature() {

        // this: Pointer auf das Objekt selbst
    }

    public Creature(int endurance, int combatSkill) {
        Endurance = endurance;
        CombatSkill = combatSkill;
    }
    public int CombatSkill { get; set; }

    public int Endurance { get; set; }

    public void Run() {
        
    }
    
}