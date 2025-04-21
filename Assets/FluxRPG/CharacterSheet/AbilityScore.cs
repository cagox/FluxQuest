using UnityEngine;
using Unity.Mathematics;

public class AbilityScore
{
    [SerializeField] private int _score = 10;
    [SerializeField] private string _name = "None";
    [SerializeField] private string _abbreviation = "NON";
    [SerializeField] private int _averageScore = 10;
    private double _experience;
    public int exp_multiplier = 100;


    public AbilityScore(string name, string abbreviation, int score) {
        _score = score;
        _name = name;
        _abbreviation = abbreviation;
        _experience = ReturnExpNeededForRank(score);
    }

    public int DisplayExperience() {
        return (int)(math.floor(_experience));
    }

    public string GetName() {
        return _name;
    }
    public string Abbreviate() {
        return _abbreviation;
    }


    public int GetScore() {
        return _score;
    }

    public void SetScore(int mod) {
        _score = _score + mod;
    }


    public double ReturnExpNeededForRank(int rank) {
        return Util.CostOfRank(rank - _averageScore, exp_multiplier);
    }

    //This method is recursive. If it causes issues, make it itterative.
    public bool AddExperience(double exp) {
        if(exp + _experience >= ReturnExpNeededForRank(_score+1)){
            _experience += ReturnExpNeededForRank(_score+1) - exp;
            _score++;
            return AddExperience(exp - ReturnExpNeededForRank(_score));
        }
        _experience += exp;
        return true;
    }

    public int GetModifier(){
        return (int)math.floor(_experience/5);
    }
}
