LayoutRef: blog
Title: .NET Foundation November Update
Author: Jon Galloway
Published: 2018-11-30 22:44:03.2885624
---
<div itemprop="articleBody">
<p>Here's the November edition of the .NET Foundation newsletter. Every month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.<br />
<br />
This month's newsletter includes:</p>

<ul>
<li>News from .NET Foundation member projects</li>
<li style="text-size-adjust:100%">A heads up on some exciting announcements about the .NET Foundation at the <a href="https://www.microsoft.com/en-us/connectevent/?ocid=AID750056_QSG_BNR_287413" style="text-size-adjust:100%; color:#2baadf" target="_blank">Connect</a> event keynote on December 4</li>
<li>.NET Meetup news</li>
</ul>

<p>As always, these are available both on our blog and via e-mail:&nbsp;<a href="http://eepurl.com/dhL_qb">Sign up to get the .NET Foundation Update via e-mail</a></p>

<hr />
<h2>Stay tuned for some big news at the Connect event!</h2>

<p><strong>We've got some really exciting updates on the way for the .NET Foundation!</strong> Watch the&nbsp;<a href="https://www.microsoft.com/en-us/connectevent/?ocid=AID750056_QSG_BNR_287413" target="_blank">Connect event keynote</a>&nbsp;on December 4 for the announcement, and keep an eye on our&nbsp;<a href="https://twitter.com/dotnetfdn" target="_blank">@dotnetfdn</a>&nbsp;Twitter handle and&nbsp;<a href="https://dotnetfoundation.org/blog" target="_blank">blog</a>&nbsp;for the announcement post and details.<br />
<br />
We can't wait to tell you about it! This next year is going to be amazing!</p>

<hr />
<h2>.NET Foundation Project News</h2>

<h3>IdentityServer 2.3 Release and ASP.NET Core Integration&nbsp;</h3>

<p>As recently announced, IdentityServer will be the default authentication and API security solution in ASP.NET Core. The integration will ship shortly after the ASP.NET Core 2.2 release.&nbsp;The basis for this integration is the new version 2.3 of IdentityServer that has been released last week.<br />
<br />
To ensure maximum compatibility with all versions of the .NET Framework, this release has been strong named, and for extra security, both the binaries and the Nuget packages are digitally signed.<br />
<br />
Besides many smaller improvements and bug fixes, the new version now support the so-called “Device Flow” which enables devices without a browser or limited input capabilities (e.g. gaming consoles, hardware devices) to securely connect to APIs.<br />
&nbsp;</p>

<h3>DNN Summit</h3>

<p>Training, Speaker, and Session info have been posted to the&nbsp;<a href="https://www.dnnsummit.org/" target="_blank">DNN Summit</a>&nbsp;site.<br />
&nbsp;</p>

<h3>NUnit 3.11.2</h3>

<p>A 3.11.2 hotfix for the NUnit VSTest adapter is available, addressing duplicate categories in Test Explorer. NUnit Visual Studio Test Generator 2.1 was also released. It now generates an NUnit3TestAdapter package reference required by VS 15.9+.<br />
It's been a quieter month with several new features in progress. The contributions are greatly appreciated!<br />
<br />
On December 1st, we plan to stop supporting .NET Framework 2.0 in NUnit framework 3.12 and forward. Last-minute comments are welcome at&nbsp;<a href="https://github.com/nunit/nunit/issues/3070" target="_blank">https://github.com/nunit/nunit/issues/3070</a>.<br />
&nbsp;</p>

<h3>Json.NET 12.0 Release 1 - .NET Foundation, NuGet and Authenticode signing, SourceLink and more</h3>

<p>This month, we&nbsp;<a href="https://dotnetfoundation.org/blog/2018/11/27/welcome-jsonnet-to-the-net-foundation" target="_blank">announced</a>&nbsp;that Json.NET, one of the most popular .NET projects in the solar system, has joined the .NET Foundation. This&nbsp;<a href="http://james.newtonking.com/archive/2018/11/27/json-net-12-0-release-1-net-foundation-nuget-and-authenticode-signing-sourcelink-and-more" target="_blank">post</a>&nbsp;announces the new 12.0 release, as well as some new features that we helped support: code signing and SourceLink support.<br />
&nbsp;</p>

<h3>AutoMapper 8.0.0 Released</h3>

<p><a href="https://jimmybogard.com/automapper-8-0-0-released/" target="_blank">AutoMapper 8.0</a>&nbsp;brings some breaking API changes, meant to simplify our configuration options which have grown quite a bit over time and remove some confusion about what configuration options were effectively equivalent. The&nbsp;<a href="http://docs.automapper.org/en/stable/8.0-Upgrade-Guide.html" target="_blank">upgrade guide</a>&nbsp;walks through the breaking changes.</p>

<p>This release also includes a new feature,&nbsp;<a href="http://docs.automapper.org/en/stable/Value-converters.html">Value Converters</a>, which allow you to define reusable mappers scoped to individual members.<br />
&nbsp;</p>

<h3>Akka.NET on .NET Rocks</h3>

<p>Check out&nbsp;<a href="https://dotnetrocks.com/?show=1601" target="_blank">Aaron's discussion of Akka.NET with Carl and Richard on the .NET Rocks podcast</a>.<br />
&nbsp;</p>

<h3>Announcing ML.NET 0.7 (Machine Learning .NET)</h3>

<p>This&nbsp;<a href="https://blogs.msdn.microsoft.com/dotnet/2018/11/08/announcing-ml-net-0-7-machine-learning-net/" target="_blank">release of ML.NET</a>&nbsp;includes the following:</p>

<ul>
<li><a href="https://blogs.msdn.microsoft.com/dotnet/2018/11/08/announcing-ml-net-0-7-machine-learning-net/#enhanced-support-for-recommendation-tasks-with-matrix-factorization" rel="nofollow">Enhanced support for recommendation tasks with Matrix Factorization</a></li>
<li><a href="https://blogs.msdn.microsoft.com/dotnet/2018/11/08/announcing-ml-net-0-7-machine-learning-net/#enabled-anomaly-detection-scenarios-and-detecting-unusual-events" rel="nofollow">Enabled anomaly detection scenarios – detecting unusual events rel</a></li>
<li><a href="https://blogs.msdn.microsoft.com/dotnet/2018/11/08/announcing-ml-net-0-7-machine-learning-net/#improved-customizability-of-mlnet-pipelines" rel="nofollow">Improved customizability of ML pipelines</a></li>
<li><a href="https://blogs.msdn.microsoft.com/dotnet/2018/11/08/announcing-ml-net-0-7-machine-learning-net/#x86-support-in-addition-to-x64" rel="nofollow">x86 support</a></li>
<li><a href="https://blogs.msdn.microsoft.com/dotnet/2018/11/08/announcing-ml-net-0-7-machine-learning-net/#nimbusml---experimental-python-bindings-for-mlnet" rel="nofollow">NimbusML – experimental Python bindings for ML.NET</a></li>
</ul>

<h3>BenchmarkDotNet v0.11.3</h3>

<p>This&nbsp;<a href="https://benchmarkdotnet.org/changelog/v0.11.3.html" target="_blank">release</a>&nbsp;is focused mainly on bug fixes that were affecting user experience. But don't worry, this release also has&nbsp;some new features too!</p>

<ul>
<li><strong>Diagnosers</strong>

<ul>
<li>ConcurrencyVisualizerProfiler (allows profiling benchmarks on Windows and exporting the data to a trace file which can be opened with Concurrency Visualizer)</li>
</ul>
</li>
<li><strong>Command-line:</strong>
<ul>
<li><code>--stopOnFirstError</code>: Stops the benchmarks execution on first error.&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/pull/947">#947</a></li>
<li><code>--statisticalTest</code>: Performs a Mann–Whitney Statistical Test for identifying regressions and improvements.&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/pull/960">#960</a></li>
</ul>
</li>
<li><strong>Bug fixes:</strong>
<ul>
<li>Dry mode doesn't work because of the ZeroMeasurementHelper&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/issues/943">#943</a></li>
<li>MannWhitneyTest fails when comparing statistics of different sample size&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/issues/948">#948</a>&nbsp;and&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/issues/950">#950</a></li>
<li>Improve the dynamic loading of Diagnostics package&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/issues/955">#955</a></li>
<li>BenchmarkRunner.RunUrl throws NRE when Config is not provided&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/issues/961">#961</a></li>
<li>Don't require the users to do manual installation of TraceEvent when using Diagnostics package&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/issues/962">#962</a></li>
<li>Stop benchmark after closing application + Flush log after stopping benchmark&nbsp;<a href="https://github.com/dotnet/BenchmarkDotNet/issues/963">#963</a></li>
</ul>
</li>
</ul>

<h3>PeachPie 0.9.18</h3>
This release includes support for .NET generics, custom attributes, and plenty of fixes.<br />
<a href="https://www.peachpie.io/2018/11/peachpie-attributes-generics.html" target="_blank"><img alt="" data-file-id="3152865" height="504" src="assets/posts/74003b16-78f9-4abd-8d12-ccbc26077669.png" width="845" /></a><br />
Read the announcement&nbsp;<a href="https://www.peachpie.io/2018/11/peachpie-attributes-generics.html" target="_blank">here</a>.

<h3>Free eBook on Modernizing .NET Applications from the Steeltoe team</h3>
Want to learn how to take advantage of Steeltoe to help modernize your .NET applications? Check out this 90 page&nbsp;<a href="https://content.pivotal.io/ebooks/modernizing-net-applications" target="_blank">eBook</a>&nbsp;from&nbsp;<a href="https://twitter.com/rseroter" target="_blank">Richard Seroter</a>!

<hr />
<h2>Meetups</h2>

<p>Our .NET Foundation sponsored&nbsp;<a href="https://www.meetup.com/pro/dotnet" target="_blank">.NET Meetup Pro groups</a>&nbsp;continue to grow.&nbsp;Here are some quick stats:</p>

<ul>
<li>240 Groups</li>
<li>51 Countries</li>
<li>147K Members</li>
</ul>

<p>We've also started sending newsletters to Meetup organizers, including some links for some free swag for their groups. If your meetup hasn't joined yet, you can&nbsp;<a href="https://aka.ms/add-dotnet-meetup">right here</a>.</p>

<hr />
<h2>Connect with the .NET Foundation online</h2>

<p>The&nbsp;<a href="https://www.facebook.com/dotnetfoundation/">.NET Foundation is on Facebook now</a>. Please like our page! We’ll post regular updates and interesting things happening with .NET to share.</p>

<p>The <a href="https://www.youtube.com/NETFoundation">.NET Foundation is also on YouTube</a>. Watch community standups and design reviews as well as code-focused shows and interviews across our multiple playlists.</p>

<hr />
<h2>Remember to Subscribe!</h2>

<p>Please&nbsp;<a href="http://eepurl.com/dhL_qb">sign up&nbsp;to get the .NET Foundation Update via e-mail</a>.&nbsp;Don’t worry, we want to keep these short, interesting, and low-noise, so we won’t overload your e-mail.</p>
</div>
