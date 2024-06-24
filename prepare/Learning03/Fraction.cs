using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    //constructors
    public Fraction(int top, int bottom)
    {
        int _top = top;
        int _bottom = bottom;
    }

    public Fraction(int top)
    {
        int _top = top;
        int _bottom = 1;
    }

    //methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}