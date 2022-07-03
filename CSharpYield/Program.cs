  static IEnumerable<string> GetSeason()
{
    string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
    List<string> seasonslist = new List<string>();
    foreach (var s in seasons)
        seasonslist.Add(s);
    return seasonslist;
}
//Function 2;
  static  IEnumerable<string> GetSeason2()
{
    string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
    foreach (var s in seasons)
        yield return s;
}
//Function 3;
  static  IEnumerable<string> GetSeason3()
{
    yield return "Winter";
    yield return "Spring";
    yield return "Summer";
    yield return "Autumn";

}

