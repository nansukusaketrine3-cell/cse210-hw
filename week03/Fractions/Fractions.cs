using System;

public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Default constructor (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter (top/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters (top/bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and Setter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}