LayoutRef: blog
Title: Announcing LLILC - A new LLVM-based Compiler for .NET
Author: 
Published: 2015-04-14 14:30:58.0000000
---
<p>The .NET Foundation was set up to foster open source innovation and collaboration around&nbsp;.NET and so&nbsp;I'm very pleased to announce that we have released an&nbsp;initial version of a new project called&nbsp;<a href="https://github.com/dotnet/llilc">LLILC</a> (pronounced "lilac") on GitHub. This is a new LLVM-based native code compiler for .NET Core&nbsp;which is being&nbsp;contributed to the .NET Foundation by Microsoft. <a href="http://llvm.org/">LLVM</a> is a very popular open source compiler framework which supports targeting multiple CPU types. LLILC creates a bridge into LLVM for .NET, making LLVM's broad chip support and tools available to .NET Core.</p>

<p>We are envisioning using the LLVM infrastructure for a number of scenarios. The first tool in LLILC is a Just in Time(JIT) compiler for CoreCLR.</p>

<h4>Why a new JIT for CoreCLR?</h4>

<p>While the CoreCLR already has JIT, we saw an opportunity to provide a new code generator that has the potential to run across all the targets and platforms supported by LLVM. To enable this, as part of the LLILC&nbsp;project we're opening a&nbsp;<a href="http://en.wikipedia.org/wiki/Common_Intermediate_Language">CIL reader</a>&nbsp;that operates directly against the same common JIT interface as the production JIT (RyuJIT). This new JIT will allow any C# program written for the .NET Core class libraries to run on any platform that CoreCLR can be ported to and that LLVM will target.</p>

<h4>There are several ongoing efforts to compile MSIL in the LLVM community. Why build another one?</h4>

<p>When we started thinking about the fastest way to get a LLVM based code generation working we&nbsp;looked around at the current open source projects (<a href="https://github.com/xen2/SharpLang">SharpLang</a>&nbsp;is a very cool one and <a href="http://www.llvmsharp.org/">LLVMSharp</a>&nbsp;is also good) as well as code Microsoft&nbsp;had internally. While a number of the OSS projects already targeted LLVM BitCode, no one had anything yet that was a close match for the new CoreCLR interface. Looking at the&nbsp;options it was quickest&nbsp;for us to refactor and modify a working MSIL reader to target BitCode then get&nbsp;an existing project to support the contracts and APIs the CoreCLR uses for JIT'ing MSIL. Using an existing MSIL reader let us get the project bootsrapped&nbsp;using a number of building-block components that we think the wider community will also be able to take&nbsp;advantage of. This rapid&nbsp;bootstrap for C# across multiple platforms was the idea that was the genesis of this project and the compelling reason to start a new effort. We hope LLILC will provide a useful example - and a set of reusable components - for the whole community and make it easier for lots of other projects to interoperate with the CoreCLR runtime.</p>

<h4>Why LLVM?</h4>

<p>Basically LLVM is awesome. It's already got great support across many platforms and chipsets and the community is amazingly active. The ability for LLVM to operate as both a JIT and as an AOT compiler was especially attractive. By bringing MSIL semantics to LLVM we plan to construct a number of tools that can work against CoreCLR or some sub set of its components. By putting all this out in an early state, we also hope folks will be able to produce tools and technologies that we haven't even thought of yet.</p>

<p><strong>Roadmap</strong></p>

<p>As we said, it's early days for the LLILC project but the current plan is to start with a classic JIT, then move to Install-time JIT (what we talk of as "NGen" in the .NET world). Next the LLILC project team want to look at an Ahead of Time compiler (AOT)&nbsp;- a&nbsp;build lab compiler that produces standalone native executables for many platforms, using some shared components from CoreCLR. The AOT compiler could&nbsp;also be used to improve startup time for important command line applications like the <a href="https://github.com/dotnet/roslyn" target="_blank">Roslyn Compiler</a>.</p>

<p>The LLIC JIT will be a functionally correct and complete JIT for the CoreCLR runtime and a great reference implementation. It's too early to say but it may not have sufficient throughput to be a first-tier JIT, but it is expected to produce high-quality code and so might make a very interesting second-tier or later JIT, or a good vehicle for prototyping codegen changes to feed back into RyuJIT.</p>

<p>Right now the core LLILC project team have been focusing on Windows along with Linux and Mac OS X but we would be very keen on folks getting involved that wanted to widen th platform base.</p>

<p><strong>Current Status</strong></p>

<p>Today on Windows we have the MSIL reader &amp; LLVM JIT implemented well enough to compile a significant number of methods in the JIT bring up the tests included in CoreCLR. In these tests we compile about half the methods and then fall back to RyuJIT for cases we can't handle yet. The testing experience is pretty decent for developers. The tests we run can be seen in the CoreCLR <a href="https://github.com/dotnet/coreclr/tree/master/tests/src/JIT/CodeGenBringUpTests" target="_blank">test repo</a>.&nbsp;All tests run against the CoreCLR GC in conservative mode - which scans the frame for roots - rather than precise mode. We don't yet support Exception Handling.</p>

<p>We've established <a href="http://dotnet-ci.cloudapp.net/job/dotnet_llilc_linux_release/">builds on Linux</a>&nbsp;and Mac OSX and are pulling together mscorlib, the base .NET Core library from <a href="https://github.com/dotnet/corefx" target="_blank">CoreFx</a>, and test asset dependencies to get testing off-the-ground for those platforms.</p>

<p>The <a href="https://github.com/dotnet/llilc/graphs/contributors">LLILC team</a>&nbsp;are <a href="http://lists.cs.uiuc.edu/pipermail/llvmdev/2015-April/084459.html">starting to engage</a>&nbsp;with the very cool folks in the LLVM community on the project (see the <a href="http://blog.llvm.org/2015/04/llilc-llvm-based-compiler-for-dotnet.html">LLVM blog post</a>) but we also hope that developers and academics who are familiar with LLVM will also get involved, helping C# and the other .NET languages be supported for LLVM.</p>

<p>The LLILC team will be working in the <a href="https://github.com/dotnet/llilc">LLILC</a> and <a href="https://github.com/microsoft/llvm">LLVM</a> repos over the next several months. They will be posting to the&nbsp;<a href="http://forums.dotnetfoundation.org/">Forums</a> as they make progress. As .NET Core becomes more fully supported on Linux and OS X, it is their intention to provide an LLILC implementation at a similar quality, so that you can use both projects together. It is also a great opportunity for us to get feedback, since we expect a lot of experimentation with .NET Core.</p>

<p>While it is early days, we'd love to have you join in and help bring the potential that LLILC offers to .NET Core via LLVM a reality. We want to know about your experience, either positive or <a href="https://github.com/dotnet/llilc/issues">issues</a> that you encounter. If you have LLVM experience or want to gain that experience by working on the project, please do engage directly with&nbsp;the <a href="https://github.com/dotnet/llilc">LLILC project</a>. The team will actively be monitoring for any PRs, responding to issues and wanting to discuss any changes we are proposing to LLVM to help it support .NET.</p>

<p>LLVM and .NET are an interesting combination. .NET provides <a href="https://github.com/dotnet/coreclr/blob/master/Documentation/intro-to-clr.md#multi-language-support">multiple-language support</a> via a common language runtime, while <a href="http://llvm.org/">LLVM</a> supports "compilation of arbitrary programming languages" to multiple CPU targets. By combining these two worlds, LLILC provides a promising path to multiple platform support&nbsp;for .NET languages and by extension to the .NET developers&nbsp;across the globe. Exciting stuff.</p>

<p>Martin Woodward<br />Executive Director, .NET Foundation</p>
