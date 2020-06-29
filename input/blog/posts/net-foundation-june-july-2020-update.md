---
Title: .NET Foundation June/July 2020 Update
Author: Claire Novotny
Published: 2020-06-17
Slug: net-foundation-june-july-2020-update
---
Here's the June/July 2020 .NET Foundation update. Every other month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.

## General news

### Board Elections Update
We are preparing for our next set of Board elections and some changes are being made to the way we conduct these elections. Namely, a Nominating Committee will solicit and accept candidate applications and vet potential candidates that will then be voted on by members. Additionally, we will begin term staggering of Board members to enhance the continuity of the organization. Please see the [election page on our website](https://dotnetfoundation.org/about/election) for more [details and information on how you can submit your nomination](https://dotnetfoundation.org/about/election/campaign)! Nominations are open now and will close on June 26th. The slate of candidates will be announced on July 7th, beginning a two week campaign period. Elections follow for two weeks using the [same system](https://www.opavote.com/methods/single-transferable-vote) as last year.

## Committee Updates

### Outreach

This month the outreach group hosted its first [remote meetup](https://www.meetup.com/dotnet-virtual-user-group/events/270931523/) as part of the [.NET Virtual Meetup group](https://www.meetup.com/dotnet-virtual-user-group/). 

The .NET Foundation has been working on a new initiative to help .NET user groups go virtual with the new [.NET Virtual User Group](https://www.meetup.com/dotnet-virtual-user-group/) program! Let the .NET Foundation take care of all of the streaming so you can focus in on making your meetup awesome and enable developers around the world join in. [Submit your user group session](https://github.com/dotnet-foundation/wg-outreach/issues/new/choose), get scheduled, get promoted, and have your user group. It is a great way to engage with the broader .NET community and keep your user group going during while we are all inside.

If you are looking for awesome upcoming user group sessions from around the world? Then join the [.NET Virtual User Group today!](https://www.meetup.com/dotnet-virtual-user-group/)

Our next meeting is Tuesday, 6/16 at 3pEST/12pPST, more information will be sent via email. 

### Marketing

Check out what we're up to by visiting the [wg-marketing](https://github.com/dotnet-foundation/wg-marketing) repo.

#### Member resources
We'd like to make our members aware of some marketing resources you can take advantage of.

- *Help spread .NET Foundation's message*: Take a look at the [.NET Foundation slides](https://dotnetfoundation.sharepoint.com/:p:/s/Marketing/EbxGONyybLRMoe6MgPNUEi4BdDuEWNLmdfV_s8INO9nWTw?e=mImEov) and use them in your presentations and events.
- *Promote your .NET open source content, events, project news*: If you'd like to promote something on the .NET Foundation social channels, fill out the [amplification request issue template on our content repo](https://github.com/dotnet-foundation/content/issues/new?assignees=&labels=&template=content-amplification-request.md&title=%5BAMPLIFICATION%5D+-+Title) and we'll get you scheduled.
- *Write a guest blog post or submit a video to our YouTube*: If you would like to propose creating content like a guest blog post or video, fill out the [content creation request issue template on our content repo](https://github.com/dotnet-foundation/content/issues/new?assignees=&labels=&template=content-creation-request.md&title=%5BCREATION%5D+-+Title) and we'll work with you on getting your content created.

#### .NET branding guidelines
Microsoft released updated .NET branding guidelines on GitHub [github.com/dotnet/brand](https://github.com/dotnet/brand). The purpose of these guidelines is to provide a framework for communicating with the .NET developer community and establishing a consistent brand identity. This not only includes the logo & typeface but also consistent messaging, terminology, fun illustrations and presentation templates you can use. 

## Events

### Session recordings for JetBrains .NET Days Online 2020

JetBrains .NET Days Online 2020 is a free virtual event that took place on May 13–14, 2020. We invited 12 community speakers to talk about the topics they are passionate about: from C# and F# to coding practices like refactoring, web, cloud, GraphQL, and even setting up a blog!

The [video recordings are ready to watch](https://pages.jetbrains.com/dotnet-days-2020/dnf)!

### .NET session recordings from Build 2020

Build 2020 was May 19-21 and the first time the event was all digital. The .NET team had some exciting announcements and presented the following sessions that you can view on-demand.
- [Journey to one .NET](https://www.youtube.com/watch?v=ctSqiD8BGPM)
- [C# Today and Tomorrow](https://www.youtube.com/watch?v=vHY6Cv6qtLY)
- [Modern Web UI with Blazor WebAssembly](https://www.youtube.com/watch?v=My_XOzQWwc4)
- [Build Native Apps for any Device with .NET](https://www.youtube.com/watch?v=rsO458GwLFg)
- [Cloud Native Apps with .NET and Azure Kubernetes Service (AKS)](https://www.youtube.com/watch?v=HzQgIng_DNE)

And many more from Build are available [here](https://channel9.msdn.com/Events/Build/2020). Also check out the [dotnet-presentations/build](https://github.com/dotnet-presentations/Build/tree/master/2020) repo for decks & resources from the .NET sessions. 

### .NET Conf 2020 dates announced: November 10-12!
.NET Conf is a free, three day virtual developer event co-organized by the .NET community and Microsoft. This year .NET 5.0 will launch at .NET Conf 2020! See the website for more information and save the date! [www.dotnetconf.net](https://www.dotnetconf.net)

We're also planning our next .NET Conf: "Focus" event, where we continue focusing on specific .NET topics. July 30 we will present a full day of sessions for *.NET Conf: Focus on Microservices* with some very special guests! Learn more: [focus.dotnetconf.net](https://focus.dotnetconf.net)

## .NET Foundation Project Updates

### [ASP.NET AJAX Control Toolkit v20.1.0 - Now Available](https://community.devexpress.com/blogs/aspnet/archive/2020/06/10/asp-net-ajax-control-toolkit-v20-1-0-now-available.aspx)

A few years ago, we took over maintenance and guidance for the ASP.NET AJAX Control Toolkit project. Please refer to this [blog post](https://community.devexpress.com/blogs/aspnet/archive/2014/09/22/ajax-control-toolkit-devexpress-offer.aspx) for more information on the project and why we stepped in to assist.

![DevExpress - ASP.NET AJAX Control Toolkit](https://community.devexpress.com/blogs/aspnet/ACT/Aspnet-AJAX-Controls-Toolkit-blog.png).

As part of our ongoing commitment to the project, we’ve released an update ([ASP.NET AJAX Control Toolkit v20.1.0](https://devexpress.com/act)) to address the following issues.

#### Resolved Issues

- `CascadingDropDown` continuously refreshes in Firefox 65 ([#477](https://github.com/DevExpress/AjaxControlToolkit/issues/477))
- `MaskedEditExtender` with `ClearMaskOnLostFocus=False` adds an extra character at the first position ([#493](https://github.com/DevExpress/AjaxControlToolkit/issues/493))
- `ListSearchExtender` does not work in Firefox 66+ ([#494](https://github.com/DevExpress/AjaxControlToolkit/issues/494), contributed by [**@TheUlderico**](https://github.com/TheUlderico))
- `AjaxFileUpload` fails with `<sessionState cookieless="UseUri">` ([#500](https://github.com/DevExpress/AjaxControlToolkit/issues/500))
- `ReorderList` adds the `opacity` CSS property to the `<LI>` element ([#503](https://github.com/DevExpress/AjaxControlToolkit/issues/503))
- `SCRIPT1028` error in legacy IE ([#515](https://github.com/DevExpress/AjaxControlToolkit/issues/515), contributed by [**@SIkebe**](https://github.com/SIkebe))
- `Tabs` control doesn't preserve the active tab when it contains a `LinkButton` with a validator ([#518](https://github.com/DevExpress/AjaxControlToolkit/issues/518))
- `DragPanelExtender` - JavaScript errors in IE 11 with non-100% zoom ([#522](https://github.com/DevExpress/AjaxControlToolkit/issues/522))
- The `onchange` handler on a `TextBox` with `AutoComplete` is triggered twice in Google Chrome ([#529](https://github.com/DevExpress/AjaxControlToolkit/issues/529))
- `HtmlEditorExtender.Decode` - Remove insecure HTML ([#532](https://github.com/DevExpress/AjaxControlToolkit/issues/532))

#### Ready to Upgrade?

To update the ASP.NET AJAX Control Toolkit, please download our most recent installer using the link below.

<a href="https://go.devexpress.com/AjaxControlToolkit_Website_Download.aspx" class="Button Gray" target="_blank">Download</a>

Or, if you prefer, use Nuget:

<a href="http://www.nuget.org/packages/AjaxControlToolkit/" target="_blank">ASP.NET AJAX Control Toolkit Nuget package</a>

As always, we welcome your feedback. Please share your thoughts on this update via [GitHub](https://github.com/DevExpress/AjaxControlToolkit/issues).


## New Projects

The .NET Foundation would like to welcome the following projects that joined in June and July!

|  |  |
| ------------------- |--------------------|
| <img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png" width="750px"> | **ResX Resource Manager**  The most popular tool to localize and manage all kind of applications with resx-based resources.  Shows all resources of a solution and let's you edit the strings and their localizations in a well-arranged data grid.|
| <img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png" width="750px"> | **P/Invoke**  A collection of libraries intended to contain all P/Invoke method signatures for popular operating systems. Think of it as https://pinvoke.net, but proven to compile and work properly, and often with sample usage in the form of unit tests.

Each library is exposed as its own NuGet package, and may include .NET Portable libraries as applicable, exposing those APIs that are available only on Desktop, or Store, or both as appropriate.|
## Meetups

### Looking for speakers to go deep on AWS?

Would your user group \ meetup appreciate hearing about .NET on AWS from an AWS .NET developer advocate? The team of longtime .NET developers would be thrilled to join your virtual user group to chat about the latest for .NET in the cloud. 

Here’s a list of example topics:
- **Overview of .NET on AWS:** AWS has over a decade supporting .NET on the cloud. We’ll provide an overview of all the support you might not know existed, such as free tools for Visual Studio, PowerShell, Azure DevOps, etc.
- **Building serverless with .NET:** The future is now for serverless, and AWS is ensuring .NET is vibrant in that future. We’ll show you how anybody can get started and take advantage of the speed and ease of using serverless with .NET.
- **Infrastructure as .NET:** Why learn JSON or YAML to build on the cloud if you can just use .NET? Learn how to model and provision cloud resources in .NET with the open source AWS Cloud Development Kit (CDK)
- **PowerShell on AWS:** AWS supports PowerShell and makes it easy to manage your AWS resources in a PowerShell scripting environment. We’ll show you all the things you can easily do on AWS with PowerShell, including native support for serverless. 
- **Something else?** What are you interested in hear about? Blazor? ML? Reach out and let us know.

You can contact the .NET developer advocacy team at **[aws-dotnetfdn-interest-open@amazon.com](mailto://aws-dotnetfdn-interest-open@amazon.com)**. Cheers!

### Sponsored Meetups
**Our .NET Foundation sponsored [.NET Meetup Pro groups](https://www.meetup.com/pro/dotnet) are continuing to grow worldwide.** Here are some quick stats:*
* 355 Groups
* 62 Countries
*	290K Members

Our .NET Meetup Pro group helps developers find your group, as well as get involved with local events like .NET Conf Local. If your meetup hasn't joined yet, you can [right here](https://aka.ms/add-dotnet-meetup).

![Map of meetup group locations](https://user-images.githubusercontent.com/1427284/74241694-64015800-4c91-11ea-9431-736bc05717a0.png)
