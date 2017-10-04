namespace MovHubDb.Model
{
    public struct Movie
    {
        public int Id { get; set; }
        public string Original_Title { get; set; }
        //private string Credits { get; set; }
        public double popularity { get; set; }
        public double Vote_Average { get; set; }
        public string Release_Date { get; set; }
        public string Overview { get; set; }

    }
}