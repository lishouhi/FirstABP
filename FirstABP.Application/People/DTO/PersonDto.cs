using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace FirstABP.People.DTO
{
    [AutoMapFrom(typeof(Person))] //AutoMapFrom attribute maps Person -> PersonDto
    public class PersonDto : EntityDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
