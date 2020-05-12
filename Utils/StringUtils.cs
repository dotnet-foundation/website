using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HtmlAgilityPack;

namespace DotnetFoundationWeb.Utils
{
  public static class StringUtils
  {
    public static IEnumerable<HtmlNode> Descendants(HtmlNode root)
    {
      return new[] { root }.Concat(root.ChildNodes.SelectMany(child => child.Descendants()));
    }

    public static IEnumerable<HtmlNode> TextDescendants(HtmlNode root)
    {
      return root.Descendants().Where(n => n.NodeType == HtmlNodeType.Text && !String.IsNullOrWhiteSpace(n.InnerText));
    }

    public static string TruncateHtml(string html, int maxCharacters)
    {
      html = html.Replace("<p>", "").Replace("</p>", "");
      if (string.IsNullOrEmpty(html) || html.Length <= maxCharacters) return html;

      var doc = new HtmlDocument();
      doc.LoadHtml(html);
      if (doc.DocumentNode.InnerText.Length <= maxCharacters) return html;

      var textNodes = new LinkedList<HtmlNode>(TextDescendants(doc.DocumentNode));
      var preceedingText = 0;
      var lastNode = textNodes.First;
      while (preceedingText <= maxCharacters && lastNode != null)
      {
        var nodeTextLength = lastNode.Value.InnerText.Length;
        if (preceedingText + nodeTextLength > maxCharacters)
        {
          var truncatedText = TruncateWords(lastNode.Value.InnerText, maxCharacters - preceedingText);

          if (String.IsNullOrWhiteSpace(truncatedText) && lastNode.Previous != null)
          {
            // Put the ellipsis in the previous node and remove the empty node.
            lastNode.Previous.Value.InnerHtml = lastNode.Previous.Value.InnerText.Trim() + "&hellip;";
            lastNode.Value.InnerHtml = String.Empty;
            lastNode = lastNode.Previous;
          }
          else
          {
            lastNode.Value.InnerHtml = truncatedText + "&hellip;";
          }

          break;
        }

        if (preceedingText + nodeTextLength == maxCharacters) break;

        preceedingText += nodeTextLength;
        lastNode = lastNode.Next;
      }

      // Remove all the nodes after lastNode
      if (lastNode != null) RemoveFollowingNodes(lastNode.Value);

      return doc.DocumentNode.InnerHtml;
    }

    private static void RemoveFollowingNodes(HtmlNode lastNode)
    {
      while (lastNode.NextSibling != null) lastNode.NextSibling.Remove();
      if (lastNode.ParentNode != null) RemoveFollowingNodes(lastNode.ParentNode);
    }

    private static string TruncateWords(string value, int length)
    {
      if (String.IsNullOrWhiteSpace(value) || length <= 0) return String.Empty;
      if (length > value.Length) return value;

      var endIndex = length;
      while (Char.IsLetterOrDigit(value[endIndex - 1]) && Char.IsLetterOrDigit(value[endIndex]) && endIndex > 1) endIndex--;

      if (endIndex == 1) return String.Empty;
      return value.Substring(0, endIndex).Trim();
    }
  }
}
