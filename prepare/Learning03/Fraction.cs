using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    //constructors
    public Fraction()
    {
        int _top = 1;
        int _bottom = 1;
    }

    public Fraction(int top)
    {
        this._top = top;
        this._bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }

    //getters and setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        this._top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        this._bottom = bottom;
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