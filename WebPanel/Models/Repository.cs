namespace WebPanel.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponses(GuestResponse response)
        {
            responses.Add(response);
        }

    }
}
