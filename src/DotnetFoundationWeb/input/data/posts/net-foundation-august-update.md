LayoutRef: blog
Title: .NET Foundation August Update
Author: Jon Galloway
Published: 2018-08-30 23:18:17.0103275
Visible: true
---
<p>Here's the August edition of the .NET Foundation newsletter. Every month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.<br />
<br />
This month's newsletter includes:</p>

<ul>
<li>.NET Meetup news</li>
<li>Info on .NET Conf (Sep 12-14), followed by worldwide .NET Conf Local events through the end of October</li>
<li>News from .NET Foundation member projects</li>
</ul>

<p>As always, these are available both on our blog and via e-mail:&nbsp;<a href="http://eepurl.com/dhL_qb">Sign up to get the .NET Foundation Update via e-mail</a></p>

<h2>Get Ready for .NET Conf and .NET Conf Local!</h2>

<p><img alt="" src="assets/posts/MSFT_18023_dotNETConf_banners_email800x200_eventInfo_r3_KW.jpg" style="width: 800px; height: 200px;" /></p>

<p>Save the date for .NET Conf — a free, 3-day, livestreamed developer conference co-organized by the .NET community and Microsoft.</p>

<p>Join us for live sessions and Q&A with experts from the community and .NET product teams. Learn to build for web, mobile, desktop, games, services, and libraries, all with .NET. Get the latest on .NET Core & ASP.NET Core, C#, F#, Azure, Visual Studio, Xamarin, and much more. We have sessions for everyone, no matter if you are just beginning or are a seasoned engineer.</p>

<p>You will learn to build for web, mobile, desktop, games, services, libraries and more for a variety of platforms and devices all with .NET. We have sessions for everyone, no matter if you are just beginning or are a seasoned engineer. We’ll have presentations on .NET Core and ASP.NET Core, C#, F#, Azure, Visual Studio, Xamarin, and much more.</p>

<p><a href="https://www.dotnetconf.net/?utm_source=dotnetfdn&utm_medium=newsletter&utm_campaign=savedate">Tune in from September 12-14 and discover the world of .NET!</a></p>

<h3>Register your .NET Conf Local events now!</h3>

<p>.NET Conf is partnering with organizers around the globe to bring you local in-person events and watch parties! We're up to over 135 local events around the world now; join your fellow developers in a city near you to learn more about .NET.</p><p>
<a href="https://www.dotnetconf.net/local-events/">Don't see your city? Organize an event!</a></p>

<h2>Meetups</h2>

<p>Wow! We're continuing to see rapid growth of the .NET Foundation sponsored&nbsp;.NET Meetup Pro groups, Here are some quick stats:</p>

<ul>
<li>198 Groups</li>
<li>47 Countries</li>
<li>121.4K Members (added over 4K in the past 30 days)</li>
</ul>

<p>We've also started sending newsletters to Meetup organizers, including some links for some free swag for their groups. If your meetup hasn't joined yet, you can <a href="https://dotnetfoundation.sharepoint.com/_layouts/15/WopiFrame.aspx?guestaccesstoken=E4s0o4r8BAjSAlDiOdKqy%2fW4RW2HbvrLcfz4PsJdbS8%3d&amp;docid=1_10cd43d461efb4f68aa5289bea6a50fc0&amp;wdFormId=%7B02655D67%2D5D39%2D47E7%2D8151%2D47536BFF227C%7D&amp;action=formsubmit">right here</a>.</p>

<h2></h2>

<h2>.NET Foundation Project News</h2>

<h3>Steeltoe by Pivotal: 2.1.0 Release</h3>
<p>Steeltoe 2.1.0 has been released! <a href="https://content.pivotal.io/blog/steeltoe-2-1-boosts-your-net-microservices-with-actuator-endpoints-distributed-tracing-and-deeper-support-for-the-frameworks-that-matter">Dave Tillman has prepared a blog</a>&nbsp;to break down all the new features and new support options we have added. While building Steeltoe 2.1.0, the team implemented a .NET library of the OpenCensus project. The Steeltoe team has been collaborating with OpenCensus members and Microsoft to donate the implementation. With the help of the Microsoft App Insights team, the code is being prepared for a release from the OpenCensus project:<br /><br />More info&nbsp;<a href="https://na01.safelinks.protection.outlook.com/?url=https%3A%2F%2Fgithub.com%2Fcensus-instrumentation%2Fopencensus-csharp&amp;data=02%7C01%7CBethma%40microsoft.com%7C43ef0210e22c4858a84808d60964043e%7C72f988bf86f141af91ab2d7cd011db47%7C1%7C0%7C636706722516321510&amp;sdata=3siUwubFcKSWfeou29oTkcmarWen4KH%2Bus8lRykqR18%3D&amp;reserved=0">h</a><a href="https://github.com/census-instrumentation/opencensus-csharp" target="_blank">ere</a>.<br />&nbsp;</p>
<h3>Cake: v0.30.0 release</h3>
<p>Version 0.30.0 of Cake has been released.&nbsp;With this release, we've got several improvements and bug fixes contributed from the community.</p>
<p>Some highlights in this release:</p>
<ul>
<li>Now available as .NET Core Global tool</li>
<li>Updated NuGet client to better support signed packages</li>
<li>Support for collection initializers on tool settings</li>
</ul>
<p>More details in the&nbsp;<a href="https://cakebuild.net/blog/2018/08/cake-v0.30.0-released" target="_blank">release announcement</a>.<br />&nbsp;</p>
<h3>IronPython 2.7.9 Release Candidate 1&nbsp;</h3>
<p>This release includes many fixes to make the user experience better and lots of issues have been fixed. This may be the last major release of the 2.7 release line as development kicks up on IronPython3! Read more&nbsp;<a href="https://github.com/IronLanguages/ironpython2/releases/tag/ipy-2.7.9-rc1" target="_blank">here</a>.<br />&nbsp;</p>
<h3>Orleans 2.1 Beta</h3>
<p>The&nbsp;Beta release of Orleans 2.1 is out on nuget.org. Major performance improvements (up to 30% over 2.0), beta of distributed transaction manager, many other improvements and fixes. No breaking changes.</p>
<p>The release announcement is&nbsp;<a href="https://github.com/dotnet/orleans/releases/tag/v2.1.0-beta1" target="_blank">here</a>.<br />&nbsp;</p>
<h3>Polly: JSON Serialization Plug-In</h3>
<p>Polly released a Json Serialization plug-in for use with Polly CachePolicy. Use Polly.Caching.Serialization.Json in combination with Polly's existing plug-in Polly.Caching.Distributed, and you can automatically serialize the results of any execution to Redis via IDistributedCache. <br /><br />Info is&nbsp;<a href="https://github.com/App-vNext/Polly.Caching.Serialization.Json" target="_blank">here</a>.<br />&nbsp;</p>
<h3>DNN: DNN v 9.2.1 released,&nbsp;EVS is now open source</h3>
<p>Two exciting announcements from the DNN team:&nbsp;<a href="http://www.dnnsoftware.com/community-blog/cid/155601/dnn-921-released" target="_blank">DNN v 9.2.1 has been released</a>, and&nbsp;<a href="http://www.dnnsoftware.com/community-blog/cid/155609/evs-is-now-open-source" target="_blank">EVS&nbsp;is now open source</a>. EVS is the DNN Extension Verification Service; open sourcing it both provides greater visibility into the verification checks as well as allows for community contributions.</p>
<h3>ILMerge has joined the .NET Foundation!&nbsp;</h3>
<p>After many years as a closed-source project, then several years on GitHub in the Microsoft organization, the ILMerge project has moved to the .NET Foundation organization. This will allow more community members to directly contribute. If you are interested,&nbsp;<a href="https://github.com/dotnet/ILMerge" target="_blank">please check it out!</a></p>

<hr />
<h2>Connect with the .NET Foundation online</h2>

<p>The&nbsp;<a href="https://www.facebook.com/dotnetfoundation/">.NET Foundation is on Facebook now</a>. Please like our page! We’ll post regular updates and interesting things happening with .NET to share.</p>

<p>The <a href="https://www.youtube.com/NETFoundation">.NET Foundation is also on YouTube</a>. Watch community standups and design reviews as well as code-focused shows and interviews across our multiple playlists.</p>

<hr />
<h2>Remember to Subscribe!</h2>

<p>Please&nbsp;<a href="http://eepurl.com/dhL_qb">sign up&nbsp;to get the .NET Foundation Update via e-mail</a>.&nbsp;Don’t worry, we want to keep these short, interesting, and low-noise, so we won’t overload your e-mail.</p>
