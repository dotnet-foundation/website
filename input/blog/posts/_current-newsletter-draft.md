---
Title: .NET Foundation January/February 2021 Update
Author: Claire Novotny
Published: 
Slug: net-foundation-january-february-2021-update
Excluded: true
---
Welcome to the .NET Foundation update for January & February. Every other month, we'll give you a quick overview of the .NET open source landscape and what the .NET Foundation is up to, including top project news, events, community links and more. 

[Sign up for the newsletter](http://eepurl.com/dhL_qb) and get these updates delivered right to your inbox.

## General news


## .NET Foundation Project Updates

### [Project Spotlight - <fill in>](https://dotnetfoundation.org/projects/spotlight)

Each month Project Spotlight shines a light on an interesting open source project and its maintainers. In this iteration, .NET Foundation Marketing Committee member, Isaac Levin, speaks with ....

### [NUnit](https://nunit.org)

Many new releases are out at once, and work is starting on future major versions!

In addition to the notes below, the .NET Core Console remains in beta ([release 3.12.0-beta2](https://github.com/nunit/nunit-console/releases/tag/v3.12.0-beta2)) due to some unresolved dependency loading and framework targeting issues. Contributions to fix these issues would be very welcome.

#### [NUnit Framework 3.13](https://github.com/nunit/nunit/releases/tag/v3.13) and [3.13.1](https://github.com/nunit/nunit/releases/tag/v3.13.1)

3.13 ships the first C# 8 Nullable Reference Types annotations! Almost all areas have been annotated. There are some important things to call out about this:

- `Assert` methods don’t always throw exceptions when the assertion fails, due to the [Multiple Asserts](https://docs.nunit.org/articles/nunit/writing-tests/assertions/multiple-asserts.html) feature. Starting in version 3.6, `Assert.NotNull(obj)` no longer meant that `obj` would never be null on the following line. `Assert.Catch` and the other `Assert` methods are the same way. The nullability annotations added in 3.13 reflect this existing reality. We decided to only add nullability annotations that were accurate in every circumstance—a philosophy consistent with how .NET itself is annotated. This leads to the next point.

- If you enable Nullable Reference Types in your test project, you will want to also add [NUnit.Analyzers 3.0](https://www.nuget.org/packages/NUnit.Analyzers/) or newer to your test project. Adding the analyzer is a great idea on its own, but it also specifically mitigates the problem in the previous point by suppressing C# compiler nullability warnings when we know it’s safe, when not in a Multiple Asserts context. This way you don’t have to use the C# null forgiveness operator (`!`) everywhere.

Another addition in 3.13 is the [`FixtureLifeCycle`](https://docs.nunit.org/articles/nunit/writing-tests/attributes/fixturelifecycle.html) attribute. It enables you to stop sharing fixture instances between the tests inside that fixture. It is useful in combination with the [Parallelizable Attribute](https://docs.nunit.org/articles/nunit/writing-tests/attributes/parallelizable.html) because it allows tests within a fixture to run in isolation from each other without sharing instance fields and properties during parallel test runs.

3.13 also fixes several issues running tests in .NET 5.0. If your tests target .NET 5.0, we recommend updating to this release or a newer one.

#### [NUnit Console and Engine 3.12](https://github.com/nunit/nunit-console/releases/tag/v3.12)

This release contains various improvements to running tests on .NET Core and Mono, and changes to extension loading logic to allow the Engine to better support extensions which target multiple platforms. There are additionally a number of fixes to issues that were identified with 3.12 Beta 1. Please also be aware that this will be the last version of the NUnit Engine to support .NET Standard 1.6.

#### [NUnit Analyzers 0.5](https://github.com/nunit/nunit.analyzers/releases/tag/0.5.0), [0.6](https://github.com/nunit/nunit.analyzers/releases/tag/0.6.0), [2.0, and 3.0](https://github.com/nunit/nunit.analyzers/releases/tag/3.0.0)

These versions bring fixes, new features, and performance improvements.

The 3.0 release of NUnit Analyzers automatically suppresses C# 8 Nullable Reference Types warnings based on context in order to fill the gap for conditions that can’t be expressed using C# annotations, as mentioned in the NUnit Framework section above. (Many thanks to Manfred Brands for this major contribution.) This functionality depends on a newer version of Roslyn which is not supported in Visual Studio 2017.

So we have decided to release two versions of the analyzers: versions starting with 2.x can be used in Visual Studio 2017. Versions starting with 3.x can be used in Visual Studio 2019. Most features will be available in both the 2.x versions and the 3.x versions unless they require Roslyn functionality that is only available in the 3.x versions.

### New Projects


## .NET Foundation Committee Updates

### Membership Committee
 


## Events


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
