namespace LinQ;

public class Songs
{
    #region ctor
    public Songs(int id, string name, string band, DateTime releaseDate)
    {
       Id = id;
       Name = name;
       Band = band;
       ReleaseDate = releaseDate;
    }
    #endregion

    public int Id { get; set; }
    public string Name { get; set; }
    public string Band { get; set; }
    public DateTime ReleaseDate { get; set; }

    #region override
    public override string ToString() =>
    $"Code: {Id} | Name: {Name} | Band: {Band} | Release Date {ReleaseDate}";
    #endregion
}