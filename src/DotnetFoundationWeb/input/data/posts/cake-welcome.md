LayoutRef: blog
Title: Free as in Cake
Author: 
Published: 2016-06-09 18:16:00.0000000
Visible: true
---
<p>I love most forms of Cake and I've also been a bit of a build automation nut for nearly two decades now. So you can imagine my delight when I was able to combine these two passions with the <a href="http://cakebuild.net/">CakeBuild.net</a>&nbsp;project. At <a href="http://ndcoslo.com/talk/having-your-cake-and-eating-it-too/">NDC Oslo today</a>, <a href="https://github.com/gep13">Gary Ewan Park</a>&nbsp;from the Cake project team&nbsp;<a href="http://ndcoslo.com/talk/having-your-cake-and-eating-it-too/">announced </a>that Cake was joining the .NET Foundation family. In this guest post, <a href="https://github.com/gep13">Gary</a>&nbsp;explains more about the project. If it looks like it will be useful to you, I encourage you to <a href="http://cakebuild.net/">give it a try</a>&nbsp;and <a href="https://github.com/cake-build">get involved</a>&nbsp;in the growing community.</p>

<p>--Martin</p>

<h2>What is Cake?</h2>

<p><g class="gr_ gr_72 gr-alert gr_gramm gr_run_anim Grammar multiReplace" id="72" data-gr-id="72">Cake</g> is a <g class="gr_ gr_66 gr-alert gr_spell gr_run_anim ContextualSpelling ins-del multiReplace" id="66" data-gr-id="66">cross platform</g> build automation system, built on top of Roslyn and the Mono Compiler, which uses C# as the scripting language.</p>

<p>Currently, it supports running builds on:</p>

<ul>
<li>Windows</li>
<li>Linux</li>
<li>OS X</li>
</ul>

<p><img width="801" height="635" alt="" src="assets/posts/cake-screenshot.png" style="display: block; margin-left: auto; margin-right: auto;" /></p>

<h2>Why use C#? Aren't there already other build systems out there?</h2>

<p>We firmly believe that creating a reliable and maintainable build automation script is best done in the same language as the application that you are building. For example, if you are working on a Powershell project, it might make sense to use something like <a href="https://github.com/psake/psake"><g class="gr_ gr_78 gr-alert gr_spell gr_run_anim ContextualSpelling ins-del multiReplace" id="78" data-gr-id="78">psake</g></a>. If doing a web application, perhaps something like <a href="https://github.com/gulpjs/gulp"><g class="gr_ gr_79 gr-alert gr_gramm gr_run_anim Grammar only-ins doubleReplace replaceWithoutSep" id="79" data-gr-id="79">gulp</g></a>. Working on <g class="gr_ gr_81 gr-alert gr_gramm gr_run_anim Grammar multiReplace" id="81" data-gr-id="81">an F#</g> project, you might want to use <a href="https://github.com/fsharp/FAKE">FAKE</a>.</p>

<p>Although we agree that being a polyglot developer is definitely a good thing, using a build script as a mechanism to <g class="gr_ gr_87 gr-alert gr_spell gr_run_anim ContextualSpelling" id="87" data-gr-id="87">pickup</g> a new language is not the best approach. This normally leads to two things:</p>

<ul>
<li>lack of adoption of that language across the team that you are working in</li>
<li>only one person, the person who started it, being in charge of said build script</li>
</ul>

<p>Rather, if the build script is written in the same primary language of the project, then everyone on the team can be immediately effective at altering/fixing that <g class="gr_ gr_93 gr-alert gr_gramm gr_run_anim Grammar multiReplace" id="93" data-gr-id="93">build</g> script.</p>

<p>Become immediately effective</p>

<p>On top of the fact that Cake allows you to create build scripts using a common language, out of the box, it has support for almost 30 of the most common build tools, including:</p>

<ul>
<li>MSBuild</li>
<li>NUnit</li>
<li>XUnit</li>
<li>WiX</li>
<li>GitVersion</li>
<li>many others...</li>
</ul>

<p>In addition, thanks to our growing and dedicated community members, we have almost 40 other build tools available via the <g class="gr_ gr_74 gr-alert gr_spell gr_run_anim ContextualSpelling ins-del multiReplace" id="74" data-gr-id="74">addin</g> mechanism which is baked into Cake. These <g class="gr_ gr_75 gr-alert gr_spell gr_run_anim ContextualSpelling ins-del multiReplace" id="75" data-gr-id="75">addins</g> include support for tools like:</p>

<ul>
<li>Xamarin</li>
<li>CMake</li>
<li>Gulp</li>
<li><g class="gr_ gr_76 gr-alert gr_spell gr_run_anim ContextualSpelling ins-del multiReplace" id="76" data-gr-id="76">Npm</g></li>
<li>many others...</li>
</ul>

<h2>Ok, so how do I get started with Cake?</h2>

<p>The best place to start with Cake would be the <a href="http://cakebuild.net/docs/tutorials/getting-started">getting started</a>&nbsp;guide. This will walk you through the process of using Cake to build an example project. From there, you can follow the <a href="http://cakebuild.net/docs/tutorials/setting-up-a-new-project">setting up a new project</a>&nbsp;guide.</p>

<h2>More information</h2>

<p>If you want to keep up to date with what is going on with Cake, be sure to subscribe to our blog feed and you can also follow us on <a href="https://twitter.com/cakebuildnet">twitter</a>. In addition, if you have any questions or problems with Cake, you can join the <a href="https://gitter.im/cake-build/cake">Gitter chat room</a>. There is almost always someone in the chat room, so feel free to ask any questions that you might have. Be sure to give <g class="gr_ gr_89 gr-alert gr_spell gr_run_anim ContextualSpelling ins-del multiReplace" id="89" data-gr-id="89">cakebot</g>, our resident <a href="https://hubot.github.com/"><g class="gr_ gr_90 gr-alert gr_spell gr_run_anim ContextualSpelling ins-del multiReplace" id="90" data-gr-id="90">hubot</g> </a>a <g class="gr_ gr_91 gr-alert gr_spell gr_run_anim ContextualSpelling ins-del multiReplace" id="91" data-gr-id="91">botsnack</g> when you drop by!</p>

<h2>Thank You</h2>

<p>Thank you very much for <g class="gr_ gr_68 gr-alert gr_gramm gr_run_anim Grammar multiReplace" id="68" data-gr-id="68">you</g> interest in Cake, we truly hope that you find it as useful a tool as we have. Happy building! --Gary</p>

<p><a href="https://github.com/gep13">Gary Ewan Park</a>&nbsp;(<a href="https://twitter.com/gep13">@gep13</a>), Project Maintainer, Cake (on behalf on the <a href="https://github.com/cake-build/cake">Cake </a>maintainers and committers)</p>
