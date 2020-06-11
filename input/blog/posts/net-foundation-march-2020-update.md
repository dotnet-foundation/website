---
Title: .NET Foundation February/March 2020 Update
Author: Claire Novotny
Published: 2020-03-15
---

Here's the February/March 2020 .NET Foundation update. Every month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.

## General news

The Board voted to tie our [code of conduct](https://dotnetfoundation.org/code-of-conduct) to always be based on the latest version of the contributor covenant. We had been at [1.3](https://www.contributor-covenant.org/version/1/3/0/code-of-conduct/), and now we're on [2.0](https://www.contributor-covenant.org/version/2/0/code_of_conduct/). Member projects are expected adopt this update promptly. Projects that directly reference our version are all set and we encourage maintainers to review the docs to understand its contents.

### Update on Board Elections
We're postponing our board elections as we work through the transition to our new Executive Director. We are also in the process of hiring a company to help the .NET Foundation administration and want to make sure this is in place before we solicit candidates. The .NET Foundation by-laws do not require an exact date to hold elections and the current Board decided to get streamlined processes in place before the next set of members are elected so that they will be set up for a successful year ahead. 

As always, these are available both on our blog and via e-mail: [Sign up to get the .NET Foundation Update via e-mail](https://eepurl.com/dhL_qb)

## Committee Updates

The board approved the [Projects charter](https://github.com/dotnet-foundation/projects) that details what we look for in member projects looking to join, and expectations of member projects once approved. If you have feedback/changes/discussion on specific areas, please open an issue (to discuss) or PR (to propose specific changes).

The [marketing committee](https://github.com/dotnet-foundation/wg-marketing) just had their meeting update to all members and discussed how you can get involved. There are some jobs they have available and are accepting nominations to the committee. They also went over the proposed .NET Brand book with positive feedback and hope to release it to the community soon. See the [meeting notes](https://github.com/dotnet-foundation/wg-marketing/blob/master/Meetings/2020-Mar-05/README.md) for details, deck and recording. 

The [outreach committee](https://github.com/dotnet-foundation/wg-outreach) is having their first monthly meeting Tuesday 3/17 at 12p EST. You can join via this [link](https://teams.microsoft.com/l/meetup-join/19%3ameeting_OWFiZTQ0NTAtMmE0OS00NTdiLWIzODAtZjk0YjcwM2Y4MGQ0%40thread.v2/0?context=%7b%22Tid%22%3a%2216076fdc-fcc1-4a15-b1ca-32c9a255900e%22%2c%22Oid%22%3a%223ab57283-2fae-42fe-b673-fa33c1e6e46a%22%7d). The group will meet every third Tuesday of the month on Teams. This first meeting will be to discuss the format for submitting projects, the goals of the committee, and talk through the process of building working groups and requesting resources. 

## Events
[.NET Conf: Focus on Xamarin](https://focus.dotnetconf.net) virtual event is coming to you on March 23! This is a free, one-day livestream event that features speakers from the community and .NET product teams that are working on building native mobile apps with Xamarin technology! Xamarin lets you build native mobile apps for Android and iOS with C# instead of Java and Swift.

[Check out the agenda and save the date!](https://focus.dotnetconf.net/Agenda)

Tune in on March 23, 2020. Ask questions live and get some deep training on how to build beautiful, performant mobile apps with Xamarin.

### JetBrains .NET Day Online 2020 - Call for Speakers

One of our Technical Steering Group members is organizing the second **JetBrains .NET Day Online on May 14, 2020**. It's a free, virtual event, where community speakers cover topics they are passionate about, ranging from deep technical .NET content and speakers' experiences with specific tools and technologies to personal development.

Right now, they are looking for speakers interested in presenting with them! JetBrains is looking for .NET topics that are relevant to a broader audience, ideally with a link to JetBrains tools like ReSharper, Rider, and the profiling tools (though this is not required). 

For more information, [head over to the Call for Speakers page](https://blog.jetbrains.com/dotnet/2020/02/13/jetbrains-net-day-online-2020-call-speakers/?utm_source=newsletter&utm_medium=referral&utm_campaign=resharper&utm_content=dnf2020-02)!

## .NET Foundation Project Updates

## New Projects

The .NET Foundation would like to welcome the following projects that joined in February and March!

|  |  |
| ------------------- |--------------------|
| <img src="https://user-images.githubusercontent.com/1334951/76425289-a12b3980-6366-11ea-977d-a1cf35af6cf8.png" alt="Omnisharp" width="750px"> | **Omnisharp**  <br>OmniSharp is a set of tooling, editor integrations and libraries that together create an ecosystem that allows you to have a great programming experience no matter what your editor and operating system of choice may be.  |
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png" alt="Kereberos&#46;NET"> | **Kereberos&#46;NET** <br> Kerberos&#46;NET is a managed implementation of the Kerberos authentication protocol used by the majority of production enterprise platforms. Hundreds of millions of enterprise Windows clients authenticate using Kerberos every day but there are noticeable gaps in how these clients seamlessly authenticate to cloud services. This library is intended to bridge those gaps between Windows on-premises model with hybrid cloud services without taking a dependency on any platform.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png" alt="Nerdbank&#46;Gitversioning"> | **Nerdbank&#46;Gitversioning** <br> This package adds precise, semver-compatible git commit information to every assembly, VSIX, NuGet and NPM package, and more. It implicitly supports all cloud build services and CI server software because it simply uses git itself and integrates naturally in MSBuild, gulp and other build scripts.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76427201-40513080-6369-11ea-9f30-b5146fec6338.png" alt="Nuget Trends"> | **Nuget Trends** <br> NuGet Trends holds historical data of NuGet packages download numbers.  It's a useful tool for package maintainers to see the download rate of their packages and also for people interested in packages popularity over time. The database has the complete nuget.org catalog which include target framework information. That means that there's a lot more features we can add like TFM adoption overtime, dependency graphs etc.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426729-aab5a100-6368-11ea-936f-ab3ac79d957c.png" alt="Fluent Validation"> | **Fluent Validation** <br> FluentValidation is a .NET library for building strongly-typed validation rules for objects. Additionally it provides integration for automatic validation within ASP.NET-based projects.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426783-bc974400-6368-11ea-90bd-40e3f56daad1.png" alt="Marten"> | **Marten** <br> Marten gives developers a multi-paradigm framework for modelling, storing and querying data on PostgreSQL. Making use of the battle hardened database engine, Marten transparently exposes the JSON(B) capabilities of PostgreSQL for managing objects and events alike, requiring no ceremony to enable friction-less development. Marten is your object (document) and event store, with bells and whistles attached, be it CRUD, Event Sourcing or anything between.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png" alt="CoreWF"> | **CoreWF** <br> The Windows Workflow Foundation (WF) handles the long-running work of many companies. It powers many applications in all types of businesses. As more developers look into adopting .NET Core, some are asking if WF will be officially ported. This project only ports the WF runtime and ETW tracking provider to the .NET Standard. But much more work is needed before it can substitute for the .NET Framework version.|
|<img width="750px" src="https://user-images.githubusercontent.com/1334951/76426382-3975ee00-6368-11ea-97cf-fee658b2ce35.png" alt="linq2db"> | **linq2db** <br> LINQ to DB is the fastest LINQ database access library offering a simple, light, fast, and type-safe layer between your POCO objects and your database.  Architecturally it is one step above micro-ORMs like Dapper, Massive, or PetaPoco, in that you work with LINQ expressions, not with magic strings, while maintaining a thin abstraction layer between your code and the database. Your queries are checked by the C# compiler and allow for easy refactoring.  However, it's not as heavy as LINQ to SQL or Entity Framework. There is no change-tracking, so you have to manage that yourself, but on the positive side you get more control and faster access to your data.  In other words LINQ to DB is type-safe SQL.|

## Meetups

**Our .NET Foundation sponsored [.NET Meetup Pro groups](https://www.meetup.com/pro/dotnet) are continuing to grow worldwide.** Here are some quick stats:*
* 347 Groups
* 61 Countries
*	276K Members

Our .NET Meetup Pro group helps developers find your group, as well as get involved with local events like .NET Conf Local. If your meetup hasn't joined yet, you can [right here](https://aka.ms/add-dotnet-meetup).

![Map of meetup group locations](https://user-images.githubusercontent.com/1427284/74241694-64015800-4c91-11ea-9431-736bc05717a0.png)
