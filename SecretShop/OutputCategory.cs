using System.Security.Claims;

namespace SecretShop
{
    public class OutputCategoryModel
    {
        public string Status { get; set; }
        public Dictionary<string, List<Plugin>> SortedPlugins { get; set; } = new Dictionary<string, List<Plugin>>();
        public List<Plugin> TotalPlugin { get; set; } = new List<Plugin>
        {
            new Plugin
            {
                Author = "W",
                Category = "Graphic",
                Description = "2",
                Id = 1,
                Image = "",
                Name = "plug2",
                PathToFile = "",
                Price = 100,
                Rating = 2,
                ReleaseDate = DateTime.Now.AddDays(2),
            },
            new Plugin
            {
                Author = "W",
                Category = "1",
                Description = "1",
                Id = 1,
                Image = "",
                Name = "plug1",
                PathToFile = "",
                Price = 200,
                Rating = 3,
                ReleaseDate = DateTime.Now.AddDays(4),
            },
            new Plugin
            {
                Author = "W",
                Category = "3",
                Description = "3",
                Id = 3,
                Image = "",
                Name = "plug3",
                PathToFile = "",
                Price = 300,
                Rating = 5,
                ReleaseDate = DateTime.Now,
            },
        };

        public OutputCategoryModel()
        {
            Status = "Ok";
            try
            {
                SortedPlugins.Add("Price", SortedToPrice());
                SortedPlugins.Add("Category", SortedToCategory());
                SortedPlugins.Add("Rating", SortedToRating());
            }
            catch(Exception ex)
            {
                Status = $"ERROR: {ex.Message}";
            }
        }
        private List<Plugin> SortedToPrice() => (from i in TotalPlugin orderby i.Price select i).ToList();

        private List<Plugin> SortedToCategory() => (from i in TotalPlugin where i.Category == "Graphic" select i).ToList();

        private List<Plugin> SortedToRating() => (from i in TotalPlugin orderby i.Rating descending select i).ToList();

        
    }


}
