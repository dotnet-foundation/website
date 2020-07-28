---
Title: .NET Foundation July/August 2020 Update
Author: Claire Novotny
Published: 
Slug: net-foundation-july-august-2020-update
Excluded: true
---
Here's the July/August 2020 .NET Foundation update. Every other month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.

## General news

### Board Elections Update


## Committee Updates

### Outreach


### Marketing


#### Member resources
We'd like to make our members aware of some marketing resources you can take advantage of.

- *Help spread .NET Foundation's message*: Take a look at the [.NET Foundation slides](https://dotnetfoundation.sharepoint.com/:p:/s/Marketing/EbxGONyybLRMoe6MgPNUEi4BdDuEWNLmdfV_s8INO9nWTw?e=mImEov) and use them in your presentations and events.
- *Promote your .NET open source content, events, project news*: If you'd like to promote something on the .NET Foundation social channels, fill out the [amplification request issue template on our content repo](https://github.com/dotnet-foundation/content/issues/new?assignees=&labels=&template=content-amplification-request.md&title=%5BAMPLIFICATION%5D+-+Title) and we'll get you scheduled.
- *Write a guest blog post or submit a video to our YouTube*: If you would like to propose creating content like a guest blog post or video, fill out the [content creation request issue template on our content repo](https://github.com/dotnet-foundation/content/issues/new?assignees=&labels=&template=content-creation-request.md&title=%5BCREATION%5D+-+Title) and we'll work with you on getting your content created.

#### .NET branding guidelines
Microsoft released updated .NET branding guidelines on GitHub [github.com/dotnet/brand](https://github.com/dotnet/brand). The purpose of these guidelines is to provide a framework for communicating with the .NET developer community and establishing a consistent brand identity. This not only includes the logo & typeface but also consistent messaging, terminology, fun illustrations and presentation templates you can use. 

## Events



### .NET Conf 2020 dates announced: November 10-12!
.NET Conf is a free, three day virtual developer event co-organized by the .NET community and Microsoft. This year .NET 5.0 will launch at .NET Conf 2020! See the website for more information and save the date! [www.dotnetconf.net](https://www.dotnetconf.net)

We're also planning our next .NET Conf: "Focus" event, where we continue focusing on specific .NET topics. July 30 we will present a full day of sessions for *.NET Conf: Focus on Microservices* with some very special guests! Learn more: [focus.dotnetconf.net](https://focus.dotnetconf.net)

## .NET Foundation Project Updates





## New Projects

The .NET Foundation would like to welcome the following projects that joined in June and July!
|                     |                    |
| ------------------- |--------------------|
| <img width="750px" src="https://user-images.githubusercontent.com/1334951/87341392-6ac11f00-c4fe-11ea-8442-e6068f16ba31.png" width="750px"> | **MahApps.Metro**  MahApps.Metro is a free open-source framework that allows developers to cobble together a better UI for their own WPF applications with minimal effort, Supporting .NET Framework and .NET Core. It overrides the default style of all common WPF controls and gives them a modern look. MahApps.Metro also includes some custom controls based on concepts from Windows Phone, Windows 8 and Window 10 (UWP) Apps.|
| <img width="750px" src="https://user-images.githubusercontent.com/1334951/88558920-0a8faa00-cfe1-11ea-8ee2-eeb0504e2b07.png" width="750px"> | **Verify**  Verify is a snapshot tool that simplifies the assertion of complex data models and documents. Verify is called on the test result during the assertion phase. It serializes that result and stores it in a file that matches the test name. On the next test execution, the result is again serialized and compared to the existing file. The test will fail if the two snapshots do not match: either the change is unexpected, or the reference snapshot needs to be updated to the new result. When snapshots do not match, the difference is automatically displayed in a diff tool.|

## New Releases

### [Linq2Db](https://github.com/linq2db/linq2db)

[Linq2Db 3.0 Released](https://github.com/linq2db/linq2db/wiki/Release-Notes-3.0.0)

This is a major upgrade from the existing 2.x versions. Major highlights:
* `IAsyncEnumerable<T>` support
* Linked Server support (cross-server database queries are now supported across all platforms where available)
* Better Eager load support (reduced query count, performance improvement)
* Query filters (convenient way to automatically filter data for all queries affecting a table)
* Support for ROLLUP and CUBE statements 
* OUTPUT statements are now supported on INSERT and DELETE statements on SQL Server
* General performance and memory use enhancements in all areas
* Misc. improvements to database providers

We are also happy to announce that [Shane Krueger](https://github.com/Shane32) and [Stuart Turner](https://github.com/viceroypenguin) have joined the linq2db team.

Full details are available [here](https://github.com/linq2db/linq2db/wiki/Release-Notes-3.0.0)

### [NUnit](https://nunit.org)

#### Documentation project

We’re grateful to have [Sean Killeen](https://seankilleen.com/) join us as lead of the documentation project. He put in a lot of effort to modernize the NUnit documentation, to great effect as you can see at [https://docs.nunit.org](https://docs.nunit.org)! The docs are now built with docfx. They are integrated with the website, have full-text search, and have edit links on each page where you can submit a PR easily. We look forward to seeing [your suggestions and contributions](https://github.com/nunit/docs)!

#### NUnit VSTest adapter

- [3.17.0](https://docs.nunit.org/articles/vs-test-adapter/Adapter-Release-Notes.html#nunit3-test-adapter-for-visual-studio---version-3170---july-11-2020) has a new StopOnError setting, the ability to set data file paths and line numbers, a major bugfix to show console output properly, and other fixes.

- [4.0.0-alpha.1](https://docs.nunit.org/articles/vs-test-adapter/Adapter-Release-Notes.html#nunit3-test-adapter-for-visual-studio---version-400-alpha1---july-12-2020) fixes some of the more complex issues, such as working with explicit tests and significant performance improvements. We would really appreciate it if you give this alpha a spin and [report](https://github.com/nunit/nunit3-vs-adapter/issues) whatever you find back to us.

#### NUnit Analyzers

- [0.3](https://github.com/nunit/nunit.analyzers/releases/tag/0.3.0) improved the documentation of all the diagnostics. It also added new diagnostics for proper usage of string constraints, ContainsConstraint, Does.Contain, and Contains.Item, and the TestCaseSource attribute.

- [0.4](https://github.com/nunit/nunit.analyzers/releases/tag/0.4.0) adds 13 new diagnostics and codefixes for asserts in the classical model such as Assert.Greater, Assert.IsNotEmpty, and Assert.IsNotInstanceOf. We have also improved the handling of asserts against constants and variables of type Task. In addition, we now properly handle ValueSourceAttribute and test methods decorated with both a TestAttribute and a TestCaseSourceAttribute/TestCaseAttribute. We have also added a diagnostic and codefix to ensure that test methods are public.

Please [try out the latest](https://www.nuget.org/packages/NUnit.Analyzers) and continue to [let us know what you’d like to see](https://github.com/nunit/nunit.analyzers/issues)!

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
* 365 Groups
* 65 Countries
*	303K Members

Our .NET Meetup Pro group helps developers find your group, as well as get involved with local events like .NET Conf Local. If your meetup hasn't joined yet, you can [right here](https://aka.ms/add-dotnet-meetup).

![Map of meetup group locations](https://user-images.githubusercontent.com/1427284/74241694-64015800-4c91-11ea-9431-736bc05717a0.png)
