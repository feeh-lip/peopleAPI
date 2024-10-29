namespace People.API.Services;

public class PeopleService : IPeopleService
{
    private readonly IPeopleRepository _peopleRepository;

    public PeopleService(IPeopleRepository peopleRepository)
    {
        _peopleRepository = peopleRepository;
    }

    public async Task<PeopleModels> GetPeoples()
    {
        var peoples = await _peopleRepository.GetPeoples();

        if(peoples == null)
        {
            //return erro
        }

        return null;
    }
}
