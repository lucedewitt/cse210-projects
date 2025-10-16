class Fraction
{
    private int _numerator;
    private int _denominator;
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public int GetNumerator() { return _numerator; }
    public int GetDenominator() { return _denominator; }
    public void SetNumerator(int value) { _numerator = value; }
    public void SetDenominator(int value) { _denominator = value; }
    public string GetFractionString()
    {
        string fraction = $"{_numerator}/{_denominator}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        double divided = (double)_numerator / (double)_denominator;
        return divided;
    }
}