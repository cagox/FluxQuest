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
