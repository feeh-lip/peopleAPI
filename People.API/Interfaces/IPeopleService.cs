namespace People.API.Interfaces;

public interface IPeopleService
{
    Task<PeopleModels> GetPeoples();
}
