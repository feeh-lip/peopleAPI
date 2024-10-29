namespace People.API.Models;

public class PeopleModels
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public List<DataPeopleModels> Results { get; set; }
}