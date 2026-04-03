using System.Collections.Generic;

public class StatsCalculator
{
    public double GetTotalDistance(List<Activity> activities)
    {
        double total = 0;
        foreach (Activity a in activities)
        {
            total += a.GetDistance();
        }
        return total;
    }
}
