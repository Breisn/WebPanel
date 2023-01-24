namespace WebPanel.Models
{
    public class Store
    {
        public static List<Rechner> stores = new List<Rechner>();
        public static IEnumerable<Rechner> Stores => stores;

        public static void AddStore(Rechner RechnerStore)
        {
            stores.Add(RechnerStore);
        }

    }
}
