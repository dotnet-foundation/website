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
        public const string Pronouns = nameof(Pronouns); // [subject]/[object] (I.e. "they/them")
        public const string Location = nameof(Location);  // Plain language location name
        public const string Lat = nameof(Lat);  // Fetched based on Location, but can be explicitly provided
        public const string Lon = nameof(Lon);  // Fetched based on Location, but can be explicitly provided
        public const string Topics = nameof(Topics);
        [SpeakerLink("fas fa-pencil-alt", false, false)]
        public const string Blog = nameof(Blog);
        [SpeakerLink(null, false, false)]
        public const string Feed = nameof(Feed);
        // Regex pattern test: https://regex101.com/r/LsRovM/1
        [SpeakerLink("fab fa-twitter", true, true, "https://twitter.com/[yourUsername]", "[Hh][Tt][Tt][Pp][Ss]:\\/\\/([Ww][Ww][Ww].)?[Tt][Ww][Ii][Tt][Tt][Ee][Rr]\\.[Cc][Oo][Mm]\\/.*")]
        public const string Twitter = nameof(Twitter);
        // Regex pattern test: https://regex101.com/r/FICmFg/1
        [SpeakerLink("fab fa-github", true, true, "https://github.com/[yourUsername]", "[Hh][Tt][Tt][Pp][Ss]:\\/\\/([Ww][Ww][Ww].)?[Gg][Ii][Tt][Hh][Uu][Bb]\\.[Cc][Oo][Mm]\\/.*")]
        public const string GitHub = nameof(GitHub);
        // Regex pattern test: https://regex101.com/r/0OHcSZ/1
        [SpeakerLink("fab fa-stack-overflow", true, true, "https://stackoverflow.com/users/[yourUserId]/[yourUsername]", "[Hh][Tt][Tt][Pp][Ss]:\\/\\/([Ww][Ww][Ww].)?[Ss][Tt][Aa][Cc][Kk][Oo][Vv][Ee][Rr][Ff][Ll][Oo][Ww]\\.[Cc][Oo][Mm]\\/[Uu][Ss][Ee][Rr][Ss]\\/\\d+\\/.*")]
        public const string StackOverflow = nameof(StackOverflow);
        // Regex pattern test: https://regex101.com/r/IlrLEM/1
        [SpeakerLink("fab fa-linkedin", true, true, "https://linkedin.com/in/[yourUsername]", "[Hh][Tt][Tt][Pp][Ss]:\\/\\/([Ww][Ww][Ww].)?[Ll][Ii][Nn][Kk][Ee][Dd][Ii][Nn]\\.[Cc][Oo][Mm]\\/[Ii][Nn]\\/.*")]
        public const string LinkedIn = nameof(LinkedIn);
        // Regex pattern test: https://regex101.com/r/D1Kxdu/1
        [SpeakerLink("fab fa-twitch", true, true, "https://twitch.tv/[yourUsername]", "[Hh][Tt][Tt][Pp][Ss]:\\/\\/([Ww][Ww][Ww].)?[Tt][Ww][Ii][Tt][Cc][Hh]\\.[Tt][Vv]\\/.*")]
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
        public const string Images = nameof(Images);  // Uses social profile image by default, but can be explicitly provided
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
