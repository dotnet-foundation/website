---
layout: _layout
permalink: /projects/net-foundation-project-committee
---
# .NET Foundation Project Committee

## Background

The .NET Foundation, an independent 501(C)(6) corporation, is chartered to foster open development and collaboration around the growing collection of open source technologies for .NET. It serves as a forum for commercial and community developers alike to strengthen the future of the .NET ecosystem by promoting openness, community participation and rapid innovation.

The mission of the .NET Foundation is to foster a community of .NET developers focused on collaborating on commercially friendly open source software projects that enhance the .NET platform and create value within the .NET ecosystem.

## Rationale

An important aspect of the .NET Foundation's vision is to attract and foster vibrant communities of open source projects and contributors. However, in order to preserve the relevancy and credibility of the .NET Foundation's brand and reputation, it must ensure that all member projects fully embrace its mission and values and are willing to function as first class ambassadors and representatives of the .NET Foundation. It is the role of the Project Committee to assist the Board of Directors in ensuring this alignment.

## Responsibilities

The Project Committee manages the day to day requirements of Projects. This includes but is not limited to the following:

- Review and evaluate new Project applications
- Monitor health of existing Projects
- Handle the retirement of Projects
- Provide support to Projects

## Organizational Structure

The Project Committee is comprised of volunteer .NET Foundation members, a representative from the .NET Foundation Board of Directors, and a designated Chairperson appointed by the Executive Director. The Chairperson ensures that the Project Committee meets monthly to discuss and review items pertaining to Projects and provides information and recommendations to the Executive Director so that they can be presented to the Board of Directors for approval. All official communication from the .NET Foundation pertaining to Projects must be delivered by the Executive Director.

## Evaluation Criteria

Transparency is a key open source characteristic, and as a result the criteria for evaluating .NET Foundation projects is designed to be as measurable and objective as possible. The criteria are not only important for evaluating new project applications but for measuring the ongoing health of existing projects. There are two types of criteria which have been defined:

**Eligibility** - this criterion is binary in nature and is used to determine if a project is fully aligned with the mission and values of the .NET Foundation.

**Health** - this criterion is quantitative in nature and is based on publicly accessible metrics which can be used to evaluate the health and maturity of a project.

## Project Levels

Projects are categorized according to the following levels: 

**Applicant** - a project which has applied to the .NET Foundation to become a member. The Project Committee will review the application within one month of the submission to determine whether or not the project has satisfied the Eligibility and/or Health requirements. 

**Seed** - a project which has been reviewed by the Project Committee and meets the basic Eligibility requirements but does not yet meet the Health requirements. Projects at this level are eligible for some .NET Foundation project services and will be re-evaluated automatically each quarter by the Project Committee to determine if they are ready to graduate to the Member level.

**Member** - a project which satisfies the Eligibility and Health requirements and has been on-boarded as an official .NET Foundation project. Projects at this level can identify themselves publicly as Member Projects and are eligible to obtain access to all .NET Foundation project services. They will continue to be monitored on a monthly basis to ensure they meet the Eligibility and Health criteria.

**Retired** - a project which was once a Member Project but no longer satisfies either the Eligibility or Health requirements, or has submitted a formal request to withdraw from the .NET Foundation.

## Eligibility Criteria

Broken into a variety of functional areas, the eligibility criteria is a checklist which defines if a project is fully aligned with the mission and values of the .NET Foundation.

**Suitability**

- The project operates within the moral and ethical standards of the .NET Foundation.
- The project is aligned with the philosophy and guidelines for collaborative development.
- The project is built on the .NET platform and/or creates value within the .NET ecosystem.

**Code**

- The project produces source code for distribution to the public at no charge.
- The project's code is easily discoverable and publicly accessible (preferably on GitHub). 
- The project contains a build script that can produce deployable artifacts that are identical to the official deployable artifacts, with the exception of code signing (Exception may be granted for strong name keys, though strongly encouraged to be committed. Exception relies on OSS signing being in the build script for public builds).
- When applicable, project must use reproducible build settings in its toolchain.
- The project uses [Source Link](https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/sourcelink).
- The project uses either embedded PDBs or publish symbol packages to NuGet (if applicable).
- The project code signs their artifacts as appropriate.

**Licenses and Copyright**

- The code is offered under an open source license which has been approved by the .NET Foundation.
- Libraries that are mandatory dependencies of the project are also offered under a standard, permissive open source license which has been approved by the .NET Foundation (exceptions include a dependency that is required by the target platform where no alternative open source dependency is available such as the .NET Framework or a hardware specific library).
- Committers are bound by a Contributor License Agreement (CLA) and/or are willing to embrace the .NET Foundation's CLA when the project becomes a Member.
- The copyright ownership of everything that the project produces is clearly defined and documented.

**Quality**

- The project is open and honest about the quality of its code.
- The project has a public issue tracker where the status of any defect can be easily obtained.
- The project puts a very high priority on producing secure software. 
- The project has a published Security Policy.

**Community**

- The project has a home page which provides high level information about its status and purpose.
- The project welcomes contributions from anyone and embraces diversity.
- The project strives to grant more rights and responsibilities to contributors who add value to the project.
- The project has a public communication channel where community members can engage with maintainers.
- The project adheres to, and enforces, the .NET Foundation Code of Conduct.
- The project has a publicly available location where members can review and contribute to documentation.

It is expected that a project satisfies the majority of the criteria outlined above; however, it is also possible for a project to obtain a waiver for specific criteria. It is the responsibility of the Project Committee to collate the project information, perform an evaluation, and make recommendations on a project's eligibility to the Board of Directors. The Board of Directors has the right to approve or deny a project's eligibility. Projects will also be re-evaluated periodically to ensure they continue to satisfy the eligibility requirements.

## Health Criteria

Health criteria are designed to be measurable and are based on publicly accessible metrics which can be used to evaluate the health and maturity of a project on an ongoing basis. For convenience reasons, standard metrics are based on values which can be readily obtained by anyone from GitHub and Nuget; however, metrics from other open source hosting platforms will also be considered.

- Age (based on the date on the LICENSE file in the repository or a date provided by the maintainer) 
- Stars
- Watchers
- Forks
- Commits
  - Issues Open
  - Issues Closed
  - Pull Requests Open
  - Pull Requests Closed
- Branches
- Packages
- Releases
- Contributors
- NuGet Package Downloads

There are no specific metrics levels or calculations which have been defined to judge the health of a project. Rather, the Project Committee utilizes the various metrics to make a relative determination of whether a project meets the health requirements. The Project Committee makes recommendations on a project's health to the Board of Directors. The Board of Directors has the right to approve or deny a project's health. Metrics will be gathered each month by the Project Committee so that trends can be analyzed to determine the ongoing vitality of a project.
