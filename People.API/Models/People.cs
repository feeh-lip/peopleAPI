namespace People.API.Models;

public class People
{
    public int Count { get; set; }
    public string Next { get; set; }
    public object Previous { get; set; }
    public List<DataPeople> Results { get; set; }
}