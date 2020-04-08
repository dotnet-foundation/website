LayoutRef: blog
Title: .NET Foundation April Update
Author: Jon Galloway
Published: 2018-04-30 23:49:00.0000000
---
<p>It’s time for the April Update, subtitled The Calm Before The Storm edition... it's a relatively quiet month, but stay tuned for May when we'll have lots of news including several new projects joining and updates from the <a href="https://www.microsoft.com/en-us/build">Build 2018 conference</a>.</p>

<p>Speaking of Build... the .NET Foundation will have a .NET Open Source booth at Build. Come say hi!</p>

<p>As always, these are available both on our blog and via e-mail: <a href="http://eepurl.com/dhL_qb">Sign up to get the .NET Foundation Update via e-mail</a></p>

<h2>.NET Foundation Updates</h2>

<h3>Meetups</h3>

<p>The .NET Foundation sponsored <a href="https://www.meetup.com/pro/dotnet">.NET Meetup Pro groups</a> are continuing to grow! Here are some quick stats:</p>

<ul>
<li>83,000 Members (up over 2800 in the past 30 days)</li>
<li>Over 4400 RSVPs in the past 30 days</li>
<li>116 Events in the past 30 days</li>
<li>Largest Recent Meetup: <a href="https://www.meetup.com/metrotorontoug/events/247597822/">Global Azure Bootcamp (Metro Toronto)</a></li>
</ul>

<p>Please help connect us with other groups you're aware of that haven't joined yet by dropping me a note <a>jon@dotnetfoundation.org</a> or leaving a comment below.​</p>

<h3>.NET Presentations: Events In A Box!</h3>

<p>Need a presentation or workshop content for your event? We've got you covered! We've launched an <a href="https://dotnet-presentations.github.io/">Events In A Box mini-site</a>, with links to repositories full of decks, demos, and workshop scripts. These are open source repos on GitHub, so you can use, remix, share, and contribute to them. We'll continue to add to and build out the content, and look forward to your feedback and contributions.</p>

<hr />
<h2>.NET Foundation Project News</h2>

<h3>Polly Integration with ASP.NET Core 2.1</h3>

<p>We are excited to announce that starting with ASP.NET Core 2.1, Polly integrates with the new IHttpClientFactory. The HttpClient factory provides a central location where you can create and manage HttpClient objects, simplifying and enhancing how you use HttpClient in the four following ways.<br />
<br />
It:</p>

<ul>
<li>allows you to name and configure logical HttpClients. For instance, you may configure a client that is pre-configured to access the GitHub API;</li>
<li>manages the lifetime of HttpClientMessageHandlers to avoid some of the pitfalls associated with managing HttpClient yourself, such as socket exhaustion;</li>
<li>provides configurable logging (via ILogger) for all requests and responses performed by clients created with the factory;</li>
<li>provides a simple API for adding middleware to outgoing calls, be that for logging, authorization, service discovery, or resilience with Polly.</li>
</ul>

<p>The Polly team has worked with the Microsoft ASP.NET Core team to release a new extension NuGet package, named Microsoft.Extensions.Http.Polly. This extension helps you easily apply Polly policies to every outgoing call from an HttpClient instance.<br />
<br />
More details <a href="https://github.com/App-vNext/Polly/wiki/Polly-and-HttpClientFactory">here</a>.</p>

<h3>BenchmarkDotNet v0.10.14 Released</h3>

<p>BenchmarkDotNet v0.10.14 has been released! This release includes:</p>

<ul>
<li>Per-method parameterization</li>
<li>Console histograms and multimodal disribution detection</li>
<li>Many improvements for Mono disassembly support on Windows</li>
<li>Many bugfixes</li>
</ul>

<p>See the release notes <a href="http://aakinshin.net/blog/post/bdn-v0_10_14/">here</a>.</p>

<h3>Announcing MvvmCross 6.0!</h3>

<p>Announcing MvvmCross 6.0!</p>

<ul>
<li>Migration to .NET Standard 2</li>
<li>Polished support for Xamarin.Forms</li>
<li>Brand new framework initialization (Setup &amp; AppStart)</li>
<li>New register process for plugins</li>
<li>Supercharged IMvxOverridePresentationAttribute for ViewPresenters</li>
<li>Initial support for Tizen</li>
<li>Tons of improvements and bug fixes!</li>
</ul>

<p>Read the release notes <a href="https://www.mvvmcross.com/mvvmcross-6.0.0-release/">here</a>.</p>

<h3>DNN-Connect Conference</h3>

<p>The DNN Community is getting ready for the annual European-based conference, DNN-Connect which takes place in Limerick, Ireland from May 31 - June 3rd. More info <a href="https://www.dnn-connect.org/events/2018">here</a>.</p>

<hr />
<h2>Community Links and News</h2>

<h3>Weekly ASP.NET Community Standup</h3>

<p>If you want to keep up to date with the latest ASP.NET news, join the Weekly ASP.NET Community Standup with Scott Hanselman, Damian Edwards and Jon Galloway. This is a live video meeting every Tuesday, with demos of new features and prototypes, live Q&amp;A, weekly community links, and more. Get the schedule, catch recent shows, and join the live standups at <a href="https://live.asp.net">https://live.asp.net</a></p>

<p>Even better, you can subscribe to the <a href="https://www.youtube.com/channel/UCiaZbznpWV1o-KLxj8zqR6A/playlists">.NET Foundation's YouTube channel</a> to make sure you catch both the ASP.NET Community Standup and&nbsp; .NET Design Reviews GitHub Triage every week.</p>

<h3>Recent Standout Community Posts and Links</h3>

<p>Here are some recent posts we’ve featured on the ASP.NET Community Standup:</p>

<ul>
<li><a href="https://blogs.msdn.microsoft.com/webdev/2018/04/12/asp-net-core-2-1-0-preview2-now-available/">ASP.NET Core 2.1.0-preview2 now available</a></li>
<li><a href="https://www.hanselman.com/blog/AddingResilienceAndTransientFaultHandlingToYourNETCoreHttpClientWithPolly.aspx">Adding Resilience and Transient Fault handling to your .NET Core HttpClient with Polly - Scott Hanselman</a></li>
<li><a href="https://docs.microsoft.com/en-us/dotnet/azure/dotnet-samples?view=azure-dotnet">Azure Code Samples for .NET | Microsoft Docs</a></li>
<li><a href="https://dotnet-presentations.github.io/">.NET Presentations | .NET Presentations: Events in a Box!</a></li>
<li><a href="https://github.com/natemcmaster/dotnet-serve">natemcmaster/dotnet-serve: Simple command-line HTTP server for .NET Core CLI</a></li>
<li><a href="https://andrewlock.net/creating-a-net-core-global-cli-tool-for-squashing-images-with-the-tinypng-api/">Creating a .NET Core global CLI tool for squashing images with the TinyPNG API</a></li>
</ul>

<p>There were a lot of posts about Blazor, corresponding with the announcement of Blazor 0.2.0 and the <a href="https://blazor.net">Blazor.net</a> site:</p>

<ul>
<li><a href="https://blogs.msdn.microsoft.com/webdev/2018/04/17/blazor-0-2-0-release-now-available/">Blazor 0.2.0 release now available | ASP.NET Blog</a></li>
<li><a href="https://blazor.net/index.html">Welcome to the Blazor preview docs website!</a></li>
<li><a href="https://daveaglick.com/posts/blazor-razor-webassembly-and-mono">Dave Glick - Blazor, Razor, WebAssembly, and Mono</a></li>
<li><a href="https://blogs.msdn.microsoft.com/webdev/2018/03/22/get-started-building-net-web-apps-in-the-browser-with-blazor/">Get started building .NET web apps that run in the browser with Blazor | ASP.NET Blog</a></li>
<li><a href="https://gitter.im/aspnet/Blazor">aspnet/Blazor - Gitter</a></li>
<li><a href="https://github.com/panesofglass/trail">panesofglass/trail: ASP.NET Blazor rendering with F#</a></li>
<li><a href="https://joonasw.net/view/csharp-await-and-js-promises-in-blazor">Using C# await against JS Promises in Blazor</a></li>
<li><a href="https://github.com/lohithgn/blazor-tour-of-heroes">lohithgn/blazor-tour-of-heroes: Blazor implementation of Angular Tour of Heroes</a></li>
<li><a href="http://www.talkingdotnet.com/create-a-crud-app-using-blazor-and-asp-net-core/">Create a CRUD App using Blazor and ASP.NET Core</a></li>
</ul>

<p>And a few top .NET posts:</p>

<ul>
<li><a href="https://blogs.msdn.microsoft.com/dotnet/2018/04/11/announcing-net-core-2-1-preview-2/">Announcing .NET Core 2.1 Preview 2</a></li>
<li><a href="https://blogs.msdn.microsoft.com/dotnet/2018/04/18/performance-improvements-in-net-core-2-1/">Performance Improvements in .NET Core 2.1</a></li>
<li><a href="https://blogs.msdn.microsoft.com/dotnet/2018/04/20/help-us-plan-the-future-of-net/">Help us plan the future of .NET!</a></li>
<li><a href="http://xoofx.com/blog/2018/04/12/writing-managed-jit-in-csharp-with-coreclr/">Writing a Managed JIT in C# with CoreCLR</a></li>
<li><a href="http://loicbaumann.fr/en/2018/04/02/how-to-optimize-net-development-using-net-core-2-1-and-c-7-2/">How To Optimize .Net Development Using .Net Core 2.1 And C# 7.2</a></li>
</ul>

<hr />
<h2>Connect with the .NET Foundation Online!</h2>

<p>The <a href="https://www.facebook.com/dotnetfoundation/">.NET Foundation is on Facebook now</a>. Please like our page! We’ll post regular updates and interesting things happening with .NET to share.</p>

<p><a href="https://www.youtube.com/NETFoundation">The .NET Foundation is also on YouTube</a>. Watch community standups and design reviews as well as code-focused shows and interviews across our multiple playlists.</p>

<p><a href="https://www.youtube.com/NETFoundation">Youtube</a></p>

<p>Do you have an interesting piece of news or content related to .NET open source? Let us know so we can include it in next month’s update by posting a comment below.</p>

<hr />
<h2>Remember to Subscribe!</h2>

<p>Please <a href="http://eepurl.com/dhL_qb">sign up</a> to get the .NET Foundation Update via e-mail.</p>

<p><a href="http://eepurl.com/dhL_qb">Subscribe</a></p>

<p>Don’t worry, we want to keep these short, interesting, and low-noise, so we won’t overload your e-mail.</p>
