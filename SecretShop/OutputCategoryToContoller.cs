namespace SecretShop
{
    public static class OutputCategoryToContoller
    {
        public static List<Plugin> sortedcategory = OutputCategory.SortedToCategory();
        public static List<Plugin> sortedprice = OutputCategory.SortedToPrice();
        public static List<Plugin> sortedrating = OutputCategory.SortedToRating();

        public static void test(out List<Plugin> plagins, out List<Plugin> plagins1, out List<Plugin> plagins2)
        {
            plagins = sortedcategory.ToList();
            plagins1 = sortedprice.ToList(); ;
            plagins2 = sortedrating.ToList(); ;
        }
    }
}
