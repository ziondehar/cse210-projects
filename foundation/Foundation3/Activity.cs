public abstract class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _length;
    }
    public abstract void GetDistance();
   
    public abstract void GetSpeed();
    public abstract void GetPace();
    public abstract void Fullstring();






}