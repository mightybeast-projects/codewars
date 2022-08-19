namespace LeapYear;

public class LeapYear
{
    private int _year;

    public bool IsLeap(int year)
    {
        _year = year;

        if (YearIsDividableBy(400)) return true;
        if (YearIsDividableBy(100)) return false;
        if (YearIsDividableBy(4)) return true;
        return false;
    }

    private bool YearIsDividableBy(int number)
    {
        return _year % number == 0;
    }
}