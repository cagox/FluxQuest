using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    //Ability scores.
    //Mind
    public AbilityScore Intelligence, Wisdom, Ego;
    //Body
    public AbilityScore Strength, Agility, Constitution;
    //Spirit
    public AbilityScore Power, Gnosis, Quintessence;

    public string Name;
    private int _copper; //I will adjust this later.


    public CharacterSheet(
        string name="UnknownStranger", 
        int intelligence=10, 
        int wisdom=10, 
        int ego=10, 
        int strength=10, 
        int agility=10,
        int constitution=10,
        int power=10,
        int gnosis=10,
        int quintessence=10,
        int copper = 0
        ) {
            Name = name;
            Intelligence = new AbilityScore("Intelligence", "Int", intelligence);
            Wisdom = new AbilityScore("Wisdom", "Wis", wisdom);
            Ego = new AbilityScore("Ego", "Ego", ego);
            Strength = new AbilityScore("Strength", "Str", strength);
            Agility = new AbilityScore("Agility", "Agi", agility);
            Constitution = new AbilityScore("Constitution", "Con", constitution);
            Power = new AbilityScore("Power", "Pow", power);
            Gnosis = new AbilityScore("Gnosis", "Gno", gnosis);
            Quintessence = new AbilityScore("Quintessence", "Quint", quintessence);
            _copper = copper;
    }

    public int GetMaxHitpoints(){
        return Ego.GetScore() + Constitution.GetScore() + Quintessence.GetScore();
    }
    
    public int Mana() {
        // This will potentially change as the system developes.
        // Mana is Quintessence + Modifiers
        return Quintessence.GetScore();
    }

    public int GetMaxEssence() {
        //Max EP is Ego + Mana
        return Ego.GetScore() + Mana();
    }

    public int GetMaxStamina() {
        // Max Stamina is Ego + Constitution
        return Ego.GetScore() + Constitution.GetScore();
    }
}
