public class Rank
{
    private string _rank;

    private string _pointNeeded;

    public Rank(string rank, string pointsneeded)
    {
        _rank = rank;
        _pointNeeded = pointsneeded;
    }
    public string GetRank()
    {
        return _rank;
    }

    public string GetPointNeeded()
    {
        return _pointNeeded;
    }

    public void SetRank(string rankname)
    {
        _rank = rankname;
    }

    public void SetPointNeeded(string pointneeded)
    {
        _pointNeeded = pointneeded;
    }
}