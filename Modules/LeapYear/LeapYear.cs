namespace LeapYear;

public class LeapYear
{
    private int year;

    public bool IsLeap(int year)
    {
        this.year = year;

        if (YearIsDividableBy(400)) return true;
        if (YearIsDividableBy(100)) return false;
        if (YearIsDividableBy(4)) return true;
        return false;
    }

    private bool YearIsDividableBy(int number) => year % number == 0;
}