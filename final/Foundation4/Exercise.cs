using System.Data;

class Exercise
{
    private string _date;
    private int _length;
    private double _speed;
    private double _distance;
    private double _pace;
    public Exercise(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public virtual void Speed()
    {
        _speed = (_distance / _length) * 60;
        Pace();
    }
    public virtual void Pace()
    {
        _pace = 60 / _speed;
    }
    public virtual void Distance()
    {
        _distance = (_speed / 60) * _length;
    }
    public virtual void Summary()
    {
        Console.Write($"{_date} {this.GetType()} ({_length} minutes): Distance {_distance:F2} km, Speed {_speed:F2} kph, Pace {_pace:F2} min per km");
    }
    public void SetSpeed(double speed) { _speed = speed; }
    public double GetSpeed() { return _speed; }
    public void SetDistance(double distance) { _distance = distance; }
    public double GetDistance() { return _distance; }
}