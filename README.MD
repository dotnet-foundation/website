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

1. In your terminal, nagivate to `src\DotnetFoundationWeb`
1. Open `src\DotnetFoundationWeb` from your local folder.
1. Use `dotnet run` to generatethe static site
1. After the build, you can check the `output` folder to review the generated html files.

Any webserver pointed at the folder output folder should work. If you need one, you can use `dotnet-serve`. Install with `dotnet tool install -g dotnet-serve`

Navigigate to the output directory and run `dotnet-serve --default-extensions:html`, then you can nagivate to `http://localhost:8080` to see the site.

One tip is to keep `dotnet-serve` running in one terminal instance and use another to re-run `dotnet build` on the main project to generate updates.

## Project Structure

[Statiq.Framework](https://github.com/statiqdev/Statiq.Framework) is a flexible and extensible static content generation framework for .NET.

* **App.Config**

    This is the configuration file for use by the project, make sure to review the `appSettings`.

* **Program.cs:**

    Class that handles the generation of the site and the start of the web server when running from Visual Studio, here is where we defined the input folder and the way to output our static files.
    The `input` folder contains source files and we are rendering to `html` files.

* **input**

    1. `_partials` folder contains small sections of code that we require in other views, includes:
        * `_head.cshtml`: Contains the `head` section of the view and includes the initial stylesheet and javascript imports.
        * `_header.cshtml`: Common header that we are using for views and includes the main navigation.
        * `_footer.cshtml`: Common footer for views.
    1. `_layout.cshtml` is where we build the page structure, include partials, analytics code and other additional imports.
    1. `index.cshtml` is the main page for the site.
        > Note: Properties for the page can be defined at the top of the file like a specific `title` for the page.
    1. `css` folder contains all the stylesheet files required. 
    1. `js` folder contains the javascript libraries and other custom scripts.
    1. `data` folder contains files that are being used to build views such as events or projects.

Each file inside the `input` folder is processed by Statiq and will generate static output files.
