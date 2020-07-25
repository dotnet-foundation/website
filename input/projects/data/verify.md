---
Title: Verify
Contributor: SimonCropp
Logo: verify.svg
Web: https://github.com/VerifyTests/Verify
---
# Verify

[Verify](https://github.com/VerifyTests/Verify) is a snapshot tool that simplifies the assertion of complex data models and documents.

Verify is called on the test result during the assertion phase. It serializes that result and stores it in a file that matches the test name. On the next test execution, the result is again serialized and compared to the existing file. The test will fail if the two snapshots do not match: either the change is unexpected, or the reference snapshot needs to be updated to the new result. When snapshots do not match, the difference is automatically displayed in a [diff tool](https://github.com/VerifyTests/DiffEngine/).

A pluggable model is provided for a variety of scenarios including:

 * [Scrubbing documents](https://github.com/VerifyTests/Verify/blob/master/docs/scrubbers.md). 
 * [Converting between different document/file types](https://github.com/VerifyTests/Verify/blob/master/docs/converter.md)
 * [Custom snapshot comparison](https://github.com/VerifyTests/Verify/blob/master/docs/comparer.md)

A number of these scenarios have be pre-packaged. For example:

 * [Verification of Blazor components](https://github.com/VerifyTests/Verify.Blazor)
 * [Comparison of images via Phash](https://github.com/VerifyTests/Verify.Phash).
 * [Verification of web sites using Selenium](https://github.com/VerifyTests/Verify.Selenium).

See [All Verify extensions](https://github.com/VerifyTests/Verify#extensions).


## Project Details

* [Project Site](https://github.com/VerifyTests/Verify)
* Project License Type: [MIT](https://github.com/VerifyTests/Verify/blob/master/license.txt)
* Project Main Contacts: Simon Cropp. [GitHub](https://github.com/SimonCropp) [Twitter](https://twitter.com/SimonCropp)


## Quicklinks

* [Example Usage](https://github.com/VerifyTests/Verify#usage)
* [Snapshot testing compared to traditional assertion](https://github.com/VerifyTests/Verify/blob/master/docs/compared-to-assertion.md)