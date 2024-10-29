namespace People.API.Interfaces;

public interface IPeopleRepository
{
    [Get("/api/people")]
    Task<People> GetPeoples();
}
