---
Title: .NET Foundation January/February 2021 Update
Author: Claire Novotny
Published: 2021-02-24
Slug: net-foundation-january-february-2021-update
---
Welcome to the .NET Foundation update for January & February. Every other month, we'll give you a quick overview of the .NET open source landscape and what the .NET Foundation is up to, including top project news, events, community links and more.

[Sign up for the newsletter](http://eepurl.com/dhL_qb) and get these updates delivered right to your inbox.

## General news

### Welcome Uno Platform as Corporate Sponsor!
<img src="https://user-images.githubusercontent.com/1427284/108915602-20a72c80-75fb-11eb-84a8-fca516cdecf1.jpg" height="143" width="250" alt="Uno-heart-dotnet-foundation_cover" />

The .NET Foundation is thrilled to announce that [Uno Platform](http://www.platform.uno/) has joined as a corporate sponsor! Uno Platform is an open source project which lets you build single-codebase applications with C# and WinUI for Windows, WebAssembly, Linux, macOS, iOS and Android. Uno Platform joins the group of corporations that are helping drive the future of the .NET platform and ecosystem and we are incredibly grateful for their support. The .NET Foundation relies on sponsors to fund our mission to create a thriving .NET open source ecosystem. Thank you, Uno Platform for being part of this effort. [Read Uno Platform sponsorship announcement](https://platform.uno/blog/uno-platform-sponsors-net-foundation). 


### [Please take the "State of .NET" survey](https://dotnetfoundation.org/about/survey?utm_source=dotnetfdn&utm_medium=newsletter)
In November we launched a "State of .NET" survey and we're encouraging everyone in the .NET community to participate. Your feedback is very important to the .NET Foundation. It will help us understand our community needs better and prioritize the work that we do. The survey will stay open until March 31, 2021 after which the results will be made public. If you complete the survey you can enter to win a $250 gift certificate (multiple winners). Please visit [our survey page](https://dotnetfoundation.org/about/survey?utm_source=dotnetfdn&utm_medium=newsletter) and thank you to everyone that has completed it already.

[![Take our Survey](https://user-images.githubusercontent.com/5115571/100258223-a97ad300-2efb-11eb-9f57-2b5bc55055b8.png)](https://dotnetfoundation.org/about/survey?utm_source=dotnetfdn&utm_medium=newsletter)

### [.NET Foundation Speaker Directory](https://dotnetfoundation.org/community/speakers)
As part of the .NET Foundation's goals to help broaden the appeal of .NET, [we're proud to announce](https://dotnetfoundation.org/blog/2021/02/19/blog/posts/announcing-the-dot-net-foundation-speakers-directory) the launch of the .NET Foundation [speaker directory](https://dotnetfoundation.org/community/speakers). The goal of the directory is to help people discover and encourage speakers from around the world as well as to provide mentors for new speakers. If you're looking for a speaker for your upcoming user group or event, you can find speakers that match your needs.

## .NET Foundation Project Updates

### [Project Spotlight - DotVVM](https://dotnetfoundation.org/projects/spotlight)

Each month Project Spotlight shines a light on an interesting open source project and its maintainers. In this iteration, .NET Foundation Marketing Committee member, Isaac Levin, speaks with Maintainer of the DotVVM prject, Tomáš Herceg, to talk about his project.

DotVVM is an open-source framework that allows building ASP.NET apps using the MVVM approach with just C# and HTML. The framework is integrated in the ASP.NET ecosystem, ships with an extension for Visual Studio, and can be also used for modernizing old ASP.NET applications as it supports both OWIN and ASP.NET Core.

### New Releases
### [CoreWCF 0.1.0 GA Release](https://corewcf.github.io/blog/2021/02/19/corewcf-ga-release)
After 21 months of public development, CoreWCF has reached its first GA release. Thank you to key contributors from Microsoft and AWS for making the project a success and getting our first release out the door. There were a lot of fundamental changes involved in building WCF on top of ASP.NET Core but we focued on delivering a great developer experience. This is a significant milestone towards supporting enterprise WCF services moving to CoreWCF hosted on any cloud platform. Read more about the release on the [CoreWCF blog](https://corewcf.github.io/blog/2021/02/19/corewcf-ga-release). 

### [NUnit](https://nunit.org)
Many new releases are out at once, and work is starting on future major versions. In addition to the notes below, the .NET Core Console remains in beta ([release 3.12.0-beta2](https://github.com/nunit/nunit-console/releases/tag/v3.12.0-beta2)) due to some unresolved dependency loading and framework targeting issues. Contributions to fix these issues would be very welcome.

#### [NUnit Framework 3.13](https://github.com/nunit/nunit/releases/tag/v3.13) and [3.13.1](https://github.com/nunit/nunit/releases/tag/v3.13.1)
3.13 ships the first C# 8 Nullable Reference Types annotations. Almost all areas have been annotated. There are some important things to call out about this:

- `Assert` methods don't always throw exceptions when the assertion fails, due to the [Multiple Asserts](https://docs.nunit.org/articles/nunit/writing-tests/assertions/multiple-asserts.html) feature. Starting in version 3.6, `Assert.NotNull(obj)` no longer meant that `obj` would never be null on the following line. `Assert.Catch` and the other `Assert` methods are the same way. The nullability annotations added in 3.13 reflect this existing reality. We decided to only add nullability annotations that were accurate in every circumstance—a philosophy consistent with how .NET itself is annotated. This leads to the next point.

- If you enable Nullable Reference Types in your test project, you will want to also add [NUnit.Analyzers 3.0](https://www.nuget.org/packages/NUnit.Analyzers/) or newer to your test project. Adding the analyzer is a great idea on its own, but it also specifically mitigates the problem in the previous point by suppressing C# compiler nullability warnings when we know it's safe, when not in a Multiple Asserts context. This way you don't have to use the C# null forgiveness operator (`!`) everywhere.

Another addition in 3.13 is the [`FixtureLifeCycle`](https://docs.nunit.org/articles/nunit/writing-tests/attributes/fixturelifecycle.html) attribute. It enables you to stop sharing fixture instances between the tests inside that fixture. It is useful in combination with the [Parallelizable Attribute](https://docs.nunit.org/articles/nunit/writing-tests/attributes/parallelizable.html) because it allows tests within a fixture to run in isolation from each other without sharing instance fields and properties during parallel test runs.

3.13 also fixes several issues running tests in .NET 5.0. If your tests target .NET 5.0, we recommend updating to this release or a newer one.

#### [NUnit Console and Engine 3.12](https://github.com/nunit/nunit-console/releases/tag/v3.12)
This release contains various improvements to running tests on .NET Core and Mono, and changes to extension loading logic to allow the Engine to better support extensions which target multiple platforms. There are additionally a number of fixes to issues that were identified with 3.12 Beta 1. Please also be aware that this will be the last version of the NUnit Engine to support .NET Standard 1.6.

#### [NUnit Analyzers 0.5](https://github.com/nunit/nunit.analyzers/releases/tag/0.5.0), [0.6](https://github.com/nunit/nunit.analyzers/releases/tag/0.6.0), [2.0, and 3.0](https://github.com/nunit/nunit.analyzers/releases/tag/3.0.0)
These versions bring fixes, new features, and performance improvements. The 3.0 release of NUnit Analyzers automatically suppresses C# 8 Nullable Reference Types warnings based on context in order to fill the gap for conditions that can't be expressed using C# annotations, as mentioned in the NUnit Framework section above. (Many thanks to Manfred Brands for this major contribution.) This functionality depends on a newer version of Roslyn which is not supported in Visual Studio 2017.

So we have decided to release two versions of the analyzers: versions starting with 2.x can be used in Visual Studio 2017. Versions starting with 3.x can be used in Visual Studio 2019. Most features will be available in both the 2.x versions and the 3.x versions unless they require Roslyn functionality that is only available in the 3.x versions.

### [Version 1.0.0 of Cake has been released](https://cakebuild.net/blog/2021/02/cake-v1.0.0-released)🍰🎉

This version is the 112th release of Cake, but just not any release - they've finally hit 1.0 🎉

#### Major new features

* .NET 5 support
* C# 9 support
* Implicit bootstrapping
* Rewritten CLI
* Frosting incorporated into main repository
* Frosting CLI brought up to speed with Cake script runners
* Improved globbing support
* Greatly improved documentation
* Bugfixes, increased test coverage, and integration tests

Full details and release notes in the release blog post: [Cake v1.0.0 released](https://cakebuild.net/blog/2021/02/cake-v1.0.0-released)

## .NET Foundation Committee Updates

### Membership Committee

The membership committee is working on [expanded profiles](https://github.com/dotnet-foundation/wg-membership/pull/14) to encourage more people in the .NET ecosystem to join the .NET Foundation. We see that there are many ways to contribute to the ecosystem, and we will use these profile definitions to encourage others to join. The profiles are not mutually exclusive, but should provide more ideas on how you can see yourself contributing to the foundation. We're also starting work on planning this year's board elections. If you're interested in serving on the nominating committee, watch for announcements.

### Marketing Committee
We'd like to make our members aware of some marketing resources you can take advantage of.

- *Help spread .NET Foundation's message*: Take a look at the [.NET Foundation slides](https://dotnetfoundation.sharepoint.com/:p:/s/Marketing/EbxGONyybLRMoe6MgPNUEi4BdDuEWNLmdfV_s8INO9nWTw?e=mImEov) and use them in your presentations and events.
- *Promote your .NET open source content, events, project news*: If you'd like to promote something on the .NET Foundation social channels, fill out the [amplification request issue template on our content repo](https://github.com/dotnet-foundation/content/issues/new?assignees=&labels=&template=content-amplification-request.md&title=%5BAMPLIFICATION%5D+-+Title) and we'll get you scheduled.

## Events
### .NET Conf: Focus on Windows, February 25
[![Windows 550x182](https://user-images.githubusercontent.com/5115571/108775140-87eab100-7515-11eb-87cf-a9c9b0df27b1.png)](https://focus.dotnetconf.net/agenda?utm_campaign=savedate&utm_medium=newsletter&utm_source=dotnetfdn)

The .NET Conf team is bringing you another ".NET Conf: Focus" event this Thursday, February 25th all about building apps for Windows. Last year they started a series of smaller, live events are delivered throughout the year that are focused on specific things you can do with .NET. 

[.NET Conf: Focus on Windows](https://focus.dotnetconf.net/agenda?utm_campaign=savedate&utm_medium=newsletter&utm_source=dotnetfdn) is a free, one-day livestream event that features speakers from the community and Microsoft teams working on Windows desktop apps and making them awesome on the latest .NET 5. Learn why and how to upgrade WPF and Windows Forms apps to .NET 5, see Visual Studio tooling improvements, learn how to leverage cloud services from your client apps, and a whole lot more. You'll also see what the future of native device development will look like in .NET 6.
 
**[Tune into focus.dotnetconf.net](https://focus.dotnetconf.net/agenda?utm_campaign=savedate&utm_medium=newsletter&utm_source=dotnetfdn) on February 25, 2021. Ask questions live and come learn how to move your Windows apps forward.** 

**[Save the date!](https://focus.dotnetconf.net/agenda?utm_campaign=savedate&utm_medium=newsletter&utm_source=dotnetfdn)**

### JetBrains .NET Day Online 2021 - Call for Speakers

JetBrains is organizing their third **.NET Day Online on May 12, 2021**. It is a free virtual event where community speakers cover topics they are passionate about, ranging from deep technical .NET content and speakers' experiences with specific tools and technologies, to personal development.

They are looking for speakers interested in presenting, and welcome all topics that would be relevant to the wider .NET community.

For more information, [head over to the Call for Speakers page](https://blog.jetbrains.com/dotnet/2021/02/15/jetbrains-net-day-online-2021-call-for-speakers/?utm_source=newsletter&utm_medium=referral&utm_campaign=resharper&utm_content=dnf2021-02)!

## How to Get Involved
The .NET Foundation is only as good as the community that supports it. There are many ways to get involved. 

### [Support a project](https://dotnetfoundation.org/projects)
Projects, and the people behind them, are at the heart of what .NET Foundation is all about. These days, you'll find a wide variety of projects under the .NET Foundation. Can you contribute to something already in the works? [Browse our projects](https://dotnetfoundation.org/projects) to find out how to contribute. 

### [Become a member](https://dotnetfoundation.org/member) 
By involving people that are passionate about .NET we can create a powerful organization that furthers sustainable open source, a diverse and open community, and help evolve this growing and evolving ecosystem that we are very passionate about. If you are as passionate about the .NET ecosystem as we are, then you should consider becoming a member of the .NET Foundation. [Read more about member benefits](https://dotnetfoundation.org/member) and [please join](https://dotnetfoundation.org/member/become-a-member) to help shape the future.

### [Join a committee](https://dotnetfoundation.org/community/committees)
The .NET Foundation Committees are where the vast majority of work gets done in the Foundation. The more you participate the more we can do together. Please visit the [committee hub on our website](https://dotnetfoundation.org/community/committees) to learn more and how you can get involved. 

### [Spread the word](https://github.com/dotnet-foundation/wg-marketing)
Help spread .NET Foundation's message. Take a look at the [.NET Foundation slides](https://dotnetfoundation.sharepoint.com/:p:/s/Marketing/EbxGONyybLRMoe6MgPNUEi4BdDuEWNLmdfV_s8INO9nWTw?e=mImEov) and use them in your presentations and events. Members can also request promotion of their events and open source related content. See the [marketing repo](https://github.com/dotnet-foundation/wg-marketing) for details. 

### [Buy some merch](https://store.dotnetfoundation.org/)
Show off your nerd side with pride! Support the .NET Foundation by rocking some gear from our store. [Check out the new items](https://store.dotnetfoundation.org/dotnetfoundation/accessories) and don't forget to show them off on [Twitter #dotnetlovesme](https://twitter.com/search?q=%23dotnetlovesme). 

### [Have some fun](https://mod-dotnet-bot.net)
Coding is better with friends, especially when they bring their own mods. As the mascot for the .NET community, dotnet-bot helps with checking pull requests on .NET repos on GitHub. Create your own coding companion by building your own custom dotnet-bot at [mod-dotnet-bot.net](https://mod-dotnet-bot.net) and sharing it on [Twitter #dotnetlovesme](https://twitter.com/search?q=%23dotnetlovesme). 

[![mod-dotnet-bot.net](https://user-images.githubusercontent.com/5115571/100276672-c670cf80-2f16-11eb-8a9f-2b8a90775a06.png)](https://mod-dotnet-bot.net)
