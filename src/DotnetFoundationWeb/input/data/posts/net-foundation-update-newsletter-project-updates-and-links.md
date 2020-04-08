LayoutRef: blog
Title: .NET Foundation Update&#58; Newsletter, Project Updates, and links!
Author: Jon Galloway
Published: 2018-01-17 22:24:00.0000000
---
<p>Welcome to the first of a series: our regular .NET Foundation updates! We’ll be posting these on our blog, but to make sure you don’t miss one, please subscribe to get them via e-mail.</p>

<p><a class="btn btn-ar btn-primary" href="http://eepurl.com/dhL_qb">Sign up to get the .NET Foundation Update via e-mail</a></p>

<p>We’re planning to send these out at the beginning of every month going forward, so that means you should see the February one in just a few weeks. Don’t worry, we want to keep these short, interesting, and low-noise, so we won’t overload your e-mail.</p>

<h2>.NET Foundation Updates</h2>

<h3>Meetups</h3>

<p class="media"><a href="https://www.meetup.com/pro/dotnet" target="_blank"><img class="media-left" src="assets/posts/meetupmap_1-2018.png" /></a>The .NET Foundation has sponsored a <a href="https://www.meetup.com/pro/dotnet">.NET Meetup Pro group</a> and now has over 100 member groups. If you’re looking for a .NET Meetup in your area, this should help you find Meetups that are focused on .NET; if you run a .NET meetup we’ll pay for your Meetup Pro membership.</p>

<p class="clearfix">Please help connect us with other groups you're aware of that haven't joined yet by dropping me a note <a href="mailto:jon@dotnetfoundation.org">jon@dotnetfoundation.org</a> or leaving a comment below.​</p>

<hr class="color dashed" />
<h3>Open Collective</h3>

<p class="media"><a href="https://opencollective.com/" target="_blank"><img class="media-right" src="assets/posts/opencollective_logo.png" /></a></p>

<p>One issue many open source projects deal with is handling finances in an open source friendly way. We've set up an umbrella organization under Open Collective to make it easier for your projects to accept money (donations, sponsorships, bounties) and to make payments in an open, transparent way. For an example of an open source project where this has worked really well, see the webpack Open Collective: <a href="https://opencollective.com/webpack">https://opencollective.com/webpack</a>. Open Collective's model is that a parent institution (in this case, .NET Foundation) holds the money for you. This is especially useful for community projects with several owners who don't want to deal with deciding who holds the money and dealing with accounting, reporting to the community, etc.</p>

<p>You obviously have other options, and I'd encourage you to do whatever makes the most sense for your project. For instance, in working with the IdentityServer team, we agreed that Patreon made more sense for them (<a href="https://www.patreon.com/identityserver">https://www.patreon.com/identityserver</a>).</p>

<p>If you host a .NET Meetup or run a .NET Foundation project and would like to get set up with Open Collective, e-mail me at <a href="mailto:jon@dotnetfoundation.org">jon@dotnetfoundation.org</a>.</p>

<h3>CLA System Upgrade</h3>

<p>One of the technical services we offer .NET Foundation projects is access to our Contributor License Agreement (CLA) automation system for GitHub pull requests. We’ve recently completed a pretty significant upgrade from our previous legacy system. The new system is build on the open source <a href="https://cla-assistant.io/">CLA Assistant</a>&nbsp; project and is a lot more reliable and easy to maintain. Users will have a better experience since they can just click through in the browser (no need to use DocuSign). Project owners will see less noise on the repo as the CLA messaging is cleanly integrated into the GitHub required pull request review steps and doesn't add status comments to the pull request.</p>

<p>One of the features of the new system is that it's easier to add new projects. We’re still working through getting some new projects onboarded, but it’s a much simpler process now.</p>

<hr class="color dashed" />
<h2>.NET Foundation Project News</h2>

<h3>UWP Community Toolkit</h3>

<p>The UWP Community Toolkit was recently updated to v2.1 which introduced new helpers for composition animations and visuals, new DockPanel control, support for new FCU controls and more to simplify and demonstrates common developer tasks building apps for Windows 10. Contributors are always welcomed to submit issues or pull request to add new awesome features.</p>

<p>More information on the <a href="https://blogs.windows.com/buildingapps/2017/11/22/uwp-community-toolkit-v2-1/#kfhcKrsjLg1o8VGi.97">new UWP Community Toolkit release is in this announcement post</a>.</p>

<h3>BenchmarkDotNet<img align="right" src="assets/posts/benchmarkdotnet_logo.png" /></h3>

<p>BenchmarkDotNet v0.10.12 has been released!</p>

<p>There are a lot of improvements in the main .NET benchmarking tool:</p>

<ul>
<li>New TailCallDiagnoser: now you get notifications when JIT applies the tail call optimizations to your methods.</li>
<li>Improved MemoryDiagnoser: it has a better precision level, and it takes less time to evaluate memory allocations in a benchmark.</li>
<li>Improved DisassemblyDiagnoser: BenchmarkDotNet contains an embedded disassembler so that it can print assembly code for all benchmarks; it's not easy, but the disassembler evolves in every release.</li>
<li>Better environment info: when your share performance results, it's very important to share information about your environment. The library generates the environment summary for you by default. Now it contains information about the amount of physical CPU, physical cores, and logic cores. If you run a benchmark on a virtual machine, you will get the name of the hypervisor (e.g., Hyper-V, VMware, or VirtualBox).</li>
<li>Better summary table: one of the greatest features of BenchmarkDotNet is the summary table. It shows all important information about results in a compact and understandable form. Now it has better customization options: you can display relative performance of different environments (e.g., compare .NET Framework and .NET Core) and group benchmarks by categories.</li>
<li>Other minor improvements and bug fixes</li>
</ul>

<p>Read more in <a href="http://aakinshin.net/blog/post/bdn-v0_10_12/">this announcement post</a>.</p>

<h3>Polly</h3>

<p>Major new features <a href="https://github.com/App-vNext/Polly/wiki">added to Polly over the last few months</a> include:<img align="right" src="assets/posts/polly_logo.png" /></p>

<ul>
<li>CachePolicy - allowing you to introduce cache-aside as a stability and performance pattern for calls governed by Polly.&nbsp; Any third-party cache or serializer can be plugged in, via interfaces, so you can hook in your favourites.&nbsp; <a href="https://github.com/App-vNext/Polly/wiki/Cache">https://github.com/App-vNext/Polly/wiki/Cache</a></li>
<li>Handling InnerExceptions natively - policies can now extract and handle InnerExceptions that may be buried deep within the kind of nested AggregateExceptions or InnerExceptions generated when using async/await or the Task Parallel Library. <a href="https://github.com/App-vNext/Polly/wiki/Handling-InnerExceptions-and-AggregateExceptions">https://github.com/App-vNext/Polly/wiki/Handling-InnerExceptions-and-AggregateExceptions</a></li>
<li>PolicyRegistry - supports separation of concerns between policy configuration and usage, and promotes the use of Polly with dependency injection.&nbsp; <a href="https://github.com/App-vNext/Polly/wiki/PolicyRegistry">https://github.com/App-vNext/Polly/wiki/PolicyRegistry</a></li>
</ul>

<p>Next on the roadmap is enabling policies to emit events which could be streamed (for example by Rx) as telemetry to dashboards.</p>

<hr class="color dashed" />
<h2>Community Links and News</h2>

<p>The <a href="https://www.facebook.com/dotnetfoundation/">.NET Foundation is on Facebook now</a>. Please like our page! We’ll post regular updates and interesting things happening with .NET to share.</p>

<p><iframe allowtransparency="true" frameborder="0" height="65" scrolling="no" src="https://www.facebook.com/plugins/like.php?href=https%3A%2F%2Fwww.facebook.com%2Fdotnetfoundation%2F&amp;width=63&amp;layout=button&amp;action=like&amp;size=large&amp;show_faces=true&amp;share=false&amp;height=65&amp;appId=8683731822" style="border: currentcolor; border-image: none; overflow: hidden;" width="63"></iframe></p>

<p>Recently Matt Warren, a .NET MVP, wrote up this pretty interesting post on Open Source .NET - 3 Years Later (<a href="http://mattwarren.org/2017/12/19/Open-Source-.Net-3-years-later)">http://mattwarren.org/2017/12/19/Open-Source-.Net-3-years-later)</a> . In the post, he highlights the community's involvement in .NET repositories. It’s amazing to see the growth we’ve achieved in just three years. I’m very encouraged by our fantastic community contributing to .NET open source.</p>

<p><a href="https://www.youtube.com/NETFoundation" target="_blank">The .NET Foundation is also on YouTube</a>. Watch community standups and design reviews as well as code-focused shows and interviews across our multiple playlists.</p>

<p><a class="btn-social solid youtube" href="https://www.youtube.com/NETFoundation">Youtube</a></p>

<p>Do you have an interesting piece of news or content related to .NET open source? Let us know so we can include it in next month’s update by posting a comment below.</p>

<hr class="color dashed" />
<h2>Remember to Subscribe!</h2>

<p>Please <a href="http://eepurl.com/dhL_qb">sign up</a> to get the .NET Foundation Update via e-mail.</p>

<p><a class="btn btn-ar btn-primary" href="http://eepurl.com/dhL_qb">Subscribe</a></p>

<p>We’re planning to send these out at the beginning of every month going forward, so that means you should see the February one in just a few weeks. Don’t worry, we want to keep these short, interesting, and low-noise, so we won’t overload your e-mail.</p>
