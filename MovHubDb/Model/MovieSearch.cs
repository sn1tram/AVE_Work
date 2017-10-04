namespace MovHubDb.Model
{
    public class MovieSearch
    {
        public MovieSearchItem[] Results { get; set; }
        public int total_results { get; set; }
    }
}