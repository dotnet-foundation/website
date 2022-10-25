---
Title: .NET Core
Contributor: Microsoft
Logo: microsoft.jpg
Web: https://github.com/dotnet/core
---
# .NET Platform

The .NET platform is the foundation of the .NET ecosystem. The platform enables all other .NET code to be built and run. It also defines many of the patterns and capabilities commonly used by .NET developers, like LINQ, async, and generics. The .NET platform is also cross-platform by default, enabling most code to run on any supported operating system or chip architecture.

The platform is composed of:

- .NET runtime and libraries
- Language compilers for C#, F#, and Visual Basic
- Frameworks, including .NET MAUI, [ASP.NET Core](/projects/aspnet-core), Windows Forms, Windows Presentation Framework
- MSBuild and build system tailored for .NET
- NuGet client and package manager
- CLI that enables building .NET projects and configuring a development environment

.NET is sometimes called a "managed code" runtime. It is called managed primarily because it uses a garbage collector for memory management and because it enforces type and memory safety. The .NET runtime also virtualizes (or abstracts) a variety of operating system and hardware concepts, such as memory, threads, and exceptions.

The runtime is designed to support multiple programming languages. C#, F#, and Visual Basic languages are supported by Microsoft and are designed in collaboration with the community.

.NET has a comprehensive standard set of class libraries. These libraries provide implementations for many general-purpose and workload-specific types and utility functionality.

.NET is supported for many types of apps running in varied environments. In some cases, multiple implementations of the same component are provided so that apps run correctly and optimally. This is the case with networking and cryptography libraries, which need to adapt to the underlying operating system. It's also true of runtimes. The .NET platform is composed of three runtimes: CoreCLR, Mono, and Native AOT. They are compatible, in terms of running the same .NET code, but satisfy different characteristics which makes them suited for different environments (like Cloud or a watch).

## Project Details

* [Project Info Site](https://github.com/dotnet/core)
* Project Code Repos: [.NET Runtime](https://github.com/dotnet/runtime), [.NET SDK](https://github.com/dotnet/sdk)
* Project Docs Repos: [Concepts](https://github.com/dotnet/docs), [APIs](https://github.com/dotnet/dotnet-api-docs), [Samples](https://github.com/dotnet/samples)
* Project License Type: [MIT](https://github.com/dotnet/runtime/blob/master/LICENSE.TXT)
* Project Main Contact: [Immo Landwerth](https://github.com/terrajobst)

## Quicklinks

* [Contribute](https://github.com/dotnet/runtime/blob/master/CONTRIBUTING.md)
* [Discussions](https://forums.dotnetfoundation.org/)
* [Samples](https://github.com/dotnet/samples)
* [Blog](https://devblogs.microsoft.com/dotnet/)
* Twitter: [@dotnet](https://twitter.com/dotnet)
* [Documentation](https://docs.microsoft.com/dotnet)
