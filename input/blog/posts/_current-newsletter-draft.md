---
Title: .NET Foundation May/June 2021 Update
Author: Claire Novotny
Published:
Slug: net-foundation-may-june-2021-update
Excluded: true
---
Welcome to the .NET Foundation update for May & June. Every other month, we'll give you a quick overview of the .NET open source landscape and what the .NET Foundation is up to, including top project news, events, community links and more.

[Sign up for the newsletter](http://eepurl.com/dhL_qb) and get these updates delivered right to your inbox.

## General news


## .NET Foundation Project Updates

### [Project Spotlight](https://dotnetfoundation.org/projects/spotlight)

Each month Project Spotlight shines a light on an interesting open source project and its maintainers. 


### New Projects
The .NET Foundation would like to welcome the following new projects!

| | | |
|-|-|-|
| bUnit | ![NFLogo](https://user-images.githubusercontent.com/1334951/113320871-de42d080-92c7-11eb-895f-0d5028cc414c.png) | bUnit is a testing library for Blazor Components. Its goal is to make it easy to write comprehensive, stable unit tests.  bUnit builds on top of existing unit testing frameworks such as xUnit, NUnit, and MSTest, which run the Blazor component tests in just the same way as any normal unit test. bUnit runs a test in milliseconds, compared to browser-based UI tests which usually take seconds to run.|
| FIDO2 | ![NFLogo](https://user-images.githubusercontent.com/1334951/113320871-de42d080-92c7-11eb-895f-0d5028cc414c.png) | FIDO2 enables passwordless sign in for all .net apps (asp, core, native) and provides a developer friendly and well tested .NET FIDO2 Server / WebAuthn relying party library for the easy validation of registration (attestation) and authentication (assertion) of FIDO2 / WebAuthn credentials, in order to increase the adoption of the technology, ultimately defeating phishing attacks.|
| .NEXT | ![dotnext](https://user-images.githubusercontent.com/1334951/121600883-03f00280-c9fa-11eb-8e7a-e6a1e9dc24b1.png) | .NEXT (dotNext) is the family of powerful libaries aimed to improve development productivity and extend .NET API with unique features which potentially will be implemented in the next versions of C# compiler or .NET Runtime.|
  

### New Releases

#### [NuGet Package Explorer is now a Web App too!](https://platform.uno/blog/nuget-package-explorer-is-now-a-web-app-powered-by-uno-platform/)

By Popular demand, NuGet Package Explorer is now a Web App. The new solution is a WinUI, Windows Community Toolkit and Uno Platform powered solution which runs on the Web, via Uno’s support for WebAssembly and .NET 6 for WebAssembly.


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

## Events

### Codegarden 2021

Codegarden is a one-of-a-kind tech conference experience organized by Umbraco - the company behind Umbraco CMS. For the first time, Codegarden goes virtual on June 9 - 11, 2021.

Beat the 'Zoom fatigue' with an exciting program full of opportunities to discuss, interact, and take part in fun activities, all the while listening to first-class talks ranging from Cloud technology, ASP.NET Core and DevOps to digital experience, accessibility, and customer satisfaction.

The Umbraco CMS is currently migrating from the ASP.NET framework to the newer, faster, and better ASP.NET Core/.NET 5, with exclusive news and updates live from the virtual Codegarden stage.

[Register for your free ticket here](https://codegarden.umbraco.com/the-tech-conference-like-no-other-codegarden-2021/)

## How to Get Involved
The .NET Foundation is only as good as the community that supports it. There are many ways to get involved. 

### [Support a project](https://dotnetfoundation.org/projects)
Projects, and the people behind them, are at the heart of what .NET Foundation is all about. These days, you’ll find a wide variety of projects under the .NET Foundation. Can you contribute to something already in the works? [Browse our projects](https://dotnetfoundation.org/projects) to find out how to contribute. 

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
