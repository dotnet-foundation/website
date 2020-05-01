using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DotnetFoundationWeb
{
  public static class AppSettings
  {
    public static string ContactEmail { get; set; } = ConfigurationManager.AppSettings["ContactEmail"];

    public static string Title { get; set; } = ConfigurationManager.AppSettings["SiteTitle"];

    public static string BaseRef { get; set; } = ConfigurationManager.AppSettings["BaseRef"];

    public static string ServerUri { get; set; } = ConfigurationManager.AppSettings["ServerUri"];

    public static bool IsCampaignOpen { get; set; }
      = String.Equals(ConfigurationManager.AppSettings["IsCampaignOpen"], "true", StringComparison.OrdinalIgnoreCase);

    public static string AzureSearchQueryKey { get; set; } = ConfigurationManager.AppSettings["AzureSearchQueryKey"];

    public static string ContributionsCounter { get; set; } = ConfigurationManager.AppSettings["ContributionsCounter"];

    public static string CompaniesCounter { get; set; } = ConfigurationManager.AppSettings["CompaniesCounter"];

    public static string ActiveProjectsCounter { get; set; } = ConfigurationManager.AppSettings["ActiveProjectsCounter"];

    public static string ResourcesCounter { get; set; } = ConfigurationManager.AppSettings["ResourcesCounter"];

    public static string GoogleAnalytics { get; set; } = ConfigurationManager.AppSettings["GoogleAnalytics"];

    public static string Lang { get; set; } = ConfigurationManager.AppSettings["Lang"];
  }
}
