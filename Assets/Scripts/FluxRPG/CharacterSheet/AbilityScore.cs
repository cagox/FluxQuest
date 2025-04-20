using UnityEngine;
using Unity.Mathematics;

public class AbilityScore
{
    [SerializeField] private int _score = 10;
    [SerializeField] private string _name = "None";
    [SerializeField] private string _abbreviation = "NON";
    [SerializeField] private int _averageScore = 10;
    private double _experience;


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


    public int ReturnExpNeededForRank(int rank) {
        if (rank == _averageScore) {
            return 0;
        }
        int exp = 0;
        int adjustedRank = rank - _averageScore;
        if (adjustedRank > 0){
            for (int i = 1; i <= adjustedRank; i++) {
                exp += i * 100;
            }
            return exp;
        }
        for(int i = -1; i >= adjustedRank; i--){
            exp += i * 100;
        }
        return exp;
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
