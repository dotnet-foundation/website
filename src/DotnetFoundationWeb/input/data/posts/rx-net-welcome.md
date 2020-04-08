LayoutRef: blog
Title: Welcoming Reactive Extensions for .NET
Author: 
Published: 2016-06-16 18:16:00.0000000
---
<p>I'm proud to announce that<a href="https://github.com/Reactive-Extensions/Rx.NET"> Reactive Extensions for .NET</a> has joined the <a href="http://dotnetfoundation.org/">.NET Foundation</a>&nbsp;Family. While <a href="https://github.com/Reactive-Extensions/Rx.NET">Rx.NET</a>&nbsp;has been open source for a long time, this move signifies that the project is moving from one driven primarily by Microsoft to true cross-community ownership. Legends of .NET open source, <a href="https://github.com/onovotny">Claire Novotny</a>&nbsp;and<a href="https://github.com/shiftkey">Brendan Forster</a>&nbsp;join <a href="https://github.com/bartdesmet">Bart De Smet</a>&nbsp;and&nbsp;<a href="https://twitter.com/mattpodwysocki">Matthew Podwysocki</a>&nbsp;as the new maintainers of the project so you know it's in the very best&nbsp;hands in the business.</p>

<p>We'll all be working to move things over in the next few days as we all get ready for the big 1.0 of .NET Core. In this guest post, Oren explains more about the move and what it means for the project.&nbsp;</p>

<p>-- Martin</p>

<h2>Announcing Rx and Ix 3.0</h2>

<p>I'm honored to be one of the community maintainers alongside <a href="https://github.com/shiftkey">Brendan Forster</a>, joining <a href="https://github.com/bartdesmet">Bart De Smet</a>,&nbsp;<a href="https://twitter.com/mattpodwysocki">Matthew Podwysocki</a>&nbsp;and the&nbsp;team of reactive luminaries on this project.</p>

<p>The first thing to announce is that work has been ongoing to bring .NET Core support for Rx.NET and Ix.NET. The code is in a public beta form right now and you can check out the <a href="https://myget.org/gallery/rxnet">CI MyGet feed</a>&nbsp;for regular builds. We'll have an RC2-compatible build on NuGet.org shortly and expect to GA alongside the rest of .NET Core on June 27.</p>

<p>Learn more about Reactive Programming with Rx over at <a href="http://reactivex.io/">http://reactivex.io/</a></p>

<h2>Breaking Changes</h2>

<p>There are two breaking changes to note in V3:</p>

<ol>
<li>Rx has a new Strong Name Key. This means that code must be recompiled against this new version; binding redirects will not work. The good news is that the SNK is now checked into the repository, so you can create private builds that are fully signed should you need to. This was not possible before as the existing SNK was the same key as the .NET Framework.<br /><br /></li>
<li>The NuGet package names have changed. The <code>Rx-*</code> and <code>Ix-*</code> packages have been renamed to match their library names, keeping <g class="gr_ gr_42 gr-alert gr_spell gr_run_anim ContextualSpelling" id="42" data-gr-id="42">inline</g> with the rest of .NET Core. <br />- Use <code>System.Reactive</code> instead of <code>Rx-Main</code><br />- Use <code>System.Interactive</code> instead of <code>Ix-Main</code><br />- Use <code>System.Interactive.Async</code> instead of <code>Ix-Async</code></li>
</ol>

<p>If you find any issues, please file them over on <a href="https://github.com/Reactive-Extensions/Rx.NET/issues">GitHub</a>. After we've got the V3.0 release out the door we're going to start working through the backlog that has built up in the project so please bear with us until the end of June while we get the initial community driven release out the door. &nbsp;<a href="https://github.com/Reactive-Extensions/Rx.NET/">Come on over</a> if you want to help out!</p>

<p><em>Claire Novotny, Co-Maintainer, Reactive Extensions for .NET</em></p>
