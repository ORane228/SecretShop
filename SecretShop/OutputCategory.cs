using System.Security.Claims;

namespace SecretShop
{
    public static class OutputCategory
    {

        static List<Plugin> TotalPlugin = Bd.GetData();

        public static List<Plugin> SortedToPrice()
        {
            List<Plugin> sorted = (from i in TotalPlugin
                                  orderby i.Price
                                  select i).ToList();
            return sorted;
        }

        public static List<Plugin> SortedToCategory()
        {
            List<Plugin> list = new List<Plugin>();
            for (int i = 0; i < TotalPlugin.Count; i++)
            {
                if (TotalPlugin[i].Category == "Graphic")
                {
                    list.Add(TotalPlugin[i]);
                }
            }
            return list;

        }

        public static List<Plugin> SortedToRating()
        {
            List<Plugin> sorted = (from i in TotalPlugin
                                   orderby i.Rating descending
                                   select i).ToList();
            return sorted;


        }



    }
    

}
