LayoutRef: blog
Title: .NET Foundation at OSCON 2019
Author: Jon Galloway
Published: 2019-08-01 00:46:43.2940043
---
<p>Earlier this month, I (Jon Galloway) attended and spoke at <a href="https://conferences.oreilly.com/oscon/oscon-or/public/schedule/detail/75936">OSCON</a> (Portland, July 16-18), representing the .NET Foundation.</p>

<p>TLDR:</p>

<ul>
<li>Presentation “<a href="https://conferences.oreilly.com/oscon/oscon-or/public/schedule/detail/79485">Why you should care about open source software foundations</a>” went well</li>
<li>Spoke with <a href="https://opensource.org/">Open Source Initiative (OSI)</a> about the .NET Foundation joining as an OSI Affiliate member, have since applied</li>
<li><a href="https://tidelift.com/">Tidelift</a> has an interesting model of supporting open source projects financially while providing value to supporters through paid project support, security scanning, etc.</li>
<li>Really good discussions and connections with other open source foundation leaders</li>
<li>Attended some good presentations and panels on open source communities</li>
</ul>

<hr />
<h3>Presentation: Why you should care about open source software foundations</h3>

<p>(<a href="https://cdn.oreillystatic.com/en/assets/1/event/295/Why%20you%20should%20care%20about%20open%20source%20software%20foundations%20_sponsored%20by%20Microsoft_%20Presentation.pptx">slide download</a>, 2 minute video on <a href="https://twitter.com/jongalloway/status/1152009213775757315">this tweet</a>)</p>

<p>In two years of supporting the .NET Foundation, I continue to see that developers are generally aware that open source software foundations (like the Linux Foundation, Apache Foundation, Eclipse Foundation, and .NET Foundation) exist, but have no idea why. That’s unfortunate, because foundations are really important for the entire open source ecosystem, including contributors, project leaders, consumers, businesses who depend on open source, pretty much everyone in software development. I’ve been giving a talk on what the .NET Foundation does at .NET related conferences over the past few years; at OSCON I broadened this to a more general “why are foundations a thing” talk, with .NET Foundation as a more of a case study.</p>

<p><strong>My high level generalization is that open source software foundations exist to make sure the projects you care about stay around and thrive.</strong>*</p>

<p>There are different foundations, with different focuses based on the communities they serve. The .NET Foundation has an interesting challenge, in that it supports both projects contributed by a trillion dollar company as well as projects that are broadly used but are developed by tiny teams.</p>

<p>For the tiny team scenario, I show the following <a href="http://www.commitstrip.com/en/2014/05/07/the-truth-behind-open-source-apps/">comic</a> in my slides (used with permission):</p>

<p><img src="assets/posts/the-truth-about-open-source.jpg" style="height:864px; width:598px" /></p>

<p><em>Source:&nbsp;<a href="http://www.commitstrip.com/en/2014/05/07/the-truth-behind-open-source-apps/">http://www.commitstrip.com/en/2014/05/07/the-truth-behind-open-source-apps/</a></em>&nbsp;</p>

<p>In the case of projects contributed and primarily developed by Microsoft, the .NET Foundation serves other purposes, like facilitating collaboration with thousands of companies and individual contributors worldwide through independent licensing, CLA support, legal, etc.</p>

<p>So my high level outline for this presentation is:</p>

<ul>
<li>.NET is really open source, and it’s really worked for us</li>
<li>Open source software foundations exist to make sure the projects you care about stay around and thrive</li>
<li>.NET Foundation as a case study
<ul style="list-style-type:circle">
<li>What we’ve been doing since 2014: project support, Meetups, events like .NET Conf</li>
<li>What we’re doing now to scale up: community elections, Action Groups</li>
</ul>
</li>
<li>A quick look at some other foundations and what they do that’s unique to their communities
<ul style="list-style-type:circle">
<li><a href="http://chooseafoundation.com/">http://chooseafoundation.com/</a></li>
<li><a href="https://opensource.com/resources/organizations">https://opensource.com/resources/organizations</a></li>
<li><a href="https://en.wikipedia.org/wiki/List_of_free_and_open-source_software_organizations">https://en.wikipedia.org/wiki/List_of_free_and_open-source_software_organizations</a> (there are legion)</li>
</ul>
</li>
<li>Get involved!
<ul style="list-style-type:circle">
<li>Projects: join a foundation</li>
<li>Developers, business people, everyone: support your foundations</li>
</ul>
</li>
</ul>

<p>The reception was good, and questions indicated people got it. Also nice was that both lawyers from the .NET Foundation’s outside legal counsel team (external to Microsoft, as .NET Foundation is a separate non-profit corporation) were there. We went to lunch after the presentation, and they both said that this really helped them understand what we’re doing and what’s unique about the .NET open source community a lot better.</p>

<p>This session was filmed, but I believe they’re just making the video available to paid attendees. I’d be happy to record and post a version if desired.</p>

<p><i>*Saying that open source software foundations exist to keep projects sustainable is a bit of an over-generalization. For instance, some foundations exist to advocate for viewpoints like free software, open web (Mozilla), etc. But, baby steps, I’m happy to start with a generalization when most people I talk to want the 101 level intro.</i></p>

<hr align="center" size="1" width="100%" />
<h3>Open Source Foundation networking</h3>

<p>I had a lot of really good conversations with leaders of open source foundations. It’s just generally good for everyone to be aware of .NET as a “real” open source thing™, but there were two standout interactions:</p>

<ul>
<li><b>The Open Source Initiative (OSI):</b> These folks were an exceptionally friendly bunch, and recommended that the .NET Foundation join the OSI as an affiliate member. I’ve since reviewed their requirements and published information and have started the application process. It'll need to go through both&nbsp;boards for approval, but at a high level this sounds really good to me.</li>
<li><b>GNOME Foundation:</b> Our recent governance model restructuring to a community elected board was heavily influenced by the GNOME Foundation’s model. It was nice to check in with them, talk to their executive director for a while, and hear what works for them organizationally.</li>
</ul>

<hr />
<h3>Tidelift conversation</h3>

<p>I had a long discussion with Luis, a co-founder at&nbsp;<a href="https://tidelift.com/">Tidelift</a>. We’ve chatted before via Twitter and&nbsp;e-mail, but their business model is complex enough that it was much more effective to talk in person.</p>

<p>Tidelift offers a “managed open source subscription backed by creators and maintainers”. Luis is a lawyer with a long history in open source, and he’s been working to think through how to offer a subscription model that benefits both open source projects and sponsors. Here’s the idea:</p>

<ul>
<li>Companies that use open source software sign on for a subscription</li>
<li>Tidelift scans their software to help them determine what they’re using (note: according to Luis, when companies guess at supporting open source projects, it can come down to well marketed projects, who the CTO follows on Twitter, etc.; actually analyzing dependency trees reveals building block packages that they may be relying on heavily without knowing it)</li>
<li>Tidelift builds a relationship with open source projects to set up support plans. Projects need to have things like defined security vulnerability reporting plans, support structure, etc., and in exchange Tidelift gives them a usage based share of their monthly subscription revenue.</li>
<li>Some of the subscription revenue supports paid development for issues requested by sponsoring companies.</li>
</ul>

<p><em>Note: This is my quick summary from an in-person conversation, and it's likely it's not exactly precise. I recommend reading the content <a href="https://tidelift.com/">on the Tidelift site</a> to make sure you get the real scoop.</em></p>

<p>It’s an interesting model that aims to connect the dots between companies using open source software and under-funded open source projects. While at some point we may want to look at a bigger, organizational level agreement, I think we’ll start by offering an introduction to .NET open source community projects that are interested. Also, Luis knows everyone in this space, so it was nice just hanging around at their booth for an hour or so and meeting all the open source legal people who came by to chat. :-)</p>

<hr align="center" size="1" width="100%" />
<h3>Attended Session Highlights</h3>

<p>I attended some informative sessions, with a focus on open source governance and community. Some highlights:</p>

<p><a href="https://conferences.oreilly.com/oscon/oscon-or/public/schedule/detail/75954">FOSS governance: The good, the bad, and the ugly</a> (Deb Nicholson, Software Freedom Conservancy)</p>

<p>This was an informative, and highly entertaining, overview of open source project best and worst practices. My main takeaway was that open source project teams and practices often organically evolve, and aren’t objectively evaluated to see what’s working and what can be improved. Deb pointed out a lot of things, like shared vision, documented processes, and plans for dealing with hostile leaders, that are worth stepping back and thinking about.</p>

<p><a href="https://conferences.oreilly.com/oscon/oscon-or/public/schedule/detail/75936">Building and maintaining open source communities</a> (panel)</p>

<p>Great stuff at this panel! Some top tips from leaders that have built effective open source communities:</p>

<ul>
<li>Focus on and improve onboarding experience</li>
<li>Look for your top contributors (“one percenters”) and really support them</li>
<li>Watch for signs of burnout, especially in your 1%ers</li>
<li>Ask them what problems they’re facing and what they’re most proud of</li>
<li>Rotate through administrative roles</li>
<li>Have community awards</li>
<li>For open source projects associated with a company, make corp leaders aware that you’re building and spending community capital. A corporate misstep can spend years of capital the team has been building.</li>
<li>Document everything, especially succession plans</li>
<li>Metrics - agree with management on goals, tie in to corporate goals</li>
<li>Don't focus on code, focus on needs of community</li>
</ul>

<hr align="center" size="1" width="100%" />
<p>We also gave away some stickers, and I popped in at the Microsoft table to talk to .NET developers as they stopped by.</p>

<p>Overall, this was a valuable conference to attend. It was really good to continue to publicize open source .NET and the .NET Foundation, make connections with other foundation leaders, and learn tips that have been effective in building open source communities.</p>
