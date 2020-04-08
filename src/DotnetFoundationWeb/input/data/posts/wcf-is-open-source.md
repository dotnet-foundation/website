LayoutRef: blog
Title: WCF Client is Open Source
Author: 
Published: 2015-05-20 12:44:00.0000000
---
<p>We&rsquo;re excited to announce a new open source project on GitHub from the WCF team at Microsoft.&nbsp; This new version of WCF targets <a href="https://github.com/dotnet/core">.NET Core</a> and has been donated to the family of <a href="https://github.com/dotnet">.NET Foundation open source projects</a><span>.</span></p>

<p>Check out the <a href="https://github.com/dotnet/wcf/">WCF project</a> for more details. The team is actively developing WCF in this repository, and they will review any issues and pull requests you wish to contribute. The <a href="https://github.com/dotnet/wcf/wiki">wiki</a> describes how to build and contribute to the project.</p>

<p>WCF targets the .NET Core framework which is designed to support multiple computer architectures and to run cross-platform. Right now the WCF project builds on Windows, but .NET Core offers the potential for it to run on OS X and Linux. The WCF team are working hard to make this a reality and to keep up to date as <a href="https://github.com/dotnet/coreclr/wiki/Contributing">platform support for .NET Core grows</a>, but if you want to help I know they would love contributions especially around improving and testing the platform support.</p>

<p>In this guest post from <a href="https://github.com/roncain">Ron Cain</a>, he explains more about the new project and how to get started with the new, open source WCF and .NET Core.</p>

<p>-- Martin</p>

<hr />

<h2>What is in the new WCF GitHub repository</h2>

<p>The <a href="https://github.com/dotnet/wcf">WCF repository</a>&nbsp;contains a subset of the full <a href="https://msdn.microsoft.com/en-us/library/dd456779.aspx">Windows Communication Foundation</a> product available on the Windows desktop, and it supports the library profiles already available for building WCF apps for the Windows Store.&nbsp; These profiles are primarily client-based, making them suited for mobile devices or on mid-tier servers to communicate with existing WCF services.&nbsp; The corresponding Windows Store libraries now available in this repository are:</p>

<ul>
<li>ServiceModel.Primitives</li>
<li>ServiceModel.Http</li>
<li>ServiceModel.NetTcp</li>
<li>ServiceModel.Duplex</li>
<li>ServiceModel.Security</li>
</ul>

<h2>Features known to work</h2>

<p>This project is under active development, but as <span>we&rsquo;ve <a href="http://blogs.msdn.com/b/dotnet/archive/2015/04/06/a-journey-through-open-source-the-trials-amp-triumphs-in-roslyn-s-first-year-of-open-source.aspx">learned from other projects</a></span>&nbsp;we want WCF to become an open source project early in its lifecycle so that it has time to respond to community feedback before it is declared &ldquo;done&rdquo;.&nbsp; This means some areas are a work in progress and you will see them changing rapidly. Our team&rsquo;s goal is to achieve feature parity with the existing Windows Store profiles first and then improve as feedback comes in.&nbsp; The following features are expected to work today:</p>

<p>Bindings:</p>

<ul>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/BasicHttpBinding.cs">BasicHttpBinding</a></li>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/NetHttpBinding.cs">NetHttpBinding</a></li>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/NetTcpBinding.cs">NetTcpBinding</a></li>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/Channels/CustomBinding.cs">CustomBinding</a></li>
</ul>

<p>Transport-level binding elements:</p>

<ul>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/Channels/HttpTransportBindingElement.cs">HttpTransportBindingElement</a></li>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/Channels/TcpTransportBindingElement.cs">TcpTransportBindingElement</a></li>
</ul>

<p>Message encoding binding elements:</p>

<ul>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/Channels/TextMessageEncodingBindingElement.cs">TextMessageEncodingBindingElement</a></li>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/Channels/BinaryMessageEncodingBindingElement.cs">BinaryMessageEncodingBindingElement</a></li>
</ul>

<p>Channel shapes</p>

<ul>
<li><a href="https://github.com/dotnet/wcf/blob/master/src/System.Private.ServiceModel/src/System/ServiceModel/Channels/IRequestChannel.cs">IRequestChannel</a></li>
</ul>

<p>Miscellaneous:</p>

<ul>
<li>ChannelFactory&lt;T&gt;</li>
<li>ClientBase&lt;T&gt;</li>
<li>FaultContract, FaultException and FaultException&lt;T&gt;</li>
<li>MessageContract</li>
<li>DataContract serialization of simple and complex types</li>
<li>XmlSerializer serialization of simple and complex types (XmlSerializerFormatAttribute)</li>
<li>IClientMessageInspector</li>
</ul>

<h2>Known issues</h2>

<p>Features that are available for Windows Store profiles but not fully enabled yet by WCF will throw a <span>PlatformNotSupportedException</span> today. Our team is actively working on these and expects to enable most of them soon.&nbsp; Checkout the <span>WCF Issues</span> to see how our team is prioritizing this work, and feel free to comment on the issues for the features most important to you. The features not yet enabled are:</p>

<ul>
<li>Duplex communication</li>
<li>WebSockets</li>
<li>SSL</li>
<li>Message level security</li>
<li>Digest or NTLM authentication</li>
<li>Streamed transfer mode</li>
<li>ETW tracing support</li>
<li>TCP transport level security</li>
</ul>

<h2>Visual Studio 2015 RC and WCF</h2>

<p>Microsoft released <a href="https://www.visualstudio.com/">Visual Studio 2015</a> RC at the Build conference in April 2015, and it supports the ability to use WCF in both Universal Windows and ASP.NET 5 applications.&nbsp; The code used to build these WCF libraries used by VS 2015 RC was moved into this new GitHub repository, and the GitHub version&nbsp;will be the source used moving forward.&nbsp; By contributing to the <a href="https://github.com/dotnet/wcf/">WCF</a>&nbsp;project&nbsp;you will be contributing directly to the WCF capabilities available to Universal Windows and ASP.NET 5 apps.</p>

<p><em><a href="https://github.com/roncain">Ron Cain</a>, Project Lead, WCF.</em></p>
