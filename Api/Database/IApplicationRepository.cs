using Api.Models;

namespace Api.Database
{
    public interface IApplicationRepository
    {
        IEnumerable<Person> GetAllPeople();
        Person? GetPersonById(int personId);
    }
}
