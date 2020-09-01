---
Title: .NET Foundation September/October 2020 Update
Author: Claire Novotny
Published: 
Slug: net-foundation-september-october-2020-update
Excluded: true
---
Here's the September/October 2020 .NET Foundation update. Every other month, we'll give you a quick overview of the .NET Open Source landscape, including top project news, events, community links and more.

## General news

## Committee Updates

### Outreach


### Marketing


#### Member resources
We'd like to make our members aware of some marketing resources you can take advantage of.

- *Help spread .NET Foundation's message*: Take a look at the [.NET Foundation slides](https://dotnetfoundation.sharepoint.com/:p:/s/Marketing/EbxGONyybLRMoe6MgPNUEi4BdDuEWNLmdfV_s8INO9nWTw?e=mImEov) and use them in your presentations and events.
- *Promote your .NET open source content, events, project news*: If you'd like to promote something on the .NET Foundation social channels, fill out the [amplification request issue template on our content repo](https://github.com/dotnet-foundation/content/issues/new?assignees=&labels=&template=content-amplification-request.md&title=%5BAMPLIFICATION%5D+-+Title) and we'll get you scheduled.
- *Write a guest blog post or submit a video to our YouTube*: If you would like to propose creating content like a guest blog post or video, fill out the [content creation request issue template on our content repo](https://github.com/dotnet-foundation/content/issues/new?assignees=&labels=&template=content-creation-request.md&title=%5BCREATION%5D+-+Title) and we'll work with you on getting your content created.

#### .NET branding guidelines
Microsoft released updated .NET branding guidelines on GitHub [github.com/dotnet/brand](https://github.com/dotnet/brand). The purpose of these guidelines is to provide a framework for communicating with the .NET developer community and establishing a consistent brand identity. This not only includes the logo & typeface but also consistent messaging, terminology, fun illustrations and presentation templates you can use. 

## Events

### "The Maintainers" Video Series Needs You
Shawn Wildermuth is putting together a short video series about open source maintainers. You can view the existing episodes (with Brad Wilson of xUnit fame; and Jimmy Bogard of AutoMapper) by visiting the [YouTube Playlist](https://shawnw.me/TheMaintainers). If you're interested in being a part of the series, please contact Shawn on [His Website](https://wildermuth.com/contact).

### .NET Conf 2020 dates announced: November 10-12!
.NET Conf is a free, three day virtual developer event co-organized by the .NET community and Microsoft. This year .NET 5.0 will launch at .NET Conf 2020! See the website for more information and save the date! [www.dotnetconf.net](https://www.dotnetconf.net)

We're also planning our next .NET Conf: "Focus" event, where we continue focusing on specific .NET topics. July 30 we will present a full day of sessions for *.NET Conf: Focus on Microservices* with some very special guests! Learn more: [focus.dotnetconf.net](https://focus.dotnetconf.net)

## .NET Foundation Project Updates

## New Projects

## New Releases

### Chem4Word 2020
After many months of exhaustive beta testing, we released [Chem4Word 2020](https://www.chem4word.co.uk/).  This release owes more to the underlying technology than the new features. 

The most substantial change is the new molecule sketcher.  The [Advanced CML-based Molecule Editor](https://www.chem4word.co.uk/2020/08/30/a-new-molecule-editor-in-chem4word-2020-introducing-acme/), or ACME for short, is a completely C#/WPF-based component.  We'd been using the GPL version of iChemLabs [ChemDoodle for Web](https://web.chemdoodle.com/#:~:text=ChemDoodle%20Web%20Components%20are%20pure,your%20websites%20and%20web%20applications.) up to now, but we'd been dodging ongoing concerns over license compatibility. Eventually we bit the bullet, and wrote our own sketcher.  This is ACME in action:

![image](https://user-images.githubusercontent.com/10074162/91839052-54a22600-ec46-11ea-90cd-e3790eb6cec1.png)

ACME can be dropped into any WPF or WinForms application, not just Chem4Word. Anyone writing a LOB cheminformatics application could use it.  It is however limited to Windows Desktop applications.  As Chem4Word up to now has been strictly Windows Desktop, then this hasn't been a limitation.  Our calculation is that there is a lot of mileage left in the VSTO/C# approach to crafting Office Add-Ins.  Time will tell whether this remains so, given Microsoft's ever-changing developer technology story.  

Other changes would appeal to the chemist more than the informatics developer.  We now support [functional groups](https://www.chem4word.co.uk/2020/08/31/functional-groups-now-included-in-chem4word-2020/) (shorthand for predefined layouts of atoms).  We have also incorporated a unique library of 2100+ substances from essential oils.  We've also improved performance, especially during rendering.  Structures now render quicker and with much higher quality.  The new Library component showcases these enhancements beautifully:

![image](https://user-images.githubusercontent.com/10074162/91839493-0b9ea180-ec47-11ea-916a-8d0c248ad15c.png)

This has been a tough release to get out, especially given lockdown and the strictures of our new way of living and working.  However, it provides a very much more solid foundation for future enhancements to Chem4Word.
## Meetups

### Looking for speakers to go deep on AWS?

Would your user group \ meetup appreciate hearing about .NET on AWS from an AWS .NET developer advocate? The team of longtime .NET developers would be thrilled to join your virtual user group to chat about the latest for .NET in the cloud. 

Here’s a list of example topics:
- **Overview of .NET on AWS:** AWS has over a decade supporting .NET on the cloud. We’ll provide an overview of all the support you might not know existed, such as free tools for Visual Studio, PowerShell, Azure DevOps, etc.
- **Building serverless with .NET:** The future is now for serverless, and AWS is ensuring .NET is vibrant in that future. We’ll show you how anybody can get started and take advantage of the speed and ease of using serverless with .NET.
- **Infrastructure as .NET:** Why learn JSON or YAML to build on the cloud if you can just use .NET? Learn how to model and provision cloud resources in .NET with the open source AWS Cloud Development Kit (CDK)
- **PowerShell on AWS:** AWS supports PowerShell and makes it easy to manage your AWS resources in a PowerShell scripting environment. We’ll show you all the things you can easily do on AWS with PowerShell, including native support for serverless. 
- **Something else?** What are you interested in hear about? Blazor? ML? Reach out and let us know.

You can contact the .NET developer advocacy team at **[aws-dotnetfdn-interest-open@amazon.com](mailto://aws-dotnetfdn-interest-open@amazon.com)**. Cheers!

### Sponsored Meetups
**Our .NET Foundation sponsored [.NET Meetup Pro groups](https://www.meetup.com/pro/dotnet) are continuing to grow worldwide.** Here are some quick stats:*
* 366 Groups
* 66 Countries
*	311K Members

Our .NET Meetup Pro group helps developers find your group, as well as get involved with local events like .NET Conf Local. If your meetup hasn't joined yet, you can [right here](https://aka.ms/add-dotnet-meetup).

![Map of meetup group locations](https://user-images.githubusercontent.com/1427284/74241694-64015800-4c91-11ea-9431-736bc05717a0.png)
