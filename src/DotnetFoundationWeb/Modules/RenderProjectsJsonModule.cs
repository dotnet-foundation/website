using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using DotnetFoundationWeb.Models;
using Microsoft.Extensions.Logging;
using Statiq.Common;

namespace DotnetFoundationWeb.Modules
{
  public class RenderProjectsJsonModule : Module
  {
    private JsonSerializerOptions _options;

    public RenderProjectsJsonModule()
    {
    }

    public RenderProjectsJsonModule WithOptions(JsonSerializerOptions options)
    {
      _options = options ?? throw new ArgumentNullException(nameof(options));
      return this;
    }

    public RenderProjectsJsonModule WithOptions(Action<JsonSerializerOptions> modifyOptions)
    {
      modifyOptions?.Invoke(_options);
      return this;
    }

    protected override async Task<IEnumerable<IDocument>> ExecuteContextAsync(IExecutionContext context)
    {
      context.LogDebug("Processing RenderProjectsJsonModule for ", context.Inputs.Length, " files");

      var projects = new List<Project>();
      foreach (IDocument input in context.Inputs)
      {
        await AddJsonAsync(input);
      }
      var outputFileDirectory = Path.Combine(context.FileSystem.GetOutputPath().FullPath, "data");
      if (!Directory.Exists(outputFileDirectory))
      {
        Directory.CreateDirectory(outputFileDirectory);
      }
      var json = JsonSerializer.Serialize(projects);
      File.WriteAllText(Path.Combine(outputFileDirectory, "projects.json"), json);
      return context.CreateDocument(await context.GetContentProviderAsync(json, MediaTypes.Json)).Yield();

      async Task AddJsonAsync(IDocument input)
      {
        var content = await input.GetContentStringAsync();
        projects.Add(new Project
        {
          Title = GetValue("Title", content),
          Logo = GetValue("Logo", content, "logo_big.png"),
          Web = GetValue("Web", content, "#"),
          Keywords = GetValue("Keywords", content),
          Content = GetContent(content)
        });
      }
    }

    private string GetValue(string key, string content, string defaultValue = "")
    {
      using StringReader reader = new StringReader(content);
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        if (string.Equals(line, "---", StringComparison.OrdinalIgnoreCase))
        {
          return defaultValue;
        }
        if (line.ToUpper().StartsWith(key.ToUpper()))
        {
          var value = line.Substring(key.Length + 1).Trim();
          return string.IsNullOrEmpty(value) ? defaultValue : value;
        }
      }
      return defaultValue;
    }

    private string GetContent(string content)
    {
      return content.Substring(content.IndexOf("---") + 3).Trim();
    }
  }
}