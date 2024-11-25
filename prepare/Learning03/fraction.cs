using System;
using System.Security.Cryptography.X509Certificates;


public class Fraction
{
    private int _top;
    private int _bottom;

   
    public Fraction()
    {
        _top = 0;
        _bottom = 1; 
    }

    
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

   
    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            Console.WriteLine("bottom cannot be zero");
        }
        _top = top;
        _bottom = bottom;
    }

    
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            Console.WriteLine("Bottom cannot be zero");
        }
        _bottom = bottom;
    }

    
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}

//