# dotnetfoundation-website

This repository contains the solution that is used to build and deploy the [dotnetfoundation](https://dotnetfoundation.org/) website.

Pull requests and issues are welcome!

## Prerequisites

* Git: Clone this repository to make a change.
* [.NET Core SDK 3.1.\*](https://dotnet.microsoft.com/download)
* Optional: [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/) for editing.

## Build and test

The basic steps to run or build the project:

1. Use `dotnet run` from the root of the repository to generate the static site.
1. After the build, check the `output` folder to review the generated HTML files.

To build and preview the site, run:

 ```
 dotnet run -- preview
 ```
 
The preceding command launches a preview web server that can be viewed from http://localhost:5080. The site automatically rebuilds and refreshes when content changes are made.

## Project Structure

This website uses [Statiq Web](https://github.com/statiqdev/Statiq.Web), a flexible and extensible static site generator for .NET.

* *App.Config* : The configuration file for the project. Review the `appSettings` section of *App.Config*.
* *Program.cs:*
    * Handles the generation of the site.
    <!-- consider deleting next line -->
    * Starts the web server when running from Visual Studio.
    * Defines the input folder and the output of static files.

* *input* : The *input* folder contains source files that are rendered as HTML files.
  * *_partials* folder contains small sections of code that are required in ther views, includes:
      * *_head.cshtml*: Contains the `head` section of the view and includes the initial stylesheet and JavaScript imports.
      * *_header.cshtml*: Common header used for views. Includes the main navigation.
      * *_footer.cshtml*: Common footer for views.
  * *_layout.cshtml*: Location where the page structure, include partials, nalytics code, and other imports are built.
  * *index.cshtml*: Main page for the site. Properties for the page can be efined at the top of the file. For example, a specific `title` for the page.
  * *css* folder contains all the stylesheet files required.
  * *js* folder contains the JavaScript libraries and other custom scripts.

Each file inside the *input* folder is processed by Statiq and will generate static output files.
