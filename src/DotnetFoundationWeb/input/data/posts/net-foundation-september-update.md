LayoutRef: blog
Title: .NET Foundation September Update
Author: Jon Galloway
Published: 2018-09-28 23:52:01.5331417
---
<div itemprop="articleBody">
<p>Here's the August edition of the .NET Foundation newsletter. Every month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.<br />
<br />
This month's newsletter includes:</p>

<ul>
<li>.NET Conf wrapup / worldwide .NET Conf Local events series through the end of October</li>
<li>News from .NET Foundation member projects</li>
<li>Hacktoberfest</li>
<li>.NET Meetup news</li>
</ul>

<p>As always, these are available both on our blog and via e-mail:&nbsp;<a href="http://eepurl.com/dhL_qb">Sign up to get the .NET Foundation Update via e-mail</a></p>

<h2>.NET Conf / .NET Conf Local</h2>

<p><img alt="" src="assets/posts/MSFT_18023_dotNETConf_banners_email800x200_eventInfo_r3_KW.jpg" style="width: 800px; height: 200px;" /></p>

<p><a href="https://dotnetconf.net">.NET Conf 2018</a> was our big live stream training event of the year and the biggest .NET Conf we’ve ever done! We had 41 live sessions – 17 in Channel 9 studios and the last day going an all-nighter with 24 hours of sessions on Twitch and Mixer. We also broadcasted the keynote via Amp Live which bought us a lot of new viewers this year. Additionally we partnered the .NET Foundation with the Visual Studio partner program to pull off a <a href="https://twitter.com/search?q=%23dotnetconf%20%23codeparty&amp;src=typd" originalsrc="https://twitter.com/search?q=%23dotnetconf%20%23codeparty&amp;src=typd" shash="dNuuvBpkaP1yj4iA8mtfv9sZraoHUnzJtsNLn8xa+sjM3Iv7DrHwxUOQH9sWnEOctzx2Mh+JCXvXk9wVmbA63k9Yzg1/B+Au55k51UoAXVp2q4QfmpzdFMjTG+zzGHO+PJwsG96Du5u7T5VrpOObg2D4OaibsvvAh5Hpn+rpY6Y=">virtual attendee party</a> where attendees could win cool prizes like the Surface Go and Xbox.&nbsp;</p>

<h3>Check out the .NET Conf Keynote!</h3>

<p>In case you missed it, check out the <a href="https://www.youtube.com/watch?v=qQdGC2jIP8s">.NET Conf keynote with Scott Hunter,&nbsp;Mads Torgersen, and Miguel De Icaza</a>:</p>

<p><a href="https://www.youtube.com/watch?v=qQdGC2jIP8s"><img alt="" src="assets/posts/maxresdefault.jpg" style="width: 1280px; height: 720px;" /></a></p>

<h3>.NET Conf Local Events<!--3--></h3>

<p>.NET Conf is partnering with organizers around the globe to bring you <a href="https://www.dotnetconf.net/local-events/">local in-person events and watch parties</a>! There are over local events around the world now; join your fellow developers in a city near you to learn more about .NET.</p>

<h2>.NET Foundation Project News</h2>

<h3>DNN:&nbsp;5 Reasons Why We’re Glad to Be Part of the .NET Foundation</h3>

<p>DNN joined the .NET Foundation in November 2017, and <a href="https://www.dnnsoftware.com/community-blog/cid/155629/5-reasons-why-were-glad-to-be-part-of-the-net-foundation">just posted some of the top reasons</a> they're glad they did. Aw, shucks, we love you too!&nbsp;</p>

<h3>Iron Python</h3>

<p>The <a href="http://ironpython.net/">IronPython</a> team is getting close to releasing a 2.7.9 final release with a lot of fixes compare to previous releases. Once 2.7.9 has been released, the team will focus mainly on IronPython 3, a release which will be compatible with Python 3.4</p>

<h3>Chemistry Add-In for Word</h3>

<p>The next version of <a href="https://www.chem4word.co.uk/">Chemistry Add-In for Word</a> is close to release!</p>

<p>It will include V8.0.0 of the ChemDoodle Web editor inside a completely new Windows Presentation Foundation interface. This makes it resolution independent, addressing a common bugbear when using it on smaller screen resolutions.</p>

<h3>NUnit</h3>

<p>The <a href="http://nunit.org">NUnit 3.9.0 console and engine</a> were released, featuring stability fixes and changing the handling of appdomain unload errors.</p>

<p>NUnit framework 3.11.0 is just around the corner, so stay tuned! Among many fixes and enhancements, this release will include:</p>

<ul>
<li>More informative assertion messages</li>
<li>PlatformAttribute detecting .NET Core</li>
<li>ValuesAttribute with nullable types</li>
<li>Async tests detecting and running Windows Forms or WPF message pumps rather than deadlocking</li>
<li>Support for UWP 10.0 is back via .NET Standard 1.4</li>
</ul>

<p>We are grateful to our many contributors!</p>

<h3>Telerik UI for UWP</h3>

<p>With one of the <a href="https://www.telerik.com/blogs/datagrid-calendar-multiday-view-improvements-telerik-ui-for-uwp-r3-2018">latest releases of Telerik UI</a> for UWP MultiDayView support has been introduced for the Calendar, expand and collapse functionality for the groups in the ListView control and many more features and improvements.&nbsp;Our latest official release of Telerik UI for UWP features more options in the <a href="https://www.telerik.com/blogs/datagrid-calendar-multiday-view-improvements-telerik-ui-for-uwp-r3-2018">MultiDay view of the Calendar</a>, nested PropertyName support, major bug fixes for the DataGrid and more.</p>

<h3>Orleans 2.1.0 release</h3>

<p>The <a href="https://github.com/dotnet/orleans/releases/tag/v2.1.0">Orleans 2.1.0&nbsp;release</a> includes a number of performance improvements, the biggest one being the new scheduler, that all add up in our tests to up to 30% throughput increase on the same hardware.</p>

<p>It also brings the support for distributed transaction to what we consider ""release candidate"" quality, with the new Distributed Transaction Manager at its core. We plan to declare transactions production ready in a subsequent release, after another round of testing and improvements.</p>

<p>Lastly, this release includes a new code generation package Microsoft.Orleans.CodeGenerator.MSBuild that can be used as an alternative to <a href="https://www.nuget.org/packages/Microsoft.Orleans.OrleansCodeGenerator.Build/">Microsoft.Orleans.OrleansCodeGenerator.Build</a>. The new code generator leverages Roslyn Code Analysis functionality to avoid loading application binaries. As a result, it avoid issues caused by clashing dependency versions and multiple versions of the .NET Core SDK.</p>

<p>This release includes no breaking changes and is backward compatible with 2.0.* releases, which allows for in-place upgrade of a running cluster.</p>

<h2>Meetups</h2>

<p>Our .NET Foundation sponsored&nbsp;.NET Meetup Pro groups broke through 200 this month, and many of them are participating in our <a href="https://www.dotnetconf.net/local-events/">.NET Conf Local Events</a> worldwide.&nbsp;Here are some quick stats:</p>

<ul>
<li>207 Groups</li>
<li>47 Countries</li>
<li>127K Members (added over 5K in the past 30 days)</li>
</ul>

<p>We've also started sending newsletters to Meetup organizers, including some links for some free swag for their groups. If your meetup hasn't joined yet, you can <a href="https://aka.ms/add-dotnet-meetup">right here</a>.</p>

<h2>Hacktoberfest</h2>

<p>Microsoft is joining in <a href="https://hacktoberfest.digitalocean.com/">Hacktoberfest</a> this October, and that includes the .NET projects on GitHub. Watch for a blog post the first week of October with more information!</p>

<hr />
<h2>Connect with the .NET Foundation online</h2>

<p>The&nbsp;<a href="https://www.facebook.com/dotnetfoundation/">.NET Foundation is on Facebook now</a>. Please like our page! We’ll post regular updates and interesting things happening with .NET to share.</p>

<p>The <a href="https://www.youtube.com/NETFoundation">.NET Foundation is also on YouTube</a>. Watch community standups and design reviews as well as code-focused shows and interviews across our multiple playlists.</p>

<hr />
<h2>Remember to Subscribe!</h2>

<p>Please&nbsp;<a href="http://eepurl.com/dhL_qb">sign up&nbsp;to get the .NET Foundation Update via e-mail</a>.&nbsp;Don’t worry, we want to keep these short, interesting, and low-noise, so we won’t overload your e-mail.</p>
</div>
