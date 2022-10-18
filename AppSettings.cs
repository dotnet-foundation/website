using System;
using System.Configuration;

namespace DotnetFoundationWeb
{
    public static class AppSettings
    {
        public static string ContactEmail { get; set; } = ConfigurationManager.AppSettings["ContactEmail"];

        public static string Title { get; set; } = ConfigurationManager.AppSettings["SiteTitle"];

        public static string Description { get; set; } = ConfigurationManager.AppSettings["SiteDescription"];

        public static string BaseRef { get; set; } = ConfigurationManager.AppSettings["BaseRef"];

        public static string ServerUrl { get; set; } = ConfigurationManager.AppSettings["ServerUrl"];

        public static bool IsCampaignOpen { get; set; }
          = string.Equals(ConfigurationManager.AppSettings["IsCampaignOpen"], "true", StringComparison.OrdinalIgnoreCase);

        public static bool ShowCampaignResults { get; set; }
          = string.Equals(ConfigurationManager.AppSettings["ShowCampaignResults"], "true", StringComparison.OrdinalIgnoreCase);

        public static string AzureSearchQueryKey { get; set; } = ConfigurationManager.AppSettings["AzureSearchQueryKey"];

        public static int ContributionsCounter { get; set; } = int.Parse(ConfigurationManager.AppSettings["ContributionsCounter"]);

        public static int CompaniesCounter { get; set; } = int.Parse(ConfigurationManager.AppSettings["CompaniesCounter"]);

        public static int ActiveProjectsCounter { get; set; } = int.Parse(ConfigurationManager.AppSettings["ActiveProjectsCounter"]);

        public static int ResourcesCounter { get; set; } = int.Parse(ConfigurationManager.AppSettings["ResourcesCounter"]);

        public static string GoogleAnalytics { get; set; } = ConfigurationManager.AppSettings["GoogleAnalytics"];

        public static string Lang { get; set; } = ConfigurationManager.AppSettings["Lang"];

        public static bool SuppressSpeakers { get; set; }
          = string.Equals(ConfigurationManager.AppSettings["SuppressSpeakers"], "true", StringComparison.OrdinalIgnoreCase);

        public static bool SuppressProjects { get; set; }
          = string.Equals(ConfigurationManager.AppSettings["SuppressProjects"], "true", StringComparison.OrdinalIgnoreCase);

    }
}
