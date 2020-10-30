using System.ComponentModel.DataAnnotations;

namespace EmporiumServer.Controllers
{
    public class Costume
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberInStock { get; set; }
        public decimal Price { get; set; }
        public string Theme { get; set; }
    }
}