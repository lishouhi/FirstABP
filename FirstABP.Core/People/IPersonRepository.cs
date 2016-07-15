using System;
using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace FirstABP.People
{
    public interface IPersonRepository : IRepository<Person,Int32>
    {
        List<Person> GetPersons();
    }
}
