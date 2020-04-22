---
name: New .NET Foundation Project Application
about: Creates a public issue to track your projects application to join the .NET
  Foundation.
title: ''
labels: 'project application'
assignees: onovotny, ChrisSfanos

---

<!-- 
Instructions:
Thanks for your application to join the .NET Foundation! 

1.  Here is a checklist of steps we’ll follow during the process: [https://github.com/dotnet-foundation/projects/blob/master/new-projects.md](https://github.com/dotnet-foundation/projects/blob/master/new-projects.md)
2.  Please review the [Eligibility Criteria](https://github.com/dotnet-foundation/projects#eligibility-criteria) before completing the application 
3.  Please fill out the application in the template below. If you prefer to submit via e-mail to keep information private, you can use this [application form](https://github.com/dotnet-foundation/projects/blob/master/OnBoardingQuestionaire.docx) and submit to contact@dotnetfoundation.org, referencing this issue number. You can also fill out the Word document and submit it as an [attachment to the issue](https://help.github.com/en/articles/file-attachments-on-issues-and-pull-requests), via Google Doc, etc. If you have questions, fill out what you know and discuss on the issue.
4.  After review and comment by the advisory council, we will submit your questionnaire to the board of directors recommending we add your project.
5.  We will send you a contribution agreement via DocuSign and configure the CLA bot.
6.  Finally, we will send you a on-boarding checklist with a set of work items to perform to complete the process.


Some common questions that come up on the questionnaire:

**Project Transfer Signatories.**: List the top contributors, with __contact e-mail__. For most projects, this is the top 1-5 contributors who have contributed more than a few hundred lines of code.
**Contribution Model.**  Under the .NET Foundation contribution model, a project retains ownership of the project, but grants .NET Foundation a broad license to the project’s code and other intellectual property. The project also confirms that the project’s submissions to .NET Foundation are its own original work (there are also instructions for any third party materials that might be included).
**Project Trademarks - Licensed vs Disclaimed.** When signing the CLA you are asked to describe and choose how you want to handle any trademarks for the project.  These include the project name, at a minimum, and potentially any logos or other recognizable, non-descriptive titles used within the project – these do not need to be formally registered trademarks. 

By default, the .NET Foundation selects **Licensed** in the CLA

|Type|What it Means|Why you'd select it <img width=900/>|
-----|-------------|-------------------
|Licensed|Project retains ownership of any trademarks and licenses the .NET Foundation to use them.|This follows the same ownership/license structure as the copyright in the project. The project keeps ownership in the trademarks and .NET Foundation only has the rights that are specifically granted in the license. The project still retains the rights to enforce its rights in the trademarks. |
|Disclaimed|Project agrees not to enforce the trademark against the .NET Foundation or anyone else.|The project doesn’t claim any ownership rights to the trademarks and does not plan to control how .NET Foundation decides to use the trademarks. |

-->

## 1.   General Information

**Project Name:**

**License:**

**Contributor (Company, Organization or individual name(s)):**

**Existing OSS Project? (Yes/No):**

**Source Code URL:**

**Project Homepage URL (if different):**

**Project Transfer Signatories:**
Full legal name and __email address__ required of the individual(s) with the authority to transfer or contribute the project to the .NET Foundation. Note that if you'd prefer not to include this in the public application, it can be submitted via e-mail to contact@dotnetfoundation.org (referencing this issue number).

## 2.   Description
**Please provide a brief statement about your project in terms that are understandable to the target consumer of the library or project, i.e. an elevator pitch for the project:**


**Please provide a 1 sentence (<140 character) summary of your to help users when searching the .NET Foundation projects**

## 3.   Project Governance
Please complete this section about who will be maintaining the open source project and how it will run.
**Project Lead:**
(Who is the primary contact point for the community and the .NET Foundation when discussing governance of the project.)

Name:   
 Email:   
 GitHub Profile URL:

**Committers:**

Which individuals have commit / write access to the repository, what is their GitHub ID and who is their employer (if contributions are on behalf of an employer)

**Governance Model:**

Please describe how new code changes are proposed to the project, how those changes are reviewed and how a decision is made to accept proposed changes. Also describe the process for identifying and appointing new committers.

**CLA**

If already an OSS project, was a Contribution License Agreement in place for contributions accepted? How does the project check who has signed one?

**CLA Notification Alias**
Provide an email address that will receive CLA related notifications from the .NET Foundation CLA automation

**Project Transfer Type**

**Contribution Model.**  Under the .NET Foundation contribution model, a project retains ownership of the project, but grants .NET Foundation a broad license to the project’s code and other intellectual property. The project also confirms that the project’s submissions to .NET Foundation are its own original work (there are also instructions for any third party materials that might be included).


## 4.   Repository Layout
The .NET Foundation host guidance for new projects and details on recommended structure here:
[https://github.com/dotnet/home/tree/master/guidance](https://github.com/dotnet/home/tree/master/guidance)

Note that the open source repository should be the master where changes are made by the core development team using the same PR process that is used for non-committer contributions.

Please define below any changes you would want to make to your repositories as part of the process of joining the .NET Foundation

## 5.  Eligibility Criteria
Please complete the following for your project
* The project is built on the .NET platform and/or creates value within the .NET ecosystem.
- [ ] Yes 
- [ ] No
* The project produces source code for distribution to the public at no charge.
- [ ] Yes 
- [ ] No
* The project's code is easily discoverable and publicly accessible (preferably on GitHub).
- [ ] Yes 
- [ ] No
* The project contains a build script that can produce deployable artifacts that are identical to the official deployable artifacts, with the exception of code signing (Exception may be granted for strong name keys, though strongly encouraged to be committed. Exception relies on OSS signing being in the build script for public builds).
- [ ] Yes 
- [ ] No
* When applicable, project must use reproducible build settings in its toolchain.
- [ ] Yes 
- [ ] No
* The project uses [Source Link.](https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/sourcelink)
- [ ] Yes 
- [ ] No
* The project uses either embedded PDBs or publish symbol packages to NuGet (if applicable).
- [ ] Yes 
- [ ] No
* The project code signs their artifacts as appropriate.
- [ ] Yes 
- [ ] No
* Libraries that are mandatory dependencies of the project are offered under a standard, permissive open source license which has been approved by the .NET Foundation (exceptions include a dependency that is required by the target platform where no alternative open source dependency is available such as the .NET Framework or a hardware specific library).
- [ ] Yes 
- [ ] No
* Committers are bound by a Contributor License Agreement (CLA) and/or are willing to embrace the .NET Foundation's CLA when the project becomes a Member.
- [ ] Yes 
- [ ] No
* The copyright ownership of everything that the project produces is clearly defined and documented.
- [ ] Yes 
- [ ] No
* The project has a public issue tracker where the status of any defect can be easily obtained.
- [ ] Yes 
- [ ] No
* The project has a published Security Policy.
- [ ] Yes 
- [ ] No
* The project has a home page which provides high level information about its status and purpose.
- [ ] Yes 
- [ ] No
* The project has a public communication channel where community members can engage with maintainers.
- [ ] Yes 
- [ ] No
* The project has a publicly available location where members can review and contribute to documentation.
- [ ] Yes 
- [ ] No

## 6.   PR Plan
Please summarize the public relations plan for the announcement when joining the foundation (and releasing as open source if appropriate). What is the main story we wish to promote, through what channels, what issues should we be aware of?  For significant news events then please also work with your .NET Foundation contact to ensure a [full PR plan](https://dotnetfoundation.sharepoint.com/Shared%20Documents/PR/Communications%20Plan%20TEMPLATE.docx?web=1) is developed.

## 7.   Infrastructure Requirements
Please describe any infrastructure requirements for the project. For example, how will build servers be operated? Any web hosting or service hosting requirements? Do we need to set up SSL certificates or provide Authenticode Code Signing arrangement for releases?


## 8.   Additional Notes
Please provide any additional information required or use this area for notes during the onboarding process. If this open source project has similarities with any other projects in this space then please detail them and why this project is different. If there are any potential issues that you feel the project might need help with early on then also state them here and discuss with your .NET Foundation Contact.
