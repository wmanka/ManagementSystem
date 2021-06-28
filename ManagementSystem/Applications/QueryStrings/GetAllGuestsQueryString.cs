namespace ManagementSystem.Applications.QueryStrings
{
    public class GetAllGuestsQueryString
    {
        public string Name { get; set; }

        public string City { get; set; }

        public GetAllGuestsQueryString(string name, string city)
        {
            Name = name;
            City = city;
        }
    }
}