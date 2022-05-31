using Api.Models;

namespace Api.Database
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationContext context;

        public ApplicationRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Person> GetAllPeople()
        { 
            var result = context.People.ToList();
            return result;
        }

        public Person? GetPersonById(int personId)
        { 
            var result = context.People.FirstOrDefault(x => x.Id == personId);
            return result;
        }
    }
}
