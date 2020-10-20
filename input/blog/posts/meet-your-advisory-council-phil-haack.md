---
Title: Meet Your Advisory Council - Phil Haack
Author: 
Published: 2015-07-01 14:15:00.0000000
---
<p>Last week I kicked off a series of written interviews with our .NET Foundation <a href="/about/board-of-directors#advisory-council">Advisory Council members</a>. The Advisory Council is composed of OSS project leaders that care deeply about .NET and the success of the foundation. They drive key initiatives in the foundation and guide the board. <a href="/assets/documents/net-foundation-advisory-council-proposal.pdf">Learn more about what the Advisory Council is all about</a> and <a href="http://forums.dotnetfoundation.org/c/governance/advisory-council">participate in public discussions with them on our forums</a>.</p>

<p><img width="243" height="236" style="background-image: none; float: left; margin: 0px 0px 0px 5px; display: inline; border-width: 0px; padding: 0px 10px 5px 0px;" alt="Phil Haack" src="/assets/members/phil-haack.jpg" /></p>

<p>For this next post, I interviewed <a href="https://github.com/Haacked">Phil Haack</a>. Phil works at GitHub as an Engineering Manager for the Desktop team. This team is responsible for GitHub for Mac, GitHub for Window, and the GitHub Extension for Visual Studio. Prior to GitHub, he was a Senior Program Manager at Microsoft responsible for shipping ASP.NET MVC and NuGet. These projects were released under open source licenses and helped serve as examples to other teams for how to ship open source software. He regularly writes for his blog <a href="http://haacked.com/">http://haacked.com/</a> and tweets random observations on Twitter as <a href="https://twitter.com/haacked">@haacked</a>. He also speaks at conferences here and there, and has quit writing technical books forever, several times now.</p>

<p><strong>Tell us a little bit about yourself. What's your background? When did you start getting interested in programming?</strong></p>

<p>My last name is pronounced "hack" which pretty much guaranteed my involvement in computers and programming. I was interested in programming at a young age when my Dad bought a TRS-80 Color Computer and we'd spend hours typing in code listings from Byte magazine. Most of my programming around this time was making the computer draw pictures and creating Mad Lib style programs. I didn&rsquo;t seriously get into programming until after college when I took a job as a programmer as a way to pay the bills for a bit before I applied to grad schools for mathematics. I never got around to those applications.</p>

<p><strong>What initiatives are you working on (or passionate about) within the .NET Foundation?</strong></p>

<p>I'm passionate about helping OSS maintainers become better maintainers.</p>

<p><strong>What&rsquo;s the biggest piece of advice you can give to maintainers to become better?</strong></p>

<p>There&rsquo;s so much I could say, but if I had one thing to say, it&rsquo;s be empathetic. Sometimes the open source culture tries to completely take the human element out of the work we do under the fallacy that the compiler and computer doesn&rsquo;t care about social issues. But the fact is that software is written for humans. Humans have to care and tend to the code. Humans use the end product of the code. Without humans, there&rsquo;s no need for the code in the first place.</p>

<p>There&rsquo;s often a lot of fatigue when working with new people joining OSS. I understand it. It&rsquo;s frustrating to be asked the same question for the 100<sup>th</sup> time because people didn&rsquo;t read the README. But losing your cool and blowing up at people is a losing proposition. For many of these folks, their interaction with you might be their very first interaction with Open Source ever! Your response could lead them down a road to becoming a valued and experienced contributor, or could totally cool them off the idea of joining in. So be welcoming. Try to remember how nervous people are about making their first contribution and act accordingly.</p>

<p><strong>Can you tell us some of the first open source projects you worked on as a contributor? Why did you get involved? How did you get started?</strong></p>

<p>Like many OSS contributors, I got involved because I was bored. At work I spent all day writing the same standard data-in data-out web applications for every client. Of course when I updated my resume, I managed to make those applications sound cutting edge and full of rocket surgery. Open Source afforded me the opportunity to delve into different types of software. For example, I wanted to try my hand at a desktop application. I spent a lot of time at work reading blog entries from people doing more interesting work than I was doing.</p>

<p>So it&rsquo;s fitting that my first foray with open source started with&nbsp;RSS Bandit (an RSS aggregator) a long time ago. For the youngsters reading this, it&rsquo;s like decentralized Medium full of very self-important writing (again, like Medium), but with many gems hidden among the bloviating. I started off by making contributions to the documentation. The maintainers started to trust me and gave me commit access so I could make direct contributions. It was a thrill to see my contributions used in the wild. I was hooked.</p>

<p>From there I started my own project with Subtext which pretty much amounted to taking a second job. It was with great sadness and relief that I shut it down after some 8 years working on it. It&rsquo;s been supplanted by Jekyll for me. It&rsquo;s the cycle of code. Newer and better code replaces older outdated approaches.</p>

<p><strong>Looking back, what bug are you most proud of fixing in an open source project?</strong></p>

<p>Too many to consider. Perhaps it was taking the four configuration files and merging them into one (via Subtext) that really simplified the installation of the blog engine. That really drilled into me the idea that usability is one of the most essential features for any project. The installation process needs to be flawless. If people can&rsquo;t even get started using your software, they won&rsquo;t stick around. They really don&rsquo;t care about how hard that work is for you. They don&rsquo;t have time to think about you, they&rsquo;re just trying to get something done and the best thing you can do is make sure your software doesn&rsquo;t get in their way.</p>

<p><strong>What project(s) do you spend most of your time on now?</strong></p>

<p>In terms of Open Source projects, I mostly spend my time on <a href="https://github.com/octokit/octokit.net">Octokit.net</a>, a client library for the GitHub API I also occasionally maintain the many small NuGet packages I&rsquo;ve written. I also maintain the Semantic Versioning (semver) specification. But that&rsquo;s mostly a hands-off affair these days since a great feature of a specification like that is to not change too drastically too often. Rather than focus my time on one project these days, I mostly contribute small fixes back to a large number of other open source projects that we happen to use at work and that I use in my free time.</p>

<p><strong>Can you tell us one thing you have learned about running an open source project?</strong></p>

<p>A lot of people will tell you they'll contribute, but very few will. So treat those folks very well! Well, treat <em>everybody</em> well! Also, everybody has opinions on what you should do. After all, opinions are free. So seek out opinions from those who have skin in the game. The idea that if you implement some feature, someone will start using your code is usually a lie. So I tend to focus on those who are actually using the software. I also focus on those who go so far as to contribute to the software in any way. When you consider that the default action for a vast majority of users is to do nothing, something as seemingly small as logging an issue is a major contribution. Appreciate it!</p>

<p><strong>Why is open source software important to you?</strong></p>

<p>It's mostly about the community of folks who have a shared interest around a piece of code and work together to raise the state of the art. As a consumer, it's important to me to be able to tweak things for my scenarios at times when the API lacks the flexibility to accomplish my goals without code changes. As a participant, it&rsquo;s been a great source of professional and skill growth. OSS has been a great outlet to leveling up and diversifying my skills. The types of projects I can work on isn&rsquo;t driven solely by what the market finds profitable at any given moment.</p>

<p><strong>What is it about .NET that you like most?</strong></p>

<p>I'm just a big fan of C# and Visual Studio. I happen to like statically typed languages and am really familiar with C#. I think platforms are a lot like culture. You tend to like the one you&rsquo;re born into. My first job happened to use classic ASP and I&rsquo;ve been on the Microsoft stack ever since. Though being at GitHub has definitely helped me branch out a lot more. There&rsquo;s so much each community can learn from each other.</p>

<p><strong>What does the future of .NET look like in your dreams?</strong></p>

<p>In my dreams, everybody who uses .NET is doing it on GitHub on every platform!</p>

<p><strong>Thanks, Phil!</strong></p>

<p>Feel free to ask more interview questions in the comments below.</p>

<p>Enjoy, <br />-<a href="https://twitter.com/bethmassi">Beth Massi</a>, .NET Foundation Technical Evangelist</p>
