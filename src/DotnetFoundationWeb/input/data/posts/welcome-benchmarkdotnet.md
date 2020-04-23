LayoutRef: blog
Title: Welcome BenchmarkDotNet
Author: 
Published: 2016-11-10 15:21:56.0000000
Visible: true
---
<p>Today, I have the pleasure of welcoming <a href="https://github.com/dotnet/BenchmarkDotNet">BenchmarkDotNet</a> into the .NET Foundation. It's a powerful cross-platform library which helps you to measure the performance of your source code with the high level of precision even when you are working with very rapid operations. It's already used by a number of great .NET projects, with a growing community of contributors.</p>

<p>In this guest post, <a href="https://github.com/AndreyAkinshin">Andrey Akinshin</a> from the <a href="https://github.com/dotnet/BenchmarkDotNet">BenchmarkDotNet</a> project explains more and how to get started.</p>

<p>-- Martin</p>

<h3>BenchmarkDotNet</h3>

<p>Benchmarking is really hard (especially microbenchmarking), you can easily make a mistake during performance measurements. BenchmarkDotNet will protect you from the common pitfalls (even for experienced developers) because it does all the dirty work for you: it generates an isolated project per each benchmark method, does several launches of this project, run multiple iterations of the method (include warm-up), and so on. Usually, you even shouldn't care about a number of iterations because BenchmarkDotNet chooses it automatically to achieve the requested level of precision.</p>

<p>It's really easy to design a performance experiment with BenchmarkDotNet. Just mark your method with the <code>[Benchmark]</code> attribute and the benchmark is ready. Want to run your code on CoreCLR, Mono, and the Full .NET Framework? No problem: a few more attributes and the corresponded projects will be generated; the results will be presented at the same summary table. In fact, you can compare any environment that you want: you can check performance difference between processor architectures (x86/x64), JIT versions (LegacyJIT/RyuJIT), different sets of GC flags (like Server/Workstation), and so on. You can also introduce one or several parameters and check the performance on different inputs at once.</p>

<p>BenchmarkDotNet helps you not only run benchmarks but also analyze the results: it generates reports in different formats and renders nice plots. It calculates many statistics, allows you to run statistical tests, and compares results of different benchmark methods. So it doesn't overload you with data, by default BenchmarkDotNet prints only the really important statistical values depending on your results: it allows you to keep summary small and simple for primitive cases but notify you about additional important area for complicated cases (of course you can request any numbers manually via additional attributes).</p>

<p>BenchmarkDotNet doesn't just blindly run your code - it tries to help you to conduct a qualitative performance investigation.</p>

<p>BenchmarkDotNet is already a full-featured benchmark library for different kinds of performance research, and many developers already use it. But it continues to actively develop, a lot of nice features are coming and are on the roadmap. Feedback is welcome: if you have an idea how to improve the library (or if you wish to implement it), the team is waiting for you on <a href="https://github.com/dotnet/BenchmarkDotNet">GitHub</a>! </p>

<p><em><a href="https://github.com/AndreyAkinshin">Andrey Akinshin</a>, Project Lead on <a href="https://github.com/dotnet/BenchmarkDotNet">BenchmarkDotNet</a></em></p>
