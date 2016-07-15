using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace FirstABP.People.DTO
{
    public class GetAllPeopleOutput : IOutputDto
    {
        public List<PersonDto> People { get; set; }
    }
}
