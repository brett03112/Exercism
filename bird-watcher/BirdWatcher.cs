using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        // 0, 2, 5, 3, 7, 8 and 4
        int[] lastWeek = new int[] { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeek;
    }

    public int Today()
    {
        int[] days = birdsPerDay;
        return days[6];
    }

    public void IncrementTodaysCount()
    {
        int[] days = birdsPerDay;
        days[6] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        int[] days = birdsPerDay;
        for (int i = 0; i < days.Length; i++)
        {
            if (days[i] == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int[] days = birdsPerDay;
        int count = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            count += days[i];
        }

        return count;
    }

    public int BusyDays()
    {
        int[] days = birdsPerDay;
        int count = 0;
        for (int i = 0; i < days.Length; i++)
        {
            if (days[i] >= 5)
            {
                count += 1;
            }
        }

        return count;
    }
}
