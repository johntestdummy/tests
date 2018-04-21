namespace SocialManagerLibrary.Entities.Twitter
{
    public class SearchMetadata
    {
        public double CompletedIn { get; set; }
        public int MaxId { get; set; }
        public string MaxIdStr { get; set; }
        public string NextResults { get; set; }
        public string Query { get; set; }
        public int Count { get; set; }
        public int SinceId { get; set; }
        public string SinceIdStr { get; set; }
    }

}
