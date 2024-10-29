namespace People.API.Interfaces;

public interface IPeopleService
{
    Task<List<PeopleDto>> GetPeoples(string nome);
}
