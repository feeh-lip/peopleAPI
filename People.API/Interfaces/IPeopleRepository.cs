namespace People.API.Interfaces;

public interface IPeopleRepository
{
    [Get("/api/people/?page={page}")]
    Task<PeopleModels> GetPeoples(int page);
}
