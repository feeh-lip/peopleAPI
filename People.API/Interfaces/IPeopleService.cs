namespace People.API.Interfaces;

public interface IPeopleService
{
    Task<List<PeopleDto>> GetPeoples(int page, string nome);
}
