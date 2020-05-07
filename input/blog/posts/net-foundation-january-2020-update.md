---
Title: .NET Foundation January 2020 Update
Author: Claire Novotny
Published: 2020-02-11
---
<article class="markdown-body entry-content p-3 p-md-6" itemprop="text">
<p>Here's the January 2020 .NET Foundation update. Every month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.</p>

<p>This month's update includes:</p>

<ul>
<li>Foundation Updates</li>
<li>Committee Updates</li>
<li>Project Updates</li>
</ul>

<p>As always, these are available both on our blog and via e-mail: <a href="http://eepurl.com/dhL_qb" rel="nofollow">Sign up to get the .NET Foundation Update via e-mail</a></p>

<h2>Foundation Updates</h2>

<p>The board has decided to hold its meetings on the third Thursday of every month. The next board meeting is scheduled for 2/20. At the last meeting, the board discussed the current action group structure and decided to narrow focus. The new committees will be:</p>

<ul>
<li>Membership - processing new member applications and setting membership policies</li>
<li>Projects - project support requests and processing new project applications</li>
<li>Outreach - anything that touches the broader community, from members to sponsors, speakers, meetup groups</li>
<li>Marketing - Be the megaphone to spread the message of openness in the .NET ecosystem through storytelling, branding, sponsorships and commuinications.</li>
</ul>

<p>The board is working to define a charter and specifics of how each committee will be run. Please participate with the committees by joining them here <a href="https://github.com/orgs/dotnet-foundation/teams">https://github.com/orgs/dotnet-foundation/teams</a>.</p>

<h2>Committee Updates</h2>

<ul>
<li>Marketing committee has started regular meetings for all members and the committee members. Please visit the <a href="https://github.com/dotnet-foundation/wg-marketing">working group repo</a> for information.</li>
<li>Member Content submissions and amplifications - if you'd like to propose writing content or just want to promote something via the @dotnetfdn Twitter handle, <a href="https://github.com/dotnet-foundation/content">submit your content creation and amplificaion requests here</a>.</li>
<li>Projects - Revising our processes for committee participation, reviewing new project applications, onboarding approved projects, and monitoring health of Foundation projects. Working through onboarding tasks for the backlog of recently accepted projects.</li>
</ul>

<h2>.NET Foundation Project Updates</h2>

<h3><a href="https://github.com/cake-build/cake">Cake</a></h3>

<p><a href="https://cakebuild.net/blog/2020/01/cake-v0.36.0-released" rel="nofollow">Cake 0.36.0 version</a></p>

<p>A new year, a new release, this marks the first Cake release for 2020, a release packed with several features, improvements and fixes i.e:</p>

<ul>
<li>.NET Core 3.1 support</li>
<li>New core maintainer</li>
<li>Improved native dependencies support</li>
<li>GitHub actions support</li>
</ul>

<p>Full details in <a href="https://cakebuild.net/blog/2020/01/cake-v0.36.0-released" rel="nofollow">Cake v0.36.0 released</a> blog post.</p>

<p><a href="https://cakebuild.net/blog/2020/02/cake-v0.37.0-released" rel="nofollow">Cake v0.37.0 released</a></p>

<p>The second release for 2020 is here, we've got a few improvements and fixes, highlights:</p>

<ul>
<li><a href="https://www.nuget.org/packages/Cake.Tool/" rel="nofollow">Cake.Tool</a> one million downloads</li>
<li>Improved GitHub action support</li>
<li>Support for latest GitReleaseManager features</li>
<li>Improved stack traces for exceptions</li>
</ul>

<p>Full details in <a href="https://cakebuild.net/blog/2020/02/cake-v0.37.0-released" rel="nofollow">Cake v0.37.0 released</a> blog post.</p>

<h3><a href="https://nunit.org/" rel="nofollow">NUnit</a></h3>

<p>This month brought releases for two of our projects:</p>

<p><strong>NUnit VSTest Adapter 3.16.0</strong> (<a href="https://github.com/nunit/docs/wiki/Adapter-Release-Notes#nunit3-test-adapter-for-visual-studio---version-3160---january-3-2020">release notes</a>) and <strong>3.16.1</strong> (<a href="https://github.com/nunit/docs/wiki/Adapter-Release-Notes#nunit3-test-adapter-for-visual-studio---version-3161---january-16-2020">release notes</a>). Major changes in 3.16:</p>

<ul>
<li>
<p>Support has been removed for .NET Core 1.* which is no longer supported by Microsoft. If you do have .NET Core 1.* solutions and can't upgrade, you should stay with version 3.15.1 or lower of the adapter.</p>
</li>
<li>
<p>The filter syntax issues we've had with special names and characters have been mostly solved thanks to excellent work by <a href="https://github.com/johnmwright">John M. Wright</a>. See <a href="https://github.com/nunit/nunit3-vs-adapter/pull/668">PR 668</a> for a detailed explanation of what has been done.</p>
</li>
<li>
<p>You can now use the NUnit filter syntax, either from command line or through settings in the runsettings file. The idea and implementation were provided by <a href="https://github.com/mletterle">Michael Letterle</a> who wrote a <a href="http://blog.prokrams.com/2019/12/16/nunit3-filter-dotnet/" rel="nofollow">great blogpost</a> to explain how this works and how he arrived at the solution.</p>
</li>
</ul>

<p><strong>NUnit Console and Engine 3.11</strong> (<a href="https://github.com/nunit/docs/wiki/Console-Release-Notes#nunit-console-311---january-26-2020">release notes</a>). This release fixes a range of minor bugs and includes a significant amount of internal restructuring work. In future, this will enable improved .NET Standard support in the engine and a .NET Core build of the console.</p>

<h3><a href="https://github.com/App-vNext/Polly">Polly</a></h3>

<p>From the Polly community this month:</p>

<p>Updates to <strong>Simmy</strong> (<a href="https://github.com/Polly-Contrib/Simmy">github</a>; <a href="https://www.nuget.org/packages/Polly.Contrib.Simmy" rel="nofollow">nuget</a>), our sister project for <strong>chaos-engineering integrated with Polly</strong>. Version 0.3 released:</p>

<ul>
<li>New Fluent-builder syntax for easier configuration</li>
<li>.NET Core 3.1 support</li>
</ul>

<p><strong>Polly.Contrib.DuplicateRequestCollapser</strong> (<a href="https://github.com/Polly-Contrib/Polly.Contrib.DuplicateRequestCollapser">github</a>; <a href="https://www.nuget.org/packages/Polly.Contrib.DuplicateRequestCollapser/" rel="nofollow">nuget</a>): a new Polly policy to <a href="https://github.com/App-vNext/Polly/wiki/Avoiding-cache-repopulation-request-storms">avoid downstream request storms</a> when repopulating expensive cache items in high-throughput systems. <code>Polly.Contrib.DuplicateRequestCollapser</code> <a href="https://github.com/Polly-Contrib/Polly.Contrib.DuplicateRequestCollapser/blob/master/README.md">collapses concurrent duplicate requests into a single downstream call</a>.</p>

<h2>Meetups</h2>

<p><strong>Our .NET Foundation sponsored <a href="https://www.meetup.com/pro/dotnet" rel="nofollow">.NET Meetup Pro groups</a> are continuing to grow worldwide.</strong> Here are some quick stats:*</p>

<ul>
<li>348 Groups</li>
<li>61 Countries</li>
<li>272K Members</li>
</ul>

<p>Our .NET Meetup Pro group helps developers find your group, as well as get involved with local events like .NET Conf Local. If your meetup hasn't joined yet, you can <a href="https://aka.ms/add-dotnet-meetup" rel="nofollow">right here</a>.</p>

<p><a href="/assets/74241694-64015800-4c91-11ea-9431-736bc05717a0.png" rel="noopener noreferrer" target="_blank"><img alt="Map of meetup group locations" src="assets/posts/74241694-64015800-4c91-11ea-9431-736bc05717a0.png" style="max-width:100%;" /></a></p>
</article>
