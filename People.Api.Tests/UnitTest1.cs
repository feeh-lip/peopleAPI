using Moq;
using People.API.Interfaces;
using People.API.Services;

namespace People.Api.Tests
{
    public class PeopleTests
    {
        private readonly PeopleService _peopleService;
        private readonly Mock<IPeopleRepository> _peopleRepository;
        public PeopleTests()
        {
            _peopleRepository = new Mock<IPeopleRepository>();
            _peopleService = new PeopleService(_peopleRepository.Object);
        }
        [Fact]
        public async Task BuscarPessoasSucesso()
        {
            _peopleRepository.Setup(p => p.GetPeoples(1))
                .ReturnsAsync(new API.Models.PeopleModels()
            {
                Count = 1,
                Next = null,
                Previous = null,
                Results = new List<API.Models.DataPeopleModels> { 
                    new API.Models.DataPeopleModels()
                    {
                        Name = "teste",

                    } 
                }
            });

            var results = await _peopleService.GetPeoples(1, null);


            Assert.Equal(1, results.Count);
        }
    }
}