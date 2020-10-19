namespace DotnetFoundationWeb
{
    /// <summary>
    /// Strongly-typed metadata keys used throughout the site.
    /// </summary>
    public static class SiteKeys
    {
        // Settings
        public const string AzureMapsSubscriptionKey = nameof(AzureMapsSubscriptionKey);

        // Speakers
        public const string Location = nameof(Location);  // Plain language location name
        public const string Lat = nameof(Lat);  // Fetched based on Location, but can be explicitly provided
        public const string Lon = nameof(Lon);  // Fetched based on Location, but can be explicitly provided
        public const string Topics = nameof(Topics);
        [SpeakerLink("fas fa-pencil-alt", false, false)]
        public const string Blog = nameof(Blog);
        [SpeakerLink(null, false, false)]
        public const string Feed = nameof(Feed);
        [SpeakerLink("fab fa-twitter", true, true, "https://twitter.com/[yourUsername]", "[Hh][Tt][Tt][Pp][Ss]:\\/\\/[Tt][Ww][Ii][Tt][Tt][Ee][Rr]\\.[Cc][Oo][Mm]\\/*")]
        public const string Twitter = nameof(Twitter);
        [SpeakerLink("fab fa-github", true, true, "https://github.com/[yourUsername]", "[Hh][Tt][Tt][Pp][Ss]:\\/\\/[Gg][Ii][Tt][Hh][Uu][Bb]\\.[Cc][Oo][Mm]\\/*")]
        public const string GitHub = nameof(GitHub);
        [SpeakerLink("fab fa-stack-overflow", true, true, "https://stackoverflow.com/users/[yourUserId]/[yourUsername]")]
        public const string StackOverflow = nameof(StackOverflow);
        [SpeakerLink("fab fa-linkedin", true, true, "https://linkedin.com/in/[yourUsername]")]
        public const string LinkedIn = nameof(LinkedIn);
        [SpeakerLink("fab fa-twitch", true, true, "https://twitch.tv/[yourUsername]")]
        public const string Twitch = nameof(Twitch);
        [SpeakerLink("fas fa-bullhorn", true, true, "https://sessionize.com/[yourUsername]")]
        public const string Sessionize = nameof(Sessionize);
        [SpeakerLink("fab fa-meetup", true, true, "https://www.meetup.com/members/[yourUserId]")]
        public const string MeetUp = nameof(MeetUp);
        [SpeakerLink("fab fa-youtube", true, true, "https://youtube.com/[yourUsername]")]
        public const string YouTube = nameof(YouTube);
        [SpeakerLink("fab fa-instagram", true, true, "https://instagram.com/[yourUsername]")]
        public const string Instagram = nameof(Instagram);
        [SpeakerLink("fab fa-dev", true, true, "https://dev.to/[yourUsername]/")]
        public const string Dev = nameof(Dev);
        public const string Email = nameof(Email);
        public const string Image = nameof(Image);  // Uses social profile image by default, but can be explicitly provided
        public const string Language = nameof(Language);
        public const string Mentor = nameof(Mentor);
        public const string Mentee = nameof(Mentee);
        public const string BlogFeedItems = nameof(BlogFeedItems);

        // Resources
        public const string Type = nameof(Type);

        // Projects
        public const string Web = nameof(Web);
        public const string Logo = nameof(Logo);
        public const string Keywords = nameof(Keywords);

        // Members
        public const string Advisor = nameof(Advisor);
        public const string Company = nameof(Company);
        public const string Intro = nameof(Intro);
        // Location
        // Image
        // Twitter

        // Committee
        public const string Chairperson = nameof(Chairperson);
        public const string Meets = nameof(Meets);
        public const string Repository = nameof(Repository);

        // Sponsors
        public const string Name = nameof(Name);
        public const string Url = nameof(Url);

        // Events
        public const string Date = nameof(Date);
        public const string Link = nameof(Link);

        // News
        public const string Source = nameof(Source);
        public const string Excerpt = nameof(Excerpt);
        // Link
        // Type

        // Presentation
        public const string Id = nameof(Id);
        public const string Repo = nameof(Repo);
        // Link

        // Directors
        public const string Elected = nameof(Elected);
    }
}
