using EmporiumServer.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace EmporiumServer.DAO
{
    public class InMemoryCostumeDao : ICostumeDao
    {
        private readonly IList<Costume> costumes = new List<Costume>();

        public InMemoryCostumeDao()
        {
            costumes.Add(new Costume { Id = 1, Name = "Ladybug", NumberInStock = 12, Price = 35.5M, Theme = "Bugs / Defects" });
            costumes.Add(new Costume { Id = 2, Name = "Software Engineer at a Conference", NumberInStock = 1, Price = 25M, Theme = "Fashionless" });
            costumes.Add(new Costume { Id = 3, Name = "Alexander Hamilton", NumberInStock = 5, Price = 5M, Theme = "Historical" });
            costumes.Add(new Costume { Id = 4, Name = "Darth Vader", NumberInStock = 0, Price = 180M, Theme = "People Prepared for COVID-19" });
            costumes.Add(new Costume { Id = 5, Name = "The Doctor", NumberInStock = 11, Price = 42M, Theme = "Historical" });
        }

        public Costume Create(Costume costume)
        {
            // Max returns the maximum value it sees for a property (the Id property here) in the collection
            int nextId = costumes.Max(costume => costume.Id) + 1;

            costume.Id = nextId;
            this.costumes.Add(costume);

            return costume;
        }

        public void Delete(int id)
        {
            // Note: First will throw an exception if no item was found that matches it. FirstOrDefault returns null instead.
            Costume costume = this.costumes.First(costume => costume.Id == id);

            costumes.Remove(costume);
        }

        public Costume[] GetAllCostumes()
        {
            return this.costumes.ToArray();
        }

        public Costume GetCostume(int id)
        {
            // Will return the first match, or null if no item matches
            return this.costumes.FirstOrDefault(costume => costume.Id == id);
        }

        public Costume Update(Costume costume)
        {
            this.Delete(costume.Id);
            return this.Create(costume);
        }
    }
}
