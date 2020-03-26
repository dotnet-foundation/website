# dotnetfoundation-website

This repository contains the solution that allows to build and deploy the [dotnetfoundation](https://dotnetfoundation.org/) website.

Pull requests and issues are welcome!

## Prerequisites

Following are listed the tools or programs that we need to build this project:

* Git: Clone this repository if you want to make any change.
* Visual Studio 2019 or later
* .NET Core 3.1.*

## How to build and test

Here are the basic steps to run or build the project.

1. Open Visual Studio.
1. From the top menu click the `File | Open | Project/Solution`.
1. Open `src\DotnetFoundationWeb\DotnetFoundationWeb.sln` from your local folder.
1. Click the `Play` button and wait for the app to start.
    > Note: A web server is started to test the generated files, check the console for the correct URL.
1. After the build, you can check the `output` folder to review the generated html files.

## Project Structure

[Statiq.Framework](https://github.com/statiqdev/Statiq.Framework) is a flexible and extensible static content generation framework for .NET.


* **App.Config**

    This is the configuration file for use by the project, make sure to review the `appSettings`.

* **Program.cs:**

    Class that handles the generation of the site and the start of the web server when running from Visual Studio, here is where we defined the input folder and the way to output our static files.
    The `input` folder contains source files and we are rendering to `html` files.

* **input**

    Here is where all the source files are and we may need to consider following notes for a better understanding of the generation.

    1. `_partials` folder contains small sections of code that we use in another pages, most important files are:
        * `_head.cshtml`: Contains the `head` section of the pages and includes the initial stylesheet and javascript imports for the pages.
        * `_header.cshtml`: Common header that we are using for all the pages and includes main navigation.
        * `_footer.cshtml`: Common footer for all the pages.
    1. `_layout.cshtml` is where we build the page structure, include the partials, add analytics code and additional imports.
    1. `index.cshtml` is our main page for the site and is a good example of how the other pages work.
    > Note: Properties for the page can be defined at the top of the file like a specific `title` for the page.
    1. `css` folder contains all the stylesheet file that we are been use in the site, import of this files are being done in the `_partials/_head.cshtml` file.
    1. `js` folder contains the javascript libraries and other custom files that are required.
    1. `data` folder contains different source of objects that are being used to build pages such as events or projects.

Each file inside the `input` folder is processed by Statiq and will generate static output files.

## Join us on Gitter

Community:
[![Gitter](https://badges.gitter.im/dotnet-foundation/election.svg)](https://gitter.im/dotnet-foundation/community?source=orgpage)

Conference: +
[![Gitter](https://badges.gitter.im/dotnet-foundation/election.svg)](https://gitter.im/dotnet-foundation/conference-chat?source=orgpage)

Election:
[![Gitter](https://badges.gitter.im/dotnet-foundation/election.svg)](https://gitter.im/dotnet-foundation/election?source=orgpage)
