namespace People.API.Services;

public class PeopleService : IPeopleService
{
    private readonly IPeopleRepository _peopleRepository;

    public PeopleService(IPeopleRepository peopleRepository)
    {
        _peopleRepository = peopleRepository;
    }

    public async Task<List<PeopleDto>> GetPeoples(string nome)
    {
        try
        {
            var peoples = await _peopleRepository.GetPeoples();

            if (peoples is null || !peoples.Results.Any())
            {
                //return erro
            }

            List<PeopleDto> peopleDto = new List<PeopleDto>();

            if (!string.IsNullOrEmpty(nome))
            {
                peoples.Results = peoples.Results.Where(p => p.Name.ToUpper().Equals(nome.ToUpper())).ToList();
            }

            foreach (var item in peoples.Results)
            {
                peopleDto.Add(new PeopleDto()
                {
                    Birth_Year = item.Birth_Year,
                    Created = item.Created,
                    Edited = item.Edited,
                    Eye_Color = item.Eye_Color,
                    Films = item.Films,
                    Gender = item.Gender,
                    Hair_Color = item.Hair_Color,
                    Height = item.Height,
                    Homeworld = item.Homeworld,
                    Mass = item.Mass,
                    Name = item.Name,
                    Skin_Color = item.Skin_Color,
                    Species = item.Species,
                    Starships = item.Starships,
                    Url = item.Url,
                    Vehicles = item.Vehicles
                });
            }

            return peopleDto;
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
