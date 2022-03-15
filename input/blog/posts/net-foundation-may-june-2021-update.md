---
Title: .NET Foundation May/June 2021 Update
Author: Claire Novotny
Published: 2021-06-30
Slug: net-foundation-may-june-2021-update
---
Welcome to the .NET Foundation update for May & June. Every other month, we'll give you a quick overview of the .NET open source landscape and what the .NET Foundation is up to, including top project news, events, community links and more.

[Sign up for the newsletter](https://eepurl.com/dhL_qb) and get these updates delivered right to your inbox.

## General news

### Welcome Okta and Volosoft to the .NET Foundation as Corporate Sponsors!

We're thrilled to have Okta and Volosoft join the .NET Foundation as Corporate Sponsors. Okta and Volosoft join a growing list of industry leaders in the .NET open source ecosystem who support the .NET Foundation, including AWS, DevExpress, Endjin, Microsoft, Octopus Deploy, Uno Platform, Progress Telerik, and VMware. Okta and Volsoft joins this group of corporations that are helping drive the future of the .NET platform and ecosystem and we are incredibly grateful for their support. The .NET Foundation relies on sponsors to fund our mission to create a thriving .NET open source ecosystem.

[![Okta logo](https://dotnetfoundation.org/assets/corporate-sponsors/okta.png)](https://www.okta.com/)

[![Volsoft logo](https://dotnetfoundation.org/assets/corporate-sponsors/volosoft.png)](https://volosoft.com/blog/Volosoft-Announces-the-NET-Foundation-Sponsorship)

## .NET Foundation Project Updates

### [Project Spotlight](https://dotnetfoundation.org/projects/spotlight) 

Each month Project Spotlight shines a light on an interesting open source project and its maintainers. 

In June, .NET Foundation Marketing Committee member, Isaac Levin, spoke with Maintainer of the Wix Toolset project, Rob Mensching, to talk about how .NET Developers who build desktop applications for Windows can take advantage of advanced publishing options with the Toolset.

**Watch the interview: [Wix](https://dotnetfoundation.org/projects/spotlight?project=WiX%20Toolset)**

The WiX Toolset is the most powerful set of tools available to create your Windows installation experience. The tools integrate seamlessly into your standard development (CI/CD) practices with text based source code, command-line tools and MSBuild/Visual Studio integration to create installation packages for your Windows software. The WiX Toolset was Microsoft's first Open Source project released in 2004 and is now a member of the .NET Foundation and supported commercially by FireGiant.

### New Projects
The .NET Foundation would like to welcome the following new projects!


| | | |
|-|-|-|
| [bUnit](https://bunit.dev/) | [![NFLogo](https://dotnetfoundation.org/assets/projects/bunit-logo.png)](https://bunit.dev/) | bUnit is a testing library for Blazor Components. Its goal is to make it easy to write comprehensive, stable unit tests.  bUnit builds on top of existing unit testing frameworks such as xUnit, NUnit, and MSTest, which run the Blazor component tests in just the same way as any normal unit test. bUnit runs a test in milliseconds, compared to browser-based UI tests which usually take seconds to run.|
| [FIDO2](https://fido2-net-lib.passwordless.dev/) | [![NFLogo](https://user-images.githubusercontent.com/1334951/113320871-de42d080-92c7-11eb-895f-0d5028cc414c.png)](https://fido2-net-lib.passwordless.dev/) | FIDO2 enables passwordless sign in for all .net apps (asp, core, native) and provides a developer friendly and well tested .NET FIDO2 Server / WebAuthn relying party library for the easy validation of registration (attestation) and authentication (assertion) of FIDO2 / WebAuthn credentials, in order to increase the adoption of the technology, ultimately defeating phishing attacks.|
| [HIBP](https://github.com/HaveIBeenPwned/PwnedPasswordsAzureFunction) | [![dotnext](https://dotnetfoundation.org/assets/projects/hibp.jpg)](https://haveibeenpwned.com/) | ';--have i been pwned? (HIBP) is a a free online resource for anyone to quickly assess if they may have been put at risk due to an online account of theirs having been compromised or "pwned" in a data breach.|
| [.NEXT](https://dotnet.github.io/dotNext/) | [![dotnext](https://dotnet.github.io/dotNext/doc_logo.png)](https://dotnet.github.io/dotNext/) | .NEXT (dotNext) is the family of powerful libaries aimed to improve development productivity and extend .NET API with unique features which potentially will be implemented in the next versions of C# compiler or .NET Runtime.|
| [Reaqtor](https://reaqtive.net/) | [![Reaqtor](https://raw.githubusercontent.com/reaqtive/reaqtor/main/reaqtor-header.svg)](https://reaqtive.net/) | Reaqtor is a framework for reliable, stateful, distributed, scalable, high performance event processing based on Reactive Extensions (Rx).|
  

### New Releases

#### [NuGet Package Explorer is now a Web App too!](https://platform.uno/blog/nuget-package-explorer-is-now-a-web-app-powered-by-uno-platform/)

By Popular demand, NuGet Package Explorer is now a Web App. The new solution is a WinUI, Windows Community Toolkit and Uno Platform powered solution which runs on the Web, via Uno's support for WebAssembly and .NET 6 for WebAssembly.


#### [DotVVM 3.0 Released](https://www.dotvvm.com/blog/83/Released-DotVVM-3-0)

If you haven't heard about DotVVM yet - it's an MVVM framework which you can use to [build ASP.NET Core web apps with just C# and HTML]([DotVVM](https://www.dotvvm.com/build) or to [modernize legacy ASP.NET apps to .NET 5](https://www.dotvvm.com/modernize). DotVVM is based on Knockout JS, its download size is just about 60kB, and comes with a set of built-in UI controls.

**DotVVM 3.0** contains many improvements, and introduces several new features:

* Easier interaction with the page viewmodel from JS or TS code - you can import JS module in the page and call its functions from DotVVM data-bindings, and also call DotVVM commands from your JS code. It makes it easy to integrate any third-party JS library or component.
* Support for lambdas and variables in data-binding expressions - it's now easier to make client-side searching, ordering, or transform data returned from the server or REST API before it's passed in the viewmodel.

[More info](https://www.dotvvm.com/blog/83/Released-DotVVM-3-0)

#### [NUnit](https://nunit.org)

[NUnit Analyzers 3.1 and 2.1](https://github.com/nunit/nunit.analyzers/releases/tag/3.1.0) are available. The 3.1 version continues to enhance the experience of using NUnit with the C# 8 Nullable Reference Types feature. (The 3.x versions have additional features that only work in Visual Studio 2019 and newer. The 2.x versions are available for those using Visual Studio 2017.)

[NUnit Adapter 4.0.0-beta.2](https://docs.nunit.org/articles/vs-test-adapter/Adapter-Release-Notes.html#nunit3-test-adapter-for-visual-studio---version-400-beta2---april-6-2021) resolves some issues and improves performance. A major change in this version is the upgrade of the NUnit.Engine to version 3.12, and thus Mono.Cecil is no longer used. Instead it has a reduced version (based on Mono.Cecil) packed into TestCentric.engine.metadata doing the same job with navigation data.

#### [Oqtane 2.1 Now Supports Multiple Databases](https://www.oqtane.org/Resources/Blog/PostId/548/oqtane-21-now-supports-multiple-databases)

On June 4, Oqtane announced the official release of Oqtane 2.1, a new major release of the popular modular application framework for Blazor, adding native support for SQL Server, SQLite, MySQL, and PostgreSQL to its growing list of framework capabilities.

A total of 94 pull requests containing 261 commits by 6 different contributors were integrated into this release.

The [2.1 release](https://github.com/oqtane/oqtane.framework/releases/tag/v2.1.0) is available for download on Github and we encourage the community to [visit the repo](https://github.com/oqtane/oqtane.framework) often to keep abreast of the latest developments.

## .NET Foundation Committee Updates

### Announcing the .NET Foundation Education Committee
We're excited to announce we've officially launched the Education Committee. Brian Jablonsky has stepped up to chair the committee. The education committee will be responsible for developing, sponsoring, and providing educational opportunities for the .NET community and is open to anyone who wants to participate. They meet every 2nd and 4th Wednesdays of the month from 11:00 AM to 12:00 PM ET.

Their first initiative is building and launching the .NET Foundation Academy, a program for higher education computer science students to learn about software development using .NET. The first curriculum focuses on full stack web development using C# and .NET 6. Students will work in teams on projects they propose, design, and implement. The course is a 12 week program consisting of a 2.5 hour class with a mix of lecture and workshops each week. 

If you are interested in joining the education committee, please [read more about joining on the education committee's GitHub repository](https://github.com/dotnet-foundation/wg-education).

### Outreach Committee Announces Proposal Process
The .NET Foundation's Outreach Committee is happy to announce that we've finalized our proposal process. If you have an idea or project that you think can help promote the adoption of .NET, C#, F#, or other related technologies, you can now propose projects directly to the .NET Foundation.

**[Read more about the details on our blog.](https://dotnetfoundation.org/blog/2021/05/19/wg-outreach-proposals)** 

### Board Nominating Committee Formed

The Nominating committee for the 2021 board elections had its organizational meeting. The nominating committee will be recruiting potential candidates for this year's board elections. In the next month, you'll hear more about potential candidates so you can make an informed choice when the election is held later this summer.

## Events

### .NET Conf: Focus on F# - July 29

[![FSharp 550x182](https://user-images.githubusercontent.com/5115571/123715356-fd042500-d82c-11eb-9393-246e4872114e.png)](https://focus.dotnetconf.net/?utm_campaign=savedate&utm_medium=newsletter&utm_source=dotnetfdn)

*.NET Conf: Focus on F#* is a free, one-day livestream event co-organized by the .NET community and Microsoft, and sponsored by the .NET Foundation and F# Software Foundation.

Learn how F# lets you write succinct, performant, and robust code backed by a powerful type system and the .NET runtime you can trust to build mission-critical software. Hear from language designers and experts using F# in a variety of ways from building minimal web APIs to performing data manipulation, interactive programming, machine learning, and data science.

**Tune into [focus.dotnetconf.net](https://focus.dotnetconf.net/?utm_campaign=savedate&utm_medium=newsletter&utm_source=dotnetfdn) on July 29, ask questions live, and learn about what F# can do. [Save the date!](https://focus.dotnetconf.net/?utm_campaign=savedate&utm_medium=newsletter&utm_source=dotnetfdn)**

### Codegarden 2021 session replays now available

Earlier in June, Umbraco held the very first virtual Codegarden. It saw over 2200 attendees enjoy 3 days of updates, discussions, and ideas from Umbraco developers, the Umbraco community, and industry experts. Talks and sessions are being uploaded to the [Umbraco YouTube channel](https://www.youtube.com/umbracohq) already, but here's a few to get you started: 

- [Scott Hunter, .NET Director of Program Management at Microsoft - Future of application development with .NET](https://www.youtube.com/watch?v=Btvm-x5BRYg&list=PLG_nqaT-rbpx6wIDr5ufUlbHkg6qB3sxH&index=20)
- [Bjarke Berg and Elitsa Marinovska, Umbraco Development Team - Umbraco 9 - the next major version](https://www.youtube.com/watch?v=a-NFlIKO1TQ&list=PLG_nqaT-rbpx6wIDr5ufUlbHkg6qB3sxH&index=19)
- [Kim Sneum Madsen, Umbraco Chief Friend Maker (CEO) -   Opening keynote](https://www.youtube.com/watch?v=D_nLL-O2YIM&list=PLG_nqaT-rbpx6wIDr5ufUlbHkg6qB3sxH)

Sad that you missed out on all the bits in between? Then come and join us for Codegarden 2022 next summer! For all the info on Codegarden 2022 when it comes, make sure you're following us on [Twitter](https://twitter.com/umbraco?lang=da) and [LinkedIn](https://www.linkedin.com/company/umbraco), or [sign up for our newsletter](https://umbraco.activehosted.com/f/2) to get updates straight into your inbox.

### Microsoft Build 2021 session replays available
If you missed it, [Microsoft Build](https://build.microsoft.com/) sessions are now available on-demand. On May 25th, .NET 6 Preview 4 was released and there were a variety of sessions at Build that covered the features coming in .NET 6. Most notably, you'll want to checkout this session, which includes lots of discussion of .NET 6 and demos that show you what's new and now possible.

Watch on-demand: [.NET 6 deep dive; what's new and what's coming](https://aka.ms/Build2021-OD485)

### [.NET Conf 2021](https://dotnetconf.net/?utm_campaign=savedate&utm_source=dotnetfdn&utm_medium=newsletter), November 9 - 11
.NET Conf 2021 and the launch of .NET 6 is coming November 9th! .NET Conf is a free, three-day, virtual developer event that celebrates the major releases of .NET. It is co-organized by the .NET community and Microsoft, and sponsored by the .NET Foundation and ecosystem partners. Call for content will open on July 29th. 

**[Save the date!](https://dotnetconf.net/?utm_campaign=savedate&utm_source=dotnetfdn&utm_medium=newsletter)**

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

[![my-dotnet-bot-mod](https://user-images.githubusercontent.com/5115571/123716322-1e661080-d82f-11eb-8e42-4e6381a2c5f7.png)](https://mod-dotnet-bot.net)

