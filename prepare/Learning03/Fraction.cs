public class Fraction
{
    private int _numerator = new int();
    private int _denominator = new int();
    public Fraction()
    {
        _numerator=1;
        _denominator=1;
    }
    public Fraction(int a)
    {
        _numerator=a;
        _denominator=1;
    }
    public Fraction(int b, int c)
    {
      _numerator=b;
      SetDen(c);  
    }
    public void SetDen(int d)
    {
        if (d != 0)
        {
            _denominator = d;
        }
        else
        {
            _denominator = 1;
        }
    }
    public void SetNum(int n)
    {
        _numerator=n;   
    }
    public int GetNum()
    {
        return _numerator;   
    }
    public int GetDen()
    {
        return _denominator;   
    }
    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }
    public double GetDecimal()
    {
        return (double)_numerator / (double)_denominator;
    }
}