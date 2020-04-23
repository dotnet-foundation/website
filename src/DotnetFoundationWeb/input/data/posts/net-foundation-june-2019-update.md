LayoutRef: blog
Title: .NET Foundation June 2019 Update
Author: Jon Galloway
Published: 2019-06-28 20:42:12.9297569
Visible: true
---
<p>Here's the June 2019 .NET Foundation update. Every month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.<br />
<br />
This month's newsletter includes:</p>

<ul>
<li>Join an Action Group!</li>
<li>.NET will be at OSCON</li>
<li>Save the Date for .NET Conf 2019</li>
<li>.NET Foundation Project Updates</li>
<li>Meetups</li>
</ul>

<p>As always, these are available both on our blog and via e-mail:&nbsp;<a href="http://eepurl.com/dhL_qb">Sign up to get the .NET Foundation Update via e-mail</a></p>

<hr />
<h2>Join an Action Group!</h2>

<p>Last month, we <a href="/blog/2019/05/31/net-foundation-may-2019-update">announced our new Action Groups</a>: a way for .NET Foundation members to join teams and get directly involved in helping the .NET Foundation scale to the next level. Our teams include the following:</p>

<ul>
<li>Communications</li>
<li>Corporate Relations</li>
<li>Marketing</li>
<li>Membership</li>
<li>Outreach</li>
<li>Project Support</li>
<li>Speakers and Meetups</li>
<li>Technical Review</li>
</ul>

<p>We've been figuring out logistics and communications as we move to working publicly and with a large team. We've settled on <a href="https://github.com/dotnet-foundation">GitHub Organizational Teams</a> and will be communicating out to the individual teams over the next few weeks.<br />
<br />
If you're a .NET Foundation Member, sign up to join an action group:</p>

<p><a class="site-button site-button--pink" href="https://forms.office.com/Pages/ResponsePage.aspx?id=3G8HFsH8FUqxyjLJolWQDu3r3uMrwH1HjiQupxbALB5UNkhFNzJEVFVXMFQ4R0E3Nk5NVkNYOVpMSi4u">Sign Up For An Action Group</a></p>

<hr />
<h2>.NET Foundation will be at OSCON</h2>

<p>.NET Foundation will have a session at <a href="https://conferences.oreilly.com/oscon/oscon-or">OSCON</a> in Portland, July 15<sup>th</sup> – 18<sup>th</sup>. We’ll be talking about the importance of open source software foundations. If you’re headed there, please come see us! We’ll also have .NET presence at the Microsoft booth in the form of coding challenges, SWAG and experts you can chat with there.</p>

<hr />
<h2><strong>.NET Conf 2019, September 23-25 (<a href="http://www.dotnetconf.net">www.dotnetconf.net</a>)</strong></h2>

<p><a href="https://www.dotnetconf.net"><img src="assets/posts/d115925b-2ca7-48bd-8259-9afd54bd4dfe.png" /></a></p>

<p>.NET Conf is our annual, free, online virtual event and this year and it’s going to be bigger than ever. .NET Core 3.0 will launch at .NET Conf!<br />
<br />
<strong>The .NET Conf Call for Speakers is now open.</strong> This is your chance to present to the world-wide .NET Community remotely from your own time-zone. Head to <a href="http://www.dotnetconf.net">www.dotnetconf.net</a> to learn more and save the date!</p>

<hr />
<h2>.NET Foundation Project Updates</h2>

<h3><a href="https://www.dotvvm.com/blog/58/Announcing-DotVVM-and-Business-Pack-2-3-0">DotVVM 2.3 Released</a></h3>

<p>DotVVM 2.3 brings several performance improvements and fixes, including a new API for local redirects and asynchronous loading of GridView.</p>

<h3><a href="http://www.thepollyproject.org/2019/06/27/simmy-the-monkey-for-making-chaos/">Simmy - chaos-engineering integrated with Polly</a></h3>

<p>Simmy (<a href="https://github.com/Polly-Contrib/Simmy">github</a>; <a href="https://www.nuget.org/packages/Polly.Contrib.Simmy">nuget</a>) is a new chaos-engineering and fault-injection tool from the Polly team and some <a href="http://elvanydev.com">awesome contributors</a>. Integrating with the Polly resilience project for .NET, Simmy lets you inject chaos into your calls to any third party system. Exceptions, fault code responses, or additional latency can all be injected into calls. Control parameters let you target which calls will be affected and how frequently, and a master on/off switch per call-path lets you turn chaos experiments on and off safely.</p>

<ul>
<li><em>Blog introduction: <a href="http://www.thepollyproject.org/2019/06/27/simmy-the-monkey-for-making-chaos/">Simmy, the monkey for making chaos</a></em>&nbsp;</li>
<li><em>Simmy repo:&nbsp;</em><a href="https://github.com/Polly-Contrib/Simmy">https://github.com/Polly-Contrib/Simmy</a></li>
<li><em>Simple sample app:</em><a href="https://github.com/Polly-Contrib/Polly.Contrib.SimmyDemo_WebApi">https://github.com/Polly-Contrib/Polly.Contrib.SimmyDemo_WebApi</a></li>
<li><em>Full demo with microservices in docker</em>: <a href="https://github.com/vany0114/chaos-injection-using-simmy">https://github.com/vany0114/chaos-injection-using-simmy</a></li>
</ul>

<h3><a href="https://github.com/dnnsoftware/Dnn.Platform">DNN Platform Readies 9.4.0 Release</a></h3>

<p>As part of the first step to adding support for ASP.NET Core, the DNN Platform project is releasing version 9.4.0 with initial support for ASP.NET Core dependency injection. Numerous additional improvements have been included as well, including more than 100 unique contributions from 30 members of the community.</p>

<h3><a href="https://www.dnnsummit.org/Blog/dnn-summit-2020-call-for-speakers-is-open">DNN Summit 2020: Call for Speakers</a></h3>

<p>DNN Summit 2020 Call for Speakers has now opened. Conference will be held in Orlando, Florida Feb 24-27, 2020.</p>

<h3><a href="https://github.com/reactiveui/ReactiveUI/releases/tag/9.18.1">ReactiveUI 8.18.1 Released</a></h3>

<p>ReactiveUI 9.18.1 has been released and we have officially added @UnoPlatform support to ReactiveUI. You can find the NuGet packages under ReactiveUI.Uno -- please report any bugs since this is fairly new support.</p>

<h3><a href="https://github.com/reactiveui/Pharmacist">Announcing Pharmacist</a></h3>

<p>Announcing Pharmacist, maintained by the ReactiveUI team. It's a tool for converting Events into Observables. Observables being linq composible events that you can manipulate onto different threads and other processes, allow you to much easier abstract the events from your Views.&nbsp;</p>

<p>Pharmacist allows you to include a NuGet package, and it'll scan any referenced NuGet in the current project and generate Observable wrappers for all events found.</p>

<p>Pharmacist is being used within ReactiveUI to generate our event wrappers for all the various platforms now such as Xamarin Forms, Uno, Android, WPF, WinForms.</p>

<p>Pharmacist is built on top of Roslyn and System.Reflection.Metadata technologies.</p>

<hr />
<h2>Meetups</h2>

<p><strong>Our .NET Foundation sponsored&nbsp;<a href="https://www.meetup.com/pro/dotnet">.NET Meetup Pro groups</a> are continuing to grow worldwide.</strong> Here are some quick stats:</p>

<ul>
<li>298&nbsp;Groups</li>
<li>60 Countries</li>
<li>222K Members</li>
</ul>

<p>Our .NET Meetup Pro group helps developers find your group, as well as get involved with local events like .NET Conf Local. If your meetup hasn't joined yet, you can&nbsp;<a href="https://aka.ms/add-dotnet-meetup">right here.</a><br />
.</p>

<p><img src="assets/posts/8fd1e465-9efa-4fc0-8c0f-60b7f5373ba3.jpg" /></p>

<hr />
<h3>Connect with the .NET Foundation online</h3>

<p>The&nbsp;<a href="https://www.facebook.com/dotnetfoundation/">.NET Foundation is on Facebook now</a>. Please like our page! We’ll post regular updates and interesting things happening with .NET to share.</p>

<p><a href="https://www.youtube.com/NETFoundation">The .NET Foundation is also on YouTube</a>. Watch community standups and design reviews as well as code-focused shows and interviews across our multiple playlists.</p>

<hr />
<h3>Remember to Subscribe!</h3>

<p>Please&nbsp;<a href="http://eepurl.com/dhL_qb">sign up to get the .NET Foundation Update via e-mail</a>. Don’t worry, we want to keep these short, interesting, and low-noise, so we won’t overload your e-mail.</p>
