namespace SocialManagerLibrary.Entities.Twitter
{
    public class User
    {
        public int Id { get; set; }
        public string IdStr { get; set; }
        public string Name { get; set; }
        public string ScreenName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public Entities Entities { get; set; }
        public bool Protected { get; set; }
        public int FollowersCount { get; set; }
        public int FriendsCount { get; set; }
        public int ListedCount { get; set; }
        public string CreatedAt { get; set; }
        public int FavouritesCount { get; set; }
        public int UtcOffset { get; set; }
        public string TimeZone { get; set; }
        public bool GeoEnabled { get; set; }
        public bool Verified { get; set; }
        public int StatusesCount { get; set; }
        public string Lang { get; set; }
        public bool ContributorsEnabled { get; set; }
        public bool IsTranslator { get; set; }
        public bool IsTranslationEnabled { get; set; }
        public string ProfileBackgroundColor { get; set; }
        public string ProfileBackgroundImageUrl { get; set; }
        public string ProfileBackgroundImageUrlHttps { get; set; }
        public bool ProfileBackgroundTile { get; set; }
        public string ProfileImageUrl { get; set; }
        public string ProfileImageUrlHttps { get; set; }
        public string ProfileBannerUrl { get; set; }
        public string ProfileLinkColor { get; set; }
        public string ProfileSidebarBorderColor { get; set; }
        public string ProfileSidebarFillColor { get; set; }
        public string ProfileTextColor { get; set; }
        public bool ProfileUseBackgroundImage { get; set; }
        public bool HasExtendedProfile { get; set; }
        public bool DefaultProfile { get; set; }
        public bool DefaultProfileImage { get; set; }
        public object Following { get; set; }
        public object FollowRequestSent { get; set; }
        public object Notifications { get; set; }
        public string TranslatorType { get; set; }
    }

}
