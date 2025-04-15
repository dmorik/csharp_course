namespace App;

public static class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

        return isLeapYear;
    }
}