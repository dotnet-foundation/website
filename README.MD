# dotnetfoundation-website

This repository contains the solution that allows to build and deploy the [dotnetfoundation](https://dotnetfoundation.org/) website.

Pull requests and issues are welcome!

## Prerequisites

Following are listed the tools or programs that we need to build this project:

* Git: Clone this repository if you want to make any change.
* [.NET Core SDK 3.1.*](https://dotnet.microsoft.com/download)
* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/) as editors (optional).

## How to build and test

Here are the basic steps to run or build the project.

1. In your terminal, navigate to `Generator`
1. Open `Generator` from your local folder.
1. Use `dotnet run` to generate the static site.
1. After the build, you can check the `output` folder to review the generated html files.

To build and preview the site, run `dotnet run -- preview`. This will launch a preview web server that can be viewed in a web browser from http://localhost:5080. The site will automatically rebuild and refresh when you make content changes.

## Project Structure

This website uses [Statiq Web](https://github.com/statiqdev/Statiq.Web), a flexible and extensible static site generator for .NET.

* **App.Config**

    This is the configuration file for use by the project, make sure to review the `appSettings`.

* **Program.cs:**

    Class that handles the generation of the site and the start of the web server when running from Visual Studio, here is where we defined the input folder and the way to output our static files.
    The `input` folder contains source files and we are rendering to `html` files.

* **input**

    1. `__data` folder contains files that are being used to build views such as events or projects.
    1. `_partials` folder contains small sections of code that we require in other views, includes:
        * `_head.cshtml`: Contains the `head` section of the view and includes the initial stylesheet and JavaScript imports.
        * `_header.cshtml`: Common header that we are using for views and includes the main navigation.
        * `_footer.cshtml`: Common footer for views.
    1. `_layout.cshtml` is where we build the page structure, include partials, analytics code and other additional imports.
    1. `index.cshtml` is the main page for the site.
        > Note: Properties for the page can be defined at the top of the file like a specific `title` for the page.
    1. `css` folder contains all the stylesheet files required.
    1. `js` folder contains the JavaScript libraries and other custom scripts.

Each file inside the `input` folder is processed by Statiq and will generate static output files.
