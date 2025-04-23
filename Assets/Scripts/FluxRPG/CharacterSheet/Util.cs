using UnityEngine;
using System.Linq;


public class Util
{
    //This method will help with displays and progress bars.
    public static double CostOfRank(int rank, int multiplier) 
    {
        return (double)(rank * multiplier);
    }

    //This method presents the full cost of the attribute not just a given rank.
    //I could have used CostOfRank() for the math, BUT, it would be super inefficient
    //at this point. If I ever get more convoluted with the math to decide rank costs,
    //I will update TotalCostOfRank() to use CostOfRank().
    public static double TotalCostOfRank(int rank, int multiplier)
    {
        double exp = 0.0D;
        if(rank == 1) {
            return (double)multiplier;
        }
        if(rank == 0) {
            return 0.0D;
        }
        if (rank > 1) {
            for(int i = 1; i <= rank; i++){
                exp += i * multiplier;
            }
            return exp;
        }
        if (rank < 0){
            for (int i=-1; i >= rank; i--){
                exp += i * multiplier;
            }
        }
        return exp;
    }

    
}

//I will give this a bet ter name eventually, but this name works for now.
public static class FluxColor
{
    public static Color maskColor = HexToColor("#FF00FF");  //Common Masking Color
    public static Color theVoid = Color.black;
    public static Color earth = HexToColor("#69480d");
    public static Color wind = HexToColor("#fffacc");
    public static Color water = HexToColor("#2323fc");
    public static Color fire = HexToColor("#fa8220");
    public static Color nature = Color.green;
    public static Color forest = HexToColor("#04470e");
    public static Color life = HexToColor("#fffffc");
    public static Color death = HexToColor("#2b014a");
    public static Color between = HexToColor("#145c4c");//Will work for now. Will customize a bit more later.
    public static Color space = HexToColor("#01097d");
    public static Color spirit = HexToColor("#e0fffd");
    public static Color nullAffinity = HexToColor("#4a484a");
    public static Color plains = HexToColor("#bbf53d");
    public static Color desert = HexToColor("#f5f29d");
    public static Color ocean = HexToColor("#92ddfc");
    public static Color lake = HexToColor("#9df5cc");
    public static Color poison = HexToColor("#a09fe0");
    public static Color chaos = Color.red;
    
    public static Color HexToColor(string hex)
    {
        if (hex.StartsWith("#"))
            hex = hex.Substring(1);

        byte r = 255, g = 255, b = 255, a = 255;

        if (hex.Length == 6) // RRGGBB
        {
            r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        }
        else if (hex.Length == 8) // RRGGBBAA
        {
            r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            a = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
        }
        else
        {
            Debug.LogWarning($"Invalid hex color: {hex}");
        }

        return new Color32(r, g, b, a);
    }

        public static Color[] AppendColor(Color[] array, Color newColor)
    {
        var list = array.ToList();
        list.Add(newColor);
        return list.ToArray();
    }
}