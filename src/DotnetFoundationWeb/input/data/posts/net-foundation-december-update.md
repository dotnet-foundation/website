LayoutRef: blog
Title: .NET Foundation December Update
Author: Jon Galloway
Published: 2019-01-01 00:30:08.6224590
Visible: true
---
<p>Here's the December edition of the .NET Foundation newsletter. Every month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.<br />
<br />
This month's newsletter includes:</p>

<ul>
<li>A recap of our announcements at the Microsoft Connect event: Open Membership and Corporate Sponsorship</li>
<li>News from .NET Foundation member projects</li>
<li>.NET Meetup news</li>
</ul>

<p>As always, these are available both on our blog and via e-mail:&nbsp;<a href="http://eepurl.com/dhL_qb">Sign up to get the .NET Foundation Update via e-mail</a></p>

<hr />
<h2>.NET Foundation Announcements at Microsoft Connect(); 2018</h2>

<h3>.NET Foundation Open Membership</h3>

<p><a href="https://channel9.msdn.com/Events/Connect/Microsoft-Connect--2018/K120"><img alt="" src="assets/posts/connect-dnf.png" style="width: 1067px; height: 597px;" /></a></p>

<p>At the&nbsp;<a href="https://news.microsoft.com/connect-2018/">Microsoft Connect</a>&nbsp;event earlier this month, we made&nbsp;<a href="/blog/2018/12/04/announcing-net-foundation-open-membership">two pretty big announcements</a>. The first is open membership: we're expanding the .NET Foundation by inviting the entire open source community to take a more active role, to directly guide foundation operations and build the ecosystem. If you've contributed to a .NET Foundation open source project, you can&nbsp;<a href="/member/become-a-member">apply to become a voting member today!</a></p>

<p>We're expanding the board from three to seven members, with one single seat appointed by Microsoft and the remaining six elected by the community. Board elections will begin in January 2019, and any person who has contributed to a.NET Foundation open source project is eligible to run for the board and to vote. This new structure will help the .NET Foundation scale with the growing .NET open source ecosystem and allows our entire community to get a lot more involved.</p>

<p>We're going to be posting more information about membership and board elections in early January - watch our <a href="/blog">blog </a>and <a href="http://www.twitter.com/dotnetfdn">@dotnetfdn</a> Twitter account for updates.</p>

<h3>.NET Foundation Corporate Sponsor Program</h3>

<p>We also announced that we're expanding our Technical Steering Group to a Corporate Sponsor Program. In addition to our current sponsors – Red Hat, JetBrains, Google, Unity, Microsoft, and Samsung, we are also welcoming&nbsp;<a href="https://content.pivotal.io/blog/you-re-investing-in-net-and-so-are-we-pivotal-is-now-a-corporate-sponsor-of-the-net-foundation">Pivotal</a>,&nbsp;<a href="https://www.telerik.com/blogs/progress-announces-support-visual-studio-2019-net-core-3-net-foundation-more">Progress Telerik</a>, and&nbsp;<a href="https://www.insight.com/">Insight</a>. Our corporate sponsors will be contributing annual dues, which will both increase the funds available and diversify our funding (rather than relying solely on donations from Microsoft).</p>

<p>Combined, the Open Membership and Corporate Sponsor Program set us up for a really exciting 2019!</p>

<hr />
<h2>.NET Announcements from Microsoft Connect();&nbsp;</h2>

<p>At the <a href="https://news.microsoft.com/connect-2018/" target="_blank">Microsoft Connect</a> (along with the <a href="https://aka.ms/dnfmemberupdate" target="_blank">.NET Foundation announcements</a> we called out above) there were some other big .NET product announcements. Here's some links to the highlights, or if you have some time you can watch the keynote videos <a href="https://channel9.msdn.com/Events/Connect/Microsoft-Connect--2018" target="_blank">here</a>.</p>

<h3>.NET Core 2.2 Released</h3>

<p><a href="https://blogs.msdn.microsoft.com/dotnet/2018/12/04/announcing-net-core-2-2/" target="_blank">.NET Core 2.2 was released</a>, including diagnostic improvements to the runtime, support for ARM32 for Windows and Azure Active Directory for SQL Client. The <a href="https://blogs.msdn.microsoft.com/webdev/2018/12/04/asp-net-core-2-2-available-today/" target="_blank">biggest improvements in this release are in ASP.NET Core</a>.</p>

<h3>.NET Core 3 Preview 1</h3>

<p><a href="https://blogs.msdn.microsoft.com/dotnet/2018/12/04/announcing-net-core-3-preview-1-and-open-sourcing-windows-desktop-frameworks/" target="_blank">.NET Core Preview 1 was announced</a>. .NET Core 3 is a major update which adds support for building Windows desktop applications using Windows Presentation Foundation (WPF), Windows Forms, and Entity Framework 6 (EF6). ASP.NET Core 3 enables client-side development with Razor Components. EF Core 3 will have support for Azure Cosmos DB. It will also include support for C# 8 and .NET Standard 2.1 and much more!</p>

<h3>WPF, Windows Forms, and WinUI Open Sourced</h3>

<p>Whoa! Along with .NET Core 3.0 Preview 1's support for WPF and Windows Forms, <a href="http://aka.ms/windevconnect" target="_blank">Microsoft announced that WPF, Windows Forms, and Windows UI XAML Library (WinUI) are now open source</a>!</p>

<hr />
<h2>.NET Foundation Project News</h2>

<h3>Cake Version 0.31.0 Release</h3>

<p><a href="https://cakebuild.net/blog/2018/12/cake-v0.31.0-released" target="_blank">Cake version 0.31.0 has been released</a>&nbsp;with new features including improved file globbing, Mono fall back for .NET executables on .NET Core, NuGet improvements and much more.</p>

<h3>Orleans 2.2.0 release</h3>

<p><a href="https://github.com/dotnet/orleans/releases/tag/v2.2.0" target="_blank">Orleans 2.2.0</a>&nbsp;is primarily about bringing support for ACID cross-grain transactions to production-ready quality. This enables scalable distributed transactions, even across disparate non-transactional data stores.<br />
<br />
This release also includes a number of other improvements and fixes, but no breaking changes. It is backward compatible with 2.0.* releases, which allows for in-place upgrade of a running cluster.</p>

<h3>NUnit Test Adapter 3.12 Release</h3>

<p><a href="https://github.com/nunit/docs/wiki/Adapter-Release-Notes" target="_blank">Version 3.12 of the NUnit Test adapter has been released</a>. This release adds the&nbsp;<a href="https://github.com/nunit/nunit3-vs-adapter/issues/215" target="_blank">ability to generate results in the NUnit3 XML format</a>&nbsp;and includes a newer version of the NUnit engine.<br />
<br />
Thanks to Ori Ashual for contributions to the docs and Matti Petrelius, Alex (ahoisl), Phillip Carter, Tom PoLáKoSzm, and Oleksandr Liakhevych as well as our maintainers for improvements to the framework and tooling, and especially Mikkel Nylander Bundgaard and Ace Olszowka for their work on the NUnit Analyzers project!</p>

<hr />
<h2>Meetups</h2>

<p>Our .NET Foundation sponsored&nbsp;<a href="https://www.meetup.com/pro/dotnet" target="_blank">.NET Meetup Pro groups</a>&nbsp;continue to grow: <strong>we just passed 150K members!</strong>Here are some quick stats:</p>

<ul>
<li>243 Groups</li>
<li>51 Countries</li>
<li>150.5K Members</li>
</ul>

<p><a href="https://www.meetup.com/pro/dotnet"><img alt="" src="assets/posts/dnf-meetups-dec18.jpg" style="width: 819px; max-width: 100%;" /></a></p>

<p>We've also started sending newsletters to Meetup organizers, including some links for some free swag for their groups. If your meetup hasn't joined yet, you can&nbsp;<a href="https://aka.ms/add-dotnet-meetup">right here</a>.</p>

<hr />
<h2>Connect with the .NET Foundation online</h2>

<p>The&nbsp;<a href="https://www.facebook.com/dotnetfoundation/">.NET Foundation is on Facebook now</a>. Please like our page! We’ll post regular updates and interesting things happening with .NET to share.</p>

<p>The <a href="https://www.youtube.com/NETFoundation">.NET Foundation is also on YouTube</a>. Watch community standups and design reviews as well as code-focused shows and interviews across our multiple playlists.</p>

<hr />
<h2>Remember to Subscribe!</h2>

<p>Please&nbsp;<a href="http://eepurl.com/dhL_qb">sign up&nbsp;to get the .NET Foundation Update via e-mail</a>.&nbsp;Don’t worry, we want to keep these short, interesting, and low-noise, so we won’t overload your e-mail.</p>
