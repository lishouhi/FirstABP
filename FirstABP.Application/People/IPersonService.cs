using Abp.Application.Services;
using FirstABP.People.DTO;

namespace FirstABP.People
{
    public interface IPersonService : IApplicationService
    {
        GetAllPeopleOutput GetPersons();
    }
}
