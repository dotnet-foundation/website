LayoutRef: blog
Title: Welcoming Protobuild to the .NET Foundation
Author: 
Published: 2016-05-11 18:15:00.0000000
Visible: true
---
<p>As .NET becomes more common cross-platform, a new generation of tools is emerging to help developers manage common workflows when using the same .NET code across multiple operating systems, <g class="gr_ gr_48 gr-alert gr_gramm gr_run_anim Punctuation only-ins replaceWithoutSep" id="48" data-gr-id="48">runtimes</g> and devices. Protobuild is one of these awesome emerging new tools and I've very proud to welcome them into the .NET Foundation.&nbsp;</p>

<p>In this guest post, <a href="https://github.com/hach-que">June Rhodes</a>&nbsp;from the Protobuild project team explains more about the project. If it looks like it will be useful to you, I encourage you to&nbsp;<a href="http://protobuild.org/">give it a try</a>&nbsp;and&nbsp;<a href="https://github.com/protobuild">get involved</a> in the growing community.</p>

<p>-- Martin</p>

<p>Do you develop <g class="gr_ gr_51 gr-alert gr_gramm gr_run_anim Punctuation multiReplace" id="51" data-gr-id="51">cross-platform .</g>NET projects? Maybe you manage them with multiple C# projects on disk for each platform or framework you want to target? Or maybe you use MSBuild conditionals to target multiple platforms and <g class="gr_ gr_38 gr-alert gr_spell gr_run_anim ContextualSpelling" id="38" data-gr-id="38">fore-go</g> the use of Linux or Mac IDEs for .NET?</p>

<p>I had used both techniques before I developed <a href="https://protobuild.org/">Protobuild</a>; a cross-platform project generator for C#. With my solutions often having 10 or more assemblies, manually keeping a Windows, <g class="gr_ gr_42 gr-alert gr_gramm gr_run_anim Punctuation only-ins replaceWithoutSep" id="42" data-gr-id="42">Linux</g> and Mac version of every project in sync as well as managing the references was difficult. As someone who frequently works on Linux, selecting the MSBuild option and foregoing the use of MonoDevelop wasn't an option either - I needed the ability to debug the software I was developing on all platforms.</p>

<p>I searched around for project generators at that point, but there weren't any particular good C# options. <g class="gr_ gr_44 gr-alert gr_gramm gr_run_anim Punctuation multiReplace" id="44" data-gr-id="44">In addition</g> I found that most of the project generators were one-way; if you wanted to add a file to your solution, you needed to open the cross-platform project definitions and add the file there. I wanted less overhead managing projects, so Protobuild supports two-way generation; when you add or remove files in your IDE, these changes get <g class="gr_ gr_46 gr-alert gr_spell gr_run_anim ContextualSpelling multiReplace" id="46" data-gr-id="46">synchronised</g> back to the cross-platform project definitions.</p>

<p>Over time Protobuild evolved to support more platforms; it now supports Windows, Linux, Mac (MonoMac, XamMac and Xamarin.Mac), iOS, tvOS, Android, Ouya, PCL (for bait-and-switch), Windows 8 Apps, Windows Phone 8, Windows Phone 8.1, Web (via <a href="http://jsil.org/">JSIL</a>) and most recently Universal Windows Apps - and you can target all of these platforms for your project just by selecting a drop-down</p>

<p><img width="725" height="436" alt="" src="assets/posts/dimagLogo.png" style="display: block; margin-left: auto; margin-right: auto;" /></p>

<p>These days, Protobuild is used by cross-platform projects like <a href="http://www.monogame.net/">MonoGame</a>&nbsp;to manage their projects and dependencies. It's capable of cross-platform package <g class="gr_ gr_39 gr-alert gr_gramm gr_run_anim Punctuation only-del replaceWithoutSep" id="39" data-gr-id="39">management,</g> and provides an automation layer for build server scripts.</p>

<p>If you're managing cross-platform .NET projects, and you'd like to try out or use Protobuild for your own projects, you can download it from the <a href="https://protobuild.org/">Protobuild website</a>.</p>

<p><em>June Rhodes, Project Lead, Protobuild</em></p>
