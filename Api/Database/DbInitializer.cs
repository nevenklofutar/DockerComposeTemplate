using Api.Models;

namespace Api.Database
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            var context = serviceProvider.GetRequiredService<ApplicationContext>();

            if (context.People.Any())
            {
                return;
            }

            SeedPeople(context);
        }

        private static void SeedPeople(ApplicationContext context)
        {
            context.People.Add(new Person() { Id = 1, Firstname = "Neven", Lastname = "Klofutar" });
            context.People.Add(new Person() { Id = 2, Firstname = "Ana", Lastname = "Klofutar" });
            context.SaveChanges();
        }

    }
}
