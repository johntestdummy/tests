namespace SocialManagerLibrary.Entities.Tw
{
    public class Status
{
    public string CreatedAt { get; set; }
    public object Id { get; set; }
    public string IdStr { get; set; }
    public string Text { get; set; }
    public bool Truncated { get; set; }
    public Entities Entities { get; set; }
    public Metadata Metadata { get; set; }
    public string Source { get; set; }
    public long? InReplyToStatusId { get; set; }
    public string InReplyToStatusIdStr { get; set; }
    public long? InReplyToUserId { get; set; }
    public string InReplyToUserIdStr { get; set; }
    public string InReplyToScreenName { get; set; }
    public User User { get; set; }
    public object Geo { get; set; }
    public object Coordinates { get; set; }
    public object Place { get; set; }
    public object Contributors { get; set; }
    public bool IsQuoteStatus { get; set; }
    public int RetweetCount { get; set; }
    public int FavoriteCount { get; set; }
    public bool Favorited { get; set; }
    public bool Retweeted { get; set; }
    public string Lang { get; set; }
    public ExtendedEntities ExtendedEntities { get; set; }
    public bool? PossiblySensitive { get; set; }
    public RetweetedStatus RetweetedStatus { get; set; }
}
}
