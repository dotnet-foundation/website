---
Title: Update on ImageSharp
Author: .NET Foundation Board
Published: 2022-10-20 13:00:00
---

ImageSharp is a popular .NET project and an important library within our ecosystem. Earlier this year, James South, the leader of the project, announced an [intent to change the license](https://twitter.com/James_M_South/status/1536190455255207936) of the project and later announced that the [license had changed](https://twitter.com/SixLabors/status/1548271228007301120). This change is significant for its users and its status as a .NET Foundation project.

This post addresses a few questions:

-   What is the .NET Foundation position on this license change?
-   What is the status of ImageSharp as a .NET Foundation project?
-   What guidance does .NET Foundation have for ImageSharp users?

**Quick answers:** [Six Labors](https://sixlabors.com/) has adopted a [new license](https://github.com/SixLabors/ImageSharp/blob/main/README.md#license) for the [ImageSharp project](https://github.com/SixLabors/ImageSharp). ImageSharp users should read the new license and determine how it applies to them before moving past the final [2.x series package](https://www.nuget.org/packages/SixLabors.ImageSharp/2.1.3). The .NET Foundation only works with projects with [OSI-approved licenses](https://opensource.org/licenses). ImageSharp has decided to leave the Foundation.

There are three principles that guided our decision-making:

-   The .NET Foundation is a home for open source projects.
-   Projects can both join and leave the Foundation.
-   Projects are self-governing.

The remainder of the post goes into more detail on these topics.

# Context

There are two primary topics at hand: software licensing and open source software (OSS) sustainability. As a software foundation, we care deeply about both and consider both to be part of our charter. However, software licensing is considerably better understood (industry-wide) than software sustainability.

Software licensing gets to the core of what open source is. The .NET Foundation follows the [open source definition](https://opensource.org/osd), per the [Open Source Initiative (OSI)](https://opensource.org/). The OSI maintains a set of [approved OSS licenses](https://opensource.org/licenses) for OSS projects to use. The .NET Foundation accepts projects that use permissive licenses within that set. We look to OSI for leadership on licenses, and we believe that many developers in our community do the same.

Software sustainability is an industry-wide challenge. This ranges from the community expectation of timely resolution on issues and PRs to revenue generation. Revenue generation helps with maintainer burnout since it enables dedicating more time to a project. [Dual licensing](https://ayende.com/blog/186147-A/making-money-from-open-source-software-how-we-do-it) (for example, GPL and commercial) is one approach that has been used for revenue generation.

We believe that sponsorship is a necessary component of sustainability. It’s an important way for users to say “thank you”. It is great to see corporations step up to sponsor projects, like [AWS](https://twitter.com/James_M_South/status/1582625737386778625) and [Microsoft](https://twitter.com/James_M_South/status/1293827661903671297). Clearly, ImageSharp and projects like it need higher levels of sponsorship.

ImageSharp has historically used a dual licensing strategy, with [Apache 2 and commercial](https://github.com/SixLabors/ImageSharp/blob/cb3d073fa6ffaeada0c6ba35745542d225c2d541/README.md#license) (link to historical commit). Dual licensing with a permissive license has the benefit of maximizing adoption at the expense of revenue generation since commercial licenses are optional. Per the Six Labors announcement, the [historical approach hasn’t generated](https://sixlabors.com/posts/license-changes/) enough revenue.

# Process

Members of the .NET Foundation board started talking to Six Labors about a license change earlier this year. We ideally wanted to help the project achieve their goals while keeping to the goals of the Foundation. We also didn’t want to rush a decision on the status of the ImageSharp project within the Foundation.

After significant consideration, the .NET Foundation board decided that there wasn’t a path forward that satisfied the goals of both Six Labors and the Foundation. The board clarified that projects in the Foundation must use a permissive OSI-approved license and that projects would all be treated the same.

# Moving Forward

It is likely that ImageSharp users have a variety of viewpoints on the new approach being taken by the project. Users took a dependency on this library with one set of terms that are now different. If you find the ImageSharp project useful and you have the ability to pay, that may be your best option. Others may choose to use the latest 2.x library for some time. However, that’s not likely a long-term option. Others will look for alternatives.

There is also the question of whether the .NET Foundation itself should be providing continuity for projects that leave the Foundation or are abandoned. ImageSharp is a high-quality library in a complicated and fast-moving domain. The Foundation would quickly find itself with the same challenges as James has articulated, but without his and his co-maintainers’ domain expertise. We don’t see a path forward where we maintain a fork of ImageSharp.

Also, the 2.x NuGet packages will not be deleted. You’ll be able to use those forever.

Open-source sustainability is an important topic for the .NET Foundation, and the open-source community at large. Relevant committees and board members will work together with the community on programs that can eventually address some of these challenges.

# Closing

The .NET Foundation Board and the Maintainer Committee spent significant time discussing this topic. It’s also worth noting that there are multiple veteran maintainers on the board who run their own projects. We saw this situation as precedent-setting and felt a strong need to make a decision we could announce and repeat in future.

We encourage users to validate the status of their dependencies and to participate in the associated communities. Open source isn’t just maintainers delivering code that satisfies PackageReference lines in your project files. At the very least, it is also a commitment to understanding the plans and challenges with each of your dependencies (and their dependencies).

Open source sustainability remains largely unaddressed in this post. The Maintainer Committee discusses these topics. Please consider joining that committee if this topic is important to you. Open source does not necessarily mean that it should be uncompensated, particularly when the value is high. The White House (for the American audience) has a [similar view](https://www.whitehouse.gov/briefing-room/statements-releases/2022/01/13/readout-of-white-house-meeting-on-software-security/). It is important for all of us to explore ways to make the software we’re increasingly relying on more sustainable.
