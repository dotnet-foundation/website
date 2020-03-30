using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DotNetFoundation
{
  public static class AppSettings
  {
    public static string Title { get; set; } = ConfigurationManager.AppSettings["SiteTitle"];

    public static string BaseRef { get; set; } = ConfigurationManager.AppSettings["BaseRef"];

    public static bool IsCampaignOpen { get; set; }
      = String.Equals(ConfigurationManager.AppSettings["IsCampaingOpen"], "true", StringComparison.OrdinalIgnoreCase);

    public static string AzureSearchQueryKey { get; set; } = ConfigurationManager.AppSettings["AzureSearchQueryKey"];

    public static string ContributorsCounter { get; set; } = ConfigurationManager.AppSettings["ContributorsCounter"];

    public static string GithubOrgsCounter { get; set; } = ConfigurationManager.AppSettings["GithubOrgsCounter"];

    public static string RepositoriesCounter { get; set; } = ConfigurationManager.AppSettings["RepositoriesCounter"];

    public static string ForksCounter { get; set; } = ConfigurationManager.AppSettings["ForksCounter"];

    public static string GoogleAnalytics { get; set; } = ConfigurationManager.AppSettings["GoogleAnalytics"];

    public static string Lang { get; set; } = ConfigurationManager.AppSettings["Lang"];
  }
}
