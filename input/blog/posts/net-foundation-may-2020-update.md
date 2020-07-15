---
Title: .NET Foundation April/May 2020 Update
Author: Claire Novotny
Published: 2020-05-06
---
Here's the April/May 2020 .NET Foundation update. Every other month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.

## General news

### New website
We just launched our [new website](https://dotnetfoundation.org)! Check it out to learn what we do, how to join as a project or as a member, and see how you can get involved! The site is built on [Statiq web](https://statiq.dev/web/), many thanks to [Dave Glick](https://twitter.com/daveaglick)!
  Community contribution to the site is encouraged, and it's all [on GitHub](https://github.com/dotnet-foundation/website).

![.NET Foundation new website screenshots](https://user-images.githubusercontent.com/68539/81202129-fce6fd00-8f7a-11ea-94e7-f8599bf85fc6.png)

## Committee Updates

### Outreach Comittee

We have two working groups that were kicked off in April's Outreach group meeting. One is working to determine the best way to support [remote meetups](https://github.com/dotnet-foundation/wg-outreach/issues/12), the second is a meta proposal group that is working on determining the process for getting Outreach proposals [resourced and approved](https://github.com/dotnet-foundation/wg-outreach/issues/13). Please see those two Github issues for details, and weigh in if you have something to share. We will have an update on next steps for both committees by out next meeting.   

## Events

### Dev Around The Sun

The .NET Foundation is presenting [Dev Around The Sun](https://devaroundthesun.org), the first of its kind, a 24-hour telethon style developer conference live on [Twitch](https://www.twitch.tv/devaroundthesun) and [YouTube](https://www.youtube.com/channel/UCG-Vejli7U-3GldOH_b8I6A) to raise funds for  [Direct Relief](https://www.directrelief.org/emergency/coronavirus-outbreak/), helping those affected most by COVID-19. 

Dev Around The Sun is a cross-platform, language-agnostic event, with high-level tech talks, as well as human skills talks. Please sign up at https://DevAroundTheSun.org to hear renowned speakers from a broad set of communities, spanning many technologies and all continents, who will educate, entertain, and inspire you in the comfort of your own home. This is a 24-hour, worldwide fundraiser for Direct Relief's coronavirus emergency fund.  The telethon-style fundraiser will take place on May 12th, 2020 and is hosted by the .NET Foundation. The virtual event will begin at 12:00 UTC May 12th, 2020 and consist of technology speakers scheduled to present for 24 hours, while raising funds for a cause.


### JetBrains .NET Days Online 2020 - A free, two-day virtual event!

As a .NET Foundation member, JetBrains is organizing the .NET Days Online, taking place on May 13–14, 2020.

This year's agenda features C#, F#, coding practices like refactoring and defensive coding, web, cloud and Xamarin, and we'll even dive into setting up a blog! Community speakers will be covering topics they are passionate about! Expect technical content and speakers' experience with specific tools and technologies.

**[Check the agenda & register to join us online](https://pages.jetbrains.com/dotnet-days-2020/dnf)**, and enjoy great content from wherever you happen to be.

### BuildStuff Weekly Virtual Meetups

Build Stuff offers free weekly meetups on various topics. On April 23, for example, Julie Lerman, author of the highly acclaimed “Programming Entity Framework” books, talked about her latest experiment on publishing a serverless ASP.NET Core API application onto AWS Lambda.  That same meetup had Ian Cooper, founder of the London .NET Users Group, talking about messages in a distributed system.

Sign up for future events or view recordings of past events at [https://www.buildstuff.events/meetups](https://www.buildstuff.events/meetups)

## .NET Foundation Project Updates

### [NUnit.Analyzers 0.2.0](https://github.com/nunit/nunit.analyzers/releases/tag/0.2.0)

Try out our first release ever of NUnit.Analyzers! By referencing this new NuGet package whenever you reference NUnit, you will get live, NUnit-specific diagnostics and code fixes in your IDE. Here are some of the smarts it currently provides:

- Proper usage of the TestCaseAttribute
- Proper usage of ParallelScopeAttribute
- Translation of assertions written in the classic model into the constraint model
- Proper usage of some of the most-used assertions (Is.EqualTo, Is.SameAs, Has.Count, Has.Property(...), Is.Null)

The full list of diagnostics is [here](https://github.com/nunit/docs/wiki/NUnit-Analyzers). If you have ideas or problems, please [let us know](https://github.com/nunit/nunit.analyzers/issues).

A big thank-you to Mikkel Nylander Bundgaard who has been leading this effort, and to the contributors who helped with this release: Ace Olszowka, Jason Bock, Jason Curl, Johan Larsson, Julian Verdurmen, Maxime Rouiller, Mihály Gyöngyösi, Oleksandr Liakhevych, and Steven Weerdenburg. This is an exciting step!

### [Marten](https://martendb.io/)

Marten team is currently working on the design of the new major (v4) release. The main focus will be put on the Event Sourcing part, but there will be also significant work done to make Marten more modular, efficient and easier to contribute. There is also a growing idea about using the code generation to reduce the boilerplate code.

For all that would like to see what's coming or take part in the discussions - there is a chance to contribute to the [Design plan](https://github.com/JasperFx/marten/pull/1457) or the details of the upcoming [Event Sourcing imrovements](https://github.com/JasperFx/marten/issues/1307).

### [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet)

BenchmarkDotNet v0.12.1 has been released!

.NET 5 support, [perfolizer](https://github.com/AndreyAkinshin/perfolizer) adoption, cross-platform disassembler, EventPipe-based cross-platform profiler, new fluent API, ref readonly support, and dozens of bug fixes!
You can find more details in the [official changelog](https://benchmarkdotnet.org/changelog/v0.12.1.html).

### Nancy is no longer being maintained!

  We would like to thank all the thousands of users of Nancy, all the people who wrote blog posts, conference speakers, video producers and those that spread the word of Nancy.

  We would like to thank the 150+ contributors to Nancy that made it what it became, without you the work would have been much harder and opportunities missed.

  We would like to thank VQ for financially sponsoring our open source efforts.

  We would like to thank the core contributors to Nancy @jchannon, @khellang, @damianh, @phillip-haydon, @prabirshrestha, @horsdal for working hard into the nights coding, testing and writing docs but most importantly the founders of Nancy itself @thecodejunkie and @grumpydev whose vision made Nancy what it was, a fun, performant and enjoyable web framework.

  We understand that organisations may have services and products that still depend on Nancy in production. A couple of members of the team can offer support, maintenance, and migration services on commercial terms. Please reach out to nancyfx.help@gmail.com to discuss options.

## New Projects

The .NET Foundation would like to welcome the following projects that joined in April and May!

|  |  |
| ------------------- |--------------------|
| <img width="750px" src="https://user-images.githubusercontent.com/1334951/78044659-d6092b80-7329-11ea-8c79-ec113bdcb599.png" width="750px"> | **Unity Container**  <br>The Unity Container (Unity) is a lightweight, extensible dependency injection container. It facilitates building loosely coupled applications.  |
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png"> | **Docker&#46;DotNet** <br> Docker&#46;DotNet is a library to interact with Docker Remote API endpoints in your .NET applications.  It is fully asynchronous, designed to be non-blocking and object-oriented way to interact with your Docker daemon programmatically.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png"> | **FlubuCore** <br> FlubuCore - "Fluent Builder Core" is a cross platform build and deployment automation system. You can define your build and deployment scripts in C# using an intuitive fluent interface. This gives you code completion, IntelliSense, debugging, FlubuCore custom analyzers, and native access to the whole .NET ecosystem inside of your scripts.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png"> | **Python&#46;NET** <br> Python&#46;NET is a package that gives Python programmers nearly seamless integration with the .NET 4.0+ Common Language Runtime (CLR) on Windows and Mono runtime on Linux and OSX. Python for .NET provides a powerful application scripting tool for .NET developers. Using this package you can script .NET applications or build entire applications in Python, using .NET services and components written in any language that targets the CLR (C#, VB.NET, F#, C++/CLI).|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/78050572-48c9d500-7331-11ea-8764-620a6abeb5f0.png"> | **Avalonia** <br> A cross platform XAML Framework for .NET Framework, .NET Core and Mono.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/78050928-d1e10c00-7331-11ea-949a-ece26db9ce39.png"> | **Piranha CMS** <br> Piranha CMS is a lightweight and unobtrusive CMS Library for .NET Core 3.1 and NetStandard 2.0. It can be used to add CMS functionality to your existing application or to build a new website from scratch.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/78051244-41ef9200-7332-11ea-9a11-02bcc020d26d.png"> | **Oqtane** <br> Oqtane is an open source modular application framework for Blazor. Oqtane was inspired by DotNetNuke and supports multi-tenancy, a fully dynamic page compositing model, designer friendly skins, extensibility via third party modules, and a familiar data model.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/78051404-7b280200-7332-11ea-8db9-11f3a9e8668a.png"> | **Elsa Workflows** <br> Elsa Workflows is an extensible, open source .NET Standard set of libraries and tools to implement workflow capabilities in any .NET application. It includes an HTML5 web components-based workflow designer.  Implement workflow functionality directly into your own application or integrate with a workflow server.|

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
* 353 Groups
* 62 Countries
*	281K Members

Our .NET Meetup Pro group helps developers find your group, as well as get involved with local events like .NET Conf Local. If your meetup hasn't joined yet, you can [right here](https://aka.ms/add-dotnet-meetup).

![Map of meetup group locations](https://user-images.githubusercontent.com/1427284/74241694-64015800-4c91-11ea-9431-736bc05717a0.png)
