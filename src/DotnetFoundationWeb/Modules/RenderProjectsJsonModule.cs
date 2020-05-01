using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using DotnetFoundationWeb.Models;
using DotnetFoundationWeb.Utils;
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
      var json = JsonSerializer.Serialize(projects);
      return context.CreateDocument(await context.GetContentProviderAsync(json, MediaTypes.Json)).Yield();

      async Task AddJsonAsync(IDocument input)
      {
        var content = await input.GetContentStringAsync();
        projects.Add(new Project
        {
          Title = StringUtils.GetDocValue("Title", content),
          Logo = StringUtils.GetDocValue("Logo", content, "logo_big.png"),
          Web = StringUtils.GetDocValue("Web", content, "#"),
          Keywords = StringUtils.GetDocValue("Keywords", content),
          Content = StringUtils.GetDocContent(content)
        });
      }
    }
  }
}
