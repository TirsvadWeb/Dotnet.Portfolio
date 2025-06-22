[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

# Portfolio

# ![Logo][logo] Portfolio

A personal portfolio website built from scratch using [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) and .NET 9.

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Download](#download)
  - [Default user](#default-user)
- [Customization](#customization)
  - [Change default user and password](#change-default-user-and-password)
  - [Update Pages Content](#update-pages-content)
  - [Add Your Projects and Skills](#add-your-projects-and-skills)
  - [Customize the Design](#customize-the-design)
  - [Add or Remove Pages](#add-or-remove-pages)
  - [Advanced Customization](#advanced-customization)
  - [Social Media Banner](#social-media-banner)
- [Releases](#releases)
- [📂 Project structure](#project-structure)
- [Create this structure and project](#create-this-structure-and-project)
  - [Powershell](#powershell)
  - [Bash](#bash)
- [License](#license)
- [Contact](#contact)
- [Acknowledgments](#acknowledgments)

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- IDE recommended [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

### Download

To quickly get started, you can download the latest version of this project directly from GitHub and extract it to your local machine using PowerShell.
Follow these steps:

1. **Download and extract the repository:**

    Open a PowerShell window and run the following commands.
    This will download the repository as a ZIP file, extract its contents, and remove the ZIP file afterward.

    ```powershell
    $repoUrl = "https://github.com/TirsvadWeb/Dotnet.Portfolio"
    $zipUrl = "$repoUrl/archive/refs/heads/master.zip"
    $zipFile = "Dotnet.Portfolio-master.zip"
    $extractPath = "Dotnet.Portfolio"

    Invoke-WebRequest -Uri $zipUrl -OutFile $zipFile
    Expand-Archive -Path $zipFile -DestinationPath .
    Remove-Item $zipFile

    Write-Host "Repository downloaded and extracted to .\$extractPath"
    ```

### Default user

username: root@localhost.com

password: Secr3t#

**MUST BE CHANGE IN PRODUCTION**

---

## Releases
Releases step by step for learning / easy following

| Version | Desciption | href |
|---------|------------|------|

---

## Project structure

**📂 Portfolio/Portfolio.Domain/**

Entetities, models and interfaces

**📂 Portfolio/Portfolio.Application/**

ViewModels and reposetories.

**📂 Portfolio/Portfolio.Infrastructure/**

Implement persistens data

**📂 Portfolio/Portfolio.WebUI/**

Main Blazor project (host/server for Blazor WebAssembly and server-side rendering).

**📂 Portfolio/Portfolio.Portfolio.WebUI.Client/**

Blazor WebAssembly client project.

**📂 Portfolio/images/**
Images used in documentation.

**📂 Portfolio/documentation/dozygen**

**📂 Portfolio/documentation/artifact**

---

## License

Distributed under the GPL-3.0 [License][license-url].

---

## Contact

Jens Tirsvad Nielsen - [LinkedIn][linkedin-url]

---

## Acknowledgments

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[contributors-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[forks-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/network/members
[stars-shield]: https://img.shields.io/github/stars/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[stars-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/stargazers
[issues-shield]: https://img.shields.io/github/issues/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[issues-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/issues
[license-shield]: https://img.shields.io/github/license/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[license-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/jens-tirsvad-nielsen-13b795b9/
[githubIssue-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/issues/
[repos-size-shield]: https://img.shields.io/github/repo-size/TirsvadWeb/Dotnet.Portfolio?style=for-the-badg

[logo]: https://raw.githubusercontent.com/TirsvadWeb/Dotnet.Portfolio/master/images/logo/32x32/logo.png